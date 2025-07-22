Imports MySql.Data.MySqlClient

Public Class FProduk
    ' Variabel untuk menandai mode Simpan Baru (True) atau Update (False)
    Dim simpan As Boolean

    ' --- PROSEDUR BANTUAN ---

    ' Menampilkan data produk ke DataGridView dengan aman
    Sub TampilProduk(ByVal sql As String)
        Try
            If kon.State = ConnectionState.Open Then kon.Close()
            kon.Open()
            Using cmd As New MySqlCommand(sql, kon)
                mda.SelectCommand = cmd
                ds.Tables.Clear()
                mda.Fill(ds, "produk")
                If ds.Tables.Contains("produk") Then
                    dg.DataSource = ds.Tables("produk")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Gagal menampilkan data produk: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If kon.State = ConnectionState.Open Then kon.Close()
        End Try
    End Sub

    ' Memproses perintah INSERT, UPDATE, DELETE dengan aman
    Sub ProsesProduk(ByVal sql As String)
        Try
            If kon.State = ConnectionState.Open Then kon.Close()
            kon.Open()
            perintah.Connection = kon
            perintah.CommandType = CommandType.Text
            perintah.CommandText = sql
            perintah.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Gagal memproses data produk: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If kon.State = ConnectionState.Open Then kon.Close()
        End Try
    End Sub

    ' Mengambil data kategori untuk ComboBox
    Sub AmbilKategori()
        Try
            If kon.State = ConnectionState.Open Then kon.Close()
            kon.Open()
            perintah.Connection = kon
            perintah.CommandText = "SELECT * FROM kategori_2421068 ORDER BY kategoriid"
            cek = perintah.ExecuteReader
            cmbkategori.Items.Clear()
            While cek.Read
                cmbkategori.Items.Add(cek.Item("kategoriid") & " - " & cek.Item("kategorinama"))
            End While
        Catch ex As Exception
            MsgBox("Gagal mengambil data kategori: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If Not cek Is Nothing AndAlso Not cek.IsClosed Then cek.Close()
            If kon.State = ConnectionState.Open Then kon.Close()
        End Try
    End Sub

    ' Mengambil data merk untuk ComboBox
    Sub AmbilMerk()
        Try
            If kon.State = ConnectionState.Open Then kon.Close()
            kon.Open()
            perintah.Connection = kon
            perintah.CommandText = "SELECT * FROM merk_2421068 ORDER BY merkid"
            cek = perintah.ExecuteReader
            cmbmerk.Items.Clear()
            While cek.Read
                cmbmerk.Items.Add(cek.Item("merkid") & " - " & cek.Item("merknama"))
            End While
        Catch ex As Exception
            MsgBox("Gagal mengambil data merk: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If Not cek Is Nothing AndAlso Not cek.IsClosed Then cek.Close()
            If kon.State = ConnectionState.Open Then kon.Close()
        End Try
    End Sub

    ' Mengatur UI menjadi aktif untuk input
    Sub Aktif()
        txtprodukid.Enabled = True
        txtproduknama.Enabled = True
        txtprodukstok.Enabled = True
        cmbkategori.Enabled = True
        cmbmerk.Enabled = True

        txtprodukid.BackColor = Color.White
        txtproduknama.BackColor = Color.White
        txtprodukstok.BackColor = Color.White
    End Sub

    ' Mengatur UI menjadi tidak aktif
    Sub TidakAktif()
        txtprodukid.Enabled = False
        txtproduknama.Enabled = False
        txtprodukstok.Enabled = False
        cmbkategori.Enabled = False
        cmbmerk.Enabled = False

        txtprodukid.BackColor = Color.Gray
        txtproduknama.BackColor = Color.Gray
        txtprodukstok.BackColor = Color.Gray

        cmdsimpan.Enabled = False
        cmdhapus.Enabled = False
    End Sub

    ' Membersihkan semua kontrol input
    Sub Bersih()
        txtprodukid.Clear()
        txtproduknama.Clear()
        txtprodukstok.Clear()
        cmbkategori.SelectedIndex = -1
        cmbmerk.SelectedIndex = -1
        txtcari.Clear()
    End Sub

    ' --- EVENT HANDLER ---

    Private Sub FProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilProduk("SELECT produkid, produknama, kategorinama, merknama, " &
                     "produkstok FROM produk_2421068 " &
                     "JOIN kategori_2421068 ON produk_2421068.produkkategoriid = kategori_2421068.kategoriid " &
                     "JOIN merk_2421068 ON produk_2421068.produkmerkid = merk_2421068.merkid ORDER BY produkid")
        ' setdg() ' Anda bisa memanggil setdg di sini jika perlu
        TidakAktif()
        Bersih()
    End Sub

    ' REVISI UTAMA: Logika tombol Tambah/Batal
    Private Sub cmdtambah_Click(sender As Object, e As EventArgs) Handles cmdtambah.Click
        If cmdtambah.Text = "Tambah" Then
            cmdtambah.Text = "Batal"
            Bersih()
            Aktif() ' Langsung aktifkan semua kontrol
            simpan = True ' Set ke mode Simpan Baru
            cmdsimpan.Text = "Simpan"
            cmdsimpan.Enabled = True
            cmdhapus.Enabled = False
            txtprodukid.Focus()
        Else
            cmdtambah.Text = "Tambah"
            TidakAktif()
            Bersih()
        End If
    End Sub

    Private Sub FProduk_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' Muat ulang data ComboBox setiap kali form menjadi aktif
        AmbilKategori()
        AmbilMerk()
    End Sub

    Private Sub txtprodukid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprodukid.KeyPress
        If e.KeyChar = Chr(13) Then ' Jika tombol Enter ditekan
            Try
                If kon.State = ConnectionState.Open Then kon.Close()
                kon.Open()
                perintah.Connection = kon
                perintah.CommandText = "SELECT p.*, k.kategorinama, m.merknama FROM produk_2421068 p " &
                                       "JOIN kategori_2421068 k ON p.produkkategoriid = k.kategoriid " &
                                       "JOIN merk_2421068 m ON p.produkmerkid = m.merkid " &
                                       "WHERE p.produkid = '" & txtprodukid.Text & "'"
                cek = perintah.ExecuteReader
                cek.Read()
                If cek.HasRows Then
                    ' Jika data ditemukan, masuk mode UPDATE
                    txtprodukid.Enabled = False ' Kunci ID
                    txtproduknama.Text = cek.Item("produknama").ToString()
                    txtprodukstok.Text = cek.Item("produkstok").ToString()
                    cmbkategori.Text = cek.Item("produkkategoriid") & " - " & cek.Item("kategorinama")
                    cmbmerk.Text = cek.Item("produkmerkid") & " - " & cek.Item("merknama")
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
                Aktif() ' Pastikan semua kontrol aktif
                cmdsimpan.Enabled = True
                txtproduknama.Focus()
            Catch ex As Exception
                MsgBox("Gagal memeriksa ID Produk: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Finally
                If kon.State = ConnectionState.Open Then kon.Close()
            End Try
        End If
    End Sub

    Private Sub cmdsimpan_Click(sender As Object, e As EventArgs) Handles cmdsimpan.Click
        ' Validasi input sebelum menyimpan
        If String.IsNullOrWhiteSpace(txtprodukid.Text) Or
           String.IsNullOrWhiteSpace(txtproduknama.Text) Or
           cmbkategori.SelectedIndex = -1 Or
           cmbmerk.SelectedIndex = -1 Or
           String.IsNullOrWhiteSpace(txtprodukstok.Text) Then
            MsgBox("Semua field harus diisi.", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If

        ' Mengambil ID dari ComboBox
        Dim kategoriID As String = cmbkategori.Text.Split("-")(0).Trim()
        Dim merkID As String = cmbmerk.Text.Split("-")(0).Trim()

        If simpan Then ' Mode Simpan Baru
            ProsesProduk("INSERT INTO produk_2421068 VALUES ('" & txtprodukid.Text & "', '" & txtproduknama.Text & "', '" &
                         kategoriID & "', '" & merkID & "', " & txtprodukstok.Text & ")")
            MsgBox("Data produk baru berhasil disimpan.", MsgBoxStyle.Information, "Info")
        Else ' Mode Update
            ProsesProduk("UPDATE produk_2421068 SET produknama='" & txtproduknama.Text & "', " &
                         "produkkategoriid='" & kategoriID & "', produkmerkid='" & merkID & "', " &
                         "produkstok=" & txtprodukstok.Text & " WHERE produkid='" & txtprodukid.Text & "'")
            MsgBox("Data produk berhasil diupdate.", MsgBoxStyle.Information, "Info")
        End If

        FProduk_Load(Nothing, Nothing) ' Muat ulang seluruh form
    End Sub

    Private Sub cmdhapus_Click(sender As Object, e As EventArgs) Handles cmdhapus.Click
        If MsgBox("Apakah Anda yakin akan menghapus data produk ini?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            ProsesProduk("DELETE FROM produk_2421068 WHERE produkid='" & txtprodukid.Text & "'")
            FProduk_Load(Nothing, Nothing) ' Muat ulang seluruh form
        End If
    End Sub

    Private Sub cmdkeluar_Click(sender As Object, e As EventArgs) Handles cmdkeluar.Click
        Me.Close()
    End Sub

    ' FITUR DIKEMBALIKAN: Event handler untuk tombol '+' di samping ComboBox
    Private Sub cmdcarikategori_Click(sender As Object, e As EventArgs) Handles cmdcarikategori.Click
        ' Asumsi nama form untuk menambah/melihat kategori adalah FKategori
        FKategori.Show()
    End Sub

    Private Sub cmdcarimerk_Click(sender As Object, e As EventArgs) Handles cmdcarimerk.Click
        ' Asumsi nama form untuk menambah/melihat merk adalah FMerk
        FMerk.Show()
    End Sub

End Class
