Public Class Form1
    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub SplitContainer1_Resize(sender As Object, e As EventArgs) Handles SplitContainer1.Resize
        TextBox1.Text = SplitContainer1.Panel1.Width
        TextBox2.Text = SplitContainer1.Panel2.Width
    End Sub
End Class
