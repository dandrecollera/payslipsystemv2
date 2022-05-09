Imports MySql.Data.MySqlClient
Public Class formLogin
    Dim formCreateAccount As New formCreateAccount()
    Private Sub showPassCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles showPassCheckBox.CheckedChanged
        If showPassCheckBox.Checked = True Then
            passwordTextBox.PasswordChar = ""
        Else
            passwordTextBox.PasswordChar = "*"
        End If
    End Sub

    Private Sub createAccountButton_Click(sender As Object, e As EventArgs) Handles createAccountButton.Click
        Me.Hide()
        formCreateAccount.ShowDialog()
        Me.Close()
    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        If userNameTextBox.Text.Trim = "" Or passwordTextBox.Text.Trim = "" Then
            MessageBox.Show("Input all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If loginSub() Then
                Me.Hide()
                Dim formMain As New formMain()
                formMain.ShowDialog()
                Me.Close()
            End If
        End If
    End Sub

    Private Function loginSub() As Boolean
        Dim db As New dbConnector()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM `user_accounts` WHERE `username` = @username AND `password` = @password", db.getConnection)

        Try
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = userNameTextBox.Text.Trim
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordTextBox.Text.Trim
            adapter.SelectCommand = command
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                My.Settings.idauth = table.Rows(0)("id")
                My.Settings.name = table.Rows(0)("name")
                Console.WriteLine(My.Settings.name)
                Return True
            Else
                Throw New Exception
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class