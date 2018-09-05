Imports System.Data.OleDb
Imports System.IO
Public Class GarmentConn
    'make Connection
    Private cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & _
     "Data Source=gament.accdb;")


    'make Command
    Private cmd As OleDbCommand

    'db data
    Public da As OleDbDataAdapter
    Public dt As DataTable

    ' QUERY PARAMETERS
    Public Params As New List(Of OleDbParameter)

    'Query ststistic
    Public RecordCount As Integer
    'error string
    Public Exception As String

    Public Sub ExecQuery(Query As String)
        'Reset query string
        RecordCount = 0
        Exception = ""
        Try
            'Open Connection
            cn.Open()
            'Create DB Command
            cmd = New OleDbCommand(Query, cn)
            'load params into DB commands

            Params.ForEach(Sub(p) cmd.Parameters.Add(p))
            ' CLEAR PARAMS LIST
            Params.Clear()
            'Excute Command and fill table
            dt = New DataTable
            da = New OleDbDataAdapter(cmd)
            RecordCount = da.Fill(dt)
        Catch ex As Exception
            Exception = ex.Message
        End Try
    End Sub
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New OleDbParameter(Name, Value)
        Params.Add(NewParam)
    End Sub
End Class

