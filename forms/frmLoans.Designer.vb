<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoans
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabLoans = New System.Windows.Forms.TabControl()
        Me.tabViewLoans = New System.Windows.Forms.TabPage()
        Me.btnShowfrmLoanAdd = New System.Windows.Forms.Button()
        Me.dgViewLoans = New System.Windows.Forms.DataGridView()
        Me.tabAddLoan = New System.Windows.Forms.TabPage()
        Me.btnShowAddPayment = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LoanAccNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateReleaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrincipalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TermsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoanTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaturityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblLoanReleaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewMalayan1DataSet = New nmc_system_vb.NewMalayan1DataSet()
        Me.TblLoanReleaseTableAdapter = New nmc_system_vb.NewMalayan1DataSetTableAdapters.tblLoanReleaseTableAdapter()
        Me.TblCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCollectionTableAdapter = New nmc_system_vb.NewMalayan1DataSetTableAdapters.tblCollectionTableAdapter()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustIdDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabLoans.SuspendLayout()
        Me.tabViewLoans.SuspendLayout()
        CType(Me.dgViewLoans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAddLoan.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLoanReleaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewMalayan1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabLoans
        '
        Me.tabLoans.Controls.Add(Me.tabViewLoans)
        Me.tabLoans.Controls.Add(Me.tabAddLoan)
        Me.tabLoans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabLoans.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabLoans.Location = New System.Drawing.Point(0, 0)
        Me.tabLoans.Name = "tabLoans"
        Me.tabLoans.SelectedIndex = 0
        Me.tabLoans.Size = New System.Drawing.Size(1013, 412)
        Me.tabLoans.TabIndex = 0
        '
        'tabViewLoans
        '
        Me.tabViewLoans.Controls.Add(Me.btnShowfrmLoanAdd)
        Me.tabViewLoans.Controls.Add(Me.dgViewLoans)
        Me.tabViewLoans.Location = New System.Drawing.Point(4, 29)
        Me.tabViewLoans.Name = "tabViewLoans"
        Me.tabViewLoans.Padding = New System.Windows.Forms.Padding(3)
        Me.tabViewLoans.Size = New System.Drawing.Size(1005, 379)
        Me.tabViewLoans.TabIndex = 0
        Me.tabViewLoans.Text = "View Loans"
        Me.tabViewLoans.UseVisualStyleBackColor = True
        '
        'btnShowfrmLoanAdd
        '
        Me.btnShowfrmLoanAdd.Location = New System.Drawing.Point(6, 6)
        Me.btnShowfrmLoanAdd.Name = "btnShowfrmLoanAdd"
        Me.btnShowfrmLoanAdd.Size = New System.Drawing.Size(147, 38)
        Me.btnShowfrmLoanAdd.TabIndex = 2
        Me.btnShowfrmLoanAdd.Text = "New"
        Me.btnShowfrmLoanAdd.UseVisualStyleBackColor = True
        '
        'dgViewLoans
        '
        Me.dgViewLoans.AllowUserToDeleteRows = False
        Me.dgViewLoans.AllowUserToOrderColumns = True
        Me.dgViewLoans.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgViewLoans.AutoGenerateColumns = False
        Me.dgViewLoans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgViewLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgViewLoans.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoanAccNoDataGridViewTextBoxColumn, Me.CustIDDataGridViewTextBoxColumn, Me.DateReleaseDataGridViewTextBoxColumn, Me.PrincipalDataGridViewTextBoxColumn, Me.InterestDataGridViewTextBoxColumn, Me.ProcFeeDataGridViewTextBoxColumn, Me.TermsDataGridViewTextBoxColumn, Me.LoanTypeDataGridViewTextBoxColumn, Me.MaturityDataGridViewTextBoxColumn})
        Me.dgViewLoans.DataSource = Me.TblLoanReleaseBindingSource
        Me.dgViewLoans.Location = New System.Drawing.Point(8, 50)
        Me.dgViewLoans.Name = "dgViewLoans"
        Me.dgViewLoans.ReadOnly = True
        Me.dgViewLoans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgViewLoans.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgViewLoans.Size = New System.Drawing.Size(989, 321)
        Me.dgViewLoans.TabIndex = 0
        '
        'tabAddLoan
        '
        Me.tabAddLoan.Controls.Add(Me.btnShowAddPayment)
        Me.tabAddLoan.Controls.Add(Me.DataGridView2)
        Me.tabAddLoan.Location = New System.Drawing.Point(4, 29)
        Me.tabAddLoan.Name = "tabAddLoan"
        Me.tabAddLoan.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAddLoan.Size = New System.Drawing.Size(1005, 379)
        Me.tabAddLoan.TabIndex = 1
        Me.tabAddLoan.Text = "Payment"
        Me.tabAddLoan.UseVisualStyleBackColor = True
        '
        'btnShowAddPayment
        '
        Me.btnShowAddPayment.Location = New System.Drawing.Point(9, 6)
        Me.btnShowAddPayment.Name = "btnShowAddPayment"
        Me.btnShowAddPayment.Size = New System.Drawing.Size(147, 38)
        Me.btnShowAddPayment.TabIndex = 1
        Me.btnShowAddPayment.Text = "New Payment"
        Me.btnShowAddPayment.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.TotalPaidDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn3, Me.CustIdDataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4})
        Me.DataGridView2.DataSource = Me.TblCollectionBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(8, 50)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(989, 321)
        Me.DataGridView2.TabIndex = 0
        '
        'LoanAccNoDataGridViewTextBoxColumn
        '
        Me.LoanAccNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.LoanAccNoDataGridViewTextBoxColumn.DataPropertyName = "LoanAccNo"
        Me.LoanAccNoDataGridViewTextBoxColumn.HeaderText = "Loan Acc. No."
        Me.LoanAccNoDataGridViewTextBoxColumn.Name = "LoanAccNoDataGridViewTextBoxColumn"
        Me.LoanAccNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.LoanAccNoDataGridViewTextBoxColumn.Width = 109
        '
        'CustIDDataGridViewTextBoxColumn
        '
        Me.CustIDDataGridViewTextBoxColumn.DataPropertyName = "CustID"
        Me.CustIDDataGridViewTextBoxColumn.HeaderText = "Cust. ID "
        Me.CustIDDataGridViewTextBoxColumn.Name = "CustIDDataGridViewTextBoxColumn"
        Me.CustIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustIDDataGridViewTextBoxColumn.Width = 96
        '
        'DateReleaseDataGridViewTextBoxColumn
        '
        Me.DateReleaseDataGridViewTextBoxColumn.DataPropertyName = "DateRelease"
        Me.DateReleaseDataGridViewTextBoxColumn.HeaderText = "Release"
        Me.DateReleaseDataGridViewTextBoxColumn.Name = "DateReleaseDataGridViewTextBoxColumn"
        Me.DateReleaseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrincipalDataGridViewTextBoxColumn
        '
        Me.PrincipalDataGridViewTextBoxColumn.DataPropertyName = "Principal"
        Me.PrincipalDataGridViewTextBoxColumn.HeaderText = "Principal"
        Me.PrincipalDataGridViewTextBoxColumn.Name = "PrincipalDataGridViewTextBoxColumn"
        Me.PrincipalDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrincipalDataGridViewTextBoxColumn.Width = 102
        '
        'InterestDataGridViewTextBoxColumn
        '
        Me.InterestDataGridViewTextBoxColumn.DataPropertyName = "Interest"
        Me.InterestDataGridViewTextBoxColumn.HeaderText = "Interest"
        Me.InterestDataGridViewTextBoxColumn.Name = "InterestDataGridViewTextBoxColumn"
        Me.InterestDataGridViewTextBoxColumn.ReadOnly = True
        Me.InterestDataGridViewTextBoxColumn.Width = 97
        '
        'ProcFeeDataGridViewTextBoxColumn
        '
        Me.ProcFeeDataGridViewTextBoxColumn.DataPropertyName = "ProcFee"
        Me.ProcFeeDataGridViewTextBoxColumn.HeaderText = "Proc. Fee"
        Me.ProcFeeDataGridViewTextBoxColumn.Name = "ProcFeeDataGridViewTextBoxColumn"
        Me.ProcFeeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProcFeeDataGridViewTextBoxColumn.Width = 102
        '
        'TermsDataGridViewTextBoxColumn
        '
        Me.TermsDataGridViewTextBoxColumn.DataPropertyName = "Terms"
        Me.TermsDataGridViewTextBoxColumn.HeaderText = "Terms"
        Me.TermsDataGridViewTextBoxColumn.Name = "TermsDataGridViewTextBoxColumn"
        Me.TermsDataGridViewTextBoxColumn.ReadOnly = True
        Me.TermsDataGridViewTextBoxColumn.Width = 83
        '
        'LoanTypeDataGridViewTextBoxColumn
        '
        Me.LoanTypeDataGridViewTextBoxColumn.DataPropertyName = "LoanType"
        Me.LoanTypeDataGridViewTextBoxColumn.HeaderText = "Loan Type"
        Me.LoanTypeDataGridViewTextBoxColumn.Name = "LoanTypeDataGridViewTextBoxColumn"
        Me.LoanTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.LoanTypeDataGridViewTextBoxColumn.Width = 107
        '
        'MaturityDataGridViewTextBoxColumn
        '
        Me.MaturityDataGridViewTextBoxColumn.DataPropertyName = "Maturity"
        Me.MaturityDataGridViewTextBoxColumn.HeaderText = "Maturity"
        Me.MaturityDataGridViewTextBoxColumn.Name = "MaturityDataGridViewTextBoxColumn"
        Me.MaturityDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaturityDataGridViewTextBoxColumn.Width = 98
        '
        'TblLoanReleaseBindingSource
        '
        Me.TblLoanReleaseBindingSource.DataMember = "tblLoanRelease"
        Me.TblLoanReleaseBindingSource.DataSource = Me.NewMalayan1DataSet
        '
        'NewMalayan1DataSet
        '
        Me.NewMalayan1DataSet.DataSetName = "NewMalayan1DataSet"
        Me.NewMalayan1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblLoanReleaseTableAdapter
        '
        Me.TblLoanReleaseTableAdapter.ClearBeforeFill = True
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
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RefNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "RefNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'TotalPaidDataGridViewTextBoxColumn
        '
        Me.TotalPaidDataGridViewTextBoxColumn.DataPropertyName = "TotalPaid"
        Me.TotalPaidDataGridViewTextBoxColumn.HeaderText = "TotalPaid"
        Me.TotalPaidDataGridViewTextBoxColumn.Name = "TotalPaidDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'CustIdDataGridViewTextBoxColumn2
        '
        Me.CustIdDataGridViewTextBoxColumn2.DataPropertyName = "CustId"
        Me.CustIdDataGridViewTextBoxColumn2.HeaderText = "CustId"
        Me.CustIdDataGridViewTextBoxColumn2.Name = "CustIdDataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CollectedBy"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CollectedBy"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'frmLoans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 412)
        Me.Controls.Add(Me.tabLoans)
        Me.Name = "frmLoans"
        Me.Text = "Loans"
        Me.tabLoans.ResumeLayout(False)
        Me.tabViewLoans.ResumeLayout(False)
        CType(Me.dgViewLoans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAddLoan.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLoanReleaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewMalayan1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabLoans As TabControl
    Friend WithEvents tabViewLoans As TabPage
    Friend WithEvents tabAddLoan As TabPage
    Friend WithEvents dgViewLoans As DataGridView
    Friend WithEvents NewMalayan1DataSet As NewMalayan1DataSet
    Friend WithEvents TblLoanReleaseBindingSource As BindingSource
    Friend WithEvents TblLoanReleaseTableAdapter As NewMalayan1DataSetTableAdapters.tblLoanReleaseTableAdapter
    Private WithEvents btnShowfrmLoanAdd As Button
    Friend WithEvents btnShowAddPayment As Button
    Friend WithEvents LoanAccNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateReleaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrincipalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InterestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProcFeeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TermsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoanTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaturityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReceiptNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReceiptDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PenaltyAmtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CollectedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn

    Friend WithEvents RefNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustIdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LoanAccNoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PrincipalAmtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IntAmtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PenaltyPaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TblCollectionBindingSource As BindingSource
    Friend WithEvents TblCollectionTableAdapter As NewMalayan1DataSetTableAdapters.tblCollectionTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TotalPaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents CustIdDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
