'Option Strict On
Public Class frmLoanAdd
    Dim objLoan As New Loan

    Private Sub btnLoanAdd_Click(sender As Object, e As EventArgs) Handles btnLoanAdd.Click
        objLoan.AddLoan(cboCustName.SelectedValue, cboCustName.Text, txtDateRel.Text, CInt(txtPrincipal.Text), CInt(txtInterest.Text), CInt(txtProcFee.Text) _
                        , CInt(cboTerms.Text), txtCycleNo.Text, cboLoanType.Text)

        lblLoanAcc.Text = objLoan.LoanAccNo
        lblCustID.Text = cboCustName.SelectedValue
        lblCustName.Text = objLoan.Customer
        lblAmort.Text = objLoan.Amort
        lblPrincipal.Text = objLoan.PrincipalAmt
        lblMaturity.Text = objLoan.Maturity
        lblDateRel.Text = objLoan.Release
        lblCycle.Text = objLoan.NoOfCycle
        lblType.Text = objLoan.TypeOfLoan
        lblInteresst.Text = objLoan.ShowRate

        'Amortization Table
        lstAmortTable.Items.Add("No." & vbTab & "Date" & vbTab & "Principal" & vbTab & "Interest" & vbTab & "Proc." & vbTab & "Balance")

        Dim No As Integer = 0
        Do Until No = objLoan.Terms
            No += 1
            objLoan.Payable -= objLoan.Amort
            objLoan.Release = DateAdd("ww", 1, objLoan.Release)

            lstAmortTable.Items.Add(No & ".)" & vbTab & objLoan.Release.ToString("MM/dd/yy") & vbTab & objLoan.Amort & vbTab &
                                    objLoan.RepInt & vbTab & objLoan.RepProcFee & vbTab & objLoan.Payable.ToString("###,##0"))
        Loop


    End Sub

    Private Sub cboCustName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCustName.SelectedIndexChanged

    End Sub

    Private Sub frmLoanAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconnection()
        sql = "SELECT * FROM viewCustName"
        cmd = New SqlClient.SqlCommand(sql, con)

        dataAdapter = New SqlClient.SqlDataAdapter(cmd)
        Dim table As New DataTable()
        dataAdapter.Fill(table)
        cboCustName.DataSource = table
        cboCustName.DisplayMember = "CustName"
        cboCustName.ValueMember = "CustID"
    End Sub
End Class