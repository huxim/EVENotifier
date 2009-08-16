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
                'main.NotifyIcon1.BalloonTipText = "循环时间到!"
                'main.NotifyIcon1.ShowBalloonTip(1000)
                i = i + 1
                main.NotifyIcon1.ShowBalloonTip(1000, "注意!", "设定的时间循环了" & i & "次.", ToolTipIcon.Info)
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
