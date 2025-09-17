Imports System.Data.SqlClient
Imports System.IO
Imports ZXing

Public Class frmProductAddEdit

    Public ProductID As Integer = 0
    Private newImagePath As String = ""

    Private Sub frmProductAddEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()

        If ProductID > 0 Then
            ' --- EDIT MODE ---
            Me.Text = "Edit Product"
            LoadProductDetails()
            btnManageRecipe.Enabled = True ' Can manage recipe for existing product
        Else
            ' --- ADD MODE ---
            Me.Text = "Add New Product"
            txtBarcode.Text = "(Will be generated on save)"
            ' You cannot manage a recipe for a product that hasn't been saved yet.
            btnManageRecipe.Enabled = False
        End If
    End Sub

    Private Sub LoadProductDetails()
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM tblProducts WHERE ProductID = @ID"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ID", ProductID)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txtProductName.Text = reader("ProductName").ToString()
                txtDescription.Text = reader("Description").ToString()
                txtPrice.Text = CDec(reader("Price")).ToString()
                txtBarcode.Text = reader("Barcode").ToString()
                If reader("CategoryID") IsNot DBNull.Value Then
                    cmbCategory.SelectedValue = CInt(reader("CategoryID"))
                End If
                If Not String.IsNullOrEmpty(txtBarcode.Text) Then
                    GenerateBarcodeImage(txtBarcode.Text)
                End If
                picProductImage.Tag = reader("ImagePath").ToString()
                If Not String.IsNullOrEmpty(picProductImage.Tag.ToString()) AndAlso File.Exists(picProductImage.Tag.ToString()) Then
                    picProductImage.Image = Image.FromFile(picProductImage.Tag.ToString())
                End If
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading product details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtProductName.Text) Then
            MessageBox.Show("Product Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim price As Decimal
        If Not Decimal.TryParse(txtPrice.Text, price) OrElse price < 0 Then
            MessageBox.Show("Please enter a valid, non-negative price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            OpenConnection()
            Dim cmd As New SqlCommand()
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@Name", txtProductName.Text.Trim())
            cmd.Parameters.AddWithValue("@Desc", txtDescription.Text.Trim())
            cmd.Parameters.AddWithValue("@Price", price)
            cmd.Parameters.AddWithValue("@CategoryID", cmbCategory.SelectedValue)

            Dim finalImagePath As String = ""
            If Not String.IsNullOrEmpty(newImagePath) Then
                finalImagePath = newImagePath
            ElseIf picProductImage.Tag IsNot Nothing Then
                finalImagePath = picProductImage.Tag.ToString()
            End If
            cmd.Parameters.AddWithValue("@Path", finalImagePath)

            If ProductID = 0 Then
                ' --- INSERT SQL (StockQuantity is GONE) ---
                Dim barcode As String = DateTime.Now.ToString("yyyyMMddHHmmss")
                cmd.CommandText = "INSERT INTO tblProducts (Barcode, ProductName, Description, Price, ImagePath, CategoryID) " &
                                  "VALUES (@Barcode, @Name, @Desc, @Price, @Path, @CategoryID); SELECT SCOPE_IDENTITY();"
                cmd.Parameters.AddWithValue("@Barcode", barcode)
                ProductID = CInt(cmd.ExecuteScalar())
                Me.Text = "Edit Product"
                btnManageRecipe.Enabled = True
                MessageBox.Show("Product saved successfully! You can now manage its recipe.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' --- UPDATE SQL (StockQuantity is GONE) ---
                cmd.CommandText = "UPDATE tblProducts SET ProductName = @Name, Description = @Desc, " &
                                  "Price = @Price, ImagePath = @Path, CategoryID = @CategoryID " &
                                  "WHERE ProductID = @ID"
                cmd.Parameters.AddWithValue("@ID", ProductID)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error saving product: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' --- NEW: Event handler for the Manage Recipe button ---
    Private Sub btnManageRecipe_Click(sender As Object, e As EventArgs) Handles btnManageRecipe.Click
        Dim frm As New frmRecipeManagement()
        frm.ProductID = Me.ProductID
        frm.ProductName = txtProductName.Text
        frm.ShowDialog()
    End Sub

    Private Sub GenerateBarcodeImage(barcodeData As String)
        Try
            Dim writer As New BarcodeWriter()
            writer.Format = BarcodeFormat.CODE_128
            writer.Options.Width = picBarcode.Width
            writer.Options.Height = picBarcode.Height
            writer.Options.Margin = 2
            picBarcode.Image = writer.Write(barcodeData)
        Catch ex As Exception
            picBarcode.Image = Nothing
        End Try
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png"
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            newImagePath = openFileDialog1.FileName
            picProductImage.Image = Image.FromFile(newImagePath)
        End If
    End Sub

    Private Sub LoadCategories()
        Try
            OpenConnection()
            Dim adapter As New SqlDataAdapter("SELECT CategoryID, CategoryName FROM tblCategories ORDER BY CategoryName", conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            cmbCategory.DataSource = dt
            cmbCategory.DisplayMember = "CategoryName"
            cmbCategory.ValueMember = "CategoryID"
        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class