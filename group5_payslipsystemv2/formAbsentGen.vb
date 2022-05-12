Imports Microsoft.Reporting.WinForms
Public Class formAbsentGen
    Public absenttable As New DataTable
    Private Sub formAbsentGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.LocalReport.DataSources.Clear()
        Dim absent As New ReportDataSource("Data", absenttable)
        ReportViewer1.LocalReport.DataSources.Add(absent)
        ReportViewer1.RefreshReport()
    End Sub
End Class