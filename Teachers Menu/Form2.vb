Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim mainMenu As New Form1()
        mainMenu.Show()
        Me.Hide()

    End Sub

    Private Sub btnInputInfo_Click(sender As Object, e As EventArgs) Handles btnInputInfo.Click
        Dim mainMenu As New Form3()
        mainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnInputGrades_Click(sender As Object, e As EventArgs) Handles btnInputGrades.Click
        Dim mainMenu As New Form4()
        mainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim mainMenu As New Form5()
        mainMenu.Show()
        Me.Hide()
    End Sub
End Class