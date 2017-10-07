<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PluginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NowPlayingLabel = New System.Windows.Forms.Label()
        Me.PrevButton = New System.Windows.Forms.Button()
        Me.ButtonPlay = New System.Windows.Forms.Button()
        Me.PauseButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DurationLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Play queue"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = true
        Me.ListBox1.Location = New System.Drawing.Point(16, 29)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(535, 186)
        Me.ListBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Now playing"
        '
        'NowPlayingLabel
        '
        Me.NowPlayingLabel.AutoSize = true
        Me.NowPlayingLabel.Location = New System.Drawing.Point(13, 234)
        Me.NowPlayingLabel.Name = "NowPlayingLabel"
        Me.NowPlayingLabel.Size = New System.Drawing.Size(10, 13)
        Me.NowPlayingLabel.TabIndex = 3
        Me.NowPlayingLabel.Text = "-"
        '
        'PrevButton
        '
        Me.PrevButton.Location = New System.Drawing.Point(16, 267)
        Me.PrevButton.Name = "PrevButton"
        Me.PrevButton.Size = New System.Drawing.Size(75, 23)
        Me.PrevButton.TabIndex = 4
        Me.PrevButton.Text = "<"
        Me.PrevButton.UseVisualStyleBackColor = true
        '
        'ButtonPlay
        '
        Me.ButtonPlay.Location = New System.Drawing.Point(97, 267)
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPlay.TabIndex = 5
        Me.ButtonPlay.Text = "Play"
        Me.ButtonPlay.UseVisualStyleBackColor = true
        '
        'PauseButton
        '
        Me.PauseButton.Location = New System.Drawing.Point(178, 267)
        Me.PauseButton.Name = "PauseButton"
        Me.PauseButton.Size = New System.Drawing.Size(75, 23)
        Me.PauseButton.TabIndex = 6
        Me.PauseButton.Text = "Pause"
        Me.PauseButton.UseVisualStyleBackColor = true
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(259, 267)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(75, 23)
        Me.StopButton.TabIndex = 7
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = true
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(340, 267)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 8
        Me.NextButton.Text = ">"
        Me.NextButton.UseVisualStyleBackColor = true
        '
        'Timer1
        '
        '
        'DurationLabel
        '
        Me.DurationLabel.AutoSize = true
        Me.DurationLabel.Location = New System.Drawing.Point(13, 251)
        Me.DurationLabel.Name = "DurationLabel"
        Me.DurationLabel.Size = New System.Drawing.Size(18, 13)
        Me.DurationLabel.TabIndex = 9
        Me.DurationLabel.Text = "-/-"
        '
        'PluginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 314)
        Me.Controls.Add(Me.DurationLabel)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.PauseButton)
        Me.Controls.Add(Me.ButtonPlay)
        Me.Controls.Add(Me.PrevButton)
        Me.Controls.Add(Me.NowPlayingLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PluginForm"
        Me.Text = "Helium 13 General Plugin (VisualBasic.NET)"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents ListBox1 As Windows.Forms.ListBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents NowPlayingLabel As Windows.Forms.Label
    Friend WithEvents PrevButton As Windows.Forms.Button
    Friend WithEvents ButtonPlay As Windows.Forms.Button
    Friend WithEvents PauseButton As Windows.Forms.Button
    Friend WithEvents StopButton As Windows.Forms.Button
    Friend WithEvents NextButton As Windows.Forms.Button
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents DurationLabel As Windows.Forms.Label
End Class
