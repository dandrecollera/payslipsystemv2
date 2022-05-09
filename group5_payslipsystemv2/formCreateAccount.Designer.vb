<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCreateAccount
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.generateButton = New System.Windows.Forms.Button()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.confirmPassTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.showPassCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.showPassCheckBox2 = New System.Windows.Forms.CheckBox()
        Me.confirmButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Create Account"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(9, 73)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(281, 20)
        Me.nameTextBox.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'userNameTextBox
        '
        Me.userNameTextBox.Location = New System.Drawing.Point(9, 116)
        Me.userNameTextBox.MaxLength = 11
        Me.userNameTextBox.Name = "userNameTextBox"
        Me.userNameTextBox.Size = New System.Drawing.Size(196, 20)
        Me.userNameTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username"
        '
        'generateButton
        '
        Me.generateButton.Location = New System.Drawing.Point(215, 114)
        Me.generateButton.Name = "generateButton"
        Me.generateButton.Size = New System.Drawing.Size(75, 23)
        Me.generateButton.TabIndex = 5
        Me.generateButton.TabStop = False
        Me.generateButton.Text = "Generate"
        Me.generateButton.UseVisualStyleBackColor = True
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(9, 161)
        Me.passwordTextBox.MaxLength = 11
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTextBox.Size = New System.Drawing.Size(281, 20)
        Me.passwordTextBox.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password"
        '
        'confirmPassTextBox
        '
        Me.confirmPassTextBox.Location = New System.Drawing.Point(9, 208)
        Me.confirmPassTextBox.MaxLength = 11
        Me.confirmPassTextBox.Name = "confirmPassTextBox"
        Me.confirmPassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmPassTextBox.Size = New System.Drawing.Size(281, 20)
        Me.confirmPassTextBox.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Confirm Password"
        '
        'showPassCheckBox1
        '
        Me.showPassCheckBox1.AutoSize = True
        Me.showPassCheckBox1.Location = New System.Drawing.Point(193, 182)
        Me.showPassCheckBox1.Name = "showPassCheckBox1"
        Me.showPassCheckBox1.Size = New System.Drawing.Size(102, 17)
        Me.showPassCheckBox1.TabIndex = 8
        Me.showPassCheckBox1.TabStop = False
        Me.showPassCheckBox1.Text = "Show Password"
        Me.showPassCheckBox1.UseVisualStyleBackColor = True
        '
        'showPassCheckBox2
        '
        Me.showPassCheckBox2.AutoSize = True
        Me.showPassCheckBox2.Location = New System.Drawing.Point(193, 231)
        Me.showPassCheckBox2.Name = "showPassCheckBox2"
        Me.showPassCheckBox2.Size = New System.Drawing.Size(102, 17)
        Me.showPassCheckBox2.TabIndex = 9
        Me.showPassCheckBox2.TabStop = False
        Me.showPassCheckBox2.Text = "Show Password"
        Me.showPassCheckBox2.UseVisualStyleBackColor = True
        '
        'confirmButton
        '
        Me.confirmButton.Location = New System.Drawing.Point(215, 277)
        Me.confirmButton.Name = "confirmButton"
        Me.confirmButton.Size = New System.Drawing.Size(75, 23)
        Me.confirmButton.TabIndex = 10
        Me.confirmButton.TabStop = False
        Me.confirmButton.Text = "Confirm"
        Me.confirmButton.UseVisualStyleBackColor = True
        '
        'cancelButton
        '
        Me.cancelButton.Location = New System.Drawing.Point(134, 277)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelButton.TabIndex = 11
        Me.cancelButton.TabStop = False
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'formCreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(308, 318)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.confirmButton)
        Me.Controls.Add(Me.showPassCheckBox2)
        Me.Controls.Add(Me.showPassCheckBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.confirmPassTextBox)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.generateButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.userNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formCreateAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents userNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents generateButton As Button
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents confirmPassTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents showPassCheckBox1 As CheckBox
    Friend WithEvents showPassCheckBox2 As CheckBox
    Friend WithEvents confirmButton As Button
    Friend WithEvents cancelButton As Button
End Class
