Imports System.Data.OleDb
Public Class Sales_ListView
    Private picdata As New DbConnect
    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function
    Public Sub RefreshDbSalesGrid()
        ' RUN QUERY
        picdata.ExecQuery("SELECT * FROM Sales ORDER BY sid ASC")
        ' REPORT & ABORT ON ERRORS
        If NotEmpty(picdata.Exception) Then MsgBox(picdata.Exception) : Exit Sub
        Salesdata.DataSource = picdata.dt
    End Sub
    Private Sub SearchSales(Name As String)

        ' ADD PARAMETERS & RUN QUERY
        picdata.AddParam("@user", "%" & Name & "%")
        picdata.ExecQuery("SELECT InvoiceNumber,productName,quantity,price,Total_Amt,invoiceDate,CustomerName,City,ContactNo,Cashier " &
                         "FROM Sales " &
                         "WHERE productName LIKE @user")

        ' REPORT & ABORT ON ERRORS
        If NotEmpty(picdata.Exception) Then MsgBox(picdata.Exception) : Exit Sub

        ' FILL DATAGRIDVIEW
        Salesdata.DataSource = picdata.dt


    End Sub
    Private Sub Salesdata_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Salesdata.CellClick
        Me.Text = Salesdata.CurrentRow.Cells(0).Value.ToString
        txtReceipt.Text = Salesdata.CurrentRow.Cells(1).Value.ToString
        txtProductId.Text = Salesdata.CurrentRow.Cells(2).Value.ToString
        txtPName.Text = Salesdata.CurrentRow.Cells(3).Value.ToString
        txtQnty.Text = Salesdata.CurrentRow.Cells(4).Value.ToString
        txtPrice.Text = Salesdata.CurrentRow.Cells(5).Value.ToString
        txtTotal.Text = Salesdata.CurrentRow.Cells(6).Value.ToString
        dtpPach.Text = Salesdata.CurrentRow.Cells(7).Value.ToString
        txtCID.Text = Salesdata.CurrentRow.Cells(8).Value.ToString
        txtCname.Text = Salesdata.CurrentRow.Cells(9).Value.ToString
        txtCcity.Text = Salesdata.CurrentRow.Cells(10).Value.ToString
        txtCaddress.Text = Salesdata.CurrentRow.Cells(11).Value.ToString
        txtCphone.Text = Salesdata.CurrentRow.Cells(12).Value.ToString
        txtCashier.Text = Salesdata.CurrentRow.Cells(13).Value.ToString
    End Sub
    Private Sub Sales_ListView_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RefreshDbSalesGrid()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        SearchSales(txtSearch.Text)
    End Sub

    Private Sub btnAddTot_Click(sender As Object, e As EventArgs) Handles btnAddTot.Click
        txtTotal.Text = Val(txtPrice.Text) * Val(txtQnty.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Sql = "DELETE * FROM Sales  WHERE sid=" & Me.Text
            conn.Open()
            With dbcmd
                .CommandText = Sql
                .Connection = conn
            End With

            result = dbcmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("record has been deleted!")
                RefreshDbSalesGrid()
                conn.Close()
            Else
                MsgBox("No  record has been deleted!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()


        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click

        Try
            Dim sqlquery As String = "UPDATE Sales SET InvoiceNumber= '" & txtReceipt.Text.ToUpper & "', PID = '" & txtProductId.Text.ToUpper & "', ProductName = '" & txtPName.Text.ToUpper & "' , quantity = '" & txtQnty.Text.ToUpper & "' , price = '" & txtPrice.Text.ToUpper & "' , Total_Amt = '" & txtTotal.Text.ToUpper & "' , invoiceDate = '" & dtpPach.Text.ToUpper & "', CustomerID = '" & txtCID.Text.ToUpper & "', CustomerName = '" & txtCname.Text.ToUpper & "', City = '" & txtCcity.Text.ToUpper & "', Addres = '" & txtCaddress.Text.ToUpper & "', ContactNo = '" & txtCphone.Text.ToUpper & "', Cashier = '" & txtCashier.Text.ToUpper & "' WHERE sid = " & Me.Text
            Dim sqlcommand As New OleDbCommand

            conn.Open()
            With sqlcommand
                .CommandText = sqlquery
                .Connection = conn
                .ExecuteNonQuery()
            End With
            MsgBox("Record Successfully Updated.")
            RefreshDbSalesGrid()
        Catch ex As Exception
            MsgBox(ex.Message)

            conn.Close()
        End Try

       
    End Sub
End Class