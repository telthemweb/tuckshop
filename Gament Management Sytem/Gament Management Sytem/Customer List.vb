Imports System.Data.OleDb
Public Class Customer_List
    Private picdata As New DbConnect
    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function
    Public Sub RefreshGrid()
        ' RUN QUERY
        picdata.ExecQuery("SELECT * FROM Customer ORDER BY CustomerID ASC")
        ' REPORT & ABORT ON ERRORS
        If NotEmpty(picdata.Exception) Then MsgBox(picdata.Exception) : Exit Sub
        dgvData.DataSource = picdata.dt
    End Sub
    Private Sub SearchMember(Name As String)

        ' ADD PARAMETERS & RUN QUERY
        picdata.AddParam("@user", "%" & Name & "%")
        picdata.ExecQuery("SELECT CustomerID,CustomerName,Gender,BirthDate,ContactNo,RegisterDate " & _
                         "FROM Customer " & _
                         "WHERE CustomerID LIKE @user")

        ' REPORT & ABORT ON ERRORS
        If NotEmpty(picdata.Exception) Then MsgBox(picdata.Exception) : Exit Sub

        ' FILL DATAGRIDVIEW
        dgvData.DataSource = picdata.dt


    End Sub
    Private Sub Customer_List_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        RefreshGrid()
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        SearchMember(txtSearch.Text)
    End Sub

    Private Sub dgvData_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellClick
        Me.Text = dgvData.CurrentRow.Cells(0).Value.ToString
        txtCustomerID.Text = dgvData.CurrentRow.Cells(1).Value.ToString
        txtCusName.Text = dgvData.CurrentRow.Cells(2).Value.ToString
        cmbgender.Text = dgvData.CurrentRow.Cells(3).Value.ToString
        dtpYr.Text = dgvData.CurrentRow.Cells(4).Value.ToString
        txtPh.Text = dgvData.CurrentRow.Cells(5).Value.ToString
        txtCity.Text = dgvData.CurrentRow.Cells(6).Value.ToString
        txtAdd.Text = dgvData.CurrentRow.Cells(7).Value.ToString
        dtpReg.Text = dgvData.CurrentRow.Cells(8).Value.ToString
        txtEmail.Text = dgvData.CurrentRow.Cells(9).Value.ToString
    End Sub
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Try
            Sql = "DELETE * FROM Customer  WHERE id=" & Me.Text
            conn.Open()
            With dbcmd
                .CommandText = Sql
                .Connection = conn
            End With

            result = dbcmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("New customer record has been deleted!")
                RefreshGrid()
                conn.Close()


            Else
                MsgBox("No customer record has been deleted!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()


        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Try
            Dim sqlquery As String = "UPDATE Customer SET CustomerID= '" & txtCustomerID.Text.ToUpper & "', CustomerName = '" & txtCusName.Text.ToUpper & "', Gender = '" & cmbgender.Text.ToUpper & "', BirthDate = '" & dtpYr.Text.ToUpper & "' , ContactNo = '" & txtPh.Text.ToUpper & "' , City = '" & txtCity.Text.ToUpper & "' , Addres = '" & txtAdd.Text.ToUpper & "' , RegisterDate = '" & dtpReg.Text.ToLower & "', Email = '" & txtEmail.Text.ToLower & "' WHERE id = " & Me.Text
            Dim sqlcommand As New OleDbCommand

            conn.Open()
            With sqlcommand
                .CommandText = sqlquery
                .Connection = conn
                .ExecuteNonQuery()
            End With
            MsgBox("Record Successfully Updated.")
            RefreshGrid()
        Catch ex As Exception
            MsgBox(ex.Message)

            conn.Close()
        End Try


    End Sub
End Class