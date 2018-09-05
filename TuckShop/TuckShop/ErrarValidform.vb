Public Class ErrarValidform
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Product_Entry.Hide()
        Main.PictureBox1.Visible = True
    End Sub
End Class