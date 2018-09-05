<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_Entry
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Datacustomer = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.List = New System.Windows.Forms.Button()
        Me.cmbgender = New System.Windows.Forms.ComboBox()
        Me.dtpReg = New System.Windows.Forms.DateTimePicker()
        Me.dtpYr = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.txtPh = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Datacustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 632)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1078, 24)
        Me.Panel1.TabIndex = 59
        '
        'Datacustomer
        '
        Me.Datacustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datacustomer.Location = New System.Drawing.Point(104, 429)
        Me.Datacustomer.Name = "Datacustomer"
        Me.Datacustomer.Size = New System.Drawing.Size(948, 184)
        Me.Datacustomer.TabIndex = 62
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gament_Management_Sytem.My.Resources.Resources._5853cfade694f413edea855c
        Me.PictureBox1.Location = New System.Drawing.Point(680, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(372, 350)
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.List)
        Me.GroupBox1.Controls.Add(Me.cmbgender)
        Me.GroupBox1.Controls.Add(Me.dtpReg)
        Me.GroupBox1.Controls.Add(Me.dtpYr)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(Me.txtAdd)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtCusName)
        Me.GroupBox1.Controls.Add(Me.txtPh)
        Me.GroupBox1.Controls.Add(Me.txtCustomerID)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 420)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        '
        'List
        '
        Me.List.Location = New System.Drawing.Point(520, 155)
        Me.List.Name = "List"
        Me.List.Size = New System.Drawing.Size(129, 52)
        Me.List.TabIndex = 85
        Me.List.Text = "View List"
        Me.List.UseVisualStyleBackColor = True
        '
        'cmbgender
        '
        Me.cmbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbgender.Location = New System.Drawing.Point(182, 112)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(217, 28)
        Me.cmbgender.TabIndex = 84
        '
        'dtpReg
        '
        Me.dtpReg.Enabled = False
        Me.dtpReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReg.Location = New System.Drawing.Point(182, 344)
        Me.dtpReg.Name = "dtpReg"
        Me.dtpReg.Size = New System.Drawing.Size(164, 29)
        Me.dtpReg.TabIndex = 83
        '
        'dtpYr
        '
        Me.dtpYr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpYr.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpYr.Location = New System.Drawing.Point(182, 158)
        Me.dtpYr.Name = "dtpYr"
        Me.dtpYr.Size = New System.Drawing.Size(164, 29)
        Me.dtpYr.TabIndex = 82
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(143, 21)
        Me.Label12.TabIndex = 81
        Me.Label12.Text = "Customer Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 352)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 21)
        Me.Label11.TabIndex = 80
        Me.Label11.Text = "Register Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 21)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Gender"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 21)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "D.O.B"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 21)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Phone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 21)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "City"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 21)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 21)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "E-mail "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 21)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Customer ID"
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(182, 250)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(217, 31)
        Me.txtCity.TabIndex = 72
        Me.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAdd
        '
        Me.txtAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd.Location = New System.Drawing.Point(182, 297)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(217, 31)
        Me.txtAdd.TabIndex = 71
        Me.txtAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(182, 379)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(217, 31)
        Me.txtEmail.TabIndex = 70
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCusName
        '
        Me.txtCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusName.Location = New System.Drawing.Point(182, 58)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(217, 31)
        Me.txtCusName.TabIndex = 69
        '
        'txtPh
        '
        Me.txtPh.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPh.Location = New System.Drawing.Point(182, 205)
        Me.txtPh.Name = "txtPh"
        Me.txtPh.Size = New System.Drawing.Size(217, 31)
        Me.txtPh.TabIndex = 68
        Me.txtPh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCustomerID
        '
        Me.txtCustomerID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.Location = New System.Drawing.Point(182, 10)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(217, 31)
        Me.txtCustomerID.TabIndex = 67
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(520, 21)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(129, 52)
        Me.Button4.TabIndex = 66
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(520, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 52)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Customer_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 656)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Datacustomer)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Customer_Entry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer_Entry"
        CType(Me.Datacustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Datacustomer As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents List As System.Windows.Forms.Button
    Friend WithEvents cmbgender As System.Windows.Forms.ComboBox
    Friend WithEvents dtpReg As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpYr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents txtPh As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
