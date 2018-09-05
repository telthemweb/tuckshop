Imports System.Data.OleDb
Public Class SupplierList
    Private picdata As New DbConnect
    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function
    Public Sub RefreshGrid()
        ' RUN QUERY
        picdata.ExecQuery("SELECT * FROM Suppliers ORDER BY SupplierId ASC")
        ' REPORT & ABORT ON ERRORS
        If NotEmpty(picdata.Exception) Then MsgBox(picdata.Exception) : Exit Sub
        dgvData.DataSource = picdata.dt
    End Sub
    Private Sub SearchMember(Name As String)

        ' ADD PARAMETERS & RUN QUERY
        picdata.AddParam("@user", "%" & Name & "%")
        picdata.ExecQuery("SELECT SupplierId,supplierName,SupplierAddress,Email,Phone,RegisterDate " & _
                         "FROM Suppliers " & _
                         "WHERE supplierName LIKE @user")

        ' REPORT & ABORT ON ERRORS
        If NotEmpty(picdata.Exception) Then MsgBox(picdata.Exception) : Exit Sub

        ' FILL DATAGRIDVIEW
        dgvData.DataSource = picdata.dt


    End Sub
    Private Sub SupplierList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SupplierList_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        RefreshGrid()
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            MsgBox("Please fill me am empty", MsgBoxStyle.Critical)
            Exit Sub
        End If
        SearchMember(txtSearch.Text)
    End Sub

    Private Sub dgvData_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvData.CellClick
        Me.Text = dgvData.CurrentRow.Cells(0).Value.ToString
        txtSup.Text = dgvData.CurrentRow.Cells(1).Value.ToString
        txtSuname.Text = dgvData.CurrentRow.Cells(2).Value.ToString
        txtCity.Text = dgvData.CurrentRow.Cells(3).Value.ToString
        txtAdd.Text = dgvData.CurrentRow.Cells(4).Value.ToString
        txtPhone.Text = dgvData.CurrentRow.Cells(5).Value.ToString
        txtEmail.Text = dgvData.CurrentRow.Cells(6).Value.ToString
        lblRegdate.Text = dgvData.CurrentRow.Cells(7).Value.ToString
    End Sub

    Private Sub btnDel_Click(sender As System.Object, e As System.EventArgs) Handles btnDel.Click
        Try
            Sql = "DELETE * FROM Suppliers  WHERE S_id=" & Me.Text
            conn.Open()
            With dbcmd
                .CommandText = Sql
                .Connection = conn
            End With

            result = dbcmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("New Supplier record has been deleted!")
                RefreshGrid()
                conn.Close()


            Else
                MsgBox("No Supplier record has been deleted!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()


        End Try
    End Sub


    Private Sub btnUp_Click(sender As System.Object, e As System.EventArgs) Handles btnUp.Click

        Try
            Dim sqlquery As String = "UPDATE Suppliers SET SupplierId= '" & txtSup.Text.ToUpper & "', supplierName = '" & txtSuname.Text.ToUpper & "', City = '" & txtCity.Text.ToUpper & "' , SupplierAddress = '" & txtAdd.Text.ToUpper & "' , Phone = '" & txtPhone.Text.ToUpper & "' , Email = '" & txtEmail.Text.ToUpper & "' , RegisterDate = '" & lblRegdate.Text.ToUpper & "' WHERE S_id = " & Me.Text
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