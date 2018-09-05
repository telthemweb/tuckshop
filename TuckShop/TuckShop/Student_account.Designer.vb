<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_account
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_account))
        Me.List = New System.Windows.Forms.Button()
        Me.cmbgender = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSurnm = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbClass = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'List
        '
        Me.List.BackColor = System.Drawing.Color.Maroon
        Me.List.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.List.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List.ForeColor = System.Drawing.Color.White
        Me.List.Location = New System.Drawing.Point(571, 293)
        Me.List.Name = "List"
        Me.List.Size = New System.Drawing.Size(129, 52)
        Me.List.TabIndex = 105
        Me.List.Text = "Close"
        Me.List.UseVisualStyleBackColor = False
        '
        'cmbgender
        '
        Me.cmbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbgender.Location = New System.Drawing.Point(267, 185)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(407, 28)
        Me.cmbgender.TabIndex = 104
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(77, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 21)
        Me.Label12.TabIndex = 101
        Me.Label12.Text = "Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(77, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 21)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = "Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(77, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 21)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Surname"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(267, 99)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(407, 31)
        Me.txtName.TabIndex = 90
        '
        'txtSurnm
        '
        Me.txtSurnm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurnm.Location = New System.Drawing.Point(267, 137)
        Me.txtSurnm.Name = "txtSurnm"
        Me.txtSurnm.Size = New System.Drawing.Size(407, 31)
        Me.txtSurnm.TabIndex = 89
        Me.txtSurnm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(267, 51)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(407, 31)
        Me.txtID.TabIndex = 88
        '
        'btnReg
        '
        Me.btnReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReg.ForeColor = System.Drawing.Color.White
        Me.btnReg.Location = New System.Drawing.Point(218, 293)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(148, 52)
        Me.btnReg.TabIndex = 87
        Me.btnReg.Text = "Register"
        Me.btnReg.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(403, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 52)
        Me.Button1.TabIndex = 86
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 21)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Student ID"
        '
        'cbClass
        '
        Me.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClass.FormattingEnabled = True
        Me.cbClass.Items.AddRange(New Object() {"1 A", "1 B", "1 C", "1 D", "2 A", "2 B", "2 C", "2 D", "3 A", "3 B", "3 C", "3 D", "4 A", "4 B", "4 C", "4 D", "5 Arts", "5 Sciences", "5 Commercials", "6 Arts", "6 Sciences", "6 Commercials"})
        Me.cbClass.Location = New System.Drawing.Point(267, 220)
        Me.cbClass.Name = "cbClass"
        Me.cbClass.Size = New System.Drawing.Size(407, 28)
        Me.cbClass.TabIndex = 108
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 21)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Class"
        '
        'Student_account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 428)
        Me.Controls.Add(Me.cbClass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.List)
        Me.Controls.Add(Me.cmbgender)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtSurnm)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Student_account"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student_account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents List As Button
    Friend WithEvents cmbgender As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSurnm As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnReg As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbClass As ComboBox
    Friend WithEvents Label2 As Label
End Class
