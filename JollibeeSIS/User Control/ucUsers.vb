Imports System.Data.SqlClient

Public Class ucUsers
    Private usersTable As New DataTable()

    Private Sub ucUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
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

    Public Sub LoadUsers()
        Try
            OpenConnection()
            ' Join with tblRoles to get the Role Name instead of just the ID
            Dim query As String = "SELECT u.UserID, u.Username, u.FullName, u.QRCodeData, r.RoleName, u.IsActive " &
                                  "FROM tblUsers u JOIN tblRoles r ON u.RoleID = r.RoleID"
            Dim adapter As New SqlDataAdapter(query, conn)
            usersTable.Clear()
            adapter.Fill(usersTable)
            dgvUsers.DataSource = usersTable

            ' --- 1. APPLY THE NEW STYLE ---
            StyleDataGridView(dgvUsers)

            ' --- 2. HIDE UNNECESSARY COLUMNS ---
            If dgvUsers.Columns.Contains("UserID") Then
                dgvUsers.Columns("UserID").Visible = False
            End If
            If dgvUsers.Columns.Contains("QRCodeData") Then
                dgvUsers.Columns("QRCodeData").Visible = False
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub txtSearchUser_TextChanged(sender As Object, e As EventArgs) Handles txtSearchUser.TextChanged
        Dim dv As New DataView(usersTable)
        Try
            dv.RowFilter = "FullName LIKE '%" & txtSearchUser.Text.Replace("'", "''") & "%'"
            dgvUsers.DataSource = dv
        Catch ex As Exception
            ' Ignore filter errors
        End Try
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim frm As New frmUserAddEdit()
        frm.UserID = 0 ' Set to Add Mode
        If frm.ShowDialog() = DialogResult.OK Then
            LoadUsers() ' Refresh the grid
        End If
    End Sub

    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        If dgvUsers.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a user to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedID As Integer = Convert.ToInt32(dgvUsers.CurrentRow.Cells("UserID").Value)

        Dim frm As New frmUserAddEdit()
        frm.UserID = selectedID ' Pass ID to trigger Edit Mode
        If frm.ShowDialog() = DialogResult.OK Then
            LoadUsers() ' Refresh the grid
        End If
    End Sub



    Private Sub btnShowQR_Click(sender As Object, e As EventArgs) Handles btnShowQR.Click
        If dgvUsers.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a user to show their QR Code.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim userName As String = dgvUsers.CurrentRow.Cells("FullName").Value.ToString()
        Dim qrData As String = dgvUsers.CurrentRow.Cells("QRCodeData").Value.ToString()

        Dim frm As New frmShowQR()
        frm.UserName = userName
        frm.QRCodeData = qrData
        frm.ShowDialog()
    End Sub
End Class