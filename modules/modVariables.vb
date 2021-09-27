Imports System.Data.SqlClient

Module modVaraibles
    'Public dbPath As String = "Data Source=JERICHO\SQLEXPRESS;Initial Catalog=NewMalayan;Integrated Security=True"
    Public dbPath As String = "Data Source=JERICHO\SQLEXPRESS;Initial Catalog=NewMalayan1;Integrated Security=True"
    Public con As SqlConnection
    Public sql As String = ""
    Public dataAdapter As SqlDataAdapter
    Public cmd As SqlCommand
    Public dataReader As SqlDataReader

End Module
