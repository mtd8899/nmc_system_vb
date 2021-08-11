<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustAdd
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpCustPerInfo = New System.Windows.Forms.GroupBox()
        Me.cboCenter = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCustOcc = New System.Windows.Forms.TextBox()
        Me.lblCustStatus = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCustSpouse = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.picCustSign = New System.Windows.Forms.PictureBox()
        Me.picCustPic = New System.Windows.Forms.PictureBox()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.lblCustSpouse = New System.Windows.Forms.Label()
        Me.btnCustAdd = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCustSuffName = New System.Windows.Forms.TextBox()
        Me.txtCustContact2 = New System.Windows.Forms.TextBox()
        Me.txtCustStatus = New System.Windows.Forms.TextBox()
        Me.txtCustProvince = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCustBrgy = New System.Windows.Forms.TextBox()
        Me.txtCustNoHome = New System.Windows.Forms.TextBox()
        Me.txtCustDOB = New System.Windows.Forms.TextBox()
        Me.txtCustFirstName = New System.Windows.Forms.TextBox()
        Me.txtCustStreet = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblFisrtname = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCustMun = New System.Windows.Forms.TextBox()
        Me.txtCustNoSpouse = New System.Windows.Forms.TextBox()
        Me.txtCustBplace = New System.Windows.Forms.TextBox()
        Me.txtCustMiddleName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txDOM = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCustDOM = New System.Windows.Forms.TextBox()
        Me.txtCustLastName = New System.Windows.Forms.TextBox()
        Me.NewMalayan1DataSet = New nmc_system_vb.NewMalayan1DataSet()
        Me.TblCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCustomersTableAdapter = New nmc_system_vb.NewMalayan1DataSetTableAdapters.tblCustomersTableAdapter()
        Me.TableAdapterManager = New nmc_system_vb.NewMalayan1DataSetTableAdapters.TableAdapterManager()
        Me.Panel1.SuspendLayout()
        Me.grpCustPerInfo.SuspendLayout()
        CType(Me.picCustSign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCustPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewMalayan1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grpCustPerInfo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1044, 461)
        Me.Panel1.TabIndex = 0
        '
        'grpCustPerInfo
        '
        Me.grpCustPerInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCustPerInfo.Controls.Add(Me.cboCenter)
        Me.grpCustPerInfo.Controls.Add(Me.Label10)
        Me.grpCustPerInfo.Controls.Add(Me.txtCustOcc)
        Me.grpCustPerInfo.Controls.Add(Me.lblCustStatus)
        Me.grpCustPerInfo.Controls.Add(Me.Label8)
        Me.grpCustPerInfo.Controls.Add(Me.txtCustSpouse)
        Me.grpCustPerInfo.Controls.Add(Me.Label20)
        Me.grpCustPerInfo.Controls.Add(Me.picCustSign)
        Me.grpCustPerInfo.Controls.Add(Me.picCustPic)
        Me.grpCustPerInfo.Controls.Add(Me.txtCustID)
        Me.grpCustPerInfo.Controls.Add(Me.lblCustSpouse)
        Me.grpCustPerInfo.Controls.Add(Me.btnCustAdd)
        Me.grpCustPerInfo.Controls.Add(Me.Label11)
        Me.grpCustPerInfo.Controls.Add(Me.Label1)
        Me.grpCustPerInfo.Controls.Add(Me.txtCustSuffName)
        Me.grpCustPerInfo.Controls.Add(Me.txtCustContact2)
        Me.grpCustPerInfo.Controls.Add(Me.txtCustStatus)
        Me.grpCustPerInfo.Controls.Add(Me.txtCustProvince)
        Me.grpCustPerInfo.Controls.Add(Me.Label7)
        Me.grpCustPerInfo.Controls.Add(Me.txtCustBrgy)
        Me.grpCustPerInfo.Controls.Add(Me.txtCustNoHome)
        Me.grpCustPerInfo.Controls.Add(Me.txtCustDOB)
        Me.grpCustPerInfo.Controls.Add(Me.txtCustFirstName)
        Me.grpCustPerInfo.Controls.Add(Me.txtCustStreet)
        Me.grpCustPerInfo.Controls.Add(Me.Label6)
        Me.grpCustPerInfo.Controls.Add(Me.Label9)
        Me.grpCustPerInfo.Controls.Add(Me.Label14)
        Me.grpCustPerInfo.Controls.Add(Me.Label19)
        Me.grpCustPerInfo.Controls.Add(Me.lblFisrtname)
        Me.grpCustPerInfo.Controls.Add(Me.Label13)
        Me.grpCustPerInfo.Controls.Add(Me.Label18)
        Me.grpCustPerInfo.Controls.Add(Me.Label5)
        Me.grpCustPerInfo.Controls.Add(Me.txtCustMun)
        Me.grpCustPerInfo.Controls.Add(Me.txtCustNoSpouse)
        Me.grpCustPerInfo.Controls.Add(Me.txtCustBplace)
        Me.grpCustPerInfo.Controls.Add(Me.txtCustMiddleName)
        Me.grpCustPerInfo.Controls.Add(Me.Label2)
        Me.grpCustPerInfo.Controls.Add(Me.txDOM)
        Me.grpCustPerInfo.Controls.Add(Me.Label4)
        Me.grpCustPerInfo.Controls.Add(Me.Label3)
        Me.grpCustPerInfo.Controls.Add(Me.txtCustDOM)
        Me.grpCustPerInfo.Controls.Add(Me.txtCustLastName)
        Me.grpCustPerInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCustPerInfo.Location = New System.Drawing.Point(13, 12)
        Me.grpCustPerInfo.Name = "grpCustPerInfo"
        Me.grpCustPerInfo.Size = New System.Drawing.Size(1020, 426)
        Me.grpCustPerInfo.TabIndex = 0
        Me.grpCustPerInfo.TabStop = False
        Me.grpCustPerInfo.Text = "  Customer Personal Information"
        '
        'cboCenter
        '
        Me.cboCenter.FormattingEnabled = True
        Me.cboCenter.Items.AddRange(New Object() {"Pag-asa", "Tigbinan", "Guisican", "Kabungahan", "Other"})
        Me.cboCenter.Location = New System.Drawing.Point(527, 28)
        Me.cboCenter.Name = "cboCenter"
        Me.cboCenter.Size = New System.Drawing.Size(121, 28)
        Me.cboCenter.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 221)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 20)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Cust Occupation"
        '
        'txtCustOcc
        '
        Me.txtCustOcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustOcc.Location = New System.Drawing.Point(144, 218)
        Me.txtCustOcc.Name = "txtCustOcc"
        Me.txtCustOcc.Size = New System.Drawing.Size(218, 26)
        Me.txtCustOcc.TabIndex = 74
        '
        'lblCustStatus
        '
        Me.lblCustStatus.AutoSize = True
        Me.lblCustStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustStatus.Location = New System.Drawing.Point(651, 161)
        Me.lblCustStatus.Name = "lblCustStatus"
        Me.lblCustStatus.Size = New System.Drawing.Size(56, 20)
        Me.lblCustStatus.TabIndex = 73
        Me.lblCustStatus.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Spouse Name"
        '
        'txtCustSpouse
        '
        Me.txtCustSpouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustSpouse.Location = New System.Drawing.Point(121, 186)
        Me.txtCustSpouse.Name = "txtCustSpouse"
        Me.txtCustSpouse.Size = New System.Drawing.Size(468, 26)
        Me.txtCustSpouse.TabIndex = 16
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(442, 31)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 20)
        Me.Label20.TabIndex = 69
        Me.Label20.Text = "Center"
        '
        'picCustSign
        '
        Me.picCustSign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCustSign.Location = New System.Drawing.Point(863, 180)
        Me.picCustSign.Name = "picCustSign"
        Me.picCustSign.Size = New System.Drawing.Size(150, 60)
        Me.picCustSign.TabIndex = 68
        Me.picCustSign.TabStop = False
        '
        'picCustPic
        '
        Me.picCustPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCustPic.Location = New System.Drawing.Point(863, 25)
        Me.picCustPic.Name = "picCustPic"
        Me.picCustPic.Size = New System.Drawing.Size(150, 150)
        Me.picCustPic.TabIndex = 67
        Me.picCustPic.TabStop = False
        '
        'txtCustID
        '
        Me.txtCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustID.Location = New System.Drawing.Point(318, 28)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(121, 26)
        Me.txtCustID.TabIndex = 63
        '
        'lblCustSpouse
        '
        Me.lblCustSpouse.AutoSize = True
        Me.lblCustSpouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustSpouse.Location = New System.Drawing.Point(219, 31)
        Me.lblCustSpouse.Name = "lblCustSpouse"
        Me.lblCustSpouse.Size = New System.Drawing.Size(87, 20)
        Me.lblCustSpouse.TabIndex = 0
        Me.lblCustSpouse.Text = "Accout No."
        '
        'btnCustAdd
        '
        Me.btnCustAdd.Location = New System.Drawing.Point(655, 205)
        Me.btnCustAdd.Name = "btnCustAdd"
        Me.btnCustAdd.Size = New System.Drawing.Size(117, 35)
        Me.btnCustAdd.TabIndex = 17
        Me.btnCustAdd.Text = "Add"
        Me.btnCustAdd.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(654, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 20)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Suffix"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(654, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Province"
        '
        'txtCustSuffName
        '
        Me.txtCustSuffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustSuffName.Location = New System.Drawing.Point(729, 58)
        Me.txtCustSuffName.Name = "txtCustSuffName"
        Me.txtCustSuffName.Size = New System.Drawing.Size(128, 26)
        Me.txtCustSuffName.TabIndex = 5
        '
        'txtCustContact2
        '
        Me.txtCustContact2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustContact2.Location = New System.Drawing.Point(331, 122)
        Me.txtCustContact2.Name = "txtCustContact2"
        Me.txtCustContact2.Size = New System.Drawing.Size(108, 26)
        Me.txtCustContact2.TabIndex = 10
        '
        'txtCustStatus
        '
        Me.txtCustStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustStatus.Location = New System.Drawing.Point(729, 161)
        Me.txtCustStatus.Name = "txtCustStatus"
        Me.txtCustStatus.Size = New System.Drawing.Size(128, 26)
        Me.txtCustStatus.TabIndex = 8
        '
        'txtCustProvince
        '
        Me.txtCustProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustProvince.Location = New System.Drawing.Point(729, 90)
        Me.txtCustProvince.Name = "txtCustProvince"
        Me.txtCustProvince.Size = New System.Drawing.Size(128, 26)
        Me.txtCustProvince.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 20)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "St./Prk/Sitio"
        '
        'txtCustBrgy
        '
        Me.txtCustBrgy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustBrgy.Location = New System.Drawing.Point(318, 90)
        Me.txtCustBrgy.Name = "txtCustBrgy"
        Me.txtCustBrgy.Size = New System.Drawing.Size(121, 26)
        Me.txtCustBrgy.TabIndex = 7
        '
        'txtCustNoHome
        '
        Me.txtCustNoHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustNoHome.Location = New System.Drawing.Point(121, 119)
        Me.txtCustNoHome.Name = "txtCustNoHome"
        Me.txtCustNoHome.Size = New System.Drawing.Size(95, 26)
        Me.txtCustNoHome.TabIndex = 10
        '
        'txtCustDOB
        '
        Me.txtCustDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustDOB.Location = New System.Drawing.Point(121, 154)
        Me.txtCustDOB.Name = "txtCustDOB"
        Me.txtCustDOB.Size = New System.Drawing.Size(95, 26)
        Me.txtCustDOB.TabIndex = 12
        '
        'txtCustFirstName
        '
        Me.txtCustFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustFirstName.Location = New System.Drawing.Point(95, 58)
        Me.txtCustFirstName.Name = "txtCustFirstName"
        Me.txtCustFirstName.Size = New System.Drawing.Size(121, 26)
        Me.txtCustFirstName.TabIndex = 2
        '
        'txtCustStreet
        '
        Me.txtCustStreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustStreet.Location = New System.Drawing.Point(106, 90)
        Me.txtCustStreet.Name = "txtCustStreet"
        Me.txtCustStreet.Size = New System.Drawing.Size(110, 26)
        Me.txtCustStreet.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(219, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Contact No. 2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(220, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 20)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Age"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 20)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Contact No. 1"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(11, 158)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(99, 20)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Date of Birth"
        '
        'lblFisrtname
        '
        Me.lblFisrtname.AutoSize = True
        Me.lblFisrtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFisrtname.Location = New System.Drawing.Point(8, 61)
        Me.lblFisrtname.Name = "lblFisrtname"
        Me.lblFisrtname.Size = New System.Drawing.Size(84, 20)
        Me.lblFisrtname.TabIndex = 28
        Me.lblFisrtname.Text = "First name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(442, 125)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(163, 20)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Spouse's Contact No."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(301, 159)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 20)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Birthplace"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(219, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Middle name"
        '
        'txtCustMun
        '
        Me.txtCustMun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustMun.Location = New System.Drawing.Point(523, 90)
        Me.txtCustMun.Name = "txtCustMun"
        Me.txtCustMun.Size = New System.Drawing.Size(121, 26)
        Me.txtCustMun.TabIndex = 8
        '
        'txtCustNoSpouse
        '
        Me.txtCustNoSpouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustNoSpouse.Location = New System.Drawing.Point(611, 122)
        Me.txtCustNoSpouse.Name = "txtCustNoSpouse"
        Me.txtCustNoSpouse.Size = New System.Drawing.Size(246, 26)
        Me.txtCustNoSpouse.TabIndex = 11
        '
        'txtCustBplace
        '
        Me.txtCustBplace.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustBplace.Location = New System.Drawing.Point(385, 155)
        Me.txtCustBplace.Name = "txtCustBplace"
        Me.txtCustBplace.Size = New System.Drawing.Size(204, 26)
        Me.txtCustBplace.TabIndex = 14
        '
        'txtCustMiddleName
        '
        Me.txtCustMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustMiddleName.Location = New System.Drawing.Point(318, 58)
        Me.txtCustMiddleName.Name = "txtCustMiddleName"
        Me.txtCustMiddleName.Size = New System.Drawing.Size(121, 26)
        Me.txtCustMiddleName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(442, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Municipal"
        '
        'txDOM
        '
        Me.txDOM.AutoSize = True
        Me.txDOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txDOM.Location = New System.Drawing.Point(654, 31)
        Me.txDOM.Name = "txDOM"
        Me.txDOM.Size = New System.Drawing.Size(46, 20)
        Me.txDOM.TabIndex = 44
        Me.txDOM.Text = "DOM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(442, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Last name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(219, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Barangay"
        '
        'txtCustDOM
        '
        Me.txtCustDOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustDOM.Location = New System.Drawing.Point(729, 25)
        Me.txtCustDOM.Name = "txtCustDOM"
        Me.txtCustDOM.Size = New System.Drawing.Size(128, 26)
        Me.txtCustDOM.TabIndex = 2
        '
        'txtCustLastName
        '
        Me.txtCustLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustLastName.Location = New System.Drawing.Point(527, 58)
        Me.txtCustLastName.Name = "txtCustLastName"
        Me.txtCustLastName.Size = New System.Drawing.Size(121, 26)
        Me.txtCustLastName.TabIndex = 4
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
        'frmCustAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 461)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCustAdd"
        Me.Tag = "1"
        Me.Text = "ADD CUSTOMER FORM"
        Me.Panel1.ResumeLayout(False)
        Me.grpCustPerInfo.ResumeLayout(False)
        Me.grpCustPerInfo.PerformLayout()
        CType(Me.picCustSign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCustPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewMalayan1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents grpCustPerInfo As GroupBox
    Friend WithEvents picCustSign As PictureBox
    Friend WithEvents picCustPic As PictureBox
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents lblCustSpouse As Label
    Friend WithEvents btnCustAdd As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCustSuffName As TextBox
    Friend WithEvents txtCustContact2 As TextBox
    Friend WithEvents txtCustProvince As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCustBrgy As TextBox
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
    Friend WithEvents txtCustNoSpouse As TextBox
    Friend WithEvents txtCustBplace As TextBox
    Friend WithEvents txtCustMiddleName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txDOM As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCustDOM As TextBox
    Friend WithEvents txtCustLastName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCustSpouse As TextBox
    Friend WithEvents lblCustStatus As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCustOcc As TextBox
    Friend WithEvents txtCustNoHome As TextBox
    Friend WithEvents txtCustStatus As TextBox
    Friend WithEvents NewMalayan1DataSet As NewMalayan1DataSet
    Friend WithEvents TblCustomersBindingSource As BindingSource
    Friend WithEvents TblCustomersTableAdapter As NewMalayan1DataSetTableAdapters.tblCustomersTableAdapter
    Friend WithEvents TableAdapterManager As NewMalayan1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents cboCenter As ComboBox
End Class
