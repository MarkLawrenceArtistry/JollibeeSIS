Imports System.Data.SqlClient

Public Class frmUserAddEdit
    Public UserID As Integer = 0 ' 0 for Add, >0 for Edit

    Private Sub frmUserAddEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRoles()
        If UserID > 0 Then
            Me.Text = "Edit User"
            LoadUserDetails()
        Else
            Me.Text = "Add New User"
            tsActive.Checked = True ' Default to active for new users
        End If
    End Sub

    Private Sub LoadRoles()
        Try
            OpenConnection()
            Dim adapter As New SqlDataAdapter("SELECT RoleID, RoleName FROM tblRoles", conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Configure the ComboBox
            cmbRole.DataSource = dt
            cmbRole.DisplayMember = "RoleName"
            cmbRole.ValueMember = "RoleID"
        Catch ex As Exception
            MessageBox.Show("Error loading roles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' --- COMPLETE CODE ADDED HERE ---
    Private Sub LoadUserDetails()
        Try
            OpenConnection()
            Dim query As String = "SELECT * FROM tblUsers WHERE UserID = @ID"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ID", UserID)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txtFullName.Text = reader("FullName").ToString()
                txtUsername.Text = reader("Username").ToString()
                cmbRole.SelectedValue = CInt(reader("RoleID"))
                tsActive.Checked = CBool(reader("IsActive"))
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' --- Validation ---
        If String.IsNullOrWhiteSpace(txtFullName.Text) OrElse String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("Full Name and Username are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If UserID = 0 AndAlso String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Password is required for new users.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            OpenConnection()
            Dim cmd As New SqlCommand()
            cmd.Connection = conn

            cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim())
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
            cmd.Parameters.AddWithValue("@RoleID", cmbRole.SelectedValue)
            cmd.Parameters.AddWithValue("@IsActive", tsActive.Checked)

            If UserID = 0 Then ' --- ADD MODE ---
                Dim passwordHash As String = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text)
                Dim qrData As String = "JFC_USER_" & DateTime.Now.Ticks.ToString() ' Generate unique QR data

                cmd.CommandText = "INSERT INTO tblUsers (Username, PasswordHash, FullName, RoleID, IsActive, QRCodeData) " &
                                  "VALUES (@Username, @PasswordHash, @FullName, @RoleID, @IsActive, @QRCodeData)"
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash)
                cmd.Parameters.AddWithValue("@QRCodeData", qrData)
            Else ' --- EDIT MODE ---
                cmd.Parameters.AddWithValue("@UserID", UserID)
                If Not String.IsNullOrWhiteSpace(txtPassword.Text) Then
                    ' --- UPDATE PASSWORD ---
                    Dim passwordHash As String = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text)
                    cmd.CommandText = "UPDATE tblUsers SET Username=@Username, PasswordHash=@PasswordHash, FullName=@FullName, " &
                                      "RoleID=@RoleID, IsActive=@IsActive WHERE UserID=@UserID"
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash)
                Else
                    ' --- DO NOT UPDATE PASSWORD ---
                    cmd.CommandText = "UPDATE tblUsers SET Username=@Username, FullName=@FullName, " &
                                      "RoleID=@RoleID, IsActive=@IsActive WHERE UserID=@UserID"
                End If
            End If

            cmd.ExecuteNonQuery()
            MessageBox.Show("User saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error saving user: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class