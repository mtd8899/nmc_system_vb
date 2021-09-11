Imports FontAwesome.Sharp

Public Class frmHome
    Private currentChildForm As Object
    Private currentButton As IconButton
    Private leftBorderBtn As Panel

    'constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(8, 50)
        pnlSideMenu.Controls.Add(leftBorderBtn)
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        'button
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
    Private Sub ActivateButton(senderButton As Object)
        If senderButton IsNot Nothing Then
            DisableButton()
            'Button
            currentButton = CType(senderButton, IconButton)
            currentButton.BackColor = Color.Purple
            'leftBorderBtn
            leftBorderBtn.BackColor = Color.IndianRed
            leftBorderBtn.Location = New Point(0, currentButton.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current form icon
            IconFormTitle.IconChar = currentButton.IconChar
        End If
    End Sub
    Private Sub DisableButton()
        If currentButton IsNot Nothing Then
            currentButton.BackColor = Color.Indigo
        End If
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCompanyName.Click

    End Sub

    Private Sub picFormIcon_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblFormTitle_Click(sender As Object, e As EventArgs) Handles lblFormTitle.Click, lblUser.Click, Label1.Click

    End Sub

    Private Sub pnlFormTitle_Paint(sender As Object, e As PaintEventArgs) Handles pnlFormTitle.Paint

    End Sub

    Private Sub pnlMenuContainer_Paint(sender As Object, e As PaintEventArgs) Handles pnlMenuContainer.Paint

    End Sub

    Private Sub IconBtnDashboard_Click(sender As Object, e As EventArgs) Handles IconBtnDashboard.Click
        OpenChildForm(New frmDashboard)
        ActivateButton(sender)
    End Sub

    Private Sub IconBtnLoans_Click(sender As Object, e As EventArgs) Handles IconBtnLoans.Click
        OpenChildForm(New frmLoans)
        ActivateButton(sender)
    End Sub

    Private Sub IconBtnSavings_Click(sender As Object, e As EventArgs) Handles IconBtnSavings.Click
        OpenChildForm(New frmLoanAdd)
        ActivateButton(sender)
    End Sub

    Private Sub IconBtnInsurance_Click(sender As Object, e As EventArgs) Handles IconBtnInsurance.Click
        OpenChildForm(New frmInsurance)
        ActivateButton(sender)
    End Sub

    Private Sub IconBtnAccounting_Click(sender As Object, e As EventArgs) Handles IconBtnAccounting.Click
        OpenChildForm(New frmAccounting)
        ActivateButton(sender)
    End Sub

    Private Sub pnlUser_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub IconBtnCustomers_Click(sender As Object, e As EventArgs) Handles IconBtnCustomers.Click
        OpenChildForm(New frmCustomer)
        ActivateButton(sender)
    End Sub
End Class
