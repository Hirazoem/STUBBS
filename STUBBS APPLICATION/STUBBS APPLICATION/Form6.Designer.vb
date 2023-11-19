<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Panel1 = New Panel()
        Label3 = New Label()
        Panel5 = New Panel()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Label4 = New Label()
        deleteButton = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel1.Controls.Add(Label3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(900, 37)
        Panel1.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Label3.Font = New Font("ROG Fonts", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(32, 9)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(226, 23)
        Label3.TabIndex = 8
        Label3.Text = "Delete Student"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel5.Dock = DockStyle.Right
        Panel5.Location = New Point(876, 37)
        Panel5.Margin = New Padding(2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(24, 489)
        Panel5.TabIndex = 17
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 37)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(32, 489)
        Panel2.TabIndex = 19
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(32, 501)
        Panel4.Margin = New Padding(2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(844, 25)
        Panel4.TabIndex = 21
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(234), CByte(181), CByte(67))
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(deleteButton)
        Panel3.Location = New Point(32, 37)
        Panel3.Margin = New Padding(2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(844, 470)
        Panel3.TabIndex = 22
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("ROG Fonts", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(340, 185)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(218, 18)
        Label4.TabIndex = 13
        Label4.Text = "Delete Information"
        ' 
        ' deleteButton
        ' 
        deleteButton.BackColor = Color.Gray
        deleteButton.Cursor = Cursors.Hand
        deleteButton.Font = New Font("ROG Fonts", 8.999999F, FontStyle.Regular, GraphicsUnit.Point)
        deleteButton.ForeColor = SystemColors.Control
        deleteButton.Location = New Point(392, 240)
        deleteButton.Margin = New Padding(2)
        deleteButton.Name = "deleteButton"
        deleteButton.Size = New Size(94, 34)
        deleteButton.TabIndex = 12
        deleteButton.Text = "Delete"
        deleteButton.UseVisualStyleBackColor = False
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 526)
        Controls.Add(Panel3)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel5)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "Form6"
        Text = "Form6"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents deleteButton As Button
    Friend WithEvents Label4 As Label
End Class
