Public Class frmCustAdd
    Dim objCustomer As New Customer

    Private Sub btnCustAdd_Click_1(sender As Object, e As EventArgs) Handles btnCustAdd.Click
        objCustomer.AddCustomer_my(Me.txtCustID.Text, Me.txtCustFirstName.Text, Me.txtCustMiddleName.Text, Me.txtCustLastName.Text _
                                , Me.txtCustSuffName.Text, Me.txtCustStreet.Text & ", " & Me.txtCustBrgy.Text & ", " & Me.txtCustMun.Text _
                                & ", " & Me.txtCustProvince.Text, Me.txtCustNoHome.Text & "/" & Me.txtCustContact2.Text & "/" & Me.txtCustNoSpouse.Text _
                                , Me.cboCenter.SelectedItem, Me.txtCustOcc.Text, Me.dtDOB.Text, Me.dtDOM.Text, Me.txtCustSpouse.Text, Me.txtCustBplace.Text, Me.txtCustStatus.Text)

        objCustomer.clearTextbox(Me)
        txtCustID.Text = ""

    End Sub

    Private Sub txtCustFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtCustFirstName.TextChanged
        txtCustID.Text = objCustomer.CreateCId()

    End Sub

End Class