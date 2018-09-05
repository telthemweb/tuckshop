Imports System.Data.OleDb
Public Class frmtransactiondetail
    Public search As Boolean = False
    Public Sub sumtotal()
        Dim total As String = 0
        For i As Integer = 0 To dgw.RowCount - 1
            total += dgw.Rows(i).Cells(3).Value
        Next
        TextBox1.Text = total
    End Sub
    Public Sub loaddata()
        findThis("SELECT InvoiceNo, transactionDate as [Date], transactionTime as [Time], TotalAmount as [Total Amount], CustomerNo FROM tbltransaction Order by InvoiceNo ASC")
        fillTable(dgw)
        sumtotal()
    End Sub
    Private Sub frmtransactiondetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DateTimePicker2.Text = Date.Today
        loaddata()
        search = False
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click

        If search = True Then
            message = "Date"
            frmsalesreport.Show()
            frmsalesreport.Label1.Text = "Daily Sales Report"
        ElseIf search = False Then
            message = "all reports"
            frmsalesreport.Show()
            frmsalesreport.Label1.Text = "Overall Sales"
        End If

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        search = True

        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter
        Try
            conn.Open()
            sqL = "SELECT InvoiceNo, transactionDate as [Date], transactionTime as [Time], TotalAmount as [Total Amount], CustomerNo FROM tbltransaction WHERE transactionDate = '" & DateTimePicker2.Text & "' Order by InvoiceNo ASC"
            With cmd
                .CommandText = sqL
                .Connection = conn
            End With

            da.SelectCommand = cmd
            da.Fill(dt)
            dgw.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        sumtotal()
    End Sub
End Class