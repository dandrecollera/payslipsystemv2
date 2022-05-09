Imports Microsoft.Reporting.WinForms
Public Class formPayslipGen
    Public paysliptable As New DataTable
    Private Sub formPayslipGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ReportViewer1.LocalReport.DataSources.Clear()
        Dim Report As New ReportDataSource("Data", paysliptable)
        ReportViewer1.LocalReport.DataSources.Add(report)
        ReportViewer1.RefreshReport()
    End Sub
End Class