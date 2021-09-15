Public Class frmCollection
    Dim objLoan As New Loan()

    ' Public Sub New(objCollection As Collection)
    'Me.objCollection = objCollection
    'End Sub

    Private Sub lblLoanRep_Click(sender As Object, e As EventArgs) Handles lblLoanRep.Click, Label2.Click

    End Sub

    Private Sub frmCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewMalayan1DataSet.tblCollectionLoan' table. You can move, or remove it, as needed.
        Me.TblCollectionLoanTableAdapter.Fill(Me.NewMalayan1DataSet.tblCollectionLoan)

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'objLoan.AddCollection(txtDate.Text, txtRefNo.Text, txtLoanRep.Text, txtInsurance.Text, txtRetFund.Text _
        ' , txtSavings.Text, txtPenaltyPaid.Text, txtAddPenalty.Text, txtColBy.Text)

        Dim objCollection As New Collection(txtDate.Text, txtRefNo.Text, txtLoanRep.Text, txtInsurance.Text, txtRetFund.Text _
                                            , txtSavings.Text, txtPenaltyPaid.Text, txtAddPenalty.Text, txtColBy.Text)

        objCollection.AddCollection()
        objCollection.AddCollectionLoan()

    End Sub

End Class