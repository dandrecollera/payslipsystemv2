<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPayslipGen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.payslipBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.payslip = New group5_payslipsystemv2.payslip()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.payslipBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.payslip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'payslipBindingSource
        '
        Me.payslipBindingSource.DataMember = "payslip"
        Me.payslipBindingSource.DataSource = Me.payslip
        '
        'payslip
        '
        Me.payslip.DataSetName = "payslip"
        Me.payslip.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "payslipdata"
        ReportDataSource2.Value = Me.payslipBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "group5_payslipsystemv2.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(545, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'formPayslipGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "formPayslipGen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payslip"
        CType(Me.payslipBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.payslip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents payslipBindingSource As BindingSource
    Friend WithEvents payslip As payslip
End Class
