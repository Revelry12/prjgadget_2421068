Public Class FPelanggan
    ' Variabel untuk menandai mode Simpan Baru (True) atau Update (False)
    Dim simpan As Boolean

    ' --- PROSEDUR BANTUAN ---

    ' Menampilkan data pelanggan ke DataGridView dengan aman
    Sub TampilPelanggan(ByVal sql As String)
        Try
            If kon.State = ConnectionState.Open Then kon.Close()
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = sql
            mda.SelectCommand = perintah
            ds.Tables.Clear()
            mda.Fill(ds, "pelanggan")
            dg.DataSource = ds.Tables("pelanggan")
        Catch ex As Exception
            MsgBox("Gagal menampilkan data pelanggan: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If kon.State = ConnectionState.Open Then kon.Close()
        End Try
    End Sub

    ' Memproses perintah INSERT, UPDATE, DELETE dengan aman
    Sub ProsesPelanggan(ByVal sql As String)
        Try
            If kon.State = ConnectionState.Open Then kon.Close()
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = sql
            perintah.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Gagal memproses data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If kon.State = ConnectionState.Open Then kon.Close()
        End Try
    End Sub

    ' Mengatur UI menjadi aktif untuk input
    Sub Aktif()
        txtidpelanggan.Enabled = True
        txtnamapelanggan.Enabled = True
        txtalamat.Enabled = True
        txtnohp.Enabled = True

        txtidpelanggan.BackColor = Color.White
        txtnamapelanggan.BackColor = Color.White
        txtalamat.BackColor = Color.White
        txtnohp.BackColor = Color.White
    End Sub

    ' Mengatur UI menjadi tidak aktif
    Sub TidakAktif()
        txtidpelanggan.Enabled = False
        txtnamapelanggan.Enabled = False
        txtalamat.Enabled = False
        txtnohp.Enabled = False

        txtidpelanggan.BackColor = Color.Gray
        txtnamapelanggan.BackColor = Color.Gray
        txtalamat.BackColor = Color.Gray
        txtnohp.BackColor = Color.Gray

        cmdsimpan.Enabled = False
        cmdhapus.Enabled = False
    End Sub

    ' Membersihkan semua kontrol input
    Sub Bersih()
        txtidpelanggan.Clear()
        txtnamapelanggan.Clear()
        txtalamat.Clear()
        txtnohp.Clear()
        txtcaripelanggan.Clear()
    End Sub

    ' --- EVENT HANDLER ---

    Private Sub FPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilPelanggan("SELECT * FROM pelanggan_2421068 ORDER BY pelangganid")
        TidakAktif()
        Bersih()
    End Sub

    ' REVISI UTAMA: Logika tombol Tambah/Batal
    Private Sub cmdtambah_Click(sender As Object, e As EventArgs) Handles cmdtambah.Click
        If cmdtambah.Text = "Tambah" Then
            cmdtambah.Text = "Batal"
            Bersih()
            Aktif() ' Langsung aktifkan semua textbox
            simpan = True ' Set ke mode Simpan Baru
            cmdsimpan.Text = "Simpan"
            cmdsimpan.Enabled = True
            cmdhapus.Enabled = False
            txtidpelanggan.Focus()
        Else
            cmdtambah.Text = "Tambah"
            TidakAktif()
            Bersih()
        End If
    End Sub

    ' Event untuk memeriksa ID saat tombol Enter ditekan
    Private Sub txtidpelanggan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidpelanggan.KeyPress
        If e.KeyChar = Chr(13) Then ' Jika tombol Enter ditekan
            Try
                If kon.State = ConnectionState.Open Then kon.Close()
                kon.Open()
                perintah.Connection = kon
                perintah.CommandText = "SELECT * FROM pelanggan_2421068 WHERE pelangganid='" & txtidpelanggan.Text & "'"
                cek = perintah.ExecuteReader
                cek.Read()
                If cek.HasRows Then
                    ' Jika data ditemukan, masuk mode UPDATE
                    txtidpelanggan.Enabled = False ' Kunci ID agar tidak diubah
                    txtnamapelanggan.Text = cek.Item("pelanggannama").ToString()
                    txtalamat.Text = cek.Item("pelangganalamat").ToString()
                    txtnohp.Text = cek.Item("pelanggannohp").ToString()
                    simpan = False ' Set ke mode Update
                    cmdsimpan.Text = "Update"
                    cmdhapus.Enabled = True
                Else
                    ' Jika data tidak ditemukan, lanjutkan mode SIMPAN BARU
                    simpan = True
                    cmdsimpan.Text = "Simpan"
                    cmdhapus.Enabled = False
                End If
                cek.Close()
                ' Panggil Aktif() di sini untuk memastikan textbox lain bisa diisi jika belum aktif
                Aktif()
                cmdsimpan.Enabled = True
                txtnamapelanggan.Focus()
            Catch ex As Exception
                MsgBox("Gagal memeriksa ID Pelanggan: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Finally
                If kon.State = ConnectionState.Open Then kon.Close()
            End Try
        End If
    End Sub

    ' Event untuk tombol Simpan/Update
    Private Sub cmdsimpan_Click(sender As Object, e As EventArgs) Handles cmdsimpan.Click
        If simpan Then ' Mode Simpan Baru
            ProsesPelanggan("INSERT INTO pelanggan_2421068 VALUES ('" & txtidpelanggan.Text & "', '" &
                            txtnamapelanggan.Text & "', '" & txtalamat.Text & "', '" & txtnohp.Text & "')")
            MsgBox("Data pelanggan baru berhasil disimpan.", MsgBoxStyle.Information, "Info")
        Else ' Mode Update
            ProsesPelanggan("UPDATE pelanggan_2421068 SET pelanggannama='" & txtnamapelanggan.Text & "', " &
                            "pelangganalamat='" & txtalamat.Text & "', pelanggannohp='" & txtnohp.Text & "' " &
                            "WHERE pelangganid='" & txtidpelanggan.Text & "'")
            MsgBox("Data pelanggan berhasil diupdate.", MsgBoxStyle.Information, "Info")
        End If

        TampilPelanggan("SELECT * FROM pelanggan_2421068 ORDER BY pelangganid")
        Bersih()
        TidakAktif()
        cmdtambah.Text = "Tambah"
    End Sub

    ' Event untuk tombol Hapus
    Private Sub cmdhapus_Click(sender As Object, e As EventArgs) Handles cmdhapus.Click
        If MsgBox("Apakah Anda yakin akan menghapus data ini?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            ProsesPelanggan("DELETE FROM pelanggan_2421068 WHERE pelangganid='" & txtidpelanggan.Text & "'")
            TampilPelanggan("SELECT * FROM pelanggan_2421068 ORDER BY pelangganid")
            Bersih()
            TidakAktif()
            cmdtambah.Text = "Tambah"
        End If
    End Sub

    ' Event untuk pencarian live
    Private Sub txtcaripelanggan_TextChanged(sender As Object, e As EventArgs) Handles txtcaripelanggan.TextChanged
        TampilPelanggan("SELECT * FROM pelanggan_2421068 WHERE pelangganid LIKE '%" & txtcaripelanggan.Text & "%' " &
                        "OR pelanggannama LIKE '%" & txtcaripelanggan.Text & "%'")
    End Sub

    ' Event untuk tombol Keluar
    Private Sub cmdkeluar_Click(sender As Object, e As EventArgs) Handles cmdkeluar.Click
        Me.Close()
    End Sub
End Class
