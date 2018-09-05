<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales_ListView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales_ListView))
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Salesdata = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCashier = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtReceipt = New System.Windows.Forms.TextBox()
        Me.dtpPach = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtProductId = New System.Windows.Forms.TextBox()
        Me.btnAddTot = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtQnty = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCID = New System.Windows.Forms.TextBox()
        Me.txtCname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCcity = New System.Windows.Forms.TextBox()
        Me.txtCaddress = New System.Windows.Forms.TextBox()
        Me.txtCphone = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Salesdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Red
        Me.btnUpdate.Image = Global.Gament_Management_Sytem.My.Resources.Resources.Actions_list_add_user_icon
        Me.btnUpdate.Location = New System.Drawing.Point(152, 220)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(196, 49)
        Me.btnUpdate.TabIndex = 31
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1364, 57)
        Me.Panel1.TabIndex = 37
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(933, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(361, 31)
        Me.txtSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(61, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales List"
        '
        'Salesdata
        '
        Me.Salesdata.BackgroundColor = System.Drawing.Color.Gray
        Me.Salesdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salesdata.GridColor = System.Drawing.Color.Black
        Me.Salesdata.Location = New System.Drawing.Point(12, 390)
        Me.Salesdata.Name = "Salesdata"
        Me.Salesdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Salesdata.Size = New System.Drawing.Size(1331, 329)
        Me.Salesdata.TabIndex = 38
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.Gament_Management_Sytem.My.Resources.Resources.Delete
        Me.Button2.Location = New System.Drawing.Point(1189, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 52)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Delete"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.Gament_Management_Sytem.My.Resources.Resources.Printer_icon
        Me.Button3.Location = New System.Drawing.Point(933, 65)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(196, 52)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "Print Receipt"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCashier)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtReceipt)
        Me.GroupBox1.Controls.Add(Me.dtpPach)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(441, 286)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'txtCashier
        '
        Me.txtCashier.BackColor = System.Drawing.Color.Silver
        Me.txtCashier.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCashier.Enabled = False
        Me.txtCashier.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashier.ForeColor = System.Drawing.Color.Black
        Me.txtCashier.Location = New System.Drawing.Point(191, 196)
        Me.txtCashier.Name = "txtCashier"
        Me.txtCashier.Size = New System.Drawing.Size(225, 28)
        Me.txtCashier.TabIndex = 23
        Me.txtCashier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(13, 41)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(133, 20)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Invoice Number"
        '
        'txtReceipt
        '
        Me.txtReceipt.BackColor = System.Drawing.Color.Silver
        Me.txtReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtReceipt.Enabled = False
        Me.txtReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceipt.ForeColor = System.Drawing.Color.Red
        Me.txtReceipt.Location = New System.Drawing.Point(191, 38)
        Me.txtReceipt.Name = "txtReceipt"
        Me.txtReceipt.Size = New System.Drawing.Size(225, 28)
        Me.txtReceipt.TabIndex = 21
        Me.txtReceipt.Text = "00000000000"
        Me.txtReceipt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpPach
        '
        Me.dtpPach.Enabled = False
        Me.dtpPach.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPach.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPach.Location = New System.Drawing.Point(191, 120)
        Me.dtpPach.Name = "dtpPach"
        Me.dtpPach.Size = New System.Drawing.Size(219, 30)
        Me.dtpPach.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cashier Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Invoice Date"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtProductId)
        Me.GroupBox3.Controls.Add(Me.btnUpdate)
        Me.GroupBox3.Controls.Add(Me.btnAddTot)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtPName)
        Me.GroupBox3.Controls.Add(Me.txtPrice)
        Me.GroupBox3.Controls.Add(Me.txtQnty)
        Me.GroupBox3.Location = New System.Drawing.Point(459, 87)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(424, 275)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        '
        'txtProductId
        '
        Me.txtProductId.BackColor = System.Drawing.Color.Silver
        Me.txtProductId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProductId.Enabled = False
        Me.txtProductId.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductId.ForeColor = System.Drawing.Color.Black
        Me.txtProductId.Location = New System.Drawing.Point(152, 19)
        Me.txtProductId.Name = "txtProductId"
        Me.txtProductId.Size = New System.Drawing.Size(196, 28)
        Me.txtProductId.TabIndex = 24
        Me.txtProductId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAddTot
        '
        Me.btnAddTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTot.Location = New System.Drawing.Point(357, 100)
        Me.btnAddTot.Name = "btnAddTot"
        Me.btnAddTot.Size = New System.Drawing.Size(36, 23)
        Me.btnAddTot.TabIndex = 18
        Me.btnAddTot.Text = "..."
        Me.btnAddTot.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 172)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(141, 20)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Total Amount   $"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(155, 166)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(193, 26)
        Me.txtTotal.TabIndex = 10
        Me.txtTotal.Text = "0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 20)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Qty"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 20)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Price $"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 20)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Product Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(7, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 20)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Product Code"
        '
        'txtPName
        '
        Me.txtPName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPName.Location = New System.Drawing.Point(155, 54)
        Me.txtPName.Name = "txtPName"
        Me.txtPName.Size = New System.Drawing.Size(193, 26)
        Me.txtPName.TabIndex = 3
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(155, 87)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(193, 26)
        Me.txtPrice.TabIndex = 2
        Me.txtPrice.Text = "0.00"
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQnty
        '
        Me.txtQnty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQnty.Location = New System.Drawing.Point(155, 119)
        Me.txtQnty.Name = "txtQnty"
        Me.txtQnty.Size = New System.Drawing.Size(193, 26)
        Me.txtQnty.TabIndex = 1
        Me.txtQnty.Text = "0"
        Me.txtQnty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCID)
        Me.GroupBox2.Controls.Add(Me.txtCname)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtCcity)
        Me.GroupBox2.Controls.Add(Me.txtCaddress)
        Me.GroupBox2.Controls.Add(Me.txtCphone)
        Me.GroupBox2.Location = New System.Drawing.Point(900, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(452, 230)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        '
        'txtCID
        '
        Me.txtCID.BackColor = System.Drawing.Color.Silver
        Me.txtCID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCID.Enabled = False
        Me.txtCID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCID.ForeColor = System.Drawing.Color.Black
        Me.txtCID.Location = New System.Drawing.Point(197, 16)
        Me.txtCID.Name = "txtCID"
        Me.txtCID.Size = New System.Drawing.Size(193, 28)
        Me.txtCID.TabIndex = 24
        Me.txtCID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCname
        '
        Me.txtCname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCname.Location = New System.Drawing.Point(197, 59)
        Me.txtCname.Name = "txtCname"
        Me.txtCname.Size = New System.Drawing.Size(193, 26)
        Me.txtCname.TabIndex = 11
        Me.txtCname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Customer Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Contact Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(33, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 20)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "City"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(33, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "CustomerID"
        '
        'txtCcity
        '
        Me.txtCcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCcity.Location = New System.Drawing.Point(197, 91)
        Me.txtCcity.Name = "txtCcity"
        Me.txtCcity.Size = New System.Drawing.Size(193, 26)
        Me.txtCcity.TabIndex = 3
        Me.txtCcity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCaddress
        '
        Me.txtCaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaddress.Location = New System.Drawing.Point(197, 124)
        Me.txtCaddress.Name = "txtCaddress"
        Me.txtCaddress.Size = New System.Drawing.Size(193, 26)
        Me.txtCaddress.TabIndex = 2
        Me.txtCaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCphone
        '
        Me.txtCphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCphone.Location = New System.Drawing.Point(197, 156)
        Me.txtCphone.Name = "txtCphone"
        Me.txtCphone.Size = New System.Drawing.Size(193, 26)
        Me.txtCphone.TabIndex = 1
        Me.txtCphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sales_ListView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 749)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Salesdata)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Sales_ListView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Salesdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Salesdata As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtReceipt As TextBox
    Friend WithEvents dtpPach As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnAddTot As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQnty As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCcity As TextBox
    Friend WithEvents txtCaddress As TextBox
    Friend WithEvents txtCphone As TextBox
    Friend WithEvents txtCashier As TextBox
    Friend WithEvents txtProductId As TextBox
    Friend WithEvents txtCID As TextBox
End Class
