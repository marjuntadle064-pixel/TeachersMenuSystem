Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim mainMenu As New Form1()
        mainMenu.Show()
        Me.Hide()

    End Sub
End Class