Imports System.Windows.Forms

Public Class Notifier

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        My.Computer.Audio.Stop()
        Me.Close()
    End Sub

    Private Sub Notifier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = Main.lblName
        Label2.Text = Main.lblDes
    End Sub
End Class
