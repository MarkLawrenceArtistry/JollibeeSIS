Imports System.Data.SqlClient

Public Class frmRecipeManagement
    Public ProductID As Integer
    Public Shadows Property ProductName As String

    Private Sub frmRecipeManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Recipe Management"
        lblProductName.Text = Me.ProductName

        SetupRecipeGrid()
        ' --- FIX: Call the styling function here ---
        StyleDataGridView(dgvRecipe)

        LoadIngredientsDropdown()
        LoadRecipeForProduct()
    End Sub

    ' --- NEW: Add the complete styling function ---
    Public Sub StyleDataGridView(ByVal dgv As Guna.UI2.WinForms.Guna2DataGridView)
        Dim jollibeeRed As Color = Color.FromArgb(218, 0, 27)
        Dim jollibeeBlack As Color = Color.FromArgb(54, 54, 54)
        Dim lightGray As Color = Color.FromArgb(249, 249, 249)
        Dim selectionColor As Color = Color.FromArgb(254, 237, 238)
        dgv.BorderStyle = BorderStyle.None
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv.BackgroundColor = Color.White
        dgv.RowHeadersVisible = False
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AllowUserToResizeRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.ColumnHeadersVisible = True
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = jollibeeBlack
        dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgv.ColumnHeadersDefaultCellStyle.BackColor
        dgv.ColumnHeadersHeight = 40
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv.EnableHeadersVisualStyles = False
        dgv.RowsDefaultCellStyle.BackColor = Color.White
        dgv.RowsDefaultCellStyle.Font = New Font("Segoe UI", 9.0F)
        dgv.RowsDefaultCellStyle.ForeColor = jollibeeBlack
        dgv.RowsDefaultCellStyle.SelectionBackColor = selectionColor
        dgv.RowsDefaultCellStyle.SelectionForeColor = jollibeeBlack
        dgv.RowTemplate.Height = 35
        dgv.AlternatingRowsDefaultCellStyle.BackColor = lightGray
        dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = selectionColor
        dgv.GridColor = Color.FromArgb(231, 229, 255)
    End Sub

    Private Sub SetupRecipeGrid()
        dgvRecipe.ColumnCount = 4
        dgvRecipe.Columns(0).Name = "IngredientID"
        dgvRecipe.Columns(1).Name = "IngredientName"
        dgvRecipe.Columns(2).Name = "QuantityUsed"
        dgvRecipe.Columns(3).Name = "Unit"
        dgvRecipe.Columns("IngredientID").Visible = False
        dgvRecipe.Columns("IngredientName").HeaderText = "Ingredient"
        dgvRecipe.Columns("QuantityUsed").HeaderText = "Qty Used"
        dgvRecipe.Columns("Unit").HeaderText = "Unit"
    End Sub

    Private Sub LoadIngredientsDropdown()
        Try
            OpenConnection()
            Dim adapter As New SqlDataAdapter("SELECT IngredientID, IngredientName + ' (' + UnitOfMeasure + ')' AS DisplayName FROM tblIngredients ORDER BY IngredientName", conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            cmbIngredients.DataSource = dt
            cmbIngredients.DisplayMember = "DisplayName"
            cmbIngredients.ValueMember = "IngredientID"
        Catch ex As Exception
            MessageBox.Show("Error loading ingredients list: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub LoadRecipeForProduct()
        Try
            OpenConnection()
            Dim query As String = "SELECT r.IngredientID, i.IngredientName, r.QuantityUsed, i.UnitOfMeasure " &
                                  "FROM tblRecipes r JOIN tblIngredients i ON r.IngredientID = i.IngredientID " &
                                  "WHERE r.ProductID = @ProductID"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ProductID", Me.ProductID)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            dgvRecipe.Rows.Clear()
            While reader.Read()
                dgvRecipe.Rows.Add(reader("IngredientID"), reader("IngredientName"), reader("QuantityUsed"), reader("UnitOfMeasure"))
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading recipe: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnAddIngredient_Click(sender As Object, e As EventArgs) Handles btnAddIngredient.Click
        If cmbIngredients.SelectedValue Is Nothing OrElse numQuantityUsed.Value <= 0 Then
            MessageBox.Show("Please select an ingredient and specify a quantity greater than zero.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedIngredientID As Integer = CType(cmbIngredients.SelectedValue, Integer)

        For Each row As DataGridViewRow In dgvRecipe.Rows
            If Not row.IsNewRow AndAlso CInt(row.Cells("IngredientID").Value) = selectedIngredientID Then
                MessageBox.Show("This ingredient is already in the recipe.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        Next

        Dim selectedRowView As DataRowView = CType(cmbIngredients.SelectedItem, DataRowView)
        Dim displayName As String = selectedRowView("DisplayName").ToString()
        Dim ingredientName As String = displayName.Substring(0, displayName.LastIndexOf(" ("))
        Dim unit As String = displayName.Substring(displayName.LastIndexOf(" (") + 2).TrimEnd(")"c)

        dgvRecipe.Rows.Add(selectedIngredientID, ingredientName, numQuantityUsed.Value, unit)
    End Sub

    Private Sub btnRemoveIngredient_Click(sender As Object, e As EventArgs) Handles btnRemoveIngredient.Click
        If dgvRecipe.CurrentRow IsNot Nothing Then
            dgvRecipe.Rows.Remove(dgvRecipe.CurrentRow)
        Else
            MessageBox.Show("Please select an ingredient from the recipe to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnSaveRecipe_Click(sender As Object, e As EventArgs) Handles btnSaveRecipe.Click
        Dim transaction As SqlTransaction = Nothing
        Try
            OpenConnection()
            transaction = conn.BeginTransaction()

            Dim deleteCmd As New SqlCommand("DELETE FROM tblRecipes WHERE ProductID = @ProductID", conn, transaction)
            deleteCmd.Parameters.AddWithValue("@ProductID", Me.ProductID)
            deleteCmd.ExecuteNonQuery()

            For Each row As DataGridViewRow In dgvRecipe.Rows
                If Not row.IsNewRow Then
                    Dim insertCmd As New SqlCommand("INSERT INTO tblRecipes (ProductID, IngredientID, QuantityUsed) VALUES (@ProductID, @IngredientID, @QuantityUsed)", conn, transaction)
                    insertCmd.Parameters.AddWithValue("@ProductID", Me.ProductID)
                    insertCmd.Parameters.AddWithValue("@IngredientID", CInt(row.Cells("IngredientID").Value))
                    insertCmd.Parameters.AddWithValue("@QuantityUsed", CDec(row.Cells("QuantityUsed").Value))
                    insertCmd.ExecuteNonQuery()
                End If
            Next

            transaction.Commit()
            MessageBox.Show("Recipe saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            If transaction IsNot Nothing Then transaction.Rollback()
            MessageBox.Show("Error saving recipe: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class