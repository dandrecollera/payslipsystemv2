Imports MySql.Data.MySqlClient
Public Class functionReports
    Dim db As New dbConnector()

    Public Function insertReport(ByVal authid As Decimal, ByVal author As String, ByVal title As String, ByVal report As String) As Boolean
        Dim command As New MySqlCommand("INSERT INTO `reports`(`authid`, `author`, `title`, `report`) VALUE (@authid, @author, @title, @report)", db.getConnection)

        command.Parameters.Add("@authid", MySqlDbType.Int32).Value = authid
        command.Parameters.Add("@author", MySqlDbType.Text).Value = author
        command.Parameters.Add("@title", MySqlDbType.Text).Value = title
        command.Parameters.Add("@report", MySqlDbType.Text).Value = report

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            db.closeConnection()
            Return True
        Else
            db.closeConnection()
            Return False
        End If
    End Function

    Public Function updateReport(ByVal id As Decimal, ByVal authid As Decimal, ByVal author As String, ByVal title As String, ByVal report As String) As Boolean
        Dim command As New MySqlCommand("UPDATE `reports` SET `authid` = @authid, `author` = @author, `title` = @title, `report` = @report WHERE `id` = @id", db.getConnection)

        command.Parameters.Add("@id", MySqlDbType.Int32).Value = id
        command.Parameters.Add("@authid", MySqlDbType.Int32).Value = authid
        command.Parameters.Add("@author", MySqlDbType.Text).Value = author
        command.Parameters.Add("@title", MySqlDbType.Text).Value = title
        command.Parameters.Add("@report", MySqlDbType.Text).Value = report

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            db.closeConnection()
            Return True
        Else
            db.closeConnection()
            Return False
        End If
    End Function

    Public Function deleteReport(ByVal id As Decimal) As Boolean
        Dim command As New MySqlCommand("DELETE FROM `reports` WHERE `id` = @id", db.getConnection)
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

    Public Function getReports(ByVal command As MySqlCommand) As DataTable
        command.Connection = db.getConnection
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        Return table
    End Function
End Class
