'EVENotifier,用于EVE的提醒工具.
'版权所有(C) 2009 huxim
'本程序为自由软件；您可依据自由软件基金会所发表的GNU通用公共授权条款，对本程序再次发布和/或修改；无论您依据的是本授权的第三版，或（您可选的）任一日后发行的版本。
'本程序是基于使用目的而加以发布，然而不负任何担保责任；亦无对适售性或特定目的适用性所为的默示性担保。详情请参照GNU通用公共授权。
'您应已收到附随于本程序的GNU通用公共授权的副本；如果没有，请参照
'<http://www.gnu.org/licenses/>.
'详情联系huxim123@gmail.com

Imports System.Windows.Forms

Public Class frmloop
    Dim T As Integer
    Dim i As Integer

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If txtLoop.Text = "" Then
            MsgBox("请输入数字!", MsgBoxStyle.OkOnly, "警告")
        Else
            Try
                If Timer1.Enabled = False Then
                    T = txtLoop.Text
                    i = 0
                    Timer1.Enabled = True
                    txtLoop.ReadOnly = True
                    OK_Button.Text = "停止"
                ElseIf Timer1.Enabled = True Then
                    Timer1.Enabled = False
                    txtLoop.ReadOnly = False
                    OK_Button.Text = "开始"
                End If
            Catch ex As Exception
                MsgBox("出现错误!" & ex.Message, MsgBoxStyle.Exclamation, "警告")
            End Try
        End If

    End Sub

    Private Sub frmloop_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Enabled = False
    End Sub

    Private Sub frmloop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            T = T - 1
            lbltime.Text = T
            If T = 0 Then
                i = i + 1
                Main.NotifyIcon1.ShowBalloonTip(1000, "循环计时器", "你设定的时间循环了" & i & "次.", ToolTipIcon.Info)
                Try

                    My.Computer.Audio.Play(My.Resources.dingdang, AudioPlayMode.Background)

                Catch ex As Exception
                    MsgBox("出现错误!" & ex.Message, MsgBoxStyle.Exclamation, "警告")
                End Try
                T = txtLoop.Text
            End If
        Catch ex As Exception
            MsgBox("出现错误!" & ex.Message, MsgBoxStyle.Exclamation, "警告")
        End Try
    End Sub

    Private Sub txtLoop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLoop.Click
        txtLoop.SelectAll()
    End Sub

    Private Sub txtLoop_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLoop.GotFocus
        txtLoop.SelectAll()
    End Sub


End Class
