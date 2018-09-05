<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpayment
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtchange = New System.Windows.Forms.TextBox
        Me.txtrecieved = New System.Windows.Forms.TextBox
        Me.txttotalcost = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(420, 209)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtchange)
        Me.Panel2.Controls.Add(Me.txtrecieved)
        Me.Panel2.Controls.Add(Me.txttotalcost)
        Me.Panel2.Location = New System.Drawing.Point(7, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(404, 192)
        Me.Panel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Change"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Payment"
        '
        'txtchange
        '
        Me.txtchange.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtchange.Font = New System.Drawing.Font("OCR A Extended", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtchange.Location = New System.Drawing.Point(118, 123)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.ReadOnly = True
        Me.txtchange.Size = New System.Drawing.Size(272, 46)
        Me.txtchange.TabIndex = 2
        Me.txtchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtrecieved
        '
        Me.txtrecieved.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtrecieved.Font = New System.Drawing.Font("OCR A Extended", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrecieved.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtrecieved.Location = New System.Drawing.Point(198, 69)
        Me.txtrecieved.Name = "txtrecieved"
        Me.txtrecieved.Size = New System.Drawing.Size(192, 46)
        Me.txtrecieved.TabIndex = 1
        Me.txtrecieved.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttotalcost
        '
        Me.txttotalcost.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txttotalcost.Font = New System.Drawing.Font("OCR A Extended", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalcost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txttotalcost.Location = New System.Drawing.Point(198, 14)
        Me.txttotalcost.Name = "txttotalcost"
        Me.txttotalcost.ReadOnly = True
        Me.txttotalcost.Size = New System.Drawing.Size(192, 46)
        Me.txttotalcost.TabIndex = 0
        Me.txttotalcost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmpayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 209)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmpayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtchange As System.Windows.Forms.TextBox
    Friend WithEvents txtrecieved As System.Windows.Forms.TextBox
    Friend WithEvents txttotalcost As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
