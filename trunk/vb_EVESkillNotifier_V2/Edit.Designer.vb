<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit
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
        Me.components = New System.ComponentModel.Container
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.nbrSec = New System.Windows.Forms.NumericUpDown
        Me.nbrMin = New System.Windows.Forms.NumericUpDown
        Me.nbrHour = New System.Windows.Forms.NumericUpDown
        Me.nbrDay = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNotiName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.rdbLeftTime = New System.Windows.Forms.RadioButton
        Me.rdbTime = New System.Windows.Forms.RadioButton
        Me.dtpTime = New System.Windows.Forms.DateTimePicker
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nbrSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nbrMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nbrHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nbrDay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(231, 160)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 27)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 21)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "确定"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 21)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "取消"
        '
        'nbrSec
        '
        Me.nbrSec.Location = New System.Drawing.Point(268, 81)
        Me.nbrSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nbrSec.Name = "nbrSec"
        Me.nbrSec.Size = New System.Drawing.Size(43, 20)
        Me.nbrSec.TabIndex = 4
        Me.nbrSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nbrMin
        '
        Me.nbrMin.Location = New System.Drawing.Point(183, 81)
        Me.nbrMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nbrMin.Name = "nbrMin"
        Me.nbrMin.Size = New System.Drawing.Size(44, 20)
        Me.nbrMin.TabIndex = 3
        Me.nbrMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nbrHour
        '
        Me.nbrHour.Location = New System.Drawing.Point(97, 81)
        Me.nbrHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.nbrHour.Name = "nbrHour"
        Me.nbrHour.Size = New System.Drawing.Size(44, 20)
        Me.nbrHour.TabIndex = 2
        Me.nbrHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nbrDay
        '
        Me.nbrDay.Location = New System.Drawing.Point(18, 81)
        Me.nbrDay.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nbrDay.Name = "nbrDay"
        Me.nbrDay.Size = New System.Drawing.Size(50, 20)
        Me.nbrDay.TabIndex = 1
        Me.nbrDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(318, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 12)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "秒"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(233, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "分钟"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(147, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "小时"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "天"
        '
        'txtNotiName
        '
        Me.txtNotiName.Location = New System.Drawing.Point(76, 12)
        Me.txtNotiName.Name = "txtNotiName"
        Me.txtNotiName.Size = New System.Drawing.Size(200, 20)
        Me.txtNotiName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 12)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "名称:"
        '
        'Button1
        '
        Me.Button1.Image = Global.EVENotifier.My.Resources.Resources.clip
        Me.Button1.Location = New System.Drawing.Point(340, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.Button1, "自动粘贴制造研究剩余时间")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rdbLeftTime
        '
        Me.rdbLeftTime.AutoSize = True
        Me.rdbLeftTime.Checked = True
        Me.rdbLeftTime.Location = New System.Drawing.Point(20, 47)
        Me.rdbLeftTime.Name = "rdbLeftTime"
        Me.rdbLeftTime.Size = New System.Drawing.Size(86, 16)
        Me.rdbLeftTime.TabIndex = 22
        Me.rdbLeftTime.TabStop = True
        Me.rdbLeftTime.Text = "按剩余时间:"
        Me.rdbLeftTime.UseVisualStyleBackColor = True
        '
        'rdbTime
        '
        Me.rdbTime.AutoSize = True
        Me.rdbTime.Location = New System.Drawing.Point(20, 123)
        Me.rdbTime.Name = "rdbTime"
        Me.rdbTime.Size = New System.Drawing.Size(74, 16)
        Me.rdbTime.TabIndex = 23
        Me.rdbTime.Text = "按时间点:"
        Me.rdbTime.UseVisualStyleBackColor = True
        '
        'dtpTime
        '
        Me.dtpTime.CustomFormat = "yyyy'年'M'月'd'日'  H:mm:ss"
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTime.Location = New System.Drawing.Point(111, 121)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.ShowUpDown = True
        Me.dtpTime.Size = New System.Drawing.Size(165, 20)
        Me.dtpTime.TabIndex = 24
        '
        'Edit
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(389, 198)
        Me.Controls.Add(Me.dtpTime)
        Me.Controls.Add(Me.rdbTime)
        Me.Controls.Add(Me.rdbLeftTime)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nbrSec)
        Me.Controls.Add(Me.nbrMin)
        Me.Controls.Add(Me.nbrHour)
        Me.Controls.Add(Me.nbrDay)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNotiName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Edit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "编辑提醒"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.nbrSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nbrMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nbrHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nbrDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents nbrSec As System.Windows.Forms.NumericUpDown
    Friend WithEvents nbrMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents nbrHour As System.Windows.Forms.NumericUpDown
    Friend WithEvents nbrDay As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNotiName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents rdbLeftTime As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTime As System.Windows.Forms.RadioButton
    Friend WithEvents dtpTime As System.Windows.Forms.DateTimePicker

End Class
