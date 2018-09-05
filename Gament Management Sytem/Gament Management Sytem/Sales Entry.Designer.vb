<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sales_Entry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbProductId = New System.Windows.Forms.ComboBox()
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
        Me.datagridCustom = New System.Windows.Forms.DataGridView()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.txtCphone = New System.Windows.Forms.TextBox()
        Me.txtCaddress = New System.Windows.Forms.TextBox()
        Me.txtCcity = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbCID = New System.Windows.Forms.ComboBox()
        Me.txtCname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbCashier = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtReceipt = New System.Windows.Forms.TextBox()
        Me.dtpPach = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.datagridCustom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1205, 51)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Xerox Malfunction BRK", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(167, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sales Entry"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Webdings", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbProductId)
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
        Me.GroupBox3.Location = New System.Drawing.Point(29, 261)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(424, 227)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        '
        'cmbProductId
        '
        Me.cmbProductId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductId.FormattingEnabled = True
        Me.cmbProductId.Location = New System.Drawing.Point(155, 20)
        Me.cmbProductId.Name = "cmbProductId"
        Me.cmbProductId.Size = New System.Drawing.Size(193, 28)
        Me.cmbProductId.TabIndex = 19
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
        'datagridCustom
        '
        Me.datagridCustom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridCustom.Location = New System.Drawing.Point(12, 494)
        Me.datagridCustom.Name = "datagridCustom"
        Me.datagridCustom.Size = New System.Drawing.Size(1180, 220)
        Me.datagridCustom.TabIndex = 11
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(857, 348)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(146, 58)
        Me.Button10.TabIndex = 16
        Me.Button10.Text = "Close"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Blue
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.White
        Me.Button11.Location = New System.Drawing.Point(665, 348)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(162, 58)
        Me.Button11.TabIndex = 17
        Me.Button11.Text = "List"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'txtCphone
        '
        Me.txtCphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCphone.Location = New System.Drawing.Point(197, 156)
        Me.txtCphone.Name = "txtCphone"
        Me.txtCphone.Size = New System.Drawing.Size(193, 26)
        Me.txtCphone.TabIndex = 1
        '
        'txtCaddress
        '
        Me.txtCaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaddress.Location = New System.Drawing.Point(197, 124)
        Me.txtCaddress.Name = "txtCaddress"
        Me.txtCaddress.Size = New System.Drawing.Size(193, 26)
        Me.txtCaddress.TabIndex = 2
        '
        'txtCcity
        '
        Me.txtCcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCcity.Location = New System.Drawing.Point(197, 91)
        Me.txtCcity.Name = "txtCcity"
        Me.txtCcity.Size = New System.Drawing.Size(193, 26)
        Me.txtCcity.TabIndex = 3
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbCID)
        Me.GroupBox2.Controls.Add(Me.txtCname)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtCcity)
        Me.GroupBox2.Controls.Add(Me.txtCaddress)
        Me.GroupBox2.Controls.Add(Me.txtCphone)
        Me.GroupBox2.Location = New System.Drawing.Point(497, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(452, 245)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'cmbCID
        '
        Me.cmbCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCID.FormattingEnabled = True
        Me.cmbCID.Location = New System.Drawing.Point(197, 15)
        Me.cmbCID.Name = "cmbCID"
        Me.cmbCID.Size = New System.Drawing.Size(193, 28)
        Me.cmbCID.TabIndex = 12
        '
        'txtCname
        '
        Me.txtCname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCname.Location = New System.Drawing.Point(197, 59)
        Me.txtCname.Name = "txtCname"
        Me.txtCname.Size = New System.Drawing.Size(193, 26)
        Me.txtCname.TabIndex = 11
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbCashier)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtReceipt)
        Me.GroupBox1.Controls.Add(Me.dtpPach)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(441, 183)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'cmbCashier
        '
        Me.cmbCashier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCashier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCashier.FormattingEnabled = True
        Me.cmbCashier.Location = New System.Drawing.Point(191, 116)
        Me.cmbCashier.Name = "cmbCashier"
        Me.cmbCashier.Size = New System.Drawing.Size(216, 28)
        Me.cmbCashier.TabIndex = 23
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(13, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(133, 20)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Invoice Number"
        '
        'txtReceipt
        '
        Me.txtReceipt.BackColor = System.Drawing.Color.Silver
        Me.txtReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceipt.ForeColor = System.Drawing.Color.Red
        Me.txtReceipt.Location = New System.Drawing.Point(191, 21)
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
        Me.dtpPach.Location = New System.Drawing.Point(191, 68)
        Me.dtpPach.Name = "dtpPach"
        Me.dtpPach.Size = New System.Drawing.Size(219, 30)
        Me.dtpPach.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cashier Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Invoice Date"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Red
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(475, 348)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(160, 58)
        Me.Button9.TabIndex = 15
        Me.Button9.Text = "Save Record"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Gament_Management_Sytem.My.Resources.Resources._059_pervert
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(902, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(291, 263)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Sales_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 749)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.datagridCustom)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Sales_Entry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales_Entry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.datagridCustom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQnty As TextBox
    Friend WithEvents btnAddTot As Button
    Friend WithEvents datagridCustom As DataGridView
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents txtCphone As System.Windows.Forms.TextBox
    Friend WithEvents txtCaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCcity As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtReceipt As TextBox
    Friend WithEvents dtpPach As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents cmbCashier As ComboBox
    Friend WithEvents cmbProductId As ComboBox
    Friend WithEvents cmbCID As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
