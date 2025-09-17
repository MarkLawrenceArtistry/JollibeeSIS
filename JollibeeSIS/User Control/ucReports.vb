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

    Private Sub btnThisYear_Click(sender As Object, e As EventArgs) Handles btnThisYear.Click
        dtpStartDate.Value = New DateTime(DateTime.Today.Year, 1, 1)
        dtpEndDate.Value = DateTime.Today
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        ' This method generates the SALES report.
        ' Since we updated the dsReports.xsd, this code will now work without changes.
        Dim ds As New dsReports()

        Try
            OpenConnection()

            Dim salesMasterQuery As String = "SELECT * FROM tblSalesMaster WHERE SaleDate BETWEEN @StartDate AND @EndDate"
            Dim masterAdapter As New SqlDataAdapter(salesMasterQuery, conn)
            masterAdapter.SelectCommand.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date)
            masterAdapter.SelectCommand.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date.AddDays(1))
            masterAdapter.Fill(ds, "tblSalesMaster")

            Dim salesDetailAdapter As New SqlDataAdapter("SELECT * FROM tblSalesDetail", conn)
            salesDetailAdapter.Fill(ds, "tblSalesDetail")

            ' This query no longer fails because dsReports.xsd has been fixed.
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

        If ds.tblSalesMaster.Rows.Count = 0 Then
            MessageBox.Show("No sales data found for the selected period.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim rpt As New rptSales()
        Dim frm As New frmReportViewer()

        rpt.SetDataSource(ds)
        frm.Report = rpt
        frm.ShowDialog()
    End Sub

    Private Sub btnLowStockReport_Click(sender As Object, e As EventArgs) Handles btnLowStockReport.Click
        ' --- THIS LOGIC IS NOW UPDATED FOR INGREDIENTS ---
        Dim ds As New dsReports()

        Try
            OpenConnection()

            ' This query now gets low INGREDIENTS and formats them for the report.
            Dim lowStockQuery As String = "SELECT IngredientName, " & _
                                          "CAST(StockQuantity AS nvarchar) + ' ' + UnitOfMeasure AS RemainingStock " & _
                                          "FROM tblIngredients WHERE StockQuantity <= 10 ORDER BY StockQuantity ASC"
            Dim adapter As New SqlDataAdapter(lowStockQuery, conn)

            ' Fill the new tblLowStockIngredients table in our DataSet
            adapter.Fill(ds, "tblLowStockIngredients")

        Catch ex As Exception
            MessageBox.Show("Error fetching low stock ingredient data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Finally
            CloseConnection()
        End Try

        If ds.tblLowStockIngredients.Rows.Count = 0 Then
            MessageBox.Show("No ingredients with low stock were found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Use the NEW Crystal Report file
        Dim rpt As New rptLowStockIngredients()
        Dim frm As New frmReportViewer()

        rpt.SetDataSource(ds)
        frm.Report = rpt
        frm.ShowDialog()
    End Sub
End Class