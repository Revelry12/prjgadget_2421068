Public Class FCariPelanggan
    Sub tampilplg(ByVal sql As String)
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "plg")
        dg.DataSource = ds.Tables("plg")
        kon.Close()
    End Sub

    Sub setdg()
        dg.Columns(0).HeaderText = "Kode Pelanggan"
        dg.Columns(1).HeaderText = "Nama Pelanggan"

        dg.Columns(0).Width = 140
        dg.Columns(1).Width = 300
    End Sub
    Private Sub FCariPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilplg("select pelangganid,pelanggannama from pelanggan_2421068 order by pelangganid")
        setdg()
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        Dim i As Integer
        i = dg.CurrentRow.Index
        FJual.txtpelangganid.Text = dg.Rows.Item(i).Cells(0).Value
        FJual.txtpelanggannama.Text = dg.Rows.Item(i).Cells(1).Value
        Me.Close()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        tampilplg("select pelangganid,pelanggannama from pelanggan_2421068 where pelangganid='" & txtcari.Text & "' or pelanggannama like '%" & txtcari.Text & "%'")
        setdg()
    End Sub
End Class
