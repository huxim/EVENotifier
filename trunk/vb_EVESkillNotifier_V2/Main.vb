'EVENotifier,用于EVE的提醒工具.
'版权所有(C) 2009 huxim
'本程序为自由软件；您可依据自由软件基金会所发表的GNU通用公共授权条款，对本程序再次发布和/或修改；无论您依据的是本授权的第三版，或（您可选的）任一日后发行的版本。
'本程序是基于使用目的而加以发布，然而不负任何担保责任；亦无对适售性或特定目的适用性所为的默示性担保。详情请参照GNU通用公共授权。
'您应已收到附随于本程序的GNU通用公共授权的副本；如果没有，请参照
'<http://www.gnu.org/licenses/>.
'详情联系huxim123@gmail.com

Imports System.Xml
Imports System.Net
Imports System.Text
Imports System.IO
Imports Microsoft.Win32
Imports Google.GData.Calendar
Imports Google.GData.Client
Imports Google.GData.Extensions


Public Class Main
    '===============定义变量==============
    Public timeColl As New Microsoft.VisualBasic.Collection() '事件集合
    Public DatetimeNow As DateTime '当前时间
    'Public xmlPath As String = My.Application.Info.DirectoryPath
    Public timeFileName As String = My.Application.Info.DirectoryPath + "\time.xml" '保存时间的文件
    Public opFileName As String = My.Application.Info.DirectoryPath + "\options.xml" '保存设置的文件
    Public index As Integer '表示当前操作的事件在集合中的索引,目前只支持操作一个事件
    Public lblName As String '弹窗提醒中显示的事件名称
    Public lblDes As String '弹窗提醒中显示的事件状态(即将完成/已完成)
    Public myOptions As New op '表示选项的对象
    'Google日历用的
    Dim postUri As Uri = New Uri("http://www.google.com/calendar/feeds/default/private/full")
    Dim Service As CalendarService = New Google.GData.Calendar.CalendarService("EVENotifier")
    '临时变量
    Dim i As Integer
    Dim j As Integer
    Public intLen As Integer '加密用的....
    Dim newVer As Boolean = False '是否有新版本

    '声明通知区域静态的右键菜单
    Dim menuMain As ToolStripMenuItem = New ToolStripMenuItem
    Dim menuOption As ToolStripMenuItem = New ToolStripMenuItem
    Dim menuLoop As ToolStripMenuItem = New ToolStripMenuItem
    Dim menuExit As ToolStripMenuItem = New ToolStripMenuItem
    Dim menuAdd As ToolStripMenuItem = New ToolStripMenuItem
    Dim sep1 As ToolStripSeparator = New ToolStripSeparator
    Dim sep2 As ToolStripSeparator = New ToolStripSeparator
    '==================定义结束==============

    '检查更新,注意用BackgroundWorker调用并跟踪
    Sub checkUpdate()
        Try
            Dim req As HttpWebRequest = WebRequest.Create("http://sites.google.com/site/huximssoft/Home/eve-ti-xing-qi-net-1/xia-zai")
            Dim res As HttpWebResponse = req.GetResponse()
            Dim strm As StreamReader = New StreamReader(res.GetResponseStream(), Encoding.UTF8)
            Dim sourceCode As String
            Dim tmpArray() As String
            Dim stringSeparators() As String = {"最新版本"}
            sourceCode = strm.ReadToEnd()
            tmpArray = sourceCode.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries)
            sourceCode = tmpArray(1)
            tmpArray = sourceCode.Split(")")
            sourceCode = tmpArray(0)
            'MsgBox(sourceCode)
            Dim localVer As String() = {"0", "0", "0", "0"}
            Dim remoteVer As String() = {"0", "0", "0", "0"}
            newVer = False
            localVer = My.Application.Info.Version.ToString.Split(".")
            remoteVer = sourceCode.Split(".")
            For a As Integer = 0 To 3 Step 1
                If remoteVer(a) > localVer(a) Then
                    newVer = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox("检查更新出错,请检查网络连接." + Chr(13) & Chr(10) + "错误信息:" + ex.Message, MsgBoxStyle.Exclamation, "警告")
        End Try
    End Sub

    '定义通知区域静态的右键菜单
    Sub setContextMenus()

        menuMain.Font = New Font(menuMain.Font, FontStyle.Bold)
        menuMain.Text = "显示主界面(&M)"
        AddHandler menuMain.Click, AddressOf showMain

        menuOption.Text = "选项(&O)..."
        AddHandler menuOption.Click, AddressOf showOption

        menuLoop.Text = "循环计时器(&L)..."
        AddHandler menuLoop.Click, AddressOf showLoop

        menuExit.Text = "退出(&X)"
        AddHandler menuExit.Click, AddressOf exitProgram

        menuAdd.Text = "添加提醒(&A)..."
        AddHandler menuAdd.Click, AddressOf cmdAdd_Click

    End Sub

    '选项类
    Public Class op
        '气球提示
        Public opballoon As Boolean
        '弹出窗口提示
        Public opmsgbox As Boolean
        '声音提示
        Public opsound As Boolean
        '自定义音频文件路径
        Public oppath As String
        '默认声音
        Public opdefault As Boolean
        '自定义声音
        Public opcustom As Boolean
        '提前时间
        Public opadvance As Integer
        'Google日历
        Public opGCalendar As Boolean
        '日历地址
        'Public opXML As String '= "http://www.google.com/calendar/feeds/default/private/full"
        '用户名
        Public opUserName As String
        '密码
        Public opPassword As String
        'G提前时间
        Public opGAd As Integer
        '自启动
        Public opAutorun As Boolean
        '启动后最小化
        Public opMinimize As Boolean

        Public Sub New()
        End Sub
    End Class

    '时间/事件类
    Public Class time
        '名称
        Public notiName As String
        '完成时间
        Public timeFinish As DateTime
        '提醒时间
        Public timeNotify As DateTime
        '已经提醒或已经完成
        Public isNotified As Boolean = False
        Public isFinished As Boolean = False

        Public Sub New()
        End Sub

    End Class

    '更新Google 日历,似乎有更好的方法.(多线程,注意冲突)
    Sub updateGooCal()
        delGEvents()
        addGEvents()
    End Sub

    '删除所有GCalendar事件
    Sub delGEvents()
        Try
            Dim myQuery As FeedQuery = New EventQuery()
            Service.setUserCredentials(myOptions.opUserName + "@gmail.com", myOptions.opPassword)
            'myQuery.Query = "aaa"
            myQuery.Uri = postUri
            Dim myResultsFeed As AtomFeed = Service.Query(myQuery)
            If (myResultsFeed.Entries.Count > 0) Then
                'Dim i As Integer = 1
                For Each delEntry As AtomEntry In myResultsFeed.Entries
                    'Dim firstMatchEntry As AtomEntry = myResultsFeed.Entries(i - 1)
                    'MsgBox(myResultsFeed.Entries.Count)
                    delEntry.Delete()
                Next
            End If
        Catch ex As Exception
            MsgBox("删除事件出错!" & ex.Message, MsgBoxStyle.Exclamation, "警告")
        End Try
    End Sub

    '将提醒添加到GCalendar
    Sub addGEvents()
        Try
            For Each mytime As time In timeColl
                Dim entry As EventEntry = New EventEntry()
                Service.setUserCredentials(myOptions.opUserName + "@gmail.com", myOptions.opPassword)

                'Set the title and content of the entry.
                entry.Title.Text = mytime.notiName

                'Set time
                Dim eventTime As Google.GData.Extensions.When = New Google.GData.Extensions.When(mytime.timeFinish, mytime.timeFinish.AddHours(1))
                entry.Times.Add(eventTime)

                'Reminders and Notifications
                Dim timeReminder As Reminder = New Reminder()
                timeReminder.Minutes = myOptions.opGAd
                timeReminder.Method = Reminder.ReminderMethod.sms
                entry.Reminders.Add(timeReminder)
                'entry.Update()

                'Send the request and receive the response:
                Dim insertedEntry As AtomEntry = Service.Insert(postUri, entry)
            Next
        Catch ex As Exception
            MsgBox("添加事件出错!" & ex.Message, MsgBoxStyle.Exclamation, "警告")
        End Try
    End Sub

    '载入设置
    Sub loadoptions()
        If My.Computer.FileSystem.FileExists(opFileName) = False Then
            MsgBox("未找到设置文件,将自动创建默认设置文件.", MsgBoxStyle.Information, "信息")
            defaultop()
        End If
        '创建reader
        Dim readersettings As New XmlReaderSettings()
        readersettings.ConformanceLevel = ConformanceLevel.Fragment
        readersettings.IgnoreWhitespace = True
        readersettings.IgnoreComments = True
        Dim reader As XmlReader = XmlReader.Create(opFileName, readersettings)
        Try
            '读取xml
            reader.ReadToFollowing("opballoon")

            myOptions.opballoon = reader.ReadElementContentAsBoolean()
            myOptions.opmsgbox = reader.ReadElementContentAsBoolean()
            myOptions.opsound = reader.ReadElementContentAsBoolean()
            myOptions.oppath = reader.ReadElementContentAsString()
            myOptions.opdefault = reader.ReadElementContentAsBoolean()
            myOptions.opcustom = reader.ReadElementContentAsBoolean()
            myOptions.opadvance = reader.ReadElementContentAsInt()
            myOptions.opGCalendar = reader.ReadElementContentAsBoolean()
            'myOptions.opXML = reader.ReadElementContentAsString()
            myOptions.opUserName = reader.ReadElementContentAsString()
            myOptions.opPassword = decrypt(reader.ReadElementContentAsString())
            myOptions.opGAd = reader.ReadElementContentAsInt()
            myOptions.opAutorun = reader.ReadElementContentAsBoolean()
            myOptions.opMinimize = reader.ReadElementContentAsBoolean()
            reader.Close()
        Catch ex As Exception
            reader.Close()
            MsgBox("载入设置出现错误,将自动创建默认设置文件." + Chr(13) & Chr(10) + "错误信息:" + ex.Message, MsgBoxStyle.Information, "信息")
            If My.Computer.FileSystem.FileExists(opFileName) Then
                My.Computer.FileSystem.DeleteFile(opFileName)
            End If
            defaultop()
            loadoptions()
        End Try
    End Sub

    '载入时间
    Sub loadtime()
        If My.Computer.FileSystem.FileExists(timeFileName) = False Then
            MsgBox("未找到时间配置文件,将自动创建空配置文件.", MsgBoxStyle.Information, "信息")
            defaulttime()
        End If

        Dim reader As XmlTextReader = Nothing
        Try
            ' Load the reader with the data file and
            'ignore all white space nodes.
            reader = New XmlTextReader(timeFileName)
            reader.WhitespaceHandling = WhitespaceHandling.None

            ' Parse the file and display each of the nodes.
            reader.Read()
            If reader.IsStartElement("time") Then

                If reader.IsEmptyElement() Then
                    '空标记,表示没有时间数据
                Else
                    '非空标记,读取时间
                    reader.ReadStartElement() '移动读取器到配置头
                    While reader.Name <> "time"
                        Dim myTime As New time
                        reader.ReadStartElement() '移动读取器到<notiName>
                        reader.Read() '移动读取器到名称
                        myTime.notiName = reader.Value
                        reader.Read() '移动读取器到</notiName>
                        reader.ReadEndElement() '移动读取器到<timeFinish>
                        reader.Read() '移动读取器到完成时间
                        myTime.timeFinish = reader.Value
                        reader.Read() '移动读取器到</timeFinish>
                        reader.ReadEndElement() '移动读取器到<timeNotify>
                        reader.Read() '移动读取器到提醒时间
                        myTime.timeNotify = reader.Value
                        reader.Read() '移动读取器到</timeNotify>
                        reader.Read() '移动读取器到配置尾
                        reader.ReadEndElement() '将读取器移动至下一组配置头
                        timeColl.Add(myTime)

                    End While
                End If
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("载入时间出现错误,将自动创建空配置文件.", MsgBoxStyle.Information, "信息")
            If My.Computer.FileSystem.FileExists(timeFileName) Then
                My.Computer.FileSystem.DeleteFile(timeFileName)
            End If
            defaulttime()
            loadtime()
        Finally
            If Not (reader Is Nothing) Then
                reader.Close()
            End If
        End Try
    End Sub

    '保存设置
    Sub saveoptions()
        'Try
        'xmlwriter方式
        '创建writer
        Dim writersettings As New XmlWriterSettings()
        writersettings.Indent = True
        writersettings.IndentChars = " "
        Dim writer As XmlWriter = XmlWriter.Create(opFileName, writersettings)
        Try
            '写入xml
            writer.WriteStartElement("op")
            writer.WriteElementString("opballoon", CStr(myOptions.opballoon).ToLower)
            writer.WriteElementString("opmsgbox", CStr(myOptions.opmsgbox).ToLower)
            writer.WriteElementString("opsound", CStr(myOptions.opsound).ToLower)
            writer.WriteElementString("oppath", CStr(myOptions.oppath))
            writer.WriteElementString("opdefault", CStr(myOptions.opdefault).ToLower)
            writer.WriteElementString("opcustom", CStr(myOptions.opcustom).ToLower)
            writer.WriteElementString("opadvance", myOptions.opadvance)
            writer.WriteElementString("opGCalendar", CStr(myOptions.opGCalendar).ToLower)
            'writer.WriteElementString("opXML", CStr(myOptions.opXML))
            writer.WriteElementString("opUserName", myOptions.opUserName)
            writer.WriteElementString("opPassword", encrypt(myOptions.opPassword))
            writer.WriteElementString("opGAd", myOptions.opGAd)
            writer.WriteElementString("opAutorun", CStr(myOptions.opAutorun).ToLower)
            writer.WriteElementString("opMinimize", CStr(myOptions.opMinimize).ToLower)
            writer.WriteEndElement()
            writer.Flush()
            writer.Close()
        Catch ex As Exception
            writer.Close()
            MsgBox("保存设置出现错误,将自动创建默认设置文件." + Chr(13) & Chr(10) + "错误信息:" + ex.Message, MsgBoxStyle.Exclamation, "警告")
            If My.Computer.FileSystem.FileExists(opFileName) Then
                My.Computer.FileSystem.DeleteFile(opFileName)
            End If
            defaultop()

        End Try
    End Sub

    '保存时间
    Sub savetime()

        'xmlwriter方式
        '创建writer
        Dim writersettings As New XmlWriterSettings()
        writersettings.Indent = True
        writersettings.IndentChars = " "
        Dim writer As XmlWriter = XmlWriter.Create(timeFileName, writersettings)
        Try
            '写入xml
            If timeColl.Count = 0 Then
                writer.WriteStartElement("time")
                writer.WriteEndElement()
            Else
                writer.WriteStartElement("time")
                For Each myTime As time In timeColl
                    writer.WriteStartElement("notiSetting")
                    writer.WriteElementString("notiName", myTime.notiName)
                    writer.WriteElementString("timeFinish", myTime.timeFinish)
                    writer.WriteElementString("timeNotify", myTime.timeNotify)
                    writer.WriteEndElement()
                Next
                writer.WriteEndElement()
            End If
            writer.Flush()
            writer.Close()
        Catch ex As Exception
            MsgBox("保存时间出现错误,将自动创建空配置文件." + Chr(13) & Chr(10) + "错误信息:" + ex.Message, MsgBoxStyle.Exclamation, "警告")
            If My.Computer.FileSystem.FileExists(timeFileName) Then
                My.Computer.FileSystem.DeleteFile(timeFileName)
            End If
            defaulttime()
        End Try
    End Sub

    '写默认设置
    Sub defaultop()
        '创建writer
        Dim writersettings As New XmlWriterSettings()
        writersettings.Indent = True
        writersettings.IndentChars = " "
        Dim writer As XmlWriter = XmlWriter.Create(opFileName, writersettings)
        '写入xml
        writer.WriteStartElement("op")
        writer.WriteElementString("opballoon", "true")
        writer.WriteElementString("opmsgbox", "true")
        writer.WriteElementString("opsound", "true")
        writer.WriteElementString("oppath", "")
        writer.WriteElementString("opdefault", "true")
        writer.WriteElementString("opcustom", "false")
        writer.WriteElementString("opadvance", "5")
        writer.WriteElementString("opGCalendar", "false")
        'writer.WriteElementString("opXML", CStr(myOptions.opXML))
        writer.WriteElementString("opUserName", "")
        writer.WriteElementString("opPassword", "")
        writer.WriteElementString("opadvance", "15")
        writer.WriteElementString("opAutorun", "false")
        writer.WriteElementString("opMinimize", "false")
        writer.WriteEndElement()
        writer.Flush()
        writer.Close()
    End Sub

    '写空时间文件
    Sub defaulttime()
        '创建writer
        Dim writersettings As New XmlWriterSettings()
        writersettings.Indent = True
        writersettings.IndentChars = " "
        Dim writer As XmlWriter = XmlWriter.Create(timeFileName, writersettings)
        '写入xml
        writer.WriteStartElement("time")
        writer.WriteEndElement()
        writer.Flush()
        writer.Close()
    End Sub

    '加密密码
    Function encrypt(ByVal cleartext As String) As String
        Dim charArraystr() As Char = cleartext.ToCharArray
        Dim charArraykey() As Char = "key111".ToCharArray
        Dim intStrlen As Integer = Len(cleartext)
        Dim intKeylen As Integer = Len("key111")
        Dim intTimes As Integer = intStrlen \ intKeylen
        Dim intArrayresult(intStrlen) As Integer

        intLen = intStrlen * 2 + 1

        For i = 0 To intTimes - 1
            For j = 0 To intKeylen - 1
                intArrayresult(j + i * intKeylen) = AscW(charArraystr(j + i * intKeylen)) Xor AscW(charArraykey(j))
            Next
        Next

        For i = intTimes * intKeylen To intStrlen - 1
            intArrayresult(i) = AscW(charArraystr(i)) Xor AscW(charArraykey(i - intTimes * intKeylen))
        Next

        Dim txtStrText As String = ""
        For i = 0 To intStrlen - 1
            txtStrText = txtStrText & intArrayresult(i) & ","
        Next
        Return txtStrText
    End Function

    '解密密码
    Function decrypt(ByVal ciphertext As String) As String
        Dim charArraystr() As Char = ciphertext.ToCharArray
        Dim charArraykey() As Char = "key111".ToCharArray
        Dim intKeylen As Integer = Len("key111")
        Dim strArrayresult() As String = Split(charArraystr, ",")
        Dim intStrlen As Integer = strArrayresult.GetLength(0) - 1
        Dim intTimes As Integer = intStrlen \ intKeylen
        Dim n As Integer

        intLen = intStrlen * 2 + 1

        For i = 0 To intTimes - 1
            For j = 0 To intKeylen - 1
                n = Val(strArrayresult(j + i * intKeylen))
                strArrayresult(j + i * intKeylen) = ChrW(n Xor AscW(charArraykey(j)))
            Next
        Next

        For i = intTimes * intKeylen To intStrlen - 1
            n = Val(strArrayresult(i))
            strArrayresult(i) = ChrW(n Xor AscW(charArraykey(i - intTimes * intKeylen)))
        Next

        Dim txtStrText As String = ""
        For i = 0 To intStrlen - 1
            txtStrText = txtStrText & strArrayresult(i)
        Next
        Return txtStrText
    End Function

    '将timeColl中的时间更新到ListView,并更新通知区域右键菜单
    Sub showTimes()
        '列表
        ListView1.Items.Clear()
        Dim i As Integer = 0
        '菜单
        ContextMenuStrip1.Items.Clear()
        ContextMenuStrip1.Items.Add(menuMain)
        ContextMenuStrip1.Items.Add(menuOption)
        ContextMenuStrip1.Items.Add(menuLoop)
        ContextMenuStrip1.Items.Add(sep1)
        ContextMenuStrip1.Items.Add(menuAdd)

        For Each mytime As time In timeColl
            '列表
            ListView1.Items.Add(mytime.notiName)
            'ListView1.Items(i).SubItems.Add(mytime.timeNotify)
            ListView1.Items(i).SubItems.Add(mytime.timeFinish)
            '菜单
            '创建事件条目
            Dim menuEvent As ToolStripMenuItem = New ToolStripMenuItem
            menuEvent.Name = i
            menuEvent.Text = mytime.notiName + " - " + mytime.timeFinish
            AddHandler menuEvent.MouseMove, AddressOf event_MouseMove
            '创建编辑子菜单
            Dim menuEdit As ToolStripMenuItem = New ToolStripMenuItem
            menuEdit.Text = "编辑"
            AddHandler menuEdit.Click, AddressOf edit_Click
            '创建删除子菜单
            Dim menuDel As ToolStripMenuItem = New ToolStripMenuItem
            menuDel.Text = "删除"
            AddHandler menuDel.Click, AddressOf del_Click
            '将子菜单装入menuEvent
            menuEvent.DropDownItems.Add(menuEdit)
            menuEvent.DropDownItems.Add(menuDel)
            '将菜单装入ContextMenuStrip1
            ContextMenuStrip1.Items.Add(menuEvent)
            i += 1
        Next
        changeColor()
        cmdDel.Enabled = False
        cmdEdit.Enabled = False
        '静态菜单剩余部分
        ContextMenuStrip1.Items.Add(sep2)
        ContextMenuStrip1.Items.Add(menuExit)

    End Sub

    '更改颜色
    Sub changeColor()
        Dim i As Integer = 0
        For Each mytime As time In timeColl
            '即将完成
            If DatetimeNow > mytime.timeNotify Then

                '更改颜色
                ListView1.Items(i).BackColor = Color.Yellow
            End If
            '完成
            If DatetimeNow > mytime.timeFinish Then

                '更改颜色
                ListView1.Items(i).BackColor = Color.Red
            End If

            i += 1
        Next
    End Sub

    Private Sub exitProgram(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出XToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub 窗口置顶TToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 窗口置顶TToolStripMenuItem1.Click
        If 窗口置顶TToolStripMenuItem1.Checked = False Then
            Me.TopMost = False
        ElseIf 窗口置顶TToolStripMenuItem1.Checked = True Then
            Me.TopMost = True
        End If
    End Sub

    Private Sub 在线帮助HToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 使用帮助HToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://sites.google.com/site/huximssoft/Home/eve-ti-xing-qi-net-1/bang-zhu")
    End Sub

    Private Sub 关于AToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 关于AToolStripMenuItem1.Click
        About.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        '每一秒钟更新当前时间并显示
        DatetimeNow = DateTime.Now
        lblTimeNow.Text = DatetimeNow.ToString
        '检查是否到达提醒时间
        Dim i As Integer = 0
        For Each mytime As time In timeColl
            '已完成
            If DatetimeNow > mytime.timeFinish And mytime.isFinished = False Then
                mytime.isFinished = True
                mytime.isNotified = True
                'If lblTimeNow.Text = mytime.timeFinish.ToString Then
                '气球提示
                If myOptions.opballoon = True Then
                    NotifyIcon1.ShowBalloonTip(6000, "注意!", mytime.notiName + "已完成!", ToolTipIcon.Warning)
                End If

                '声音提示
                If myOptions.opsound = True Then
                    Try
                        If myOptions.opdefault = True Then
                            My.Computer.Audio.Play(My.Resources.Windows_Ringin, AudioPlayMode.BackgroundLoop)
                        ElseIf myOptions.opcustom = True Then
                            My.Computer.Audio.Play(myOptions.oppath, AudioPlayMode.BackgroundLoop)
                        End If
                    Catch ex As Exception
                        MsgBox("出现错误!" & ex.Message, MsgBoxStyle.Exclamation, "警告")
                    End Try
                End If

                '消息窗口提示
                If myOptions.opmsgbox = True Then
                    Me.ShowInTaskbar = True
                    Me.WindowState = FormWindowState.Normal
                    lblName = mytime.notiName
                    lblDes = "已经完成."
                    Dim Result As Integer

                    'Displays a MessageBox using the Question icon and specifying the No button as the default.
                    Result = MsgBox(lblName + Chr(13) & Chr(10) + lblDes, MessageBoxIcon.Warning, "请注意")

                    ' Gets the result of the MessageBox display.
                    If Result = 1 Then
                        My.Computer.Audio.Stop()
                    End If
                End If

                '更改颜色
                ListView1.Items(i).BackColor = Color.Red

                '即将完成
            ElseIf DatetimeNow > mytime.timeNotify And mytime.isNotified = False Then
                mytime.isNotified = True
                'If lblTimeNow.Text = mytime.timeNotify.ToString Then
                '气球提示
                If myOptions.opballoon = True Then
                    NotifyIcon1.ShowBalloonTip(6000, "注意!", mytime.notiName + "即将完成.", ToolTipIcon.Info)
                End If

                '声音提示
                If myOptions.opsound = True Then
                    Try
                        If myOptions.opdefault = True Then
                            My.Computer.Audio.Play(My.Resources.Windows_Ringin, AudioPlayMode.BackgroundLoop)
                        ElseIf myOptions.opcustom = True Then
                            My.Computer.Audio.Play(myOptions.oppath, AudioPlayMode.BackgroundLoop)
                        End If
                    Catch ex As Exception
                        MsgBox("出现错误!" & ex.Message, MsgBoxStyle.Exclamation, "警告")
                    End Try
                End If

                '消息窗口提示
                If myOptions.opmsgbox = True Then
                    Me.ShowInTaskbar = True
                    Me.WindowState = FormWindowState.Normal
                    lblName = mytime.notiName
                    lblDes = "即将完成."
                    Dim Result As Integer

                    'Displays a MessageBox using the Question icon and specifying the No button as the default.
                    Result = MsgBox(lblName + Chr(13) & Chr(10) + lblDes, MessageBoxIcon.Information, "请注意")

                    ' Gets the result of the MessageBox display.
                    If Result = 1 Then
                        My.Computer.Audio.Stop()
                    End If
                End If

                '更改颜色
                ListView1.Items(i).BackColor = Color.Yellow
            End If
            i += 1
        Next
    End Sub

    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Add.ShowDialog()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Edit.ShowDialog()
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        delAEvent()
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '启动时显示时间
        DatetimeNow = DateTime.Now
        lblTimeNow.Text = DatetimeNow.ToString
        '载入数据
        '载入程序设置
        loadoptions()
        '载入提醒时间
        loadtime()
        '显示时间
        showTimes()
        '通知区域静态的右键菜单
        setContextMenus()
        '应用常规设置
        applyNormalOptions()
    End Sub

    '应用常规设置
    Private Sub applyNormalOptions()
        applyAutorun()
        applyMinimize()
    End Sub

    '自启动
    Sub applyAutorun()
        '判断是无虚拟机还是有虚拟机
        Dim appPath As String
        Dim appLocation As String
        Dim registryKey As String = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run"
        Dim isVM As Boolean
        appPath = My.Application.Info.DirectoryPath
        If appPath.EndsWith("\app") Then
            'MsgBox(".")
            isVM = True
            Dim appString() As Char = "\app"
            appLocation = appPath.TrimEnd(appString)
            appPath = appLocation + "\evenloader.exe"
        Else
            appLocation = appPath
            appPath = appLocation + "\run.exe"
        End If
        'MsgBox(appPath)

        Try
            If myOptions.opAutorun = True Then

                Dim shortCutPath As String
                ' 直接调用COM对象
                Dim wsh As Object = CreateObject("WScript.Shell")
                shortCutPath = appLocation & "\EVENotifier.lnk"
                'shortCutPath = wsh.SpecialFolders("StartUp") & "\EVENotifier.lnk"
                'MsgBox(shortCutPath)

                Dim lnk As Object = wsh.CreateShortcut(shortCutPath)
                If isVM Then
                    With lnk
                        '.Arguments = "/?" '传递参数
                        .Description = "EVE提醒器"
                        .IconLocation = appLocation + "\app\run.exe,0" '图标
                        .TargetPath = appPath
                        '.WindowStyle = 7 '打开窗体的风格，最小化
                        .WorkingDirectory = appLocation '工作路径

                        .Save() '保存快捷方式
                    End With

                    My.Computer.Registry.SetValue(registryKey, "EVENotifier", shortCutPath, Microsoft.Win32.RegistryValueKind.String)
                    'MsgBox("c:\windows\system32\cmd.exe /c """ + appPath + "")
                Else
                    With lnk
                        '.Arguments = "/?" '传递参数
                        .Description = "EVE提醒器"
                        .IconLocation = appLocation + "\run.exe,0" '图标
                        .TargetPath = appPath
                        '.WindowStyle = 7 '打开窗体的风格，最小化
                        .WorkingDirectory = appLocation '工作路径

                        .Save() '保存快捷方式
                    End With
                    My.Computer.Registry.SetValue(registryKey, "EVENotifier", shortCutPath, Microsoft.Win32.RegistryValueKind.String)
                End If
            Else
                Dim rk As RegistryKey = Registry.CurrentUser
                rk = rk.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
                If rk.GetValue("EVENotifier") <> Nothing Then
                    rk.DeleteValue("EVENotifier")
                End If
            End If
        Catch ex As Exception
            MsgBox("访问注册表出错." + Chr(13) & Chr(10) + "错误信息:" + ex.Message, MsgBoxStyle.Exclamation, "警告")
        End Try
    End Sub

    '启动后最小化
    Private Sub applyMinimize()
        If myOptions.opMinimize = True Then
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Edit.ShowDialog()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Dim indexes As ListView.SelectedIndexCollection = Me.ListView1.SelectedIndices
        If indexes.Count > 0 Then
            index = indexes(0)
            cmdEdit.Enabled = True
            cmdDel.Enabled = True
        Else
            cmdEdit.Enabled = False
            cmdDel.Enabled = False
        End If
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.BalloonTipClicked
        My.Computer.Audio.Stop()
    End Sub

    Private Sub NotifyIcon1_BalloonTipClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.BalloonTipClosed
        My.Computer.Audio.Stop()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
    End Sub

    '最小化隐藏任务栏按钮
    Private Sub Main_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.ShowInTaskbar = False
            'Me.NotifyIcon1.Visible = True
        Else
            'Me.NotifyIcon1.Visible = False
            Me.ShowInTaskbar = True
            'Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub showMain(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
    End Sub

    Private Sub 添加提醒AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Add.ShowDialog()
    End Sub

    Private Sub NotifyIcon1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseMove

        Dim timeTip As New System.Text.StringBuilder()
        For Each mytime As time In timeColl
            'timeTip += mytime.notiName + " - " + mytime.timeFinish + vbCrLf 'Chr(13) & Chr(10)
            timeTip = timeTip.Append(vbCrLf + mytime.notiName + " - " + mytime.timeFinish) 'Chr(13) & Chr(10)
        Next
        Dim txttip As String
        If timeTip.Length > 0 Then
            txttip = timeTip.Remove(0, 2).ToString
        Else
            txttip = "EVE提醒器"
        End If
        If txttip.Length >= 64 Then
            NotifyIcon1.Text = txttip.Substring(0, 60) + "..."
        Else
            NotifyIcon1.Text = txttip
        End If
    End Sub

    Private Sub showLoop(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 循环计时器LToolStripMenuItem1.Click
        frmloop.Show()
    End Sub

    Private Sub showOption(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 选项OToolStripMenuItem1.Click
        Options.ShowDialog()
    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Edit.ShowDialog()
    End Sub

    Private Sub del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        delAEvent()
    End Sub

    Private Sub event_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim mItem As ToolStripMenuItem

        mItem = CType(sender, ToolStripMenuItem)
        index = mItem.Name
        'MsgBox(index)
    End Sub

    Private Sub 检查更新UToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 检查更新UToolStripMenuItem.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        checkUpdate()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ' Initializes variables to pass to the MessageBox.Show method.
        Dim MessageHasNew As String = "现在有新版本,要转到下载页吗?"
        Dim MessageNoNew As String = "没有发现新版本."
        Dim Caption As String = "检查更新"
        Dim ButtonsHasNew As Integer = MessageBoxButtons.YesNo
        Dim ButtonsNoNew As Integer = MessageBoxButtons.OK
        Dim Result As DialogResult
        If newVer Then
            'Displays a MessageBox using the Question icon and specifying the No button as the default.
            Result = MessageBox.Show(Me, MessageHasNew, Caption, ButtonsHasNew)

            ' Gets the result of the MessageBox display.
            If Result = Windows.Forms.DialogResult.Yes Then
                System.Diagnostics.Process.Start("http://sites.google.com/site/huximssoft/Home/eve-ti-xing-qi-net-1/xia-zai")
            End If
        Else
            MessageBox.Show(Me, MessageNoNew, Caption, ButtonsNoNew)
        End If
    End Sub

    Private Sub delAEvent()
        ' Initializes variables to pass to the MessageBox.Show method.

        Dim Message As String = "真的要删除'" + timeColl.Item(index + 1).notiName + "'么?"
        Dim Caption As String = "确认"
        Dim Buttons As Integer = MessageBoxButtons.YesNo
        Dim Result As DialogResult

        'Displays a MessageBox using the Question icon and specifying the No button as the default.
        Result = MessageBox.Show(Me, Message, Caption, MessageBoxButtons.YesNo)

        ' Gets the result of the MessageBox display.
        If Result = Windows.Forms.DialogResult.Yes Then

            ' 删除记录
            timeColl.Remove(index + 1)
            'MessageBox.Show("已删除!")
            savetime()
            showTimes()
            ListView1.Focus()
            If index > 0 Then
                ListView1.Items(index - 1).Selected = True
            ElseIf index = 0 Then
                If ListView1.Items.Count > 0 Then
                    ListView1.Items(index).Selected = True
                End If
            End If
            If myOptions.opGCalendar Then
                Dim threadUpdateGoocal As New System.Threading.Thread(AddressOf updateGooCal)
                threadUpdateGoocal.Start()
            End If

            If timeColl.Count = 0 Then
                cmdDel.Enabled = False
                cmdEdit.Enabled = False
            End If
        End If
    End Sub
End Class
