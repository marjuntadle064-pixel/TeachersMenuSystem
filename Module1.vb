Imports MySql.Data.MySqlClient
Module Module1
    Public connection As New MySqlConnection("server=localhost;user=root;password=;database=users db")

    Public Sub OpenConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    Public Sub CloseConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
End Module
