Public Class FormResult

    Private Sub FormResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormResult_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.TextBoxResult.Height = Me.Height - 91
        Me.TextBoxResult.Width = Me.Width - 40
        Me.ButtonCopyAndClose.Left = Me.Width - 135
        Me.ButtonCopyAndClose.Top = Me.Height - 73
    End Sub

    Private Sub ButtonCopyAndClose_Click(sender As Object, e As EventArgs) Handles ButtonCopyAndClose.Click
        Windows.Forms.Clipboard.SetText(TextBoxResult.Text)
        Me.Dispose()
    End Sub
End Class