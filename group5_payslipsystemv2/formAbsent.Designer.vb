<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formAbsent
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.generateButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.detailRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.dateTextBox = New System.Windows.Forms.TextBox()
        Me.employeeTextBox = New System.Windows.Forms.TextBox()
        Me.employeeIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbsentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Payslipdbv2DataSet = New group5_payslipsystemv2.payslipdbv2DataSet()
        Me.AbsentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AbsentTableAdapter = New group5_payslipsystemv2.payslipdbv2DataSetTableAdapters.absentTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbsentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Payslipdbv2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbsentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'generateButton
        '
        Me.generateButton.Location = New System.Drawing.Point(121, 356)
        Me.generateButton.Name = "generateButton"
        Me.generateButton.Size = New System.Drawing.Size(80, 39)
        Me.generateButton.TabIndex = 32
        Me.generateButton.Text = "Generate Report"
        Me.generateButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(208, 357)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(81, 36)
        Me.addButton.TabIndex = 31
        Me.addButton.Text = "Add Absent"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'refreshButton
        '
        Me.refreshButton.Location = New System.Drawing.Point(208, 403)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(81, 31)
        Me.refreshButton.TabIndex = 28
        Me.refreshButton.TabStop = False
        Me.refreshButton.Text = "Refresh"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(121, 403)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(81, 31)
        Me.backButton.TabIndex = 27
        Me.backButton.TabStop = False
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'detailRichTextBox
        '
        Me.detailRichTextBox.Location = New System.Drawing.Point(12, 190)
        Me.detailRichTextBox.Name = "detailRichTextBox"
        Me.detailRichTextBox.ReadOnly = True
        Me.detailRichTextBox.Size = New System.Drawing.Size(278, 96)
        Me.detailRichTextBox.TabIndex = 26
        Me.detailRichTextBox.TabStop = False
        Me.detailRichTextBox.Text = ""
        '
        'dateTextBox
        '
        Me.dateTextBox.Location = New System.Drawing.Point(11, 313)
        Me.dateTextBox.Name = "dateTextBox"
        Me.dateTextBox.ReadOnly = True
        Me.dateTextBox.Size = New System.Drawing.Size(279, 20)
        Me.dateTextBox.TabIndex = 24
        Me.dateTextBox.TabStop = False
        '
        'employeeTextBox
        '
        Me.employeeTextBox.Location = New System.Drawing.Point(13, 148)
        Me.employeeTextBox.Name = "employeeTextBox"
        Me.employeeTextBox.ReadOnly = True
        Me.employeeTextBox.Size = New System.Drawing.Size(279, 20)
        Me.employeeTextBox.TabIndex = 22
        Me.employeeTextBox.TabStop = False
        '
        'employeeIdTextBox
        '
        Me.employeeIdTextBox.Location = New System.Drawing.Point(12, 105)
        Me.employeeIdTextBox.Name = "employeeIdTextBox"
        Me.employeeIdTextBox.ReadOnly = True
        Me.employeeIdTextBox.Size = New System.Drawing.Size(279, 20)
        Me.employeeIdTextBox.TabIndex = 21
        Me.employeeIdTextBox.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Detail"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Employee"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Employee ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Search ID or Name"
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(216, 55)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 13
        Me.clearButton.TabStop = False
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(13, 57)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(197, 20)
        Me.searchTextBox.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Employee's List of Absences"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.EmployeeidDataGridViewTextBoxColumn1, Me.EmployeeDataGridViewTextBoxColumn1, Me.DetailDataGridViewTextBoxColumn1, Me.DateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AbsentBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(308, 9)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(563, 425)
        Me.DataGridView1.TabIndex = 33
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'EmployeeidDataGridViewTextBoxColumn
        '
        Me.EmployeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.HeaderText = "Employee ID"
        Me.EmployeeidDataGridViewTextBoxColumn.Name = "EmployeeidDataGridViewTextBoxColumn"
        '
        'EmployeeDataGridViewTextBoxColumn
        '
        Me.EmployeeDataGridViewTextBoxColumn.DataPropertyName = "employee"
        Me.EmployeeDataGridViewTextBoxColumn.HeaderText = "Employee"
        Me.EmployeeDataGridViewTextBoxColumn.Name = "EmployeeDataGridViewTextBoxColumn"
        Me.EmployeeDataGridViewTextBoxColumn.Width = 180
        '
        'DetailDataGridViewTextBoxColumn
        '
        Me.DetailDataGridViewTextBoxColumn.DataPropertyName = "detail"
        Me.DetailDataGridViewTextBoxColumn.HeaderText = "Detail"
        Me.DetailDataGridViewTextBoxColumn.Name = "DetailDataGridViewTextBoxColumn"
        Me.DetailDataGridViewTextBoxColumn.Width = 180
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.Visible = False
        '
        'EmployeeidDataGridViewTextBoxColumn1
        '
        Me.EmployeeidDataGridViewTextBoxColumn1.DataPropertyName = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn1.HeaderText = "Employee ID"
        Me.EmployeeidDataGridViewTextBoxColumn1.Name = "EmployeeidDataGridViewTextBoxColumn1"
        '
        'EmployeeDataGridViewTextBoxColumn1
        '
        Me.EmployeeDataGridViewTextBoxColumn1.DataPropertyName = "employee"
        Me.EmployeeDataGridViewTextBoxColumn1.HeaderText = "Employee"
        Me.EmployeeDataGridViewTextBoxColumn1.Name = "EmployeeDataGridViewTextBoxColumn1"
        Me.EmployeeDataGridViewTextBoxColumn1.Width = 180
        '
        'DetailDataGridViewTextBoxColumn1
        '
        Me.DetailDataGridViewTextBoxColumn1.DataPropertyName = "detail"
        Me.DetailDataGridViewTextBoxColumn1.HeaderText = "Detail"
        Me.DetailDataGridViewTextBoxColumn1.Name = "DetailDataGridViewTextBoxColumn1"
        Me.DetailDataGridViewTextBoxColumn1.Width = 180
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
        'AbsentBindingSource1
        '
        Me.AbsentBindingSource1.DataMember = "absent"
        Me.AbsentBindingSource1.DataSource = Me.Payslipdbv2DataSet
        '
        'Payslipdbv2DataSet
        '
        Me.Payslipdbv2DataSet.DataSetName = "payslipdbv2DataSet"
        Me.Payslipdbv2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AbsentBindingSource
        '
        Me.AbsentBindingSource.DataMember = "absent"
        Me.AbsentBindingSource.DataSource = Me.Payslipdbv2DataSet
        '
        'AbsentTableAdapter
        '
        Me.AbsentTableAdapter.ClearBeforeFill = True
        '
        'formAbsent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(887, 449)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.generateButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.detailRichTextBox)
        Me.Controls.Add(Me.dateTextBox)
        Me.Controls.Add(Me.employeeTextBox)
        Me.Controls.Add(Me.employeeIdTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formAbsent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee's Absences"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbsentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Payslipdbv2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbsentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents generateButton As Button
    Friend WithEvents addButton As Button
    Friend WithEvents refreshButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents detailRichTextBox As RichTextBox
    Friend WithEvents dateTextBox As TextBox
    Friend WithEvents employeeTextBox As TextBox
    Friend WithEvents employeeIdTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents clearButton As Button
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Payslipdbv2DataSet As payslipdbv2DataSet
    Friend WithEvents AbsentBindingSource As BindingSource
    Friend WithEvents AbsentTableAdapter As payslipdbv2DataSetTableAdapters.absentTableAdapter
    Friend WithEvents DatetimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbsentBindingSource1 As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DetailDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
