' This needs to be imported to work with report documents
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmReportViewer
    ' Public property to hold the report we want to display
    Public Report As ReportDocument

    Private Sub frmReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assign the passed-in report to the viewer control
        CrystalReportViewer1.ReportSource = Report
        CrystalReportViewer1.Refresh()
    End Sub
End Class