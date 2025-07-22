<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FProduk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtprodukid = New System.Windows.Forms.TextBox()
        Me.txtproduknama = New System.Windows.Forms.TextBox()
        Me.txtprodukstok = New System.Windows.Forms.TextBox()
        Me.cmbkategori = New System.Windows.Forms.ComboBox()
        Me.cmbmerk = New System.Windows.Forms.ComboBox()
        Me.cmdcarikategori = New System.Windows.Forms.Button()
        Me.cmdcarimerk = New System.Windows.Forms.Button()
        Me.cmdtambah = New System.Windows.Forms.Button()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.cmdhapus = New System.Windows.Forms.Button()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Produk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kategori"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Merk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stok"
        '
        'txtprodukid
        '
        Me.txtprodukid.Location = New System.Drawing.Point(189, 44)
        Me.txtprodukid.Name = "txtprodukid"
        Me.txtprodukid.Size = New System.Drawing.Size(133, 26)
        Me.txtprodukid.TabIndex = 5
        '
        'txtproduknama
        '
        Me.txtproduknama.Location = New System.Drawing.Point(189, 100)
        Me.txtproduknama.Name = "txtproduknama"
        Me.txtproduknama.Size = New System.Drawing.Size(380, 26)
        Me.txtproduknama.TabIndex = 6
        '
        'txtprodukstok
        '
        Me.txtprodukstok.Location = New System.Drawing.Point(189, 280)
        Me.txtprodukstok.Name = "txtprodukstok"
        Me.txtprodukstok.Size = New System.Drawing.Size(100, 26)
        Me.txtprodukstok.TabIndex = 7
        '
        'cmbkategori
        '
        Me.cmbkategori.FormattingEnabled = True
        Me.cmbkategori.Location = New System.Drawing.Point(189, 156)
        Me.cmbkategori.Name = "cmbkategori"
        Me.cmbkategori.Size = New System.Drawing.Size(293, 28)
        Me.cmbkategori.TabIndex = 8
        '
        'cmbmerk
        '
        Me.cmbmerk.FormattingEnabled = True
        Me.cmbmerk.Location = New System.Drawing.Point(189, 223)
        Me.cmbmerk.Name = "cmbmerk"
        Me.cmbmerk.Size = New System.Drawing.Size(293, 28)
        Me.cmbmerk.TabIndex = 9
        '
        'cmdcarikategori
        '
        Me.cmdcarikategori.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcarikategori.Location = New System.Drawing.Point(508, 149)
        Me.cmdcarikategori.Name = "cmdcarikategori"
        Me.cmdcarikategori.Size = New System.Drawing.Size(61, 39)
        Me.cmdcarikategori.TabIndex = 10
        Me.cmdcarikategori.Text = "+"
        Me.cmdcarikategori.UseVisualStyleBackColor = True
        '
        'cmdcarimerk
        '
        Me.cmdcarimerk.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcarimerk.Location = New System.Drawing.Point(508, 217)
        Me.cmdcarimerk.Name = "cmdcarimerk"
        Me.cmdcarimerk.Size = New System.Drawing.Size(61, 39)
        Me.cmdcarimerk.TabIndex = 11
        Me.cmdcarimerk.Text = "+"
        Me.cmdcarimerk.UseVisualStyleBackColor = True
        '
        'cmdtambah
        '
        Me.cmdtambah.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdtambah.Location = New System.Drawing.Point(30, 358)
        Me.cmdtambah.Name = "cmdtambah"
        Me.cmdtambah.Size = New System.Drawing.Size(114, 50)
        Me.cmdtambah.TabIndex = 12
        Me.cmdtambah.Text = "Tambah"
        Me.cmdtambah.UseVisualStyleBackColor = True
        '
        'cmdsimpan
        '
        Me.cmdsimpan.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsimpan.Location = New System.Drawing.Point(189, 358)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(114, 50)
        Me.cmdsimpan.TabIndex = 13
        Me.cmdsimpan.Text = "Simpan"
        Me.cmdsimpan.UseVisualStyleBackColor = True
        '
        'cmdhapus
        '
        Me.cmdhapus.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdhapus.Location = New System.Drawing.Point(342, 358)
        Me.cmdhapus.Name = "cmdhapus"
        Me.cmdhapus.Size = New System.Drawing.Size(114, 50)
        Me.cmdhapus.TabIndex = 14
        Me.cmdhapus.Text = "Hapus"
        Me.cmdhapus.UseVisualStyleBackColor = True
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdkeluar.Location = New System.Drawing.Point(483, 358)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(114, 50)
        Me.cmdkeluar.TabIndex = 15
        Me.cmdkeluar.Text = "Keluar"
        Me.cmdkeluar.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(34, 462)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(592, 26)
        Me.txtcari.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 423)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(221, 25)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Cari Kode / Nama Produk"
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(34, 518)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersWidth = 62
        Me.dg.RowTemplate.Height = 28
        Me.dg.Size = New System.Drawing.Size(588, 150)
        Me.dg.TabIndex = 18
        '
        'FProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 693)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.cmdkeluar)
        Me.Controls.Add(Me.cmdhapus)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.cmdtambah)
        Me.Controls.Add(Me.cmdcarimerk)
        Me.Controls.Add(Me.cmdcarikategori)
        Me.Controls.Add(Me.cmbmerk)
        Me.Controls.Add(Me.cmbkategori)
        Me.Controls.Add(Me.txtprodukstok)
        Me.Controls.Add(Me.txtproduknama)
        Me.Controls.Add(Me.txtprodukid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FProduk"
        Me.Text = "DATA PRODUK"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtprodukid As TextBox
    Friend WithEvents txtproduknama As TextBox
    Friend WithEvents txtprodukstok As TextBox
    Friend WithEvents cmbkategori As ComboBox
    Friend WithEvents cmbmerk As ComboBox
    Friend WithEvents cmdcarikategori As Button
    Friend WithEvents cmdcarimerk As Button
    Friend WithEvents cmdtambah As Button
    Friend WithEvents cmdsimpan As Button
    Friend WithEvents cmdhapus As Button
    Friend WithEvents cmdkeluar As Button
    Friend WithEvents txtcari As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dg As DataGridView
End Class
