Imports MySql.Data.MySqlClient
Public Class formAudit
    Dim db As New dbConnector()
    Dim functionAudit As New functionAudit()
    Private Sub formAudit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Payslipdbv2DataSet.audits' table. You can move, or remove it, as needed.
        Me.AuditsTableAdapter.Fill(Me.Payslipdbv2DataSet.audits)

    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        updateData()
    End Sub

    Private Sub clearFields()
        searchTextBox.Text = ""
        userIdTextBox.Text = ""
        userTextBox.Text = ""
        detailRichTextBox.Text = ""
        dateTextBox.Text = ""
    End Sub

    Private Sub updateData()
        clearFields()
        Dim command As New MySqlCommand("SELECT * FROM `audits`")
        Dim table As DataTable = functionAudit.getAudit(command)
        DataGridView1.DataSource = table
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        clearFields()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim dtGrid = DataGridView1.CurrentRow.Cells
        fillFields(dtGrid(1).Value, dtGrid(2).Value, dtGrid(3).Value, dtGrid(4).Value)
    End Sub

    Private Sub fillFields(userId, user, details, dates)
        userIdTextBox.Text = userId
        userTextBox.Text = user
        detailRichTextBox.Text = details
        dateTextBox.Text = dates
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Hide()
        Dim formMain As New formMain()
        formMain.ShowDialog()
        Me.Close()
    End Sub

    Private Sub searchTextBox_TextChanged(sender As Object, e As EventArgs) Handles searchTextBox.TextChanged
        searchAudit()
    End Sub

    Private Sub searchAudit()
        Try
            Dim searchInput As String = searchTextBox.Text
            Dim command As New MySqlCommand("SELECT * FROM `audit` WHERE `user` LIKE @input OR `user_id` LIKE @input", db.getConnection)
            command.Parameters.AddWithValue("@input", "%" + searchInput + "%")
            Dim table As DataTable = functionAudit.getAudit(command)

            DataGridView1.DataSource = table
            fillFields(table.Rows(0)("employee_id"), table.Rows(0)("employee"), table.Rows(0)("detail"), table.Rows(0)("date"))
        Catch ex As Exception
            'Pass
        End Try
    End Sub

    Private Sub generateButton_Click(sender As Object, e As EventArgs) Handles generateButton.Click
        If userIdTextBox.Text IsNot "" Then
            Dim formAuditGen As New formAuditGen()
            Dim table As New DataTable()
            Dim dtNames() As String = {"user_id", "user", "detail", "dates"}
            Dim i As Decimal
            For i = 0 To dtNames.Length - 1
                table.Columns.Add(dtNames(i))
            Next

            table.Rows.Add(userIdTextBox.Text, userTextBox.Text, detailRichTextBox.Text, dateTextBox.Text)
            formAuditGen.audittable = table
            formAuditGen.ShowDialog()
        Else
            MessageBox.Show("Select an Audit!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
End Class