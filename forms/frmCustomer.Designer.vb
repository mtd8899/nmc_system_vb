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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tabCustHome = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnNewCust = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCustSpouse = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.lblCustSpouse = New System.Windows.Forms.Label()
        Me.btnCustAdd = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCustSuffName = New System.Windows.Forms.TextBox()
        Me.txtCustOcc = New System.Windows.Forms.TextBox()
        Me.txtCustProvince = New System.Windows.Forms.TextBox()
        Me.txtCustCenter = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCustBrgy = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCustNoHome = New System.Windows.Forms.TextBox()
        Me.txtCustDOB = New System.Windows.Forms.TextBox()
        Me.txtCustFirstName = New System.Windows.Forms.TextBox()
        Me.txtCustStreet = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblFisrtname = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCustMun = New System.Windows.Forms.TextBox()
        Me.txtCustNoWork = New System.Windows.Forms.TextBox()
        Me.txtCustBplace = New System.Windows.Forms.TextBox()
        Me.txtCustMiddleName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txDOM = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCustNoSpouse = New System.Windows.Forms.TextBox()
        Me.txtCustDOM = New System.Windows.Forms.TextBox()
        Me.txtCustLastName = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.pnlCustTab = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboCustStatus = New System.Windows.Forms.ComboBox()
        Me.cboCenter = New System.Windows.Forms.ComboBox()
        Me.btnOpenCustAddForm = New System.Windows.Forms.Button()
        Me.btnPrintRepCust = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUpViewCust = New System.Windows.Forms.Button()
        Me.btnNextViewCust = New System.Windows.Forms.Button()
        Me.btnPrevViewCust = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TableAdapterManager = New nmc_system_vb.NewMalayan1DataSetTableAdapters.TableAdapterManager()
        Me.NewMalayan1DataSet = New nmc_system_vb.NewMalayan1DataSet()
        Me.TblCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCustomersTableAdapter = New nmc_system_vb.NewMalayan1DataSetTableAdapters.tblCustomersTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCustHome.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.pnlCustTab.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewMalayan1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1045, 275)
        Me.DataGridView1.TabIndex = 0
        '
        'tabCustHome
        '
        Me.tabCustHome.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabCustHome.Controls.Add(Me.TabPage1)
        Me.tabCustHome.Controls.Add(Me.TabPage2)
        Me.tabCustHome.Controls.Add(Me.TabPage3)
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
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnNewCust)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1061, 428)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnNewCust
        '
        Me.btnNewCust.Location = New System.Drawing.Point(30, 22)
        Me.btnNewCust.Name = "btnNewCust"
        Me.btnNewCust.Size = New System.Drawing.Size(130, 38)
        Me.btnNewCust.TabIndex = 1
        Me.btnNewCust.Text = "New"
        Me.btnNewCust.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(509, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 38)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1061, 428)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.txtCustSpouse)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtCustID)
        Me.GroupBox1.Controls.Add(Me.lblCustSpouse)
        Me.GroupBox1.Controls.Add(Me.btnCustAdd)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCustSuffName)
        Me.GroupBox1.Controls.Add(Me.txtCustOcc)
        Me.GroupBox1.Controls.Add(Me.txtCustProvince)
        Me.GroupBox1.Controls.Add(Me.txtCustCenter)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCustBrgy)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCustNoHome)
        Me.GroupBox1.Controls.Add(Me.txtCustDOB)
        Me.GroupBox1.Controls.Add(Me.txtCustFirstName)
        Me.GroupBox1.Controls.Add(Me.txtCustStreet)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.lblFisrtname)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCustMun)
        Me.GroupBox1.Controls.Add(Me.txtCustNoWork)
        Me.GroupBox1.Controls.Add(Me.txtCustBplace)
        Me.GroupBox1.Controls.Add(Me.txtCustMiddleName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txDOM)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCustNoSpouse)
        Me.GroupBox1.Controls.Add(Me.txtCustDOM)
        Me.GroupBox1.Controls.Add(Me.txtCustLastName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1043, 312)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Personal Data"
        '
        'txtCustSpouse
        '
        Me.txtCustSpouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustSpouse.Location = New System.Drawing.Point(543, 209)
        Me.txtCustSpouse.Name = "txtCustSpouse"
        Me.txtCustSpouse.Size = New System.Drawing.Size(176, 26)
        Me.txtCustSpouse.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(433, 213)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 20)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Spouse"
        '
        'txtCustID
        '
        Me.txtCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustID.Location = New System.Drawing.Point(213, 208)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(176, 26)
        Me.txtCustID.TabIndex = 23
        '
        'lblCustSpouse
        '
        Me.lblCustSpouse.AutoSize = True
        Me.lblCustSpouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustSpouse.Location = New System.Drawing.Point(103, 212)
        Me.lblCustSpouse.Name = "lblCustSpouse"
        Me.lblCustSpouse.Size = New System.Drawing.Size(87, 20)
        Me.lblCustSpouse.TabIndex = 24
        Me.lblCustSpouse.Text = "Accout No."
        '
        'btnCustAdd
        '
        Me.btnCustAdd.Location = New System.Drawing.Point(769, 236)
        Me.btnCustAdd.Name = "btnCustAdd"
        Me.btnCustAdd.Size = New System.Drawing.Size(117, 35)
        Me.btnCustAdd.TabIndex = 22
        Me.btnCustAdd.Text = "Add"
        Me.btnCustAdd.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(14, 126)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 20)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Contact:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 20)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Customer:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(893, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 20)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Suffix"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Province"
        '
        'txtCustSuffName
        '
        Me.txtCustSuffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustSuffName.Location = New System.Drawing.Point(892, 29)
        Me.txtCustSuffName.Name = "txtCustSuffName"
        Me.txtCustSuffName.Size = New System.Drawing.Size(50, 26)
        Me.txtCustSuffName.TabIndex = 3
        '
        'txtCustOcc
        '
        Me.txtCustOcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustOcc.Location = New System.Drawing.Point(494, 92)
        Me.txtCustOcc.Name = "txtCustOcc"
        Me.txtCustOcc.Size = New System.Drawing.Size(162, 26)
        Me.txtCustOcc.TabIndex = 8
        '
        'txtCustProvince
        '
        Me.txtCustProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustProvince.Location = New System.Drawing.Point(178, 92)
        Me.txtCustProvince.Name = "txtCustProvince"
        Me.txtCustProvince.Size = New System.Drawing.Size(212, 26)
        Me.txtCustProvince.TabIndex = 7
        '
        'txtCustCenter
        '
        Me.txtCustCenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustCenter.Location = New System.Drawing.Point(750, 92)
        Me.txtCustCenter.Name = "txtCustCenter"
        Me.txtCustCenter.Size = New System.Drawing.Size(136, 26)
        Me.txtCustCenter.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(662, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Center"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(395, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Occupation"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(103, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Street/Purok/Sitio"
        '
        'txtCustBrgy
        '
        Me.txtCustBrgy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustBrgy.Location = New System.Drawing.Point(494, 60)
        Me.txtCustBrgy.Name = "txtCustBrgy"
        Me.txtCustBrgy.Size = New System.Drawing.Size(162, 26)
        Me.txtCustBrgy.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Address:"
        '
        'txtCustNoHome
        '
        Me.txtCustNoHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustNoHome.Location = New System.Drawing.Point(161, 124)
        Me.txtCustNoHome.Name = "txtCustNoHome"
        Me.txtCustNoHome.Size = New System.Drawing.Size(228, 26)
        Me.txtCustNoHome.TabIndex = 10
        '
        'txtCustDOB
        '
        Me.txtCustDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustDOB.Location = New System.Drawing.Point(213, 155)
        Me.txtCustDOB.Name = "txtCustDOB"
        Me.txtCustDOB.Size = New System.Drawing.Size(176, 26)
        Me.txtCustDOB.TabIndex = 13
        '
        'txtCustFirstName
        '
        Me.txtCustFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustFirstName.Location = New System.Drawing.Point(213, 28)
        Me.txtCustFirstName.Name = "txtCustFirstName"
        Me.txtCustFirstName.Size = New System.Drawing.Size(176, 26)
        Me.txtCustFirstName.TabIndex = 0
        '
        'txtCustStreet
        '
        Me.txtCustStreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustStreet.Location = New System.Drawing.Point(240, 60)
        Me.txtCustStreet.Name = "txtCustStreet"
        Me.txtCustStreet.Size = New System.Drawing.Size(150, 26)
        Me.txtCustStreet.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(103, 127)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 20)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Home"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(103, 159)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(99, 20)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Date of Birth"
        '
        'lblFisrtname
        '
        Me.lblFisrtname.AutoSize = True
        Me.lblFisrtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFisrtname.Location = New System.Drawing.Point(103, 32)
        Me.lblFisrtname.Name = "lblFisrtname"
        Me.lblFisrtname.Size = New System.Drawing.Size(84, 20)
        Me.lblFisrtname.TabIndex = 1
        Me.lblFisrtname.Text = "First name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(395, 130)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 20)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Work"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(395, 162)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 20)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Birthplace"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(395, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Middle name"
        '
        'txtCustMun
        '
        Me.txtCustMun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustMun.Location = New System.Drawing.Point(750, 60)
        Me.txtCustMun.Name = "txtCustMun"
        Me.txtCustMun.Size = New System.Drawing.Size(136, 26)
        Me.txtCustMun.TabIndex = 6
        '
        'txtCustNoWork
        '
        Me.txtCustNoWork.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustNoWork.Location = New System.Drawing.Point(494, 124)
        Me.txtCustNoWork.Name = "txtCustNoWork"
        Me.txtCustNoWork.Size = New System.Drawing.Size(162, 26)
        Me.txtCustNoWork.TabIndex = 11
        '
        'txtCustBplace
        '
        Me.txtCustBplace.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustBplace.Location = New System.Drawing.Point(494, 162)
        Me.txtCustBplace.Name = "txtCustBplace"
        Me.txtCustBplace.Size = New System.Drawing.Size(162, 26)
        Me.txtCustBplace.TabIndex = 14
        '
        'txtCustMiddleName
        '
        Me.txtCustMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustMiddleName.Location = New System.Drawing.Point(494, 29)
        Me.txtCustMiddleName.Name = "txtCustMiddleName"
        Me.txtCustMiddleName.Size = New System.Drawing.Size(162, 26)
        Me.txtCustMiddleName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(662, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Municipal"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(662, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 20)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Spouse"
        '
        'txDOM
        '
        Me.txDOM.AutoSize = True
        Me.txDOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txDOM.Location = New System.Drawing.Point(662, 162)
        Me.txDOM.Name = "txDOM"
        Me.txDOM.Size = New System.Drawing.Size(46, 20)
        Me.txDOM.TabIndex = 9
        Me.txDOM.Text = "DOM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(662, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Last name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(395, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Barangay"
        '
        'txtCustNoSpouse
        '
        Me.txtCustNoSpouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustNoSpouse.Location = New System.Drawing.Point(750, 124)
        Me.txtCustNoSpouse.Name = "txtCustNoSpouse"
        Me.txtCustNoSpouse.Size = New System.Drawing.Size(136, 26)
        Me.txtCustNoSpouse.TabIndex = 12
        '
        'txtCustDOM
        '
        Me.txtCustDOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustDOM.Location = New System.Drawing.Point(750, 156)
        Me.txtCustDOM.Name = "txtCustDOM"
        Me.txtCustDOM.Size = New System.Drawing.Size(136, 26)
        Me.txtCustDOM.TabIndex = 15
        '
        'txtCustLastName
        '
        Me.txtCustLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustLastName.Location = New System.Drawing.Point(750, 29)
        Me.txtCustLastName.Name = "txtCustLastName"
        Me.txtCustLastName.Size = New System.Drawing.Size(136, 26)
        Me.txtCustLastName.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1061, 428)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
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
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TextBox1.Location = New System.Drawing.Point(69, 1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 26)
        Me.TextBox1.TabIndex = 6
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
        'btnOpenCustAddForm
        '
        Me.btnOpenCustAddForm.Location = New System.Drawing.Point(5, 3)
        Me.btnOpenCustAddForm.Name = "btnOpenCustAddForm"
        Me.btnOpenCustAddForm.Size = New System.Drawing.Size(108, 30)
        Me.btnOpenCustAddForm.TabIndex = 1
        Me.btnOpenCustAddForm.Text = "New"
        Me.btnOpenCustAddForm.UseVisualStyleBackColor = True
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
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(5, 39)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1045, 330)
        Me.DataGridView2.TabIndex = 0
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
        'NewMalayan1DataSet
        '
        Me.NewMalayan1DataSet.DataSetName = "NewMalayan1DataSet"
        Me.NewMalayan1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCustomersBindingSource
        '
        Me.TblCustomersBindingSource.DataMember = "tblCustomers"
        Me.TblCustomersBindingSource.DataSource = Me.NewMalayan1DataSet
        '
        'TblCustomersTableAdapter
        '
        Me.TblCustomersTableAdapter.ClearBeforeFill = True
        '
        'frmCustomer
        '
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1069, 461)
        Me.Controls.Add(Me.tabCustHome)
        Me.Name = "frmCustomer"
        Me.Text = "Customers"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCustHome.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.pnlCustTab.ResumeLayout(False)
        Me.pnlCustTab.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewMalayan1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tabCustHome As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCustAdd As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCustSuffName As TextBox
    Friend WithEvents txtCustOcc As TextBox
    Friend WithEvents txtCustProvince As TextBox
    Friend WithEvents txtCustCenter As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCustBrgy As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCustNoHome As TextBox
    Friend WithEvents txtCustDOB As TextBox
    Friend WithEvents txtCustFirstName As TextBox
    Friend WithEvents txtCustStreet As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblFisrtname As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCustMun As TextBox
    Friend WithEvents txtCustNoWork As TextBox
    Friend WithEvents txtCustBplace As TextBox
    Friend WithEvents txtCustMiddleName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txDOM As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCustNoSpouse As TextBox
    Friend WithEvents txtCustDOM As TextBox
    Friend WithEvents txtCustLastName As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents lblCustSpouse As Label
    Friend WithEvents txtCustSpouse As TextBox
    Friend WithEvents Label15 As Label
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
    Friend WithEvents btnNewCust As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pnlCustTab As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label17 As Label
    Private WithEvents cboCustStatus As ComboBox
    Private WithEvents cboCenter As ComboBox
    Friend WithEvents btnDown As Button
    Friend WithEvents btnUpViewCust As Button
    Friend WithEvents btnNextViewCust As Button
    Friend WithEvents btnPrevViewCust As Button
    Private WithEvents btnOpenCustAddForm As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnPrintRepCust As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TableAdapterManager As NewMalayan1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblCustomersTableAdapter As NewMalayan1DataSetTableAdapters.tblCustomersTableAdapter
    Friend WithEvents NewMalayan1DataSet As NewMalayan1DataSet
    Friend WithEvents TblCustomersBindingSource As BindingSource
End Class
