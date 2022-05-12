Imports Microsoft.Reporting.WinForms
Public Class formAuditGen
    Public audittable As New DataTable
    Private Sub formAuditGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.LocalReport.DataSources.Clear()
        Dim audits As New ReportDataSource("Data", audittable)
        ReportViewer1.LocalReport.DataSources.Add(audits)
        ReportViewer1.RefreshReport()
    End Sub
End Class