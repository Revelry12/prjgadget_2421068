Imports MySql.Data.MySqlClient

Public Class Fuser
    Dim simpan As Boolean

    Dim mnRandomNumber As Integer


    Function GetRandomNumber(ByVal vnMinimumNumber As Integer, ByVal vnMaximumNumber As Integer) As Integer
        Randomize()
        Return CInt(Int((vnMaximumNumber - vnMinimumNumber + 1) * Rnd() + vnMinimumNumber))
    End Function



    Sub Aktif()

        txtuser.Enabled = True
        txtnama.Enabled = True
        cmblevel.Enabled = True
        rbaktif.Enabled = True
        rbblokir.Enabled = True


        txtuser.BackColor = Color.White
        txtnama.BackColor = Color.White
    End Sub

    Sub TidakAktif()

        txtuser.Enabled = False
        txtnama.Enabled = False
        cmblevel.Enabled = False
        rbaktif.Enabled = False
        rbblokir.Enabled = False
        txtuser.BackColor = Color.Gray
        txtnama.BackColor = Color.Gray

        cmdsimpan.Enabled = False
        cmdreset.Enabled = False
    End Sub

    Sub Bersih()
        txtuser.Clear()
        txtnama.Clear()
        cmblevel.SelectedIndex = -1
        rbaktif.Checked = True
        txtcari.Clear()
    End Sub

    Sub TampilUser(ByVal sql As String)
        Try
            If kon.State = ConnectionState.Open Then kon.Close()
            kon.Open()
            mda = New MySqlDataAdapter(sql, kon)
            ds.Tables.Clear()
            mda.Fill(ds, "datauser")
            dg.DataSource = ds.Tables("datauser")
            ' setdg() ' Panggil setdg setelah data dimuat
        Catch ex As Exception
            MsgBox("Gagal menampilkan data user: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If kon.State = ConnectionState.Open Then kon.Close()
        End Try
    End Sub

    Sub ProsesUser(ByVal sql As String)
        Try
            If kon.State = ConnectionState.Open Then kon.Close()
            kon.Open()
            perintah.Connection = kon
            perintah.CommandText = sql
            perintah.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Gagal memproses data user: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If kon.State = ConnectionState.Open Then kon.Close()
        End Try
    End Sub

    Sub AmbilLevel()
        Try
            If kon.State = ConnectionState.Open Then kon.Close()
            kon.Open()
            perintah.Connection = kon
            perintah.CommandText = "SELECT * FROM level_2421068 ORDER BY levelid"
            cek = perintah.ExecuteReader()
            cmblevel.Items.Clear()
            While cek.Read
                cmblevel.Items.Add(cek.Item("levelid") & " - " & cek.Item("levelakses"))
            End While
        Catch ex As Exception
            MsgBox("Gagal mengambil data level: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If Not cek Is Nothing AndAlso Not cek.IsClosed Then cek.Close()
            If kon.State = ConnectionState.Open Then kon.Close()
        End Try
    End Sub

    '--- EVENT HANDLER ---

    Private Sub Fuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AmbilLevel()
        TidakAktif()
        TampilUser("SELECT username, userfullname, levelakses, useraktif " &
                   "FROM user_2421068 JOIN level_2421068 ON user_2421068.userlevelid = level_2421068.levelid ORDER BY username")
        ' setdg()
    End Sub

    Private Sub cmdtambah_Click(sender As Object, e As EventArgs) Handles cmdtambah.Click
        If cmdtambah.Text = "Tambah" Then
            cmdtambah.Text = "Batal"
            Bersih()
            Aktif()
            simpan = True ' Set ke mode Simpan Baru
            cmdsimpan.Text = "Simpan"
            cmdsimpan.Enabled = True
            txtuser.Focus()
        Else
            cmdtambah.Text = "Tambah"
            TidakAktif()
            Bersih()
        End If
    End Sub

    Private Sub txtuser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtuser.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If kon.State = ConnectionState.Open Then kon.Close()
                kon.Open()
                perintah.Connection = kon
                perintah.CommandText = "SELECT u.*, l.levelakses FROM user_2421068 u JOIN level_2421068 l ON u.userlevelid = l.levelid WHERE u.username='" & txtuser.Text & "'"
                cek = perintah.ExecuteReader
                Aktif() ' Aktifkan semua field setelah pengecekan
                If cek.Read() Then
                    txtnama.Text = cek.Item("userfullname").ToString()
                    cmblevel.Text = cek.Item("userlevelid") & " - " & cek.Item("levelakses")
                    rbaktif.Checked = (cek.Item("useraktif").ToString() = "Y")
                    rbblokir.Checked = (cek.Item("useraktif").ToString() = "T")
                    simpan = False
                    cmdsimpan.Text = "Update"
                    cmdreset.Enabled = True
                Else
                    simpan = True
                    cmdsimpan.Text = "Simpan"
                    cmdreset.Enabled = False
                End If
                cmdsimpan.Enabled = True
                txtnama.Focus()
            Catch ex As Exception
                MsgBox("Gagal memeriksa username: " & ex.Message)
            Finally
                If Not cek Is Nothing AndAlso Not cek.IsClosed Then cek.Close()
                If kon.State = ConnectionState.Open Then kon.Close()
            End Try
        End If
    End Sub

    Private Sub cmdsimpan_Click(sender As Object, e As EventArgs) Handles cmdsimpan.Click
        ' Validasi input
        If String.IsNullOrWhiteSpace(txtuser.Text) Or String.IsNullOrWhiteSpace(txtnama.Text) Or cmblevel.SelectedIndex = -1 Then
            MsgBox("Nama User, Nama Lengkap, dan Level harus diisi.", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If

        Dim statususer As String = If(rbaktif.Checked, "Y", "T")
        Dim levelID As String = cmblevel.Text.Split("-")(0).Trim()

        If simpan Then ' Mode Simpan Baru
            Dim pass As String = "12345" ' Password default
            ProsesUser("INSERT INTO user_2421068 (username, userfullname, userpass, userlevelid, useraktif) VALUES('" &
                       txtuser.Text & "', '" & txtnama.Text & "', MD5('" & pass & "'), '" & levelID & "', '" & statususer & "')")
            MsgBox("User baru berhasil disimpan. Password default adalah: " & pass, MsgBoxStyle.Information, "Informasi")
        Else ' Mode Update
            ProsesUser("UPDATE user_2421068 SET userfullname='" & txtnama.Text & "', " &
                       "userlevelid='" & levelID & "', useraktif='" & statususer & "' WHERE username='" & txtuser.Text & "'")
            MsgBox("Data user berhasil diupdate.", MsgBoxStyle.Information, "Informasi")
        End If

        Fuser_Load(Nothing, Nothing) ' Muat ulang form
    End Sub

    Private Sub cmdkeluar_Click(sender As Object, e As EventArgs) Handles cmdkeluar.Click
        Me.Close()
    End Sub

    ' DITAMBAHKAN KEMBALI: Event handler untuk tombol Reset Password dan Cari
    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles cmdreset.Click
        If String.IsNullOrWhiteSpace(txtuser.Text) Then
            MsgBox("Pilih user yang akan direset passwordnya terlebih dahulu.", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If

        Dim pass As String
        mnRandomNumber = GetRandomNumber(1000, 9999) ' Membuat password 4 angka
        pass = mnRandomNumber.ToString()

        ProsesUser("UPDATE user_2421068 SET userpass=md5('" & pass & "') WHERE username='" & txtuser.Text & "'")

        MsgBox("Password baru untuk user '" & txtuser.Text & "' adalah: " & pass, MsgBoxStyle.Information, "Informasi")
        Fuser_Load(Nothing, Nothing) ' Muat ulang form
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        ' PERBAIKAN: Query pencarian harus JOIN dengan tabel level
        Dim sql As String = "SELECT username, userfullname, levelakses, useraktif " &
                            "FROM user_2421068 JOIN level_2421068 ON user_2421068.userlevelid = level_2421068.levelid " &
                            "WHERE username LIKE '%" & txtcari.Text & "%' " &
                            "OR userfullname LIKE '%" & txtcari.Text & "%' ORDER BY username"
        TampilUser(sql)
    End Sub
End Class
