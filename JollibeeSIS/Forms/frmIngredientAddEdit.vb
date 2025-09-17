Imports System.Data.SqlClient

Public Class frmIngredientAddEdit
    Public IngredientID As Integer = 0

    Private Sub frmIngredientAddEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IngredientID > 0 Then
            Me.Text = "Edit Ingredient"
            LoadIngredientDetails()
        Else
            Me.Text = "Add New Ingredient"
        End If
    End Sub

    Private Sub LoadIngredientDetails()
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM tblIngredients WHERE IngredientID = @ID"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ID", IngredientID)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txtIngredientName.Text = reader("IngredientName").ToString()
                numStock.Value = CDec(reader("StockQuantity"))
                txtUnit.Text = reader("UnitOfMeasure").ToString()
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading ingredient details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtIngredientName.Text) OrElse String.IsNullOrWhiteSpace(txtUnit.Text) Then
            MessageBox.Show("Ingredient Name and Unit of Measure are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            OpenConnection()
            Dim cmd As New SqlCommand()
            cmd.Connection = conn
            cmd.Parameters.AddWithValue("@Name", txtIngredientName.Text.Trim())
            cmd.Parameters.AddWithValue("@Stock", numStock.Value)
            cmd.Parameters.AddWithValue("@Unit", txtUnit.Text.Trim())

            If IngredientID = 0 Then
                cmd.CommandText = "INSERT INTO tblIngredients (IngredientName, StockQuantity, UnitOfMeasure) VALUES (@Name, @Stock, @Unit)"
            Else
                cmd.CommandText = "UPDATE tblIngredients SET IngredientName = @Name, StockQuantity = @Stock, UnitOfMeasure = @Unit WHERE IngredientID = @ID"
                cmd.Parameters.AddWithValue("@ID", IngredientID)
            End If

            cmd.ExecuteNonQuery()
            MessageBox.Show("Ingredient saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error saving ingredient: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class