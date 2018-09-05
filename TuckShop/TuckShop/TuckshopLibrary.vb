Module TuckshopLibrary

    Public Sub writeThisError(ByVal errMsg As String)
        Try
            Dim FILE_NAME As String = Application.StartupPath & "\errorlogfile.txt"
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, True)

            objWriter.WriteLine(errMsg)
            objWriter.Close()
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Public Function GetCount() As Integer
        Dim table As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(table)

            Return table.Rows(0).Item(0)

        Catch ex As Exception
            writeThisError(Format(Now, "Long Date") & " " & Date.Now.ToString("H:mm:ss") & " ===>> " & ex.Message)
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function
    Public Function GetNumRows() As Integer
        Dim table As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(table)

            Return table.Rows.Count

        Catch ex As Exception
            writeThisError(Format(Now, "Long Date") & " " & Date.Now.ToString("H:mm:ss") & " ===>> " & ex.Message)
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function
    Public Function isemptyresult() As Integer
        Try
            If GetNumRows() > 0 Then

                Return GetNumRows()

            End If
        Catch ex As Exception
            writeThisError(Format(Now, "Long Date") & " " & Date.Now.ToString("H:mm:ss") & " ===>> " & ex.Message)
            MsgBox(ex.Message)
        End Try

        Return Nothing
    End Function
    Public Sub fillcombo(ByVal combo As Object, ByVal member As String, ByVal idparam As String)
        Dim publictable As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(publictable)
            With combo
                .DataSource = publictable
                .displaymember = member
                .valuemember = idparam
            End With

            da.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub



End Module
