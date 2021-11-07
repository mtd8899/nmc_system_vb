Public Class Class1

    Private Sub txtDate_Leave(sender As Object, e As EventArgs) Handles txtDate.Leave
        If txtDate.Text.Length = 0 Then
            MsgBox("Enter date of payment.")
            txtDate.Focus()

        ElseIf IsDate(txtDate.Text) = False Then
            MsgBox("Please enter correct date of payment.")
            txtDate.Focus()
        End If
    End Sub

    Private Sub txtRefNo_Leave(sender As Object, e As EventArgs) Handles txtRefNo.Leave

        If txtRefNo.Text.Length = 0 Then
            MsgBox("Please enter reference #.")
            txtRefNo.Focus()

        ElseIf txtRefNo.Text.Length <> 5 Then
            MsgBox("Please enter correct reference #.")
            txtRefNo.Focus()
        End If
    End Sub

    Private Sub cboCustName_Leave(sender As Object, e As EventArgs) Handles cboCustName.Leave
        If cboCustName.Text.Length = 0 Then
            MsgBox("Please choose name of payor.")
        End If
    End Sub

    Private Sub txtLoanRep_Leave(sender As Object, e As EventArgs) Handles txtLoanRep.Leave
        If txtLoanRep.Text.Length = 0 Then
            txtLoanRep.Text = 0

        ElseIf IsNumeric(txtLoanRep.Text) = False Then
            MsgBox("Please enter correct amount.")
        End If

        btnSubmit.Enabled = True
    End Sub

    Private Sub txtInsurance_Leave(sender As Object, e As EventArgs) Handles txtInsurance.Leave
        If txtInsurance.Text.Length = 0 Then
            txtInsurance.Text = 0

        ElseIf IsNumeric(txtInsurance.Text) = False Then
            MsgBox("Please enter correct amount.")
        End If
    End Sub

    Private Sub txtRetFund_Leave(sender As Object, e As EventArgs) Handles txtRetFund.Leave
        If txtRetFund.Text.Length = 0 Then
            txtRetFund.Text = 0

        ElseIf IsNumeric(txtRetFund.Text) = False Then
            MsgBox("Please enter correct amount.")
        End If
    End Sub

    Private Sub txtSavingsDep_Leave(sender As Object, e As EventArgs) Handles txtSavingsDep.Leave
        If txtSavingsDep.Text.Length = 0 Then
            txtSavingsDep.Text = 0

        ElseIf IsNumeric(txtSavingsDep.Text) = False Then
            MsgBox("Please enter correct amount.")
        End If
    End Sub

    Private Sub txtPenaltyPaid_Leave(sender As Object, e As EventArgs) Handles txtPenaltyPaid.Leave
        If txtPenaltyPaid.Text.Length = 0 Then
            txtPenaltyPaid.Text = 0

        ElseIf IsNumeric(txtPenaltyPaid.Text) = False Then
            MsgBox("Please enter correct amount.")
        End If
    End Sub

    Private Sub txtAddPenalty_Leave(sender As Object, e As EventArgs) Handles txtAddPenalty.Leave
        If txtAddPenalty.Text.Length = 0 Then
            txtAddPenalty.Text = 0

        ElseIf IsNumeric(txtAddPenalty.Text) = False Then
            MsgBox("Please enter correct amount.")
        End If
    End Sub

    Private Sub txtOtherPayment_Leave(sender As Object, e As EventArgs) Handles txtOtherPayment.Leave
        If txtOtherPayment.Text.Length = 0 Then
            txtOtherPayment.Text = 0

        ElseIf IsNumeric(txtOtherPayment.Text) = False Then
            MsgBox("Please enter correct amount.")
        End If
    End Sub

    Private Sub txtSavingsWithdraw_Leave(sender As Object, e As EventArgs) Handles txtSavingsWithdraw.Leave
        If txtSavingsWithdraw.Text.Length = 0 Then
            txtSavingsWithdraw.Text = 0

        ElseIf IsNumeric(txtSavingsWithdraw.Text) = False Then
            MsgBox("Please enter correct amount.")
        End If
    End Sub
End Class
