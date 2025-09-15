Imports System.Data.SqlClient
Imports System.IO
' --- 1. ADD THIS IMPORT FOR CURRENCY FORMATTING ---
Imports System.Globalization

Public Class ucPOS

    ' --- 2. ADD THE PHILIPPINE CULTURE INFO FOR THE PESO SYMBOL ---
    Private ReadOnly PH_CULTURE As New CultureInfo("en-PH")

    Private Sub ucPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup the DataGridView for the cart
        txtBarcode.Focus()
        SetupCartGrid()
        ' Load all product cards
        LoadProducts()
    End Sub

    Private Sub SetupCartGrid()
        dgvCart.ColumnCount = 5
        dgvCart.Columns(0).Name = "ID"
        dgvCart.Columns(1).Name = "Product"
        dgvCart.Columns(2).Name = "Qty"
        dgvCart.Columns(3).Name = "Price"
        dgvCart.Columns(4).Name = "Total"

        ' --- 3. APPLY THE GLOBAL STYLE FIRST ---
        StyleDataGridView(dgvCart)

        ' --- 4. APPLY SPECIFIC OVERRIDES FOR THIS GRID ---
        dgvCart.Columns("ID").Visible = False ' Hide the ProductID column from the user
        dgvCart.Columns("Product").FillWeight = 150 ' Give more space to the product name
        dgvCart.Columns("Qty").Width = 60
        dgvCart.Columns("Price").Width = 80
        dgvCart.Columns("Total").Width = 80
    End Sub

    Public Sub StyleDataGridView(ByVal dgv As Guna.UI2.WinForms.Guna2DataGridView)
        ' Define your brand colors
        Dim jollibeeRed As Color = Color.FromArgb(218, 0, 27)
        Dim jollibeeBlack As Color = Color.FromArgb(54, 54, 54)
        Dim lightGray As Color = Color.FromArgb(249, 249, 249) ' For alternating rows
        Dim selectionColor As Color = Color.FromArgb(254, 237, 238) ' A very light Jollibee red

        ' --- GENERAL STYLE ---
        dgv.BorderStyle = BorderStyle.None
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv.BackgroundColor = Color.White
        dgv.RowHeadersVisible = False
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AllowUserToResizeRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' --- HEADER STYLE ---
        dgv.ColumnHeadersVisible = True ' THIS IS THE MOST IMPORTANT FIX
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = jollibeeBlack
        dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgv.ColumnHeadersDefaultCellStyle.BackColor
        dgv.ColumnHeadersHeight = 40
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv.EnableHeadersVisualStyles = False

        ' --- ROW STYLE ---
        dgv.RowsDefaultCellStyle.BackColor = Color.White
        dgv.RowsDefaultCellStyle.Font = New Font("Segoe UI", 9.0F)
        dgv.RowsDefaultCellStyle.ForeColor = jollibeeBlack
        dgv.RowsDefaultCellStyle.SelectionBackColor = selectionColor
        dgv.RowsDefaultCellStyle.SelectionForeColor = jollibeeBlack
        dgv.RowTemplate.Height = 35

        ' --- ALTERNATING ROW STYLE ---
        dgv.AlternatingRowsDefaultCellStyle.BackColor = lightGray
        dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = selectionColor

        ' --- GRID COLOR ---
        dgv.GridColor = Color.FromArgb(231, 229, 255)
    End Sub

    Private Sub UpdateCartTotals()
        Dim subtotal As Decimal = 0
        For Each row As DataGridViewRow In dgvCart.Rows
            ' Add this check to prevent errors on the empty "new row"
            If Not row.IsNewRow Then
                subtotal += CDec(row.Cells("Total").Value)
            End If
        Next

        Dim taxRate As Decimal = 0.12 ' 12% VAT
        Dim tax As Decimal = subtotal * taxRate
        Dim total As Decimal = subtotal + tax

        ' --- 5. USE THE PHILIPPINE CULTURE FOR CORRECT CURRENCY SYMBOL ---
        lblSubtotal.Text = "Subtotal: " & subtotal.ToString("C", PH_CULTURE)
        lblTax.Text = "Tax (12%): " & tax.ToString("C", PH_CULTURE)
        lblTotal.Text = total.ToString("C", PH_CULTURE) ' This will now show ₱ symbol
    End Sub

    ' The rest of your code (LoadProducts, AddItemToCart, SaveSale, etc.)
    ' remains perfectly fine and does not need to be changed.
    ' I have included it below for a complete, copy-paste-ready solution.

    Private Sub LoadProducts()
        flpProducts.Controls.Clear() ' Clear existing products before loading

        Try
            OpenConnection()
            Dim query As String = "SELECT ProductID, ProductName, Price, ImagePath FROM tblProducts WHERE StockQuantity > 0"
            Dim cmd As New SqlCommand(query, conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim card As New ucProductCard()
                card.ProductID = CInt(reader("ProductID"))
                card.ProductName = reader("ProductName").ToString()
                card.ProductPrice = CDec(reader("Price"))

                ' Load image safely
                Dim imagePath As String = reader("ImagePath").ToString()
                If Not String.IsNullOrEmpty(imagePath) AndAlso File.Exists(imagePath) Then
                    card.ProductImage = Image.FromFile(imagePath)
                Else
                    ' Optional: Set a default placeholder image if none exists
                    ' card.ProductImage = My.Resources.placeholder
                End If

                ' IMPORTANT: Handle the custom event from the card
                AddHandler card.ProductClicked, AddressOf ProductCard_Clicked

                flpProducts.Controls.Add(card)
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub ProductCard_Clicked(sender As Object, e As EventArgs)
        Dim clickedCard As ucProductCard = CType(sender, ucProductCard)
        AddItemToCart(clickedCard.ProductID, clickedCard.ProductName, clickedCard.ProductPrice)
    End Sub

    Private Sub AddItemToCart(id As Integer, name As String, price As Decimal)
        For Each row As DataGridViewRow In dgvCart.Rows
            If Not row.IsNewRow AndAlso CInt(row.Cells("ID").Value) = id Then
                row.Cells("Qty").Value = CInt(row.Cells("Qty").Value) + 1
                row.Cells("Total").Value = CInt(row.Cells("Qty").Value) * CDec(row.Cells("Price").Value)
                UpdateCartTotals()
                Return
            End If
        Next
        dgvCart.Rows.Add(id, name, 1, price, price)
        UpdateCartTotals()
    End Sub

    Private Sub SaveSale()
        Dim transaction As SqlTransaction = Nothing
        Try
            OpenConnection()
            transaction = conn.BeginTransaction()

            Dim receiptNumber As String = "RCPT" & DateTime.Now.ToString("yyyyMMddHHmmss")
            Dim totalAmount As Decimal = Decimal.Parse(lblTotal.Text.Replace("₱", ""), NumberStyles.Currency, PH_CULTURE)

            Dim masterQuery As String = "INSERT INTO tblSalesMaster (ReceiptNumber, TotalAmount, UserID) VALUES (@Receipt, @Total, @UserID); SELECT SCOPE_IDENTITY();"
            Dim masterCmd As New SqlCommand(masterQuery, conn, transaction)
            masterCmd.Parameters.AddWithValue("@Receipt", receiptNumber)
            masterCmd.Parameters.AddWithValue("@Total", totalAmount)
            masterCmd.Parameters.AddWithValue("@UserID", modGlobal.CurrentUserID)
            Dim newSaleID As Integer = Convert.ToInt32(masterCmd.ExecuteScalar())

            For Each row As DataGridViewRow In dgvCart.Rows
                If Not row.IsNewRow Then
                    Dim productID As Integer = CInt(row.Cells("ID").Value)
                    Dim qty As Integer = CInt(row.Cells("Qty").Value)
                    Dim price As Decimal = CDec(row.Cells("Price").Value)

                    Dim detailQuery As String = "INSERT INTO tblSalesDetail (SaleID, ProductID, Quantity, PriceAtTimeOfSale) VALUES (@SaleID, @ProductID, @Qty, @Price)"
                    Dim detailCmd As New SqlCommand(detailQuery, conn, transaction)
                    detailCmd.Parameters.AddWithValue("@SaleID", newSaleID)
                    detailCmd.Parameters.AddWithValue("@ProductID", productID)
                    detailCmd.Parameters.AddWithValue("@Qty", qty)
                    detailCmd.Parameters.AddWithValue("@Price", price)
                    detailCmd.ExecuteNonQuery()

                    Dim stockQuery As String = "UPDATE tblProducts SET StockQuantity = StockQuantity - @Qty WHERE ProductID = @ProductID"
                    Dim stockCmd As New SqlCommand(stockQuery, conn, transaction)
                    stockCmd.Parameters.AddWithValue("@Qty", qty)
                    stockCmd.Parameters.AddWithValue("@ProductID", productID)
                    stockCmd.ExecuteNonQuery()
                End If
            Next

            transaction.Commit()
            MessageBox.Show("Sale completed successfully! Receipt #: " & receiptNumber, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvCart.Rows.Clear()
            UpdateCartTotals()
        Catch ex As Exception
            If transaction IsNot Nothing Then transaction.Rollback()
            MessageBox.Show("An error occurred during the sale. The transaction was rolled back. Error: " & ex.Message, "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Function AreCartItemsValid() As Boolean
        Dim productIDs As New List(Of String)
        For Each row As DataGridViewRow In dgvCart.Rows
            If Not row.IsNewRow Then
                productIDs.Add(row.Cells("ID").Value.ToString())
            End If
        Next
        If productIDs.Count = 0 Then Return True
        Try
            OpenConnection()
            Dim query As String = "SELECT COUNT(*) FROM tblProducts WHERE ProductID IN (" & String.Join(",", productIDs.ToArray()) & ")"
            Dim cmd As New SqlCommand(query, conn)
            Dim existingItemCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If existingItemCount < productIDs.Count Then
                MessageBox.Show("One or more items in the cart are no longer available in the inventory. Please clear the cart and re-add the items.", "Item Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Error verifying cart items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim realItemCount As Integer = 0
        For Each row As DataGridViewRow In dgvCart.Rows
            If Not row.IsNewRow Then
                realItemCount += 1
            End If
        Next
        If realItemCount = 0 Then
            MessageBox.Show("Cart is empty. Please add items first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not AreCartItemsValid() Then Return

        Dim total As Decimal = Decimal.Parse(lblTotal.Text, NumberStyles.Currency, PH_CULTURE)
        Dim frm As New frmPayment()
        frm.TotalAmount = total
        If frm.ShowDialog() = DialogResult.OK Then
            SaveSale()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If MessageBox.Show("Are you sure you want to clear the cart?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            dgvCart.Rows.Clear()
            UpdateCartTotals()
        End If
    End Sub

    Private Sub txtBarcode_KeyPress(sender As Object, e As KeypressEventArgs) Handles txtBarcode.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Dim barcode As String = txtBarcode.Text.Trim()
            If Not String.IsNullOrEmpty(barcode) Then
                FindAndAddProductByBarcode(barcode)
                txtBarcode.Text = ""
            End If
        End If
    End Sub

    Private Sub FindAndAddProductByBarcode(barcode As String)
        Try
            OpenConnection()
            Dim query As String = "SELECT ProductID, ProductName, Price FROM tblProducts WHERE Barcode = @Barcode AND StockQuantity > 0"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Barcode", barcode)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                Dim id As Integer = CInt(reader("ProductID"))
                Dim name As String = reader("ProductName").ToString()
                Dim price As Decimal = CDec(reader("Price"))
                reader.Close()
                AddItemToCart(id, name, price)
            Else
                reader.Close()
                MessageBox.Show("Product with barcode '" & barcode & "' not found or is out of stock.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error finding product by barcode: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

End Class