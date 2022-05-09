<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formPayslip
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Payslipdbv2DataSet = New group5_payslipsystemv2.payslipdbv2DataSet()
        Me.TimeinoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimeinoutTableAdapter = New group5_payslipsystemv2.payslipdbv2DataSetTableAdapters.timeinoutTableAdapter()
        Me.monthsComboBox = New System.Windows.Forms.ComboBox()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New group5_payslipsystemv2.payslipdbv2DataSetTableAdapters.employeeTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.secondRadioButton = New System.Windows.Forms.RadioButton()
        Me.firstRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.salaryTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.generalSalaryTextBox = New System.Windows.Forms.TextBox()
        Me.overtimeTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bonusTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.totalwoDeductionTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.sssTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pagibigTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.philhealthTextBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.taxTextBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.finalTotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.generateButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        CType(Me.Payslipdbv2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeinoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Payslipdbv2DataSet
        '
        Me.Payslipdbv2DataSet.DataSetName = "payslipdbv2DataSet"
        Me.Payslipdbv2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TimeinoutBindingSource
        '
        Me.TimeinoutBindingSource.DataMember = "timeinout"
        Me.TimeinoutBindingSource.DataSource = Me.Payslipdbv2DataSet
        '
        'TimeinoutTableAdapter
        '
        Me.TimeinoutTableAdapter.ClearBeforeFill = True
        '
        'monthsComboBox
        '
        Me.monthsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.monthsComboBox.FormattingEnabled = True
        Me.monthsComboBox.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.monthsComboBox.Location = New System.Drawing.Point(55, 52)
        Me.monthsComboBox.Name = "monthsComboBox"
        Me.monthsComboBox.Size = New System.Drawing.Size(175, 21)
        Me.monthsComboBox.TabIndex = 3
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "employee"
        Me.EmployeeBindingSource.DataSource = Me.Payslipdbv2DataSet
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Generate Payslip"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Month"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.secondRadioButton)
        Me.Panel1.Controls.Add(Me.firstRadioButton)
        Me.Panel1.Location = New System.Drawing.Point(235, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(120, 37)
        Me.Panel1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cutoff"
        '
        'secondRadioButton
        '
        Me.secondRadioButton.AutoSize = True
        Me.secondRadioButton.Enabled = False
        Me.secondRadioButton.Location = New System.Drawing.Point(61, 16)
        Me.secondRadioButton.Name = "secondRadioButton"
        Me.secondRadioButton.Size = New System.Drawing.Size(43, 17)
        Me.secondRadioButton.TabIndex = 7
        Me.secondRadioButton.Text = "2nd"
        Me.secondRadioButton.UseVisualStyleBackColor = True
        '
        'firstRadioButton
        '
        Me.firstRadioButton.AutoSize = True
        Me.firstRadioButton.Enabled = False
        Me.firstRadioButton.Location = New System.Drawing.Point(15, 16)
        Me.firstRadioButton.Name = "firstRadioButton"
        Me.firstRadioButton.Size = New System.Drawing.Size(39, 17)
        Me.firstRadioButton.TabIndex = 7
        Me.firstRadioButton.Text = "1st"
        Me.firstRadioButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Employee Detail"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(13, 129)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.ReadOnly = True
        Me.nameTextBox.Size = New System.Drawing.Size(217, 20)
        Me.nameTextBox.TabIndex = 8
        '
        'salaryTextBox
        '
        Me.salaryTextBox.Location = New System.Drawing.Point(236, 129)
        Me.salaryTextBox.Name = "salaryTextBox"
        Me.salaryTextBox.ReadOnly = True
        Me.salaryTextBox.Size = New System.Drawing.Size(119, 20)
        Me.salaryTextBox.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(233, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Base Salary"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "General Salary"
        '
        'generalSalaryTextBox
        '
        Me.generalSalaryTextBox.Location = New System.Drawing.Point(13, 207)
        Me.generalSalaryTextBox.Name = "generalSalaryTextBox"
        Me.generalSalaryTextBox.ReadOnly = True
        Me.generalSalaryTextBox.Size = New System.Drawing.Size(154, 20)
        Me.generalSalaryTextBox.TabIndex = 8
        '
        'overtimeTextBox
        '
        Me.overtimeTextBox.Location = New System.Drawing.Point(13, 249)
        Me.overtimeTextBox.Name = "overtimeTextBox"
        Me.overtimeTextBox.ReadOnly = True
        Me.overtimeTextBox.Size = New System.Drawing.Size(154, 20)
        Me.overtimeTextBox.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Overtime"
        '
        'bonusTextBox
        '
        Me.bonusTextBox.Location = New System.Drawing.Point(13, 293)
        Me.bonusTextBox.Name = "bonusTextBox"
        Me.bonusTextBox.Size = New System.Drawing.Size(154, 20)
        Me.bonusTextBox.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Bonus"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 166)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Overview"
        '
        'totalwoDeductionTextBox
        '
        Me.totalwoDeductionTextBox.Location = New System.Drawing.Point(12, 339)
        Me.totalwoDeductionTextBox.Name = "totalwoDeductionTextBox"
        Me.totalwoDeductionTextBox.ReadOnly = True
        Me.totalwoDeductionTextBox.Size = New System.Drawing.Size(154, 20)
        Me.totalwoDeductionTextBox.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 323)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Total w/o Deduction"
        '
        'sssTextBox
        '
        Me.sssTextBox.Location = New System.Drawing.Point(187, 207)
        Me.sssTextBox.Name = "sssTextBox"
        Me.sssTextBox.ReadOnly = True
        Me.sssTextBox.Size = New System.Drawing.Size(168, 20)
        Me.sssTextBox.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(186, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "SSS"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(185, 166)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 16)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Deduction"
        '
        'pagibigTextBox
        '
        Me.pagibigTextBox.Location = New System.Drawing.Point(187, 249)
        Me.pagibigTextBox.Name = "pagibigTextBox"
        Me.pagibigTextBox.ReadOnly = True
        Me.pagibigTextBox.Size = New System.Drawing.Size(168, 20)
        Me.pagibigTextBox.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(186, 233)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Pagibig"
        '
        'philhealthTextBox
        '
        Me.philhealthTextBox.Location = New System.Drawing.Point(187, 293)
        Me.philhealthTextBox.Name = "philhealthTextBox"
        Me.philhealthTextBox.ReadOnly = True
        Me.philhealthTextBox.Size = New System.Drawing.Size(168, 20)
        Me.philhealthTextBox.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(186, 277)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "PhilHealth"
        '
        'taxTextBox
        '
        Me.taxTextBox.Location = New System.Drawing.Point(187, 339)
        Me.taxTextBox.Name = "taxTextBox"
        Me.taxTextBox.ReadOnly = True
        Me.taxTextBox.Size = New System.Drawing.Size(168, 20)
        Me.taxTextBox.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(186, 323)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Tax"
        '
        'finalTotalTextBox
        '
        Me.finalTotalTextBox.Location = New System.Drawing.Point(12, 390)
        Me.finalTotalTextBox.Name = "finalTotalTextBox"
        Me.finalTotalTextBox.ReadOnly = True
        Me.finalTotalTextBox.Size = New System.Drawing.Size(154, 20)
        Me.finalTotalTextBox.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 374)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Final Total"
        '
        'generateButton
        '
        Me.generateButton.Location = New System.Drawing.Point(280, 387)
        Me.generateButton.Name = "generateButton"
        Me.generateButton.Size = New System.Drawing.Size(75, 23)
        Me.generateButton.TabIndex = 11
        Me.generateButton.Text = "Generate"
        Me.generateButton.UseVisualStyleBackColor = True
        '
        'cancelButton
        '
        Me.cancelButton.Location = New System.Drawing.Point(199, 388)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelButton.TabIndex = 11
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'formPayslip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 438)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.generateButton)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.salaryTextBox)
        Me.Controls.Add(Me.bonusTextBox)
        Me.Controls.Add(Me.finalTotalTextBox)
        Me.Controls.Add(Me.totalwoDeductionTextBox)
        Me.Controls.Add(Me.overtimeTextBox)
        Me.Controls.Add(Me.taxTextBox)
        Me.Controls.Add(Me.philhealthTextBox)
        Me.Controls.Add(Me.pagibigTextBox)
        Me.Controls.Add(Me.sssTextBox)
        Me.Controls.Add(Me.generalSalaryTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.monthsComboBox)
        Me.Name = "formPayslip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate Payslip"
        CType(Me.Payslipdbv2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeinoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Payslipdbv2DataSet As payslipdbv2DataSet
    Friend WithEvents TimeinoutBindingSource As BindingSource
    Friend WithEvents TimeinoutTableAdapter As payslipdbv2DataSetTableAdapters.timeinoutTableAdapter
    Friend WithEvents monthsComboBox As ComboBox
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As payslipdbv2DataSetTableAdapters.employeeTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents firstRadioButton As RadioButton
    Friend WithEvents secondRadioButton As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents salaryTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents generalSalaryTextBox As TextBox
    Friend WithEvents overtimeTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents bonusTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents totalwoDeductionTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents sssTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents pagibigTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents philhealthTextBox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents taxTextBox As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents finalTotalTextBox As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents generateButton As Button
    Friend WithEvents cancelButton As Button
End Class
