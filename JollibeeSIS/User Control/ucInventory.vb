Imports System.Data.SqlClient

Public Class ucInventory

    Private productsTable As New DataTable()

    Private Sub ucInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' --- FIX 1: Call BOTH functions when the control loads ---
        LoadProducts()
        LoadCategoryFilter()
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

    Private Sub LoadCategoryFilter()
        Try
            OpenConnection()
            Dim adapter As New SqlDataAdapter("SELECT CategoryID, CategoryName FROM tblCategories ORDER BY CategoryName", conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Add an "All Categories" option at the top
            Dim allRow As DataRow = dt.NewRow()
            allRow("CategoryID") = 0
            allRow("CategoryName") = "-- All Categories --"
            dt.Rows.InsertAt(allRow, 0)

            cmbCategoryFilter.DataSource = dt
            cmbCategoryFilter.DisplayMember = "CategoryName"
            cmbCategoryFilter.ValueMember = "CategoryID"
        Catch ex As Exception
            MessageBox.Show("Error loading category filter: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Public Sub LoadProducts()
        Try
            OpenConnection()

            Dim query As String = "WITH CalculableStock AS (" & _
                                  "SELECT r.ProductID, MIN(FLOOR(i.StockQuantity / r.QuantityUsed)) AS CanMake " & _
                                  "FROM tblRecipes r JOIN tblIngredients i ON r.IngredientID = i.IngredientID " & _
                                  "WHERE r.QuantityUsed > 0 GROUP BY r.ProductID" & _
                                  ") SELECT p.ProductID, p.Barcode, p.ProductName, c.CategoryName, p.Description, p.Price, p.ImagePath, " & _
                                  "ISNULL(cs.CanMake, 0) AS [Stock (Can Make)] " & _
                                  "FROM tblProducts p LEFT JOIN tblCategories c ON p.CategoryID = c.CategoryID " & _
                                  "LEFT JOIN CalculableStock cs ON p.ProductID = cs.ProductID"

            Dim adapter As New SqlDataAdapter(query, conn)

            productsTable.Clear()
            adapter.Fill(productsTable)
            dgvProducts.DataSource = productsTable

            StyleDataGridView(dgvProducts)

            If dgvProducts.Columns.Contains("ProductID") Then dgvProducts.Columns("ProductID").Visible = False
            If dgvProducts.Columns.Contains("Description") Then dgvProducts.Columns("Description").Visible = False
            If dgvProducts.Columns.Contains("ImagePath") Then dgvProducts.Columns("ImagePath").Visible = False

        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub ApplyFilters()
        Dim dv As New DataView(productsTable)
        Dim filters As New List(Of String)

        ' Text search filter
        If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
            filters.Add(String.Format("(ProductName LIKE '%{0}%' OR Barcode LIKE '%{0}%')", txtSearch.Text.Replace("'", "''")))
        End If

        ' Category filter (This will now work correctly)
        If cmbCategoryFilter.SelectedIndex > 0 Then ' Index 0 is "-- All Categories --"
            filters.Add(String.Format("CategoryID = {0}", cmbCategoryFilter.SelectedValue))
        End If

        ' Combine filters
        dv.RowFilter = String.Join(" AND ", filters.ToArray())
        dgvProducts.DataSource = dv
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ApplyFilters()
    End Sub

    Private Sub cmbCategoryFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoryFilter.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New frmProductAddEdit()
        frm.ProductID = 0 ' Set to Add Mode
        If frm.ShowDialog() = DialogResult.OK Then
            LoadProducts() ' Refresh the grid after a successful addition
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvProducts.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a user to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedID As Integer = Convert.ToInt32(dgvProducts.CurrentRow.Cells("ProductID").Value)

        Dim frm As New frmProductAddEdit()
        frm.ProductID = selectedID ' Pass ID to trigger Edit Mode
        If frm.ShowDialog() = DialogResult.OK Then
            LoadProducts() ' Refresh the grid after a successful update
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvProducts.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a product to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this product? This action cannot be undone.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                Dim selectedID As Integer = Convert.ToInt32(dgvProducts.CurrentRow.Cells("ProductID").Value)
                OpenConnection()
                Dim query As String = "DELETE FROM tblProducts WHERE ProductID = @ID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", selectedID)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadProducts() ' Refresh the grid
            Catch ex As Exception
                MessageBox.Show("Error deleting product. It might be used in existing sales records. Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                CloseConnection()
            End Try
        End If
    End Sub
End Class