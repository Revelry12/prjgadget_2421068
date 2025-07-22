Public Class FLapPelanggan
    Private Sub FLapPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from pelanggan_2421068 order by pelangganid"
        cek = perintah.ExecuteReader
        While cek.Read
            cmbawal.Items.Add(cek.Item("pelangganid"))
            cmbakhir.Items.Add(cek.Item("pelangganid"))
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
        Dim crlapproduk As New LapPelanggan
        Dim sql, query As String
        query = "SELECT * from pelanggan_2421068"

        If rbsemua.Checked = True Then
            sql = query
        Else
            sql = query & " WHERE pelangganid " &
                  " BETWEEN '" & cmbawal.Text & "' AND '" & cmbakhir.Text & "'"
        End If

        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "pelanggan")
        crlapproduk.SetDataSource(ds.Tables("pelanggan"))
        FCetak.crv.ReportSource = crlapproduk
        kon.Close()
        FCetak.Show()
        FCetak.WindowState = FormWindowState.Maximized
    End Sub
End Class