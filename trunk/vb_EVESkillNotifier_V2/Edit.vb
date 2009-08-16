Imports System.Windows.Forms

Public Class Edit
    Dim collIndex As Integer
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            If nbrDay.Value < 0 Or nbrDay.Value > 65534 Or nbrHour.Value < 0 _
                Or nbrHour.Value > 24 Or nbrMin.Value < 0 Or nbrMin.Value > 60 _
                Or nbrSec.Value < 0 Or nbrSec.Value > 60 Then
                MsgBox("请正确输入时间!", MsgBoxStyle.Exclamation, "警告")
                nbrDay.Value = 0
                nbrHour.Value = 0
                nbrMin.Value = 0
                nbrSec.Value = 0
            ElseIf txtNotiName.Text = "" Then
                MsgBox("请输入提醒名称!", MsgBoxStyle.Exclamation, "警告")
            Else
                'Dim editTime As New Main.time
                Dim duration As System.TimeSpan

                Main.timeColl.Item(collIndex).notiName = txtNotiName.Text
                duration = New System.TimeSpan(nbrDay.Value, nbrHour.Value, nbrMin.Value, nbrSec.Value)
                Main.timeColl.Item(collIndex).timeFinish = Main.DatetimeNow.Add(duration)
                Main.timeColl.Item(collIndex).timeNotify = Main.timeColl.Item(collIndex).timeFinish.Add(New System.TimeSpan(0, 0, -Main.myOptions.opadvance, 0))
                Main.timeColl.Item(collIndex).isNotified = False
                Main.timeColl.Item(collIndex).isFinished = False
                'Main.timeColl.Item(Main.index) = editTime
                Main.savetime()
                Main.showTimes()
                If Main.myOptions.opGCalendar Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Me.Close()
                    Main.delEvent()
                    Main.addEvent()
                End If

                If Main.timeColl.Item(collIndex).timeFinish.Hour = 9 Then
                    MsgBox("事件完成时服务器正好在维护,请注意.", MsgBoxStyle.Exclamation, "警告")
                ElseIf Main.timeColl.Item(collIndex).timeFinish.Hour = 10 Then
                    MsgBox("事件在10点多完成,可能遇到服务器维护延长.", MsgBoxStyle.Information, "信息")
                End If
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
                End If
        Catch ex As Exception
            MsgBox("更改提醒时出现错误!" + Chr(13) & Chr(10) + "错误信息:" + ex.Message, MsgBoxStyle.Exclamation, "警告")
            nbrDay.Value = 0
            nbrHour.Value = 0
            nbrMin.Value = 0
            nbrSec.Value = 0
        End Try
        Main.ListView1.Focus()
        Main.ListView1.Items(Main.index).Selected = True
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Main.cmdDel.Enabled = False
        Main.cmdEdit.Enabled = False
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        collIndex = Main.index + 1
        txtNotiName.Text = Main.ListView1.Items.Item(Main.index).Text
        nbrDay.Value = 0
        nbrHour.Value = 0
        nbrMin.Value = 0
        nbrSec.Value = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim text As String = ""
        Try
            If My.Computer.Clipboard.ContainsText Then
                text = My.Computer.Clipboard.GetText
            End If
            text = text.Replace("距离完成<t><right><color=0xFFFFFF00>", " ")

            Dim textArray() As String = text.Split(" ")
            Dim timeArray() As String = {"0", "0", "0", "0"}

            If text.Contains("天") Then
                timeArray(0) = textArray(Array.IndexOf(textArray, "天") - 1)
            End If
            If text.Contains("小时") Then
                timeArray(1) = textArray(Array.IndexOf(textArray, "小时") - 1)
            End If
            If text.Contains("分") Then
                timeArray(2) = textArray(Array.IndexOf(textArray, "分") - 1)
            End If
            If text.Contains("秒") Then
                timeArray(3) = textArray(Array.IndexOf(textArray, "秒") - 1)
            End If

            nbrDay.Value = timeArray(0)
            nbrHour.Value = timeArray(1)
            nbrMin.Value = timeArray(2)
            nbrSec.Value = timeArray(3)
        Catch ex As Exception
            MsgBox("访问剪贴板发生错误!" + Chr(13) & Chr(10) + "错误信息:" + ex.Message, MsgBoxStyle.Exclamation, "警告")
        End Try
    End Sub

    Private Sub nbrDay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbrDay.Click
        nbrDay.Select(0, 20)
    End Sub

    Private Sub nbrDay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbrDay.GotFocus
        nbrDay.Select(0, 20)
    End Sub

    Private Sub nbrHour_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbrHour.Click
        nbrHour.Select(0, 2)
    End Sub

    Private Sub nbrHour_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbrHour.GotFocus
        nbrHour.Select(0, 2)
    End Sub

    Private Sub nbrMin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbrMin.Click
        nbrMin.Select(0, 2)
    End Sub

    Private Sub nbrMin_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbrMin.GotFocus
        nbrMin.Select(0, 2)
    End Sub

    Private Sub nbrSec_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbrSec.Click
        nbrSec.Select(0, 2)
    End Sub

    Private Sub nbrSec_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nbrSec.GotFocus
        nbrSec.Select(0, 2)
    End Sub

End Class
