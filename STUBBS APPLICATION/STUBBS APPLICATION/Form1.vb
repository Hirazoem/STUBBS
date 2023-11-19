

Public Class Form1
    Private currentForm As Form

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If currentForm IsNot Nothing Then
            Panel13.Controls.Remove(currentForm)
        End If

        currentForm = Form2
        currentForm.TopLevel = False
        Panel5.Controls.Add(currentForm)
        currentForm.BringToFront()
        currentForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If currentForm IsNot Nothing Then
            Panel13.Controls.Remove(currentForm)
        End If

        currentForm = Form3
        currentForm.TopLevel = False
        Panel5.Controls.Add(currentForm)
        currentForm.BringToFront()
        currentForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If currentForm IsNot Nothing Then
            Panel13.Controls.Remove(currentForm)
        End If

        currentForm = Form4
        currentForm.TopLevel = False
        Panel5.Controls.Add(currentForm)
        currentForm.BringToFront()
        currentForm.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If currentForm IsNot Nothing Then
            Panel13.Controls.Remove(currentForm)
        End If

        currentForm = Form5
        currentForm.TopLevel = False
        Panel5.Controls.Add(currentForm)
        currentForm.BringToFront()
        currentForm.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If currentForm IsNot Nothing Then
            Panel13.Controls.Remove(currentForm)
        End If

        currentForm = Form6
        currentForm.TopLevel = False
        Panel5.Controls.Add(currentForm)
        currentForm.BringToFront()
        currentForm.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Exit()
    End Sub
End Class
