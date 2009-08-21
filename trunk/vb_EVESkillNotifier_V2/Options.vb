'EVENotifier,用于EVE的提醒工具.
'版权所有(C) 2009 huxim
'本程序为自由软件；您可依据自由软件基金会所发表的GNU通用公共授权条款，对本程序再次发布和/或修改；无论您依据的是本授权的第三版，或（您可选的）任一日后发行的版本。
'本程序是基于使用目的而加以发布，然而不负任何担保责任；亦无对适售性或特定目的适用性所为的默示性担保。详情请参照GNU通用公共授权。
'您应已收到附随于本程序的GNU通用公共授权的副本；如果没有，请参照
'<http://www.gnu.org/licenses/>.
'详情联系huxim123@gmail.com

Imports EVENotifier.Main

Public Class Options


    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click

        Me.Close()
    End Sub

    Private Sub Options_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        chkballoon.Checked = main.myOptions.opballoon
        chkmsgbox.Checked = main.myOptions.opmsgbox
        chksound.Checked = main.myOptions.opsound
        rdoDefault.Checked = main.myOptions.opdefault
        rdoCustom.Checked = main.myOptions.opcustom
        txtPath.Text = main.myOptions.oppath
        txtadvance.Text = Main.myOptions.opadvance
        chkGCal.Checked = Main.myOptions.opGCalendar
        'txtXML.Text = Main.myOptions.opXML
        txtUserName.Text = Main.myOptions.opUserName
        txtPassword.Text = Main.myOptions.opPassword
        txtGAd.Value = Main.myOptions.opGAd
        chkAutorun.Checked = Main.myOptions.opAutorun
        chkMinimize.Checked = Main.myOptions.opMinimize

        cmdApply.Enabled = False

        If chksound.Checked = False Then
            rdoDefault.Enabled = False
            rdoCustom.Enabled = False
            txtPath.Enabled = False
            cmdTest.Enabled = False
            cmdBrowse.Enabled = False
        Else
            rdoDefault.Enabled = True
            rdoCustom.Enabled = True
            If rdoDefault.Checked = True Then
                txtPath.Enabled = False
                cmdTest.Enabled = False
                cmdBrowse.Enabled = False
            Else
                txtPath.Enabled = True
                cmdTest.Enabled = True
                cmdBrowse.Enabled = True
            End If
        End If
        If chkGCal.Checked = True Then
            'txtXML.Enabled = True
            txtUserName.Enabled = True
            txtPassword.Enabled = True
        Else
            'txtXML.Enabled = False
            txtUserName.Enabled = False
            txtPassword.Enabled = False
        End If
    End Sub

    Private Sub rdoDefault_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoDefault.CheckedChanged
        If rdoDefault.Checked = True Then
            txtPath.Enabled = False
            cmdTest.Enabled = False
            cmdBrowse.Enabled = False
        Else
            txtPath.Enabled = True
            cmdTest.Enabled = True
            cmdBrowse.Enabled = True
        End If
        cmdApply.Enabled = True
    End Sub

    Private Sub rdoCustom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoCustom.CheckedChanged
        If txtPath.Text = "" Then
            cmdTest.Enabled = False
        Else
            cmdTest.Enabled = True
        End If
        cmdApply.Enabled = True
    End Sub

    Private Sub chksound_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksound.CheckedChanged
        If chksound.Checked = False Then
            rdoDefault.Enabled = False
            rdoCustom.Enabled = False
            txtPath.Enabled = False
            cmdTest.Enabled = False
            cmdBrowse.Enabled = False
        Else
            rdoDefault.Enabled = True
            rdoCustom.Enabled = True
            If rdoDefault.Checked = True Then
                txtPath.Enabled = False
                cmdTest.Enabled = False
                cmdBrowse.Enabled = False
            Else
                txtPath.Enabled = True
                cmdTest.Enabled = True
                cmdBrowse.Enabled = True
            End If
        End If
        cmdApply.Enabled = True
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            main.myOptions.oppath = OpenFileDialog1.FileName
            txtPath.Text = main.myOptions.oppath
        End If
    End Sub

    Private Sub cmdTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest.Click
        If txtPath.Text = "" And txtPath.Enabled = True Then

            MsgBox("请指定音频文件!", MsgBoxStyle.Exclamation, "警告")
        Else
            Try
                My.Computer.Audio.Play(main.myOptions.oppath, AudioPlayMode.Background)
            Catch ex As Exception
                MsgBox("出现错误!" & ex.Message, MsgBoxStyle.Exclamation, "警告")
            End Try
        End If
    End Sub

    Private Sub txtPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPath.TextChanged
        If txtPath.Text = "" Then
            cmdTest.Enabled = False
        Else
            cmdTest.Enabled = True
        End If
        cmdApply.Enabled = True
    End Sub

    Private Sub chkballoon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkballoon.CheckedChanged
        cmdApply.Enabled = True
    End Sub

    Private Sub chkmsgbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkmsgbox.CheckedChanged
        cmdApply.Enabled = True
    End Sub

    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApply.Click
        If txtPath.Text = "" And txtPath.Enabled = True Then

            MsgBox("请指定音频文件!", MsgBoxStyle.Exclamation, "警告")
        Else
            Try
                'main.myOptions.opballoon = chkballoon.Checked
                'main.myOptions.opmsgbox = chkmsgbox.Checked
                'main.myOptions.opsound = chksound.Checked
                'main.myOptions.opdefault = rdoDefault.Checked
                'main.myOptions.opcustom = rdoCustom.Checked
                'main.myOptions.oppath = txtPath.Text
                'Main.myOptions.opadvance = txtadvance.Text
                'Main.myOptions.opGCalendar = chkGCal.Checked
                ''Main.myOptions.opXML = txtXML.Text
                'Main.myOptions.opUserName = txtUserName.Text
                'Main.myOptions.opPassword = txtPassword.Text
                'Main.myOptions.opGAd = txtGAd.Text
                ''main.myTime.timeNotify = main.myTime.timeFinish.Add(New System.TimeSpan(0, 0, -main.myOptions.opadvance, 0))

                'For Each mytime As Main.time In Main.timeColl
                '    mytime.timeNotify = mytime.timeFinish.Add(New System.TimeSpan(0, 0, -Main.myOptions.opadvance, 0))
                'Next

                'Main.showTimes()
                'Main.saveoptions()
                'Main.savetime()
                'If Main.myOptions.opGCalendar Then
                '    Dim threadUpdateGoocal As New System.Threading.Thread(AddressOf Main.updateGooCal)
                '    threadUpdateGoocal.Start()
                'End If
                applyOptions()
                cmdApply.Enabled = False
            Catch ex As Exception
                MsgBox("出现错误!" & ex.Message, MsgBoxStyle.Exclamation, "警告")
            End Try

        End If
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If txtPath.Text = "" And txtPath.Enabled = True Then

            MsgBox("请指定音频文件!", MsgBoxStyle.Exclamation, "警告")
        Else
            Try
                'main.myOptions.opballoon = chkballoon.Checked
                'main.myOptions.opmsgbox = chkmsgbox.Checked
                'main.myOptions.opsound = chksound.Checked
                'main.myOptions.opdefault = rdoDefault.Checked
                'main.myOptions.opcustom = rdoCustom.Checked
                'main.myOptions.oppath = txtPath.Text
                'Main.myOptions.opadvance = txtadvance.Text
                'Main.myOptions.opGCalendar = chkGCal.Checked
                ''Main.myOptions.opXML = txtXML.Text
                'Main.myOptions.opUserName = txtUserName.Text
                'Main.myOptions.opPassword = txtPassword.Text
                'Main.myOptions.opGAd = txtGAd.Text
                ''main.myTime.timeNotify = main.myTime.timeFinish.Add(New System.TimeSpan(0, 0, -main.myOptions.opadvance, 0))

                'For Each mytime As Main.time In Main.timeColl
                '    mytime.timeNotify = mytime.timeFinish.Add(New System.TimeSpan(0, 0, -Main.myOptions.opadvance, 0))
                'Next

                'Main.showTimes()
                'Main.saveoptions()
                'Main.savetime()
                'If Main.myOptions.opGCalendar Then
                '    Dim threadUpdateGoocal As New System.Threading.Thread(AddressOf Main.updateGooCal)
                '    threadUpdateGoocal.Start()
                'End If
                applyOptions()
                Me.Close()
            Catch ex As Exception
                MsgBox("出现错误!" & ex.Message, MsgBoxStyle.Exclamation, "警告")
            End Try
        End If
    End Sub

   
    Private Sub chkGCal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGCal.CheckedChanged
        If chkGCal.Checked = True Then
            txtXML.Enabled = True
            txtUserName.Enabled = True
            txtPassword.Enabled = True
        Else
            txtXML.Enabled = False
            txtUserName.Enabled = False
            txtPassword.Enabled = False
        End If
        cmdApply.Enabled = True
    End Sub

    Private Sub txtUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserName.TextChanged
        cmdApply.Enabled = True
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        cmdApply.Enabled = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://sites.google.com/site/huximssoft/Home/eve-ti-xing-qi-net-1/she-zhigoogle-ri-li")
    End Sub

    'Private Sub txtXML_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtXML.TextChanged
    '    cmdApply.Enabled = True
    'End Sub

    Private Sub applyOptions()
        Main.myOptions.opballoon = chkballoon.Checked
        Main.myOptions.opmsgbox = chkmsgbox.Checked
        Main.myOptions.opsound = chksound.Checked
        Main.myOptions.opdefault = rdoDefault.Checked
        Main.myOptions.opcustom = rdoCustom.Checked
        Main.myOptions.oppath = txtPath.Text
        Main.myOptions.opadvance = txtadvance.Text
        Main.myOptions.opGCalendar = chkGCal.Checked
        'Main.myOptions.opXML = txtXML.Text
        Main.myOptions.opUserName = txtUserName.Text
        Main.myOptions.opPassword = txtPassword.Text
        Main.myOptions.opGAd = txtGAd.Text
        'main.myTime.timeNotify = main.myTime.timeFinish.Add(New System.TimeSpan(0, 0, -main.myOptions.opadvance, 0))
        Main.myOptions.opAutorun = chkAutorun.Checked
        Main.myOptions.opMinimize = chkMinimize.Checked


        For Each mytime As Main.time In Main.timeColl
            mytime.timeNotify = mytime.timeFinish.Add(New System.TimeSpan(0, 0, -Main.myOptions.opadvance, 0))
        Next

        Main.showTimes()
        Main.saveoptions()
        Main.savetime()
        Main.applyAutorun()
        If Main.myOptions.opGCalendar Then
            Dim threadUpdateGoocal As New System.Threading.Thread(AddressOf Main.updateGooCal)
            threadUpdateGoocal.Start()
        End If
    End Sub

    Private Sub txtGAd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGAd.ValueChanged
        cmdApply.Enabled = True
    End Sub

    Private Sub chkAutorun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutorun.CheckedChanged
        cmdApply.Enabled = True
    End Sub

    Private Sub chkMinimize_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMinimize.CheckedChanged
        cmdApply.Enabled = True
    End Sub
End Class