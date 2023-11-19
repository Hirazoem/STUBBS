<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        components = New ComponentModel.Container()
        studentDataGridView = New DataGridView()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Label2 = New Label()
        lastNameTextBox = New TextBox()
        idTextBox = New TextBox()
        addButton = New Button()
        Label1 = New Label()
        clearButton = New Button()
        yearLevelComboBox = New ComboBox()
        Label4 = New Label()
        Panel3 = New Panel()
        Label5 = New Label()
        gradeTextBox = New TextBox()
        middleNameTextBox = New TextBox()
        firstNameTextBox = New TextBox()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel1 = New Panel()
        Label3 = New Label()
        Panel2 = New Panel()
        CType(studentDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' studentDataGridView
        ' 
        studentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        studentDataGridView.Location = New Point(17, 247)
        studentDataGridView.Name = "studentDataGridView"
        studentDataGridView.RowHeadersWidth = 62
        studentDataGridView.RowTemplate.Height = 33
        studentDataGridView.Size = New Size(807, 203)
        studentDataGridView.TabIndex = 0
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calisto MT", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(17, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 28)
        Label2.TabIndex = 4
        Label2.Text = "Students ID  :"
        ' 
        ' lastNameTextBox
        ' 
        lastNameTextBox.Font = New Font("Calisto MT", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lastNameTextBox.Location = New Point(197, 54)
        lastNameTextBox.Name = "lastNameTextBox"
        lastNameTextBox.Size = New Size(185, 34)
        lastNameTextBox.TabIndex = 1
        lastNameTextBox.Text = "Last Name"
        ' 
        ' idTextBox
        ' 
        idTextBox.Font = New Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        idTextBox.Location = New Point(197, 110)
        idTextBox.Name = "idTextBox"
        idTextBox.Size = New Size(372, 31)
        idTextBox.TabIndex = 3
        ' 
        ' addButton
        ' 
        addButton.BackColor = Color.FromArgb(CByte(85), CByte(230), CByte(193))
        addButton.Cursor = Cursors.Hand
        addButton.FlatAppearance.BorderSize = 0
        addButton.Font = New Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        addButton.Location = New Point(633, 110)
        addButton.Name = "addButton"
        addButton.Size = New Size(130, 50)
        addButton.TabIndex = 5
        addButton.Text = "Add"
        addButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calisto MT", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(17, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 28)
        Label1.TabIndex = 2
        Label1.Text = "Students Name:"
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        clearButton.Cursor = Cursors.Hand
        clearButton.FlatAppearance.BorderSize = 0
        clearButton.Font = New Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        clearButton.ForeColor = SystemColors.Control
        clearButton.Location = New Point(633, 173)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(130, 50)
        clearButton.TabIndex = 6
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' yearLevelComboBox
        ' 
        yearLevelComboBox.Font = New Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        yearLevelComboBox.FormattingEnabled = True
        yearLevelComboBox.Location = New Point(197, 147)
        yearLevelComboBox.Name = "yearLevelComboBox"
        yearLevelComboBox.Size = New Size(210, 31)
        yearLevelComboBox.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calisto MT", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(17, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(165, 28)
        Label4.TabIndex = 8
        Label4.Text = "College Year : "
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(234), CByte(181), CByte(67))
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(gradeTextBox)
        Panel3.Controls.Add(middleNameTextBox)
        Panel3.Controls.Add(firstNameTextBox)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(clearButton)
        Panel3.Controls.Add(addButton)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(lastNameTextBox)
        Panel3.Controls.Add(studentDataGridView)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(idTextBox)
        Panel3.Controls.Add(yearLevelComboBox)
        Panel3.Location = New Point(32, 37)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(844, 464)
        Panel3.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calisto MT", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(17, 192)
        Label5.Name = "Label5"
        Label5.Size = New Size(156, 28)
        Label5.TabIndex = 12
        Label5.Text = "Grade Ave    :"
        ' 
        ' gradeTextBox
        ' 
        gradeTextBox.Font = New Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point)
        gradeTextBox.Location = New Point(197, 192)
        gradeTextBox.Name = "gradeTextBox"
        gradeTextBox.Size = New Size(372, 31)
        gradeTextBox.TabIndex = 11
        ' 
        ' middleNameTextBox
        ' 
        middleNameTextBox.Font = New Font("Calisto MT", 14F, FontStyle.Regular, GraphicsUnit.Point)
        middleNameTextBox.Location = New Point(602, 54)
        middleNameTextBox.Name = "middleNameTextBox"
        middleNameTextBox.Size = New Size(185, 34)
        middleNameTextBox.TabIndex = 10
        middleNameTextBox.Text = "Middle Name"
        ' 
        ' firstNameTextBox
        ' 
        firstNameTextBox.Font = New Font("Calisto MT", 14F, FontStyle.Regular, GraphicsUnit.Point)
        firstNameTextBox.Location = New Point(397, 54)
        firstNameTextBox.Name = "firstNameTextBox"
        firstNameTextBox.Size = New Size(185, 34)
        firstNameTextBox.TabIndex = 9
        firstNameTextBox.Text = "First Name"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(0, 501)
        Panel4.Margin = New Padding(2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(900, 25)
        Panel4.TabIndex = 21
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel5.Dock = DockStyle.Right
        Panel5.Location = New Point(876, 0)
        Panel5.Margin = New Padding(2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(24, 501)
        Panel5.TabIndex = 22
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel1.Controls.Add(Label3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(876, 37)
        Panel1.TabIndex = 23
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
        Label3.Size = New Size(260, 29)
        Label3.TabIndex = 8
        Label3.Text = "Input Student"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 37)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(32, 464)
        Panel2.TabIndex = 24
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 526)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Font = New Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        CType(studentDataGridView, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents studentDataGridView As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label2 As Label
    Friend WithEvents lastNameTextBox As TextBox
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents addButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents clearButton As Button
    Friend WithEvents yearLevelComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents middleNameTextBox As TextBox
    Friend WithEvents firstNameTextBox As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents gradeTextBox As TextBox
End Class
