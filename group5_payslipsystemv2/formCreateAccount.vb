Public Class formCreateAccount
    Dim functionAccount As New functionAccount()
    Private Sub generateButton_Click(sender As Object, e As EventArgs) Handles generateButton.Click
        Dim random As New Random()
        Dim letterNums() As Char = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim generated(7) As String

        For index As Integer = 1 To 7
            Dim selection = random.Next(0, letterNums.Length - 1)
            Dim caps = random.Next(0, 2)
            If selection <= 26 And caps = 0 Then
                generated(index) = Char.ToLower(letterNums(selection))
            Else
                generated(index) = letterNums(selection)
            End If
        Next

        Dim generatedUsername As String = ""
        For index As Integer = 0 To generated.Length - 1
            generatedUsername += generated(index)
        Next

        userNameTextBox.Text = generatedUsername
    End Sub

    Private Sub showPassCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles showPassCheckBox1.CheckedChanged
        If showPassCheckBox1.Checked = True Then
            passwordTextBox.PasswordChar = ""
        Else
            passwordTextBox.PasswordChar = "*"
        End If
    End Sub

    Private Sub showPassCheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles showPassCheckBox2.CheckedChanged
        If showPassCheckBox2.Checked = True Then
            confirmPassTextBox.PasswordChar = ""
        Else
            confirmPassTextBox.PasswordChar = "*"
        End If
    End Sub

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        If nameTextBox.Text.Trim = "" Or userNameTextBox.Text.Trim = "" Or passwordTextBox.Text.Trim = "" Or confirmPassTextBox.Text.Trim = "" Then
            MessageBox.Show("Enter all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim respond As DialogResult = MessageBox.Show("Confirm Inputs?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If respond = DialogResult.Yes Then
                addAccount()
            End If
        End If

    End Sub

    Private Sub addAccount()
        Try
            If passwordTextBox.Text = confirmPassTextBox.Text Then
                Dim name As String = nameTextBox.Text.Trim
                Dim username As String = userNameTextBox.Text.Trim
                Dim password As String = passwordTextBox.Text.Trim
                If functionAccount.insertAccount(name, username, password) Then
                    MessageBox.Show("Create account success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    returnLogin()
                End If
            Else
                Throw New Exception
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Input! Check Username and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        returnLogin()
    End Sub

    Private Sub returnLogin()
        Me.Hide()
        Dim formLogin As New formLogin()
        formLogin.ShowDialog()
        Me.Close()
    End Sub
End Class