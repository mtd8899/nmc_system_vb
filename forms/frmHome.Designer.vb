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
        Me.pnlSideMenu = New System.Windows.Forms.Panel()
        Me.IconBtnAccounting = New FontAwesome.Sharp.IconButton()
        Me.IconBtnInsurance = New FontAwesome.Sharp.IconButton()
        Me.IconBtnSavings = New FontAwesome.Sharp.IconButton()
        Me.IconBtnCustomers = New FontAwesome.Sharp.IconButton()
        Me.IconBtnLoans = New FontAwesome.Sharp.IconButton()
        Me.IconBtnDashboard = New FontAwesome.Sharp.IconButton()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.pnlCompanyName = New System.Windows.Forms.Panel()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.pnlDesktop = New System.Windows.Forms.Panel()
        Me.pnlFormTitle = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconFormTitle = New FontAwesome.Sharp.IconPictureBox()
        Me.pnlMenuContainer = New System.Windows.Forms.Panel()
        Me.IconUser = New FontAwesome.Sharp.IconPictureBox()
        Me.pnlSideMenu.SuspendLayout()
        Me.pnlCompanyName.SuspendLayout()
        Me.pnlFormTitle.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.IconFormTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenuContainer.SuspendLayout()
        CType(Me.IconUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSideMenu
        '
        Me.pnlSideMenu.BackColor = System.Drawing.Color.Indigo
        Me.pnlSideMenu.Controls.Add(Me.IconBtnAccounting)
        Me.pnlSideMenu.Controls.Add(Me.IconBtnInsurance)
        Me.pnlSideMenu.Controls.Add(Me.IconBtnSavings)
        Me.pnlSideMenu.Controls.Add(Me.IconBtnCustomers)
        Me.pnlSideMenu.Controls.Add(Me.IconBtnLoans)
        Me.pnlSideMenu.Controls.Add(Me.IconBtnDashboard)
        Me.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSideMenu.Location = New System.Drawing.Point(0, 213)
        Me.pnlSideMenu.Name = "pnlSideMenu"
        Me.pnlSideMenu.Size = New System.Drawing.Size(200, 304)
        Me.pnlSideMenu.TabIndex = 0
        '
        'IconBtnAccounting
        '
        Me.IconBtnAccounting.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconBtnAccounting.FlatAppearance.BorderSize = 0
        Me.IconBtnAccounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconBtnAccounting.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconBtnAccounting.ForeColor = System.Drawing.Color.White
        Me.IconBtnAccounting.IconChar = FontAwesome.Sharp.IconChar.BalanceScale
        Me.IconBtnAccounting.IconColor = System.Drawing.Color.White
        Me.IconBtnAccounting.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconBtnAccounting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconBtnAccounting.Location = New System.Drawing.Point(0, 250)
        Me.IconBtnAccounting.Name = "IconBtnAccounting"
        Me.IconBtnAccounting.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.IconBtnAccounting.Size = New System.Drawing.Size(200, 50)
        Me.IconBtnAccounting.TabIndex = 12
        Me.IconBtnAccounting.Text = "Accounting"
        Me.IconBtnAccounting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconBtnAccounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconBtnAccounting.UseVisualStyleBackColor = True
        '
        'IconBtnInsurance
        '
        Me.IconBtnInsurance.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconBtnInsurance.FlatAppearance.BorderSize = 0
        Me.IconBtnInsurance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconBtnInsurance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconBtnInsurance.ForeColor = System.Drawing.Color.White
        Me.IconBtnInsurance.IconChar = FontAwesome.Sharp.IconChar.UserShield
        Me.IconBtnInsurance.IconColor = System.Drawing.Color.White
        Me.IconBtnInsurance.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconBtnInsurance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconBtnInsurance.Location = New System.Drawing.Point(0, 200)
        Me.IconBtnInsurance.Name = "IconBtnInsurance"
        Me.IconBtnInsurance.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.IconBtnInsurance.Size = New System.Drawing.Size(200, 50)
        Me.IconBtnInsurance.TabIndex = 11
        Me.IconBtnInsurance.Text = "Insurance"
        Me.IconBtnInsurance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconBtnInsurance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconBtnInsurance.UseVisualStyleBackColor = True
        '
        'IconBtnSavings
        '
        Me.IconBtnSavings.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconBtnSavings.FlatAppearance.BorderSize = 0
        Me.IconBtnSavings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconBtnSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconBtnSavings.ForeColor = System.Drawing.Color.White
        Me.IconBtnSavings.IconChar = FontAwesome.Sharp.IconChar.University
        Me.IconBtnSavings.IconColor = System.Drawing.Color.White
        Me.IconBtnSavings.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconBtnSavings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconBtnSavings.Location = New System.Drawing.Point(0, 150)
        Me.IconBtnSavings.Name = "IconBtnSavings"
        Me.IconBtnSavings.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.IconBtnSavings.Size = New System.Drawing.Size(200, 50)
        Me.IconBtnSavings.TabIndex = 10
        Me.IconBtnSavings.Text = "Savings"
        Me.IconBtnSavings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconBtnSavings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconBtnSavings.UseVisualStyleBackColor = True
        '
        'IconBtnCustomers
        '
        Me.IconBtnCustomers.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconBtnCustomers.FlatAppearance.BorderSize = 0
        Me.IconBtnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconBtnCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconBtnCustomers.ForeColor = System.Drawing.Color.White
        Me.IconBtnCustomers.IconChar = FontAwesome.Sharp.IconChar.UserFriends
        Me.IconBtnCustomers.IconColor = System.Drawing.Color.White
        Me.IconBtnCustomers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconBtnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconBtnCustomers.Location = New System.Drawing.Point(0, 100)
        Me.IconBtnCustomers.Name = "IconBtnCustomers"
        Me.IconBtnCustomers.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.IconBtnCustomers.Size = New System.Drawing.Size(200, 50)
        Me.IconBtnCustomers.TabIndex = 9
        Me.IconBtnCustomers.Text = "Customers"
        Me.IconBtnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconBtnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconBtnCustomers.UseVisualStyleBackColor = True
        '
        'IconBtnLoans
        '
        Me.IconBtnLoans.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconBtnLoans.FlatAppearance.BorderSize = 0
        Me.IconBtnLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconBtnLoans.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconBtnLoans.ForeColor = System.Drawing.Color.White
        Me.IconBtnLoans.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWaveAlt
        Me.IconBtnLoans.IconColor = System.Drawing.Color.White
        Me.IconBtnLoans.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconBtnLoans.IconSize = 53
        Me.IconBtnLoans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconBtnLoans.Location = New System.Drawing.Point(0, 50)
        Me.IconBtnLoans.Name = "IconBtnLoans"
        Me.IconBtnLoans.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.IconBtnLoans.Size = New System.Drawing.Size(200, 50)
        Me.IconBtnLoans.TabIndex = 8
        Me.IconBtnLoans.Text = "Loans"
        Me.IconBtnLoans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconBtnLoans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconBtnLoans.UseVisualStyleBackColor = True
        '
        'IconBtnDashboard
        '
        Me.IconBtnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconBtnDashboard.FlatAppearance.BorderSize = 0
        Me.IconBtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconBtnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconBtnDashboard.ForeColor = System.Drawing.Color.White
        Me.IconBtnDashboard.IconChar = FontAwesome.Sharp.IconChar.Deezer
        Me.IconBtnDashboard.IconColor = System.Drawing.Color.White
        Me.IconBtnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconBtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconBtnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.IconBtnDashboard.Name = "IconBtnDashboard"
        Me.IconBtnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.IconBtnDashboard.Size = New System.Drawing.Size(200, 50)
        Me.IconBtnDashboard.TabIndex = 7
        Me.IconBtnDashboard.Text = "Dashboard"
        Me.IconBtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconBtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconBtnDashboard.UseVisualStyleBackColor = True
        '
        'pnlLogo
        '
        Me.pnlLogo.BackColor = System.Drawing.Color.Indigo
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(200, 213)
        Me.pnlLogo.TabIndex = 0
        '
        'pnlCompanyName
        '
        Me.pnlCompanyName.BackColor = System.Drawing.Color.Indigo
        Me.pnlCompanyName.Controls.Add(Me.lblCompanyName)
        Me.pnlCompanyName.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCompanyName.Location = New System.Drawing.Point(200, 0)
        Me.pnlCompanyName.Name = "pnlCompanyName"
        Me.pnlCompanyName.Size = New System.Drawing.Size(684, 68)
        Me.pnlCompanyName.TabIndex = 1
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.ForeColor = System.Drawing.Color.White
        Me.lblCompanyName.Location = New System.Drawing.Point(6, 20)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(256, 42)
        Me.lblCompanyName.TabIndex = 0
        Me.lblCompanyName.Text = "New Malayan"
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.White
        Me.lblFormTitle.Location = New System.Drawing.Point(45, 18)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(105, 24)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "Form Title"
        '
        'pnlDesktop
        '
        Me.pnlDesktop.BackColor = System.Drawing.Color.White
        Me.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDesktop.Location = New System.Drawing.Point(200, 118)
        Me.pnlDesktop.Name = "pnlDesktop"
        Me.pnlDesktop.Size = New System.Drawing.Size(684, 399)
        Me.pnlDesktop.TabIndex = 2
        '
        'pnlFormTitle
        '
        Me.pnlFormTitle.BackColor = System.Drawing.Color.Indigo
        Me.pnlFormTitle.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlFormTitle.Controls.Add(Me.Label1)
        Me.pnlFormTitle.Controls.Add(Me.IconFormTitle)
        Me.pnlFormTitle.Controls.Add(Me.lblFormTitle)
        Me.pnlFormTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFormTitle.Location = New System.Drawing.Point(200, 68)
        Me.pnlFormTitle.Name = "pnlFormTitle"
        Me.pnlFormTitle.Size = New System.Drawing.Size(684, 50)
        Me.pnlFormTitle.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.IconUser, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblUser, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(504, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(180, 50)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblUser
        '
        Me.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(124, 13)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(53, 24)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "User"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(791, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User"
        '
        'IconFormTitle
        '
        Me.IconFormTitle.BackColor = System.Drawing.Color.Indigo
        Me.IconFormTitle.IconChar = FontAwesome.Sharp.IconChar.Database
        Me.IconFormTitle.IconColor = System.Drawing.Color.White
        Me.IconFormTitle.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconFormTitle.IconSize = 44
        Me.IconFormTitle.ImageLocation = ""
        Me.IconFormTitle.Location = New System.Drawing.Point(0, 6)
        Me.IconFormTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.IconFormTitle.Name = "IconFormTitle"
        Me.IconFormTitle.Size = New System.Drawing.Size(48, 44)
        Me.IconFormTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.IconFormTitle.TabIndex = 1
        Me.IconFormTitle.TabStop = False
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
        'IconUser
        '
        Me.IconUser.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.IconUser.BackColor = System.Drawing.Color.Indigo
        Me.IconUser.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
        Me.IconUser.IconChar = FontAwesome.Sharp.IconChar.UserCircle
        Me.IconUser.IconColor = System.Drawing.Color.White
        Me.IconUser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconUser.IconSize = 44
        Me.IconUser.ImageLocation = ""
        Me.IconUser.Location = New System.Drawing.Point(0, 3)
        Me.IconUser.Margin = New System.Windows.Forms.Padding(0)
        Me.IconUser.Name = "IconUser"
        Me.IconUser.Size = New System.Drawing.Size(48, 44)
        Me.IconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.IconUser.TabIndex = 1
        Me.IconUser.TabStop = False
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
        Me.pnlFormTitle.ResumeLayout(False)
        Me.pnlFormTitle.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.IconFormTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenuContainer.ResumeLayout(False)
        CType(Me.IconUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSideMenu As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents pnlCompanyName As Panel
    Friend WithEvents pnlDesktop As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents pnlFormTitle As Panel
    Friend WithEvents pnlMenuContainer As Panel
    Friend WithEvents IconBtnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnAccounting As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnInsurance As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnSavings As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnCustomers As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnLoans As FontAwesome.Sharp.IconButton
    Friend WithEvents IconFormTitle As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents IconUser As FontAwesome.Sharp.IconPictureBox
End Class
