Public Class frmLoans

    Private Sub frmLoans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Nmc_databaseDataSet.tbl_collections' table. You can move, or remove it, as needed.
        Me.Tbl_collectionsTableAdapter.Fill(Me.Nmc_databaseDataSet.tbl_collections)
        'TODO: This line of code loads data into the 'Nmc_databaseDataSet.v_loan_current' table. You can move, or remove it, as needed.
        Me.V_loan_currentTableAdapter.Fill(Me.Nmc_databaseDataSet.v_loan_current)
        'TODO: This line of code loads data into the 'Nmc_databaseDataSet.loan_balance' table. You can move, or remove it, as needed.
        Me.Loan_balanceTableAdapter.Fill(Me.Nmc_databaseDataSet.loan_balance)
        'TODO: This line of code loads data into the 'Nmc_databaseDataSet.v_loan_od120' table. You can move, or remove it, as needed.
        Me.V_loan_od120TableAdapter.Fill(Me.Nmc_databaseDataSet.v_loan_od120)
        'TODO: This line of code loads data into the 'Nmc_databaseDataSet.v_loan_od90' table. You can move, or remove it, as needed.
        Me.V_loan_od90TableAdapter.Fill(Me.Nmc_databaseDataSet.v_loan_od90)
        'TODO: This line of code loads data into the 'Nmc_databaseDataSet.v_loan_od60' table. You can move, or remove it, as needed.
        Me.V_loan_od60TableAdapter.Fill(Me.Nmc_databaseDataSet.v_loan_od60)
        'TODO: This line of code loads data into the 'Nmc_databaseDataSet.v_loan_od30' table. You can move, or remove it, as needed.
        Me.V_loan_od30TableAdapter.Fill(Me.Nmc_databaseDataSet.v_loan_od30)
        'TODO: This line of code loads data into the 'Nmc_databaseDataSet.v_loan_od' table. You can move, or remove it, as needed.
        Me.V_loan_odTableAdapter.Fill(Me.Nmc_databaseDataSet.v_loan_od)
        'TODO: This line of code loads data into the 'Nmc_databaseDataSet.loan_balance' table. You can move, or remove it, as needed.
        Me.Loan_balanceTableAdapter.Fill(Me.Nmc_databaseDataSet.loan_balance)

    End Sub

    Public Sub LoadData()
        openCon()

        Try
            cmd1.Connection = conn
            cmd1.CommandText = "SELECT * FROM loan_release"
            adapter.SelectCommand = cmd1
            table.Clear()
            adapter.Fill(table)
            dgViewLoans.DataSource = table
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        conn.Close()
    End Sub

    Private Sub btnShowfrmLoanAdd_Click(sender As Object, e As EventArgs) Handles btnShowfrmLoanAdd.Click
        Dim form = New frmLoanAdd
        'frmAddCust.BringToFront()
        form.Show()
    End Sub

    Private Sub btnShowAddPayment_Click(sender As Object, e As EventArgs) Handles btnShowAddPayment.Click
        Dim form = New frmCollection
        'frmAddCust.BringToFront()
        form.Show()
    End Sub


End Class