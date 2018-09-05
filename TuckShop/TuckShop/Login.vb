Public Class Login
    Dim timep As DateTime = TimeOfDay
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim RegExit As DialogResult
        RegExit = MsgBox("Are you sure you want to Exit!!", MsgBoxStyle.YesNo, "Attention Please")
        If DialogResult.Yes Then

            MsgBox("Thank you very much please call again")
            Application.Exit()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        If btnLogin.Text = "Click Here  to Login" Then
            btnLogin.Text = "Login"
            gLoginForm.Visible = True
            lblWel.Visible = False
            lblUser.Visible = True
            lblUser.Text = "User Login"

        End If
        If txtUser.Text = "" Then
            MsgBox("Username is required Please", MsgBoxStyle.Critical)

        ElseIf txtPass.Text = "" Then

            MsgBox("Password is required Please", MsgBoxStyle.Critical)


        Else
            sql = "SELECT * FROM `users` WHERE `Username`='" & txtUser.Text & "' AND `Password`='" & txtPass.Text & "' "
            tuckfindthis(sql)

            If GetNumRows() = 1 Then
                MsgBox("Logged in Successfully", MsgBoxStyle.Information)
                LoadSingleResult("login")
                txtPass.Text = ""
                txtUser.Text = ""

            Else
                MsgBox("Username or Passwrord is not correct, Please try again!!", MsgBoxStyle.Critical)

                txtPass.Text = ""
                txtUser.Text = ""

            End If
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWel.Visible = True
        If timep.Hour < 12 Then
            MsgBox("Good morning welcome back your time is  " & TimeOfDay)
        ElseIf timep.Hour >= 12 And timep.Hour <= 15 Then
            MsgBox("Good afternoon welcome back your time is  " & TimeOfDay)
        Else
            MsgBox("Good evening welcome back your time is   " & TimeOfDay)
        End If
    End Sub
End Class
