Public Class frmLoans
    Private Sub TabPage3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles tabAddLoan.Click

    End Sub

    Private Sub frmLoans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewMalayan1DataSet.tblCollection' table. You can move, or remove it, as needed.
        Me.TblCollectionTableAdapter.Fill(Me.NewMalayan1DataSet.tblCollection)
        'TODO: This line of code loads data into the 'NewMalayan1DataSet.tblCollection' table. You can move, or remove it, as needed.
        Me.TblCollectionTableAdapter.Fill(Me.NewMalayan1DataSet.tblCollection)
        'TODO: This line of code loads data into the 'NewMalayan1DataSet.tblCollectionLoan' table. You can move, or remove it, as needed.
        Me.TblLoanReleaseTableAdapter.Fill(Me.NewMalayan1DataSet.tblLoanRelease)

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