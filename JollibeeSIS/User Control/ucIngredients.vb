Imports System.Data.SqlClient

Public Class ucIngredients

    Private ingredientsTable As New DataTable()

    Private Sub ucIngredients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadIngredients()
    End Sub

    Public Sub LoadIngredients()
        Try
            OpenConnection()
            Dim query As String = "SELECT IngredientID, IngredientName, StockQuantity, UnitOfMeasure FROM tblIngredients"
            Dim adapter As New SqlDataAdapter(query, conn)

            ingredientsTable.Clear()
            adapter.Fill(ingredientsTable)
            dgvIngredients.DataSource = ingredientsTable
            StyleDataGridView(dgvIngredients)

            If dgvIngredients.Columns.Contains("IngredientID") Then dgvIngredients.Columns("IngredientID").Visible = False

        Catch ex As Exception
            MessageBox.Show("Error loading ingredients: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dv As New DataView(ingredientsTable)
        Try
            dv.RowFilter = "IngredientName LIKE '%" & txtSearch.Text.Replace("'", "''") & "%'"
            dgvIngredients.DataSource = dv
        Catch ex As Exception
            ' Ignore filter errors
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New frmIngredientAddEdit()
        frm.IngredientID = 0 ' Add Mode
        If frm.ShowDialog() = DialogResult.OK Then
            LoadIngredients()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvIngredients.CurrentRow Is Nothing Then
            MessageBox.Show("Please select an ingredient to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedID As Integer = Convert.ToInt32(dgvIngredients.CurrentRow.Cells("IngredientID").Value)

        Dim frm As New frmIngredientAddEdit()
        frm.IngredientID = selectedID ' Edit Mode
        If frm.ShowDialog() = DialogResult.OK Then
            LoadIngredients()
        End If
    End Sub

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
End Class