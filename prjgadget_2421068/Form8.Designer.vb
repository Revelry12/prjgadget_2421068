<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPelanggan
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
        Me.txtnamapelanggan = New System.Windows.Forms.TextBox()
        Me.txtidpelanggan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtnohp = New System.Windows.Forms.TextBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcaripelanggan = New System.Windows.Forms.TextBox()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.cmdhapus = New System.Windows.Forms.Button()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.cmdtambah = New System.Windows.Forms.Button()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnamapelanggan
        '
        Me.txtnamapelanggan.Location = New System.Drawing.Point(222, 162)
        Me.txtnamapelanggan.Name = "txtnamapelanggan"
        Me.txtnamapelanggan.Size = New System.Drawing.Size(380, 26)
        Me.txtnamapelanggan.TabIndex = 10
        '
        'txtidpelanggan
        '
        Me.txtidpelanggan.Location = New System.Drawing.Point(222, 106)
        Me.txtidpelanggan.Name = "txtidpelanggan"
        Me.txtidpelanggan.Size = New System.Drawing.Size(133, 26)
        Me.txtidpelanggan.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Id Pelanggan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 25)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Nomor HP"
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(222, 215)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(311, 26)
        Me.txtalamat.TabIndex = 13
        '
        'txtnohp
        '
        Me.txtnohp.Location = New System.Drawing.Point(222, 276)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(311, 26)
        Me.txtnohp.TabIndex = 14
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(65, 483)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersWidth = 62
        Me.dg.RowTemplate.Height = 28
        Me.dg.Size = New System.Drawing.Size(588, 150)
        Me.dg.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(60, 388)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(251, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Cari Kode / Nama Pelanggan"
        '
        'txtcaripelanggan
        '
        Me.txtcaripelanggan.Location = New System.Drawing.Point(65, 427)
        Me.txtcaripelanggan.Name = "txtcaripelanggan"
        Me.txtcaripelanggan.Size = New System.Drawing.Size(592, 26)
        Me.txtcaripelanggan.TabIndex = 23
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdkeluar.Location = New System.Drawing.Point(514, 323)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(114, 50)
        Me.cmdkeluar.TabIndex = 22
        Me.cmdkeluar.Text = "Keluar"
        Me.cmdkeluar.UseVisualStyleBackColor = True
        '
        'cmdhapus
        '
        Me.cmdhapus.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdhapus.Location = New System.Drawing.Point(373, 323)
        Me.cmdhapus.Name = "cmdhapus"
        Me.cmdhapus.Size = New System.Drawing.Size(114, 50)
        Me.cmdhapus.TabIndex = 21
        Me.cmdhapus.Text = "Hapus"
        Me.cmdhapus.UseVisualStyleBackColor = True
        '
        'cmdsimpan
        '
        Me.cmdsimpan.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsimpan.Location = New System.Drawing.Point(220, 323)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(114, 50)
        Me.cmdsimpan.TabIndex = 20
        Me.cmdsimpan.Text = "Simpan"
        Me.cmdsimpan.UseVisualStyleBackColor = True
        '
        'cmdtambah
        '
        Me.cmdtambah.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdtambah.Location = New System.Drawing.Point(61, 323)
        Me.cmdtambah.Name = "cmdtambah"
        Me.cmdtambah.Size = New System.Drawing.Size(114, 50)
        Me.cmdtambah.TabIndex = 19
        Me.cmdtambah.Text = "Tambah"
        Me.cmdtambah.UseVisualStyleBackColor = True
        '
        'FPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 694)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcaripelanggan)
        Me.Controls.Add(Me.cmdkeluar)
        Me.Controls.Add(Me.cmdhapus)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.cmdtambah)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnamapelanggan)
        Me.Controls.Add(Me.txtidpelanggan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FPelanggan"
        Me.Text = "DATA PELANGGAN"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnamapelanggan As TextBox
    Friend WithEvents txtidpelanggan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents txtnohp As TextBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcaripelanggan As TextBox
    Friend WithEvents cmdkeluar As Button
    Friend WithEvents cmdhapus As Button
    Friend WithEvents cmdsimpan As Button
    Friend WithEvents cmdtambah As Button
End Class
