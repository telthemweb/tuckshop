<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.gLoginForm = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblWel = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gLoginForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(486, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Blue
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(84, 403)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(333, 54)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Click Here  to Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'gLoginForm
        '
        Me.gLoginForm.Controls.Add(Me.Label3)
        Me.gLoginForm.Controls.Add(Me.Label2)
        Me.gLoginForm.Controls.Add(Me.txtPass)
        Me.gLoginForm.Controls.Add(Me.txtUser)
        Me.gLoginForm.Location = New System.Drawing.Point(84, 63)
        Me.gLoginForm.Name = "gLoginForm"
        Me.gLoginForm.Size = New System.Drawing.Size(712, 309)
        Me.gLoginForm.TabIndex = 2
        Me.gLoginForm.TabStop = False
        Me.gLoginForm.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(128, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Username"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(242, 164)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(342, 35)
        Me.txtPass.TabIndex = 11
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(242, 104)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(342, 35)
        Me.txtUser.TabIndex = 10
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWel
        '
        Me.lblWel.AutoSize = True
        Me.lblWel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWel.ForeColor = System.Drawing.Color.Maroon
        Me.lblWel.Location = New System.Drawing.Point(140, 23)
        Me.lblWel.Name = "lblWel"
        Me.lblWel.Size = New System.Drawing.Size(625, 37)
        Me.lblWel.TabIndex = 14
        Me.lblWel.Text = "CHIPADZE HIGH SCHOOL TUCKSHOP"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Maroon
        Me.lblUser.Location = New System.Drawing.Point(140, 23)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(625, 37)
        Me.lblUser.TabIndex = 15
        Me.lblUser.Text = "CHIPADZE HIGH SCHOOL TUCKSHOP"
        Me.lblUser.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(845, 515)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblWel)
        Me.Controls.Add(Me.gLoginForm)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gLoginForm.ResumeLayout(False)
        Me.gLoginForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents gLoginForm As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblWel As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents Timer1 As Timer
End Class
