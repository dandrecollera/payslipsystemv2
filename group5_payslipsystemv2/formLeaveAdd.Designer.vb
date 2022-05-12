<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLeaveAdd
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
        Me.detailRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.employeeComboBox = New System.Windows.Forms.ComboBox()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'detailRichTextBox
        '
        Me.detailRichTextBox.Location = New System.Drawing.Point(21, 117)
        Me.detailRichTextBox.Name = "detailRichTextBox"
        Me.detailRichTextBox.Size = New System.Drawing.Size(239, 126)
        Me.detailRichTextBox.TabIndex = 24
        Me.detailRichTextBox.Text = ""
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(19, 270)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(242, 20)
        Me.DateTimePicker1.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Employee"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Add Employee's Leave"
        '
        'employeeComboBox
        '
        Me.employeeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.employeeComboBox.FormattingEnabled = True
        Me.employeeComboBox.Location = New System.Drawing.Point(18, 69)
        Me.employeeComboBox.Name = "employeeComboBox"
        Me.employeeComboBox.Size = New System.Drawing.Size(242, 21)
        Me.employeeComboBox.TabIndex = 18
        '
        'cancelButton
        '
        Me.cancelButton.Location = New System.Drawing.Point(107, 305)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelButton.TabIndex = 17
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(188, 305)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 16
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'formLeaveAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(278, 344)
        Me.Controls.Add(Me.detailRichTextBox)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.employeeComboBox)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.addButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formLeaveAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Leave"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents detailRichTextBox As RichTextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents employeeComboBox As ComboBox
    Friend WithEvents cancelButton As Button
    Friend WithEvents addButton As Button
End Class
