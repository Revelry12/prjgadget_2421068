Imports MySql.Data.MySqlClient
Public Class FKategori
    Dim strkon As String = "server=localhost;uid=root;database=dbgadget_2421068"
    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim ds As New DataSet
    Dim mda As New MySqlDataAdapter
    Dim cek As MySqlDataReader

    Private Sub FKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Kosongkan textbox saat form dimuat
        txtkategori.Text = ""
    End Sub

    Private Sub FKategori_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from kategori_2421068 order by kategoriid"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "kategori")
        dg.DataSource = ds.Tables("kategori")
        kon.Close()
    End Sub

    Private Sub cmdsimpan_Click(sender As Object, e As EventArgs) Handles cmdsimpan.Click
        If String.IsNullOrWhiteSpace(txtkategori.Text) Then
            MsgBox("Nama Kategori tidak boleh kosong.", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If

        ' Menyimpan data ke tabel kategori_2421068
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "INSERT INTO kategori_2421068(kategorinama) VALUES('" & txtkategori.Text & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
        ' Tutup form setelah menyimpan
        Me.Close()
    End Sub
End Class