Imports System.Data.OleDb
Public Class frmLogin

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try

            sqL = "SELECT * FROM Users WHERE Username = '" & txtUser.Text & "' AND pwd = '" & txtPwd.Text & "'"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)

            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            If dr.Read = True Then

                frmMain.lblEmployeeNo.Text = dr("StaffID")

                frmMain.ToolStripButton6.Enabled = True
                frmMain.ToolStripButton4.Enabled = True
                frmMain.ManageToolStripMenuItem.Enabled = True
                'frmMain.TransactionToolStripMenuItem.Enabled = False
                frmMain.SalesReportToolStripMenuItem.Enabled = True
                frmMain.MenuStrip1.Visible = True
                frmMain.ToolStrip1.Visible = True

                txtUser.Text = ""
                txtPwd.Text = ""
                Me.Close()
            ElseIf txtUser.Text = "user" And txtPwd.Text = "password" Then
                MsgBox("Welcome Cashier")
                frmMain.ToolStripButton6.Enabled = False
                frmMain.ToolStripButton4.Enabled = False
                frmMain.ManageToolStripMenuItem.Enabled = False
                'frmMain.TransactionToolStripMenuItem.Enabled = False
                frmMain.SalesReportToolStripMenuItem.Enabled = False
                frmMain.MenuStrip1.Visible = True
                frmMain.ToolStrip1.Visible = True

                txtUser.Text = ""
                txtPwd.Text = ""
                Me.Close()
            Else
                MsgBox("Incorrect username or password!", MsgBoxStyle.Critical, "Login")
                txtPwd.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        If MsgBox("Are you sure you want to close?", MsgBoxStyle.YesNo, "Close Window") = MsgBoxResult.Yes Then
            Me.Close()
            frmMain.Close()
        End If
        txtUser.Focus()
    End Sub
End Class
