Public Class Student_account
    Private Sub Student_account_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub List_Click(sender As Object, e As EventArgs) Handles List.Click
        Dim RegExit As DialogResult
        RegExit = MsgBox("Are you sure you want to close me!!", MsgBoxStyle.YesNo, "Attention Please")
        If DialogResult.Yes Then
            Me.Close()
            Main.PictureBox1.Visible = True
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        If btnReg.Text = "Register" Then
            'select all records in the database
            tuckfindthis("SELECT COUNT(*) FROM `customer` WHERE `studID`='" & txtID.Text & "'")

            'check if the id is already exist in the database
            If GetCount() > 0 Then
                MsgBox("Student ID Number is already exist Please try something new!", MsgBoxStyle.Critical)
            Else
                'checking for empty textboxes and show error
                If txtID.Text = "" Then
                    MsgBox("Student ID Number is Required!", MsgBoxStyle.Critical)
                ElseIf txtName.Text = "" Then
                    MsgBox("Name is Required!", MsgBoxStyle.Critical)
                ElseIf txtSurnm.Text = "" Then
                    MsgBox("Surame is Required!", MsgBoxStyle.Critical)

                ElseIf cmbgender.Text = "" Then
                    MsgBox("Please select gender!", MsgBoxStyle.Critical)
                ElseIf cbClass.Text = "" Then
                    MsgBox("Please select class!", MsgBoxStyle.Critical)
                    'if there no errors occur 
                Else
                    'then insert record into database now
                    issucess = product_insert("INSERT INTO `customer` (`studID`, `name`, `surname`,`gender`, `class`)  VALUES ('" & txtID.Text & "','" & txtName.Text & "', '" & txtSurnm.Text & "', '" & cmbgender.Text & "', '" & cbClass.Text & "')")
                    'if successfully 
                    If issucess = True Then
                        MsgBox("New student has been added successfully!", MsgBoxStyle.Information)
                        StudentList.Show()
                        Me.Hide()
                        txtID.Text = ""
                        txtName.Text = ""
                        txtSurnm.Text = ""
                    Else
                        ' No student has been added!
                        MsgBox("No student has been added!", MsgBoxStyle.Critical)
                        txtID.ForeColor = Color.Red
                        txtName.ForeColor = Color.Red
                        txtSurnm.ForeColor = Color.Red
                    End If

                End If
            End If
        End If
    End Sub
End Class