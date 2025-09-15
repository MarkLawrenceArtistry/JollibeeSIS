Imports System.Data.SqlClient

Module modGlobal
    '--- DATABASE CONNECTION ---
    ' Make sure to change 'YOUR_SERVER_NAME' to your SQL Server instance name (e.g., "DESKTOP-123\SQLEXPRESS").
    ' Change 'JollibeeSIS_DB' if you used a different database name.
    Public conn As New SqlConnection("Server=DESKTOP-P0Q63D3\SQLEXPRESS2010;Database=JollibeeSIS_DB;Integrated Security=True;")

    '--- CURRENT USER SESSION ---
    ' We will populate these variables after a successful login.
    Public CurrentUserID As Integer
    Public CurrentUsername As String
    Public CurrentFullName As String
    Public CurrentRole As String

    ' A reusable function to open the database connection
    Public Sub OpenConnection()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    ' A reusable function to close the database connection
    Public Sub CloseConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub


End Module