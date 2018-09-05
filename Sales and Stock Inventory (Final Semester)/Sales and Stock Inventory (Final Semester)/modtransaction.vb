Imports System.Data.OleDb
Module modtransaction
    Public productCode As String
    Public itemDesc As String
    Public itemPrice As Double
    Public itemNum As Integer

    Sub getinvoiceNo()

        Try
            sqL = "SELECT InvoiceNo FROm tbltransaction Order By InvoiceNo desc"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                frmtransaction.lblInvoiceNo.Text = Val(dr("InvoiceNo")) + 1

            Else
                frmtransaction.lblInvoiceNo.Text = 100000000
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

End Module
