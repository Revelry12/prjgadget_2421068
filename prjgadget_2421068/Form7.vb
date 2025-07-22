Imports MySql.Data.MySqlClient

Public Class FMerk
    Dim strkon As String = "server=localhost;uid=root;database=dbgadget_2421068"
    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim ds As New DataSet
    Dim mda As New MySqlDataAdapter
    Dim cek As MySqlDataReader

    Private Sub FMerk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Kosongkan textbox saat form dimuat
        txtmerk.Text = ""
    End Sub

    Private Sub FMerk_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' Mengambil data dari tabel merk_2421068
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from merk_2421068 order by merkid"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "merk")
        dg.DataSource = ds.Tables("merk")
        kon.Close()
    End Sub

    Private Sub cmdsimpan_Click(sender As Object, e As EventArgs) Handles cmdsimpan.Click
        If String.IsNullOrWhiteSpace(txtmerk.Text) Then
            MsgBox("Nama Merk tidak boleh kosong.", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If
        ' Menyimpan data ke tabel merk_2421068
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "INSERT INTO merk_2421068(merknama) VALUES('" & txtmerk.Text & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
        ' Tutup form setelah menyimpan
        Me.Close()
    End Sub
End Class