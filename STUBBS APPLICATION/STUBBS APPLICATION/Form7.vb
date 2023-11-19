Imports System.IO

Public Class Form7
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If username = "admin" AndAlso password = "admin" Then
            MessageBox.Show("Login successful!")

            ' Log the login details
            LogLoginDetails(username)

            Dim form1 As New Form1()
            form1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If
    End Sub

    Private Sub LogLoginDetails(username As String)
        Dim logText As String = $"User: {username}, Date: {DateTime.Now}"

        ' Specify the path and filename for the log file
        Dim logFilePath As String = "login_logs.txt"

        ' Append the login details to the log file
        File.AppendAllText(logFilePath, logText & Environment.NewLine)
    End Sub


End Class
