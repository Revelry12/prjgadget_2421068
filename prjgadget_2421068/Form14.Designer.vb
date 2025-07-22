<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLapJual
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
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.cmdcetak = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdkeluar.Location = New System.Drawing.Point(451, 163)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(116, 55)
        Me.cmdkeluar.TabIndex = 12
        Me.cmdkeluar.Text = "Keluar"
        Me.cmdkeluar.UseVisualStyleBackColor = True
        '
        'cmdcetak
        '
        Me.cmdcetak.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcetak.Location = New System.Drawing.Point(258, 163)
        Me.cmdcetak.Name = "cmdcetak"
        Me.cmdcetak.Size = New System.Drawing.Size(116, 55)
        Me.cmdcetak.TabIndex = 11
        Me.cmdcetak.Text = "CETAK"
        Me.cmdcetak.UseVisualStyleBackColor = True
        '
        'FLapJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdkeluar)
        Me.Controls.Add(Me.cmdcetak)
        Me.Name = "FLapJual"
        Me.Text = "Data Laporan Penjualan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdkeluar As Button
    Friend WithEvents cmdcetak As Button
End Class
