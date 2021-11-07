Public Class frmCollection
    Private objLoan As New Loan

    Private Sub frmCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim intCustId As Integer
        openCon()
        Try
            cmd1.Connection = conn
            sql1 = "SELECT * FROM name_lid_bal"
            cmd1.CommandText = sql1
            adapter.SelectCommand = cmd1
            table.Clear()
            adapter.Fill(table)
            cboCustName.DataSource = table
            cboCustName.ValueMember = "id"
            cboCustName.DisplayMember = "name_lid_balance"

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        conn.Close()

        'btnSubmit.Enabled = False

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try

            objLoan.AddPayment(Mid(cboCustName.Text, InStrRev(cboCustName.Text, "(") + 1, 6),
                           cboCustName.SelectedValue,
                           txtDate.Text,
                           txtLoanRep.Text,
                           txtInsurance.Text,
                           txtRefNo.Text,
                           txtRetFund.Text,
                           txtSavingsDep.Text,
                           txtSavingsWithdraw.Text,
                           txtPenaltyPaid.Text,
                           txtOtherPayment.Text,
                           txtOtherPayDesc.Text,
                           txtAddPenalty.Text,
                           txtAddPenNote.Text,
                           txtColBy.Text)

            ClearTextbox()

        Catch ex As Exception
            MsgBox("Please enter correct data.
Error details:
" & ex.ToString)
        End Try

    End Sub

    Public Function GetLoanAccNo()
        Dim intLoanAccNo As Integer
        openCon()
        Try
            cmd1.Connection = conn
            sql1 = "SELECT * FROM name_lid_bal"
            cmd1.CommandText = sql1
            adapter.SelectCommand = cmd1
            table.Clear()
            adapter.Fill(table)
            cboCustName.DataSource = table
            cboCustName.ValueMember = "id"
            cboCustName.DisplayMember = "name_lid_balance"

            Dim pos As Integer = InStrRev(cboCustName.Text, "(")
            intLoanAccNo = Mid(cboCustName.Text, pos + 1, 6)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        conn.Close()

        Return intLoanAccNo
    End Function

    Private Sub txtOtherPayDesc_Click(sender As Object, e As EventArgs) Handles txtOtherPayDesc.Click
        txtTotalPayment.Text = objLoan.CollTotalPaid
    End Sub

    Public Function GetLastRefNo()
        Dim intLastRefNo As Integer

        openCon()
        Try
            cmd1.Connection = conn
            sql1 = "SELECT ref_no FROM tbl_collections WHERE ref_no =(SELECT MAX(ref_no) 
                    FROM tbl_collections)"
            cmd1.CommandText = sql1

            reader = cmd1.ExecuteReader
            If (reader.Read()) Then
                intLastRefNo = reader("ref_no")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            conn.Close()
        End Try

        Return intLastRefNo
    End Function

    Private Sub btnShowLastRefNo_Click(sender As Object, e As EventArgs) Handles btnShowLastRefNo.Click
        MsgBox("Last ref. no.: " & GetLastRefNo())
    End Sub

    Public Sub ClearTextbox()
        If chkCollDate.Checked = False Then
            txtDate.Text = " "
        End If

        If chkRefNo.Checked = False Then
            txtRefNo.Text = " "
        End If

        If chkCollBy.Checked = False Then
            txtColBy.Text = " "
        End If

        cboCustName.Text = " "
        txtLoanRep.Text = " 0"
        txtInsurance.Text = "0"
        txtRetFund.Text = "0"
        txtSavingsDep.Text = "0"
        txtPenaltyPaid.Text = "0"
        txtAddPenalty.Text = "0"
        txtAddPenNote.Text = " "
        txtOtherPayment.Text = "0"
        txtOtherPayDesc.Text = " "
        txtTotalPayment.Text = "0"
        txtSavingsWithdraw.Text = "0"

    End Sub

End Class