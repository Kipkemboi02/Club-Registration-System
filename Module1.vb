Imports MySql.Data.MySqlClient

Module Module1
    Public constring As MySqlConnection
    Public cm As MySqlCommand

    Sub connection()

        Try
            constring = New MySqlConnection("host=loacalhost; user= root;password=; database='user registration'")
            constring.Open()
            MsgBox("Connected to Database")
        Catch ex As Exception
            MsgBox("connection failed")

        End Try


    End Sub
End Module
