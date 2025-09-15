Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class ucReports

    Private Sub btnToday_Click(sender As Object, e As EventArgs) Handles btnToday.Click
        dtpStartDate.Value = DateTime.Today
        dtpEndDate.Value = DateTime.Today
    End Sub

    Private Sub btnThisWeek_Click(sender As Object, e As EventArgs) Handles btnThisWeek.Click
        dtpStartDate.Value = DateTime.Today.AddDays(-(DateTime.Today.DayOfWeek))
        dtpEndDate.Value = DateTime.Today
    End Sub

    Private Sub btnThisMonth_Click(sender As Object, e As EventArgs) Handles btnThisMonth.Click
        dtpStartDate.Value = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        dtpEndDate.Value = DateTime.Today
    End Sub

    ' --- NEW: Add the click event handler for the "This Year" button ---
    Private Sub btnThisYear_Click(sender As Object, e As EventArgs) Handles btnThisYear.Click
        ' Set the start date to January 1st of the current year
        dtpStartDate.Value = New DateTime(DateTime.Today.Year, 1, 1)
        ' Set the end date to today
        dtpEndDate.Value = DateTime.Today
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        ' Create a new, empty instance of our report DataSet
        Dim ds As New dsReports()

        Try
            OpenConnection()

            ' --- STEP 1: Get the Master Sales records for the selected date range ---
            Dim salesMasterQuery As String = "SELECT * FROM tblSalesMaster WHERE SaleDate BETWEEN @StartDate AND @EndDate"
            Dim masterAdapter As New SqlDataAdapter(salesMasterQuery, conn)
            masterAdapter.SelectCommand.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date)
            masterAdapter.SelectCommand.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date.AddDays(1))

            ' Fill ONLY the tblSalesMaster table in our DataSet
            masterAdapter.Fill(ds, "tblSalesMaster")

            ' --- STEP 2: Now that we have the master sales, get ALL related data ---
            ' It's easier and efficient enough to load all details, products, and users,
            ' as Crystal Reports will filter them based on the relationships.

            Dim salesDetailAdapter As New SqlDataAdapter("SELECT * FROM tblSalesDetail", conn)
            salesDetailAdapter.Fill(ds, "tblSalesDetail")

            Dim productsAdapter As New SqlDataAdapter("SELECT * FROM tblProducts", conn)
            productsAdapter.Fill(ds, "tblProducts")

            Dim usersAdapter As New SqlDataAdapter("SELECT * FROM tblUsers", conn)
            usersAdapter.Fill(ds, "tblUsers")

        Catch ex As Exception
            MessageBox.Show("Error fetching report data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Finally
            CloseConnection()
        End Try

        ' --- Generate and Show Report ---
        If ds.tblSalesMaster.Rows.Count = 0 Then
            MessageBox.Show("No sales data found for the selected period.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim rpt As New rptSales()
        Dim frm As New frmReportViewer()

        ' --- THIS IS THE KEY ---
        ' Give Crystal Reports the ENTIRE DataSet. It knows how to use the
        ' relationships we defined in the .xsd file to link the tables together.
        rpt.SetDataSource(ds)

        frm.Report = rpt
        frm.ShowDialog()
    End Sub
End Class