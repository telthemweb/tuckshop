Imports System.Data.OleDb
Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text = "" Then
            MsgBox("Please Username is required!", MsgBoxStyle.Critical, "Error")
            Exit Sub
        ElseIf txtPass.Text = "" Then
            MsgBox("Please Password is required!", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\gament.accdb")
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Users WHERE Username = '" & txtUser.Text & "' AND [Password] = '" & txtPass.Text & "' AND  UserType ='" & cmbtypr.Text & "' ", con)
        Dim user As String = ""
        Dim pass As String = ""
        Dim rolep As String = ""

        con.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        Try
            If (sdr.Read = True) Then
                user = sdr("Username")
                pass = sdr("Password")
                rolep = sdr("UserType")

                If rolep = "Administrator" Then
                    MsgBox("You are logged in Successfully ,Please welcome Administrator", MsgBoxStyle.Information, "Successful")
                    MainPage.btnLog.Text = (rolep) & " " & "Log Out"
                    MainPage.Show()
                    Me.Hide()
                    IsUserLoggedIn = True
                ElseIf rolep = "Manager" Then
                    MsgBox("You are logged in Successfully, Please welcome Manager", MsgBoxStyle.Information, "Successful")
                    MainPage.btnLog.Text = (rolep) & " " & "Log Out"
                    MainPage.Show()
                    Me.Hide()
                    IsUserLoggedIn = True

                Else
                    MsgBox("Please contact System Administrator", MsgBoxStyle.Critical, "System Error")
                    txtPass.Clear()
                    txtUser.Clear()
                    cmbtypr.ResetText()
                End If
            Else
                MsgBox("Incorrect credentials", MsgBoxStyle.Critical, "System Error")
                txtPass.Clear()
                txtUser.Clear()
                cmbtypr.ResetText()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub


End Class
