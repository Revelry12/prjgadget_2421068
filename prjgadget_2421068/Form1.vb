
Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        Try
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "SELECT * FROM user_2421068 " &
                                 "WHERE username='" & txtusername.Text & "' " &
                                 "AND userpass=MD5('" & txtpassword.Text & "')"

            cek = perintah.ExecuteReader()
            cek.Read()

            If cek.HasRows Then
                ' Mengambil nilai dari database
                Dim userStatus As String = cek.Item("useraktif").ToString().Trim().ToUpper()
                Dim userLevel As String = cek.Item("userlevelid").ToString()

                MsgBox("Login Berhasil", MsgBoxStyle.Information, "DEBUG")

                useraktif = txtusername.Text

                If userStatus = "Y" Then
                    ' Akun aktif, lanjutkan login
                    FMenu.ToolStripStatusLabel2.Text = useraktif
                    If userLevel = "1" Then
                        FMenu.SettingToolStripMenuItem.Enabled = True
                    Else
                        FMenu.SettingToolStripMenuItem.Enabled = False
                    End If
                    FMenu.Show()
                    Me.Hide()
                Else
                    ' Akun tidak aktif
                    MsgBox("Akun Anda tidak aktif, silakan hubungi Administrator.", MsgBoxStyle.Exclamation, "Informasi")
                End If
            Else
                ' Username atau password salah
                MsgBox("Username atau Password Salah...", MsgBoxStyle.Information, "Informasi")
            End If

        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If kon.State = ConnectionState.Open Then
                kon.Close()
            End If
        End Try

    End Sub

    Private Sub cmdexit_Click(sender As Object, e As EventArgs) Handles cmdexit.Click
        End
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub txtusername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusername.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtpassword.Focus()
        End Select
    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                cmdlogin.PerformClick()
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
