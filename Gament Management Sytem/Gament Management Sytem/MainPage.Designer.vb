<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSuppliers = New System.Windows.Forms.Button()
        Me.btnCust = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnPuchase = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.btnLog)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1348, 100)
        Me.Panel1.TabIndex = 0
        '
        'btnLog
        '
        Me.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLog.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.ForeColor = System.Drawing.Color.Red
        Me.btnLog.Image = Global.Gament_Management_Sytem.My.Resources.Resources.Actions_list_add_user_icon
        Me.btnLog.Location = New System.Drawing.Point(1021, 42)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(304, 47)
        Me.btnLog.TabIndex = 11
        Me.btnLog.Text = "Hi"
        Me.btnLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(374, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(582, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "GARMENT MANAGEMENT SYSTEM"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Red
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(1331, -1)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(31, 29)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "X"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SuppliersToolStripMenuItem, Me.ProductsToolStripMenuItem1, Me.CustomerToolStripMenuItem, Me.StockToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.SalesToolStripMenuItem, Me.PurchaseToolStripMenuItem1, Me.OrderToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1348, 28)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SuppliersToolStripMenuItem
        '
        Me.SuppliersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSupplierToolStripMenuItem})
        Me.SuppliersToolStripMenuItem.Image = Global.Gament_Management_Sytem.My.Resources.Resources.order_icon
        Me.SuppliersToolStripMenuItem.Name = "SuppliersToolStripMenuItem"
        Me.SuppliersToolStripMenuItem.Size = New System.Drawing.Size(101, 24)
        Me.SuppliersToolStripMenuItem.Text = "Suppliers"
        '
        'AddSupplierToolStripMenuItem
        '
        Me.AddSupplierToolStripMenuItem.Name = "AddSupplierToolStripMenuItem"
        Me.AddSupplierToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.AddSupplierToolStripMenuItem.Text = "Add Supplier"
        '
        'ProductsToolStripMenuItem1
        '
        Me.ProductsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductEntryToolStripMenuItem})
        Me.ProductsToolStripMenuItem1.Name = "ProductsToolStripMenuItem1"
        Me.ProductsToolStripMenuItem1.Size = New System.Drawing.Size(83, 24)
        Me.ProductsToolStripMenuItem1.Text = "Products"
        '
        'ProductEntryToolStripMenuItem
        '
        Me.ProductEntryToolStripMenuItem.Name = "ProductEntryToolStripMenuItem"
        Me.ProductEntryToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.ProductEntryToolStripMenuItem.Text = "Product Entry"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerEntryToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'CustomerEntryToolStripMenuItem
        '
        Me.CustomerEntryToolStripMenuItem.Name = "CustomerEntryToolStripMenuItem"
        Me.CustomerEntryToolStripMenuItem.Size = New System.Drawing.Size(188, 24)
        Me.CustomerEntryToolStripMenuItem.Text = "Customer Entry"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseToolStripMenuItem, Me.OrdersToolStripMenuItem, Me.StocksToolStripMenuItem, Me.SupplierToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'PurchaseToolStripMenuItem
        '
        Me.PurchaseToolStripMenuItem.Name = "PurchaseToolStripMenuItem"
        Me.PurchaseToolStripMenuItem.Size = New System.Drawing.Size(141, 24)
        Me.PurchaseToolStripMenuItem.Text = "Purchase"
        '
        'OrdersToolStripMenuItem
        '
        Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
        Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(141, 24)
        Me.OrdersToolStripMenuItem.Text = "Orders"
        '
        'StocksToolStripMenuItem
        '
        Me.StocksToolStripMenuItem.Name = "StocksToolStripMenuItem"
        Me.StocksToolStripMenuItem.Size = New System.Drawing.Size(141, 24)
        Me.StocksToolStripMenuItem.Text = "Stocks"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(141, 24)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'PurchaseToolStripMenuItem1
        '
        Me.PurchaseToolStripMenuItem1.Name = "PurchaseToolStripMenuItem1"
        Me.PurchaseToolStripMenuItem1.Size = New System.Drawing.Size(84, 24)
        Me.PurchaseToolStripMenuItem1.Text = "Purchase"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderEntryToolStripMenuItem})
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.OrderToolStripMenuItem.Text = "Order"
        '
        'OrderEntryToolStripMenuItem
        '
        Me.OrderEntryToolStripMenuItem.Name = "OrderEntryToolStripMenuItem"
        Me.OrderEntryToolStripMenuItem.Size = New System.Drawing.Size(158, 24)
        Me.OrderEntryToolStripMenuItem.Text = "order Entry"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Location = New System.Drawing.Point(369, 330)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(627, 318)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(221, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(185, 78)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Contact Me"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(257, 159)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(103, 13)
        Me.LinkLabel2.TabIndex = 2
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "www.ellahsales.com"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gament_Management_Sytem.My.Resources.Resources.order_icon
        Me.PictureBox1.Location = New System.Drawing.Point(285, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 55)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(621, 53)
        Me.Panel2.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Image = Global.Gament_Management_Sytem.My.Resources.Resources.Info_32x32
        Me.Button2.Location = New System.Drawing.Point(9, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 36)
        Me.Button2.TabIndex = 1
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(84, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Info"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Navy
        Me.Panel3.Controls.Add(Me.btnSuppliers)
        Me.Panel3.Controls.Add(Me.btnCust)
        Me.Panel3.Controls.Add(Me.btnSales)
        Me.Panel3.Controls.Add(Me.btnStock)
        Me.Panel3.Controls.Add(Me.btnOrder)
        Me.Panel3.Controls.Add(Me.btnPuchase)
        Me.Panel3.Location = New System.Drawing.Point(372, 174)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(627, 138)
        Me.Panel3.TabIndex = 2
        '
        'btnSuppliers
        '
        Me.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuppliers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuppliers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSuppliers.Location = New System.Drawing.Point(413, 78)
        Me.btnSuppliers.Name = "btnSuppliers"
        Me.btnSuppliers.Size = New System.Drawing.Size(174, 47)
        Me.btnSuppliers.TabIndex = 5
        Me.btnSuppliers.Text = "Suppliers"
        Me.btnSuppliers.UseVisualStyleBackColor = True
        '
        'btnCust
        '
        Me.btnCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCust.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCust.Location = New System.Drawing.Point(38, 78)
        Me.btnCust.Name = "btnCust"
        Me.btnCust.Size = New System.Drawing.Size(174, 47)
        Me.btnCust.TabIndex = 4
        Me.btnCust.Text = "Customers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnCust.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSales.Location = New System.Drawing.Point(412, 15)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(174, 47)
        Me.btnSales.TabIndex = 3
        Me.btnSales.Text = "Sales"
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnStock
        '
        Me.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnStock.Location = New System.Drawing.Point(223, 78)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(174, 47)
        Me.btnStock.TabIndex = 2
        Me.btnStock.Text = "Stock"
        Me.btnStock.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnOrder.Location = New System.Drawing.Point(223, 15)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(174, 47)
        Me.btnOrder.TabIndex = 1
        Me.btnOrder.Text = "Orders"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnPuchase
        '
        Me.btnPuchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPuchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPuchase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPuchase.Location = New System.Drawing.Point(38, 15)
        Me.btnPuchase.Name = "btnPuchase"
        Me.btnPuchase.Size = New System.Drawing.Size(174, 47)
        Me.btnPuchase.TabIndex = 0
        Me.btnPuchase.Text = "Purchases"
        Me.btnPuchase.UseVisualStyleBackColor = True
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gament_Management_Sytem.My.Resources.Resources.home
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1348, 710)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SuppliersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProductsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSales As Button
    Friend WithEvents btnStock As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnPuchase As Button
    Friend WithEvents btnSuppliers As Button
    Friend WithEvents btnCust As Button
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnLog As System.Windows.Forms.Button
    Friend WithEvents StockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StocksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
