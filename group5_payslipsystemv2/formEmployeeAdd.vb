Public Class formEmployeeAdd
    Dim functionEmployee As New functionEmployee()
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        If nameTextBox.Text = "" Or emailTextBox.Text = "" Or contactTextBox.Text = "" Or addressRichTextBox.Text = "" Or baseSalaryTextBox.Text = "" Then
            MessageBox.Show("Input all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If functionEmployee.insertEmployee(nameTextBox.Text.Trim(), emailTextBox.Text.Trim(), contactTextBox.Text.Trim(), addressRichTextBox.Text.Trim(), baseSalaryTextBox.Text.Trim()) Then
                MessageBox.Show("Employee Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Employee not successfully added.", "Error")
            End If
        End If
    End Sub
End Class