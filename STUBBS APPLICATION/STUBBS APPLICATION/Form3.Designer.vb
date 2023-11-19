<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        studentDataGridView = New DataGridView()
        sectionADataGridView = New DataGridView()
        sectionCDataGridView = New DataGridView()
        sectionBDataGridView = New DataGridView()
        shuffleButton = New Button()
        clearButton = New Button()
        refreshButton = New Button()
        Panel1 = New Panel()
        Label3 = New Label()
        Panel3 = New Panel()
        Panel6 = New Panel()
        saveButton = New Button()
        Label4 = New Label()
        yearLevelDropDownList = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel5 = New Panel()
        Panel2 = New Panel()
        Panel4 = New Panel()
        CType(studentDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(sectionADataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(sectionCDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(sectionBDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' studentDataGridView
        ' 
        studentDataGridView.BackgroundColor = Color.FromArgb(CByte(234), CByte(181), CByte(67))
        studentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        studentDataGridView.GridColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        studentDataGridView.Location = New Point(267, 21)
        studentDataGridView.Margin = New Padding(2, 3, 2, 3)
        studentDataGridView.Name = "studentDataGridView"
        studentDataGridView.RowHeadersWidth = 62
        studentDataGridView.RowTemplate.Height = 33
        studentDataGridView.Size = New Size(410, 209)
        studentDataGridView.TabIndex = 0
        ' 
        ' sectionADataGridView
        ' 
        sectionADataGridView.BackgroundColor = Color.FromArgb(CByte(234), CByte(181), CByte(67))
        sectionADataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        sectionADataGridView.GridColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        sectionADataGridView.Location = New Point(35, 17)
        sectionADataGridView.Margin = New Padding(2, 3, 2, 3)
        sectionADataGridView.Name = "sectionADataGridView"
        sectionADataGridView.RowHeadersWidth = 62
        sectionADataGridView.RowTemplate.Height = 33
        sectionADataGridView.Size = New Size(279, 320)
        sectionADataGridView.TabIndex = 1
        ' 
        ' sectionCDataGridView
        ' 
        sectionCDataGridView.BackgroundColor = Color.FromArgb(CByte(234), CByte(181), CByte(67))
        sectionCDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        sectionCDataGridView.GridColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        sectionCDataGridView.Location = New Point(636, 17)
        sectionCDataGridView.Margin = New Padding(2, 3, 2, 3)
        sectionCDataGridView.Name = "sectionCDataGridView"
        sectionCDataGridView.RowHeadersWidth = 62
        sectionCDataGridView.RowTemplate.Height = 33
        sectionCDataGridView.Size = New Size(282, 320)
        sectionCDataGridView.TabIndex = 2
        ' 
        ' sectionBDataGridView
        ' 
        sectionBDataGridView.BackgroundColor = Color.FromArgb(CByte(234), CByte(181), CByte(67))
        sectionBDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        sectionBDataGridView.GridColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        sectionBDataGridView.Location = New Point(332, 17)
        sectionBDataGridView.Margin = New Padding(2, 3, 2, 3)
        sectionBDataGridView.Name = "sectionBDataGridView"
        sectionBDataGridView.RowHeadersWidth = 62
        sectionBDataGridView.RowTemplate.Height = 33
        sectionBDataGridView.Size = New Size(284, 320)
        sectionBDataGridView.TabIndex = 2
        ' 
        ' shuffleButton
        ' 
        shuffleButton.BackColor = Color.FromArgb(CByte(85), CByte(230), CByte(193))
        shuffleButton.Cursor = Cursors.Hand
        shuffleButton.Location = New Point(741, 75)
        shuffleButton.Margin = New Padding(2, 3, 2, 3)
        shuffleButton.Name = "shuffleButton"
        shuffleButton.Size = New Size(107, 45)
        shuffleButton.TabIndex = 3
        shuffleButton.Text = "Shuffle"
        shuffleButton.UseVisualStyleBackColor = False
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        clearButton.Cursor = Cursors.Hand
        clearButton.ForeColor = SystemColors.Control
        clearButton.Location = New Point(741, 176)
        clearButton.Margin = New Padding(2, 3, 2, 3)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(107, 45)
        clearButton.TabIndex = 4
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' refreshButton
        ' 
        refreshButton.BackColor = Color.FromArgb(CByte(37), CByte(204), CByte(247))
        refreshButton.Cursor = Cursors.Hand
        refreshButton.Location = New Point(741, 21)
        refreshButton.Margin = New Padding(2, 3, 2, 3)
        refreshButton.Name = "refreshButton"
        refreshButton.Size = New Size(107, 45)
        refreshButton.TabIndex = 5
        refreshButton.Text = "Refresh"
        refreshButton.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel1.Controls.Add(Label3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2, 3, 2, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1029, 49)
        Panel1.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Label3.Font = New Font("ROG Fonts", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(37, 12)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(329, 29)
        Label3.TabIndex = 8
        Label3.Text = "Shuffle Students"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(234), CByte(181), CByte(67))
        Panel3.Controls.Add(sectionADataGridView)
        Panel3.Controls.Add(sectionCDataGridView)
        Panel3.Controls.Add(sectionBDataGridView)
        Panel3.Location = New Point(37, 301)
        Panel3.Margin = New Padding(2, 3, 2, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(965, 385)
        Panel3.TabIndex = 13
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(234), CByte(181), CByte(67))
        Panel6.Controls.Add(saveButton)
        Panel6.Controls.Add(Label4)
        Panel6.Controls.Add(yearLevelDropDownList)
        Panel6.Controls.Add(Label2)
        Panel6.Controls.Add(Label1)
        Panel6.Controls.Add(studentDataGridView)
        Panel6.Controls.Add(clearButton)
        Panel6.Controls.Add(shuffleButton)
        Panel6.Controls.Add(refreshButton)
        Panel6.Location = New Point(37, 49)
        Panel6.Margin = New Padding(2, 3, 2, 3)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(965, 255)
        Panel6.TabIndex = 15
        ' 
        ' saveButton
        ' 
        saveButton.BackColor = Color.FromArgb(CByte(85), CByte(230), CByte(193))
        saveButton.Cursor = Cursors.Hand
        saveButton.Location = New Point(741, 125)
        saveButton.Margin = New Padding(2, 3, 2, 3)
        saveButton.Name = "saveButton"
        saveButton.Size = New Size(107, 45)
        saveButton.TabIndex = 10
        saveButton.Text = "Save"
        saveButton.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("ROG Fonts", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(13, 133)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(166, 23)
        Label4.TabIndex = 9
        Label4.Text = "Year Level:"
        ' 
        ' yearLevelDropDownList
        ' 
        yearLevelDropDownList.FormattingEnabled = True
        yearLevelDropDownList.Location = New Point(49, 171)
        yearLevelDropDownList.Margin = New Padding(2, 3, 2, 3)
        yearLevelDropDownList.Name = "yearLevelDropDownList"
        yearLevelDropDownList.Size = New Size(147, 28)
        yearLevelDropDownList.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("ROG Fonts", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(72, 71)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(155, 23)
        Label2.TabIndex = 7
        Label2.Text = "Students: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("ROG Fonts", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(33, 43)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 23)
        Label1.TabIndex = 6
        Label1.Text = "List of "
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel5.Dock = DockStyle.Right
        Panel5.Location = New Point(1002, 49)
        Panel5.Margin = New Padding(2, 3, 2, 3)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(27, 652)
        Panel5.TabIndex = 16
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 49)
        Panel2.Margin = New Padding(2, 3, 2, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(37, 652)
        Panel2.TabIndex = 18
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(37, 668)
        Panel4.Margin = New Padding(2, 3, 2, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(965, 33)
        Panel4.TabIndex = 20
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 701)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel5)
        Controls.Add(Panel6)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2, 3, 2, 3)
        Name = "Form3"
        CType(studentDataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(sectionADataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(sectionCDataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(sectionBDataGridView, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents studentDataGridView As DataGridView
    Friend WithEvents sectionADataGridView As DataGridView
    Friend WithEvents sectionCDataGridView As DataGridView
    Friend WithEvents sectionBDataGridView As DataGridView
    Friend WithEvents shuffleButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents refreshButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents yearLevelDropDownList As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents saveButton As Button
End Class
