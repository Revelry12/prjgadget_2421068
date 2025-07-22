Imports MySql.Data.MySqlClient

Module Module1
    Dim strkon As String = "server=localhost;uid=root;password=;database=dbgadget_2421068"

    Public kon As New MySqlConnection(strkon)
    Public perintah As New MySqlCommand
    Public cek As MySqlDataReader
    Public mda As New MySqlDataAdapter
    Public ds As New DataSet
    Public useraktif As String
    Public simpan As Boolean
End Module