Public Class FormSettings
    Dim settingspath As String = Environment.GetEnvironmentVariable("TEMP") & My.Resources.PubRes.StringSettingPath
    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IO.File.Exists(settingspath) Then
            IO.File.Create(settingspath)
        End If
    End Sub

    Private Sub FormSettings_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxAppID.Text = ""
        TextBoxAppKey.Text = ""
    End Sub
End Class