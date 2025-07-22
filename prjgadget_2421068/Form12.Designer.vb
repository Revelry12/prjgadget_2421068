<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLaporanProduk
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbsemua = New System.Windows.Forms.RadioButton()
        Me.rbseleksi = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbakhir = New System.Windows.Forms.ComboBox()
        Me.cmbawal = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdcetak = New System.Windows.Forms.Button()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbsemua)
        Me.GroupBox1.Controls.Add(Me.rbseleksi)
        Me.GroupBox1.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(33, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(556, 167)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pilihan"
        '
        'rbsemua
        '
        Me.rbsemua.AutoSize = True
        Me.rbsemua.Location = New System.Drawing.Point(19, 91)
        Me.rbsemua.Name = "rbsemua"
        Me.rbsemua.Size = New System.Drawing.Size(147, 29)
        Me.rbsemua.TabIndex = 1
        Me.rbsemua.TabStop = True
        Me.rbsemua.Text = "Cetak Semua"
        Me.rbsemua.UseVisualStyleBackColor = True
        '
        'rbseleksi
        '
        Me.rbseleksi.AutoSize = True
        Me.rbseleksi.Location = New System.Drawing.Point(19, 46)
        Me.rbseleksi.Name = "rbseleksi"
        Me.rbseleksi.Size = New System.Drawing.Size(147, 29)
        Me.rbseleksi.TabIndex = 0
        Me.rbseleksi.TabStop = True
        Me.rbseleksi.Text = "Cetak Seleksi"
        Me.rbseleksi.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbakhir)
        Me.GroupBox2.Controls.Add(Me.cmbawal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(642, 137)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'cmbakhir
        '
        Me.cmbakhir.FormattingEnabled = True
        Me.cmbakhir.Location = New System.Drawing.Point(418, 78)
        Me.cmbakhir.Name = "cmbakhir"
        Me.cmbakhir.Size = New System.Drawing.Size(172, 28)
        Me.cmbakhir.TabIndex = 4
        '
        'cmbawal
        '
        Me.cmbawal.FormattingEnabled = True
        Me.cmbawal.Location = New System.Drawing.Point(33, 78)
        Me.cmbawal.Name = "cmbawal"
        Me.cmbawal.Size = New System.Drawing.Size(172, 28)
        Me.cmbawal.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(299, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "s/d"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(413, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Produk"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Produk"
        '
        'cmdcetak
        '
        Me.cmdcetak.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcetak.Location = New System.Drawing.Point(83, 382)
        Me.cmdcetak.Name = "cmdcetak"
        Me.cmdcetak.Size = New System.Drawing.Size(116, 55)
        Me.cmdcetak.TabIndex = 5
        Me.cmdcetak.Text = "CETAK"
        Me.cmdcetak.UseVisualStyleBackColor = True
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdkeluar.Location = New System.Drawing.Point(276, 382)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(116, 55)
        Me.cmdkeluar.TabIndex = 6
        Me.cmdkeluar.Text = "Keluar"
        Me.cmdkeluar.UseVisualStyleBackColor = True
        '
        'FLaporanProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 537)
        Me.Controls.Add(Me.cmdkeluar)
        Me.Controls.Add(Me.cmdcetak)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FLaporanProduk"
        Me.Text = "Laporan Data Produk"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbsemua As RadioButton
    Friend WithEvents rbseleksi As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbakhir As ComboBox
    Friend WithEvents cmbawal As ComboBox
    Friend WithEvents cmdcetak As Button
    Friend WithEvents cmdkeluar As Button
End Class
