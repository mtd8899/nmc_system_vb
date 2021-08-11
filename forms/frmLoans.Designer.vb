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
        Me.tabLoans = New System.Windows.Forms.TabControl()
        Me.tabViewLoans = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tabAddLoan = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.tabLoans.SuspendLayout()
        Me.tabViewLoans.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAddLoan.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabLoans As TabControl
    Friend WithEvents tabViewLoans As TabPage
    Friend WithEvents tabAddLoan As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
End Class
