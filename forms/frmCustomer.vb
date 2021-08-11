Imports System.Data.SqlClient

Public Class frmCustomer
    Private objCustomer As New Customer
    Private frmAddCust As New frmCustAdd
    Private db As NewMalayan1Entities1

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewMalayan1DataSet.tblCustomers' table. You can move, or remove it, as needed.
        Me.TblCustomersTableAdapter.Fill(Me.NewMalayan1DataSet.tblCustomers)
        'TODO: This line of code loads data into the 'NewMalayan1DataSet.tblCustomers' table. You can move, or remove it, as needed.
        Me.TblCustomersTableAdapter.Fill(Me.NewMalayan1DataSet.tblCustomers)
        db = New NewMalayan1Entities1()


    End Sub

    Private Sub btnNewCust_Click(sender As Object, e As EventArgs) Handles btnNewCust.Click
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

    Private Sub btnCustAdd_Click(sender As Object, e As EventArgs) Handles btnCustAdd.Click

    End Sub

    Private Sub txtCustID_TextChanged(sender As Object, e As EventArgs) Handles txtCustID.TextChanged

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

    Private Sub btnPrintRepCust_Click(sender As Object, e As EventArgs) Handles btnPrintRepCust.Click
        db = New NewMalayan1Entities1()

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class