Public Class StudentList
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim RegExit As DialogResult
        RegExit = MsgBox("Are you sure you want to close me!!", MsgBoxStyle.YesNo, "Attention Please")
        If RegExit = DialogResult.Yes Then
            Me.Close()
            Main.PictureBox1.Visible = True
        End If
    End Sub

    Private Sub StudentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tuckfindthis("SELECT `studID`, `name`,`surname`, `gender`, `class` FROM `customer`")
        LoadData(studentGrid, "students")
    End Sub

    Private Sub StudentList_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tuckfindthis("SELECT  COUNT(*) FROM `customer`")
        Dim numberOfStudent = GetCount()
        lblTotal.Text = numberOfStudent
    End Sub
End Class