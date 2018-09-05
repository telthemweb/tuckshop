Public Class frmMain

    Private Sub ProductsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsToolStripMenuItem.Click
        frmItem.ShowDialog()
    End Sub
    Private Sub TransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionToolStripMenuItem.Click
        frmtransaction.Show()
        frmtransaction.Close()
        frmtransaction.ShowDialog()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MenuStrip1.Visible = False

        lblDate.Text = Date.Now.ToString("dddd") & " - " & Date.Now.ToString("MMM dd, yyyy")
        frmLogin.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTIme.Text = Format(Date.Now, "Long Time")
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        MsgBox("Have a Good Day")
        MenuStrip1.Visible = False
        ToolStrip1.Visible = False
        frmLogin.ShowDialog()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tllogout.Click
        MsgBox("Have a Good Day")
        MenuStrip1.Visible = False
        ToolStrip1.Visible = False
        frmLogin.ShowDialog()

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click

        frmtransaction.ShowDialog()
    End Sub
    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        frmItem.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        frmtransactiondetail.ShowDialog()
    End Sub

    Private Sub SalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReportToolStripMenuItem.Click
        frmtransactiondetail.ShowDialog()
    End Sub
End Class
