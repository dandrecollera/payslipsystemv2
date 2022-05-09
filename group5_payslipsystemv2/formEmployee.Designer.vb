<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEmployee
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasesalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Payslipdbv2DataSet = New group5_payslipsystemv2.payslipdbv2DataSet()
        Me.EmployeeTableAdapter = New group5_payslipsystemv2.payslipdbv2DataSetTableAdapters.employeeTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.contactTextBox = New System.Windows.Forms.TextBox()
        Me.addressRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.salaryTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.backButton = New System.Windows.Forms.Button()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.buttonGeneratePaySlip = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Payslipdbv2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.BasesalaryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmployeeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(296, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(689, 565)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 35
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 180
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Width = 180
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "contact"
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "Contact"
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        Me.ContactDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContactDataGridViewTextBoxColumn.Width = 130
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.Visible = False
        '
        'BasesalaryDataGridViewTextBoxColumn
        '
        Me.BasesalaryDataGridViewTextBoxColumn.DataPropertyName = "base_salary"
        DataGridViewCellStyle2.Format = "₱##,###.00"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.BasesalaryDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.BasesalaryDataGridViewTextBoxColumn.HeaderText = "Base Salary"
        Me.BasesalaryDataGridViewTextBoxColumn.Name = "BasesalaryDataGridViewTextBoxColumn"
        Me.BasesalaryDataGridViewTextBoxColumn.ReadOnly = True
        Me.BasesalaryDataGridViewTextBoxColumn.Width = 120
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "employee"
        Me.EmployeeBindingSource.DataSource = Me.Payslipdbv2DataSet
        '
        'Payslipdbv2DataSet
        '
        Me.Payslipdbv2DataSet.DataSetName = "payslipdbv2DataSet"
        Me.Payslipdbv2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee List"
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(12, 58)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(197, 20)
        Me.searchTextBox.TabIndex = 0
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(215, 56)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 3
        Me.clearButton.TabStop = False
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search ID or Name"
        '
        'idTextBox
        '
        Me.idTextBox.Location = New System.Drawing.Point(11, 106)
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.ReadOnly = True
        Me.idTextBox.Size = New System.Drawing.Size(279, 20)
        Me.idTextBox.TabIndex = 5
        Me.idTextBox.TabStop = False
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(12, 149)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.ReadOnly = True
        Me.nameTextBox.Size = New System.Drawing.Size(279, 20)
        Me.nameTextBox.TabIndex = 5
        Me.nameTextBox.TabStop = False
        '
        'emailTextBox
        '
        Me.emailTextBox.Location = New System.Drawing.Point(11, 194)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.ReadOnly = True
        Me.emailTextBox.Size = New System.Drawing.Size(279, 20)
        Me.emailTextBox.TabIndex = 5
        Me.emailTextBox.TabStop = False
        '
        'contactTextBox
        '
        Me.contactTextBox.Location = New System.Drawing.Point(11, 239)
        Me.contactTextBox.Name = "contactTextBox"
        Me.contactTextBox.ReadOnly = True
        Me.contactTextBox.Size = New System.Drawing.Size(279, 20)
        Me.contactTextBox.TabIndex = 5
        Me.contactTextBox.TabStop = False
        '
        'addressRichTextBox
        '
        Me.addressRichTextBox.Location = New System.Drawing.Point(12, 281)
        Me.addressRichTextBox.Name = "addressRichTextBox"
        Me.addressRichTextBox.ReadOnly = True
        Me.addressRichTextBox.Size = New System.Drawing.Size(278, 96)
        Me.addressRichTextBox.TabIndex = 6
        Me.addressRichTextBox.TabStop = False
        Me.addressRichTextBox.Text = ""
        '
        'salaryTextBox
        '
        Me.salaryTextBox.Location = New System.Drawing.Point(11, 402)
        Me.salaryTextBox.Name = "salaryTextBox"
        Me.salaryTextBox.ReadOnly = True
        Me.salaryTextBox.Size = New System.Drawing.Size(279, 20)
        Me.salaryTextBox.TabIndex = 5
        Me.salaryTextBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Contact No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 387)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Base Salary"
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(11, 546)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(81, 31)
        Me.backButton.TabIndex = 7
        Me.backButton.TabStop = False
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'refreshButton
        '
        Me.refreshButton.Location = New System.Drawing.Point(209, 546)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(81, 31)
        Me.refreshButton.TabIndex = 8
        Me.refreshButton.TabStop = False
        Me.refreshButton.Text = "Refresh"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(11, 503)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(81, 36)
        Me.addButton.TabIndex = 9
        Me.addButton.Text = "Add Employee"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'editButton
        '
        Me.editButton.Location = New System.Drawing.Point(111, 503)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(81, 36)
        Me.editButton.TabIndex = 9
        Me.editButton.Text = "Edit Employee"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(209, 503)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(81, 36)
        Me.deleteButton.TabIndex = 9
        Me.deleteButton.Text = "Delete Employee"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'buttonGeneratePaySlip
        '
        Me.buttonGeneratePaySlip.Location = New System.Drawing.Point(12, 458)
        Me.buttonGeneratePaySlip.Name = "buttonGeneratePaySlip"
        Me.buttonGeneratePaySlip.Size = New System.Drawing.Size(80, 39)
        Me.buttonGeneratePaySlip.TabIndex = 10
        Me.buttonGeneratePaySlip.Text = "Generate Payslip"
        Me.buttonGeneratePaySlip.UseVisualStyleBackColor = True
        '
        'formEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(997, 589)
        Me.Controls.Add(Me.buttonGeneratePaySlip)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.addressRichTextBox)
        Me.Controls.Add(Me.salaryTextBox)
        Me.Controls.Add(Me.contactTextBox)
        Me.Controls.Add(Me.emailTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.idTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Payslipdbv2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Payslipdbv2DataSet As payslipdbv2DataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As payslipdbv2DataSetTableAdapters.employeeTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BasesalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents clearButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents contactTextBox As TextBox
    Friend WithEvents addressRichTextBox As RichTextBox
    Friend WithEvents salaryTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents backButton As Button
    Friend WithEvents refreshButton As Button
    Friend WithEvents addButton As Button
    Friend WithEvents editButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents buttonGeneratePaySlip As Button
End Class
