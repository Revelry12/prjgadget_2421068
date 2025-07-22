Imports MySql.Data.MySqlClient
Public Class Fgantipassword
    Private Sub Fgantipassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Fgantipassword_Click(sender As Object, e As EventArgs) Handles Me.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Lengkapi Isian Terlebih Dahulu", MsgBoxStyle.Information, "Informasi")
        Else
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "select * from user_2421068 where username='" &
                                   useraktif.ToString & "' and userpass=md5('" & TextBox1.Text & "')"
            cek = perintah.ExecuteReader
            cek.Read()
            If cek.HasRows Then
                If TextBox2.Text <> TextBox3.Text Then
                    MsgBox("Password Baru Tidak Sama Ulangi Password Baru", MsgBoxStyle.Information, "Informasi")
                Else
                    cek.Close()
                    perintah.CommandText = "update user_2421068 set userpass=md5('" & TextBox2.Text & "') " &
                                           "where username='" & useraktif.ToString & "'"
                    perintah.ExecuteNonQuery()
                    MsgBox("Password Berhasil DiUpdate", MsgBoxStyle.Information, "Pesan")
                End If
            Else
                MsgBox("Password Sekarang Anda Salah", MsgBoxStyle.Information, "Informasi")
            End If
            kon.Close()
        End If
        Me.Dispose()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                TextBox2.Focus()
        End Select
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                TextBox3.Focus()
        End Select
    End Sub
End Class