Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & modGlobal.CurrentFullName & " (" & modGlobal.CurrentRole & ")"
        ApplyRBAC()

        ' Load the Dashboard by default when the main form opens
        Dim uc As New ucDashboard()
        LoadUserControl(uc)
    End Sub

    Private Sub ApplyRBAC()
        ' By default, let's assume all buttons are visible for Admin
        ' and then restrict access for other roles.
        Select Case modGlobal.CurrentRole
            Case "Manager"
                ' Manager can see everything except User Management
                btnUsers.Visible = False

            Case "Cashier"
                ' Cashier can only see the POS screen and logout
                btnDashboard.Visible = False
                btnInventory.Visible = False
                btnReports.Visible = False
                btnUsers.Visible = False
        End Select
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ' Reset global session variables
            modGlobal.CurrentUserID = 0
            modGlobal.CurrentUsername = ""
            modGlobal.CurrentFullName = ""
            modGlobal.CurrentRole = ""

            ' --- THIS IS THE FIX ---
            ' Find the single instance of frmLogin that is still running but hidden.
            ' Application.OpenForms("frmLogin") refers to a form by its NAME property.
            Dim loginForm As Form = Application.OpenForms("frmLogin")
            If loginForm IsNot Nothing Then
                loginForm.Show()
            Else
                ' This is a fallback in case something went wrong.
                Dim newLogin As New frmLogin()
                newLogin.Show()
            End If

            ' Simply close this main form. The login form is now visible,
            ' and the application will not exit because the login form is still open.
            Me.Close()
        End If
    End Sub

    Private Sub LoadUserControl(control As UserControl)
        pnlContent.Controls.Clear() ' Remove any existing control
        control.Location = New Point(0, 0) ' Position it at the top-left of the panel
        pnlContent.Controls.Add(control)
    End Sub

    Private Sub btnDashboard_Click(sender As System.Object, e As System.EventArgs) Handles btnDashboard.Click
        Dim uc As New ucDashboard()
        LoadUserControl(uc)
    End Sub

    Private Sub btnPOS_Click(sender As Object, e As EventArgs) Handles btnPOS.Click
        Dim uc As New ucPOS()
        LoadUserControl(uc)
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Dim uc As New ucInventory()
        LoadUserControl(uc)
    End Sub

    Private Sub btnReports_Click(sender As System.Object, e As System.EventArgs) Handles btnReports.Click
        Dim uc As New ucReports()
        LoadUserControl(uc)
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim uc As New ucUsers()
        LoadUserControl(uc)
    End Sub
End Class