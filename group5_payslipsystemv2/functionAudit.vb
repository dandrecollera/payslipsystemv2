Imports MySql.Data.MySqlClient
Public Class functionAudit
    Dim db As New dbConnector()
    Public Function getAudit(command) As DataTable
        command.Connection = db.getConnection()
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        Return table
    End Function

    Public Function insertAudit(details) As Boolean
        Dim command As New MySqlCommand("INSERT INTO `audits`(`user_id`, `user`, `detail`) VALUE (@user_id, @user, @detail)", db.getConnection)

        command.Parameters.Add("@user_id", MySqlDbType.Int32).Value = My.Settings.idauth
        command.Parameters.Add("@user", MySqlDbType.Text).Value = My.Settings.name
        command.Parameters.Add("@detail", MySqlDbType.Text).Value = details

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
