<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNotiName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.nbrDay = New System.Windows.Forms.NumericUpDown
        Me.nbrHour = New System.Windows.Forms.NumericUpDown
        Me.nbrMin = New System.Windows.Forms.NumericUpDown
        Me.nbrSec = New System.Windows.Forms.NumericUpDown
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nbrDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nbrHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nbrMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nbrSec, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(231, 117)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "名称:"
        '
        'txtNotiName
        '
        Me.txtNotiName.Location = New System.Drawing.Point(78, 12)
        Me.txtNotiName.Name = "txtNotiName"
        Me.txtNotiName.Size = New System.Drawing.Size(200, 21)
        Me.txtNotiName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "剩余时间:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "天"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(145, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "小时"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(231, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "分钟"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(316, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 12)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "秒"
        '
        'nbrDay
        '
        Me.nbrDay.Location = New System.Drawing.Point(16, 80)
        Me.nbrDay.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nbrDay.Name = "nbrDay"
        Me.nbrDay.Size = New System.Drawing.Size(50, 21)
        Me.nbrDay.TabIndex = 1
        Me.nbrDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nbrHour
        '
        Me.nbrHour.Location = New System.Drawing.Point(95, 80)
        Me.nbrHour.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.nbrHour.Name = "nbrHour"
        Me.nbrHour.Size = New System.Drawing.Size(44, 21)
        Me.nbrHour.TabIndex = 2
        Me.nbrHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nbrMin
        '
        Me.nbrMin.Location = New System.Drawing.Point(181, 80)
        Me.nbrMin.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nbrMin.Name = "nbrMin"
        Me.nbrMin.Size = New System.Drawing.Size(44, 21)
        Me.nbrMin.TabIndex = 3
        Me.nbrMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nbrSec
        '
        Me.nbrSec.Location = New System.Drawing.Point(266, 80)
        Me.nbrSec.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nbrSec.Name = "nbrSec"
        Me.nbrSec.Size = New System.Drawing.Size(43, 21)
        Me.nbrSec.TabIndex = 4
        Me.nbrSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Image = Global.EVENotifier.My.Resources.Resources.clip
        Me.Button1.Location = New System.Drawing.Point(339, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.Button1, "自动粘贴制造研究剩余时间")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(389, 155)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nbrSec)
        Me.Controls.Add(Me.nbrMin)
        Me.Controls.Add(Me.nbrHour)
        Me.Controls.Add(Me.nbrDay)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNotiName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "添加提醒"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.nbrDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nbrHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nbrMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nbrSec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNotiName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nbrDay As System.Windows.Forms.NumericUpDown
    Friend WithEvents nbrHour As System.Windows.Forms.NumericUpDown
    Friend WithEvents nbrMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents nbrSec As System.Windows.Forms.NumericUpDown
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
