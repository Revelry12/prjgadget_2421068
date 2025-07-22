Public Class FMenu
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdukToolStripMenuItem.Click
        FProduk.Show()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        FPelanggan.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        FJual.Show()
    End Sub

    Private Sub LaporanDataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanDataProdukToolStripMenuItem.Click
        FLaporanProduk.Show()
    End Sub

    Private Sub GantiPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        Fgantipassword.Show()
    End Sub

    Private Sub ManajemenUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenUserToolStripMenuItem.Click
        Fuser.Show()
    End Sub

    Private Sub LoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub LaporanDataPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanDataPelangganToolStripMenuItem.Click
        FLapPelanggan.Show()
    End Sub

    Private Sub LaporanPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPenjualanToolStripMenuItem.Click
        FLapJual.Show()
    End Sub
End Class