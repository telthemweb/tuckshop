Imports System.Data.OleDb
Public Class Sales_Entry
    Private cb As New DbConnect
    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Sales_Entry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\gament.accdb")
        Str = "select * from Sales"
        dbcmd = New OleDbCommand(Str, con)
        dbda.SelectCommand = dbcmd
        dbda.Fill(ds, "Sales")

        'for generating Sales Invoice Number.
        Dim InvoiceNumber As Integer
        InvoiceNumber = ds.Tables("Sales").Rows.Count + 1
        If InvoiceNumber >= 0 Then
            txtReceipt.Text = "80059900600" & InvoiceNumber
        Else
            txtReceipt.Text = "0000000" & 0
        End If

        'for getting users.
        ' RUN QUERY
        cb.ExecQuery("SELECT * FROM Users ORDER BY Name ASC")
        If NotEmpty(cb.Exception) Then MsgBox(cb.Exception) : Exit Sub




        ' CLEAR COMBOBOX
        cmbCashier.Items.Clear()

        ' FILL COMBOBOX
        For Each R As DataRow In cb.dt.Rows
            cmbCashier.Items.Add(R("Name"))
        Next
        'Product Name
        ' RUN QUERY
        cb.ExecQuery("SELECT * FROM products ORDER BY PID ASC")
        If NotEmpty(cb.Exception) Then MsgBox(cb.Exception) : Exit Sub
        ' CLEAR COMBOBOX
        cmbProductId.Items.Clear()

        ' FILL COMBOBOX
        For Each R As DataRow In cb.dt.Rows
            cmbProductId.Items.Add(R("PID"))
        Next

        'Customer
        ' RUN QUERY
        cb.ExecQuery("SELECT * FROM Customer ORDER BY CustomerID ASC")
        If NotEmpty(cb.Exception) Then MsgBox(cb.Exception) : Exit Sub

        ' CLEAR COMBOBOX
        cmbCID.Items.Clear()

        ' FILL COMBOBOX
        For Each R As DataRow In cb.dt.Rows
            cmbCID.items.Add(R("CustomerID"))
        Next

    End Sub
    Public Sub RefresSaleshGrid()
        ' RUN QUERY
        cb.ExecQuery("SELECT * FROM Sales ORDER BY sid ASC")
        ' REPORT & ABORT ON ERRORS
        If NotEmpty(cb.Exception) Then MsgBox(cb.Exception) : Exit Sub
        datagridCustom.DataSource = cb.dt

    End Sub

    Private Sub AddSales()
        If cmbCashier.Text = "" Then
            MsgBox("Please select Cashier", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf cmbCID.Text = "" Then
            MsgBox("Please select CustomerID", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf cmbProductId.Text = "" Then
            MsgBox("Please select Product code", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf txtTotal.Text = "" Then
            MsgBox("Please quantity is required", MsgBoxStyle.Critical)
            Exit Sub
        End If

        'add parameter fro DBConn cLass
        cb.AddParam("@invoice", txtReceipt.Text)
        cb.AddParam("@prcode", cmbProductId.Text)
        cb.AddParam("@prname", txtPName.Text)
        cb.AddParam("@qnty", txtQnty.Text)
        cb.AddParam("@price", txtPrice.Text)
        cb.AddParam("@totalAmount", txtTotal.Text)
        cb.AddParam("@date", dtpPach.Text)
        cb.AddParam("@custID", cmbCID.Text)
        cb.AddParam("@custNam", txtCname.Text)
        cb.AddParam("@city", txtCcity.Text)
        cb.AddParam("@address", txtCaddress.Text)
        cb.AddParam("@custPhone", txtCphone.Text)
        cb.AddParam("@cashier", cmbCashier.Text)


        'execute command

        cb.ExecQuery("INSERT INTO Sales([InvoiceNumber],[PID], [productName], [quantity], [price],[Total_Amt],[invoiceDate], [CustomerID],[CustomerName],[City],[Addres],[ContactNo],[Cashier]) VALUES(@invoice,@prcode,@prname,@qnty,@price,@totalAmount,@date,@custID,@custNam,@city,@address,@custPhone,@cashier)")

        ' REPORT & ABORT ON ERRORS
        If NotEmpty(cb.Exception) Then MsgBox(cb.Exception) : Exit Sub

        MsgBox("New Sales Record Added Successfully", MsgBoxStyle.Information)
    End Sub



   

    Private Sub btnAddTot_Click(sender As Object, e As EventArgs) Handles btnAddTot.Click
        txtTotal.Text = Val(txtPrice.Text) * Val(txtQnty.Text)
    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AddSales()
        RefresSaleshGrid()
    End Sub

    Private Sub Sales_Entry_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RefresSaleshGrid()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Sales_ListView.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
    End Sub

    Private Sub cmbProductId_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbProductId.SelectedIndexChanged
        conn.Open()

        Try
            dbcmd = New OleDbCommand("SELECT * FROM products WHERE PID ='" & cmbProductId.Text & "'", conn)
            Dim DbReader As OleDbDataReader

            DbReader = dbcmd.ExecuteReader
            While DbReader.Read
                txtPName.Text = DbReader("ProdName")
                txtPrice.Text = DbReader("SellingPrice")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        conn.Close()
    End Sub

    Private Sub cmbCID_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbCID.SelectedIndexChanged
        conn.Open()

        Try
            dbcmd = New OleDbCommand("SELECT * FROM Customer WHERE CustomerID ='" & cmbCID.Text & "'", conn)
            Dim DbReader As OleDbDataReader

            DbReader = dbcmd.ExecuteReader
            While DbReader.Read
                txtCname.Text = DbReader("CustomerName")
                txtCcity.Text = DbReader("City")
                txtCaddress.Text = DbReader("Addres")
                txtCphone.Text = DbReader("ContactNo")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        conn.Close()
    End Sub
End Class