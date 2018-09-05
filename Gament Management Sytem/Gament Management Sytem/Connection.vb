Module Connection

    Public dbda As New OleDb.OleDbDataAdapter

    Public dbcmd As New OleDb.OleDbCommand

    Public dbdt As New DataTable
    Public Str As String

    Public Sql, MYSQLOF, user As String
    Public result As Integer
    Public dr As OleDb.OleDbDataReader
    Public ds As New DataSet
    Public conn As OleDb.OleDbConnection = Gamentconnection()
    'connect to database
    Public Function Gamentconnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\gament.accdb")
    End Function
    Public Function Getsinglevalue(ByVal qry As String)
        Dim resultid As Integer
        conn.Open()
        Try
            With dbcmd
                .Connection = conn
                .CommandText = qry
            End With
            dr = dbcmd.ExecuteReader
            While dr.Read
                resultid = dr.GetValue(0)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        Return resultid
    End Function
    Public Sub AutoFill(ByVal Qry As String, ByVal TxtResult As TextBox)
        Dim QryRes As New AutoCompleteStringCollection
        TxtResult.AutoCompleteCustomSource.Clear()

        conn.Open()
        With dbcmd
            .Connection = conn
            .CommandText = Qry
        End With

        dr = dbcmd.ExecuteReader
        While dr.Read
            QryRes.Add(dr.GetValue(0))
        End While

        TxtResult.AutoCompleteMode = AutoCompleteMode.Suggest
        TxtResult.AutoCompleteSource = AutoCompleteSource.CustomSource
        TxtResult.AutoCompleteCustomSource = QryRes
        conn.Close()
    End Sub
End Module

