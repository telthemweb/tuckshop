Module PublicVariables
    Public IsUserLoggedIn As Boolean = False

    Public Sub DisallowLetter(ByVal Target As Control)
        If TypeOf Target Is TextBox Then
            If Not IsNumeric(Target.Text) Then
                CType(Target, TextBox).Text = ""
            End If
        End If
    End Sub

    Public Sub DisallowNumber(ByVal Target As Control)
        If TypeOf Target Is TextBox Then
            If IsNumeric(CType(Target, TextBox).Text) Then
                CType(Target, TextBox).Text = ""
            End If
        End If
    End Sub
End Module
