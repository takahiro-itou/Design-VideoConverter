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
        SplitContainer1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        SplitContainer1.Location = New Point(12, 410)
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
        SplitContainer1.Size = New Size(615, 135)
        SplitContainer1.SplitterDistance = 203
        SplitContainer1.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.Location = New Point(64, 15)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(126, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(14, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox2.Location = New Point(62, 15)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(339, 23)
        TextBox2.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 0
        Label2.Text = "Label2"
        ' 
        ' VideoConfig1
        ' 
        VideoConfig1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        VideoConfig1.Font = New Font("ＭＳ ゴシック", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        VideoConfig1.Location = New Point(0, 0)
        VideoConfig1.MaximumSize = New Size(0, 104)
        VideoConfig1.MinimumSize = New Size(532, 104)
        VideoConfig1.Name = "VideoConfig1"
        VideoConfig1.Size = New Size(532, 104)
        VideoConfig1.TabIndex = 2
        ' 
        ' AudioConfig1
        ' 
        AudioConfig1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        AudioConfig1.Font = New Font("ＭＳ ゴシック", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        AudioConfig1.Location = New Point(0, 125)
        AudioConfig1.MaximumSize = New Size(0, 104)
        AudioConfig1.MinimumSize = New Size(532, 104)
        AudioConfig1.Name = "AudioConfig1"
        AudioConfig1.Size = New Size(614, 104)
        AudioConfig1.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(688, 583)
        Controls.Add(AudioConfig1)
        Controls.Add(VideoConfig1)
        Controls.Add(SplitContainer1)
        Name = "Form1"
        Text = "Form1"
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
