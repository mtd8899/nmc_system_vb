Public Class frmCustAdd
    Dim objCustomer As New Customer

    Private Sub btnCustAdd_Click_1(sender As Object, e As EventArgs) Handles btnCustAdd.Click
        objCustomer.AddCustomer(Me.txtCustID.Text, Me.txtCustFirstName.Text, Me.txtCustMiddleName.Text, Me.txtCustLastName.Text _
                                , Me.txtCustSuffName.Text, Me.txtCustStreet.Text & ", " & Me.txtCustBrgy.Text & ", " & Me.txtCustMun.Text _
                                & ", " & Me.txtCustProvince.Text, Me.txtCustNoHome.Text & "/" & Me.txtCustContact2.Text & "/" & Me.txtCustNoSpouse.Text _
                                , Me.cboCenter.Text, Me.txtCustOcc.Text, Me.txtCustDOB.Text, Me.txtCustDOM.Text, Me.txtCustSpouse.Text, Me.txtCustBplace.Text, Me.txtCustStatus.Text)
        objCustomer.clearTextbox(Me)
        Me.txtCustID.Text = ""
    End Sub

    Private Sub txtCustFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtCustFirstName.TextChanged
        Me.txtCustID.Text = objCustomer.CreateCustID()
    End Sub

    Private Sub frmCustAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewMalayan1DataSet.tblCustomers' table. You can move, or remove it, as needed.
        Me.TblCustomersTableAdapter.Fill(Me.NewMalayan1DataSet.tblCustomers)

    End Sub
End Class