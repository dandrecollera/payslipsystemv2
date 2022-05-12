Imports MySql.Data.MySqlClient
Public Class functionAbsent
    Dim db As New dbConnector()

    Public Function getAbsent(ByVal command) As DataTable
        command.Connection = db.getConnection()
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        Return table
    End Function


    Public Function getEmployee() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM `employee`", db.getConnection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table
    End Function

    Public Function insertAbsent(employeeid, employee, details, dates) As Boolean
        Dim command As New MySqlCommand("INSERT INTO `absent`(`employee_id`, `employee`, `detail`, `date`) VALUE (@employee_id, @employee, @detail, @date)", db.getConnection)

        command.Parameters.Add("@employee_id", MySqlDbType.Int32).Value = employeeid
        command.Parameters.Add("@employee", MySqlDbType.Text).Value = employee
        command.Parameters.Add("@detail", MySqlDbType.Text).Value = details
        command.Parameters.Add("@date", MySqlDbType.DateTime).Value = dates

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            db.closeConnection()
            Return True
        Else
            db.closeConnection()
            Return False
        End If

    End Function
End Class
