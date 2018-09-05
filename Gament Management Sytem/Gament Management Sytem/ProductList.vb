Public Class ProductList
    Private picdata As New DbConnect
    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function
    Public Sub RefreshGrid()
        ' RUN QUERY
        picdata.ExecQuery("SELECT * FROM products ORDER BY PID ASC")
        ' REPORT & ABORT ON ERRORS
        If NotEmpty(picdata.Exception) Then MsgBox(picdata.Exception) : Exit Sub
        dgvData.DataSource = picdata.dt
    End Sub
    Private Sub SearchMember(Name As String)

        ' ADD PARAMETERS & RUN QUERY
        picdata.AddParam("@user", "%" & Name & "%")
        picdata.ExecQuery("SELECT PID,ProdName,ProductDesc,Color,SuppliedBY,SellingPrice " &
                         "FROM products " &
                         "WHERE ProdName LIKE @user")

        ' REPORT & ABORT ON ERRORS
        If NotEmpty(picdata.Exception) Then MsgBox(picdata.Exception) : Exit Sub

        ' FILL DATAGRIDVIEW
        dgvData.DataSource = picdata.dt


    End Sub

    Private Sub UpdateProduct()

        'add parameter fro DBConn cLass
        picdata.AddParam("@code", txtPc.Text)
        picdata.AddParam("@pname", txtPname.Text)
        picdata.AddParam("@descript", txtDesc.Text)
        picdata.AddParam("@color", txtColor.Text)
        picdata.AddParam("@dateAdded", dtpAdded.Text)
        picdata.AddParam("@Supply", cmbSupply.Text)
        picdata.AddParam("@sp", txtSP.Text)



        'execute command              
        picdata.ExecQuery("UPDATE products SET [PID]=@code,[ProdName]= @pname, [ProductDesc]= @descript, [Color]= @color,[dateadded]= @dateAdded,[SuppliedBY]=@Supply, [SellingPrice]=@sp WHERE [PID]=" & Me.Text)

        RefreshGrid()
        ' REPORT & ABORT ON ERRORS
        If NotEmpty(picdata.Exception) Then MsgBox(picdata.Exception) : Exit Sub

        MsgBox("New Product Updated Successfully", MsgBoxStyle.Information)
    End Sub
    Private Sub dgvData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellClick
        Me.Text = dgvData.CurrentRow.Cells(0).Value.ToString
        txtPc.Text = dgvData.CurrentRow.Cells(1).Value.ToString
        txtPname.Text = dgvData.CurrentRow.Cells(2).Value.ToString
        txtDesc.Text = dgvData.CurrentRow.Cells(3).Value.ToString
        txtColor.Text = dgvData.CurrentRow.Cells(4).Value.ToString
        dtpAdded.Text = dgvData.CurrentRow.Cells(5).Value.ToString
        cmbSupply.Text = dgvData.CurrentRow.Cells(6).Value.ToString
        txtSP.Text = dgvData.CurrentRow.Cells(7).Value.ToString
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchMember(txtSearch.Text)
    End Sub

    Private Sub ProductList_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        RefreshGrid()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Sql = "DELETE * FROM products  WHERE id =" & Me.Text
            conn.Open()
            With dbcmd
                .CommandText = Sql
                .Connection = conn
            End With

            result = dbcmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("New Product record has been deleted!")
                RefreshGrid()
                conn.Close()


            Else
                MsgBox("No Product record has been deleted!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()


        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UpdateProduct()
        RefreshGrid()
    End Sub

    Private Sub ProductList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvData_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellContentClick

    End Sub
End Class