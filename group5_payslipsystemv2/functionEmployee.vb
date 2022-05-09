Imports MySql.Data.MySqlClient
Public Class functionEmployee
    Dim db As New dbConnector()

    Public Function insertEmployee(ByVal name As String, ByVal email As String, ByVal contact As String, ByVal address As String, ByVal baseSalary As Double) As Boolean
        Dim command As New MySqlCommand("INSERT INTO `employee`(`name`, `email`, `contact`, `address`, `base_salary`) VALUE (@name, @email, @contact, @address, @base_salary)", db.getConnection)

        command.Parameters.Add("@name", MySqlDbType.Text).Value = name
        command.Parameters.Add("@email", MySqlDbType.Text).Value = email
        command.Parameters.Add("@contact", MySqlDbType.VarChar).Value = contact
        command.Parameters.Add("@address", MySqlDbType.MediumText).Value = address
        command.Parameters.Add("@base_salary", MySqlDbType.Int32).Value = baseSalary

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            db.closeConnection()
            Return True
        Else
            db.closeConnection()
            Return False
        End If
    End Function

    Public Function updateEmployee(ByVal id As Decimal, ByVal name As String, ByVal email As String, ByVal contact As String, ByVal address As String, ByVal baseSalary As Double) As Boolean
        Dim command As New MySqlCommand("UPDATE `employee` SET `name` = @name, `email` = @email, `contact` = @contact, `address` = @address, `base_salary` = @base_salary WHERE `id` = @id", db.getConnection)

        command.Parameters.Add("@id", MySqlDbType.Int32).Value = id
        command.Parameters.Add("@name", MySqlDbType.Text).Value = name
        command.Parameters.Add("@email", MySqlDbType.Text).Value = email
        command.Parameters.Add("@contact", MySqlDbType.VarChar).Value = contact
        command.Parameters.Add("@address", MySqlDbType.MediumText).Value = address
        command.Parameters.Add("@base_salary", MySqlDbType.Int32).Value = baseSalary

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            db.closeConnection()
            Return True
        Else
            db.closeConnection()
            Return False
        End If
    End Function

    Public Function deleteEmployee(ByVal id As Decimal) As Boolean
        Dim command As New MySqlCommand("DELETE FROM `employee` WHERE `id` = @id", db.getConnection)
        command.Parameters.Add("@id", MySqlDbType.Int32).Value = id

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            db.closeConnection()
            Return True
        Else
            db.closeConnection()
            Return False
        End If
    End Function

    Public Function getEmployee(ByVal command As MySqlCommand) As DataTable
        command.Connection = db.getConnection
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        Return table
    End Function
End Class
