Imports MySql.Data.MySqlClient
Public Class functionAccount
    Dim db As New dbConnector()

    Public Function insertAccount(ByVal name As String, ByVal username As String, ByVal password As String) As Boolean
        Dim command As New MySqlCommand("INSERT INTO `user_accounts`(`name`, `username`, `password`) VALUE (@name, @username, @password)", db.getConnection)

        command.Parameters.Add("@name", MySqlDbType.Text).Value = name
        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password

        db.openConnection()

        If command.ExecuteNonQuery = 1 Then
            db.closeConnection()
            Return True
        Else
            db.closeConnection()
            Return False
        End If
    End Function
End Class
