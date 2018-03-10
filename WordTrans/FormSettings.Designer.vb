<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxAppID = New System.Windows.Forms.TextBox()
        Me.TextBoxAppKey = New System.Windows.Forms.TextBox()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonSign = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AppID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "AppKey:"
        '
        'TextBoxAppID
        '
        Me.TextBoxAppID.Location = New System.Drawing.Point(134, 49)
        Me.TextBoxAppID.Name = "TextBoxAppID"
        Me.TextBoxAppID.Size = New System.Drawing.Size(217, 21)
        Me.TextBoxAppID.TabIndex = 2
        '
        'TextBoxAppKey
        '
        Me.TextBoxAppKey.Location = New System.Drawing.Point(134, 88)
        Me.TextBoxAppKey.Name = "TextBoxAppKey"
        Me.TextBoxAppKey.Size = New System.Drawing.Size(217, 21)
        Me.TextBoxAppKey.TabIndex = 3
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(90, 139)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 4
        Me.ButtonOK.Text = "确定"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(176, 139)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClear.TabIndex = 5
        Me.ButtonClear.Text = "清空"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonSign
        '
        Me.ButtonSign.Location = New System.Drawing.Point(261, 139)
        Me.ButtonSign.Name = "ButtonSign"
        Me.ButtonSign.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSign.TabIndex = 6
        Me.ButtonSign.Text = "注册"
        Me.ButtonSign.UseVisualStyleBackColor = True
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 211)
        Me.Controls.Add(Me.ButtonSign)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.TextBoxAppKey)
        Me.Controls.Add(Me.TextBoxAppID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(430, 250)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(430, 250)
        Me.Name = "FormSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSettings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TextBoxAppID As Windows.Forms.TextBox
    Friend WithEvents TextBoxAppKey As Windows.Forms.TextBox
    Friend WithEvents ButtonOK As Windows.Forms.Button
    Friend WithEvents ButtonClear As Windows.Forms.Button
    Friend WithEvents ButtonSign As Windows.Forms.Button
End Class
