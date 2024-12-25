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
        VideoConfig1 = New WinFormsControl.VideoConfig()
        SuspendLayout()
        ' 
        ' VideoConfig1
        ' 
        VideoConfig1.Font = New Font("ＭＳ ゴシック", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        VideoConfig1.Location = New Point(12, 12)
        VideoConfig1.Name = "VideoConfig1"
        VideoConfig1.Size = New Size(707, 360)
        VideoConfig1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 570)
        Controls.Add(VideoConfig1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents VideoConfig1 As WinFormsControl.VideoConfig

End Class
