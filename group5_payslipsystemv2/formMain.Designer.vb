<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeoutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OvertimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinuteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeinoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Payslipdbv2DataSet = New group5_payslipsystemv2.payslipdbv2DataSet()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.TimeinoutTableAdapter = New group5_payslipsystemv2.payslipdbv2DataSetTableAdapters.timeinoutTableAdapter()
        Me.buttonTimeInOut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeinoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Payslipdbv2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.EmployeeidDataGridViewTextBoxColumn, Me.EmployeeDataGridViewTextBoxColumn, Me.TimeinDataGridViewTextBoxColumn, Me.TimeoutDataGridViewTextBoxColumn, Me.RegularDataGridViewTextBoxColumn, Me.OvertimeDataGridViewTextBoxColumn, Me.MinuteDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TimeinoutBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(530, 366)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'EmployeeidDataGridViewTextBoxColumn
        '
        Me.EmployeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.HeaderText = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.Name = "EmployeeidDataGridViewTextBoxColumn"
        Me.EmployeeidDataGridViewTextBoxColumn.Visible = False
        '
        'EmployeeDataGridViewTextBoxColumn
        '
        Me.EmployeeDataGridViewTextBoxColumn.DataPropertyName = "employee"
        Me.EmployeeDataGridViewTextBoxColumn.HeaderText = "Employee"
        Me.EmployeeDataGridViewTextBoxColumn.Name = "EmployeeDataGridViewTextBoxColumn"
        Me.EmployeeDataGridViewTextBoxColumn.Width = 180
        '
        'TimeinDataGridViewTextBoxColumn
        '
        Me.TimeinDataGridViewTextBoxColumn.DataPropertyName = "timein"
        DataGridViewCellStyle1.Format = "t"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.TimeinDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.TimeinDataGridViewTextBoxColumn.HeaderText = "Time In"
        Me.TimeinDataGridViewTextBoxColumn.Name = "TimeinDataGridViewTextBoxColumn"
        '
        'TimeoutDataGridViewTextBoxColumn
        '
        Me.TimeoutDataGridViewTextBoxColumn.DataPropertyName = "timeout"
        DataGridViewCellStyle2.Format = "t"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.TimeoutDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TimeoutDataGridViewTextBoxColumn.HeaderText = "Time Out"
        Me.TimeoutDataGridViewTextBoxColumn.Name = "TimeoutDataGridViewTextBoxColumn"
        '
        'RegularDataGridViewTextBoxColumn
        '
        Me.RegularDataGridViewTextBoxColumn.DataPropertyName = "regular"
        Me.RegularDataGridViewTextBoxColumn.HeaderText = "regular"
        Me.RegularDataGridViewTextBoxColumn.Name = "RegularDataGridViewTextBoxColumn"
        Me.RegularDataGridViewTextBoxColumn.Visible = False
        '
        'OvertimeDataGridViewTextBoxColumn
        '
        Me.OvertimeDataGridViewTextBoxColumn.DataPropertyName = "overtime"
        Me.OvertimeDataGridViewTextBoxColumn.HeaderText = "overtime"
        Me.OvertimeDataGridViewTextBoxColumn.Name = "OvertimeDataGridViewTextBoxColumn"
        Me.OvertimeDataGridViewTextBoxColumn.Visible = False
        '
        'MinuteDataGridViewTextBoxColumn
        '
        Me.MinuteDataGridViewTextBoxColumn.DataPropertyName = "minute"
        Me.MinuteDataGridViewTextBoxColumn.HeaderText = "minute"
        Me.MinuteDataGridViewTextBoxColumn.Name = "MinuteDataGridViewTextBoxColumn"
        Me.MinuteDataGridViewTextBoxColumn.Visible = False
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "date"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'TimeinoutBindingSource
        '
        Me.TimeinoutBindingSource.DataMember = "timeinout"
        Me.TimeinoutBindingSource.DataSource = Me.Payslipdbv2DataSet
        '
        'Payslipdbv2DataSet
        '
        Me.Payslipdbv2DataSet.DataSetName = "payslipdbv2DataSet"
        Me.Payslipdbv2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(554, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripButton1.Text = "Employee"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripButton2.Text = "Absences"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(46, 22)
        Me.ToolStripButton3.Text = "Leaves"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripButton4.Text = "Reports"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripButton5.Text = "Audit Log"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton6.Text = "Logout"
        '
        'TimeinoutTableAdapter
        '
        Me.TimeinoutTableAdapter.ClearBeforeFill = True
        '
        'buttonTimeInOut
        '
        Me.buttonTimeInOut.Location = New System.Drawing.Point(414, 450)
        Me.buttonTimeInOut.Name = "buttonTimeInOut"
        Me.buttonTimeInOut.Size = New System.Drawing.Size(125, 23)
        Me.buttonTimeInOut.TabIndex = 2
        Me.buttonTimeInOut.Text = "Add Time In/Time Out"
        Me.buttonTimeInOut.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Time In / Time Out"
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(554, 486)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buttonTimeInOut)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formMain"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeinoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Payslipdbv2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Payslipdbv2DataSet As payslipdbv2DataSet
    Friend WithEvents TimeinoutBindingSource As BindingSource
    Friend WithEvents TimeinoutTableAdapter As payslipdbv2DataSetTableAdapters.timeinoutTableAdapter
    Friend WithEvents buttonTimeInOut As Button
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeoutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegularDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OvertimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinuteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
End Class
