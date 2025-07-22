Public Class FLapJual
    Private Sub cmdkeluar_Click(sender As Object, e As EventArgs) Handles cmdkeluar.Click
        Me.Dispose()
    End Sub

    Private Sub cmdcetak_Click(sender As Object, e As EventArgs) Handles cmdcetak.Click
        Dim crlapproduk As New LapJual
        Dim sql As String
        sql = "SELECT jualnofaktur,jualtgl,jualpelangganid, " &
              " pelanggannama,jualprodukid,produknama,kategorinama,merknama,jualimei, " &
              " jualharga,jualqty,jualuserinput FROM jual_2421068 JOIN pelanggan_2421068 ON jualpelangganid=pelangganid " &
              " JOIN produk_2421068 ON jualprodukid=produkid JOIN kategori_2421068 ON " &
              " produkkategoriid=kategoriid JOIN merk_2421068 ON produkmerkid=merkid "
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "jual")
        crlapproduk.SetDataSource(ds.Tables("jual"))
        FCetak.crv.ReportSource = crlapproduk
        kon.Close()
        FCetak.Show()
        FCetak.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub FLapJual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class