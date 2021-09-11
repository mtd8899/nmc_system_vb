Public Class frmLoans
    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles tabAddLoan.Click

    End Sub

    Private Sub frmLoans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewMalayan1DataSet.tblLoanRelease' table. You can move, or remove it, as needed.
        Me.TblLoanReleaseTableAdapter.Fill(Me.NewMalayan1DataSet.tblLoanRelease)

    End Sub
End Class