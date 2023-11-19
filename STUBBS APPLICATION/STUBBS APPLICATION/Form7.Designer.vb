<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Panel5 = New Panel()
        Panel1 = New Panel()
        Label3 = New Label()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        btnLogin = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel5.Dock = DockStyle.Right
        Panel5.Location = New Point(966, 0)
        Panel5.Margin = New Padding(2, 4, 2, 4)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(34, 562)
        Panel5.TabIndex = 18
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel1.Controls.Add(Label3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2, 4, 2, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(966, 61)
        Panel1.TabIndex = 19
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Label3.Font = New Font("ROG Fonts", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(46, 15)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 34)
        Label3.TabIndex = 8
        Label3.Text = "Log In"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 61)
        Panel2.Margin = New Padding(2, 4, 2, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(46, 501)
        Panel2.TabIndex = 20
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(46, 521)
        Panel4.Margin = New Padding(2, 4, 2, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(920, 41)
        Panel4.TabIndex = 22
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(234), CByte(181), CByte(67))
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(btnLogin)
        Panel3.Controls.Add(txtPassword)
        Panel3.Controls.Add(txtUsername)
        Panel3.Location = New Point(46, 61)
        Panel3.Margin = New Padding(4, 4, 4, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(920, 466)
        Panel3.TabIndex = 23
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calisto MT", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(89, 178)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 32)
        Label1.TabIndex = 8
        Label1.Text = "Password :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calisto MT", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(81, 108)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 32)
        Label2.TabIndex = 7
        Label2.Text = "Username :"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(85), CByte(230), CByte(193))
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.Font = New Font("Calisto MT", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogin.Location = New Point(581, 281)
        btnLogin.Margin = New Padding(4, 4, 4, 4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(162, 62)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Log In"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Calisto MT", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(279, 178)
        txtPassword.Margin = New Padding(4, 4, 4, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(464, 35)
        txtPassword.TabIndex = 5
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Calisto MT", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.Location = New Point(279, 104)
        txtUsername.Margin = New Padding(4, 4, 4, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(464, 35)
        txtUsername.TabIndex = 4
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 562)
        Controls.Add(Panel3)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Panel5)
        Margin = New Padding(4, 4, 4, 4)
        Name = "Form7"
        Text = "Form7"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
