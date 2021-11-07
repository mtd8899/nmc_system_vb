<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCollection
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
        Me.components = New System.ComponentModel.Container()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkCollBy = New System.Windows.Forms.CheckBox()
        Me.btnClearTxtbox = New System.Windows.Forms.Button()
        Me.btnShowLastRefNo = New System.Windows.Forms.Button()
        Me.chkCollDate = New System.Windows.Forms.CheckBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.chkRefNo = New System.Windows.Forms.CheckBox()
        Me.cboCustName = New System.Windows.Forms.ComboBox()
        Me.txtSavingsWithdraw = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAddPenNote = New System.Windows.Forms.TextBox()
        Me.txtOtherPayDesc = New System.Windows.Forms.TextBox()
        Me.txtOtherPayment = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalPayment = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtColBy = New System.Windows.Forms.TextBox()
        Me.txtAddPenalty = New System.Windows.Forms.TextBox()
        Me.txtPenaltyPaid = New System.Windows.Forms.TextBox()
        Me.txtSavingsDep = New System.Windows.Forms.TextBox()
        Me.txtRetFund = New System.Windows.Forms.TextBox()
        Me.txtInsurance = New System.Windows.Forms.TextBox()
        Me.txtLoanRep = New System.Windows.Forms.TextBox()
        Me.txtRefNo = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.lblColBy = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblInsurance = New System.Windows.Forms.Label()
        Me.lblLoanRep = New System.Windows.Forms.Label()
        Me.dgViewAddingColl = New System.Windows.Forms.DataGridView()
        Me.TblCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTotalRep = New System.Windows.Forms.TextBox()
        Me.TblCollectionLoanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgViewAddingColl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCollectionLoanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(21, 31)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(46, 18)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "Date:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkCollBy)
        Me.GroupBox1.Controls.Add(Me.btnClearTxtbox)
        Me.GroupBox1.Controls.Add(Me.btnShowLastRefNo)
        Me.GroupBox1.Controls.Add(Me.chkCollDate)
        Me.GroupBox1.Controls.Add(Me.btnSubmit)
        Me.GroupBox1.Controls.Add(Me.chkRefNo)
        Me.GroupBox1.Controls.Add(Me.cboCustName)
        Me.GroupBox1.Controls.Add(Me.txtSavingsWithdraw)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtAddPenNote)
        Me.GroupBox1.Controls.Add(Me.txtOtherPayDesc)
        Me.GroupBox1.Controls.Add(Me.txtOtherPayment)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTotalPayment)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtColBy)
        Me.GroupBox1.Controls.Add(Me.txtAddPenalty)
        Me.GroupBox1.Controls.Add(Me.txtPenaltyPaid)
        Me.GroupBox1.Controls.Add(Me.txtSavingsDep)
        Me.GroupBox1.Controls.Add(Me.txtRetFund)
        Me.GroupBox1.Controls.Add(Me.txtInsurance)
        Me.GroupBox1.Controls.Add(Me.txtLoanRep)
        Me.GroupBox1.Controls.Add(Me.txtRefNo)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.lblColBy)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblInsurance)
        Me.GroupBox1.Controls.Add(Me.lblLoanRep)
        Me.GroupBox1.Controls.Add(Me.lblDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 530)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Payment"
        '
        'chkCollBy
        '
        Me.chkCollBy.AutoSize = True
        Me.chkCollBy.Checked = True
        Me.chkCollBy.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCollBy.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCollBy.Location = New System.Drawing.Point(324, 291)
        Me.chkCollBy.Name = "chkCollBy"
        Me.chkCollBy.Size = New System.Drawing.Size(15, 14)
        Me.chkCollBy.TabIndex = 23
        Me.chkCollBy.UseVisualStyleBackColor = True
        '
        'btnClearTxtbox
        '
        Me.btnClearTxtbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClearTxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearTxtbox.Location = New System.Drawing.Point(6, 316)
        Me.btnClearTxtbox.Name = "btnClearTxtbox"
        Me.btnClearTxtbox.Size = New System.Drawing.Size(165, 39)
        Me.btnClearTxtbox.TabIndex = 22
        Me.btnClearTxtbox.Text = "Clear"
        Me.btnClearTxtbox.UseVisualStyleBackColor = True
        '
        'btnShowLastRefNo
        '
        Me.btnShowLastRefNo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnShowLastRefNo.FlatAppearance.BorderSize = 0
        Me.btnShowLastRefNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowLastRefNo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowLastRefNo.Location = New System.Drawing.Point(177, 28)
        Me.btnShowLastRefNo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnShowLastRefNo.Name = "btnShowLastRefNo"
        Me.btnShowLastRefNo.Size = New System.Drawing.Size(76, 25)
        Me.btnShowLastRefNo.TabIndex = 21
        Me.btnShowLastRefNo.Text = "Ref. No:"
        Me.btnShowLastRefNo.UseVisualStyleBackColor = True
        '
        'chkCollDate
        '
        Me.chkCollDate.AutoSize = True
        Me.chkCollDate.Checked = True
        Me.chkCollDate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCollDate.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCollDate.Location = New System.Drawing.Point(163, 35)
        Me.chkCollDate.Name = "chkCollDate"
        Me.chkCollDate.Size = New System.Drawing.Size(15, 14)
        Me.chkCollDate.TabIndex = 20
        Me.chkCollDate.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(174, 316)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(165, 39)
        Me.btnSubmit.TabIndex = 15
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'chkRefNo
        '
        Me.chkRefNo.AutoSize = True
        Me.chkRefNo.Checked = True
        Me.chkRefNo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRefNo.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRefNo.Location = New System.Drawing.Point(327, 35)
        Me.chkRefNo.Name = "chkRefNo"
        Me.chkRefNo.Size = New System.Drawing.Size(15, 14)
        Me.chkRefNo.TabIndex = 100
        Me.chkRefNo.UseVisualStyleBackColor = True
        '
        'cboCustName
        '
        Me.cboCustName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboCustName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCustName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCustName.FormattingEnabled = True
        Me.cboCustName.Location = New System.Drawing.Point(24, 60)
        Me.cboCustName.Name = "cboCustName"
        Me.cboCustName.Size = New System.Drawing.Size(315, 26)
        Me.cboCustName.TabIndex = 2
        '
        'txtSavingsWithdraw
        '
        Me.txtSavingsWithdraw.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSavingsWithdraw.Location = New System.Drawing.Point(233, 252)
        Me.txtSavingsWithdraw.Name = "txtSavingsWithdraw"
        Me.txtSavingsWithdraw.Size = New System.Drawing.Size(106, 26)
        Me.txtSavingsWithdraw.TabIndex = 13
        Me.txtSavingsWithdraw.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(150, 255)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 18)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Withdraw:"
        '
        'txtAddPenNote
        '
        Me.txtAddPenNote.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddPenNote.Location = New System.Drawing.Point(111, 188)
        Me.txtAddPenNote.Name = "txtAddPenNote"
        Me.txtAddPenNote.Size = New System.Drawing.Size(228, 26)
        Me.txtAddPenNote.TabIndex = 9
        '
        'txtOtherPayDesc
        '
        Me.txtOtherPayDesc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherPayDesc.Location = New System.Drawing.Point(203, 220)
        Me.txtOtherPayDesc.Name = "txtOtherPayDesc"
        Me.txtOtherPayDesc.Size = New System.Drawing.Size(136, 26)
        Me.txtOtherPayDesc.TabIndex = 11
        '
        'txtOtherPayment
        '
        Me.txtOtherPayment.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherPayment.Location = New System.Drawing.Point(73, 220)
        Me.txtOtherPayment.Name = "txtOtherPayment"
        Me.txtOtherPayment.Size = New System.Drawing.Size(71, 26)
        Me.txtOtherPayment.TabIndex = 10
        Me.txtOtherPayment.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Other:"
        '
        'txtTotalPayment
        '
        Me.txtTotalPayment.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPayment.Location = New System.Drawing.Point(73, 252)
        Me.txtTotalPayment.Name = "txtTotalPayment"
        Me.txtTotalPayment.Size = New System.Drawing.Size(71, 26)
        Me.txtTotalPayment.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 18)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Total:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Pen . Note:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(150, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 18)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Desc.:"
        '
        'txtColBy
        '
        Me.txtColBy.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColBy.Location = New System.Drawing.Point(111, 284)
        Me.txtColBy.Name = "txtColBy"
        Me.txtColBy.Size = New System.Drawing.Size(210, 26)
        Me.txtColBy.TabIndex = 14
        '
        'txtAddPenalty
        '
        Me.txtAddPenalty.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddPenalty.Location = New System.Drawing.Point(272, 156)
        Me.txtAddPenalty.Name = "txtAddPenalty"
        Me.txtAddPenalty.Size = New System.Drawing.Size(67, 26)
        Me.txtAddPenalty.TabIndex = 8
        Me.txtAddPenalty.Text = "0"
        '
        'txtPenaltyPaid
        '
        Me.txtPenaltyPaid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenaltyPaid.Location = New System.Drawing.Point(111, 156)
        Me.txtPenaltyPaid.Name = "txtPenaltyPaid"
        Me.txtPenaltyPaid.Size = New System.Drawing.Size(74, 26)
        Me.txtPenaltyPaid.TabIndex = 7
        Me.txtPenaltyPaid.Text = "0"
        '
        'txtSavingsDep
        '
        Me.txtSavingsDep.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSavingsDep.Location = New System.Drawing.Point(272, 124)
        Me.txtSavingsDep.Name = "txtSavingsDep"
        Me.txtSavingsDep.Size = New System.Drawing.Size(67, 26)
        Me.txtSavingsDep.TabIndex = 6
        Me.txtSavingsDep.Text = "0"
        '
        'txtRetFund
        '
        Me.txtRetFund.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetFund.Location = New System.Drawing.Point(111, 124)
        Me.txtRetFund.Name = "txtRetFund"
        Me.txtRetFund.Size = New System.Drawing.Size(74, 26)
        Me.txtRetFund.TabIndex = 5
        Me.txtRetFund.Text = "0"
        '
        'txtInsurance
        '
        Me.txtInsurance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsurance.Location = New System.Drawing.Point(272, 92)
        Me.txtInsurance.Name = "txtInsurance"
        Me.txtInsurance.Size = New System.Drawing.Size(67, 26)
        Me.txtInsurance.TabIndex = 4
        Me.txtInsurance.Text = "0"
        '
        'txtLoanRep
        '
        Me.txtLoanRep.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanRep.Location = New System.Drawing.Point(111, 92)
        Me.txtLoanRep.Name = "txtLoanRep"
        Me.txtLoanRep.Size = New System.Drawing.Size(74, 26)
        Me.txtLoanRep.TabIndex = 3
        Me.txtLoanRep.Text = "0"
        '
        'txtRefNo
        '
        Me.txtRefNo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.Location = New System.Drawing.Point(255, 28)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(66, 26)
        Me.txtRefNo.TabIndex = 1
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(73, 27)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(86, 26)
        Me.txtDate.TabIndex = 0
        '
        'lblColBy
        '
        Me.lblColBy.AutoSize = True
        Me.lblColBy.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColBy.Location = New System.Drawing.Point(22, 288)
        Me.lblColBy.Name = "lblColBy"
        Me.lblColBy.Size = New System.Drawing.Size(92, 17)
        Me.lblColBy.TabIndex = 5
        Me.lblColBy.Text = "Collected by:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Add Pen.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 18)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Pen. Paid:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(191, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Savings:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Ret. Fund:"
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsurance.Location = New System.Drawing.Point(191, 95)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(78, 18)
        Me.lblInsurance.TabIndex = 5
        Me.lblInsurance.Text = "Insurance:"
        '
        'lblLoanRep
        '
        Me.lblLoanRep.AutoSize = True
        Me.lblLoanRep.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanRep.Location = New System.Drawing.Point(21, 95)
        Me.lblLoanRep.Name = "lblLoanRep"
        Me.lblLoanRep.Size = New System.Drawing.Size(84, 18)
        Me.lblLoanRep.TabIndex = 5
        Me.lblLoanRep.Text = "Loan Rep.:"
        '
        'dgViewAddingColl
        '
        Me.dgViewAddingColl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgViewAddingColl.AutoGenerateColumns = False
        Me.dgViewAddingColl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgViewAddingColl.DataSource = Me.TblCollectionBindingSource
        Me.dgViewAddingColl.Location = New System.Drawing.Point(366, 19)
        Me.dgViewAddingColl.Name = "dgViewAddingColl"
        Me.dgViewAddingColl.Size = New System.Drawing.Size(686, 475)
        Me.dgViewAddingColl.TabIndex = 0
        '
        'txtTotalRep
        '
        Me.txtTotalRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRep.Location = New System.Drawing.Point(895, 502)
        Me.txtTotalRep.Name = "txtTotalRep"
        Me.txtTotalRep.Size = New System.Drawing.Size(157, 30)
        Me.txtTotalRep.TabIndex = 8
        '
        'frmCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 551)
        Me.Controls.Add(Me.txtTotalRep)
        Me.Controls.Add(Me.dgViewAddingColl)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximumSize = New System.Drawing.Size(1150, 600)
        Me.Name = "frmCollection"
        Me.Text = "Collection Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgViewAddingColl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCollectionLoanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDate As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtAddPenalty As TextBox
    Friend WithEvents txtTotalPayment As TextBox
    Friend WithEvents txtPenaltyPaid As TextBox
    Friend WithEvents txtSavingsDep As TextBox
    Friend WithEvents txtRetFund As TextBox
    Friend WithEvents txtInsurance As TextBox
    Friend WithEvents txtLoanRep As TextBox
    Friend WithEvents txtRefNo As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblInsurance As Label
    Friend WithEvents lblLoanRep As Label
    Friend WithEvents dgViewAddingColl As DataGridView
    Friend WithEvents txtTotalRep As TextBox
    Friend WithEvents txtColBy As TextBox
    Friend WithEvents lblColBy As Label
    Friend WithEvents ReceiptNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReceiptDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PenaltyAmtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CollectedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn

    Friend WithEvents RefNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoanAccNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrincipalAmtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IntAmtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PenaltyPaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TblCollectionLoanBindingSource As BindingSource
    Friend WithEvents txtAddPenNote As TextBox
    Friend WithEvents txtOtherPayDesc As TextBox
    Friend WithEvents txtOtherPayment As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSavingsWithdraw As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents View1BindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents TblCollectionBindingSource As BindingSource
    Friend WithEvents cboCustName As ComboBox
    Friend WithEvents chkRefNo As CheckBox
    Friend WithEvents chkCollDate As CheckBox
    Friend WithEvents btnShowLastRefNo As Button
    Friend WithEvents btnClearTxtbox As Button
    Friend WithEvents chkCollBy As CheckBox
End Class
