Imports MySql.Data.MySqlClient
Public Class Form3
    Private Sub LoadData_Click(sender As Object, e As EventArgs) Handles LoadData.Click
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM `student_info`"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtStudentID.Text) OrElse
       String.IsNullOrWhiteSpace(txtUserID.Text) OrElse
       String.IsNullOrWhiteSpace(txtFullName.Text) OrElse
       String.IsNullOrWhiteSpace(cmbCourse.Text) OrElse
       String.IsNullOrWhiteSpace(cmbYear.Text) Then

            MessageBox.Show("Please fill in all required fields before saving.",
                        "Missing Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Exit Sub ' ← Stop the code, wag ituloy ang save
        End If

        Try
            connection.Open()
            Dim query As String = "INSERT INTO `student_info` (student_id, user_id, fullname, course, birthday, year_level) " &
                                  "VALUES (@student_id, @user_id, @fullname, @course, @birthday, @year_level)"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@student_id", txtStudentID.Text)
            cmd.Parameters.AddWithValue("@user_id", txtUserID.Text)
            cmd.Parameters.AddWithValue("@fullname", txtFullName.Text)
            cmd.Parameters.AddWithValue("@course", cmbCourse.Text)
            cmd.Parameters.AddWithValue("@birthday", dtpBirthday.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@year_level", cmbYear.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Student information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' refresh datagridview after saving
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

End Class
