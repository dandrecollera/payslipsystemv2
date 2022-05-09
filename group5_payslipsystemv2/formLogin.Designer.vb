<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogin
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
        Me.userNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.showPassCheckBox = New System.Windows.Forms.CheckBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.createAccountButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'userNameTextBox
        '
        Me.userNameTextBox.Location = New System.Drawing.Point(12, 76)
        Me.userNameTextBox.Name = "userNameTextBox"
        Me.userNameTextBox.Size = New System.Drawing.Size(254, 20)
        Me.userNameTextBox.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(14, 125)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTextBox.Size = New System.Drawing.Size(254, 20)
        Me.passwordTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'showPassCheckBox
        '
        Me.showPassCheckBox.AutoSize = True
        Me.showPassCheckBox.Location = New System.Drawing.Point(172, 149)
        Me.showPassCheckBox.Name = "showPassCheckBox"
        Me.showPassCheckBox.Size = New System.Drawing.Size(102, 17)
        Me.showPassCheckBox.TabIndex = 2
        Me.showPassCheckBox.TabStop = False
        Me.showPassCheckBox.Text = "Show Password"
        Me.showPassCheckBox.UseVisualStyleBackColor = True
        '
        'loginButton
        '
        Me.loginButton.Location = New System.Drawing.Point(193, 190)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(75, 23)
        Me.loginButton.TabIndex = 3
        Me.loginButton.TabStop = False
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'createAccountButton
        '
        Me.createAccountButton.Location = New System.Drawing.Point(16, 190)
        Me.createAccountButton.Name = "createAccountButton"
        Me.createAccountButton.Size = New System.Drawing.Size(93, 23)
        Me.createAccountButton.TabIndex = 4
        Me.createAccountButton.TabStop = False
        Me.createAccountButton.Text = "Create Account"
        Me.createAccountButton.UseVisualStyleBackColor = True
        '
        'formLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(278, 235)
        Me.Controls.Add(Me.createAccountButton)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.showPassCheckBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.userNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents userNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents showPassCheckBox As CheckBox
    Friend WithEvents loginButton As Button
    Friend WithEvents createAccountButton As Button
End Class
