Public Class Product_Entry

    Private Sub List_Click_1(sender As Object, e As EventArgs) Handles List.Click
        Dim RegExit As DialogResult
        RegExit = MsgBox("Are you sure you want to close me!!", MsgBoxStyle.YesNo, "Attention Please")
        If DialogResult.Yes Then
            Me.Close()
            Main.PictureBox1.Visible = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtCusName.Text = "Mango" Then
            Success.Show()
        Else
            ErrarValidform.Show()
        End If
    End Sub
End Class