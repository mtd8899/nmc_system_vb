Public Class frmHome
    Private currentChildForm As Object
    Private currentButton As Object

    Private Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = False
        childForm.Dock = DockStyle.Fill
        pnlDesktop.Controls.Add(childForm)
        pnlDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text
    End Sub
    Private Sub ActivateButton(senderButton As Button)
        'currentButton = CType(senderButton, Button)
        picFormIcon.Image = senderButton.Image
    End Sub
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        OpenChildForm(New frmDashboard)
    End Sub

    Private Sub btnLoan_Click(sender As Object, e As EventArgs) Handles btnLoan.Click
        OpenChildForm(New frmLoans)
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        OpenChildForm(New frmCustomer)
    End Sub

    Private Sub btnSavings_Click(sender As Object, e As EventArgs) Handles btnSavings.Click
        OpenChildForm(New frmSavings)
    End Sub

    Private Sub btnInsurance_Click(sender As Object, e As EventArgs) Handles btnInsurance.Click
        OpenChildForm(New frmInsurance)
    End Sub

    Private Sub btnAccounting_Click(sender As Object, e As EventArgs) Handles btnAccounting.Click
        OpenChildForm(New frmAccounting)
    End Sub

    Private Sub pnlDesktop_Paint(sender As Object, e As PaintEventArgs) Handles pnlDesktop.Paint

    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pnlLogo_Paint(sender As Object, e As PaintEventArgs) Handles pnlLogo.Paint

    End Sub

    Private Sub pnlSideMenu_Paint(sender As Object, e As PaintEventArgs) Handles pnlSideMenu.Paint

    End Sub

    Private Sub pnlCompanyName_Paint(sender As Object, e As PaintEventArgs) Handles pnlCompanyName.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub picFormIcon_Click(sender As Object, e As EventArgs) Handles picFormIcon.Click

    End Sub

    Private Sub lblFormTitle_Click(sender As Object, e As EventArgs) Handles lblFormTitle.Click

    End Sub

    Private Sub pnlFormTitle_Paint(sender As Object, e As PaintEventArgs) Handles pnlFormTitle.Paint

    End Sub

    Private Sub pnlMenuContainer_Paint(sender As Object, e As PaintEventArgs) Handles pnlMenuContainer.Paint

    End Sub
End Class
