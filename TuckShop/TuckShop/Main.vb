Public Class Main
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Application.Exit()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Student_account.MdiParent = Me
        Student_account.Show()
        PictureBox1.Visible = False
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        StudentList.MdiParent = Me
        StudentList.Show()
        PictureBox1.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Supplier.MdiParent = Me
        Supplier.Show()
        PictureBox1.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SupplierList.MdiParent = Me
        SupplierList.Show()
        PictureBox1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Product_Entry.MdiParent = Me
        Product_Entry.Show()
        PictureBox1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Product_List.MdiParent = Me
        Product_List.Show()
        PictureBox1.Visible = False
    End Sub


    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Dim RegExit As DialogResult
        RegExit = MsgBox("Are you sure you want to Logout!!", MsgBoxStyle.YesNo, "Attention Please")
        If DialogResult.Yes Then
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Batch_Entry.MdiParent = Me
        Batch_Entry.Show()
        PictureBox1.Visible = False
    End Sub
End Class