<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockDetails))
        Me.stGridview = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnStocl = New System.Windows.Forms.Button()
        Me.cmbPro = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rtcTDiscript = New System.Windows.Forms.RichTextBox()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPname = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtdisc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtQnty = New System.Windows.Forms.TextBox()
        CType(Me.stGridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'stGridview
        '
        Me.stGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.stGridview.Location = New System.Drawing.Point(12, 368)
        Me.stGridview.Name = "stGridview"
        Me.stGridview.Size = New System.Drawing.Size(1302, 340)
        Me.stGridview.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1338, 100)
        Me.Panel1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Silver
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(634, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(356, 37)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Xtrusion (BRK)", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(62, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.btnStocl)
        Me.GroupBox3.Controls.Add(Me.cmbPro)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtCost)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.rtcTDiscript)
        Me.GroupBox3.Controls.Add(Me.txtVat)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtPname)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtdisc)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtPrice)
        Me.GroupBox3.Controls.Add(Me.txtQnty)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 106)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1302, 256)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1016, 189)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 50)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnStocl
        '
        Me.btnStocl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStocl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStocl.Location = New System.Drawing.Point(824, 189)
        Me.btnStocl.Name = "btnStocl"
        Me.btnStocl.Size = New System.Drawing.Size(163, 50)
        Me.btnStocl.TabIndex = 32
        Me.btnStocl.Text = "Add Stock"
        Me.btnStocl.UseVisualStyleBackColor = True
        '
        'cmbPro
        '
        Me.cmbPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPro.FormattingEnabled = True
        Me.cmbPro.Location = New System.Drawing.Point(201, 31)
        Me.cmbPro.Name = "cmbPro"
        Me.cmbPro.Size = New System.Drawing.Size(259, 33)
        Me.cmbPro.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(483, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Selling Price $"
        '
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(605, 94)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(215, 31)
        Me.txtCost.TabIndex = 29
        Me.txtCost.Text = "0.0"
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Product Description"
        '
        'rtcTDiscript
        '
        Me.rtcTDiscript.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtcTDiscript.Location = New System.Drawing.Point(201, 117)
        Me.rtcTDiscript.Name = "rtcTDiscript"
        Me.rtcTDiscript.Size = New System.Drawing.Size(259, 96)
        Me.rtcTDiscript.TabIndex = 27
        Me.rtcTDiscript.Text = ""
        '
        'txtVat
        '
        Me.txtVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVat.Location = New System.Drawing.Point(1025, 80)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(193, 31)
        Me.txtVat.TabIndex = 26
        Me.txtVat.Text = "0"
        Me.txtVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(883, 83)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 20)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "VAT"
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
        Me.txtPname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPname.Location = New System.Drawing.Point(201, 76)
        Me.txtPname.Name = "txtPname"
        Me.txtPname.Size = New System.Drawing.Size(259, 31)
        Me.txtPname.TabIndex = 23
        Me.txtPname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(883, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 20)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Discount"
        '
        'txtdisc
        '
        Me.txtdisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdisc.Location = New System.Drawing.Point(1025, 27)
        Me.txtdisc.Name = "txtdisc"
        Me.txtdisc.Size = New System.Drawing.Size(193, 31)
        Me.txtdisc.TabIndex = 10
        Me.txtdisc.Text = "0"
        Me.txtdisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(483, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 20)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Cost Price $"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(483, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 20)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Quantity"
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
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(605, 148)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(215, 31)
        Me.txtPrice.TabIndex = 2
        Me.txtPrice.Text = "0.00"
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQnty
        '
        Me.txtQnty.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQnty.Location = New System.Drawing.Point(605, 34)
        Me.txtQnty.Name = "txtQnty"
        Me.txtQnty.Size = New System.Drawing.Size(215, 31)
        Me.txtQnty.TabIndex = 1
        Me.txtQnty.Text = "0"
        Me.txtQnty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'StockDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1338, 720)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.stGridview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StockDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock"
        CType(Me.stGridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents stGridview As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtVat As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtPname As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtdisc As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtQnty As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnStocl As System.Windows.Forms.Button
    Friend WithEvents cmbPro As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rtcTDiscript As System.Windows.Forms.RichTextBox
End Class
