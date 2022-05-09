Imports MySql.Data.MySqlClient
Public Class formEmployee
    Dim db As New dbConnector()
    Dim functionEmployee As New functionEmployee()
    Private Sub formEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Payslipdbv2DataSet.employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Payslipdbv2DataSet.employee)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim dtGrid = DataGridView1.CurrentRow.Cells
        fillFields(dtGrid(0).Value, dtGrid(1).Value, dtGrid(2).Value, dtGrid(3).Value, dtGrid(4).Value, dtGrid(5).Value)
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        clearFields()
    End Sub

    Private Sub searchTextBox_TextChanged(sender As Object, e As EventArgs) Handles searchTextBox.TextChanged
        searchEmployee()
    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        updateData()
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim formEmployeeAdd As New formEmployeeAdd()
        If formEmployeeAdd.ShowDialog() = DialogResult.OK Then
            updateData()
        End If
    End Sub

    Private Sub clearFields()
        searchTextBox.Text = ""
        idTextBox.Text = ""
        nameTextBox.Text = ""
        emailTextBox.Text = ""
        contactTextBox.Text = ""
        addressRichTextBox.Text = ""
        salaryTextBox.Text = ""
    End Sub

    Private Sub fillFields(id, name, email, contact, address, salary)
        idTextBox.Text = id.ToString
        nameTextBox.Text = name.ToString
        emailTextBox.Text = email.ToString
        contactTextBox.Text = contact.ToString
        addressRichTextBox.Text = address.ToString
        salaryTextBox.Text = Format(salary, "₱##,###.00")
    End Sub

    Private Sub searchEmployee()
        Try
            Dim searchInput As String = searchTextBox.Text
            Dim command As New MySqlCommand("SELECT * FROM `employee` WHERE `name` LIKE @input OR `id` LIKE @input", db.getConnection)
            command.Parameters.AddWithValue("@input", "%" + searchInput + "%")
            Dim table As DataTable = functionEmployee.getEmployee(command)

            DataGridView1.DataSource = table

            fillFields(table.Rows(0)("id"), table.Rows(0)("name"), table.Rows(0)("email"), table.Rows(0)("contact"), table.Rows(0)("address"), table.Rows(0)("base_salary"))
        Catch ex As Exception
            'Pass
        End Try
    End Sub

    Private Sub updateData()
        clearFields()
        Dim command As New MySqlCommand("SELECT * FROM `employee`")
        Dim table As DataTable = functionEmployee.getEmployee(command)
        DataGridView1.DataSource = table
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        If idTextBox.Text IsNot "" Then
            editEmployee()
        Else
            MessageBox.Show("Select an Employee!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub editEmployee()
        Dim formEmployeeEdit As New formEmployeeEdit()
        formEmployeeEdit.idTextBox.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        formEmployeeEdit.nameTextBox.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        formEmployeeEdit.emailTextBox.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        formEmployeeEdit.contactTextBox.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        formEmployeeEdit.addressRichTextBox.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        formEmployeeEdit.baseSalaryTextBox.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()

        If formEmployeeEdit.ShowDialog() = DialogResult.OK Then
            updateData()
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        editEmployee()
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        If idTextBox.Text IsNot "" Then
            functionEmployee.deleteEmployee(idTextBox.Text.Trim())
            MessageBox.Show("Employee Deleted.", "Deleted")
            updateData()
        Else
            MessageBox.Show("Select an Employee!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Hide()
        Dim formMain As New formMain()
        formMain.ShowDialog()
        Me.Close()
    End Sub

    Private Sub buttonGeneratePaySlip_Click(sender As Object, e As EventArgs) Handles buttonGeneratePaySlip.Click
        If idTextBox.Text IsNot "" Then
            Dim formPayslip As New formPayslip()
            formPayslip.id = idTextBox.Text
            formPayslip.employeeName = nameTextBox.Text
            formPayslip.baseSalary = DataGridView1.CurrentRow.Cells(5).Value
            formPayslip.ShowDialog()
        Else
            MessageBox.Show("Select an Employee!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class