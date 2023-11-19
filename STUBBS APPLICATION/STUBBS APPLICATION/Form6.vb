Imports System.IO
Imports System.Windows.Forms

Public Class Form6
    Private filePath As String = "student_data.txt"

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        ' Check if the file exists
        If File.Exists(filePath) Then
            ' Delete the file
            File.Delete(filePath)

            ' Clear the table in Form2
            Form2.studentTable.Rows.Clear()

            ' Delete the section database files
            Dim selectedYearLevel As String = Form5.yearLevelDropDownList.SelectedItem.ToString()
            Dim sectionAFile As String = $"SectionA_{selectedYearLevel}.txt"
            Dim sectionBFile As String = $"SectionB_{selectedYearLevel}.txt"
            Dim sectionCFile As String = $"SectionC_{selectedYearLevel}.txt"

            If File.Exists(sectionAFile) Then
                File.Delete(sectionAFile)
            End If

            If File.Exists(sectionBFile) Then
                File.Delete(sectionBFile)
            End If

            If File.Exists(sectionCFile) Then
                File.Delete(sectionCFile)
            End If

            MessageBox.Show("Data deleted successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No data found.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
