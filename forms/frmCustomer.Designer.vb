<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomer
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
        Me.TblCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewMalayan1DataSet = New nmc_system_vb.NewMalayan1DataSet()
        Me.TableAdapterManager = New nmc_system_vb.NewMalayan1DataSetTableAdapters.TableAdapterManager()
        Me.TblCustomersTableAdapter = New nmc_system_vb.NewMalayan1DataSetTableAdapters.tblCustomersTableAdapter()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.pnlCustTab = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.CustStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPrevViewCust = New System.Windows.Forms.Button()
        Me.btnNextViewCust = New System.Windows.Forms.Button()
        Me.btnUpViewCust = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnPrintRepCust = New System.Windows.Forms.Button()
        Me.btnOpenCustAddForm = New System.Windows.Forms.Button()
        Me.cboCenter = New System.Windows.Forms.ComboBox()
        Me.cboCustStatus = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.tabCustHome = New System.Windows.Forms.TabControl()
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewMalayan1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.pnlCustTab.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCustHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'TblCustomersBindingSource
        '
        Me.TblCustomersBindingSource.DataMember = "tblCustomers"
        Me.TblCustomersBindingSource.DataSource = Me.NewMalayan1DataSet
        '
        'NewMalayan1DataSet
        '
        Me.NewMalayan1DataSet.DataSetName = "NewMalayan1DataSet"
        Me.NewMalayan1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblCollectionInsTableAdapter = Nothing
        Me.TableAdapterManager.tblCollectionLoanTableAdapter = Nothing
        Me.TableAdapterManager.tblCollectionSavingsTableAdapter = Nothing
        Me.TableAdapterManager.tblCollMiscTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomersTableAdapter = Me.TblCustomersTableAdapter
        Me.TableAdapterManager.tblInsuranceTableAdapter = Nothing
        Me.TableAdapterManager.tblLoanReleaseTableAdapter = Nothing
        Me.TableAdapterManager.tblSavingsAccTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = nmc_system_vb.NewMalayan1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblCustomersTableAdapter
        '
        Me.TblCustomersTableAdapter.ClearBeforeFill = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.pnlCustTab)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1061, 428)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Customers"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'pnlCustTab
        '
        Me.pnlCustTab.Controls.Add(Me.Panel1)
        Me.pnlCustTab.Controls.Add(Me.Label20)
        Me.pnlCustTab.Controls.Add(Me.Label17)
        Me.pnlCustTab.Controls.Add(Me.cboCustStatus)
        Me.pnlCustTab.Controls.Add(Me.cboCenter)
        Me.pnlCustTab.Controls.Add(Me.btnOpenCustAddForm)
        Me.pnlCustTab.Controls.Add(Me.btnPrintRepCust)
        Me.pnlCustTab.Controls.Add(Me.btnDown)
        Me.pnlCustTab.Controls.Add(Me.btnUpViewCust)
        Me.pnlCustTab.Controls.Add(Me.btnNextViewCust)
        Me.pnlCustTab.Controls.Add(Me.btnPrevViewCust)
        Me.pnlCustTab.Controls.Add(Me.DataGridView2)
        Me.pnlCustTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCustTab.Location = New System.Drawing.Point(3, 3)
        Me.pnlCustTab.Name = "pnlCustTab"
        Me.pnlCustTab.Size = New System.Drawing.Size(1055, 422)
        Me.pnlCustTab.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.CustStatusDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.TblCustomersBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(5, 39)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1045, 330)
        Me.DataGridView2.TabIndex = 0
        '
        'CustStatusDataGridViewTextBoxColumn
        '
        Me.CustStatusDataGridViewTextBoxColumn.DataPropertyName = "CustStatus"
        Me.CustStatusDataGridViewTextBoxColumn.HeaderText = "CustStatus"
        Me.CustStatusDataGridViewTextBoxColumn.Name = "CustStatusDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "CustBplace"
        Me.DataGridViewTextBoxColumn13.HeaderText = "CustBplace"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "CustSpouse"
        Me.DataGridViewTextBoxColumn12.HeaderText = "CustSpouse"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CustDOM"
        Me.DataGridViewTextBoxColumn11.HeaderText = "CustDOM"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CustDOB"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CustDOB"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CustOcc"
        Me.DataGridViewTextBoxColumn9.HeaderText = "CustOcc"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Center"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Center"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CustContact"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CustContact"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CustAdd"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CustAdd"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CustSname"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CustSname"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CustLname"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CustLname"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CustMname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CustMname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CustFname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CustFname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CustID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CustID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'btnPrevViewCust
        '
        Me.btnPrevViewCust.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrevViewCust.Location = New System.Drawing.Point(5, 381)
        Me.btnPrevViewCust.Name = "btnPrevViewCust"
        Me.btnPrevViewCust.Size = New System.Drawing.Size(75, 30)
        Me.btnPrevViewCust.TabIndex = 1
        Me.btnPrevViewCust.Text = "Preview"
        Me.btnPrevViewCust.UseVisualStyleBackColor = True
        '
        'btnNextViewCust
        '
        Me.btnNextViewCust.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNextViewCust.Location = New System.Drawing.Point(86, 381)
        Me.btnNextViewCust.Name = "btnNextViewCust"
        Me.btnNextViewCust.Size = New System.Drawing.Size(75, 30)
        Me.btnNextViewCust.TabIndex = 1
        Me.btnNextViewCust.Text = "Next"
        Me.btnNextViewCust.UseVisualStyleBackColor = True
        '
        'btnUpViewCust
        '
        Me.btnUpViewCust.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUpViewCust.Location = New System.Drawing.Point(167, 381)
        Me.btnUpViewCust.Name = "btnUpViewCust"
        Me.btnUpViewCust.Size = New System.Drawing.Size(75, 30)
        Me.btnUpViewCust.TabIndex = 1
        Me.btnUpViewCust.Text = "Up"
        Me.btnUpViewCust.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDown.Location = New System.Drawing.Point(248, 381)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(75, 30)
        Me.btnDown.TabIndex = 1
        Me.btnDown.Text = "Down"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnPrintRepCust
        '
        Me.btnPrintRepCust.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintRepCust.Location = New System.Drawing.Point(975, 381)
        Me.btnPrintRepCust.Name = "btnPrintRepCust"
        Me.btnPrintRepCust.Size = New System.Drawing.Size(75, 30)
        Me.btnPrintRepCust.TabIndex = 1
        Me.btnPrintRepCust.Text = "Print"
        Me.btnPrintRepCust.UseVisualStyleBackColor = True
        '
        'btnOpenCustAddForm
        '
        Me.btnOpenCustAddForm.Location = New System.Drawing.Point(5, 3)
        Me.btnOpenCustAddForm.Name = "btnOpenCustAddForm"
        Me.btnOpenCustAddForm.Size = New System.Drawing.Size(108, 30)
        Me.btnOpenCustAddForm.TabIndex = 1
        Me.btnOpenCustAddForm.Text = "New"
        Me.btnOpenCustAddForm.UseVisualStyleBackColor = True
        '
        'cboCenter
        '
        Me.cboCenter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCenter.FormattingEnabled = True
        Me.cboCenter.Items.AddRange(New Object() {"All", "Masalong", "Calabasa", "Pag-asa", "Malangcao-Basud", "Tigbinan", "Guisican", "Kabungahan", "Labo"})
        Me.cboCenter.Location = New System.Drawing.Point(240, 3)
        Me.cboCenter.Name = "cboCenter"
        Me.cboCenter.Size = New System.Drawing.Size(197, 28)
        Me.cboCenter.TabIndex = 2
        '
        'cboCustStatus
        '
        Me.cboCustStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCustStatus.FormattingEnabled = True
        Me.cboCustStatus.Items.AddRange(New Object() {"All", "Active", "Savers", "Past Due", "InActive"})
        Me.cboCustStatus.Location = New System.Drawing.Point(516, 3)
        Me.cboCustStatus.Name = "cboCustStatus"
        Me.cboCustStatus.Size = New System.Drawing.Size(197, 28)
        Me.cboCustStatus.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(177, 8)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 20)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Center"
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(453, 8)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 20)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Status"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.IconPictureBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Location = New System.Drawing.Point(748, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(302, 30)
        Me.Panel1.TabIndex = 4
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 5)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 20)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Search"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TextBox1.Location = New System.Drawing.Point(69, 1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 26)
        Me.TextBox1.TabIndex = 6
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.IconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 30
        Me.IconPictureBox2.Location = New System.Drawing.Point(270, 0)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(32, 30)
        Me.IconPictureBox2.TabIndex = 5
        Me.IconPictureBox2.TabStop = False
        '
        'tabCustHome
        '
        Me.tabCustHome.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabCustHome.Controls.Add(Me.TabPage4)
        Me.tabCustHome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCustHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCustHome.ItemSize = New System.Drawing.Size(75, 25)
        Me.tabCustHome.Location = New System.Drawing.Point(0, 0)
        Me.tabCustHome.Multiline = True
        Me.tabCustHome.Name = "tabCustHome"
        Me.tabCustHome.SelectedIndex = 0
        Me.tabCustHome.Size = New System.Drawing.Size(1069, 461)
        Me.tabCustHome.TabIndex = 1
        '
        'frmCustomer
        '
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1069, 461)
        Me.Controls.Add(Me.tabCustHome)
        Me.Name = "frmCustomer"
        Me.Text = "Customers"
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewMalayan1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.pnlCustTab.ResumeLayout(False)
        Me.pnlCustTab.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCustHome.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CustIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustFnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustMnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustLnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustSnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustAddDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CenterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustOccDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustDOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustDOMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustSpouseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustBplaceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As NewMalayan1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblCustomersTableAdapter As NewMalayan1DataSetTableAdapters.tblCustomersTableAdapter
    Friend WithEvents NewMalayan1DataSet As NewMalayan1DataSet
    Friend WithEvents TblCustomersBindingSource As BindingSource
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents pnlCustTab As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label17 As Label
    Private WithEvents cboCustStatus As ComboBox
    Private WithEvents cboCenter As ComboBox
    Private WithEvents btnOpenCustAddForm As Button
    Friend WithEvents btnPrintRepCust As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents btnUpViewCust As Button
    Friend WithEvents btnNextViewCust As Button
    Friend WithEvents btnPrevViewCust As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents CustStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tabCustHome As TabControl
End Class
