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
        Me.txtSavings = New System.Windows.Forms.TextBox()
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgViewAddingColl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewMalayan1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCollectionLoanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(6, 30)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(63, 25)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "Date:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtColBy)
        Me.GroupBox1.Controls.Add(Me.txtAddPenalty)
        Me.GroupBox1.Controls.Add(Me.txtTotalPayment)
        Me.GroupBox1.Controls.Add(Me.txtPenaltyPaid)
        Me.GroupBox1.Controls.Add(Me.txtSavings)
        Me.GroupBox1.Controls.Add(Me.txtRetFund)
        Me.GroupBox1.Controls.Add(Me.txtInsurance)
        Me.GroupBox1.Controls.Add(Me.txtLoanAccNo)
        Me.GroupBox1.Controls.Add(Me.txtLoanRep)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtRefNo)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.Label8)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 503)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txtColBy
        '
        Me.txtColBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColBy.Location = New System.Drawing.Point(99, 450)
        Me.txtColBy.Name = "txtColBy"
        Me.txtColBy.Size = New System.Drawing.Size(215, 30)
        Me.txtColBy.TabIndex = 11
        '
        'txtAddPenalty
        '
        Me.txtAddPenalty.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddPenalty.Location = New System.Drawing.Point(149, 411)
        Me.txtAddPenalty.Name = "txtAddPenalty"
        Me.txtAddPenalty.Size = New System.Drawing.Size(165, 30)
        Me.txtAddPenalty.TabIndex = 10
        '
        'txtTotalPayment
        '
        Me.txtTotalPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPayment.Location = New System.Drawing.Point(171, 372)
        Me.txtTotalPayment.Name = "txtTotalPayment"
        Me.txtTotalPayment.Size = New System.Drawing.Size(143, 30)
        Me.txtTotalPayment.TabIndex = 9
        '
        'txtPenaltyPaid
        '
        Me.txtPenaltyPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenaltyPaid.Location = New System.Drawing.Point(154, 333)
        Me.txtPenaltyPaid.Name = "txtPenaltyPaid"
        Me.txtPenaltyPaid.Size = New System.Drawing.Size(160, 30)
        Me.txtPenaltyPaid.TabIndex = 8
        '
        'txtSavings
        '
        Me.txtSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSavings.Location = New System.Drawing.Point(110, 294)
        Me.txtSavings.Name = "txtSavings"
        Me.txtSavings.Size = New System.Drawing.Size(204, 30)
        Me.txtSavings.TabIndex = 7
        '
        'txtRetFund
        '
        Me.txtRetFund.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetFund.Location = New System.Drawing.Point(127, 255)
        Me.txtRetFund.Name = "txtRetFund"
        Me.txtRetFund.Size = New System.Drawing.Size(188, 30)
        Me.txtRetFund.TabIndex = 6
        '
        'txtInsurance
        '
        Me.txtInsurance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsurance.Location = New System.Drawing.Point(127, 216)
        Me.txtInsurance.Name = "txtInsurance"
        Me.txtInsurance.Size = New System.Drawing.Size(188, 30)
        Me.txtInsurance.TabIndex = 5
        '
        'txtLoanAccNo
        '
        Me.txtLoanAccNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanAccNo.Location = New System.Drawing.Point(168, 141)
        Me.txtLoanAccNo.Name = "txtLoanAccNo"
        Me.txtLoanAccNo.Size = New System.Drawing.Size(146, 30)
        Me.txtLoanAccNo.TabIndex = 3
        '
        'txtLoanRep
        '
        Me.txtLoanRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanRep.Location = New System.Drawing.Point(132, 177)
        Me.txtLoanRep.Name = "txtLoanRep"
        Me.txtLoanRep.Size = New System.Drawing.Size(182, 30)
        Me.txtLoanRep.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(89, 105)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(225, 30)
        Me.txtName.TabIndex = 2
        '
        'txtRefNo
        '
        Me.txtRefNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.Location = New System.Drawing.Point(111, 66)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(203, 30)
        Me.txtRefNo.TabIndex = 1
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(78, 25)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(236, 30)
        Me.txtDate.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 375)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 25)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Total Payment:"
        '
        'lblColBy
        '
        Me.lblColBy.AutoSize = True
        Me.lblColBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColBy.Location = New System.Drawing.Point(6, 453)
        Me.lblColBy.Name = "lblColBy"
        Me.lblColBy.Size = New System.Drawing.Size(87, 25)
        Me.lblColBy.TabIndex = 5
        Me.lblColBy.Text = "Col. By:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 414)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Add Penalty:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 25)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Penalty Paid:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 297)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Savings:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Ret. Fund:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Loan Acc. No.:"
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsurance.Location = New System.Drawing.Point(6, 219)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(112, 25)
        Me.lblInsurance.TabIndex = 5
        Me.lblInsurance.Text = "Insurance:"
        '
        'lblLoanRep
        '
        Me.lblLoanRep.AutoSize = True
        Me.lblLoanRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanRep.Location = New System.Drawing.Point(6, 180)
        Me.lblLoanRep.Name = "lblLoanRep"
        Me.lblLoanRep.Size = New System.Drawing.Size(117, 25)
        Me.lblLoanRep.TabIndex = 5
        Me.lblLoanRep.Text = "Loan Rep.:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(6, 108)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(74, 25)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name:"
        '
        'lblRefNo
        '
        Me.lblRefNo.AutoSize = True
        Me.lblRefNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefNo.Location = New System.Drawing.Point(6, 69)
        Me.lblRefNo.Name = "lblRefNo"
        Me.lblRefNo.Size = New System.Drawing.Size(96, 25)
        Me.lblRefNo.TabIndex = 5
        Me.lblRefNo.Text = "Ref. No.:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(347, 460)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(165, 39)
        Me.btnSubmit.TabIndex = 12
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'dgViewAddingColl
        '
        Me.dgViewAddingColl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgViewAddingColl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgViewAddingColl.Location = New System.Drawing.Point(347, 18)
        Me.dgViewAddingColl.Name = "dgViewAddingColl"
        Me.dgViewAddingColl.Size = New System.Drawing.Size(705, 433)
        Me.dgViewAddingColl.TabIndex = 0
        '
        'txtTotalRep
        '
        Me.txtTotalRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRep.Location = New System.Drawing.Point(895, 460)
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
        'frmCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 527)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtTotalRep)
        Me.Controls.Add(Me.dgViewAddingColl)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximumSize = New System.Drawing.Size(1150, 566)
        Me.Name = "frmCollection"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgViewAddingColl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewMalayan1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCollectionLoanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDate As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtAddPenalty As TextBox
    Friend WithEvents txtTotalPayment As TextBox
    Friend WithEvents txtPenaltyPaid As TextBox
    Friend WithEvents txtSavings As TextBox
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
End Class
