Partial Class RibbonMain
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()> _
   Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Windows.Forms 类撰写设计器支持所必需的
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        '组件设计器需要此调用。
        InitializeComponent()

    End Sub

    '组件重写释放以清理组件列表。
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

    '组件设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是组件设计器所必需的
    '可使用组件设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tab1 = Me.Factory.CreateRibbonTab
        Me.Group1 = Me.Factory.CreateRibbonGroup
        Me.ButtonToChs = Me.Factory.CreateRibbonButton
        Me.ButtonToEng = Me.Factory.CreateRibbonButton
        Me.SplitButtonMoreTrans = Me.Factory.CreateRibbonSplitButton
        Me.Button1 = Me.Factory.CreateRibbonButton
        Me.Button2 = Me.Factory.CreateRibbonButton
        Me.Button3 = Me.Factory.CreateRibbonButton
        Me.Group2 = Me.Factory.CreateRibbonGroup
        Me.ButtonSetup = Me.Factory.CreateRibbonButton
        Me.Button4 = Me.Factory.CreateRibbonButton
        Me.Tab1.SuspendLayout()
        Me.Group1.SuspendLayout()
        Me.Group2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab1
        '
        Me.Tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
        Me.Tab1.Groups.Add(Me.Group1)
        Me.Tab1.Groups.Add(Me.Group2)
        Me.Tab1.Label = "翻译"
        Me.Tab1.Name = "Tab1"
        '
        'Group1
        '
        Me.Group1.Items.Add(Me.ButtonToChs)
        Me.Group1.Items.Add(Me.ButtonToEng)
        Me.Group1.Items.Add(Me.SplitButtonMoreTrans)
        Me.Group1.Label = "翻译"
        Me.Group1.Name = "Group1"
        '
        'ButtonToChs
        '
        Me.ButtonToChs.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.ButtonToChs.Image = Global.WordTrans.My.Resources.PubRes.ImageE2C
        Me.ButtonToChs.Label = "自动翻译为中文"
        Me.ButtonToChs.Name = "ButtonToChs"
        Me.ButtonToChs.ShowImage = True
        '
        'ButtonToEng
        '
        Me.ButtonToEng.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.ButtonToEng.Image = Global.WordTrans.My.Resources.PubRes.ImageC2E
        Me.ButtonToEng.Label = "自动翻译为英文"
        Me.ButtonToEng.Name = "ButtonToEng"
        Me.ButtonToEng.ShowImage = True
        '
        'SplitButtonMoreTrans
        '
        Me.SplitButtonMoreTrans.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.SplitButtonMoreTrans.Image = Global.WordTrans.My.Resources.PubRes.ImageMore
        Me.SplitButtonMoreTrans.Items.Add(Me.Button1)
        Me.SplitButtonMoreTrans.Items.Add(Me.Button2)
        Me.SplitButtonMoreTrans.Items.Add(Me.Button3)
        Me.SplitButtonMoreTrans.Label = "更多翻译"
        Me.SplitButtonMoreTrans.Name = "SplitButtonMoreTrans"
        '
        'Button1
        '
        Me.Button1.Label = "Button1"
        Me.Button1.Name = "Button1"
        Me.Button1.ShowImage = True
        '
        'Button2
        '
        Me.Button2.Label = "Button2"
        Me.Button2.Name = "Button2"
        Me.Button2.ShowImage = True
        '
        'Button3
        '
        Me.Button3.Label = "Button3"
        Me.Button3.Name = "Button3"
        Me.Button3.ShowImage = True
        '
        'Group2
        '
        Me.Group2.Items.Add(Me.ButtonSetup)
        Me.Group2.Items.Add(Me.Button4)
        Me.Group2.Label = "设置"
        Me.Group2.Name = "Group2"
        '
        'ButtonSetup
        '
        Me.ButtonSetup.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.ButtonSetup.Image = Global.WordTrans.My.Resources.PubRes.ImageSettings
        Me.ButtonSetup.Label = "配置"
        Me.ButtonSetup.Name = "ButtonSetup"
        Me.ButtonSetup.ShowImage = True
        '
        'Button4
        '
        Me.Button4.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge
        Me.Button4.Image = Global.WordTrans.My.Resources.PubRes.ImageSign
        Me.Button4.Label = "注册ID"
        Me.Button4.Name = "Button4"
        Me.Button4.ShowImage = True
        '
        'Ribbon1
        '
        Me.Name = "Ribbon1"
        Me.RibbonType = "Microsoft.Word.Document"
        Me.Tabs.Add(Me.Tab1)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.Group1.ResumeLayout(False)
        Me.Group1.PerformLayout()
        Me.Group2.ResumeLayout(False)
        Me.Group2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab1 As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Group1 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents ButtonToChs As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents ButtonToEng As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents SplitButtonMoreTrans As Microsoft.Office.Tools.Ribbon.RibbonSplitButton
    Friend WithEvents ButtonSetup As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button4 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button1 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button2 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button3 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Group2 As Microsoft.Office.Tools.Ribbon.RibbonGroup
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property Ribbon1() As RibbonMain
        Get
            Return Me.GetRibbon(Of RibbonMain)()
        End Get
    End Property
End Class
