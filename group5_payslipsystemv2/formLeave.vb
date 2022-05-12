Imports MySql.Data.MySqlClient

Public Class formLeave
    Dim functionAudit As New functionAudit()
    Dim functionLeave As New functionLeave()
    Dim db As New dbConnector()
    Private Sub formLeave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Payslipdbv2DataSet.leaves' table. You can move, or remove it, as needed.
        Me.LeavesTableAdapter.Fill(Me.Payslipdbv2DataSet.leaves)

    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Hide()
        Dim formMain As New formMain()
        formMain.ShowDialog()
        Me.Close()
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim formLeaveAdd As New formLeaveAdd()
        If formLeaveAdd.ShowDialog() = DialogResult.OK Then
            updateData()
        End If
    End Sub

    Private Sub updateData()
        clearFields()
        Dim command As New MySqlCommand("SELECT * FROM `leaves`")
        Dim table As DataTable = functionLeave.getLeaves(command)
        DataGridView1.DataSource = table
    End Sub

    Private Sub clearFields()
        searchTextBox.Text = ""
        employeeIdTextBox.Text = ""
        employeeTextBox.Text = ""
        detailRichTextBox.Text = ""
        dateTextBox.Text = ""
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        clearFields()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim dtGrid = DataGridView1.CurrentRow.Cells
        fillFields(dtGrid(1).Value, dtGrid(2).Value, dtGrid(3).Value, dtGrid(4).Value)
    End Sub

    Private Sub fillFields(employeeId, employee, details, dates)
        employeeIdTextBox.Text = employeeId
        employeeTextBox.Text = employee
        detailRichTextBox.Text = details
        Dim d As Date = Date.Parse(dates)
        dateTextBox.Text = d.ToString("d")
    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        updateData()
    End Sub

    Private Sub searchTextBox_TextChanged(sender As Object, e As EventArgs) Handles searchTextBox.TextChanged
        searchAbsent()
    End Sub

    Private Sub searchAbsent()
        Try
            Dim searchInput As String = searchTextBox.Text
            Dim command As New MySqlCommand("SELECT * FROM `leaves` WHERE `employee` LIKE @input OR `employee_id` LIKE @input", db.getConnection)
            command.Parameters.AddWithValue("@input", "%" + searchInput + "%")
            Dim table As DataTable = functionLeave.getLeaves(command)

            DataGridView1.DataSource = table
            fillFields(table.Rows(0)("employee_id"), table.Rows(0)("employee"), table.Rows(0)("detail"), table.Rows(0)("date"))
        Catch ex As Exception
            'Pass
        End Try
    End Sub

    Private Sub generateButton_Click(sender As Object, e As EventArgs) Handles generateButton.Click
        If employeeIdTextBox.Text IsNot "" Then
            Dim formLeaveGen As New formLeaveGen()
            Dim table As New DataTable()
            Dim dtNames() As String = {"employee_id", "employee", "details", "dates"}
            Dim i As Decimal
            For i = 0 To dtNames.Length - 1
                table.Columns.Add(dtNames(i))
            Next

            Dim audit As String = "Generated Leave Report for: " + employeeTextBox.Text
            functionAudit.insertAudit(audit)

            table.Rows.Add(employeeIdTextBox.Text, employeeTextBox.Text, detailRichTextBox.Text, dateTextBox.Text)
            formAbsentGen.absenttable = table
            formAbsentGen.ShowDialog()
        Else
            MessageBox.Show("Select an Employee's Absent!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class