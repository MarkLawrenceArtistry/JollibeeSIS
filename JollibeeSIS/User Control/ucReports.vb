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
        Dim ds As New dsReports()

        Try
            OpenConnection()

            Dim lowStockQuery As String = "SELECT p.ProductName, c.CategoryName, p.StockQuantity, p.Price " &
                                          "FROM tblProducts p LEFT JOIN tblCategories c ON p.CategoryID = c.CategoryID " &
                                          "WHERE p.StockQuantity <= 10 ORDER BY p.StockQuantity ASC"
            Dim adapter As New SqlDataAdapter(lowStockQuery, conn)

            adapter.Fill(ds, "tblLowStock")

        Catch ex As Exception
            MessageBox.Show("Error fetching low stock data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Finally
            CloseConnection()
        End Try

        If ds.tblLowStock.Rows.Count = 0 Then
            MessageBox.Show("No items with low stock were found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim rpt As New rptLowStock()
        Dim frm As New frmReportViewer()

        rpt.SetDataSource(ds)
        frm.Report = rpt
        frm.ShowDialog()
    End Sub
End Class