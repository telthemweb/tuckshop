Imports MySql.Data.MySqlClient
Module sqlQuery
    Public Sub tuckfindthis(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub LoadSingleResult(ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()
            Select Case param
                Case "student"
                    Do While dReader.Read = True

                    Loop
                Case "login"
                    Do While dReader.Read = True

                        ACCOUNT_NAME = dReader("Name") & " " & dReader("Surname")
                        ACCOUNT_USERNAME = dReader("Username")
                        ACCOUNT_TYPE = dReader("UserType")
                        Main.Show()

                        Login.Hide()
                    Loop
                Case "products"


                    Do While dReader.Read = True

                    Loop

                Case "sales"

                    Do While dReader.Read = True

                    Loop
                Case "stock"

                    Do While dReader.Read = True

                    Loop
                Case "orders"

                    Do While dReader.Read = True

                    Loop

                Case "students"

                    Do While dReader.Read = True

                    Loop
                Case "suppliers"

                    Do While dReader.Read = True

                    Loop

                Case "purchases"

                    Do While dReader.Read = True

                    Loop

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

End Module
