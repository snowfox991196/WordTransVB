Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json

Public Class FormSettings
    Dim settingspath As String = Environment.GetEnvironmentVariable("TEMP") & My.Resources.PubRes.StringSettingPath
    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists(settingspath) Then
            If IO.File.Exists(settingspath) Then
                Dim textbuffer As String = IO.File.ReadAllText(settingspath)
                Dim settingset As JObject = CType(JsonConvert.DeserializeObject(textbuffer), JObject)
                If settingset IsNot Nothing Then
                    If settingset.ContainsKey("appid") Then
                        TextBoxAppID.Text = settingset("appid").ToString
                    End If
                    If settingset.ContainsKey("appkey") Then
                        TextBoxAppKey.Text = settingset("appkey").ToString
                    End If
                End If
            Else
                'MsgBox("配置文件不存在，请先设置appid")
            End If
        End If
    End Sub

    Private Sub FormSettings_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim settings As New JObject
        settings("appid") = TextBoxAppID.Text
        settings("appkey") = TextBoxAppKey.Text
        If IO.File.Exists(settingspath) Then
            IO.File.Delete(settingspath)
        End If
        Dim filewriter As IO.StreamWriter = New IO.StreamWriter(settingspath, True, Encoding.Default)
        filewriter.Write(settings.ToString)
        filewriter.Close()
        RibbonMain.InitSettings()
        Me.Dispose()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxAppID.Text = ""
        TextBoxAppKey.Text = ""
    End Sub

    Private Sub ButtonSign_Click(sender As Object, e As EventArgs) Handles ButtonSign.Click
        Diagnostics.Process.Start(My.Resources.PubRes.StringSignURL)
    End Sub
End Class