Imports System.Data.OleDb
Public Class Purchase_List
    Private picdata As New DbConnect
    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function
    Public Sub RefreshDbPurchaseGrid()
        ' RUN QUERY
        picdata.ExecQuery("SELECT * FROM Purchases ORDER BY pCode ASC")
        ' REPORT & ABORT ON ERRORS
        If NotEmpty(picdata.Exception) Then MsgBox(picdata.Exception) : Exit Sub
        Puchasedata.DataSource = picdata.dt
    End Sub
    Private Sub SearchPurchase(Name As String)

        ' ADD PARAMETERS & RUN QUERY
        picdata.AddParam("@user", "%" & Name & "%")
        picdata.ExecQuery("SELECT supplierid,ProductName,Suppliedby,invoiceNum,Total_amt,datePurchased,price,contactNumber " &
                         "FROM Purchases " &
                         "WHERE ProductName LIKE @user")

        ' REPORT & ABORT ON ERRORS
        If NotEmpty(picdata.Exception) Then MsgBox(picdata.Exception) : Exit Sub

        ' FILL DATAGRIDVIEW
        Puchasedata.DataSource = picdata.dt


    End Sub
    Private Sub Puchasedata_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Puchasedata.CellClick
        Me.Text = Puchasedata.CurrentRow.Cells(0).Value.ToString
        txtParc.Text = Puchasedata.CurrentRow.Cells(1).Value.ToString
        cmbProductCod.Text = Puchasedata.CurrentRow.Cells(2).Value.ToString
        cmbSupNum.Text = Puchasedata.CurrentRow.Cells(3).Value.ToString
        txtPname.Text = Puchasedata.CurrentRow.Cells(4).Value.ToString
        txtSupled.Text = Puchasedata.CurrentRow.Cells(5).Value.ToString
        txtSpName.Text = Puchasedata.CurrentRow.Cells(6).Value.ToString
        txtReceipt.Text = Puchasedata.CurrentRow.Cells(7).Value.ToString
        txtQnty.Text = Puchasedata.CurrentRow.Cells(8).Value.ToString
        txtPrice.Text = Puchasedata.CurrentRow.Cells(9).Value.ToString
        txtTotal.Text = Puchasedata.CurrentRow.Cells(10).Value.ToString
        dtpPach.Text = Puchasedata.CurrentRow.Cells(11).Value.ToString
        cmbModePay.Text = Puchasedata.CurrentRow.Cells(12).Value.ToString
        txtCity.Text = Puchasedata.CurrentRow.Cells(13).Value.ToString
        txtAddres.Text = Puchasedata.CurrentRow.Cells(14).Value.ToString
        txtPhone.Text = Puchasedata.CurrentRow.Cells(15).Value.ToString
    End Sub

    Private Sub Purchase_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDbPurchaseGrid()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        SearchPurchase(txtSearch.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PurchaseReceipt.Label7.Text = txtReceipt.Text
        PurchaseReceipt.Label8.Text = txtParc.Text
        PurchaseReceipt.Label9.Text = txtTotal.Text
        PurchaseReceipt.Label10.Text = txtPname.Text
        PurchaseReceipt.Label16.Text = cmbModePay.Text
        PurchaseReceipt.Label17.Text = txtPrice.Text
        PurchaseReceipt.Label20.Text = txtTotal.Text
        PurchaseReceipt.Label21.Text = dtpPach.Text
        PurchaseReceipt.Label22.Text = txtSupled.Text
        PurchaseReceipt.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Sql = "DELETE * FROM Purchases  WHERE parchaseID=" & Me.Text
            conn.Open()
            With dbcmd
                .CommandText = Sql
                .Connection = conn
            End With

            result = dbcmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("record has been deleted!")
                RefreshDbPurchaseGrid()
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        txtTotal.Text = Val(txtPrice.Text) * Val(txtQnty.Text)
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click


        If Not (txtPname.Text = "" Or cmbSupNum.Text = "" Or txtSpName.Text = "" Or txtCity.Text = "" Or txtAddres.Text = "" Or txtQnty.Text = "" Or txtPhone.Text = "") Then
            Try
                Dim sqlquery As String = "UPDATE Purchases SET pCode= '" & txtParc.Text.ToUpper & "', PID = '" & cmbProductCod.Text.ToUpper & "', supplierid = '" & cmbSupNum.Text.ToUpper & "', ProductName = '" & txtPname.Text.ToUpper & "' , Suppliedby = '" & txtSupled.Text.ToUpper & "' , SupplierName = '" & txtSpName.Text.ToUpper & "' , invoiceNum = '" & txtReceipt.Text.ToUpper & "' , quantity = '" & txtQnty.Text.ToUpper & "', price = '" & txtPrice.Text.ToUpper & "', Total_amt = '" & txtTotal.Text.ToUpper & "', datePurchased = '" & dtpPach.Text.ToUpper & "', PaymentMode = '" & cmbModePay.Text.ToUpper & "', suppliercity = '" & txtCity.Text.ToUpper & "', SupplierAddress = '" & txtAddres.Text.ToUpper & "', contactNumber = '" & txtPhone.Text.ToUpper & "' WHERE parchaseID = " & Me.Text
                Dim sqlcommand As New OleDbCommand

                conn.Open()
                With sqlcommand
                    .CommandText = sqlquery
                    .Connection = conn
                    .ExecuteNonQuery()
                End With
                MsgBox("Record Successfully Updated.")
                RefreshDbPurchaseGrid()
            Catch ex As Exception
                MsgBox(ex.Message)

                conn.Close()
            End Try

        Else
            MsgBox("Fields cannot be empty.")
        End If
    End Sub
End Class