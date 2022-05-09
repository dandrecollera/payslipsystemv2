<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formReports
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
        Me.reportRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.dateTextBox = New System.Windows.Forms.TextBox()
        Me.authorTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.titleTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatetimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Payslipdbv2DataSet = New group5_payslipsystemv2.payslipdbv2DataSet()
        Me.ReportsTableAdapter = New group5_payslipsystemv2.payslipdbv2DataSetTableAdapters.reportsTableAdapter()
        Me.generateButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Payslipdbv2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'reportRichTextBox
        '
        Me.reportRichTextBox.Location = New System.Drawing.Point(13, 134)
        Me.reportRichTextBox.Name = "reportRichTextBox"
        Me.reportRichTextBox.ReadOnly = True
        Me.reportRichTextBox.Size = New System.Drawing.Size(278, 159)
        Me.reportRichTextBox.TabIndex = 20
        Me.reportRichTextBox.TabStop = False
        Me.reportRichTextBox.Text = ""
        '
        'dateTextBox
        '
        Me.dateTextBox.Location = New System.Drawing.Point(12, 315)
        Me.dateTextBox.Name = "dateTextBox"
        Me.dateTextBox.ReadOnly = True
        Me.dateTextBox.Size = New System.Drawing.Size(279, 20)
        Me.dateTextBox.TabIndex = 17
        Me.dateTextBox.TabStop = False
        '
        'authorTextBox
        '
        Me.authorTextBox.Location = New System.Drawing.Point(12, 354)
        Me.authorTextBox.Name = "authorTextBox"
        Me.authorTextBox.ReadOnly = True
        Me.authorTextBox.Size = New System.Drawing.Size(279, 20)
        Me.authorTextBox.TabIndex = 18
        Me.authorTextBox.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Date / Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 338)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Author"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Search ID or Title"
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(216, 55)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 9
        Me.clearButton.TabStop = False
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(13, 57)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(197, 20)
        Me.searchTextBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Report List"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Report"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New System.Drawing.Point(12, 105)
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.ReadOnly = True
        Me.titleTextBox.Size = New System.Drawing.Size(279, 20)
        Me.titleTextBox.TabIndex = 19
        Me.titleTextBox.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.AuthidDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.ReportDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.DatetimeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReportsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(301, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(483, 452)
        Me.DataGridView1.TabIndex = 21
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(209, 393)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(81, 31)
        Me.deleteButton.TabIndex = 24
        Me.deleteButton.Text = "Delete Report"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'editButton
        '
        Me.editButton.Location = New System.Drawing.Point(111, 393)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(81, 31)
        Me.editButton.TabIndex = 25
        Me.editButton.Text = "Edit Report"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(11, 393)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(81, 31)
        Me.addButton.TabIndex = 26
        Me.addButton.Text = "Add Report"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'refreshButton
        '
        Me.refreshButton.Location = New System.Drawing.Point(209, 431)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(81, 36)
        Me.refreshButton.TabIndex = 23
        Me.refreshButton.TabStop = False
        Me.refreshButton.Text = "Refresh"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(111, 431)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(81, 36)
        Me.backButton.TabIndex = 22
        Me.backButton.TabStop = False
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 30
        '
        'AuthidDataGridViewTextBoxColumn
        '
        Me.AuthidDataGridViewTextBoxColumn.DataPropertyName = "authid"
        Me.AuthidDataGridViewTextBoxColumn.HeaderText = "authid"
        Me.AuthidDataGridViewTextBoxColumn.Name = "AuthidDataGridViewTextBoxColumn"
        Me.AuthidDataGridViewTextBoxColumn.Visible = False
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.Width = 170
        '
        'ReportDataGridViewTextBoxColumn
        '
        Me.ReportDataGridViewTextBoxColumn.DataPropertyName = "report"
        Me.ReportDataGridViewTextBoxColumn.HeaderText = "Report"
        Me.ReportDataGridViewTextBoxColumn.Name = "ReportDataGridViewTextBoxColumn"
        Me.ReportDataGridViewTextBoxColumn.Visible = False
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        Me.AuthorDataGridViewTextBoxColumn.Width = 180
        '
        'DatetimeDataGridViewTextBoxColumn
        '
        Me.DatetimeDataGridViewTextBoxColumn.DataPropertyName = "datetime"
        DataGridViewCellStyle2.Format = "g"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DatetimeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DatetimeDataGridViewTextBoxColumn.HeaderText = "Date Time"
        Me.DatetimeDataGridViewTextBoxColumn.Name = "DatetimeDataGridViewTextBoxColumn"
        '
        'ReportsBindingSource
        '
        Me.ReportsBindingSource.DataMember = "reports"
        Me.ReportsBindingSource.DataSource = Me.Payslipdbv2DataSet
        '
        'Payslipdbv2DataSet
        '
        Me.Payslipdbv2DataSet.DataSetName = "payslipdbv2DataSet"
        Me.Payslipdbv2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportsTableAdapter
        '
        Me.ReportsTableAdapter.ClearBeforeFill = True
        '
        'generateButton
        '
        Me.generateButton.Location = New System.Drawing.Point(11, 430)
        Me.generateButton.Name = "generateButton"
        Me.generateButton.Size = New System.Drawing.Size(81, 37)
        Me.generateButton.TabIndex = 26
        Me.generateButton.Text = "Generate Report"
        Me.generateButton.UseVisualStyleBackColor = True
        '
        'formReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(799, 479)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.generateButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.reportRichTextBox)
        Me.Controls.Add(Me.dateTextBox)
        Me.Controls.Add(Me.authorTextBox)
        Me.Controls.Add(Me.titleTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Payslipdbv2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents reportRichTextBox As RichTextBox
    Friend WithEvents dateTextBox As TextBox
    Friend WithEvents authorTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents clearButton As Button
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents titleTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Payslipdbv2DataSet As payslipdbv2DataSet
    Friend WithEvents ReportsBindingSource As BindingSource
    Friend WithEvents ReportsTableAdapter As payslipdbv2DataSetTableAdapters.reportsTableAdapter
    Friend WithEvents deleteButton As Button
    Friend WithEvents editButton As Button
    Friend WithEvents addButton As Button
    Friend WithEvents refreshButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReportDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatetimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents generateButton As Button
End Class
