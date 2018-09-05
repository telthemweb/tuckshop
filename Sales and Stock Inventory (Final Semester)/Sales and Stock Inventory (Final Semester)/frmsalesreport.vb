Imports System.Data.OleDb
Public Class frmsalesreport
    Public Function mycon() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\CanteenDB.accdb")
    End Function
    Dim acscmd As New OleDb.OleDbCommand
    Dim acsda As New OleDb.OleDbDataAdapter
    Dim acscon As OleDb.OleDbConnection = mycon()
    Dim acsds As New DataSet
    Dim strsql As String
    Dim strreportname As String
    Public Sub report(ByVal sql As String, ByVal rptname As String)
        acsds = New DataSet
        strsql = sql
        acscmd.CommandText = strsql
        acscmd.Connection = acscon
        acsda.SelectCommand = acscmd
        acsda.Fill(acsds)

        strreportname = rptname
        Dim strreportpath As String = Application.StartupPath & "\Salesreport\" & strreportname & ".rpt"

        If Not IO.File.Exists(strreportpath) Then
            MsgBox("Unable to locate file :" & vbCrLf & strreportpath)
        End If

        Dim reportdoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportdoc.Load(strreportpath)
        reportdoc.SetDataSource(acsds.Tables(0))

        CrystalReportViewer1.ShowRefreshButton = False
        CrystalReportViewer1.ShowCloseButton = False
        CrystalReportViewer1.ShowGroupTreeButton = False
        CrystalReportViewer1.ReportSource = reportdoc
    End Sub
    Private Sub frmsalesreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If message = "all reports" Then
            report("SELECT * FROM tbltransaction", "salesreport")
        ElseIf message = "Date" Then
            report("SELECT * FROM tbltransaction where transactionDate = '" & frmtransactiondetail.DateTimePicker2.Text.ToString & "'", "salesreport")
        End If
    End Sub
End Class