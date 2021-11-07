Public Class frmCustomer
    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Nmc_databaseDataSet.customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.Nmc_databaseDataSet.customers)

    End Sub

    Private Sub btnShowfrmAddCust_Click(sender As Object, e As EventArgs) Handles btnShowfrmAddCust.Click
        Dim objfrmCustAdd As New frmCustAdd
        objfrmCustAdd.BringToFront()
        objfrmCustAdd.Show()
    End Sub
End Class