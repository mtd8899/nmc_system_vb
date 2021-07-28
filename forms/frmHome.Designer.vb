<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.pnlSideMenu = New System.Windows.Forms.Panel()
        Me.btnAccounting = New System.Windows.Forms.Button()
        Me.btnInsurance = New System.Windows.Forms.Button()
        Me.btnSavings = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnLoan = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.pnlCompanyName = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picFormIcon = New System.Windows.Forms.PictureBox()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.pnlDesktop = New System.Windows.Forms.Panel()
        Me.pnlFormTitle = New System.Windows.Forms.Panel()
        Me.pnlMenuContainer = New System.Windows.Forms.Panel()
        Me.pnlSideMenu.SuspendLayout()
        Me.pnlCompanyName.SuspendLayout()
        CType(Me.picFormIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFormTitle.SuspendLayout()
        Me.pnlMenuContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSideMenu
        '
        Me.pnlSideMenu.BackColor = System.Drawing.Color.Indigo
        Me.pnlSideMenu.Controls.Add(Me.btnAccounting)
        Me.pnlSideMenu.Controls.Add(Me.btnInsurance)
        Me.pnlSideMenu.Controls.Add(Me.btnSavings)
        Me.pnlSideMenu.Controls.Add(Me.btnCustomer)
        Me.pnlSideMenu.Controls.Add(Me.btnLoan)
        Me.pnlSideMenu.Controls.Add(Me.btnDashboard)
        Me.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSideMenu.Location = New System.Drawing.Point(0, 185)
        Me.pnlSideMenu.Name = "pnlSideMenu"
        Me.pnlSideMenu.Size = New System.Drawing.Size(200, 332)
        Me.pnlSideMenu.TabIndex = 0
        '
        'btnAccounting
        '
        Me.btnAccounting.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccounting.FlatAppearance.BorderSize = 0
        Me.btnAccounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccounting.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccounting.ForeColor = System.Drawing.Color.White
        Me.btnAccounting.Image = CType(resources.GetObject("btnAccounting.Image"), System.Drawing.Image)
        Me.btnAccounting.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAccounting.Location = New System.Drawing.Point(0, 250)
        Me.btnAccounting.Name = "btnAccounting"
        Me.btnAccounting.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnAccounting.Size = New System.Drawing.Size(200, 50)
        Me.btnAccounting.TabIndex = 6
        Me.btnAccounting.Text = "Accounting"
        Me.btnAccounting.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAccounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccounting.UseVisualStyleBackColor = True
        '
        'btnInsurance
        '
        Me.btnInsurance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInsurance.FlatAppearance.BorderSize = 0
        Me.btnInsurance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsurance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsurance.ForeColor = System.Drawing.Color.White
        Me.btnInsurance.Image = CType(resources.GetObject("btnInsurance.Image"), System.Drawing.Image)
        Me.btnInsurance.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnInsurance.Location = New System.Drawing.Point(0, 200)
        Me.btnInsurance.Name = "btnInsurance"
        Me.btnInsurance.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnInsurance.Size = New System.Drawing.Size(200, 50)
        Me.btnInsurance.TabIndex = 5
        Me.btnInsurance.Text = "Insurance"
        Me.btnInsurance.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInsurance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInsurance.UseVisualStyleBackColor = True
        '
        'btnSavings
        '
        Me.btnSavings.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSavings.FlatAppearance.BorderSize = 0
        Me.btnSavings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavings.ForeColor = System.Drawing.Color.White
        Me.btnSavings.Image = CType(resources.GetObject("btnSavings.Image"), System.Drawing.Image)
        Me.btnSavings.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnSavings.Location = New System.Drawing.Point(0, 150)
        Me.btnSavings.Name = "btnSavings"
        Me.btnSavings.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnSavings.Size = New System.Drawing.Size(200, 50)
        Me.btnSavings.TabIndex = 4
        Me.btnSavings.Text = "Savings"
        Me.btnSavings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSavings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSavings.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCustomer.FlatAppearance.BorderSize = 0
        Me.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.ForeColor = System.Drawing.Color.White
        Me.btnCustomer.Image = CType(resources.GetObject("btnCustomer.Image"), System.Drawing.Image)
        Me.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnCustomer.Location = New System.Drawing.Point(0, 100)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnCustomer.Size = New System.Drawing.Size(200, 50)
        Me.btnCustomer.TabIndex = 3
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnLoan
        '
        Me.btnLoan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLoan.FlatAppearance.BorderSize = 0
        Me.btnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoan.ForeColor = System.Drawing.Color.White
        Me.btnLoan.Image = CType(resources.GetObject("btnLoan.Image"), System.Drawing.Image)
        Me.btnLoan.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnLoan.Location = New System.Drawing.Point(0, 50)
        Me.btnLoan.Name = "btnLoan"
        Me.btnLoan.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnLoan.Size = New System.Drawing.Size(200, 50)
        Me.btnLoan.TabIndex = 2
        Me.btnLoan.Text = "Loan"
        Me.btnLoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLoan.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(200, 50)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'pnlLogo
        '
        Me.pnlLogo.BackColor = System.Drawing.Color.Indigo
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(200, 185)
        Me.pnlLogo.TabIndex = 0
        '
        'pnlCompanyName
        '
        Me.pnlCompanyName.BackColor = System.Drawing.Color.Indigo
        Me.pnlCompanyName.Controls.Add(Me.Label1)
        Me.pnlCompanyName.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCompanyName.Location = New System.Drawing.Point(200, 0)
        Me.pnlCompanyName.Name = "pnlCompanyName"
        Me.pnlCompanyName.Size = New System.Drawing.Size(684, 75)
        Me.pnlCompanyName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Malayan"
        '
        'picFormIcon
        '
        Me.picFormIcon.Location = New System.Drawing.Point(14, 9)
        Me.picFormIcon.Name = "picFormIcon"
        Me.picFormIcon.Size = New System.Drawing.Size(32, 29)
        Me.picFormIcon.TabIndex = 1
        Me.picFormIcon.TabStop = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.White
        Me.lblFormTitle.Location = New System.Drawing.Point(52, 14)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(89, 20)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "Form Title"
        '
        'pnlDesktop
        '
        Me.pnlDesktop.BackColor = System.Drawing.Color.White
        Me.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDesktop.Location = New System.Drawing.Point(200, 125)
        Me.pnlDesktop.Name = "pnlDesktop"
        Me.pnlDesktop.Size = New System.Drawing.Size(684, 392)
        Me.pnlDesktop.TabIndex = 2
        '
        'pnlFormTitle
        '
        Me.pnlFormTitle.BackColor = System.Drawing.Color.Indigo
        Me.pnlFormTitle.Controls.Add(Me.picFormIcon)
        Me.pnlFormTitle.Controls.Add(Me.lblFormTitle)
        Me.pnlFormTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFormTitle.Location = New System.Drawing.Point(200, 75)
        Me.pnlFormTitle.Name = "pnlFormTitle"
        Me.pnlFormTitle.Size = New System.Drawing.Size(684, 50)
        Me.pnlFormTitle.TabIndex = 0
        '
        'pnlMenuContainer
        '
        Me.pnlMenuContainer.Controls.Add(Me.pnlSideMenu)
        Me.pnlMenuContainer.Controls.Add(Me.pnlLogo)
        Me.pnlMenuContainer.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenuContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenuContainer.Name = "pnlMenuContainer"
        Me.pnlMenuContainer.Size = New System.Drawing.Size(200, 517)
        Me.pnlMenuContainer.TabIndex = 3
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 517)
        Me.Controls.Add(Me.pnlDesktop)
        Me.Controls.Add(Me.pnlFormTitle)
        Me.Controls.Add(Me.pnlCompanyName)
        Me.Controls.Add(Me.pnlMenuContainer)
        Me.Name = "frmHome"
        Me.Text = "Home"
        Me.pnlSideMenu.ResumeLayout(False)
        Me.pnlCompanyName.ResumeLayout(False)
        Me.pnlCompanyName.PerformLayout()
        CType(Me.picFormIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFormTitle.ResumeLayout(False)
        Me.pnlFormTitle.PerformLayout()
        Me.pnlMenuContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSideMenu As Panel
    Friend WithEvents btnAccounting As Button
    Friend WithEvents btnInsurance As Button
    Friend WithEvents btnSavings As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnLoan As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents pnlCompanyName As Panel
    Friend WithEvents pnlDesktop As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents picFormIcon As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlFormTitle As Panel
    Friend WithEvents pnlMenuContainer As Panel
End Class
