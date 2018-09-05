Imports System.Data.OleDb
Public Class ProductEntry
    Private cob As New DbConnect
    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub ProductEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\gament.accdb")
        'Product Code
        Str = "select * from products"
        dbcmd = New OleDbCommand(Str, con)
        dbda.SelectCommand = dbcmd
        dbda.Fill(ds, "products")

        'for registration Product  Code.
        Dim LastNo As Integer
        LastNo = ds.Tables("products").Rows.Count + 1
        If LastNo >= 0 Then
            txtPc.Text = "P00" & LastNo
        Else
            txtPc.Text = "P" & 0
        End If
        'for registration Suplier.
        ' RUN QUERY
        cob.ExecQuery("SELECT * FROM Suppliers ORDER BY supplierName ASC")
        If NotEmpty(cob.Exception) Then MsgBox(cob.Exception) : Exit Sub


        ' TotalAmount = TotalAmount + txtAmount.Value

        ' CLEAR COMBOBOX
        cmbSupply.Items.Clear()

        ' FILL COMBOBOX
        For Each R As DataRow In cob.dt.Rows
            cmbSupply.Items.Add(R("supplierName"))
        Next

        ' DISPLAY FIRS NAME FOUND
        If cob.RecordCount > 0 Then cmbSupply.SelectedIndex = 0
    End Sub
    Private Sub AddProduct()

        'add parameter fro DBConn cLass
        cob.AddParam("@code", txtPc.Text)
        cob.AddParam("@pname", txtPname.Text)
        cob.AddParam("@descript", txtDesc.Text)
        cob.AddParam("@color", txtColor.Text)
        cob.AddParam("@dateAdded", dtpAdded.Text)
        cob.AddParam("@Supply", cmbSupply.Text)
        cob.AddParam("@sp", txtSP.Text)



        'execute command
        cob.ExecQuery("INSERT INTO products([PID], [ProdName], [ProductDesc], [Color],[dateadded],[SuppliedBY], [SellingPrice]) VALUES(@code,@pname,@descript,@color,@dateAdded,@Supply,@sp)")

        ' REPORT & ABORT ON ERRORS
        If NotEmpty(cob.Exception) Then MsgBox(cob.Exception) : Exit Sub

        MsgBox("New Product Added Successfully", MsgBoxStyle.Information)
    End Sub
    Public Sub RefreshGrid()
        ' RUN QUERY
        cob.ExecQuery("SELECT * FROM products ORDER BY PID ASC")
        ' REPORT & ABORT ON ERRORS
        If NotEmpty(cob.Exception) Then MsgBox(cob.Exception) : Exit Sub
        dgvData.DataSource = cob.dt

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        AddProduct()
        RefreshGrid()
    End Sub

    Private Sub ProductEntry_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        RefreshGrid()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmbSupply_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSupply.SelectedIndexChanged

    End Sub

    Private Sub txtColor_TextChanged(sender As Object, e As EventArgs) Handles txtColor.TextChanged

    End Sub

    Private Sub txtDesc_TextChanged(sender As Object, e As EventArgs) Handles txtDesc.TextChanged

    End Sub

    Private Sub txtPname_TextChanged(sender As Object, e As EventArgs) Handles txtPname.TextChanged

    End Sub

    Private Sub txtPc_TextChanged(sender As Object, e As EventArgs) Handles txtPc.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub dtpAdded_ValueChanged(sender As Object, e As EventArgs) Handles dtpAdded.ValueChanged

    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        ProductList.Show()
    End Sub
End Class