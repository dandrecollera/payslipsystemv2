Imports Microsoft.Reporting.WinForms
Public Class formLeaveGen
    Public leavetable As New DataTable
    Private Sub formLeaveGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.LocalReport.DataSources.Clear()
        Dim leaves As New ReportDataSource("Data", leavetable)
        ReportViewer1.LocalReport.DataSources.Add(leaves)
        ReportViewer1.RefreshReport()
    End Sub
End Class