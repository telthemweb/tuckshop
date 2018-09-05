Imports System.Data.OleDb
Public Class Customer_Entry
    Private cb As New DbConnect
    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function
    Public Sub cleartextfields()
        For Each crt As Control In GroupBox1.Controls
            If crt.GetType Is GetType(TextBox) Then
                crt.Text = Nothing
            End If
        Next

    End Sub
    Private Sub Customer_Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\gament.accdb")
        Str = "select * from Customer"
        dbcmd = New OleDbCommand(Str, con)
        dbda.SelectCommand = dbcmd
        dbda.Fill(ds, "Customer")
        con.Open()
        'for registration No.
        Dim LastNo As Integer
        LastNo = ds.Tables("Customer").Rows.Count + 1
        If LastNo >= 0 Then
            txtCustomerID.Text = "C00" & LastNo
        Else
            txtCustomerID.Text = "C" & 0
        End If
    End Sub
    Private Sub AddUser()
        'add parameter
        cb.AddParam("@cid", txtCustomerID.Text)
        cb.AddParam("@name", txtCusName.Text)
        cb.AddParam("@gender", cmbgender.Text)
        cb.AddParam("@dob", dtpYr.Text)
        cb.AddParam("@phone", txtPh.Text)
        cb.AddParam("@city", txtCity.Text)
        cb.AddParam("@adress", txtAdd.Text)
        cb.AddParam("@datecreated", dtpReg.Text)
        cb.AddParam("@email", txtEmail.Text)

        'execute command
        cb.ExecQuery("INSERT INTO Customer([CustomerID], [CustomerName], [Gender], [BirthDate], [ContactNo], [City],[Addres],[RegisterDate],[Email]) VALUES(@cid,@name,@gender,@dob,@phone,@city,@adress,@datecreated,@email)")

        ' REPORT & ABORT ON ERRORS
        If NotEmpty(cb.Exception) Then MsgBox(cb.Exception) : Exit Sub

        MsgBox("Customer added", MsgBoxStyle.Information)
        conn.Close()
    End Sub
    Public Sub RefreshGrid()
        ' RUN QUERY
        cb.ExecQuery("SELECT * FROM Customer ORDER BY CustomerID ASC")
        ' REPORT & ABORT ON ERRORS
        If NotEmpty(cb.Exception) Then MsgBox(cb.Exception) : Exit Sub
        Datacustomer.DataSource = cb.dt

    End Sub

   

    Private Sub Customer_Entry_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        RefreshGrid()
    End Sub

    Private Sub List_Click(sender As System.Object, e As System.EventArgs)
        Customer_List.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        cleartextfields()
    End Sub

    Private Sub List_Click_1(sender As System.Object, e As System.EventArgs) Handles List.Click
        Customer_List.ShowDialog()
    End Sub

    Private Sub txtCusName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCusName.TextChanged
        DisallowNumber(txtCusName)
    End Sub

    Private Sub Button4_Click_1(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        AddUser()
        RefreshGrid()
    End Sub
End Class