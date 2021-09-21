Imports System.Data.SqlClient

Public Class Customer

    Public Sub AddCustomer_my(strCustID As String, strCustFname As String, strCustMname As String, strCustLname As String _
                            , strCustSname As String, strCustAdd As String, strCustContact As String _
                            , strCustCenter As String, strCustOcc As String, strCustDOB As String _
                            , strDOM As String, strCustSpouse As String, strCustBplace As String, strCustStatus As String)
        openCon()

        Try
            cmd1.Connection = conn
            cmd1.CommandText = "INSERT INTO customers VALUES(@CustID, @CustFname, @CustMname, @CustLname, @CustSname, @CustAdd, @CustContact, @Center, @CustOcc, @CustDOB, @CustDOM, @CustSpouse, @CustBplace, @CustStatus)"

            'sql = "INSERT INTO customers VALUES(@CustID, @CustFname, @CustMname, @CustLname, @CustSname, @CustAdd, @CustContact, @Center, @CustOcc, @CustDOB, @CustDOM, @CustSpouse, @CustBplace, @CustStatus)"
            'cmd = New SqlCommand(sql, conn)

            cmd1.Parameters.AddWithValue("@CustID", strCustID)
            cmd1.Parameters.AddWithValue("@CustFname", strCustFname)
            cmd1.Parameters.AddWithValue("@CustMname", strCustMname)
            cmd1.Parameters.AddWithValue("@CustLname", strCustLname)
            cmd1.Parameters.AddWithValue("@CustSname", strCustSname)
            cmd1.Parameters.AddWithValue("@CustAdd", strCustAdd)
            cmd1.Parameters.AddWithValue("@CustContact", strCustContact)
            cmd1.Parameters.AddWithValue("@Center", strCustCenter)
            cmd1.Parameters.AddWithValue("@CustOcc", strCustOcc)
            cmd1.Parameters.AddWithValue("@CustDOB", strCustDOB)
            cmd1.Parameters.AddWithValue("@CustDOM", strDOM)
            cmd1.Parameters.AddWithValue("@CustSpouse", strCustSpouse)
            cmd1.Parameters.AddWithValue("@CustBplace", strCustBplace)
            cmd1.Parameters.AddWithValue("@CustStatus", strCustStatus)
            cmd1.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try

        MsgBox("Customer added successfully!")

    End Sub

    Public Function CreateCId()
        Dim intCustID As Integer

        openCon()
        sql = "SELECT CustID FROM customers WHERE CustID=(SELECT MAX(CustID) FROM customers)"

        cmd1 = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)

        reader = cmd1.ExecuteReader
        If (reader.Read()) Then
            intCustID = reader("CustID") + 1
        End If
        conn.Close()
        Return intCustID


    End Function

    Public Sub AddCustomer(strCustID As String, strCustFname As String, strCustMname As String, strCustLname As String _
                            , strCustSname As String, strCustAdd As String, strCustContact As String _
                            , strCustCenter As String, strCustOcc As String, strCustDOB As String _
                            , strDOM As String, strCustSpouse As String, strCustBplace As String, strCustStatus As String)
        Try
            dbconnection()
            sql = "INSERT INTO tblCustomers VALUES(@CustID, @CustFname, @CustMname, @CustLname, @CustSname, @CustAdd, @CustContact, @Center, @CustOcc, @CustDOB, @CustDOM, @CustSpouse, @CustBplace, @CustStatus)"
            cmd = New SqlCommand(sql, con)

            cmd.Parameters.AddWithValue("@CustID", strCustID)
            cmd.Parameters.AddWithValue("@CustFname", strCustFname)
            cmd.Parameters.AddWithValue("@CustMname", strCustMname)
            cmd.Parameters.AddWithValue("@CustLname", strCustLname)
            cmd.Parameters.AddWithValue("@CustSname", strCustSname)
            cmd.Parameters.AddWithValue("@CustAdd", strCustAdd)
            cmd.Parameters.AddWithValue("@CustContact", strCustContact)
            cmd.Parameters.AddWithValue("@Center", strCustCenter)
            cmd.Parameters.AddWithValue("@CustOcc", strCustOcc)
            cmd.Parameters.AddWithValue("@CustDOB", strCustDOB)
            cmd.Parameters.AddWithValue("@CustDOM", strDOM)
            cmd.Parameters.AddWithValue("@CustSpouse", strCustSpouse)
            cmd.Parameters.AddWithValue("@CustBplace", strCustBplace)
            cmd.Parameters.AddWithValue("@CustStatus", strCustStatus)
            cmd.ExecuteNonQuery()

            'MsgBox("Customer added successfully!")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connection_Close()

        End Try

        MsgBox("Customer added successfully!")
    End Sub

    Public Sub ClearAll(txtControl As Control)
        'Dim txtControl As Control

        For Each txtControl In txtControl.Controls
            'If TypeOf (txtControl) Is TextBox Then
            txtControl.Text  = ""
            ' End If
        Next

    End Sub

    Public Sub CallOnComboCustCenter(cboCustStat As ComboBox)
        dbconnection()

        If (cboCustStat.Text = "All") Then
            sql = "SELECT * FROM tblCustomers"
        End If
    End Sub

    Public Sub clearTextbox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            clearTextbox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next
    End Sub

    Public Function FilterCustByCenter(ByVal strCenter As String)
        'Dim strCenter As String = ""
        Dim dataSet = New DataSet
        Select Case strCenter

            Case "All"
                strCenter = "SELECT * FROM tblCustomers"
            Case "Masalong"
                strCenter = "SELECT * FROM tblCustomers WHERE Center = 'Masalong'"
            Case "Calabasa"
                strCenter = "SELECT * FROM tblCustomers WHERE Center = 'Calabasa'"
            Case "Malangcao-Basud"
                strCenter = "SELECT * FROM tblCustomers WHERE Center = 'Malangcao-Basud'"
            Case "Tigbinan"
                strCenter = "SELECT * FROM tblCustomers WHERE Center = 'Tigbinan'"
            Case "Guisican"
                strCenter = "SELECT * FROM tblCustomers WHERE Center = 'Guisican'"
            Case "Kabungahan"
                strCenter = "SELECT * FROM tblCustomers WHERE Center = 'Kabungahan'"
            Case "Labo"
                strCenter = "SELECT * FROM tblCustomers WHERE Center = 'Labo'"
            Case "Pag-asa"
                strCenter = "SELECT * FROM tblCustomers WHERE Center = 'Pag-asa'"

        End Select

        dbconnection()
        sql = strCenter
        cmd = New SqlCommand(sql, con)
        dataAdapter = New SqlDataAdapter(cmd)
        Dim ds As DataSet = New DataSet()
        Dim datGridCust = New DataGridView

        'fill the dataset
        dataAdapter.Fill(ds, sql)

        'bind to the datagridview control
        datGridCust.DataSource = ds

        'set the table in the dataset to display
        datGridCust.DataMember = sql
        Return dataSet
        MsgBox("Hi")
    End Function

    Public Function CreateCustID()
        Dim intCustID As Integer

        dbconnection()
        sql = "SELECT CustID FROM tblCustomers WHERE CustID=(SELECT MAX(CustID) FROM tblCustomers)"

        cmd = New SqlClient.SqlCommand(sql, con)

        dataReader = cmd.ExecuteReader
        If (dataReader.Read()) Then
            intCustID = dataReader("CustID") + 1
        End If

        Return intCustID
    End Function

    Public Sub DataBinding()
        openCon()
        Try
            cmd1.Connection = conn
            cmd1.CommandText = "SELECT CustID FROM customers WHERE CustID=(SELECT MAX(CustID) FROM customers)"
            adapter.SelectCommand = cmd1
            data.Clear()
            adapter.Fill(data, "CustId")

            'txtCustID.DataBindings.Add("Text", data, "CustId.CUstID")
            'txtCustID.Text += 1
            'txtCustID.DataBindings.Clear()

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally

        End Try
    End Sub
End Class