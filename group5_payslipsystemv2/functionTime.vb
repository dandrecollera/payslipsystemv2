Imports MySql.Data.MySqlClient
Public Class functionTime
    Dim db As New dbConnector()

    Public Function getEmployee() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM `employee`", db.getConnection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table
    End Function

    Public Function insertTime(ByVal employeeId As Decimal, ByVal employee As String, ByVal timein As Date, ByVal timeout As Date, ByVal regular As Decimal, ByVal overtime As Decimal, ByVal minute As Decimal) As Boolean
        Dim command As New MySqlCommand("INSERT INTO `timeinout`(`employee_id`, `employee`, `timein`, `timeout`, `regular`, `overtime`, `minute`, `date`) VALUE (@employee_id, @employee, @timein, @timeout, @regular, @overtime, @minute, @date)", db.getConnection)

        command.Parameters.Add("@employee_id", MySqlDbType.Int32).Value = employeeId
        command.Parameters.Add("@employee", MySqlDbType.Text).Value = employee
        command.Parameters.Add("@timein", MySqlDbType.DateTime).Value = timein
        command.Parameters.Add("@timeout", MySqlDbType.DateTime).Value = timeout
        command.Parameters.Add("@regular", MySqlDbType.Int32).Value = regular
        command.Parameters.Add("@overtime", MySqlDbType.Int32).Value = overtime
        command.Parameters.Add("@minute", MySqlDbType.Int32).Value = minute
        command.Parameters.Add("@date", MySqlDbType.DateTime).Value = Date.Now()

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
