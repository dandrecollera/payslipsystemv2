Public Class formReportsAdd
    Dim authId As Decimal
    Dim functionReports As New functionReports()
    Dim functionAudit As New functionAudit()

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        If titleTextBox.Text = "" Or reportRichTextBox.Text = "" Then
            MessageBox.Show("Input all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If functionReports.insertReport(authId, authorTextBox.Text, titleTextBox.Text, reportRichTextBox.Text) Then
                Dim audit As String = "Added new report titled: " + titleTextBox.Text
                functionAudit.insertAudit(audit)
                MessageBox.Show("Report Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Report not successfully added.", "Error")
            End If
        End If
    End Sub

    Private Sub formReportsAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        authorTextBox.Text = My.Settings.name
        authId = My.Settings.idauth
    End Sub
End Class