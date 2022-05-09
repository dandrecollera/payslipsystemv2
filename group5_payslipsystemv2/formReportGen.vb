Imports Microsoft.Reporting.WinForms

Public Class formReportGen
    Public reporttable As New DataTable
    Private Sub formReportGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.LocalReport.DataSources.Clear()
        Dim Report As New ReportDataSource("Data", reporttable)
        ReportViewer1.LocalReport.DataSources.Add(Report)
        ReportViewer1.RefreshReport()

    End Sub
End Class