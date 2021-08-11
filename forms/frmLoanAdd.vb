Option Strict On
Public Class frmLoanAdd
    Dim objLoan As New Loan

    Private Sub btnLoanAdd_Click(sender As Object, e As EventArgs) Handles btnLoanAdd.Click

        objLoan.AddLoan(cboCustName.Text, txtDateRel.Text, CInt(txtPrincipal.Text), CInt(txtInterest.Text), CInt(txtProcFee.Text) _
                        , CInt(cboTerms.Text), txtCycleNo.Text, cboLoanType.Text)
        lblAmort.Text = objLoan.Amort
        lblPrincipal.Text = objLoan.PrincipalAmt
        lblMaturity.Text = objLoan.Maturity
        lblDateRel.Text = objLoan.Release
        lblCycle.Text = objLoan.NoOfCycle
        lblType.Text = objLoan.TypeOfLoan
        lblInteresst.Text = objLoan.ShowRate
        lblCustName.Text = objLoan.Customer

    End Sub

    Private Sub cboCustName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCustName.SelectedIndexChanged
        dbconnection()
        sql = "SELECT CustFname FROM tblCustomers"
        cmd = New SqlClient.SqlCommand(sql, con)

        dataAdapter = New SqlClient.SqlDataAdapter(cmd)
        Dim table As New DataTable()
        dataAdapter.Fill(table)
        cboCustName.DataSource = table
        cboCustName.DisplayMember = "CustFname"
        cboCustName.ValueMember = "CustID"

    End Sub

End Class