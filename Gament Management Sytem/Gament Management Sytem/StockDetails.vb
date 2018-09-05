Imports System.Data.OleDb
Public Class StockDetails
    Private cb As New DbConnect
    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
    Public Sub RefreshStockGrid()
        ' RUN QUERY
        cb.ExecQuery("SELECT * FROM Stock ORDER BY ID ASC")
        ' REPORT & ABORT ON ERRORS
        If NotEmpty(cb.Exception) Then MsgBox(cb.Exception) : Exit Sub
        stGridview.DataSource = cb.dt

    End Sub

    Private Sub StockDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Product Name
        ' RUN QUERY
        cb.ExecQuery("SELECT * FROM products ORDER BY PID ASC")
        If NotEmpty(cb.Exception) Then MsgBox(cb.Exception) : Exit Sub
        ' CLEAR COMBOBOX
        cmbPro.Items.Clear()

        ' FILL COMBOBOX
        For Each R As DataRow In cb.dt.Rows
            cmbPro.Items.Add(R("PID"))
        Next
    End Sub

    Private Sub AddStock()

        'add parameter fro DBConn cLass
        cb.AddParam("@PID", cmbPro.Text)
        cb.AddParam("@ProdName", txtPname.Text)
        cb.AddParam("@ProdDesc", rtcTDiscript.Text)
        cb.AddParam("@Cost_Price", txtCost.Text)
        cb.AddParam("@Selling_Price", txtPrice.Text)
        cb.AddParam("@Discount", txtdisc.Text)
        cb.AddParam("@VAT", txtVat.Text)
        cb.AddParam("@Qnty", txtQnty.Text)


        'execute command

        cb.ExecQuery("INSERT INTO Stock([PID],[ProdName], [ProdDesc], [Cost_Price], [Selling_Price],[Discount],[VAT], [Qnty]) VALUES(@PID,@ProdName,@ProdDesc,@Cost_Price,@Selling_Price,@Discount,@VAT,@Qnty)")

        ' REPORT & ABORT ON ERRORS
        If NotEmpty(cb.Exception) Then MsgBox(cb.Exception) : Exit Sub

        MsgBox("New Stock Record Added Successfully", MsgBoxStyle.Information)
    End Sub

    Private Sub stGridview_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles stGridview.CellClick
        Me.Text = stGridview.CurrentRow.Cells(0).Value.ToString
        cmbPro.Text = stGridview.CurrentRow.Cells(1).Value.ToString
        txtPname.Text = stGridview.CurrentRow.Cells(2).Value.ToString
        rtcTDiscript.Text = stGridview.CurrentRow.Cells(3).Value.ToString
        txtCost.Text = stGridview.CurrentRow.Cells(4).Value.ToString
        txtPrice.Text = stGridview.CurrentRow.Cells(5).Value.ToString
        txtVat.Text = stGridview.CurrentRow.Cells(6).Value.ToString
        txtdisc.Text = stGridview.CurrentRow.Cells(7).Value.ToString
        txtQnty.Text = stGridview.CurrentRow.Cells(8).Value.ToString

       
    End Sub

    Private Sub StockDetails_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        RefreshStockGrid()
    End Sub

    Private Sub btnStocl_Click(sender As System.Object, e As System.EventArgs) Handles btnStocl.Click
        AddStock()
        RefreshStockGrid()
    End Sub

    Private Sub cmbPro_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbPro.SelectedIndexChanged
        conn.Open()

        Try
            dbcmd = New OleDbCommand("SELECT * FROM products WHERE PID ='" & cmbPro.Text & "'", conn)
            Dim DbReader As OleDbDataReader

            DbReader = dbcmd.ExecuteReader
            While DbReader.Read
                txtPname.Text = DbReader("ProdName")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            Sql = "DELETE * FROM Stock  WHERE ID =" & Me.Text
            conn.Open()
            With dbcmd
                .CommandText = Sql
                .Connection = conn
            End With

            result = dbcmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("New  record has been deleted!")
                RefreshStockGrid()
                conn.Close()


            Else
                MsgBox("No STOCK record has been deleted!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()


        End Try
    End Sub
End Class