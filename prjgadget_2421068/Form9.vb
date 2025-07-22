Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class FJual
    Dim i, no As Integer
    Dim totsel, kembali As Double

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltgl.Text = Format(Now, "dd/MM/yyyy") & " - " & Format(Now, "HH:mm:ss")
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub FJual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buatkolom()
        tidakaktif()
        bersih()
    End Sub

    Private Sub dg_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellEndEdit
        Dim currentRow As DataGridViewRow = dg.Rows(e.RowIndex)

        Try
            ' --- Aksi saat Kode Produk diisi ---
            If e.ColumnIndex = dg.Columns("kode").Index Then
                Dim produkId As String = If(currentRow.Cells("kode").Value, "").ToString()
                If String.IsNullOrEmpty(produkId) Then Return

                If kon.State = ConnectionState.Open Then kon.Close()
                kon.Open()
                perintah.Connection = kon
                perintah.CommandText = "SELECT p.produknama, k.kategorinama, m.merknama " &
                                       "FROM produk_2421068 p " &
                                       "JOIN kategori_2421068 k ON p.produkkategoriid = k.kategoriid " &
                                       "JOIN merk_2421068 m ON p.produkmerkid = m.merkid " &
                                       "WHERE p.produkid='" & produkId & "'"
                cek = perintah.ExecuteReader()

                If cek.Read() Then
                    ' Isi data produk
                    currentRow.Cells("nama").Value = cek.Item("produknama")
                    currentRow.Cells("kategori").Value = cek.Item("kategorinama")
                    currentRow.Cells("merk").Value = cek.Item("merknama")
                    currentRow.Cells("qty").Value = 1

                    ' Hitung subtotal
                    Dim qty As Integer = 1
                    Dim harga As Double = CDbl(currentRow.Cells("harga").Value)
                    currentRow.Cells("subtotal").Value = qty * harga
                Else
                    MsgBox("Data Barang Tidak Ada", MsgBoxStyle.Information, "Informasi")
                    ' Hapus baris jika kode produk tidak valid untuk mencegah error
                    If Not currentRow.IsNewRow Then dg.Rows.Remove(currentRow)
                End If
                cek.Close()
            End If

            ' --- Aksi saat Quantity atau Harga diubah ---
            If e.ColumnIndex = dg.Columns("qty").Index Or e.ColumnIndex = dg.Columns("harga").Index Then
                Dim qty As Integer = CInt(If(currentRow.Cells("qty").Value, 0))
                Dim harga As Double = CDbl(If(currentRow.Cells("harga").Value, 0))
                currentRow.Cells("subtotal").Value = qty * harga
            End If

            ' Panggil kalkulasi total setelah semua aksi di atas
            hitungtotal()
            hitungtotqty()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If Not cek Is Nothing AndAlso Not cek.IsClosed Then cek.Close()
            If kon.State = ConnectionState.Open Then kon.Close()
        End Try

    End Sub

    Private Sub cmdbaru_Click(sender As Object, e As EventArgs) Handles cmdbaru.Click
        bersih()
        aktif()
        buatfaktur()
        txtpelangganid.Focus()
    End Sub

    Private Sub cmdcaripelanggan_Click(sender As Object, e As EventArgs) Handles cmdcaripelanggan.Click
        FCariPelanggan.Show()
    End Sub

    Private Sub cmdsimpan_Click(sender As Object, e As EventArgs) Handles cmdsimpan.Click
        ' Check if pelanggan is selected
        If String.IsNullOrEmpty(txtpelangganid.Text) OrElse String.IsNullOrEmpty(txtpelanggannama.Text) Then
            MsgBox("Harap pilih pelanggan terlebih dahulu.", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If

        ' Validasi produk: pastikan ada minimal satu baris produk yang terisi
        Dim produkAda As Boolean = False
        For Each row As DataGridViewRow In dg.Rows
            If Not row.IsNewRow AndAlso Not String.IsNullOrEmpty(row.Cells("kode").Value?.ToString()) Then
                produkAda = True
                Exit For
            End If
        Next
        If Not produkAda Then
            MsgBox("Harap isi data produk terlebih dahulu.", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If

        ' Check if there are any empty required cells in non-empty rows
        For Each row As DataGridViewRow In dg.Rows
            If row.IsNewRow Then Continue For

            If String.IsNullOrEmpty(row.Cells("kode").Value?.ToString()) OrElse
               String.IsNullOrEmpty(row.Cells("nama").Value?.ToString()) OrElse
               Not IsNumeric(row.Cells("qty").Value) OrElse
               Not IsNumeric(row.Cells("harga").Value) Then
                MsgBox("Ada data produk yang belum lengkap. Silakan periksa kembali.", MsgBoxStyle.Exclamation, "Peringatan")
                Return
            End If
        Next

        ' If all validations pass, proceed with save
        If MsgBox("Apakah Anda yakin ingin menyimpan transaksi ini?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            simpantransaksi()
            tidakaktif()
            cmdcetak.Enabled = True
        End If
    End Sub

    Private Sub txtjmluang_TextChanged(sender As Object, e As EventArgs) Handles txtjmluang.TextChanged
        If IsNumeric(txtjmluang.Text) Then
            kembali = Val(txtjmluang.Text) - totsel
            txtkembali.Text = Format(kembali, "Rp #,##0")
        Else
            txtkembali.Text = "Rp 0"
        End If
    End Sub

    Private Sub cmdtambahpelanggan_Click(sender As Object, e As EventArgs) Handles cmdtambahpelanggan.Click
        FPelanggan.Show()
    End Sub

    Private Sub cmdkeluar_Click(sender As Object, e As EventArgs) Handles cmdkeluar.Click
        Me.Dispose()
        FMenu.Show()
    End Sub

    Private Sub txtpelangganid_TextChanged(sender As Object, e As EventArgs) Handles txtpelangganid.TextChanged

    End Sub

    Private Sub dg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dg.KeyPress
        If e.KeyChar = Chr(27) Then
            If dg.CurrentRow.IsNewRow Then
                MsgBox("Cannot delete an uncommitted new row.", MsgBoxStyle.Information, "Error")
                Return
            End If
            dg.Rows.RemoveAt(dg.CurrentCell.RowIndex)
            Call hitungtotqty()
            Call hitungtotal()
        End If
        If (InStr("RTAB", e.KeyChar) = 0) And (e.KeyChar <> Chr(8)) Then
            e.KeyChar = Chr(0)
        Else
            MsgBox("Input anda salah")
        End If
    End Sub

    Function terbilang(ByVal n As Double) As String
        Dim satuan As String() = {"", "Satu", "Dua", "Tiga", "Empat", "Lima",
                                  "Enam", "Tujuh", "Delapan", "Sembilan", "Sepuluh", "Sebelas"}

        Select Case n
            Case 0 To 11
                terbilang = " " & satuan(Fix(n))
            Case 12 To 19
                terbilang = terbilang(n Mod 10) & " Belas"
            Case 20 To 99
                terbilang = terbilang(Fix(n / 10)) & " Puluh " & terbilang(n Mod 10)
            Case 100 To 199
                terbilang = " Seratus" & terbilang(n - 100)
            Case 200 To 999
                terbilang = terbilang(Fix(n / 100)) & " Ratus " & terbilang(n Mod 100)
            Case 1000 To 1999
                terbilang = " Seribu" & terbilang(n - 1000)
            Case 2000 To 999999
                terbilang = terbilang(Fix(n / 1000)) & " Ribu " & terbilang(n Mod 1000)
            Case 1000000 To 999999999
                terbilang = terbilang(Fix(n / 1000000)) & " Juta " & terbilang(n Mod 1000000)
            Case 1000000000 To 999999999999
                terbilang = terbilang(Fix(n / 1000000000)) & " Milyar " & terbilang(n Mod 1000000000)
            Case Else
                terbilang = terbilang(Fix(n / 1000000000000)) & " Trilyun " & terbilang(n Mod 1000000000000)
        End Select
    End Function

    Private Sub txtpelangganid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpelangganid.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                kon.Open()
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "SELECT * FROM pelanggan_2421068 WHERE pelangganid='" & txtpelangganid.Text & "'"
                cek = perintah.ExecuteReader()
                cek.Read()
                If cek.HasRows Then
                    txtpelanggannama.Text = cek.Item("pelanggannama").ToString()
                Else
                    MsgBox("Kode Pelanggan Tidak Ada", MsgBoxStyle.Information, "Informasi")
                End If
            Catch ex As Exception
                MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Finally
                If kon.State = ConnectionState.Open Then
                    kon.Close()
                End If
            End Try
        End If
    End Sub
    Sub tidakaktif()
        txtjualnofaktur.Enabled = False
        txtpelangganid.Enabled = False
        txtpelanggannama.Enabled = False
        txtjmluang.Enabled = False
        txtkembali.Enabled = False
        dg.Enabled = False
        cmdsimpan.Enabled = False
        cmdcetak.Enabled = False
        cmdbaru.Enabled = True
    End Sub

    Sub aktif()
        txtpelangganid.Enabled = True
        txtjmluang.Enabled = True
        dg.Enabled = True
        cmdsimpan.Enabled = True
        cmdcetak.Enabled = False
    End Sub

    Sub bersih()
        txtjualnofaktur.Text = ""
        txtpelangganid.Text = ""
        txtpelanggannama.Text = ""
        txtjmluang.Text = ""
        txtkembali.Text = ""
        lblterbilang.Text = "..."
        lbltotbay.Text = "Rp 0"
        lbltotqty.Text = "0"
        totsel = 0
        dg.Rows.Clear()
    End Sub

    Sub buatkolom()
        If dg.Columns.Count = 0 Then
            dg.Columns.Add("kode", "Kode Produk")
            dg.Columns.Add("nama", "Nama Produk")
            dg.Columns.Add("kategori", "Kategori")
            dg.Columns.Add("merk", "Merk Produk")
            dg.Columns.Add("imei", "No. IMEI/No. Seri")
            dg.Columns.Add("qty", "Quantity")
            dg.Columns.Add("harga", "Harga Jual")
            dg.Columns.Add("subtotal", "Sub Total")

            dg.Columns("nama").ReadOnly = True
            dg.Columns("subtotal").ReadOnly = True

            dg.Columns("harga").DefaultCellStyle.Format = "N0"
            dg.Columns("subtotal").DefaultCellStyle.Format = "N0"
        End If
    End Sub

    Sub hitungtotal()
        Dim total As Double = 0
        For Each row As DataGridViewRow In dg.Rows
            If row.IsNewRow Then Continue For
            total += CDbl(If(row.Cells("subtotal").Value, 0))
        Next
        lbltotbay.Text = Format(total, "Rp #,##0")
        lblterbilang.Text = UCase(terbilang(total)) & " RUPIAH"
        totsel = total

        ' Update kembalian here
        Dim jumlahUang As Double
        If Double.TryParse(txtjmluang.Text, jumlahUang) Then
            kembali = jumlahUang - totsel
            txtkembali.Text = Format(kembali, "Rp #,##0")
        Else
            txtkembali.Text = "Rp 0"
        End If
    End Sub

    Sub hitungtotqty()
        Dim totqty As Integer = 0
        For Each row As DataGridViewRow In dg.Rows
            If row.IsNewRow Then Continue For
            totqty += CInt(If(row.Cells("qty").Value, 0))
        Next
        lbltotqty.Text = totqty.ToString()
    End Sub

    Private Sub cmdcetak_Click(sender As Object, e As EventArgs) Handles cmdcetak.Click
        tampilDataFaktur()
        Try
            ' 1. Membuat instance dari file laporan Faktur.rpt Anda
            Dim crfaktur As New Faktur()

            ' 2. PERBAIKAN: Query SQL dengan JOIN yang benar menggunakan alias tabel (j, pl, p, k, m)
            Dim sql As String = "SELECT j.jualnofaktur, j.jualtgl, j.jualpelangganid, pl.pelanggannama, " &
                            "j.jualprodukid, p.produknama, k.kategorinama, m.merknama, j.jualimei, " &
                            "j.jualharga, j.jualqty, j.jualuserinput " &
                            "FROM jual_2421068 j " &
                            "JOIN pelanggan_2421068 pl ON j.jualpelangganid = pl.pelangganid " &
                            "JOIN produk_2421068 p ON j.jualprodukid = p.produkid " &
                            "JOIN kategori_2421068 k ON p.produkkategoriid = k.kategoriid " &
                            "JOIN merk_2421068 m ON p.produkmerkid = m.merkid " &
                            "WHERE j.jualnofaktur = '" & txtjualnofaktur.Text & "'"

            If kon.State = ConnectionState.Open Then kon.Close()
            kon.Open()

            ' 3. Mengisi DataSet dengan data dari query yang sudah benar
            mda = New MySqlDataAdapter(sql, kon)
            Dim dsCetak As New DataSet()
            mda.Fill(dsCetak, "faktur") ' Nama tabel harus cocok dengan di DataSet report

            ' 4. Mengatur sumber data dan menampilkan laporan
            crfaktur.SetDataSource(dsCetak.Tables("faktur"))
            FCetak.crv.ReportSource = crfaktur
            FCetak.Show()
            FCetak.WindowState = FormWindowState.Maximized

        Catch ex As Exception
            MsgBox("Gagal menampilkan laporan: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ' Selalu pastikan koneksi ditutup
            If kon.State = ConnectionState.Open Then
                kon.Close()
            End If
        End Try
    End Sub

    Function simpantransaksi() As Boolean
        Try
            kon.Open()
            For i = 0 To dg.RowCount - 2
                perintah.Connection = kon
                perintah.CommandType = CommandType.Text
                perintah.CommandText = "INSERT INTO jual_2421068 (jualnofaktur, jualtgl, " &
                                       "jualpelangganid, jualprodukid, jualimei, jualharga, jualqty, " &
                                       "jualuserinput) VALUES('" & txtjualnofaktur.Text & "', '" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "', " &
                                       "'" & txtpelangganid.Text & "', '" & dg.Rows.Item(i).Cells("kode").Value & "', " &
                                       "'" & dg.Rows.Item(i).Cells("imei").Value & "', '" & dg.Rows.Item(i).Cells("harga").Value & "', " &
                                       "'" & dg.Rows.Item(i).Cells("qty").Value & "', '" & useraktif & "')"
                perintah.ExecuteNonQuery()

                perintah.CommandText = "UPDATE produk_2421068 SET produkstok = produkstok - " & dg.Rows.Item(i).Cells("qty").Value & " " &
                                       "WHERE produkid = '" & dg.Rows.Item(i).Cells("kode").Value & "'"
                perintah.ExecuteNonQuery()
            Next
            MsgBox("Data Sukses Disimpan", MsgBoxStyle.Information, "Informasi")
            Return True
        Catch ex As Exception
            MsgBox("Gagal menyimpan data: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            If kon.State = ConnectionState.Open Then kon.Close()
        End Try
    End Function

    Private Sub FJual_Scroll(sender As Object, e As ScrollEventArgs) Handles MyBase.Scroll

    End Sub

    Sub buatfaktur()
        Dim kode, kodebaru, tgl As String
        Dim no As Integer
        tgl = Format(Now, "ddMMyyyy")
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select jualnofaktur from jual_2421068 " &
                               "order by jualnofaktur desc limit 1"
        cek = perintah.ExecuteReader()
        cek.Read()
        If cek.HasRows Then
            kode = cek.Item("jualnofaktur")
            no = Val(Microsoft.VisualBasic.Mid(kode, 3, 4))
            no = no + 1
            kodebaru = "F-" & Format(no, "0000") & tgl
            txtjualnofaktur.Text = kodebaru
        Else
            txtjualnofaktur.Text = "F-0001" & tgl
        End If
        cek.Close()
        kon.Close()
    End Sub

    Sub tampilplg()
        perintah.CommandText = "select pelangganid,pelanggannama from pelanggan_2421068 order by pelangganid"
    End Sub

    Sub tampilDataFaktur()
        dg.Rows.Clear()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT j.jualprodukid, p.produknama, k.kategorinama, m.merknama, " &
                               "j.jualimei, j.jualqty, j.jualharga, (j.jualqty * j.jualharga) AS subtotal " &
                               "FROM jual_2421068 j " &
                               "JOIN produk_2421068 p ON j.jualprodukid = p.produkid " &
                               "JOIN kategori_2421068 k ON p.produkkategoriid = k.kategoriid " &
                               "JOIN merk_2421068 m ON p.produkmerkid = m.merkid " &
                               "WHERE j.jualnofaktur = '" & txtjualnofaktur.Text & "'"
        cek = perintah.ExecuteReader()
        While cek.Read()
            dg.Rows.Add(
                cek("jualprodukid"),    ' Kode
                cek("produknama"),      ' Nama
                cek("kategorinama"),     ' Kategori
                cek("merknama"),        ' Merk
                cek("jualimei"),        ' IMEI
                cek("jualqty"),         ' Qty
                cek("jualharga"),       ' Harga
                cek("subtotal")         ' Subtotal
            )
        End While
        cek.Close()
        kon.Close()
    End Sub
End Class
