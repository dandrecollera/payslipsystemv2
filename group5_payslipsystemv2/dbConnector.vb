Imports MySql.Data.MySqlClient
Public Class dbConnector
    Dim connection As New MySqlConnection("datasource=localhost; port=3306; username=root; password= ; database=payslipdbv2")

    Public Function getConnection() As MySqlConnection
        Return connection
    End Function

    Public Sub openConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    Public Sub closeConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
End Class
