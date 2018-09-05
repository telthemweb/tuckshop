Module loaddgv
    Dim da As New OleDb.OleDbDataAdapter


    Public Sub findThis(ByVal sql As String)
        Try
            conn.Open()
            With cmd
                .CommandText = sql
                .Connection = conn
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub fillTable(ByVal dtg As Object)
        Dim dt As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                dtg.Datasource = dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
