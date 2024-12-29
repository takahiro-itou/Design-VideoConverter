<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        VideoConfig1 = New WinFormsControl.VideoConfig()
        AudioConfig1 = New WinFormsControl.AudioConfig()
        SuspendLayout()
        ' 
        ' VideoConfig1
        ' 
        resources.ApplyResources(VideoConfig1, "VideoConfig1")
        VideoConfig1.Name = "VideoConfig1"
        ' 
        ' AudioConfig1
        ' 
        resources.ApplyResources(AudioConfig1, "AudioConfig1")
        AudioConfig1.Name = "AudioConfig1"
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        resources.ApplyResources(Me, "$this")
        Controls.Add(AudioConfig1)
        Controls.Add(VideoConfig1)
        Name = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents VideoConfig1 As WinFormsControl.VideoConfig
    Friend WithEvents AudioConfig1 As WinFormsControl.AudioConfig

End Class
