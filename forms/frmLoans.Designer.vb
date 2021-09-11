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
        Me.tabLoans = New System.Windows.Forms.TabControl()
        Me.tabViewLoans = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tabAddLoan = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.NewMalayan1DataSet = New nmc_system_vb.NewMalayan1DataSet()
        Me.TblLoanReleaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblLoanReleaseTableAdapter = New nmc_system_vb.NewMalayan1DataSetTableAdapters.tblLoanReleaseTableAdapter()
        Me.LoanAccNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateReleaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrincipalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TermsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoanTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaturityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabLoans.SuspendLayout()
        Me.tabViewLoans.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAddLoan.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewMalayan1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLoanReleaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabLoans
        '
        Me.tabLoans.Controls.Add(Me.tabViewLoans)
        Me.tabLoans.Controls.Add(Me.tabAddLoan)
        Me.tabLoans.Controls.Add(Me.TabPage3)
        Me.tabLoans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabLoans.Location = New System.Drawing.Point(0, 0)
        Me.tabLoans.Name = "tabLoans"
        Me.tabLoans.SelectedIndex = 0
        Me.tabLoans.Size = New System.Drawing.Size(1013, 510)
        Me.tabLoans.TabIndex = 0
        '
        'tabViewLoans
        '
        Me.tabViewLoans.Controls.Add(Me.DataGridView1)
        Me.tabViewLoans.Location = New System.Drawing.Point(4, 22)
        Me.tabViewLoans.Name = "tabViewLoans"
        Me.tabViewLoans.Padding = New System.Windows.Forms.Padding(3)
        Me.tabViewLoans.Size = New System.Drawing.Size(1005, 484)
        Me.tabViewLoans.TabIndex = 0
        Me.tabViewLoans.Text = "View Loans"
        Me.tabViewLoans.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoanAccNoDataGridViewTextBoxColumn, Me.CustIDDataGridViewTextBoxColumn, Me.DateReleaseDataGridViewTextBoxColumn, Me.PrincipalDataGridViewTextBoxColumn, Me.InterestDataGridViewTextBoxColumn, Me.ProcFeeDataGridViewTextBoxColumn, Me.TermsDataGridViewTextBoxColumn, Me.LoanTypeDataGridViewTextBoxColumn, Me.MaturityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblLoanReleaseBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(8, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(934, 387)
        Me.DataGridView1.TabIndex = 0
        '
        'tabAddLoan
        '
        Me.tabAddLoan.Controls.Add(Me.DataGridView2)
        Me.tabAddLoan.Location = New System.Drawing.Point(4, 22)
        Me.tabAddLoan.Name = "tabAddLoan"
        Me.tabAddLoan.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAddLoan.Size = New System.Drawing.Size(1005, 484)
        Me.tabAddLoan.TabIndex = 1
        Me.tabAddLoan.Text = " Add Loan"
        Me.tabAddLoan.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(69, 76)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(545, 150)
        Me.DataGridView2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1005, 484)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Loan "
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'NewMalayan1DataSet
        '
        Me.NewMalayan1DataSet.DataSetName = "NewMalayan1DataSet"
        Me.NewMalayan1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblLoanReleaseBindingSource
        '
        Me.TblLoanReleaseBindingSource.DataMember = "tblLoanRelease"
        Me.TblLoanReleaseBindingSource.DataSource = Me.NewMalayan1DataSet
        '
        'TblLoanReleaseTableAdapter
        '
        Me.TblLoanReleaseTableAdapter.ClearBeforeFill = True
        '
        'LoanAccNoDataGridViewTextBoxColumn
        '
        Me.LoanAccNoDataGridViewTextBoxColumn.DataPropertyName = "LoanAccNo"
        Me.LoanAccNoDataGridViewTextBoxColumn.HeaderText = "LoanAccNo"
        Me.LoanAccNoDataGridViewTextBoxColumn.Name = "LoanAccNoDataGridViewTextBoxColumn"
        '
        'CustIDDataGridViewTextBoxColumn
        '
        Me.CustIDDataGridViewTextBoxColumn.DataPropertyName = "CustID"
        Me.CustIDDataGridViewTextBoxColumn.HeaderText = "CustID"
        Me.CustIDDataGridViewTextBoxColumn.Name = "CustIDDataGridViewTextBoxColumn"
        '
        'DateReleaseDataGridViewTextBoxColumn
        '
        Me.DateReleaseDataGridViewTextBoxColumn.DataPropertyName = "DateRelease"
        Me.DateReleaseDataGridViewTextBoxColumn.HeaderText = "DateRelease"
        Me.DateReleaseDataGridViewTextBoxColumn.Name = "DateReleaseDataGridViewTextBoxColumn"
        '
        'PrincipalDataGridViewTextBoxColumn
        '
        Me.PrincipalDataGridViewTextBoxColumn.DataPropertyName = "Principal"
        Me.PrincipalDataGridViewTextBoxColumn.HeaderText = "Principal"
        Me.PrincipalDataGridViewTextBoxColumn.Name = "PrincipalDataGridViewTextBoxColumn"
        '
        'InterestDataGridViewTextBoxColumn
        '
        Me.InterestDataGridViewTextBoxColumn.DataPropertyName = "Interest"
        Me.InterestDataGridViewTextBoxColumn.HeaderText = "Interest"
        Me.InterestDataGridViewTextBoxColumn.Name = "InterestDataGridViewTextBoxColumn"
        '
        'ProcFeeDataGridViewTextBoxColumn
        '
        Me.ProcFeeDataGridViewTextBoxColumn.DataPropertyName = "ProcFee"
        Me.ProcFeeDataGridViewTextBoxColumn.HeaderText = "ProcFee"
        Me.ProcFeeDataGridViewTextBoxColumn.Name = "ProcFeeDataGridViewTextBoxColumn"
        '
        'TermsDataGridViewTextBoxColumn
        '
        Me.TermsDataGridViewTextBoxColumn.DataPropertyName = "Terms"
        Me.TermsDataGridViewTextBoxColumn.HeaderText = "Terms"
        Me.TermsDataGridViewTextBoxColumn.Name = "TermsDataGridViewTextBoxColumn"
        '
        'LoanTypeDataGridViewTextBoxColumn
        '
        Me.LoanTypeDataGridViewTextBoxColumn.DataPropertyName = "LoanType"
        Me.LoanTypeDataGridViewTextBoxColumn.HeaderText = "LoanType"
        Me.LoanTypeDataGridViewTextBoxColumn.Name = "LoanTypeDataGridViewTextBoxColumn"
        '
        'MaturityDataGridViewTextBoxColumn
        '
        Me.MaturityDataGridViewTextBoxColumn.DataPropertyName = "Maturity"
        Me.MaturityDataGridViewTextBoxColumn.HeaderText = "Maturity"
        Me.MaturityDataGridViewTextBoxColumn.Name = "MaturityDataGridViewTextBoxColumn"
        '
        'frmLoans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 510)
        Me.Controls.Add(Me.tabLoans)
        Me.Name = "frmLoans"
        Me.Text = "Loans"
        Me.tabLoans.ResumeLayout(False)
        Me.tabViewLoans.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAddLoan.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewMalayan1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLoanReleaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabLoans As TabControl
    Friend WithEvents tabViewLoans As TabPage
    Friend WithEvents tabAddLoan As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents NewMalayan1DataSet As NewMalayan1DataSet
    Friend WithEvents TblLoanReleaseBindingSource As BindingSource
    Friend WithEvents TblLoanReleaseTableAdapter As NewMalayan1DataSetTableAdapters.tblLoanReleaseTableAdapter
    Friend WithEvents LoanAccNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateReleaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrincipalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InterestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProcFeeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TermsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoanTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaturityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
