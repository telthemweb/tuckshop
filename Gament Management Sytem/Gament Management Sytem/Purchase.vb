Imports System.Data.OleDb
Public Class Purchase
    Private cb As New DbConnect
    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function
    Private Sub Purchase_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\gament.accdb")
        Str = "select * from Purchases"
        dbcmd = New OleDbCommand(Str, con)
        dbda.SelectCommand = dbcmd
        dbda.Fill(ds, "Purchases")

        'for generating Purchase Code.
        Dim LastNo As Integer
        LastNo = ds.Tables("Purchases").Rows.Count + 1
        If LastNo >= 0 Then
            txtParc.Text = "PX50002" & LastNo
        Else
            txtParc.Text = "PX" & 0
        End If

        'for generating Invoice Number.
        Dim InvoiceNumber As Integer
        InvoiceNumber = ds.Tables("Purchases").Rows.Count + 1
        If InvoiceNumber >= 0 Then
            txtReceipt.Text = "80059900" & LastNo
        Else
            txtReceipt.Text = "0000000" & 0
        End If

        'for registration Supplier Name.
        ' RUN QUERY
        cb.ExecQuery("SELECT * FROM Suppliers ORDER BY SupplierId ASC")
        If NotEmpty(cb.Exception) Then MsgBox(cb.Exception) : Exit Sub


        ' TotalAmount = TotalAmount + txtAmount.Value

        ' CLEAR COMBOBOX
        cmbSupNum.Items.Clear()

        ' FILL COMBOBOX
        For Each R As DataRow In cb.dt.Rows
            cmbSupNum.Items.Add(R("SupplierId"))
        Next

        ' DISPLAY FIRS NAME FOUND
        If cb.RecordCount > 0 Then cmbSupNum.SelectedIndex = 0


        'Product Name
        ' RUN QUERY
        cb.ExecQuery("SELECT * FROM products ORDER BY PID ASC")
        If NotEmpty(cb.Exception) Then MsgBox(cb.Exception) : Exit Sub
        ' CLEAR COMBOBOX
        cmbProductCod.Items.Clear()

        ' FILL COMBOBOX
        For Each R As DataRow In cb.dt.Rows
            cmbProductCod.Items.Add(R("PID"))
        Next
    End Sub
    'Purchase
    Private Sub AddPurchase()

        'add parameter fro DBConn cLass
        cb.AddParam("@Pcode", txtParc.Text)
        cb.AddParam("@pid", cmbProductCod.Text)
        cb.AddParam("@suplyid", cmbSupNum.Text)
        cb.AddParam("@productname", txtPname.Text)
        cb.AddParam("@suppliedby", txtSupled.Text)
        cb.AddParam("@supname", txtSpName.Text)
        cb.AddParam("@Invoice", txtReceipt.Text)
        cb.AddParam("@qnty", txtQnty.Text)
        cb.AddParam("@price", txtPrice.Text)
        cb.AddParam("@totalAmount", txtTotal.Text)
        cb.AddParam("@date", dtpPach.Text)
        cb.AddParam("@paymentM", cmbModePay.Text)
        cb.AddParam("@city", txtCity.Text)
        cb.AddParam("@address", txtAddres.Text)
        cb.AddParam("@supPhone", txtPhone.Text)


        'execute command

        cb.ExecQuery("INSERT INTO Purchases([pCode],[PID], [supplierid], [ProductName], [Suppliedby],[SupplierName],[invoiceNum], [quantity],[price],[Total_amt],[datePurchased],[PaymentMode],[suppliercity],[SupplierAddress],[contactNumber]) VALUES(@Pcode,@pid,@suplyid,@productname,@suppliedby,@supname,@Invoice,@qnty,@price,@totalAmount,@date,@paymentM,@city,@address,@supPhone)")

        ' REPORT & ABORT ON ERRORS
        If NotEmpty(cb.Exception) Then MsgBox(cb.Exception) : Exit Sub

        MsgBox("New Purchase Added Successfully", MsgBoxStyle.Information)
    End Sub
    Public Sub RefresPachasehGrid()
        ' RUN QUERY
        cb.ExecQuery("SELECT * FROM Purchases ORDER BY pCode ASC")
        ' REPORT & ABORT ON ERRORS
        If NotEmpty(cb.Exception) Then MsgBox(cb.Exception) : Exit Sub
        pachaseGrid.DataSource = cb.dt

    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        txtTotal.Text = Val(txtPrice.Text) * Val(txtQnty.Text)
    End Sub

    Private Sub cmbSupName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSupNum.SelectedIndexChanged
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

    Private Sub cmbProductCod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductCod.SelectedIndexChanged
        conn.Open()

        Try
            dbcmd = New OleDbCommand("SELECT * FROM products WHERE PID ='" & cmbProductCod.Text & "'", conn)
            Dim DbReader As OleDbDataReader

            DbReader = dbcmd.ExecuteReader
            While DbReader.Read
                txtPname.Text = DbReader("ProdName")
                txtPrice.Text = DbReader("SellingPrice")
                txtSupled.Text = DbReader("SuppliedBY")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        conn.Close()
    End Sub
 

    Private Sub Purchase_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RefresPachasehGrid()
    End Sub
    Private Sub btnLi_Click(sender As Object, e As EventArgs) Handles btnLi.Click
        Purchase_List.Show()
    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        AddPurchase()
        RefresPachasehGrid()
    End Sub
End Class