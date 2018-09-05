Imports System.Data.OleDb

Public Class frmtransaction
    Dim totalprice As Double
    Dim totalCost As Double
    Dim getProdtoDelete As Integer

    Private Sub GetItemInfo()
        Try
            sqL = "SELECT ItemCode, IDescription, UnitPrice, itemNo FROM ITEM Where IDescription = '" & Val(txtSearch.Text) & "'"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            If dr.Read = True Then
                productCode = dr("ItemCode")
                itemDesc = dr("IDescription")
                itemPrice = dr("UnitPrice")
                itemNum = dr("itemNo")
            End If
            txtSearch.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Public Sub addtolist()
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        Try
            sql = "SELECT * FROM item where IDescription = '" & txtSearch.Text & "'"

            ConnDB()
            With cmd
                .CommandText = sql
                .Connection = conn
            End With
            dr = cmd.ExecuteReader
            While dr.Read()
                If txtSearch.Text = "" Then

                Else
                    ' Create the new row.
                    Dim price As Decimal = dr("UnitPrice")
                    Dim stockonhand As Decimal = dr("StocksOnHand")
                    Dim itemcode As String = dr("ItemCode")
                    Dim itemdesc As String = dr("IDescription")

                    'add transactiondetail
                    itemNum = dr("ItemNo")
                    itemPrice = dr("UnitPrice")

                    Try
                        sql = "INSERT INTO transactionDetail(InvoiceNo, ItemNo, itemPrice, Quantity) Values('" & lblInvoiceNo.Text & "', '" & itemNum & "', '" & itemPrice & "', '" & txtQuantity.Text & "')"
                        ConnDB()
                        cmd = New OleDbCommand(sql, conn)
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        cmd.Dispose()
                        conn.Close()
                    End Try

                    totalprice = Val(txtQuantity.Text) * price
                   
                    dgvItems.Rows.Add(txtQuantity.Text, itemcode, itemdesc, price, totalprice)
                    'update stockonhand per item
                    UpdateDecreaseQuantity()
                    txtSearch.Clear()
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = Format(Date.Now, "Long Time")
        lbldate.Text = Date.Now.ToString("dddd")
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        frmLoadItem.Show()
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If txtSearch.Text = Nothing Then

            '''''''''''''''''''''''
        Else
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                txtQuantity.Focus()
            End If
        End If
    End Sub

    Private Sub autocomplete()
        Try
            ConnDB()
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)

            Dim da As New OleDbDataAdapter("Select IDescription from Item", conn)
            da.Fill(dt)
            Dim r As DataRow
            txtSearch.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txtSearch.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub frmtransaction_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.Control AndAlso (e.KeyCode = Keys.P)) Then
            ' When Control + P is pressed
            'button perfom click
            btnPayment.PerformClick()
        ElseIf (e.Control AndAlso (e.KeyCode = Keys.N)) Then
            btnNewTransacation.PerformClick()
        ElseIf (e.Control AndAlso (e.KeyCode = Keys.R)) Then
            btnRemove.PerformClick()
        ElseIf (e.Control AndAlso (e.KeyCode = Keys.Escape)) Then
            btnClose.PerformClick()
        End If

    End Sub

    Private Sub frmtransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        btnNewTransacation.PerformClick()
        getinvoiceNo()
        Timer1.Start()
        autocomplete()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Show()
        Me.Close()
    End Sub

    Private Sub txtQuantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQuantity.KeyDown
        If txtQuantity.Text = Nothing Then
            ''''''''''''''''''''''''''''''''
        Else
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                addtolist()
                totalCost += totalprice
                lblTotalCost.Text = Format(totalCost, "#,##0.00")
                'GetItemInfo()
                txtQuantity.Clear()
                txtSearch.Focus()
            End If
        End If
    End Sub

    Private Sub UpdateDecreaseQuantity()
        Try
            sqL = "Update Item SET StocksOnHand = stocksOnHand - " & Val(txtQuantity.Text) & " WHERE IDescription = '" & txtSearch.Text & "'"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Sub

    Private Sub btnNewTransacation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewTransacation.Click
        dgvItems.Rows.Clear()
        lblTotalCost.Text = "0.00"
        totalCost = 0
        txtSearch.Focus()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If dgvItems.Rows.Count = 0 Then
            MsgBox("No Transaction", MsgBoxStyle.Exclamation, "Remove Item")
            txtSearch.Focus()
            Exit Sub
        Else
            If MsgBox("Are you sure you want to Delete?", MsgBoxStyle.YesNo, "Delete Item") = MsgBoxResult.Yes Then
                RemoveItem()

                txtSearch.Focus()
            Else
                Exit Sub
            End If

        End If
    End Sub

   
    Private Sub UpdateIncreaseQuantity()
        Try
            sqL = "Update Item SET StocksOnHand = stocksOnHand + '" & dgvItems.CurrentRow.Cells(0).Value & "' WHERE ItemNo = " & getProdtoDelete & ""
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub RemoveItem()
        lblTotalCost.Text = Format(lblTotalCost.Text - dgvItems.CurrentRow.Cells(4).Value, "#,##0.00")
        GetProductIDToDelete()
        UpdateIncreaseQuantity()
        dgvItems.Rows.Remove(dgvItems.SelectedRows.Item(0))
        totalCost = lblTotalCost.Text
    End Sub
    Private Sub GetProductIDToDelete()
        Try
            sqL = "SELECT ItemNo FROM item Where itemCode = '" & dgvItems.CurrentRow.Cells(1).Value & "'"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                getProdtoDelete = dr("itemNo")


                'delete transactiondetail
                Try
                    sqL = "DELETE FROM transactionDetail WHERE itemNo = " & getProdtoDelete & " AND InvoiceNo = '" & lblInvoiceNo.Text & "'"
                    ConnDB()
                    cmd = New OleDbCommand(sqL, conn)
                    Dim i As Integer
                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        'MsgBox("Item Deleted", MsgBoxStyle.Information, "Delete Item")
                    Else
                        ' MsgBox("Failed to Delete item", MsgBoxStyle.Critical, "Delete Item")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click
        frmpayment.ShowDialog()
    End Sub
End Class