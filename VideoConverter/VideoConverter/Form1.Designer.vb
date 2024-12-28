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
        SplitContainer1 = New SplitContainer()
        TextBox1 = New TextBox()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        VideoConfig1 = New WinFormsControl.VideoConfig()
        AudioConfig1 = New WinFormsControl.AudioConfig()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        resources.ApplyResources(SplitContainer1, "SplitContainer1")
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.BackColor = SystemColors.Window
        SplitContainer1.Panel1.Controls.Add(TextBox1)
        SplitContainer1.Panel1.Controls.Add(Label1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.BackColor = Color.Red
        SplitContainer1.Panel2.Controls.Add(TextBox2)
        SplitContainer1.Panel2.Controls.Add(Label2)
        ' 
        ' TextBox1
        ' 
        resources.ApplyResources(TextBox1, "TextBox1")
        TextBox1.Name = "TextBox1"
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"
        ' 
        ' TextBox2
        ' 
        resources.ApplyResources(TextBox2, "TextBox2")
        TextBox2.Name = "TextBox2"
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.Name = "Label2"
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
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(AudioConfig1)
        Controls.Add(VideoConfig1)
        Controls.Add(SplitContainer1)
        Name = "Form1"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents VideoConfig1 As WinFormsControl.VideoConfig
    Friend WithEvents AudioConfig1 As WinFormsControl.AudioConfig

End Class
