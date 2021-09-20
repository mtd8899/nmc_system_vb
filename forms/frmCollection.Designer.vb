<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtColBy = New System.Windows.Forms.TextBox()
        Me.txtAddPenalty = New System.Windows.Forms.TextBox()
        Me.txtTotalPayment = New System.Windows.Forms.TextBox()
        Me.txtPenaltyPaid = New System.Windows.Forms.TextBox()
        Me.txtSavingsDep = New System.Windows.Forms.TextBox()
        Me.txtRetFund = New System.Windows.Forms.TextBox()
        Me.txtInsurance = New System.Windows.Forms.TextBox()
        Me.txtLoanAccNo = New System.Windows.Forms.TextBox()
        Me.txtLoanRep = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtRefNo = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblColBy = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblInsurance = New System.Windows.Forms.Label()
        Me.lblLoanRep = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblRefNo = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.dgViewAddingColl = New System.Windows.Forms.DataGridView()
        Me.txtTotalRep = New System.Windows.Forms.TextBox()
        Me.NewMalayan1DataSet = New nmc_system_vb.NewMalayan1DataSet()
        Me.TblCollectionLoanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCollectionLoanTableAdapter = New nmc_system_vb.NewMalayan1DataSetTableAdapters.tblCollectionLoanTableAdapter()
        Me.txtAddPenNote = New System.Windows.Forms.TextBox()
        Me.txtOtherPayDesc = New System.Windows.Forms.TextBox()
        Me.txtOtherPayment = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSavingsWithdraw = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.View1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_1TableAdapter = New nmc_system_vb.NewMalayan1DataSetTableAdapters.View_1TableAdapter()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCollectionTableAdapter = New nmc_system_vb.NewMalayan1DataSetTableAdapters.tblCollectionTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgViewAddingColl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewMalayan1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCollectionLoanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(30, 31)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(46, 18)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "Date:"
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Controls.Add(Me.txtLoanAccNo)
        Me.GroupBox1.Controls.Add(Me.txtLoanRep)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtRefNo)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.lblColBy)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblInsurance)
        Me.GroupBox1.Controls.Add(Me.lblLoanRep)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.lblRefNo)
        Me.GroupBox1.Controls.Add(Me.lblDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 530)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Payment"
        '
        'txtColBy
        '
        Me.txtColBy.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColBy.Location = New System.Drawing.Point(98, 488)
        Me.txtColBy.Name = "txtColBy"
        Me.txtColBy.Size = New System.Drawing.Size(179, 26)
        Me.txtColBy.TabIndex = 15
        '
        'txtAddPenalty
        '
        Me.txtAddPenalty.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddPenalty.Location = New System.Drawing.Point(132, 300)
        Me.txtAddPenalty.Name = "txtAddPenalty"
        Me.txtAddPenalty.Size = New System.Drawing.Size(145, 26)
        Me.txtAddPenalty.TabIndex = 9
        '
        'txtTotalPayment
        '
        Me.txtTotalPayment.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPayment.Location = New System.Drawing.Point(145, 424)
        Me.txtTotalPayment.Name = "txtTotalPayment"
        Me.txtTotalPayment.Size = New System.Drawing.Size(132, 26)
        Me.txtTotalPayment.TabIndex = 13
        '
        'txtPenaltyPaid
        '
        Me.txtPenaltyPaid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenaltyPaid.Location = New System.Drawing.Point(136, 268)
        Me.txtPenaltyPaid.Name = "txtPenaltyPaid"
        Me.txtPenaltyPaid.Size = New System.Drawing.Size(141, 26)
        Me.txtPenaltyPaid.TabIndex = 8
        '
        'txtSavingsDep
        '
        Me.txtSavingsDep.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSavingsDep.Location = New System.Drawing.Point(104, 238)
        Me.txtSavingsDep.Name = "txtSavingsDep"
        Me.txtSavingsDep.Size = New System.Drawing.Size(173, 26)
        Me.txtSavingsDep.TabIndex = 7
        '
        'txtRetFund
        '
        Me.txtRetFund.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetFund.Location = New System.Drawing.Point(115, 208)
        Me.txtRetFund.Name = "txtRetFund"
        Me.txtRetFund.Size = New System.Drawing.Size(162, 26)
        Me.txtRetFund.TabIndex = 6
        '
        'txtInsurance
        '
        Me.txtInsurance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsurance.Location = New System.Drawing.Point(114, 178)
        Me.txtInsurance.Name = "txtInsurance"
        Me.txtInsurance.Size = New System.Drawing.Size(163, 26)
        Me.txtInsurance.TabIndex = 5
        '
        'txtLoanAccNo
        '
        Me.txtLoanAccNo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanAccNo.Location = New System.Drawing.Point(145, 117)
        Me.txtLoanAccNo.Name = "txtLoanAccNo"
        Me.txtLoanAccNo.Size = New System.Drawing.Size(132, 26)
        Me.txtLoanAccNo.TabIndex = 3
        '
        'txtLoanRep
        '
        Me.txtLoanRep.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanRep.Location = New System.Drawing.Point(120, 148)
        Me.txtLoanRep.Name = "txtLoanRep"
        Me.txtLoanRep.Size = New System.Drawing.Size(157, 26)
        Me.txtLoanRep.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(90, 87)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(187, 26)
        Me.txtName.TabIndex = 2
        '
        'txtRefNo
        '
        Me.txtRefNo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.Location = New System.Drawing.Point(104, 57)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(173, 26)
        Me.txtRefNo.TabIndex = 1
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(82, 27)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(195, 26)
        Me.txtDate.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 427)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 18)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Total Payment:"
        '
        'lblColBy
        '
        Me.lblColBy.AutoSize = True
        Me.lblColBy.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColBy.Location = New System.Drawing.Point(30, 491)
        Me.lblColBy.Name = "lblColBy"
        Me.lblColBy.Size = New System.Drawing.Size(62, 18)
        Me.lblColBy.TabIndex = 5
        Me.lblColBy.Text = "Col. By:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Add Penalty:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 18)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Penalty Paid:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Savings:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Ret. Fund:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Loan Acc. No.:"
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsurance.Location = New System.Drawing.Point(30, 181)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(78, 18)
        Me.lblInsurance.TabIndex = 5
        Me.lblInsurance.Text = "Insurance:"
        '
        'lblLoanRep
        '
        Me.lblLoanRep.AutoSize = True
        Me.lblLoanRep.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanRep.Location = New System.Drawing.Point(30, 151)
        Me.lblLoanRep.Name = "lblLoanRep"
        Me.lblLoanRep.Size = New System.Drawing.Size(84, 18)
        Me.lblLoanRep.TabIndex = 5
        Me.lblLoanRep.Text = "Loan Rep.:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(30, 91)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(54, 18)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name:"
        '
        'lblRefNo
        '
        Me.lblRefNo.AutoSize = True
        Me.lblRefNo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefNo.Location = New System.Drawing.Point(30, 61)
        Me.lblRefNo.Name = "lblRefNo"
        Me.lblRefNo.Size = New System.Drawing.Size(68, 18)
        Me.lblRefNo.TabIndex = 5
        Me.lblRefNo.Text = "Ref. No.:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(308, 500)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(165, 39)
        Me.btnSubmit.TabIndex = 16
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'dgViewAddingColl
        '
        Me.dgViewAddingColl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgViewAddingColl.AutoGenerateColumns = False
        Me.dgViewAddingColl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgViewAddingColl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.dgViewAddingColl.DataSource = Me.TblCollectionBindingSource
        Me.dgViewAddingColl.Location = New System.Drawing.Point(308, 9)
        Me.dgViewAddingColl.Name = "dgViewAddingColl"
        Me.dgViewAddingColl.Size = New System.Drawing.Size(744, 487)
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
        'NewMalayan1DataSet
        '
        Me.NewMalayan1DataSet.DataSetName = "NewMalayan1DataSet"
        Me.NewMalayan1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCollectionLoanBindingSource
        '
        Me.TblCollectionLoanBindingSource.DataMember = "tblCollectionLoan"
        Me.TblCollectionLoanBindingSource.DataSource = Me.NewMalayan1DataSet
        '
        'TblCollectionLoanTableAdapter
        '
        Me.TblCollectionLoanTableAdapter.ClearBeforeFill = True
        '
        'txtAddPenNote
        '
        Me.txtAddPenNote.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddPenNote.Location = New System.Drawing.Point(81, 331)
        Me.txtAddPenNote.Name = "txtAddPenNote"
        Me.txtAddPenNote.Size = New System.Drawing.Size(196, 26)
        Me.txtAddPenNote.TabIndex = 10
        '
        'txtOtherPayDesc
        '
        Me.txtOtherPayDesc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherPayDesc.Location = New System.Drawing.Point(87, 392)
        Me.txtOtherPayDesc.Name = "txtOtherPayDesc"
        Me.txtOtherPayDesc.Size = New System.Drawing.Size(190, 26)
        Me.txtOtherPayDesc.TabIndex = 12
        '
        'txtOtherPayment
        '
        Me.txtOtherPayment.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherPayment.Location = New System.Drawing.Point(149, 361)
        Me.txtOtherPayment.Name = "txtOtherPayment"
        Me.txtOtherPayment.Size = New System.Drawing.Size(128, 26)
        Me.txtOtherPayment.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 364)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Other Payment:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Note:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 395)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 18)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Desc.:"
        '
        'txtSavingsWithdraw
        '
        Me.txtSavingsWithdraw.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSavingsWithdraw.Location = New System.Drawing.Point(173, 456)
        Me.txtSavingsWithdraw.Name = "txtSavingsWithdraw"
        Me.txtSavingsWithdraw.Size = New System.Drawing.Size(104, 26)
        Me.txtSavingsWithdraw.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 459)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 18)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Savings Withdraw:"
        '
        'View1BindingSource
        '
        Me.View1BindingSource.DataMember = "View_1"
        Me.View1BindingSource.DataSource = Me.NewMalayan1DataSet
        '
        'View_1TableAdapter
        '
        Me.View_1TableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "RefNo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "RefNo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'TblCollectionBindingSource
        '
        Me.TblCollectionBindingSource.DataMember = "tblCollection"
        Me.TblCollectionBindingSource.DataSource = Me.NewMalayan1DataSet
        '
        'TblCollectionTableAdapter
        '
        Me.TblCollectionTableAdapter.ClearBeforeFill = True
        '
        'frmCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 551)
        Me.Controls.Add(Me.btnSubmit)
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
        CType(Me.NewMalayan1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCollectionLoanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtLoanAccNo As TextBox
    Friend WithEvents txtLoanRep As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtRefNo As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblInsurance As Label
    Friend WithEvents lblLoanRep As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblRefNo As Label
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
    Friend WithEvents NewMalayan1DataSet As NewMalayan1DataSet
    Friend WithEvents TblCollectionLoanBindingSource As BindingSource
    Friend WithEvents TblCollectionLoanTableAdapter As NewMalayan1DataSetTableAdapters.tblCollectionLoanTableAdapter
    Friend WithEvents txtAddPenNote As TextBox
    Friend WithEvents txtOtherPayDesc As TextBox
    Friend WithEvents txtOtherPayment As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSavingsWithdraw As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents View1BindingSource As BindingSource
    Friend WithEvents View_1TableAdapter As NewMalayan1DataSetTableAdapters.View_1TableAdapter
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents TblCollectionBindingSource As BindingSource
    Friend WithEvents TblCollectionTableAdapter As NewMalayan1DataSetTableAdapters.tblCollectionTableAdapter
End Class
