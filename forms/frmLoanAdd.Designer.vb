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
        Me.btnLoanAdd = New System.Windows.Forms.Button()
        Me.txtProcFee = New System.Windows.Forms.TextBox()
        Me.txtCycleNo = New System.Windows.Forms.TextBox()
        Me.txtInterest = New System.Windows.Forms.TextBox()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.txtDateRel = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1022, 501)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLoanAdd)
        Me.GroupBox1.Controls.Add(Me.txtProcFee)
        Me.GroupBox1.Controls.Add(Me.txtCycleNo)
        Me.GroupBox1.Controls.Add(Me.txtInterest)
        Me.GroupBox1.Controls.Add(Me.txtPrincipal)
        Me.GroupBox1.Controls.Add(Me.txtDateRel)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Label7)
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
        Me.GroupBox1.Size = New System.Drawing.Size(998, 477)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnLoanAdd
        '
        Me.btnLoanAdd.Location = New System.Drawing.Point(193, 421)
        Me.btnLoanAdd.Name = "btnLoanAdd"
        Me.btnLoanAdd.Size = New System.Drawing.Size(159, 47)
        Me.btnLoanAdd.TabIndex = 8
        Me.btnLoanAdd.Text = "Submit"
        Me.btnLoanAdd.UseVisualStyleBackColor = True
        '
        'txtProcFee
        '
        Me.txtProcFee.Location = New System.Drawing.Point(193, 210)
        Me.txtProcFee.Name = "txtProcFee"
        Me.txtProcFee.Size = New System.Drawing.Size(159, 31)
        Me.txtProcFee.TabIndex = 4
        '
        'txtCycleNo
        '
        Me.txtCycleNo.Location = New System.Drawing.Point(193, 335)
        Me.txtCycleNo.Name = "txtCycleNo"
        Me.txtCycleNo.Size = New System.Drawing.Size(159, 31)
        Me.txtCycleNo.TabIndex = 7
        '
        'txtInterest
        '
        Me.txtInterest.Location = New System.Drawing.Point(193, 167)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(159, 31)
        Me.txtInterest.TabIndex = 3
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(193, 121)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(159, 31)
        Me.txtPrincipal.TabIndex = 2
        '
        'txtDateRel
        '
        Me.txtDateRel.Location = New System.Drawing.Point(193, 78)
        Me.txtDateRel.Name = "txtDateRel"
        Me.txtDateRel.Size = New System.Drawing.Size(159, 31)
        Me.txtDateRel.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView1)
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
        Me.Panel2.Location = New System.Drawing.Point(369, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(629, 438)
        Me.Panel2.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 144)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(594, 291)
        Me.DataGridView1.TabIndex = 2
        '
        'lblDateRel
        '
        Me.lblDateRel.AutoSize = True
        Me.lblDateRel.Location = New System.Drawing.Point(496, 8)
        Me.lblDateRel.Name = "lblDateRel"
        Me.lblDateRel.Size = New System.Drawing.Size(89, 25)
        Me.lblDateRel.TabIndex = 1
        Me.lblDateRel.Text = "DateRel"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(404, 8)
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
        Me.lblMaturity.Location = New System.Drawing.Point(502, 35)
        Me.lblMaturity.Name = "lblMaturity"
        Me.lblMaturity.Size = New System.Drawing.Size(89, 25)
        Me.lblMaturity.TabIndex = 1
        Me.lblMaturity.Text = "Maturity"
        '
        'lblCycle
        '
        Me.lblCycle.AutoSize = True
        Me.lblCycle.Location = New System.Drawing.Point(502, 116)
        Me.lblCycle.Name = "lblCycle"
        Me.lblCycle.Size = New System.Drawing.Size(66, 25)
        Me.lblCycle.TabIndex = 1
        Me.lblCycle.Text = "Cycle"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(502, 89)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(60, 25)
        Me.lblType.TabIndex = 1
        Me.lblType.Text = "Type"
        '
        'lblInteresst
        '
        Me.lblInteresst.AutoSize = True
        Me.lblInteresst.Location = New System.Drawing.Point(502, 62)
        Me.lblInteresst.Name = "lblInteresst"
        Me.lblInteresst.Size = New System.Drawing.Size(83, 25)
        Me.lblInteresst.TabIndex = 1
        Me.lblInteresst.Text = "Interest"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(404, 116)
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
        Me.Label13.Location = New System.Drawing.Point(404, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 25)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Type"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(404, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 25)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Maturity"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(404, 62)
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
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 25)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Loan Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Terms"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 338)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 25)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Cycle No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Proc Fee"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Interest(monthly)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Principal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date Release"
        '
        'cboLoanType
        '
        Me.cboLoanType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLoanType.FormattingEnabled = True
        Me.cboLoanType.Items.AddRange(New Object() {"Personal Loan", "Business Loan"})
        Me.cboLoanType.Location = New System.Drawing.Point(193, 296)
        Me.cboLoanType.Name = "cboLoanType"
        Me.cboLoanType.Size = New System.Drawing.Size(159, 33)
        Me.cboLoanType.TabIndex = 6
        '
        'cboTerms
        '
        Me.cboTerms.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTerms.FormattingEnabled = True
        Me.cboTerms.Items.AddRange(New Object() {"25", "16"})
        Me.cboTerms.Location = New System.Drawing.Point(193, 253)
        Me.cboTerms.Name = "cboTerms"
        Me.cboTerms.Size = New System.Drawing.Size(159, 33)
        Me.cboTerms.TabIndex = 5
        '
        'cboCustName
        '
        Me.cboCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCustName.FormattingEnabled = True
        Me.cboCustName.Location = New System.Drawing.Point(193, 30)
        Me.cboCustName.Name = "cboCustName"
        Me.cboCustName.Size = New System.Drawing.Size(159, 33)
        Me.cboCustName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer Name"
        '
        'frmLoanAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 501)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmLoanAdd"
        Me.Text = "Loan Cycle"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
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
End Class
