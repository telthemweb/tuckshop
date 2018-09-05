Imports System.Data.OleDb
Public Class frmpayment
    Dim result As Integer
    Private Sub frmpayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txttotalcost.Text = frmtransaction.lblTotalCost.Text
        'txttotalcost.Text = FormatCurrency(Val(txttotalcost.Text))
        txtrecieved.Select()
        txtchange.Text = "0.00"
    End Sub

    Private Sub txtrecieved_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtrecieved.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Try
                ConnDB()
                Dim cmd As New OleDbCommand
                sqL = "INSERT INTO tbltransaction (InvoiceNo, transactionDate, transactionTime, TotalAmount, CustomerNo) VALUES ('" & frmtransaction.lblInvoiceNo.Text & "' , '" & Date.Today & "' , '" & frmtransaction.lblTime.Text & "' , '" & txttotalcost.Text & "' , '" & frmtransaction.lblCustomerName.Text & "')"

                With cmd
                    .CommandText = sqL
                    .Connection = conn
                End With
                result = cmd.ExecuteNonQuery
                If result > 0 Then
                    MsgBox("Thank you!")
                    txtchange.Clear()
                    txtrecieved.Clear()
                    txttotalcost.Clear()
                    getinvoiceNo()
                    frmtransaction.btnNewTransacation.PerformClick()
                    conn.Close()
                    Me.Close()
                Else
                    MsgBox("Transaction not Saved!")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtrecieved_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrecieved.TextChanged
        txtchange.Text = Val(txtrecieved.Text) - Val(txttotalcost.Text)


        If Val(txtrecieved.Text) < Val(txttotalcost.Text) Then
            txtchange.Text = "0.00"
        End If
    End Sub

 
End Class