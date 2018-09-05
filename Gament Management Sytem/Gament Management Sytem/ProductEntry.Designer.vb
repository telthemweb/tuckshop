<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductEntry
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
        Me.txtPname = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSP = New System.Windows.Forms.TextBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPc = New System.Windows.Forms.TextBox()
        Me.dtpAdded = New System.Windows.Forms.DateTimePicker()
        Me.cmbSupply = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPname
        '
        Me.txtPname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPname.Location = New System.Drawing.Point(233, 114)
        Me.txtPname.Name = "txtPname"
        Me.txtPname.Size = New System.Drawing.Size(309, 35)
        Me.txtPname.TabIndex = 1
        Me.txtPname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(231, 155)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(309, 47)
        Me.txtDesc.TabIndex = 4
        Me.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Product Description"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 222)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 21)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Color"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(36, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 21)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Product Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(851, 45)
        Me.Panel1.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(381, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 21)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Products"
        '
        'btnNew
        '
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.OliveDrab
        Me.btnNew.Location = New System.Drawing.Point(581, 157)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(169, 45)
        Me.btnNew.TabIndex = 23
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.BackColor = System.Drawing.Color.Blue
        Me.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnList.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnList.Location = New System.Drawing.Point(581, 104)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(169, 45)
        Me.btnList.TabIndex = 24
        Me.btnList.Text = "List"
        Me.btnList.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(202, 408)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(229, 45)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSP)
        Me.GroupBox1.Location = New System.Drawing.Point(50, 329)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(502, 64)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 21)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Selling Price   $"
        '
        'txtSP
        '
        Me.txtSP.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSP.Location = New System.Drawing.Point(340, 11)
        Me.txtSP.Name = "txtSP"
        Me.txtSP.Size = New System.Drawing.Size(142, 33)
        Me.txtSP.TabIndex = 16
        Me.txtSP.Text = "0.00"
        Me.txtSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(22, 459)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(797, 143)
        Me.dgvData.TabIndex = 31
        '
        'txtColor
        '
        Me.txtColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.Location = New System.Drawing.Point(231, 208)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(309, 35)
        Me.txtColor.TabIndex = 32
        Me.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 21)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Product Code"
        '
        'txtPc
        '
        Me.txtPc.Enabled = False
        Me.txtPc.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPc.Location = New System.Drawing.Point(231, 60)
        Me.txtPc.Name = "txtPc"
        Me.txtPc.Size = New System.Drawing.Size(309, 35)
        Me.txtPc.TabIndex = 33
        Me.txtPc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpAdded
        '
        Me.dtpAdded.Enabled = False
        Me.dtpAdded.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAdded.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAdded.Location = New System.Drawing.Point(683, 60)
        Me.dtpAdded.Name = "dtpAdded"
        Me.dtpAdded.Size = New System.Drawing.Size(156, 31)
        Me.dtpAdded.TabIndex = 35
        '
        'cmbSupply
        '
        Me.cmbSupply.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupply.FormattingEnabled = True
        Me.cmbSupply.Location = New System.Drawing.Point(231, 267)
        Me.cmbSupply.Name = "cmbSupply"
        Me.cmbSupply.Size = New System.Drawing.Size(311, 37)
        Me.cmbSupply.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 21)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Supplied by"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(577, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 21)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "Date" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ProductEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 614)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbSupply)
        Me.Controls.Add(Me.dtpAdded)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPc)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtPname)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(867, 653)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(867, 653)
        Me.Name = "ProductEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProductEntry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPname As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnList As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSP As System.Windows.Forms.TextBox
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPc As System.Windows.Forms.TextBox
    Friend WithEvents dtpAdded As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbSupply As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As Label
End Class
