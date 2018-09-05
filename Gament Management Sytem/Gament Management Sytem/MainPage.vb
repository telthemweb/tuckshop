Public Class MainPage

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login.Show()
        Me.Hide()
        Login.txtPass.Clear()
        Login.txtUser.Clear()
        Login.cmbtypr.ResetText()
    End Sub

    Private Sub StockDetailsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        StockDetails.ShowDialog()
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Purchase.ShowDialog()
    End Sub

    Private Sub OrderDetailsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        OrderDetails.ShowDialog()
    End Sub

    Private Sub ProductEntryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProductEntryToolStripMenuItem.Click
        ProductEntry.ShowDialog()
    End Sub

 

    Private Sub SupplierEntryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        SupplierEntry.ShowDialog()
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        Sales_Entry.ShowDialog()
    End Sub

    Private Sub CustomerEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerEntryToolStripMenuItem.Click
        Customer_Entry.ShowDialog()
    End Sub

    Private Sub CustomerListToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Customer_List.ShowDialog()
    End Sub

    Private Sub UserRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs)
        UserRegistration.ShowDialog()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Sales_Entry.ShowDialog()
    End Sub

   

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Login.Show()
        Me.Hide()
        Login.txtPass.Clear()
        Login.txtUser.Clear()
        Login.cmbtypr.ResetText()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles btnOrder.Click
        OrderDetails.ShowDialog()
    End Sub

    Private Sub MainPage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddSupplierToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddSupplierToolStripMenuItem.Click
        SupplierEntry.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles btnSuppliers.Click
        SupplierEntry.ShowDialog()
    End Sub

    Private Sub OrderEntryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OrderEntryToolStripMenuItem.Click
        OrderDetails.ShowDialog()
    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StockToolStripMenuItem.Click
        StockDetails.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles btnPuchase.Click
        Purchase.ShowDialog()
    End Sub

    Private Sub PurchaseToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PurchaseToolStripMenuItem1.Click
        Purchase.ShowDialog()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalesToolStripMenuItem.Click
        Sales_Entry.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles btnCust.Click
        Customer_Entry.ShowDialog()
    End Sub

    Private Sub btnStock_Click(sender As System.Object, e As System.EventArgs) Handles btnStock.Click
        StockDetails.ShowDialog()
    End Sub
End Class