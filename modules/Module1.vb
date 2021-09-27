Imports MySql.Data.MySqlClient

Module Module1
    Public conn As New MySqlConnection
    Public cmd1 As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public data As New DataSet
    Public table As New DataTable
    Public reader As MySqlDataReader
    Public sql1 As String = ""

    Sub openCon()
        conn.ConnectionString = "server=localhost;username=root;password=MySQL@1988;database=nmc_database"
        conn.Open()
    End Sub

End Module
