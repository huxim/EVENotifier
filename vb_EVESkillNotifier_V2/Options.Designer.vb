<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.txtXML = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.chkGCal = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtadvance = New System.Windows.Forms.TextBox
        Me.cmdTest = New System.Windows.Forms.Button
        Me.rdoCustom = New System.Windows.Forms.RadioButton
        Me.rdoDefault = New System.Windows.Forms.RadioButton
        Me.cmdBrowse = New System.Windows.Forms.Button
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.chksound = New System.Windows.Forms.CheckBox
        Me.chkmsgbox = New System.Windows.Forms.CheckBox
        Me.chkballoon = New System.Windows.Forms.CheckBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdApply = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.chkMinimize = New System.Windows.Forms.CheckBox
        Me.chkAutorun = New System.Windows.Forms.CheckBox
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtGAd = New System.Windows.Forms.NumericUpDown
        Me.Label7 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.txtGAd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtXML
        '
        Me.txtXML.Location = New System.Drawing.Point(355, 104)
        Me.txtXML.Name = "txtXML"
        Me.txtXML.Size = New System.Drawing.Size(171, 20)
        Me.txtXML.TabIndex = 22
        Me.txtXML.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(293, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 12)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "日历地址:"
        Me.Label6.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(192, 19)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(58, 12)
        Me.LinkLabel1.TabIndex = 20
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "如何使用?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(204, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 12)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "@gmail.com"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 12)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "密码:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 12)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "用户名:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(98, 85)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 16
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(98, 52)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(100, 20)
        Me.txtUserName.TabIndex = 15
        '
        'chkGCal
        '
        Me.chkGCal.AutoSize = True
        Me.chkGCal.Location = New System.Drawing.Point(15, 18)
        Me.chkGCal.Name = "chkGCal"
        Me.chkGCal.Size = New System.Drawing.Size(150, 16)
        Me.chkGCal.TabIndex = 14
        Me.chkGCal.Text = "设置Google日历提醒(&G)"
        Me.chkGCal.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(145, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "分钟提醒我"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "在事件到期前"
        '
        'txtadvance
        '
        Me.txtadvance.Location = New System.Drawing.Point(100, 160)
        Me.txtadvance.MaxLength = 2
        Me.txtadvance.Name = "txtadvance"
        Me.txtadvance.Size = New System.Drawing.Size(39, 20)
        Me.txtadvance.TabIndex = 11
        Me.txtadvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdTest
        '
        Me.cmdTest.Location = New System.Drawing.Point(213, 126)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(74, 23)
        Me.cmdTest.TabIndex = 9
        Me.cmdTest.Text = "测试(&E)"
        Me.cmdTest.UseVisualStyleBackColor = True
        '
        'rdoCustom
        '
        Me.rdoCustom.AutoSize = True
        Me.rdoCustom.Location = New System.Drawing.Point(40, 104)
        Me.rdoCustom.Name = "rdoCustom"
        Me.rdoCustom.Size = New System.Drawing.Size(110, 16)
        Me.rdoCustom.TabIndex = 8
        Me.rdoCustom.TabStop = True
        Me.rdoCustom.Text = "自定义提示音(&C)"
        Me.rdoCustom.UseVisualStyleBackColor = True
        '
        'rdoDefault
        '
        Me.rdoDefault.AutoSize = True
        Me.rdoDefault.Location = New System.Drawing.Point(40, 82)
        Me.rdoDefault.Name = "rdoDefault"
        Me.rdoDefault.Size = New System.Drawing.Size(99, 16)
        Me.rdoDefault.TabIndex = 7
        Me.rdoDefault.TabStop = True
        Me.rdoDefault.Text = "默认提示音(&D)"
        Me.rdoDefault.UseVisualStyleBackColor = True
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(293, 126)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(75, 23)
        Me.cmdBrowse.TabIndex = 4
        Me.cmdBrowse.Text = "浏览(&B)..."
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(57, 126)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(150, 20)
        Me.txtPath.TabIndex = 3
        '
        'chksound
        '
        Me.chksound.AutoSize = True
        Me.chksound.Location = New System.Drawing.Point(18, 60)
        Me.chksound.Name = "chksound"
        Me.chksound.Size = New System.Drawing.Size(86, 16)
        Me.chksound.TabIndex = 2
        Me.chksound.Text = "声音提示(&S)"
        Me.chksound.UseVisualStyleBackColor = True
        '
        'chkmsgbox
        '
        Me.chkmsgbox.AutoSize = True
        Me.chkmsgbox.Location = New System.Drawing.Point(18, 38)
        Me.chkmsgbox.Name = "chkmsgbox"
        Me.chkmsgbox.Size = New System.Drawing.Size(111, 16)
        Me.chkmsgbox.TabIndex = 1
        Me.chkmsgbox.Text = "弹出窗口提示(&O)"
        Me.chkmsgbox.UseVisualStyleBackColor = True
        '
        'chkballoon
        '
        Me.chkballoon.AutoSize = True
        Me.chkballoon.Location = New System.Drawing.Point(18, 16)
        Me.chkballoon.Name = "chkballoon"
        Me.chkballoon.Size = New System.Drawing.Size(86, 16)
        Me.chkballoon.TabIndex = 0
        Me.chkballoon.Text = "气球提示(&T)"
        Me.chkballoon.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdOk, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdCancel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdApply, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(183, 254)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(218, 27)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(3, 3)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(66, 21)
        Me.cmdOk.TabIndex = 0
        Me.cmdOk.Text = "确定"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(75, 3)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(66, 21)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "取消"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdApply
        '
        Me.cmdApply.Enabled = False
        Me.cmdApply.Location = New System.Drawing.Point(147, 3)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(68, 21)
        Me.cmdApply.TabIndex = 2
        Me.cmdApply.Text = "应用(&A)"
        Me.cmdApply.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "波形文件 (*.wav)|*.wav|所有文件 (*.*)|*.*"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(390, 222)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.chkMinimize)
        Me.TabPage3.Controls.Add(Me.chkAutorun)
        Me.TabPage3.Location = New System.Drawing.Point(4, 21)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(382, 197)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "常规"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'chkMinimize
        '
        Me.chkMinimize.AutoSize = True
        Me.chkMinimize.Location = New System.Drawing.Point(24, 92)
        Me.chkMinimize.Name = "chkMinimize"
        Me.chkMinimize.Size = New System.Drawing.Size(114, 16)
        Me.chkMinimize.TabIndex = 1
        Me.chkMinimize.Text = "启动后最小化(&M)"
        Me.chkMinimize.UseVisualStyleBackColor = True
        '
        'chkAutorun
        '
        Me.chkAutorun.AutoSize = True
        Me.chkAutorun.Location = New System.Drawing.Point(24, 42)
        Me.chkAutorun.Name = "chkAutorun"
        Me.chkAutorun.Size = New System.Drawing.Size(110, 16)
        Me.chkAutorun.TabIndex = 0
        Me.chkAutorun.Text = "伴随系统启动(&S)"
        Me.chkAutorun.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chkmsgbox)
        Me.TabPage1.Controls.Add(Me.chkballoon)
        Me.TabPage1.Controls.Add(Me.chksound)
        Me.TabPage1.Controls.Add(Me.txtPath)
        Me.TabPage1.Controls.Add(Me.cmdBrowse)
        Me.TabPage1.Controls.Add(Me.rdoDefault)
        Me.TabPage1.Controls.Add(Me.rdoCustom)
        Me.TabPage1.Controls.Add(Me.cmdTest)
        Me.TabPage1.Controls.Add(Me.txtadvance)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 21)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(382, 197)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "基本"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtGAd)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtXML)
        Me.TabPage2.Controls.Add(Me.chkGCal)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtUserName)
        Me.TabPage2.Controls.Add(Me.LinkLabel1)
        Me.TabPage2.Controls.Add(Me.txtPassword)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 21)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(382, 197)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "扩展"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(240, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 12)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "分钟"
        '
        'txtGAd
        '
        Me.txtGAd.Location = New System.Drawing.Point(190, 123)
        Me.txtGAd.Name = "txtGAd"
        Me.txtGAd.Size = New System.Drawing.Size(44, 20)
        Me.txtGAd.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 12)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "设置Google日历提醒器时间:"
        '
        'Options
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(413, 293)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Options"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "设置"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.txtGAd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkmsgbox As System.Windows.Forms.CheckBox
    Friend WithEvents chkballoon As System.Windows.Forms.CheckBox
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents chksound As System.Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdApply As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents rdoCustom As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDefault As System.Windows.Forms.RadioButton
    Friend WithEvents cmdTest As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtadvance As System.Windows.Forms.TextBox
    Friend WithEvents chkGCal As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtXML As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtGAd As System.Windows.Forms.NumericUpDown
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents chkMinimize As System.Windows.Forms.CheckBox
    Friend WithEvents chkAutorun As System.Windows.Forms.CheckBox
End Class
