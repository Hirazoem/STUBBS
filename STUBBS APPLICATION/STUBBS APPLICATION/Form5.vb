Imports System.IO
Imports System.Windows.Forms

Public Class Form5
    Private sectionATable As New DataTable()
    Private sectionBTable As New DataTable()
    Private sectionCTable As New DataTable()

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up the columns of the tables
        sectionATable.Columns.Add("ID", GetType(Integer))
        sectionATable.Columns.Add("Name", GetType(String))
        sectionBTable.Columns.Add("ID", GetType(Integer))
        sectionBTable.Columns.Add("Name", GetType(String))
        sectionCTable.Columns.Add("ID", GetType(Integer))
        sectionCTable.Columns.Add("Name", GetType(String))

        ' Set up the data grid views
        sectionADataGridView.DataSource = sectionATable
        sectionBDataGridView.DataSource = sectionBTable
        sectionCDataGridView.DataSource = sectionCTable

        ' Set the header text of the columns
        sectionADataGridView.Columns("ID").HeaderText = "ID"
        sectionADataGridView.Columns("Name").HeaderText = "Section A"
        sectionBDataGridView.Columns("ID").HeaderText = "ID"
        sectionBDataGridView.Columns("Name").HeaderText = "Section B"
        sectionCDataGridView.Columns("ID").HeaderText = "ID"
        sectionCDataGridView.Columns("Name").HeaderText = "Section C"

        sectionADataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        sectionBDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        sectionCDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        yearLevelDropDownList.Items.AddRange({"1st Year", "2nd Year", "3rd Year", "4th Year", "Irregular"})
        yearLevelDropDownList.SelectedIndex = 0

        RefreshSectionTables()
    End Sub

    Private Sub RefreshSectionTables()
        ' Clear the section tables
        sectionATable.Rows.Clear()
        sectionBTable.Rows.Clear()
        sectionCTable.Rows.Clear()

        ' Get the selected year level
        Dim selectedYearLevel As String = yearLevelDropDownList.SelectedItem.ToString()

        ' Load the section lists based on the selected year level
        LoadSectionList(sectionATable, $"SectionA_{selectedYearLevel}.txt")
        LoadSectionList(sectionBTable, $"SectionB_{selectedYearLevel}.txt")
        LoadSectionList(sectionCTable, $"SectionC_{selectedYearLevel}.txt")
    End Sub

    Private Sub yearLevelDropDownList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles yearLevelDropDownList.SelectedIndexChanged
        ' Refresh the section tables when the selected year level changes
        RefreshSectionTables()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        ' Refresh the section tables
        RefreshSectionTables()
    End Sub

    Private Sub LoadSectionList(table As DataTable, fileName As String)
        ' Check if the file exists
        If File.Exists(fileName) Then
            ' Read the lines from the file
            Dim lines As String() = File.ReadAllLines(fileName)

            ' Check if the file has at least one data row
            If lines.Length > 1 Then
                ' Split the header line to get the column names
                Dim headerLine As String = lines(0)
                Dim columnNames As String() = headerLine.Split(vbTab)

                ' Create columns in the table based on the column names
                table.Columns.Clear()
                For Each columnName As String In columnNames
                    table.Columns.Add(columnName, GetType(String))
                Next

                ' Add the data rows to the table
                For i As Integer = 1 To lines.Length - 1
                    Dim dataLine As String = lines(i)
                    Dim dataValues As String() = dataLine.Split(vbTab)

                    If dataValues.Length = table.Columns.Count Then
                        table.Rows.Add(dataValues)
                    End If
                Next
            End If
        End If
    End Sub


End Class
