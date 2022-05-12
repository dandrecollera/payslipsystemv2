<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAudit
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.generateButton = New System.Windows.Forms.Button()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.detailRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.dateTextBox = New System.Windows.Forms.TextBox()
        Me.userTextBox = New System.Windows.Forms.TextBox()
        Me.userIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UseridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatetimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuditsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Payslipdbv2DataSet = New group5_payslipsystemv2.payslipdbv2DataSet()
        Me.AuditsTableAdapter = New group5_payslipsystemv2.payslipdbv2DataSetTableAdapters.auditsTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuditsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Payslipdbv2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DetailDataGridViewTextBoxColumn
        '
        Me.DetailDataGridViewTextBoxColumn.DataPropertyName = "detail"
        Me.DetailDataGridViewTextBoxColumn.HeaderText = "Detail"
        Me.DetailDataGridViewTextBoxColumn.Name = "DetailDataGridViewTextBoxColumn"
        Me.DetailDataGridViewTextBoxColumn.Width = 180
        '
        'EmployeeDataGridViewTextBoxColumn
        '
        Me.EmployeeDataGridViewTextBoxColumn.DataPropertyName = "employee"
        Me.EmployeeDataGridViewTextBoxColumn.HeaderText = "Employee"
        Me.EmployeeDataGridViewTextBoxColumn.Name = "EmployeeDataGridViewTextBoxColumn"
        Me.EmployeeDataGridViewTextBoxColumn.Width = 180
        '
        'EmployeeidDataGridViewTextBoxColumn
        '
        Me.EmployeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.HeaderText = "Employee ID"
        Me.EmployeeidDataGridViewTextBoxColumn.Name = "EmployeeidDataGridViewTextBoxColumn"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'generateButton
        '
        Me.generateButton.Location = New System.Drawing.Point(12, 402)
        Me.generateButton.Name = "generateButton"
        Me.generateButton.Size = New System.Drawing.Size(80, 39)
        Me.generateButton.TabIndex = 49
        Me.generateButton.Text = "Generate Report"
        Me.generateButton.UseVisualStyleBackColor = True
        '
        'refreshButton
        '
        Me.refreshButton.Location = New System.Drawing.Point(213, 402)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(81, 39)
        Me.refreshButton.TabIndex = 47
        Me.refreshButton.TabStop = False
        Me.refreshButton.Text = "Refresh"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(112, 402)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(81, 39)
        Me.backButton.TabIndex = 46
        Me.backButton.TabStop = False
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'detailRichTextBox
        '
        Me.detailRichTextBox.Location = New System.Drawing.Point(16, 193)
        Me.detailRichTextBox.Name = "detailRichTextBox"
        Me.detailRichTextBox.ReadOnly = True
        Me.detailRichTextBox.Size = New System.Drawing.Size(278, 96)
        Me.detailRichTextBox.TabIndex = 45
        Me.detailRichTextBox.TabStop = False
        Me.detailRichTextBox.Text = ""
        '
        'dateTextBox
        '
        Me.dateTextBox.Location = New System.Drawing.Point(15, 316)
        Me.dateTextBox.Name = "dateTextBox"
        Me.dateTextBox.ReadOnly = True
        Me.dateTextBox.Size = New System.Drawing.Size(279, 20)
        Me.dateTextBox.TabIndex = 44
        Me.dateTextBox.TabStop = False
        '
        'userTextBox
        '
        Me.userTextBox.Location = New System.Drawing.Point(17, 151)
        Me.userTextBox.Name = "userTextBox"
        Me.userTextBox.ReadOnly = True
        Me.userTextBox.Size = New System.Drawing.Size(279, 20)
        Me.userTextBox.TabIndex = 43
        Me.userTextBox.TabStop = False
        '
        'userIdTextBox
        '
        Me.userIdTextBox.Location = New System.Drawing.Point(16, 108)
        Me.userIdTextBox.Name = "userIdTextBox"
        Me.userIdTextBox.ReadOnly = True
        Me.userIdTextBox.Size = New System.Drawing.Size(279, 20)
        Me.userIdTextBox.TabIndex = 42
        Me.userIdTextBox.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Date Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Detail"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "User"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "User ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Search ID or Name"
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(220, 58)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 36
        Me.clearButton.TabStop = False
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(17, 60)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(197, 20)
        Me.searchTextBox.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 24)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Audit Log"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.UseridDataGridViewTextBoxColumn, Me.UserDataGridViewTextBoxColumn, Me.DetailDataGridViewTextBoxColumn1, Me.DatetimeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AuditsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(303, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(563, 429)
        Me.DataGridView1.TabIndex = 50
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.Visible = False
        '
        'UseridDataGridViewTextBoxColumn
        '
        Me.UseridDataGridViewTextBoxColumn.DataPropertyName = "user_id"
        Me.UseridDataGridViewTextBoxColumn.HeaderText = "User ID"
        Me.UseridDataGridViewTextBoxColumn.Name = "UseridDataGridViewTextBoxColumn"
        Me.UseridDataGridViewTextBoxColumn.Width = 80
        '
        'UserDataGridViewTextBoxColumn
        '
        Me.UserDataGridViewTextBoxColumn.DataPropertyName = "user"
        Me.UserDataGridViewTextBoxColumn.HeaderText = "User"
        Me.UserDataGridViewTextBoxColumn.Name = "UserDataGridViewTextBoxColumn"
        Me.UserDataGridViewTextBoxColumn.Width = 180
        '
        'DetailDataGridViewTextBoxColumn1
        '
        Me.DetailDataGridViewTextBoxColumn1.DataPropertyName = "detail"
        Me.DetailDataGridViewTextBoxColumn1.HeaderText = "Detail"
        Me.DetailDataGridViewTextBoxColumn1.Name = "DetailDataGridViewTextBoxColumn1"
        Me.DetailDataGridViewTextBoxColumn1.Width = 180
        '
        'DatetimeDataGridViewTextBoxColumn
        '
        Me.DatetimeDataGridViewTextBoxColumn.DataPropertyName = "datetime"
        DataGridViewCellStyle2.Format = "g"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DatetimeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DatetimeDataGridViewTextBoxColumn.HeaderText = "Date Time"
        Me.DatetimeDataGridViewTextBoxColumn.Name = "DatetimeDataGridViewTextBoxColumn"
        Me.DatetimeDataGridViewTextBoxColumn.Width = 120
        '
        'AuditsBindingSource
        '
        Me.AuditsBindingSource.DataMember = "audits"
        Me.AuditsBindingSource.DataSource = Me.Payslipdbv2DataSet
        '
        'Payslipdbv2DataSet
        '
        Me.Payslipdbv2DataSet.DataSetName = "payslipdbv2DataSet"
        Me.Payslipdbv2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AuditsTableAdapter
        '
        Me.AuditsTableAdapter.ClearBeforeFill = True
        '
        'formAudit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(876, 449)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.generateButton)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.detailRichTextBox)
        Me.Controls.Add(Me.dateTextBox)
        Me.Controls.Add(Me.userTextBox)
        Me.Controls.Add(Me.userIdTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formAudit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Audit Log"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuditsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Payslipdbv2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DetailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents generateButton As Button
    Friend WithEvents refreshButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents detailRichTextBox As RichTextBox
    Friend WithEvents dateTextBox As TextBox
    Friend WithEvents userTextBox As TextBox
    Friend WithEvents userIdTextBox As TextBox
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
    Friend WithEvents AuditsBindingSource As BindingSource
    Friend WithEvents AuditsTableAdapter As payslipdbv2DataSetTableAdapters.auditsTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UseridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetailDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DatetimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
