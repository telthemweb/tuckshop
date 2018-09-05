
Imports System.Data.OleDb

Module connection
    Public message As String = ""
    Public sqL As String
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public conn As OleDbConnection
    Public connStr As String = System.Environment.CurrentDirectory.ToString & "\CanteenDB.accdb"

    Public Sub ConnDB()
        Try
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & connStr & "")
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
