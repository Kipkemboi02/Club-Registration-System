Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cm = New MySqlCommand("insert into registration value('" & txtname.Text & "', '" & cmbgender.Text & "','" & txtphone.Text & "', '" & txtemail.Text & "', '" & txtreg.Text & "','" & cmbschool.Text & "','" & cmbcourse.Text & "', '" & cmbresidence.Text & "')", constring)
            cm.ExecuteNonQuery()
            MsgBox("Registered Succesfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
    End Sub
End Class
