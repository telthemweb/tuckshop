<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentList))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.studentGrid = New System.Windows.Forms.DataGridView()
        Me.SCHOOLID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comlocl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SURNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENDER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FORMCLASS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.studentGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(7, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(975, 75)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Location = New System.Drawing.Point(311, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(445, 39)
        Me.Panel2.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(17, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 29)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Number of Students"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Green
        Me.lblTotal.Location = New System.Drawing.Point(351, 5)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(41, 29)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "67"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.TuckShop.My.Resources.Resources.Apply_32x32
        Me.PictureBox4.Location = New System.Drawing.Point(922, 20)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Student List"
        '
        'studentGrid
        '
        Me.studentGrid.BackgroundColor = System.Drawing.Color.White
        Me.studentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.studentGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SCHOOLID, Me.Comlocl, Me.SURNAME, Me.GENDER, Me.FORMCLASS})
        Me.studentGrid.Location = New System.Drawing.Point(7, 77)
        Me.studentGrid.Name = "studentGrid"
        Me.studentGrid.Size = New System.Drawing.Size(975, 359)
        Me.studentGrid.TabIndex = 0
        '
        'SCHOOLID
        '
        Me.SCHOOLID.HeaderText = "SHOOL ID"
        Me.SCHOOLID.Name = "SCHOOLID"
        '
        'Comlocl
        '
        Me.Comlocl.HeaderText = "FIRST NAME"
        Me.Comlocl.Name = "Comlocl"
        Me.Comlocl.Width = 270
        '
        'SURNAME
        '
        Me.SURNAME.HeaderText = "SURNAME"
        Me.SURNAME.Name = "SURNAME"
        Me.SURNAME.Width = 250
        '
        'GENDER
        '
        Me.GENDER.HeaderText = "GENDER"
        Me.GENDER.Name = "GENDER"
        Me.GENDER.Width = 190
        '
        'FORMCLASS
        '
        Me.FORMCLASS.HeaderText = "CLASS"
        Me.FORMCLASS.Name = "FORMCLASS"
        Me.FORMCLASS.Width = 120
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.TuckShop.My.Resources.Resources.images__3__3
        Me.PictureBox2.Location = New System.Drawing.Point(23, 442)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TuckShop.My.Resources.Resources.about
        Me.PictureBox1.Location = New System.Drawing.Point(875, 442)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'StudentList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(991, 495)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.studentGrid)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StudentList"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.studentGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents studentGrid As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents SCHOOLID As DataGridViewTextBoxColumn
    Friend WithEvents Comlocl As DataGridViewTextBoxColumn
    Friend WithEvents SURNAME As DataGridViewTextBoxColumn
    Friend WithEvents GENDER As DataGridViewTextBoxColumn
    Friend WithEvents FORMCLASS As DataGridViewTextBoxColumn
End Class
