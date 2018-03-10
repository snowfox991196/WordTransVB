<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormResult
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxResult = New System.Windows.Forms.TextBox()
        Me.ButtonCopyAndClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxResult
        '
        Me.TextBoxResult.Location = New System.Drawing.Point(12, 12)
        Me.TextBoxResult.Multiline = True
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxResult.Size = New System.Drawing.Size(260, 209)
        Me.TextBoxResult.TabIndex = 0
        '
        'ButtonCopyAndClose
        '
        Me.ButtonCopyAndClose.Location = New System.Drawing.Point(165, 227)
        Me.ButtonCopyAndClose.Name = "ButtonCopyAndClose"
        Me.ButtonCopyAndClose.Size = New System.Drawing.Size(107, 23)
        Me.ButtonCopyAndClose.TabIndex = 1
        Me.ButtonCopyAndClose.Text = "复制并关闭"
        Me.ButtonCopyAndClose.UseVisualStyleBackColor = True
        '
        'FormResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ButtonCopyAndClose)
        Me.Controls.Add(Me.TextBoxResult)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "FormResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "翻译结果"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxResult As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCopyAndClose As System.Windows.Forms.Button
End Class
