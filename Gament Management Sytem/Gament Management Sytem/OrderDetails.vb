Imports System.Data.OleDb
Public Class OrderDetails
    Private cb As New DbConnect
    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub OrderDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       

        'for registration Supplier Name.
        ' RUN QUERY
        cb.ExecQuery("SELECT * FROM Suppliers ORDER BY SupplierId ASC")
        If NotEmpty(cb.Exception) Then MsgBox(cb.Exception) : Exit Sub


        ' CLEAR COMBOBOX
        cmbSupNum.Items.Clear()

        ' FILL COMBOBOX
        For Each R As DataRow In cb.dt.Rows
            cmbSupNum.Items.Add(R("SupplierId"))
        Next

        ' DISPLAY FIRS NAME FOUND
        If cb.RecordCount > 0 Then cmbSupNum.SelectedIndex = 0

    End Sub

    Private Sub cmbSupNum_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSupNum.SelectedIndexChanged
        conn.Open()

        Try
            dbcmd = New OleDbCommand("SELECT * FROM Suppliers WHERE SupplierId ='" & cmbSupNum.Text & "'", conn)
            Dim DbReader As OleDbDataReader

            DbReader = dbcmd.ExecuteReader
            While DbReader.Read
                txtSpName.Text = DbReader("supplierName")
                txtCity.Text = DbReader("City")
                txtAddres.Text = DbReader("SupplierAddress")
                txtPhone.Text = DbReader("Phone")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        txtTotal.Text = Val(txtPrice.Text) * Val(txtQnty.Text)
    End Sub

    'Add Order to database
    Private Sub PlaceOrder()

        'add parameter fro DBConn cLass
        cb.AddParam("@ProdName", txtPName.Text)
        cb.AddParam("@SupplierId", cmbSupNum.Text)
        cb.AddParam("@supplierName", txtSpName.Text)
        cb.AddParam("@City", txtCity.Text)
        cb.AddParam("@SupplierAddress", txtAddres.Text)
        cb.AddParam("@ContactNo", txtPhone.Text)
        cb.AddParam("@Quantity", txtQnty.Text)
        cb.AddParam("@Price", txtPrice.Text)
        cb.AddParam("@paymentMode", cmbPayment.Text)
        cb.AddParam("@Total_amt", txtTotal.Text)
        cb.AddParam("@DatedOrded", dtpDate.Text)


        'execute command

        cb.ExecQuery("INSERT INTO Orders([ProdName],[SupplierId], [supplierName],[City],[SupplierAddress],[ContactNo], [quantity],[price],[paymentMode],[Total_amt],[DatedOrded]) VALUES(@ProdName,@SupplierId,@supplierName,@City,@SupplierAddress,@ContactNo,@Quantity,@Price,@paymentMode,@Total_amt,@DatedOrded)")

        ' REPORT & ABORT ON ERRORS
        If NotEmpty(cb.Exception) Then MsgBox(cb.Exception) : Exit Sub

        MsgBox("New Order Added Successfully", MsgBoxStyle.Information)
    End Sub
    Public Sub RefresshOrderGrid()
        ' RUN QUERY
        cb.ExecQuery("SELECT * FROM Orders ORDER BY oid ASC")
        ' REPORT & ABORT ON ERRORS
        If NotEmpty(cb.Exception) Then MsgBox(cb.Exception) : Exit Sub
        OrderView.DataSource = cb.dt

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        PlaceOrder()
        RefresshOrderGrid()
    End Sub

    Private Sub OrderDetails_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        RefresshOrderGrid()
    End Sub

    Private Sub OrderView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OrderView.CellClick
        Me.Text = OrderView.CurrentRow.Cells(0).Value.ToString
        txtPName.Text = OrderView.CurrentRow.Cells(1).Value.ToString
        cmbSupNum.Text = OrderView.CurrentRow.Cells(2).Value.ToString
        txtSpName.Text = OrderView.CurrentRow.Cells(3).Value.ToString
        txtCity.Text = OrderView.CurrentRow.Cells(4).Value.ToString
        txtAddres.Text = OrderView.CurrentRow.Cells(5).Value.ToString
        txtPhone.Text = OrderView.CurrentRow.Cells(6).Value.ToString
        txtQnty.Text = OrderView.CurrentRow.Cells(7).Value.ToString
        txtPrice.Text = OrderView.CurrentRow.Cells(8).Value.ToString
        cmbPayment.Text = OrderView.CurrentRow.Cells(9).Value.ToString
        txtTotal.Text = OrderView.CurrentRow.Cells(10).Value.ToString
        dtpDate.Text = OrderView.CurrentRow.Cells(11).Value.ToString

        
    End Sub

    Private Sub btnDel_Click(sender As System.Object, e As System.EventArgs) Handles btnDel.Click
        Try
            Sql = "DELETE * FROM Orders  WHERE oid=" & Me.Text
            conn.Open()
            With dbcmd
                .CommandText = Sql
                .Connection = conn
            End With

            result = dbcmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("record has been deleted!")
                RefresshOrderGrid()
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

    Private Sub btnList_Click(sender As System.Object, e As System.EventArgs) Handles btnList.Click
       
        If Not (txtPName.Text = "" Or cmbSupNum.Text = "" Or txtSpName.Text = "" Or txtCity.Text = "" Or txtAddres.Text = "" Or txtQnty.Text = "" Or txtPhone.Text = "") Then
            Try
                Dim sqlquery As String = "UPDATE Orders SET ProdName = '" & txtPName.Text.ToUpper & "', SupplierId = '" & cmbSupNum.Text.ToUpper & "', supplierName = '" & txtSpName.Text.ToUpper & "' , City = '" & txtCity.Text.ToUpper & "' , SupplierAddress = '" & txtAddres.Text.ToUpper & "' , ContactNo = '" & txtPhone.Text.ToUpper & "' , Quantity = '" & txtQnty.Text.ToUpper & "',paymentMode = '" & txtPName.Text.ToUpper & "', Total_amt = '" & txtTotal.Text.ToUpper & "', DatedOrded = '" & dtpDate.Text.ToUpper & "' WHERE oid = " & Me.Text
                Dim sqlcommand As New OleDbCommand
                conn.Open()
                With sqlcommand
                    .CommandText = sqlquery
                    .Connection = conn
                    .ExecuteNonQuery()
                End With
                MsgBox("Record Successfully Updated.")
                RefresshOrderGrid()
            Catch ex As Exception
                MsgBox(ex.Message)

                conn.Close()
            End Try

        Else
            MsgBox("Fields cannot be empty.")
        End If
    End Sub

End Class