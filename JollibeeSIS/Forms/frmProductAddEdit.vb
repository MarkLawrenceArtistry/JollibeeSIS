Imports System.Data.SqlClient
Imports System.IO
Imports ZXing

Public Class frmProductAddEdit

    ' Public properties to control the form's behavior
    Public ProductID As Integer = 0 ' If 0, it's "Add" mode. If > 0, it's "Edit" mode.
    Private newImagePath As String = "" ' To store the path of a newly selected image

    Private Sub frmProductAddEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' --- THIS IS THE FIX ---
        ' Load the categories into the dropdown first, before doing anything else.
        LoadCategories()

        If ProductID > 0 Then
            ' --- EDIT MODE ---
            Me.Text = "Edit Product"
            LoadProductDetails() ' This will now be able to set the selected category
        Else
            ' --- ADD MODE ---
            Me.Text = "Add New Product"
            txtBarcode.Text = "(Will be generated on save)"
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
                numStock.Value = CInt(reader("StockQuantity"))
                txtBarcode.Text = reader("Barcode").ToString()

                If reader("CategoryID") IsNot DBNull.Value Then
                    cmbCategory.SelectedValue = CInt(reader("CategoryID"))
                End If

                ' --- Generate and display the barcode for the existing item ---
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

    Private Sub GenerateBarcodeImage(barcodeData As String)
        Try
            Dim writer As New BarcodeWriter()
            writer.Format = BarcodeFormat.CODE_128 ' A very common and versatile format
            writer.Options.Width = picBarcode.Width
            writer.Options.Height = picBarcode.Height
            writer.Options.Margin = 2 ' Add a little whitespace
            picBarcode.Image = writer.Write(barcodeData)
        Catch ex As Exception
            ' If it fails, just show a blank image
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' --- Input Validation ---
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
            cmd.Parameters.AddWithValue("@Stock", numStock.Value)
            cmd.Parameters.AddWithValue("@CategoryID", cmbCategory.SelectedValue)

            ' Decide which image path to save
            Dim finalImagePath As String = ""
            If Not String.IsNullOrEmpty(newImagePath) Then
                finalImagePath = newImagePath ' User selected a new image
            ElseIf picProductImage.Tag IsNot Nothing Then
                finalImagePath = picProductImage.Tag.ToString() ' User didn't change the image
            End If
            cmd.Parameters.AddWithValue("@Path", finalImagePath)

            If ProductID = 0 Then
                ' --- INSERT (ADD) LOGIC ---
                ' We need a unique barcode. For simplicity, we'll generate one.
                Dim barcode As String = DateTime.Now.ToString("yyyyMMddHHmmss")
                cmd.CommandText = "INSERT INTO tblProducts (Barcode, ProductName, Description, Price, StockQuantity, ImagePath, CategoryID) " &
                                  "VALUES (@Barcode, @Name, @Desc, @Price, @Stock, @Path, @CategoryID)"
                cmd.Parameters.AddWithValue("@Barcode", barcode)
            Else
                ' --- MODIFIED: Add CategoryID to the UPDATE statement ---
                cmd.CommandText = "UPDATE tblProducts SET ProductName = @Name, Description = @Desc, " &
                                  "Price = @Price, StockQuantity = @Stock, ImagePath = @Path, CategoryID = @CategoryID " &
                                  "WHERE ProductID = @ID"
                cmd.Parameters.AddWithValue("@ID", ProductID)
            End If

            cmd.ExecuteNonQuery()
            MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error saving product: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
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