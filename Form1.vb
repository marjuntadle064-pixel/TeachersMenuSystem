Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            connection.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM accounts WHERE username=@user AND password=@pass", connection)
            cmd.Parameters.AddWithValue("@user", txtUsername.Text)
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Example: open another form
                ' Dim dashboard As New DashboardForm()
                ' dashboard.Show()
                ' Me.Hide()
                Dim mainMenu As New Form2()
                mainMenu.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            reader.Close()
            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class
