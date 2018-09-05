Imports MySql.Data.MySqlClient
Module DatabaseCon
    Dim MysqlConn As New MySqlConnection

    Public Function myconn() As MySqlConnection

        Return New MySqlConnection(My.Settings.mydbConnection)


    End Function
End Module
