Imports MySql.Data.MySqlClient
Public Class formReports
    Dim functionReports As New functionReports()
    Dim functionAudit As New functionAudit()
    Dim db As New dbConnector()
    Dim id As Decimal = Nothing
    Private Sub formReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Payslipdbv2DataSet.reports' table. You can move, or remove it, as needed.
        Me.ReportsTableAdapter.Fill(Me.Payslipdbv2DataSet.reports)

    End Sub

    Private Sub updateData()
        clearFields()
        Dim command As New MySqlCommand("SELECT * FROM `reports`")
        Dim table As DataTable = functionReports.getReports(command)
        DataGridView1.DataSource = table
    End Sub

    Private Sub clearFields()
        searchTextBox.Text = ""
        titleTextBox.Text = ""
        reportRichTextBox.Text = ""
        dateTextBox.Text = ""
        authorTextBox.Text = ""
        id = Nothing
    End Sub

    Private Sub fillFields(title, report, dateTime, author, idInfo)
        titleTextBox.Text = title.ToString
        reportRichTextBox.Text = report.ToString
        dateTextBox.Text = dateTime.ToString
        authorTextBox.Text = author.ToString
        id = idInfo
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim dtGrid = DataGridView1.CurrentRow.Cells
        fillFields(dtGrid(2).Value, dtGrid(3).Value, dtGrid(5).Value, dtGrid(4).Value, dtGrid(0).Value)
    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        updateData()
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        clearFields()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Hide()
        Dim formMain As New formMain()
        formMain.ShowDialog()
        Me.Close()
    End Sub

    Private Sub searchTextBox_TextChanged(sender As Object, e As EventArgs) Handles searchTextBox.TextChanged
        searchReport()
    End Sub

    Private Sub searchReport()
        Try
            Dim searchInput As String = searchTextBox.Text
            Dim command As New MySqlCommand("SELECT * FROM `reports` WHERE `title` LIKE @input OR `id` LIKE @input", db.getConnection)
            command.Parameters.AddWithValue("@input", "%" + searchInput + "%")
            Dim table As DataTable = functionReports.getReports(command)

            DataGridView1.DataSource = table

            fillFields(table.Rows(0)("title"), table.Rows(0)("report"), table.Rows(0)("datetime"), table.Rows(0)("author"), table.Rows(0)("id"))
        Catch ex As Exception
            'Pass
        End Try
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim formReportsAdd As New formReportsAdd()
        If formReportsAdd.ShowDialog() = DialogResult.OK Then
            updateData()
        End If
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        If titleTextBox.Text IsNot "" Then
            editReport()
        Else
            MessageBox.Show("Select a Report!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub editReport()
        Dim formReportEdit As New formReportsEdit()
        formReportEdit.titleTextBox.Text = titleTextBox.Text
        formReportEdit.reportRichTextBox.Text = reportRichTextBox.Text
        formReportEdit.id = id

        If formReportEdit.ShowDialog() = DialogResult.OK Then
            updateData()
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        editReport()
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        If titleTextBox.Text IsNot "" Then
            Dim audit As String = "Delete report titled: " + titleTextBox.Text
            functionAudit.insertAudit(audit)
            functionReports.deleteReport(id)
            MessageBox.Show("Report Deleted.", "Deleted")
            updateData()
        Else
            MessageBox.Show("Select a Report!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub generateButton_Click(sender As Object, e As EventArgs) Handles generateButton.Click
        If titleTextBox.Text IsNot "" Then
            Dim formReportGen As New formReportGen()
            Dim table As New DataTable()
            Dim dtNames() As String = {"title", "report", "datetime", "author"}
            Dim i As Decimal
            For i = 0 To dtNames.Length - 1
                table.Columns.Add(dtNames(i))
            Next

            Dim audit As String = "Generate report titled: " + titleTextBox.Text
            functionAudit.insertAudit(audit)
            table.Rows.Add(titleTextBox.Text, reportRichTextBox.Text, dateTextBox.Text, authorTextBox.Text)
            formReportGen.reporttable = table
            formReportGen.ShowDialog()
        Else
            MessageBox.Show("Select a Report!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class