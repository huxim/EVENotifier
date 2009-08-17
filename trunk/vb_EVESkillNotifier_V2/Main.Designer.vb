<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.文件FToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.退出XToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.视图VToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.窗口置顶TToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.工具TToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.循环计时器LToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.选项OToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.帮助HToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.使用帮助HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.检查更新UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.关于AToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.lblTimeNow = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.notiName = New System.Windows.Forms.ColumnHeader
        Me.timeFinish = New System.Windows.Forms.ColumnHeader
        Me.cmdStop = New System.Windows.Forms.Button
        Me.cmdDel = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.MenuStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件FToolStripMenuItem1, Me.视图VToolStripMenuItem1, Me.工具TToolStripMenuItem1, Me.帮助HToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(574, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '文件FToolStripMenuItem1
        '
        Me.文件FToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.退出XToolStripMenuItem1})
        Me.文件FToolStripMenuItem1.Name = "文件FToolStripMenuItem1"
        Me.文件FToolStripMenuItem1.Size = New System.Drawing.Size(57, 20)
        Me.文件FToolStripMenuItem1.Text = "文件(&F)"
        '
        '退出XToolStripMenuItem1
        '
        Me.退出XToolStripMenuItem1.Name = "退出XToolStripMenuItem1"
        Me.退出XToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.退出XToolStripMenuItem1.Text = "退出(&X)"
        '
        '视图VToolStripMenuItem1
        '
        Me.视图VToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.窗口置顶TToolStripMenuItem1})
        Me.视图VToolStripMenuItem1.Name = "视图VToolStripMenuItem1"
        Me.视图VToolStripMenuItem1.Size = New System.Drawing.Size(57, 20)
        Me.视图VToolStripMenuItem1.Text = "视图(&V)"
        '
        '窗口置顶TToolStripMenuItem1
        '
        Me.窗口置顶TToolStripMenuItem1.CheckOnClick = True
        Me.窗口置顶TToolStripMenuItem1.Name = "窗口置顶TToolStripMenuItem1"
        Me.窗口置顶TToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.窗口置顶TToolStripMenuItem1.Text = "窗口置顶(&T)"
        '
        '工具TToolStripMenuItem1
        '
        Me.工具TToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.循环计时器LToolStripMenuItem1, Me.选项OToolStripMenuItem1})
        Me.工具TToolStripMenuItem1.Name = "工具TToolStripMenuItem1"
        Me.工具TToolStripMenuItem1.Size = New System.Drawing.Size(57, 20)
        Me.工具TToolStripMenuItem1.Text = "工具(&T)"
        '
        '循环计时器LToolStripMenuItem1
        '
        Me.循环计时器LToolStripMenuItem1.Name = "循环计时器LToolStripMenuItem1"
        Me.循环计时器LToolStripMenuItem1.Size = New System.Drawing.Size(159, 22)
        Me.循环计时器LToolStripMenuItem1.Text = "循环计时器(&L)..."
        '
        '选项OToolStripMenuItem1
        '
        Me.选项OToolStripMenuItem1.Name = "选项OToolStripMenuItem1"
        Me.选项OToolStripMenuItem1.Size = New System.Drawing.Size(159, 22)
        Me.选项OToolStripMenuItem1.Text = "选项(&O)..."
        '
        '帮助HToolStripMenuItem1
        '
        Me.帮助HToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.使用帮助HToolStripMenuItem, Me.检查更新UToolStripMenuItem, Me.关于AToolStripMenuItem1})
        Me.帮助HToolStripMenuItem1.Name = "帮助HToolStripMenuItem1"
        Me.帮助HToolStripMenuItem1.Size = New System.Drawing.Size(58, 20)
        Me.帮助HToolStripMenuItem1.Text = "帮助(&H)"
        '
        '使用帮助HToolStripMenuItem
        '
        Me.使用帮助HToolStripMenuItem.Name = "使用帮助HToolStripMenuItem"
        Me.使用帮助HToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.使用帮助HToolStripMenuItem.Text = "使用帮助(&H)..."
        '
        '检查更新UToolStripMenuItem
        '
        Me.检查更新UToolStripMenuItem.Name = "检查更新UToolStripMenuItem"
        Me.检查更新UToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.检查更新UToolStripMenuItem.Text = "检查更新(&U)"
        '
        '关于AToolStripMenuItem1
        '
        Me.关于AToolStripMenuItem1.Name = "关于AToolStripMenuItem1"
        Me.关于AToolStripMenuItem1.Size = New System.Drawing.Size(149, 22)
        Me.关于AToolStripMenuItem1.Text = "关于(&A)..."
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblTimeNow)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(574, 325)
        Me.SplitContainer1.SplitterDistance = 31
        Me.SplitContainer1.TabIndex = 0
        Me.SplitContainer1.TabStop = False
        '
        'lblTimeNow
        '
        Me.lblTimeNow.AutoSize = True
        Me.lblTimeNow.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTimeNow.Location = New System.Drawing.Point(228, 9)
        Me.lblTimeNow.Name = "lblTimeNow"
        Me.lblTimeNow.Size = New System.Drawing.Size(45, 13)
        Me.lblTimeNow.TabIndex = 1
        Me.lblTimeNow.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(140, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "当前时间:"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ListView1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.cmdStop)
        Me.SplitContainer2.Panel2.Controls.Add(Me.cmdDel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.cmdEdit)
        Me.SplitContainer2.Panel2.Controls.Add(Me.cmdAdd)
        Me.SplitContainer2.Size = New System.Drawing.Size(574, 290)
        Me.SplitContainer2.SplitterDistance = 452
        Me.SplitContainer2.TabIndex = 8
        Me.SplitContainer2.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.notiName, Me.timeFinish})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(452, 290)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'notiName
        '
        Me.notiName.Text = "名称"
        Me.notiName.Width = 223
        '
        'timeFinish
        '
        Me.timeFinish.Text = "完成时间"
        Me.timeFinish.Width = 223
        '
        'cmdStop
        '
        Me.cmdStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdStop.AutoSize = True
        Me.cmdStop.Location = New System.Drawing.Point(13, 255)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(93, 23)
        Me.cmdStop.TabIndex = 3
        Me.cmdStop.Text = "停止提示音(&S)"
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'cmdDel
        '
        Me.cmdDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDel.Location = New System.Drawing.Point(13, 74)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(93, 23)
        Me.cmdDel.TabIndex = 2
        Me.cmdDel.Text = "删除(&D)"
        Me.cmdDel.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEdit.Location = New System.Drawing.Point(13, 45)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(93, 23)
        Me.cmdEdit.TabIndex = 1
        Me.cmdEdit.Text = "编辑(&E)"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.Location = New System.Drawing.Point(13, 16)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(93, 23)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "添加提醒(&A)"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "text"
        Me.NotifyIcon1.BalloonTipTitle = "title"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "EVE提醒器"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'BackgroundWorker1
        '
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 349)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EVE提醒器"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 文件FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 视图VToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 窗口置顶TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 工具TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 选项OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Google日历GToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 帮助HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 在线帮助HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关于AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblTimeNow As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents cmdDel As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents 循环计时器LToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents notiName As System.Windows.Forms.ColumnHeader
    Friend WithEvents timeFinish As System.Windows.Forms.ColumnHeader
    Friend WithEvents 文件FToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出XToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 视图VToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 窗口置顶TToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 工具TToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 循环计时器LToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 选项OToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 帮助HToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 使用帮助HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关于AToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 检查更新UToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker


End Class
