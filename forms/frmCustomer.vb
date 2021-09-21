Imports System.Data.SqlClient

Public Class frmCustomer
    Private objCustomer As New Customer
    Private frmAddCust As New frmCustAdd

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()

    End Sub

    Public Sub LoadCustomers()
        openCon()
        Try
            cmd1.Connection = conn
            cmd1.CommandText = "SELECT * FROM customers"
            adapter.SelectCommand = cmd1
            table.Clear()
            adapter.Fill(table)
            DataGridView2.DataSource = table
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MsgBox("Connected")
        conn.Close()
    End Sub

    Private Sub btnNewCust_Click(sender As Object, e As EventArgs)
        frmAddCust.BringToFront()
        frmAddCust.Show()
    End Sub

    Private Sub btnOpenCustAddForm_Click(sender As Object, e As EventArgs) Handles btnOpenCustAddForm.Click

        Dim form = New frmCustAdd
        'frmAddCust.BringToFront()
        form.Show()
    End Sub

    Private Sub datGridViewDisp()
        dbconnection()
        sql = "SELECT * FROM tblCustomers WHERE Center =  " \ cboCenter.Text \ ""

        cmd = New SqlCommand(sql, con)
        dataAdapter = New SqlDataAdapter(cmd)
        Dim ds As DataSet = New DataSet()

        'fill the dataset
        dataAdapter.Fill(ds, sql)

        'bind to the datagridview control
        DataGridView2.DataSource = ds

        'set the table in the dataset to display
        DataGridView2.DataMember = sql

        Connection_Close()

    End Sub

    Private Sub cboCenter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCenter.SelectedIndexChanged
        Dim strCenter As String = ""
        Select Case cboCenter.Text

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

        'fill the dataset
        dataAdapter.Fill(ds, sql)

        'bind to the datagridview control
        DataGridView2.DataSource = ds

        'set the table in the dataset to display
        DataGridView2.DataMember = sql

    End Sub

    Private Sub cboCustStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCustStatus.SelectedIndexChanged
        Dim strStatus As String = ""
        Select Case cboCustStatus.Text

            Case "All"
                strStatus = "SELECT * FROM tblCustomers"
            Case "Active"
                strStatus = "SELECT * FROM tblCustomers WHERE CustStatus = 'Active'"
            Case "Savers"
                strStatus = "SELECT * FROM tblCustomers WHERE CustStatus = 'Savers'"
            Case "Overdue"
                strStatus = "SELECT * FROM tblCustomers WHERE  CustStatus = 'Overdue'"
            Case "Inactive"
                strStatus = "SELECT * FROM tblCustomers WHERE  CustStatus = 'Inactive'"

        End Select

        dbconnection()
        sql = strStatus
        cmd = New SqlCommand(sql, con)
        dataAdapter = New SqlDataAdapter(cmd)
        Dim ds As DataSet = New DataSet()

        'fill the dataset
        dataAdapter.Fill(ds, sql)

        'bind to the datagridview control
        DataGridView2.DataSource = ds

        'set the table in the dataset to display
        DataGridView2.DataMember = sql

    End Sub

End Class