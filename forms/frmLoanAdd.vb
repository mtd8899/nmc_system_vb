'Option Strict On
Public Class frmLoanAdd
    Dim objLoan As New Loan

    Private Sub btnLoanAdd_Click(sender As Object, e As EventArgs) Handles btnLoanAdd.Click
        Try

            objLoan.AddLoan(cboCustName.SelectedValue, cboCustName.Text, txtDateRel.Text, txtPrincipal.Text,
                        txtInterest.Text, txtProcFee.Text, cboTerms.Text, txtCycleNo.Text,
                        cboLoanType.Text, txtCoMaker.Text, txtCollateral.Text)

        lblLoanAcc.Text = objLoan.LoanAccNo
        lblCustID.Text = cboCustName.SelectedValue
        lblCustName.Text = objLoan.CustomerName
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

            MsgBox("Loan added successfully!")


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmLoanAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        openCon()
        Try
            cmd1.Connection = conn
            sql1 = "SELECT * FROM name_and_id"
            cmd1.CommandText = sql1
            adapter.SelectCommand = cmd1
            table.Clear()
            adapter.Fill(table)
            cboCustName.DataSource = table
            cboCustName.ValueMember = "id"
            cboCustName.DisplayMember = "fullname_and_id"

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        conn.Close()

    End Sub

End Class