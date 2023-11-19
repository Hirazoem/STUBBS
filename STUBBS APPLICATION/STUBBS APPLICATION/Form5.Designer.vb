<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        sectionCDataGridView = New DataGridView()
        sectionBDataGridView = New DataGridView()
        sectionADataGridView = New DataGridView()
        RefreshButton = New Button()
        Label4 = New Label()
        yearLevelDropDownList = New ComboBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(sectionCDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(sectionBDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(sectionADataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Panel1.TabIndex = 8
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
        Label3.Size = New Size(305, 29)
        Label3.TabIndex = 8
        Label3.Text = "List of Students"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel5.Dock = DockStyle.Right
        Panel5.Location = New Point(1002, 49)
        Panel5.Margin = New Padding(2, 3, 2, 3)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(27, 652)
        Panel5.TabIndex = 17
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 49)
        Panel2.Margin = New Padding(2, 3, 2, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(37, 652)
        Panel2.TabIndex = 19
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(37, 663)
        Panel4.Margin = New Padding(2, 3, 2, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(965, 38)
        Panel4.TabIndex = 21
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(234), CByte(181), CByte(67))
        Panel3.Controls.Add(sectionCDataGridView)
        Panel3.Controls.Add(sectionBDataGridView)
        Panel3.Controls.Add(sectionADataGridView)
        Panel3.Controls.Add(RefreshButton)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(yearLevelDropDownList)
        Panel3.Location = New Point(37, 49)
        Panel3.Margin = New Padding(2, 3, 2, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(965, 613)
        Panel3.TabIndex = 22
        ' 
        ' sectionCDataGridView
        ' 
        sectionCDataGridView.BackgroundColor = Color.FromArgb(CByte(234), CByte(181), CByte(67))
        sectionCDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        sectionCDataGridView.GridColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        sectionCDataGridView.Location = New Point(646, 103)
        sectionCDataGridView.Margin = New Padding(2, 3, 2, 3)
        sectionCDataGridView.Name = "sectionCDataGridView"
        sectionCDataGridView.RowHeadersWidth = 62
        sectionCDataGridView.RowTemplate.Height = 33
        sectionCDataGridView.Size = New Size(269, 469)
        sectionCDataGridView.TabIndex = 14
        ' 
        ' sectionBDataGridView
        ' 
        sectionBDataGridView.BackgroundColor = Color.FromArgb(CByte(234), CByte(181), CByte(67))
        sectionBDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        sectionBDataGridView.GridColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        sectionBDataGridView.Location = New Point(351, 103)
        sectionBDataGridView.Margin = New Padding(2, 3, 2, 3)
        sectionBDataGridView.Name = "sectionBDataGridView"
        sectionBDataGridView.RowHeadersWidth = 62
        sectionBDataGridView.RowTemplate.Height = 33
        sectionBDataGridView.Size = New Size(261, 469)
        sectionBDataGridView.TabIndex = 13
        ' 
        ' sectionADataGridView
        ' 
        sectionADataGridView.BackgroundColor = Color.FromArgb(CByte(234), CByte(181), CByte(67))
        sectionADataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        sectionADataGridView.GridColor = Color.FromArgb(CByte(44), CByte(58), CByte(71))
        sectionADataGridView.Location = New Point(51, 103)
        sectionADataGridView.Margin = New Padding(2, 3, 2, 3)
        sectionADataGridView.Name = "sectionADataGridView"
        sectionADataGridView.RowHeadersWidth = 62
        sectionADataGridView.RowTemplate.Height = 33
        sectionADataGridView.Size = New Size(261, 469)
        sectionADataGridView.TabIndex = 12
        ' 
        ' RefreshButton
        ' 
        RefreshButton.BackColor = Color.FromArgb(CByte(37), CByte(204), CByte(247))
        RefreshButton.Cursor = Cursors.Hand
        RefreshButton.Location = New Point(351, 15)
        RefreshButton.Margin = New Padding(2, 3, 2, 3)
        RefreshButton.Name = "RefreshButton"
        RefreshButton.Size = New Size(107, 45)
        RefreshButton.TabIndex = 11
        RefreshButton.Text = "Refresh"
        RefreshButton.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("ROG Fonts", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(5, 25)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(166, 23)
        Label4.TabIndex = 10
        Label4.Text = "Year Level:"
        ' 
        ' yearLevelDropDownList
        ' 
        yearLevelDropDownList.FormattingEnabled = True
        yearLevelDropDownList.Location = New Point(165, 25)
        yearLevelDropDownList.Margin = New Padding(2, 3, 2, 3)
        yearLevelDropDownList.Name = "yearLevelDropDownList"
        yearLevelDropDownList.Size = New Size(147, 28)
        yearLevelDropDownList.TabIndex = 9
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 701)
        Controls.Add(Panel3)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel5)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2, 3, 2, 3)
        Name = "Form5"
        Text = "Form5"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(sectionCDataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(sectionBDataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(sectionADataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents yearLevelDropDownList As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RefreshButton As Button
    Friend WithEvents sectionCDataGridView As DataGridView
    Friend WithEvents sectionBDataGridView As DataGridView
    Friend WithEvents sectionADataGridView As DataGridView
End Class
