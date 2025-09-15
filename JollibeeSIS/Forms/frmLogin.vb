Imports System.Data.SqlClient
' --- NOTE: AForge and ZXing imports are no longer needed here ---

Public Class frmLogin

    Private Sub btnScanQR_Click(sender As Object, e As EventArgs) Handles btnScanQR.Click
        Dim scannerForm As New frmQRScanner()
        Me.Hide()
        If scannerForm.ShowDialog() = DialogResult.OK Then
            Dim qrData As String = scannerForm.ScannedData
            If Not String.IsNullOrEmpty(qrData) Then
                ' The LoginWithQRCode function will handle showing the form again on failure.
                LoginWithQRCode(qrData)
            Else
                ' If scanner returned OK but data is empty, just show the login form.
                Me.Show()
            End If
        Else
            ' If the user cancelled the scanner, show the login form.
            Me.Show()
        End If
    End Sub

    ' --- The rest of your login logic is UNCHANGED ---
    ' It works perfectly as is.

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        LoginWithPassword(txtUsername.Text, txtPassword.Text)
    End Sub

    Private Sub LoginWithPassword(username As String, password As String)
        Try
            OpenConnection()
            Dim query As String = "SELECT u.UserID, u.Username, u.PasswordHash, u.FullName, r.RoleName " &
                                  "FROM tblUsers u INNER JOIN tblRoles r ON u.RoleID = r.RoleID " &
                                  "WHERE u.Username = @Username AND u.IsActive = 1"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Username", username.Trim())
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                Dim dbPasswordHash As String = reader("PasswordHash").ToString()
                reader.Close()

                If BCrypt.Net.BCrypt.Verify(password, dbPasswordHash) Then
                    PerformSuccessfulLogin(query, cmd.Parameters)
                Else
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                reader.Close()
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub LoginWithQRCode(qrData As String)
        Try
            OpenConnection()
            Dim query As String = "SELECT u.UserID, u.Username, u.FullName, r.RoleName " &
                                  "FROM tblUsers u INNER JOIN tblRoles r ON u.RoleID = r.RoleID " &
                                  "WHERE u.QRCodeData = @QRCodeData AND u.IsActive = 1"

            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@QRCodeData", qrData)
            PerformSuccessfulLogin(query, cmd.Parameters)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub PerformSuccessfulLogin(query As String, Optional params As SqlParameterCollection = Nothing)
        ' (The top part of the function is the same...)
        Dim cmd As New SqlCommand(query, conn)
        If params IsNot Nothing Then
            For Each p As SqlParameter In params
                cmd.Parameters.Add(New SqlParameter(p.ParameterName, p.Value))
            Next
        End If
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            ' (Setting global variables is the same...)
            modGlobal.CurrentUserID = CInt(reader("UserID"))
            modGlobal.CurrentUsername = reader("Username").ToString()
            modGlobal.CurrentFullName = reader("FullName").ToString()
            modGlobal.CurrentRole = reader("RoleName").ToString()
            reader.Close()
            MessageBox.Show("Login Successful! Welcome, " & modGlobal.CurrentFullName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' --- THIS IS THE FIX ---
            ' 1. Hide the current login form. We will show it again on logout.
            Me.Hide()
            ' 2. Create and show the main form.
            Dim frm As New frmMain()
            frm.Show()

        Else
            reader.Close()
            MessageBox.Show("Invalid credentials or inactive account.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' On a failed login, we must re-show the login form if it was hidden by the scanner
            Me.Show()
        End If
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click, Label5.Click

    End Sub
End Class