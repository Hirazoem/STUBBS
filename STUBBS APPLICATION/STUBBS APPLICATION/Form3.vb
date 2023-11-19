Imports System.IO
Imports System.Windows.Forms

Public Class Form3
    Private studentTable As New DataTable()
    Private sectionATable As New DataTable()
    Private sectionBTable As New DataTable()
    Private sectionCTable As New DataTable()

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up the columns of the tables
        studentTable.Columns.Add("ID", GetType(Integer))
        studentTable.Columns.Add("Name", GetType(String))
        studentTable.Columns.Add("Year Level", GetType(String))
        studentTable.Columns.Add("Grade Average", GetType(Decimal)) ' Add Grade Average column

        sectionATable.Columns.Add("ID", GetType(Integer))
        sectionATable.Columns.Add("Name", GetType(String))
        sectionBTable.Columns.Add("ID", GetType(Integer))
        sectionBTable.Columns.Add("Name", GetType(String))
        sectionCTable.Columns.Add("ID", GetType(Integer))
        sectionCTable.Columns.Add("Name", GetType(String))

        ' Set up the data grid views
        studentDataGridView.DataSource = studentTable
        sectionADataGridView.DataSource = sectionATable
        sectionBDataGridView.DataSource = sectionBTable
        sectionCDataGridView.DataSource = sectionCTable

        ' Set the header text of the columns
        studentDataGridView.Columns("ID").HeaderText = "ID"
        studentDataGridView.Columns("Name").HeaderText = "Name"
        studentDataGridView.Columns("Year Level").HeaderText = "Year Level"
        studentDataGridView.Columns("Grade Average").HeaderText = "Grade Average" ' Set header text for Grade Average column
        sectionADataGridView.Columns("ID").HeaderText = "ID"
        sectionADataGridView.Columns("Name").HeaderText = "Section A"
        sectionBDataGridView.Columns("ID").HeaderText = "ID"
        sectionBDataGridView.Columns("Name").HeaderText = "Section B"
        sectionCDataGridView.Columns("ID").HeaderText = "ID"
        sectionCDataGridView.Columns("Name").HeaderText = "Section C"

        studentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        sectionADataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        sectionBDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        sectionCDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        yearLevelDropDownList.Items.AddRange({"1st Year", "2nd Year", "3rd Year", "4th Year"})
        yearLevelDropDownList.SelectedIndex = 0

        ' Retrieve the student names, year levels, and grade averages from Form2
        Dim students = From row In Form2.studentTable.AsEnumerable() Select ID = row.Field(Of Integer)("ID"), Name = row.Field(Of String)("Name"), YearLevel = GetYearLevel(row.Field(Of Integer)("Year Level")), GradeAverage = row.Field(Of Decimal)("Grade Average")
        For Each student In students
            studentTable.Rows.Add(student.ID, student.Name, student.YearLevel, student.GradeAverage)
        Next
    End Sub

    Private Function GetYearLevel(yearLevel As Integer) As String
        Select Case yearLevel
            Case 1
                Return "1st Year"
            Case 2
                Return "2nd Year"
            Case 3
                Return "3rd Year"
            Case 4
                Return "4th Year"
        End Select

        Return ""
    End Function

    Private Sub LoadStudents()
        ' Clear the student table
        studentTable.Rows.Clear()

        ' Retrieve the student names, year levels, and grade averages from Form2
        Dim students = From row In Form2.studentTable.AsEnumerable() Select ID = row.Field(Of Integer)("ID"), Name = row.Field(Of String)("Name"), YearLevel = GetYearLevel(row.Field(Of Integer)("Year Level")), GradeAverage = row.Field(Of Decimal)("Grade Average")
        For Each student In students
            studentTable.Rows.Add(student.ID, student.Name, student.YearLevel, student.GradeAverage)
        Next
    End Sub

    Private Sub shuffleButton_Click(sender As Object, e As EventArgs) Handles shuffleButton.Click
        ' Clear the section tables
        sectionATable.Rows.Clear()
        sectionBTable.Rows.Clear()
        sectionCTable.Rows.Clear()

        ' Get the selected year level
        Dim selectedYearLevel As String = yearLevelDropDownList.SelectedItem.ToString()

        ' Shuffle the student names into sections based on the selected year level
        Dim shuffledStudents = GetFilteredStudents(selectedYearLevel).OrderBy(Function(r) Guid.NewGuid())
        Dim index As Integer = 0

        For Each student In shuffledStudents
            Dim id As Integer = student.Field(Of Integer)("ID")
            Dim name As String = student.Field(Of String)("Name")
            Dim gradeAverage As Decimal = student.Field(Of Decimal)("Grade Average")

            ' Determine the section based on the grade average
            Dim section As String = GetSection(gradeAverage)

            ' Assign the student to the corresponding section
            Select Case section
                Case "A"
                    sectionATable.Rows.Add(id, name)
                Case "B"
                    sectionBTable.Rows.Add(id, name)
                Case "C"
                    sectionCTable.Rows.Add(id, name)
            End Select

            index += 1
        Next
    End Sub

    Private Function GetSection(gradeAverage As Decimal) As String
        If gradeAverage >= 1.0 AndAlso gradeAverage <= 1.67 Then
            Return "A"
        ElseIf gradeAverage >= 1.68 AndAlso gradeAverage <= 2.34 Then
            Return "B"
        ElseIf gradeAverage >= 2.35 AndAlso gradeAverage <= 3.0 Then
            Return "C"
        End If

        Return ""
    End Function

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ' Clear the section tables
        sectionATable.Rows.Clear()
        sectionBTable.Rows.Clear()
        sectionCTable.Rows.Clear()
    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        ' Reload the students from Form2
        LoadStudents()
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        ' Get the selected year level
        Dim selectedYearLevel As String = yearLevelDropDownList.SelectedItem.ToString()

        ' Save the shuffled lists to separate text file databases based on the selected year level
        SaveShuffledList(sectionATable, $"SectionA_{selectedYearLevel}.txt")
        SaveShuffledList(sectionBTable, $"SectionB_{selectedYearLevel}.txt")
        SaveShuffledList(sectionCTable, $"SectionC_{selectedYearLevel}.txt")

        ' Show save notification
        ShowSaveNotification()
    End Sub

    Private Sub ShowSaveNotification()
        MessageBox.Show("Save Done!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function GetFilteredStudents(yearLevel As String) As IEnumerable(Of DataRow)
        Return studentTable.AsEnumerable().Where(Function(row) row.Field(Of String)("Year Level") = yearLevel)
    End Function

    Private Sub SaveShuffledList(table As DataTable, fileName As String)
        Dim lines As New List(Of String)()

        ' Add the header line
        Dim headerLine As String = String.Join(vbTab, table.Columns.Cast(Of DataColumn)().Select(Function(column) column.ColumnName))
        lines.Add(headerLine)

        ' Add the data rows
        For Each row As DataRow In table.Rows
            Dim dataLine As String = String.Join(vbTab, row.ItemArray.Select(Function(item) item.ToString()))
            lines.Add(dataLine)
        Next

        ' Save the lines to the text file
        File.WriteAllLines(fileName, lines)
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub
End Class
