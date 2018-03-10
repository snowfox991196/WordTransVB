Imports Microsoft.Office.Tools.Ribbon
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json


Public Class RibbonMain
    Shared translater As New TransHelper
    Dim frm As FormSettings
    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load
        'Dim settingspath As String = Environment.GetEnvironmentVariable("TEMP") & My.Resources.PubRes.StringSettingPath
        'If IO.File.Exists(settingspath) Then
        '    Dim textbuffer As String = IO.File.ReadAllText(settingspath)
        '    Dim settingset As JObject = CType(JsonConvert.DeserializeObject(textbuffer), JObject)
        '    If settingset IsNot Nothing Then
        '        If settingset.ContainsKey("appid") Then
        '            translater.SetAppid(settingset("appid").ToString)
        '        End If
        '        If settingset.ContainsKey("appkey") Then
        '            translater.SetKey(settingset("appkey").ToString)
        '        End If
        '    End If
        'Else
        '    'MsgBox("配置文件不存在，请先设置appid")
        'End If
        'translater.SetAppid("")
        'translater.SetKey("")
        InitSettings()
    End Sub
    Private Sub ButtonToChs_Click(sender As Object, e As RibbonControlEventArgs) Handles ButtonToChs.Click
        'Dim frmRslt As New FormResult
        'Dim http As New HttpHelper
        'Dim transer As New TransHelper
        'Dim stringtoget As String
        'frmRslt.TextBoxResult.Text = "正在初始化模块..."
        'frmRslt.Show()
        'With transer
        '    .initSalt()
        '    .setAppid("")
        '    .setKey("")
        'End With
        'frmRslt.TextBoxResult.Text = frmRslt.TextBoxResult.Text & vbCrLf & "初始化完成..."
        'frmRslt.Refresh()
        'stringtoget = Globals.ThisAddIn.Application.Selection.Text
        'If stringtoget <> "" Then
        '    frmRslt.TextBoxResult.Text = frmRslt.TextBoxResult.Text & vbCrLf & "正在与服务器通信..."
        '    frmRslt.Refresh()
        '    Dim empData As String = http.HttpPost(My.Resources.PubRes.StringTransURL, transer.getParams(stringtoget))
        '    frmRslt.TextBoxResult.Text = frmRslt.TextBoxResult.Text & vbCrLf & "正在处理结果集..."
        '    frmRslt.Refresh()
        '    Dim resulttempset As JObject = CType(JsonConvert.DeserializeObject(empData), JObject)
        '    Dim resulttempstring As String = resulttempset("trans_result").ToString
        '    Dim resultstring As String = Mid(resulttempstring, 2, resulttempstring.Length - 2)
        '    Dim resultset As JObject = CType(JsonConvert.DeserializeObject(resultstring), JObject)
        '    frmRslt.TextBoxResult.Text = resultset("dst").ToString
        '    'frmRslt.TextBoxResult.Text = resultstring
        '    frmRslt.Refresh()
        'Else
        '    MsgBox("未选中内容")
        'End If

        Dim frmRslt As New FormResult
        Dim stringtoget As String
        stringtoget = Globals.ThisAddIn.Application.Selection.Text
        If stringtoget <> "" & stringtoget.Length <= 255 Then
            frmRslt.TextBoxResult.Text = translater.Translate(stringtoget, "auto", "zh")
            frmRslt.Show()
        ElseIf stringtoget = "" Then
            MsgBox("未选中内容")
            frmRslt.Dispose()
        Else
            MsgBox("为了保证翻译结果准确，请选择小于255个字符")
            frmRslt.Dispose()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As RibbonControlEventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start(My.Resources.PubRes.StringSignURL)
    End Sub

    Private Sub ButtonToEng_Click(sender As Object, e As RibbonControlEventArgs) Handles ButtonToEng.Click
        Dim frmRslt As New FormResult
        Dim stringtoget As String
        stringtoget = Globals.ThisAddIn.Application.Selection.Text
        If stringtoget <> "" & stringtoget.Length <= 255 Then
            frmRslt.TextBoxResult.Text = translater.Translate(stringtoget, "auto", "en")
            frmRslt.Show()
        ElseIf stringtoget = "" Then
            MsgBox("未选中内容")
            frmRslt.Dispose()
        Else
            MsgBox("为了保证翻译结果准确，请选择小于255个字符")
            frmRslt.Dispose()
        End If
    End Sub

    Private Sub ButtonSetup_Click(sender As Object, e As RibbonControlEventArgs) Handles ButtonSetup.Click
        If frm Is Nothing OrElse frm.IsDisposed Then
            frm = New FormSettings
            frm.Show()
        Else
            MsgBox("有未关闭的设置窗口", vbOKOnly + vbInformation)
        End If
    End Sub

    Public Shared Sub InitSettings()
        Dim settingspath As String = Environment.GetEnvironmentVariable("TEMP") & My.Resources.PubRes.StringSettingPath
        If IO.File.Exists(settingspath) Then
            Dim textbuffer As String = IO.File.ReadAllText(settingspath)
            Dim settingset As JObject = CType(JsonConvert.DeserializeObject(textbuffer), JObject)
            If settingset IsNot Nothing Then
                If settingset.ContainsKey("appid") Then
                    translater.SetAppid(settingset("appid").ToString)
                End If
                If settingset.ContainsKey("appkey") Then
                    translater.SetKey(settingset("appkey").ToString)
                End If
            End If
        Else
            'MsgBox("配置文件不存在，请先设置appid")
        End If
    End Sub

End Class
