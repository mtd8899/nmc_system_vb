<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoanAdd
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCustId = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCoMaker = New System.Windows.Forms.TextBox()
        Me.btnShowAmort = New System.Windows.Forms.Button()
        Me.btnLoanAdd = New System.Windows.Forms.Button()
        Me.txtProcFee = New System.Windows.Forms.TextBox()
        Me.txtCollateral = New System.Windows.Forms.TextBox()
        Me.txtCycleNo = New System.Windows.Forms.TextBox()
        Me.txtInterest = New System.Windows.Forms.TextBox()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.txtDateRel = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lstAmortTable = New System.Windows.Forms.ListBox()
        Me.lblDateRel = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblPrincipal = New System.Windows.Forms.Label()
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.lblAmort = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.lblMaturity = New System.Windows.Forms.Label()
        Me.lblCycle = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblInteresst = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblLoanAcc = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboLoanType = New System.Windows.Forms.ComboBox()
        Me.cboTerms = New System.Windows.Forms.ComboBox()
        Me.cboCustName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1152, 466)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtCustId)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtCoMaker)
        Me.GroupBox1.Controls.Add(Me.btnShowAmort)
        Me.GroupBox1.Controls.Add(Me.btnLoanAdd)
        Me.GroupBox1.Controls.Add(Me.txtProcFee)
        Me.GroupBox1.Controls.Add(Me.txtCollateral)
        Me.GroupBox1.Controls.Add(Me.txtCycleNo)
        Me.GroupBox1.Controls.Add(Me.txtInterest)
        Me.GroupBox1.Controls.Add(Me.txtPrincipal)
        Me.GroupBox1.Controls.Add(Me.txtDateRel)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboLoanType)
        Me.GroupBox1.Controls.Add(Me.cboTerms)
        Me.GroupBox1.Controls.Add(Me.cboCustName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1128, 443)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Loan deatails:"
        '
        'txtCustId
        '
        Me.txtCustId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustId.Location = New System.Drawing.Point(149, 35)
        Me.txtCustId.Name = "txtCustId"
        Me.txtCustId.Size = New System.Drawing.Size(242, 26)
        Me.txtCustId.TabIndex = 10
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(19, 38)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(109, 20)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Cust. Acc. No."
        '
        'txtCoMaker
        '
        Me.txtCoMaker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCoMaker.Location = New System.Drawing.Point(149, 329)
        Me.txtCoMaker.Name = "txtCoMaker"
        Me.txtCoMaker.Size = New System.Drawing.Size(242, 26)
        Me.txtCoMaker.TabIndex = 8
        '
        'btnShowAmort
        '
        Me.btnShowAmort.Location = New System.Drawing.Point(6, 393)
        Me.btnShowAmort.Name = "btnShowAmort"
        Me.btnShowAmort.Size = New System.Drawing.Size(159, 47)
        Me.btnShowAmort.TabIndex = 8
        Me.btnShowAmort.Text = "ShowAmort"
        Me.btnShowAmort.UseVisualStyleBackColor = True
        '
        'btnLoanAdd
        '
        Me.btnLoanAdd.Location = New System.Drawing.Point(232, 393)
        Me.btnLoanAdd.Name = "btnLoanAdd"
        Me.btnLoanAdd.Size = New System.Drawing.Size(159, 47)
        Me.btnLoanAdd.TabIndex = 10
        Me.btnLoanAdd.Text = "Submit"
        Me.btnLoanAdd.UseVisualStyleBackColor = True
        '
        'txtProcFee
        '
        Me.txtProcFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcFee.Location = New System.Drawing.Point(149, 197)
        Me.txtProcFee.Name = "txtProcFee"
        Me.txtProcFee.Size = New System.Drawing.Size(242, 26)
        Me.txtProcFee.TabIndex = 4
        '
        'txtCollateral
        '
        Me.txtCollateral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollateral.Location = New System.Drawing.Point(149, 361)
        Me.txtCollateral.Name = "txtCollateral"
        Me.txtCollateral.Size = New System.Drawing.Size(242, 26)
        Me.txtCollateral.TabIndex = 9
        '
        'txtCycleNo
        '
        Me.txtCycleNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCycleNo.Location = New System.Drawing.Point(149, 297)
        Me.txtCycleNo.Name = "txtCycleNo"
        Me.txtCycleNo.Size = New System.Drawing.Size(242, 26)
        Me.txtCycleNo.TabIndex = 7
        '
        'txtInterest
        '
        Me.txtInterest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterest.Location = New System.Drawing.Point(149, 165)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(242, 26)
        Me.txtInterest.TabIndex = 3
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrincipal.Location = New System.Drawing.Point(149, 133)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(242, 26)
        Me.txtPrincipal.TabIndex = 2
        '
        'txtDateRel
        '
        Me.txtDateRel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateRel.Location = New System.Drawing.Point(149, 101)
        Me.txtDateRel.Name = "txtDateRel"
        Me.txtDateRel.Size = New System.Drawing.Size(242, 26)
        Me.txtDateRel.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 335)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 20)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Co-maker"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.lstAmortTable)
        Me.Panel2.Controls.Add(Me.lblDateRel)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.lblPrincipal)
        Me.Panel2.Controls.Add(Me.lblCustName)
        Me.Panel2.Controls.Add(Me.lblAmort)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.lblCustID)
        Me.Panel2.Controls.Add(Me.lblMaturity)
        Me.Panel2.Controls.Add(Me.lblCycle)
        Me.Panel2.Controls.Add(Me.lblType)
        Me.Panel2.Controls.Add(Me.lblInteresst)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.lblLoanAcc)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(397, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(731, 410)
        Me.Panel2.TabIndex = 3
        '
        'lstAmortTable
        '
        Me.lstAmortTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAmortTable.FormattingEnabled = True
        Me.lstAmortTable.ItemHeight = 25
        Me.lstAmortTable.Location = New System.Drawing.Point(18, 154)
        Me.lstAmortTable.Name = "lstAmortTable"
        Me.lstAmortTable.Size = New System.Drawing.Size(696, 254)
        Me.lstAmortTable.TabIndex = 200
        '
        'lblDateRel
        '
        Me.lblDateRel.AutoSize = True
        Me.lblDateRel.Location = New System.Drawing.Point(519, 8)
        Me.lblDateRel.Name = "lblDateRel"
        Me.lblDateRel.Size = New System.Drawing.Size(89, 25)
        Me.lblDateRel.TabIndex = 1
        Me.lblDateRel.Text = "DateRel"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(427, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(91, 25)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Release"
        '
        'lblPrincipal
        '
        Me.lblPrincipal.AutoSize = True
        Me.lblPrincipal.Location = New System.Drawing.Point(202, 89)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(87, 25)
        Me.lblPrincipal.TabIndex = 1
        Me.lblPrincipal.Text = "PrinAmt"
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.Location = New System.Drawing.Point(202, 64)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(166, 25)
        Me.lblCustName.TabIndex = 1
        Me.lblCustName.Text = "Customer Name"
        '
        'lblAmort
        '
        Me.lblAmort.AutoSize = True
        Me.lblAmort.Location = New System.Drawing.Point(202, 116)
        Me.lblAmort.Name = "lblAmort"
        Me.lblAmort.Size = New System.Drawing.Size(68, 25)
        Me.lblAmort.TabIndex = 1
        Me.lblAmort.Text = "Amort"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(174, 25)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Principal Amount"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 116)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(131, 25)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Amortization"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(166, 25)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Customer Name"
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.Location = New System.Drawing.Point(202, 35)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(82, 25)
        Me.lblCustID.TabIndex = 1
        Me.lblCustID.Text = "Cust ID"
        '
        'lblMaturity
        '
        Me.lblMaturity.AutoSize = True
        Me.lblMaturity.Location = New System.Drawing.Point(525, 35)
        Me.lblMaturity.Name = "lblMaturity"
        Me.lblMaturity.Size = New System.Drawing.Size(89, 25)
        Me.lblMaturity.TabIndex = 1
        Me.lblMaturity.Text = "Maturity"
        '
        'lblCycle
        '
        Me.lblCycle.AutoSize = True
        Me.lblCycle.Location = New System.Drawing.Point(525, 116)
        Me.lblCycle.Name = "lblCycle"
        Me.lblCycle.Size = New System.Drawing.Size(66, 25)
        Me.lblCycle.TabIndex = 1
        Me.lblCycle.Text = "Cycle"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(525, 89)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(60, 25)
        Me.lblType.TabIndex = 1
        Me.lblType.Text = "Type"
        '
        'lblInteresst
        '
        Me.lblInteresst.AutoSize = True
        Me.lblInteresst.Location = New System.Drawing.Point(525, 62)
        Me.lblInteresst.Name = "lblInteresst"
        Me.lblInteresst.Size = New System.Drawing.Size(83, 25)
        Me.lblInteresst.TabIndex = 1
        Me.lblInteresst.Text = "Interest"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(427, 116)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 25)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Cycle"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(191, 25)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Customer Acc. No."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(427, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 25)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Type"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(427, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 25)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Maturity"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(427, 62)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 25)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Interest"
        '
        'lblLoanAcc
        '
        Me.lblLoanAcc.AutoSize = True
        Me.lblLoanAcc.Location = New System.Drawing.Point(202, 8)
        Me.lblLoanAcc.Name = "lblLoanAcc"
        Me.lblLoanAcc.Size = New System.Drawing.Size(86, 25)
        Me.lblLoanAcc.TabIndex = 1
        Me.lblLoanAcc.Text = "Loan ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(189, 25)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Loan Account. No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Loan Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 368)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Collateral"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Terms"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Cycle No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Proc Fee"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Interest(monthly)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Principal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date Release"
        '
        'cboLoanType
        '
        Me.cboLoanType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLoanType.FormattingEnabled = True
        Me.cboLoanType.Items.AddRange(New Object() {"Personal Loan", "Business Loan"})
        Me.cboLoanType.Location = New System.Drawing.Point(149, 263)
        Me.cboLoanType.Name = "cboLoanType"
        Me.cboLoanType.Size = New System.Drawing.Size(242, 28)
        Me.cboLoanType.TabIndex = 6
        '
        'cboTerms
        '
        Me.cboTerms.DisplayMember = "CustID"
        Me.cboTerms.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTerms.FormattingEnabled = True
        Me.cboTerms.Location = New System.Drawing.Point(149, 229)
        Me.cboTerms.Name = "cboTerms"
        Me.cboTerms.Size = New System.Drawing.Size(242, 28)
        Me.cboTerms.TabIndex = 5
        Me.cboTerms.ValueMember = "CustID"
        '
        'cboCustName
        '
        Me.cboCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCustName.FormattingEnabled = True
        Me.cboCustName.Location = New System.Drawing.Point(149, 67)
        Me.cboCustName.Name = "cboCustName"
        Me.cboCustName.Size = New System.Drawing.Size(242, 28)
        Me.cboCustName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer Name"
        '
        'frmLoanAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 470)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmLoanAdd"
        Me.Text = "Add Loan Form"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboCustName As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPrincipal As Label
    Friend WithEvents lblAmort As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblCustID As Label
    Friend WithEvents lblInteresst As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblLoanAcc As Label
    Friend WithEvents lblDateRel As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblMaturity As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblCustName As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblType As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblCycle As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents btnLoanAdd As Button
    Friend WithEvents txtProcFee As TextBox
    Friend WithEvents txtInterest As TextBox
    Friend WithEvents txtPrincipal As TextBox
    Friend WithEvents txtDateRel As TextBox
    Friend WithEvents cboLoanType As ComboBox
    Friend WithEvents cboTerms As ComboBox
    Friend WithEvents txtCycleNo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnShowAmort As Button
    Friend WithEvents lstAmortTable As ListBox
    Friend WithEvents txtCoMaker As TextBox
    Friend WithEvents txtCollateral As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCustId As TextBox
    Friend WithEvents Label20 As Label
End Class
