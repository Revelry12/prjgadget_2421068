<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FJual
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtjualnofaktur = New System.Windows.Forms.TextBox()
        Me.txtpelangganid = New System.Windows.Forms.TextBox()
        Me.cmdbaru = New System.Windows.Forms.Button()
        Me.cmdcaripelanggan = New System.Windows.Forms.Button()
        Me.lbltgl = New System.Windows.Forms.Label()
        Me.txtpelanggannama = New System.Windows.Forms.TextBox()
        Me.cmdtambahpelanggan = New System.Windows.Forms.Button()
        Me.lbltotbay = New System.Windows.Forms.Label()
        Me.lbltotqty = New System.Windows.Forms.Label()
        Me.lblterbilang = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdcetak = New System.Windows.Forms.Button()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtjmluang = New System.Windows.Forms.TextBox()
        Me.txtkembali = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Faktur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pelanggan"
        '
        'txtjualnofaktur
        '
        Me.txtjualnofaktur.Location = New System.Drawing.Point(185, 41)
        Me.txtjualnofaktur.Name = "txtjualnofaktur"
        Me.txtjualnofaktur.Size = New System.Drawing.Size(252, 26)
        Me.txtjualnofaktur.TabIndex = 2
        '
        'txtpelangganid
        '
        Me.txtpelangganid.Location = New System.Drawing.Point(185, 95)
        Me.txtpelangganid.Name = "txtpelangganid"
        Me.txtpelangganid.Size = New System.Drawing.Size(252, 26)
        Me.txtpelangganid.TabIndex = 3
        '
        'cmdbaru
        '
        Me.cmdbaru.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdbaru.Location = New System.Drawing.Point(463, 37)
        Me.cmdbaru.Name = "cmdbaru"
        Me.cmdbaru.Size = New System.Drawing.Size(71, 35)
        Me.cmdbaru.TabIndex = 4
        Me.cmdbaru.Text = "Baru"
        Me.cmdbaru.UseVisualStyleBackColor = True
        '
        'cmdcaripelanggan
        '
        Me.cmdcaripelanggan.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcaripelanggan.Location = New System.Drawing.Point(463, 90)
        Me.cmdcaripelanggan.Name = "cmdcaripelanggan"
        Me.cmdcaripelanggan.Size = New System.Drawing.Size(71, 35)
        Me.cmdcaripelanggan.TabIndex = 5
        Me.cmdcaripelanggan.Text = "..."
        Me.cmdcaripelanggan.UseVisualStyleBackColor = True
        '
        'lbltgl
        '
        Me.lbltgl.AutoSize = True
        Me.lbltgl.Location = New System.Drawing.Point(563, 44)
        Me.lbltgl.Name = "lbltgl"
        Me.lbltgl.Size = New System.Drawing.Size(57, 20)
        Me.lbltgl.TabIndex = 6
        Me.lbltgl.Text = "Label3"
        '
        'txtpelanggannama
        '
        Me.txtpelanggannama.Location = New System.Drawing.Point(567, 95)
        Me.txtpelanggannama.Name = "txtpelanggannama"
        Me.txtpelanggannama.Size = New System.Drawing.Size(228, 26)
        Me.txtpelanggannama.TabIndex = 7
        '
        'cmdtambahpelanggan
        '
        Me.cmdtambahpelanggan.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdtambahpelanggan.Location = New System.Drawing.Point(814, 90)
        Me.cmdtambahpelanggan.Name = "cmdtambahpelanggan"
        Me.cmdtambahpelanggan.Size = New System.Drawing.Size(47, 35)
        Me.cmdtambahpelanggan.TabIndex = 8
        Me.cmdtambahpelanggan.Text = "+"
        Me.cmdtambahpelanggan.UseVisualStyleBackColor = True
        '
        'lbltotbay
        '
        Me.lbltotbay.AutoSize = True
        Me.lbltotbay.Font = New System.Drawing.Font("Montserrat", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotbay.Location = New System.Drawing.Point(934, 16)
        Me.lbltotbay.Name = "lbltotbay"
        Me.lbltotbay.Size = New System.Drawing.Size(261, 62)
        Me.lbltotbay.TabIndex = 9
        Me.lbltotbay.Text = "Total Bayar"
        '
        'lbltotqty
        '
        Me.lbltotqty.AutoSize = True
        Me.lbltotqty.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotqty.Location = New System.Drawing.Point(949, 90)
        Me.lbltotqty.Name = "lbltotqty"
        Me.lbltotqty.Size = New System.Drawing.Size(107, 31)
        Me.lbltotqty.TabIndex = 10
        Me.lbltotqty.Text = "Quantity"
        '
        'lblterbilang
        '
        Me.lblterbilang.AutoSize = True
        Me.lblterbilang.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblterbilang.Location = New System.Drawing.Point(32, 192)
        Me.lblterbilang.Name = "lblterbilang"
        Me.lblterbilang.Size = New System.Drawing.Size(113, 31)
        Me.lblterbilang.TabIndex = 11
        Me.lblterbilang.Text = "Terbilang"
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(33, 307)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersWidth = 62
        Me.dg.RowTemplate.Height = 28
        Me.dg.Size = New System.Drawing.Size(1105, 340)
        Me.dg.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Data Produk"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(33, 650)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(426, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Tekan tombol ""Esc"" untuk menghapus item produk"
        '
        'cmdcetak
        '
        Me.cmdcetak.Location = New System.Drawing.Point(38, 722)
        Me.cmdcetak.Name = "cmdcetak"
        Me.cmdcetak.Size = New System.Drawing.Size(138, 35)
        Me.cmdcetak.TabIndex = 15
        Me.cmdcetak.Text = "Cetak Faktur"
        Me.cmdcetak.UseVisualStyleBackColor = True
        '
        'cmdsimpan
        '
        Me.cmdsimpan.Location = New System.Drawing.Point(214, 722)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(120, 35)
        Me.cmdsimpan.TabIndex = 16
        Me.cmdsimpan.Text = "Simpan"
        Me.cmdsimpan.UseVisualStyleBackColor = True
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Location = New System.Drawing.Point(371, 722)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(120, 35)
        Me.cmdkeluar.TabIndex = 17
        Me.cmdkeluar.Text = "Keluar"
        Me.cmdkeluar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(854, 732)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 25)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Jumlah Uang"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(854, 796)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 25)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Kembali"
        '
        'txtjmluang
        '
        Me.txtjmluang.Location = New System.Drawing.Point(1001, 732)
        Me.txtjmluang.Name = "txtjmluang"
        Me.txtjmluang.Size = New System.Drawing.Size(171, 26)
        Me.txtjmluang.TabIndex = 20
        '
        'txtkembali
        '
        Me.txtkembali.Location = New System.Drawing.Point(1001, 795)
        Me.txtkembali.Name = "txtkembali"
        Me.txtkembali.Size = New System.Drawing.Size(171, 26)
        Me.txtkembali.TabIndex = 21
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 940)
        Me.Controls.Add(Me.txtkembali)
        Me.Controls.Add(Me.txtjmluang)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdkeluar)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.cmdcetak)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.lblterbilang)
        Me.Controls.Add(Me.lbltotqty)
        Me.Controls.Add(Me.lbltotbay)
        Me.Controls.Add(Me.cmdtambahpelanggan)
        Me.Controls.Add(Me.txtpelanggannama)
        Me.Controls.Add(Me.lbltgl)
        Me.Controls.Add(Me.cmdcaripelanggan)
        Me.Controls.Add(Me.cmdbaru)
        Me.Controls.Add(Me.txtpelangganid)
        Me.Controls.Add(Me.txtjualnofaktur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FJual"
        Me.Text = "Entri Data Penjualan"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtjualnofaktur As TextBox
    Friend WithEvents txtpelangganid As TextBox
    Friend WithEvents cmdbaru As Button
    Friend WithEvents cmdcaripelanggan As Button
    Friend WithEvents lbltgl As Label
    Friend WithEvents txtpelanggannama As TextBox
    Friend WithEvents cmdtambahpelanggan As Button
    Friend WithEvents lbltotbay As Label
    Friend WithEvents lbltotqty As Label
    Friend WithEvents lblterbilang As Label
    Friend WithEvents dg As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdcetak As Button
    Friend WithEvents cmdsimpan As Button
    Friend WithEvents cmdkeluar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtjmluang As TextBox
    Friend WithEvents txtkembali As TextBox
    Friend WithEvents Timer1 As Timer
End Class
