Imports MySql.Data.MySqlClient

Module Module1
    Public conn As New MySqlConnection
    Public cmd1 As New MySqlCommand

    Sub openCon()
        conn.ConnectionString = "server=localhost;username=root;password=MySQL@1988;database=nmc_database"
        conn.Open()
    End Sub
End Module
