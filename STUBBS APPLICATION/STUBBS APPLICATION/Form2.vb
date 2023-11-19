Imports System.IO
Imports System.Windows.Forms

Public Class Form2
    ' Declare a variable to hold the path of the text file
    Private filePath As String = "student_data.txt"
    ' Create a table to store the student data
    Friend studentTable As New DataTable()

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up the columns of the table
        studentTable.Columns.Add("ID", GetType(Integer))
        studentTable.Columns.Add("Name", GetType(String))
        studentTable.Columns.Add("Year Level", GetType(Integer))
        studentTable.Columns.Add("Grade Average", GetType(Decimal))

        ' Set up the data grid view
        studentDataGridView.DataSource = studentTable
        studentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        studentDataGridView.ReadOnly = True

        ' Set up the Year Level drop-down
        yearLevelComboBox.Items.AddRange({"1st Year", "2nd Year", "3rd Year", "4th Year"})
        yearLevelComboBox.SelectedIndex = 0

        ' Create the text file and write the header row
        If Not File.Exists(filePath) Then
            Using writer As New StreamWriter(filePath)
                writer.WriteLine("Year Level,ID,First Name,Middle Name,Grade Average")
            End Using
        Else
            ' Load the data from the text file into the table
            Using reader As New StreamReader(filePath)
                ' Skip the header row
                reader.ReadLine()

                ' Read the data line by line
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim values As String() = line.Split(","c)
                    Dim yearLevel As Integer = Integer.Parse(values(0))
                    Dim id As Integer = Integer.Parse(values(1))
                    Dim firstName As String = values(2)
                    Dim middleName As String = values(3)
                    Dim gradeAverage As Decimal = Decimal.Parse(values(4))
                    Dim name As String = $"{firstName} {middleName}"

                    ' Add the data to the table
                    studentTable.Rows.Add(id, name, yearLevel, gradeAverage)
                End While
            End Using
        End If
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        ' Get the first name, middle name, last name, ID, Year Level, and grade average from the text boxes and drop-down
        Dim firstName As String = firstNameTextBox.Text
        Dim middleName As String = middleNameTextBox.Text
        Dim lastName As String = lastNameTextBox.Text
        Dim name As String = $"{lastName}, {firstName} {middleName}"
        Dim id As Integer = Integer.Parse(idTextBox.Text)
        Dim yearLevel As Integer = yearLevelComboBox.SelectedIndex + 1
        Dim gradeAverage As Decimal

        ' Validate the grade average input
        If Decimal.TryParse(gradeTextBox.Text, gradeAverage) Then
            ' Check if the grade average is valid
            If gradeAverage <= 3.0 Then
                ' Add the data to the table
                studentTable.Rows.Add(id, name, yearLevel, gradeAverage)

                ' Append the data to the text file
                Using writer As New StreamWriter(filePath, True)
                    writer.WriteLine($"{yearLevel},{id},{firstName},{middleName},{gradeAverage}")
                End Using

                ' Clear the text boxes
                firstNameTextBox.Text = ""
                middleNameTextBox.Text = ""
                lastNameTextBox.Text = ""
                idTextBox.Text = ""
                yearLevelComboBox.SelectedIndex = 0
                gradeTextBox.Text = ""
            Else
                MessageBox.Show("Invalid input. Grade average should be less than or equal to 3.0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Invalid input. Please enter a valid grade average.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ' Clear the text boxes and drop-down
        firstNameTextBox.Text = ""
        middleNameTextBox.Text = ""
        lastNameTextBox.Text = ""
        idTextBox.Text = ""
        yearLevelComboBox.SelectedIndex = 0
        gradeTextBox.Text = ""
    End Sub


End Class
