Imports ImGeneralPluginEngine
Imports NeonScripting

Public Class Class1
    Implements IImGeneralPlugin

    Public Sub InitializePlugin(host As INeonScriptHost, PluginCloseAction As Action(Of IImGeneralPlugin)) Implements IImGeneralPlugin.InitializePlugin
        ' Place any custom plugin logic here
        Dim dlg = New PluginForm
        dlg.ScriptHost = host
        dlg.Populate()
        dlg.ShowDialog
        PluginCloseAction?.Invoke(me)
    End Sub

    Public Sub OnEvent(eventType As NeonEventTypes) Implements IImGeneralPlugin.OnEvent
    End Sub

    Public Sub ClosePlugin() Implements IImGeneralPlugin.ClosePlugin
    End Sub

    Public ReadOnly Property Name As String Implements IImGeneralPlugin.Name
        Get
            Return "Sample VisualBasic plugin"
        End Get
    End Property

    Public ReadOnly Property Author As String Implements IImGeneralPlugin.Author
        Get
            Return "Mikael Stalvik"
        End Get
    End Property

End Class
