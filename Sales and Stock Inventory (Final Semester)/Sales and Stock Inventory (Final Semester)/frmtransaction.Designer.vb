<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtransaction
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtransaction))
        Me.lblDiscount = New System.Windows.Forms.Label
        Me.dgvItems = New System.Windows.Forms.DataGridView
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProdName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnPayment = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblTotalCost = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnNewTransacation = New System.Windows.Forms.Button
        Me.lblCustomerName = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblCustomerNo = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.lblInvoiceNo = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtQuantity = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.lblTime = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbldate = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(507, 453)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(47, 13)
        Me.lblDiscount.TabIndex = 6
        Me.lblDiscount.Text = "discount"
        Me.lblDiscount.Visible = False
        '
        'dgvItems
        '
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FloralWhite
        Me.dgvItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItems.BackgroundColor = System.Drawing.Color.White
        Me.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvItems.ColumnHeadersHeight = 24
        Me.dgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Quantity, Me.ItemCode, Me.ProdName, Me.UnitPrice, Me.Total})
        Me.dgvItems.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvItems.EnableHeadersVisualStyles = False
        Me.dgvItems.GridColor = System.Drawing.Color.White
        Me.dgvItems.Location = New System.Drawing.Point(1, 187)
        Me.dgvItems.MultiSelect = False
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.ReadOnly = True
        Me.dgvItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSalmon
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItems.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvItems.RowHeadersVisible = False
        Me.dgvItems.RowHeadersWidth = 25
        Me.dgvItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        Me.dgvItems.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvItems.RowTemplate.Height = 18
        Me.dgvItems.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItems.Size = New System.Drawing.Size(573, 291)
        Me.dgvItems.TabIndex = 49
        '
        'Quantity
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Quantity.DefaultCellStyle = DataGridViewCellStyle3
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'ItemCode
        '
        Me.ItemCode.HeaderText = "Item Code"
        Me.ItemCode.Name = "ItemCode"
        Me.ItemCode.ReadOnly = True
        '
        'ProdName
        '
        Me.ProdName.HeaderText = "Item Description"
        Me.ProdName.Name = "ProdName"
        Me.ProdName.ReadOnly = True
        '
        'UnitPrice
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "#,##0.00"
        Me.UnitPrice.DefaultCellStyle = DataGridViewCellStyle4
        Me.UnitPrice.HeaderText = "Price"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.ReadOnly = True
        '
        'Total
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "#,##0.00"
        Me.Total.DefaultCellStyle = DataGridViewCellStyle5
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.SteelBlue
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(7, 132)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(211, 36)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPayment.ForeColor = System.Drawing.Color.White
        Me.btnPayment.Location = New System.Drawing.Point(6, 90)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(211, 36)
        Me.btnPayment.TabIndex = 4
        Me.btnPayment.Text = "&Payment"
        Me.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(3, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 18)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Total Amount :"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Arial Rounded MT Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblTotalCost.Location = New System.Drawing.Point(33, 26)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(97, 43)
        Me.lblTotalCost.TabIndex = 6
        Me.lblTotalCost.Text = "0.00"
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(9, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Search"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.SteelBlue
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(6, 48)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(211, 36)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnNewTransacation
        '
        Me.btnNewTransacation.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNewTransacation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewTransacation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewTransacation.ForeColor = System.Drawing.Color.White
        Me.btnNewTransacation.Location = New System.Drawing.Point(7, 6)
        Me.btnNewTransacation.Name = "btnNewTransacation"
        Me.btnNewTransacation.Size = New System.Drawing.Size(211, 36)
        Me.btnNewTransacation.TabIndex = 0
        Me.btnNewTransacation.Text = "&New Transaction"
        Me.btnNewTransacation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNewTransacation.UseVisualStyleBackColor = False
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(72, 18)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(50, 18)
        Me.lblCustomerName.TabIndex = 0
        Me.lblCustomerName.Text = "Default"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(201, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KCC Canteen Transaction"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCustomerNo
        '
        Me.lblCustomerNo.AutoSize = True
        Me.lblCustomerNo.Location = New System.Drawing.Point(9, 18)
        Me.lblCustomerNo.Name = "lblCustomerNo"
        Me.lblCustomerNo.Size = New System.Drawing.Size(15, 18)
        Me.lblCustomerNo.TabIndex = 0
        Me.lblCustomerNo.Text = "1"
        Me.lblCustomerNo.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.txtQuantity)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.txtSearch)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(1, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(798, 115)
        Me.Panel2.TabIndex = 46
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.lblInvoiceNo)
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Location = New System.Drawing.Point(373, 53)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(199, 62)
        Me.Panel8.TabIndex = 4
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoiceNo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblInvoiceNo.Location = New System.Drawing.Point(76, 27)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(109, 24)
        Me.lblInvoiceNo.TabIndex = 2
        Me.lblInvoiceNo.Text = "100000001"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(3, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 18)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Invoice No :"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Location = New System.Drawing.Point(194, 81)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(32, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(235, 81)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(92, 23)
        Me.txtQuantity.TabIndex = 2
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(232, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Quantity"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.lblTime)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.lbldate)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Location = New System.Drawing.Point(-2, -6)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(574, 60)
        Me.Panel6.TabIndex = 1
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblTime.Location = New System.Drawing.Point(435, 23)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(47, 22)
        Me.lblTime.TabIndex = 4
        Me.lblTime.Text = "Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(370, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 22)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Time :"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lbldate.Location = New System.Drawing.Point(70, 21)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(44, 22)
        Me.lbldate.TabIndex = 0
        Me.lbldate.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(9, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Date :"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Panel9)
        Me.Panel5.Controls.Add(Me.lblTotalCost)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Location = New System.Drawing.Point(569, -3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(228, 116)
        Me.Panel5.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.lblCustomerName)
        Me.Panel9.Controls.Add(Me.lblCustomerNo)
        Me.Panel9.Controls.Add(Me.Label8)
        Me.Panel9.Location = New System.Drawing.Point(-1, 73)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(228, 42)
        Me.Panel9.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(2, 1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Customer :"
        '
        'txtSearch
        '
        Me.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSearch.Location = New System.Drawing.Point(12, 81)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(176, 23)
        Me.txtSearch.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(798, 73)
        Me.Panel1.TabIndex = 48
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Honeydew
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Label12)
        Me.Panel7.Controls.Add(Me.Label11)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.btnClose)
        Me.Panel7.Controls.Add(Me.btnPayment)
        Me.Panel7.Controls.Add(Me.btnRemove)
        Me.Panel7.Controls.Add(Me.btnNewTransacation)
        Me.Panel7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(574, 187)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(225, 291)
        Me.Panel7.TabIndex = 47
        '
        'Timer1
        '
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(13, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Crtl+N"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(14, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Crtl+R"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.SteelBlue
        Me.Label11.Location = New System.Drawing.Point(13, 99)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 18)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Crtl+P"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.SteelBlue
        Me.Label12.Location = New System.Drawing.Point(13, 141)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 18)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Crtl+ Esc"
        '
        'frmtransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 486)
        Me.Controls.Add(Me.dgvItems)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmtransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction"
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents dgvItems As System.Windows.Forms.DataGridView
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnPayment As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnNewTransacation As System.Windows.Forms.Button
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCustomerNo As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
