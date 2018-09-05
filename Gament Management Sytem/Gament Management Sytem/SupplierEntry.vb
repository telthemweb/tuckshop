Imports System.Data.OleDb
Public Class SupplierEntry
    Private cb As New DbConnect
    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function


    Private Sub SupplierEntry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\gament.accdb")
        Str = "select * from Suppliers"
        dbcmd = New OleDbCommand(Str, con)
        dbda.SelectCommand = dbcmd
        dbda.Fill(ds, "Suppliers")

        'for generating supplier code and this code is unique.
        Dim LastNo As Integer
        LastNo = ds.Tables("Suppliers").Rows.Count + 1
        If LastNo >= 0 Then
            txtSup.Text = "S106700" & LastNo
        Else
            txtSup.Text = "S" & 0
        End If
    End Sub
    Private Sub AddSupplier()
        'add parameter
        cb.AddParam("@code", txtSup.Text)
        cb.AddParam("@name", txtSuname.Text)
        cb.AddParam("@city", txtCity.Text)
        cb.AddParam("@adress", txtAddress.Text)
        cb.AddParam("@phone", txtContact.Text)
        cb.AddParam("@email", txtEmail.Text)
        cb.AddParam("@datecreated", dtpDateCreated.Text)


        'execute command
        cb.ExecQuery("INSERT INTO Suppliers([SupplierId], [supplierName], [City], [SupplierAddress], [Phone], [Email],[RegisterDate]) VALUES(@code,@name,@city,@adress,@phone,@email,@datecreated)")

        ' REPORT & ABORT ON ERRORS
        If NotEmpty(cb.Exception) Then MsgBox(cb.Exception) : Exit Sub

        MsgBox("Supplier added successfully", MsgBoxStyle.Information)
        conn.Close()
    End Sub
    Public Sub RefreshGrid()
        ' RUN QUERY
        cb.ExecQuery("SELECT * FROM Suppliers ORDER BY SupplierId ASC")
        ' REPORT & ABORT ON ERRORS
        If NotEmpty(cb.Exception) Then MsgBox(cb.Exception) : Exit Sub
        dataColect.DataSource = cb.dt

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        AddSupplier()
        RefreshGrid()
    End Sub

    Private Sub SupplierEntry_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        RefreshGrid()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        SupplierList.ShowDialog()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

    End Sub
End Class