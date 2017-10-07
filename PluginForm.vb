Imports NeonScripting

Public Class PluginForm

    Dim _currentId As Integer = -1
    Private _host As INeonScriptHost = Nothing
    Public Property ScriptHost As INeonScriptHost
        Get
            Return _host
        End Get
        Set
            _host = value
        End Set
    End Property

    Public Sub Populate()
        ListBox1.Items.Clear()
        For Each item In _host.RemoteCalls.TracksInPlayQueue()
            ListBox1.Items.Add($"{item.Artist} - {item.Title}")
        Next
    End Sub

    Private Sub PrevButton_Click(sender As Object, e As EventArgs) Handles PrevButton.Click
        _host.RemoteCalls.Previous()
        Populate()
    End Sub

    Private Sub ButtonPlay_Click(sender As Object, e As EventArgs) Handles ButtonPlay.Click
        _host.RemoteCalls.Play(0)
    End Sub

    Private Sub PauseButton_Click(sender As Object, e As EventArgs) Handles PauseButton.Click
        _host.RemoteCalls.Pause()
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        _host.RemoteCalls.Stop()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        _host.RemoteCalls.Next()
        Populate()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Stopped = 3
        ' Paused = 2
        ' Playing = 1
        ' Undefined = 0
        If _host.RemoteCalls.PlayerState <> 3 Then
            Dim track = _host.RemoteCalls.ActiveTrack
            If track IsNot Nothing  
                Dim id = track.DetailId
                If id <> _currentId Then
                    _currentId = id
                    NowPlayingLabel.Text = $"{track.Artist} - {track.Title}"
                End If
            End If
            DurationLabel.Text = $"{_host.RemoteCalls.CurrentPosition.ToString()}/{_host.RemoteCalls.Duration.ToString()}"
        End If
    End Sub

    Private Sub PluginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDoubleClick
        _host.RemoteCalls.Play(ListBox1.SelectedIndex)
        Populate()
    End Sub
End Class