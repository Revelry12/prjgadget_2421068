Imports MySql.Data.MySqlClient
Public Class Fuser
    Dim mnRandomNumber As Integer

    Function GetRandomNumber(ByVal vnMinimumNumber As Integer, ByVal vnMaximumNumber As Integer)
        Randomize()
        GetRandomNumber = CInt(Int((vnMaximumNumber - vnMinimumNumber + 1) * Rnd() + vnMinimumNumber))
    End Function

    Sub tampilanuser(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "datauser")
        dg.DataSource = ds.Tables("datauser")
        kon.Close()
    End Sub

    Sub prosesuser(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        perintah.ExecuteNonQuery()
        kon.Close()
    End Sub

    Sub ambillevel()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "Select * from level_2421068 order by levelid"
        cek = perintah.ExecuteReader
        While cek.Read
            cmblevel.Items.Add(cek.Item("levelid") & " - " & cek.Item("levelakses"))
        End While
        kon.Close()
    End Sub

    Sub aktif()
        txtuser.Enabled = True
        txtuser.Enabled = True
        txtuser.BackColor = Color.White
        txtuser.BackColor = Color.White
    End Sub

    Sub tidakaktif()
        txtuser.Enabled = False
        txtuser.Enabled = False
        txtuser.BackColor = Color.Gray
        txtuser.BackColor = Color.Gray
    End Sub

    Sub bersih()
        txtuser.Text = ""
        txtuser.Text = ""
    End Sub

    Sub setdg()
        dg.Columns(0).HeaderText = "User Name"
        dg.Columns(1).HeaderText = "Nama Lengkap"
        dg.Columns(2).HeaderText = "Level"
        dg.Columns(3).HeaderText = "Status Aktif"
        dg.Columns(0).Width = 100
        dg.Columns(1).Width = 200
        dg.Columns(2).Width = 70
        dg.Columns(3).Width = 70

    End Sub

    Private Sub Fuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmblevel.Items.Clear()
        ambillevel()
    End Sub

    Private Sub Fuser_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        tidakaktif()
        cmdsimpan.Enabled = False
        tampilanuser("SELECT username, userfullname, levelakses, useraktif " &
                 "FROM user_2421068 JOIN level_2421068 ON user_2421068.userlevelid = level_2421068.levelid ORDER BY username")
        setdg()
    End Sub

    Private Sub cmdtambah_Click(sender As Object, e As EventArgs) Handles cmdtambah.Click
        If cmdtambah.Text = "TAMBAH" Then
            txtuser.Enabled = True
            txtuser.Focus()
            txtuser.BackColor = Color.White
        Else
            tidakaktif()
            cmdsimpan.Enabled = False
            bersih()
        End If
    End Sub

    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged

    End Sub

    Private Sub txtuser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtuser.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                kon.Open()
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "SELECT user_2421068.*, levelakses " &
                                       "FROM user_2421068 JOIN level_2421068 ON user_2421068.userlevelid = level_2421068.levelid " &
                                       "WHERE username='" & txtuser.Text & "'"

                cek = perintah.ExecuteReader
                cek.Read()
                If cek.HasRows Then
                    txtnama.Text = cek.Item("userfullname")
                    cmblevel.Text = cek.Item("userlevelid") & " - " & cek.Item("levelakses")

                    Dim status As String
                    status = cek.Item("useraktif")
                    If status = "Y" Then
                        rbaktif.Checked = True
                    Else
                        rbblokir.Checked = True
                    End If
                    simpan = False
                    cmdsimpan.Text = "UPDATE"
                Else
                    simpan = True
                    cmdsimpan.Text = "SIMPAN"
                End If
                cek.Close()
                kon.Close()
                aktif()
                txtnama.Focus()
                cmdsimpan.Enabled = True
                cmdtambah.Text = "BATAL"
        End Select
    End Sub

    Private Sub cmdsimpan_Click(sender As Object, e As EventArgs) Handles cmdsimpan.Click
        Dim statususer, pass As String
        If rbaktif.Checked = True Then
            statususer = "Y"
        Else
            statususer = "T"
        End If

        mnRandomNumber = GetRandomNumber(1, 10000)
        pass = mnRandomNumber

        If cmdsimpan.Text = "SIMPAN" Then
            prosesuser("INSERT INTO user_2421068 VALUES('" & txtuser.Text & "', '" &
                       txtnama.Text & "',md5('" & pass & "'), '" &
                       cmblevel.Text.Substring(0, 1) & "','" & statususer & "')")
            MsgBox("Password Anda " & pass & "", MsgBoxStyle.Information, "Informasi")
        Else
            prosesuser("UPDATE user_2421068 SET userfullname='" & txtnama.Text & "', " &
                       "userlevelid='" & cmblevel.Text.Substring(0, 1) & "', " &
                       "useraktif='" & statususer & "' WHERE username='" & txtuser.Text & "'")
            MsgBox("Data Sukses Diupdate", MsgBoxStyle.Information, "Informasi")
        End If

        tampilanuser("SELECT username, userfullname, levelakses, useraktif " &
                     "FROM user_2421068 JOIN level_2421068 ON user_2421068.userlevelid = level_2421068.levelid " &
                     "ORDER BY username")
        setdg()
    End Sub

    Private Sub cmdkeluar_Click(sender As Object, e As EventArgs) Handles cmdkeluar.Click
        Me.Dispose()
    End Sub

    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles cmdreset.Click
        Dim pass As String
        mnRandomNumber = GetRandomNumber(1, 10000)
        pass = mnRandomNumber

        prosesuser("UPDATE user_2421068 SET userpass=md5('" & pass & "') WHERE username='" & txtuser.Text & "'")

        bersih()
        MsgBox("Password Baru Anda " & pass & "", MsgBoxStyle.Information, "Informasi")
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        tampilanuser("SELECT * FROM user_2421068 WHERE username='" & txtcari.Text & "' " &
                 "OR userfullname LIKE '%" & txtcari.Text & "%'")
    End Sub
End Class