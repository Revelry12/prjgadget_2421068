Public Class FLaporanProduk
    Private Sub FLaporanProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from produk_2421068 order by produkid"
        cek = perintah.ExecuteReader
        While cek.Read
            cmbawal.Items.Add(cek.Item("produkid"))
            cmbakhir.Items.Add(cek.Item("produkid"))
        End While
        cek.Close()
        kon.Close()

        cmbawal.Enabled = False
        cmbakhir.Enabled = False
    End Sub

    Private Sub rbseleksi_CheckedChanged(sender As Object, e As EventArgs) Handles rbseleksi.CheckedChanged
        If rbseleksi.Checked = True Then
            cmbawal.Enabled = True
            cmbakhir.Enabled = True
        Else
            cmbawal.Enabled = False
            cmbakhir.Enabled = False
        End If
    End Sub

    Private Sub cmdkeluar_Click(sender As Object, e As EventArgs) Handles cmdkeluar.Click
        Me.Dispose()
    End Sub

    Private Sub cmdcetak_Click(sender As Object, e As EventArgs) Handles cmdcetak.Click
        Dim crLapproduk As New LapProduk
        Dim sql, query As String
        query = "SELECT produkid,produknama,kategorinama,merknama,produkstok " &
                "FROM produk_2421068 JOIN kategori_2421068 ON produkkategoriid=kategoriid JOIN " &
                "merk_2421068 ON produkmerkid=merkid"

        If rbsemua.Checked = True Then
            sql = query
        Else
            sql = query & " WHERE produkid " &
                  " BETWEEN '" & cmbawal.Text & "' AND '" & cmbakhir.Text & "'"
        End If

        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "produk")
        crLapproduk.SetDataSource(ds.Tables("produk"))
        FCetak.crv.ReportSource = crLapproduk
        kon.Close()
        FCetak.Show()
        FCetak.WindowState = FormWindowState.Maximized
    End Sub
End Class