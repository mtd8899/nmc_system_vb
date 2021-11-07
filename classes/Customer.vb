Imports System.Data.SqlClient

Public Class Customer

    Public Sub AddCustomer_my(strCustID As String, strCustFname As String, strCustMname As String _
                            , strCustLname As String, strCustSname As String, strCustAdd As String _
                            , strCustContact As String, strCustCenter As String, strCustOcc As String _
                            , strCustDOB As String, strDOM As String, strCustSpouse As String _
                            , strCustBplace As String, strCustStatus As String)
        openCon()

        Try
            cmd1.Connection = conn
            cmd1.CommandText = "INSERT INTO customers VALUES(@id, @firstname, @middlename, @lastname,
                                @suffixname, @address, @contact, @center, @occupation, @birthdate, @membership_date,
                                @spouse, @birthplace, @status)"

            cmd1.Parameters.AddWithValue("@id", strCustID)
            cmd1.Parameters.AddWithValue("@firstname", strCustFname)
            cmd1.Parameters.AddWithValue("@middlename", strCustMname)
            cmd1.Parameters.AddWithValue("@CustLname", strCustLname)
            cmd1.Parameters.AddWithValue("@suffixname", strCustSname)
            cmd1.Parameters.AddWithValue("@address", strCustAdd)
            cmd1.Parameters.AddWithValue("@contact", strCustContact)
            cmd1.Parameters.AddWithValue("@center", strCustCenter)
            cmd1.Parameters.AddWithValue("@occupation", strCustOcc)
            cmd1.Parameters.AddWithValue("@birtdate", strCustDOB)
            cmd1.Parameters.AddWithValue("@membership_date", strDOM)
            cmd1.Parameters.AddWithValue("@spouse", strCustSpouse)
            cmd1.Parameters.AddWithValue("@birthplace", strCustBplace)
            cmd1.Parameters.AddWithValue("@status", strCustStatus)
            cmd1.ExecuteNonQuery()

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try

        MsgBox("Customer added successfully!")

    End Sub

    Public Function CreateCId()
        Dim intCustID As Integer

        openCon()
        sql1 = "SELECT id FROM customers WHERE id=(SELECT MAX(id) FROM customers)"
        cmd1 = New MySql.Data.MySqlClient.MySqlCommand(sql1, conn)

        reader = cmd1.ExecuteReader
        If (reader.Read()) Then
            intCustID = reader("id") + 1
        End If

        conn.Close()

        Return intCustID

    End Function

    Public Sub ClearAll(txtControl As Control)
        'Dim txtControl As Control

        For Each txtControl In txtControl.Controls
            'If TypeOf (txtControl) Is TextBox Then
            txtControl.Text = ""
            ' End If
        Next

    End Sub

    Public Sub CallOnComboCustCenter(cboCustStat As ComboBox)
        dbconnection()

        If (cboCustStat.Text = "All") Then
            sql = "SELECT * FROM customers"
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
                strCenter = "SELECT * FROM customers"
            Case "Masalong"
                strCenter = "SELECT * FROM customers WHERE Center = 'Masalong'"
            Case "Calabasa"
                strCenter = "SELECT * FROM customers WHERE Center = 'Calabasa'"
            Case "Malangcao-Basud"
                strCenter = "SELECT * FROM customers WHERE Center = 'Malangcao-Basud'"
            Case "Tigbinan"
                strCenter = "SELECT * FROM customers WHERE Center = 'Tigbinan'"
            Case "Guisican"
                strCenter = "SELECT * FROM customers WHERE Center = 'Guisican'"
            Case "Kabungahan"
                strCenter = "SELECT * FROM customers WHERE Center = 'Kabungahan'"
            Case "Labo"
                strCenter = "SELECT * FROM customers WHERE Center = 'Labo'"
            Case "Pag-asa"
                strCenter = "SELECT * FROM customers WHERE Center = 'Pag-asa'"

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
        sql = "SELECT id FROM customers WHERE id=(SELECT MAX(id) FROM customers)"

        cmd = New SqlClient.SqlCommand(sql, con)

        dataReader = cmd.ExecuteReader
        If (dataReader.Read()) Then
            intCustID = dataReader("id") + 1
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