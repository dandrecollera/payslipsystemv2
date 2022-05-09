Public Class formReportsEdit
    Dim functionReports As New functionReports()
    Public id As Decimal
    Dim authId As Decimal

    Private Sub formReportsEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        authorTextBox.Text = My.Settings.name
        authId = My.Settings.idauth
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        If titleTextBox.Text = "" Or reportRichTextBox.Text = "" Then
            MessageBox.Show("Input all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If functionReports.updateReport(id, authId, authorTextBox.Text, titleTextBox.Text, reportRichTextBox.Text) Then
                MessageBox.Show("Report Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Report not successfully updated.", "Error")
            End If
        End If
    End Sub
End Class