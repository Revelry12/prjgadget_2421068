<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fuser
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
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.cmblevel = New System.Windows.Forms.ComboBox()
        Me.cmdreset = New System.Windows.Forms.Button()
        Me.rbaktif = New System.Windows.Forms.RadioButton()
        Me.rbblokir = New System.Windows.Forms.RadioButton()
        Me.cmdtambah = New System.Windows.Forms.Button()
        Me.cmdsimpan = New System.Windows.Forms.Button()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Lengkap User"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Level"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Status"
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(309, 54)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(245, 26)
        Me.txtuser.TabIndex = 4
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(309, 106)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(357, 26)
        Me.txtnama.TabIndex = 5
        '
        'cmblevel
        '
        Me.cmblevel.FormattingEnabled = True
        Me.cmblevel.Location = New System.Drawing.Point(309, 170)
        Me.cmblevel.Name = "cmblevel"
        Me.cmblevel.Size = New System.Drawing.Size(245, 28)
        Me.cmblevel.TabIndex = 6
        '
        'cmdreset
        '
        Me.cmdreset.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdreset.Location = New System.Drawing.Point(591, 164)
        Me.cmdreset.Name = "cmdreset"
        Me.cmdreset.Size = New System.Drawing.Size(173, 37)
        Me.cmdreset.TabIndex = 7
        Me.cmdreset.Text = "Reset Password"
        Me.cmdreset.UseVisualStyleBackColor = True
        '
        'rbaktif
        '
        Me.rbaktif.AutoSize = True
        Me.rbaktif.Location = New System.Drawing.Point(309, 224)
        Me.rbaktif.Name = "rbaktif"
        Me.rbaktif.Size = New System.Drawing.Size(66, 24)
        Me.rbaktif.TabIndex = 8
        Me.rbaktif.TabStop = True
        Me.rbaktif.Text = "Aktif"
        Me.rbaktif.UseVisualStyleBackColor = True
        '
        'rbblokir
        '
        Me.rbblokir.AutoSize = True
        Me.rbblokir.Location = New System.Drawing.Point(429, 224)
        Me.rbblokir.Name = "rbblokir"
        Me.rbblokir.Size = New System.Drawing.Size(73, 24)
        Me.rbblokir.TabIndex = 9
        Me.rbblokir.TabStop = True
        Me.rbblokir.Text = "Blokir"
        Me.rbblokir.UseVisualStyleBackColor = True
        '
        'cmdtambah
        '
        Me.cmdtambah.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdtambah.Location = New System.Drawing.Point(53, 316)
        Me.cmdtambah.Name = "cmdtambah"
        Me.cmdtambah.Size = New System.Drawing.Size(105, 37)
        Me.cmdtambah.TabIndex = 10
        Me.cmdtambah.Text = "Tambah"
        Me.cmdtambah.UseVisualStyleBackColor = True
        '
        'cmdsimpan
        '
        Me.cmdsimpan.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsimpan.Location = New System.Drawing.Point(199, 316)
        Me.cmdsimpan.Name = "cmdsimpan"
        Me.cmdsimpan.Size = New System.Drawing.Size(105, 37)
        Me.cmdsimpan.TabIndex = 11
        Me.cmdsimpan.Text = "Simpan"
        Me.cmdsimpan.UseVisualStyleBackColor = True
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdkeluar.Location = New System.Drawing.Point(342, 316)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(105, 37)
        Me.cmdkeluar.TabIndex = 12
        Me.cmdkeluar.Text = "Keluar"
        Me.cmdkeluar.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(503, 321)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(245, 26)
        Me.txtcari.TabIndex = 13
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(12, 379)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersWidth = 62
        Me.dg.RowTemplate.Height = 28
        Me.dg.Size = New System.Drawing.Size(825, 240)
        Me.dg.TabIndex = 14
        '
        'Fuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 645)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.cmdkeluar)
        Me.Controls.Add(Me.cmdsimpan)
        Me.Controls.Add(Me.cmdtambah)
        Me.Controls.Add(Me.rbblokir)
        Me.Controls.Add(Me.rbaktif)
        Me.Controls.Add(Me.cmdreset)
        Me.Controls.Add(Me.cmblevel)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Fuser"
        Me.Text = "Data User"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents cmblevel As ComboBox
    Friend WithEvents cmdreset As Button
    Friend WithEvents rbaktif As RadioButton
    Friend WithEvents rbblokir As RadioButton
    Friend WithEvents cmdtambah As Button
    Friend WithEvents cmdsimpan As Button
    Friend WithEvents cmdkeluar As Button
    Friend WithEvents txtcari As TextBox
    Friend WithEvents dg As DataGridView
End Class
