<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase_List
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Purchase_List))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtReceipt = New System.Windows.Forms.TextBox()
        Me.cmbModePay = New System.Windows.Forms.ComboBox()
        Me.dtpPach = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtParc = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cmbSupNum = New System.Windows.Forms.TextBox()
        Me.txtSpName = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddres = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbProductCod = New System.Windows.Forms.TextBox()
        Me.txtSupled = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPname = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtQnty = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Puchasedata = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Puchasedata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtReceipt)
        Me.GroupBox1.Controls.Add(Me.cmbModePay)
        Me.GroupBox1.Controls.Add(Me.dtpPach)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtParc)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(441, 299)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(38, 29)
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
        Me.txtReceipt.Location = New System.Drawing.Point(191, 21)
        Me.txtReceipt.Name = "txtReceipt"
        Me.txtReceipt.Size = New System.Drawing.Size(225, 28)
        Me.txtReceipt.TabIndex = 21
        Me.txtReceipt.Text = "00000000000"
        Me.txtReceipt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbModePay
        '
        Me.cmbModePay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModePay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModePay.FormattingEnabled = True
        Me.cmbModePay.Items.AddRange(New Object() {"EcoCash", "Telcach", "Swiping", "Credit", "Cheque"})
        Me.cmbModePay.Location = New System.Drawing.Point(223, 195)
        Me.cmbModePay.Name = "cmbModePay"
        Me.cmbModePay.Size = New System.Drawing.Size(190, 28)
        Me.cmbModePay.TabIndex = 20
        '
        'dtpPach
        '
        Me.dtpPach.Enabled = False
        Me.dtpPach.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPach.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPach.Location = New System.Drawing.Point(220, 135)
        Me.dtpPach.Name = "dtpPach"
        Me.dtpPach.Size = New System.Drawing.Size(193, 30)
        Me.dtpPach.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Payment Mode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Purchas Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Purchase Code"
        '
        'txtParc
        '
        Me.txtParc.Enabled = False
        Me.txtParc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParc.Location = New System.Drawing.Point(220, 76)
        Me.txtParc.Name = "txtParc"
        Me.txtParc.Size = New System.Drawing.Size(193, 26)
        Me.txtParc.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.cmbSupNum)
        Me.GroupBox2.Controls.Add(Me.txtSpName)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtCity)
        Me.GroupBox2.Controls.Add(Me.txtAddres)
        Me.GroupBox2.Controls.Add(Me.txtPhone)
        Me.GroupBox2.Location = New System.Drawing.Point(900, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(452, 299)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Red
        Me.btnUpdate.Image = Global.Gament_Management_Sytem.My.Resources.Resources.Actions_list_add_user_icon
        Me.btnUpdate.Location = New System.Drawing.Point(195, 244)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(196, 49)
        Me.btnUpdate.TabIndex = 31
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'cmbSupNum
        '
        Me.cmbSupNum.Enabled = False
        Me.cmbSupNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupNum.Location = New System.Drawing.Point(198, 29)
        Me.cmbSupNum.Name = "cmbSupNum"
        Me.cmbSupNum.Size = New System.Drawing.Size(193, 26)
        Me.cmbSupNum.TabIndex = 24
        Me.cmbSupNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSpName
        '
        Me.txtSpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpName.Location = New System.Drawing.Point(198, 70)
        Me.txtSpName.Name = "txtSpName"
        Me.txtSpName.Size = New System.Drawing.Size(193, 26)
        Me.txtSpName.TabIndex = 22
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(34, 33)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 20)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "Supplier Id" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Contact Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 20)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "City"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Supplier Name"
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(198, 120)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(193, 26)
        Me.txtCity.TabIndex = 3
        '
        'txtAddres
        '
        Me.txtAddres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddres.Location = New System.Drawing.Point(198, 161)
        Me.txtAddres.Name = "txtAddres"
        Me.txtAddres.Size = New System.Drawing.Size(193, 26)
        Me.txtAddres.TabIndex = 2
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(198, 203)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(193, 26)
        Me.txtPhone.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbProductCod)
        Me.GroupBox3.Controls.Add(Me.txtSupled)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtPname)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtPrice)
        Me.GroupBox3.Controls.Add(Me.txtQnty)
        Me.GroupBox3.Location = New System.Drawing.Point(490, 101)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 299)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        '
        'cmbProductCod
        '
        Me.cmbProductCod.Enabled = False
        Me.cmbProductCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductCod.Location = New System.Drawing.Point(148, 24)
        Me.cmbProductCod.Name = "cmbProductCod"
        Me.cmbProductCod.Size = New System.Drawing.Size(193, 26)
        Me.cmbProductCod.TabIndex = 23
        Me.cmbProductCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSupled
        '
        Me.txtSupled.Enabled = False
        Me.txtSupled.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupled.Location = New System.Drawing.Point(148, 229)
        Me.txtSupled.Name = "txtSupled"
        Me.txtSupled.Size = New System.Drawing.Size(193, 26)
        Me.txtSupled.TabIndex = 26
        Me.txtSupled.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(9, 235)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 20)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Supplied by" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 20)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Product Code"
        '
        'txtPname
        '
        Me.txtPname.Enabled = False
        Me.txtPname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPname.Location = New System.Drawing.Point(148, 70)
        Me.txtPname.Name = "txtPname"
        Me.txtPname.Size = New System.Drawing.Size(193, 26)
        Me.txtPname.TabIndex = 23
        Me.txtPname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(347, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = ",,,,"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 198)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(141, 20)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Total Amount   $"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(148, 195)
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
        Me.Label11.Location = New System.Drawing.Point(18, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 20)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Qty"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 20)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Price $"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 76)
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
        Me.Label14.Size = New System.Drawing.Size(0, 20)
        Me.Label14.TabIndex = 4
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(148, 117)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(193, 26)
        Me.txtPrice.TabIndex = 2
        Me.txtPrice.Text = "0.00"
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQnty
        '
        Me.txtQnty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQnty.Location = New System.Drawing.Point(148, 149)
        Me.txtQnty.Name = "txtQnty"
        Me.txtQnty.Size = New System.Drawing.Size(193, 26)
        Me.txtQnty.TabIndex = 1
        Me.txtQnty.Text = "0"
        Me.txtQnty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.Panel1.TabIndex = 25
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
        Me.Label1.Size = New System.Drawing.Size(444, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Update Purchase List"
        '
        'Puchasedata
        '
        Me.Puchasedata.BackgroundColor = System.Drawing.Color.Gray
        Me.Puchasedata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Puchasedata.GridColor = System.Drawing.Color.Black
        Me.Puchasedata.Location = New System.Drawing.Point(12, 463)
        Me.Puchasedata.Name = "Puchasedata"
        Me.Puchasedata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Puchasedata.Size = New System.Drawing.Size(1331, 274)
        Me.Puchasedata.TabIndex = 26
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.Gament_Management_Sytem.My.Resources.Resources.Printer_icon
        Me.Button3.Location = New System.Drawing.Point(933, 59)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(196, 52)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Print Receipt"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.Gament_Management_Sytem.My.Resources.Resources.Delete
        Me.Button2.Location = New System.Drawing.Point(1189, 59)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 52)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Delete"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Purchase_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 749)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Puchasedata)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Purchase_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Puchasedata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtReceipt As TextBox
    Friend WithEvents cmbModePay As ComboBox
    Friend WithEvents dtpPach As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtParc As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSpName As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddres As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtSupled As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtPname As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQnty As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Puchasedata As DataGridView
    Friend WithEvents cmbProductCod As TextBox
    Friend WithEvents cmbSupNum As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
