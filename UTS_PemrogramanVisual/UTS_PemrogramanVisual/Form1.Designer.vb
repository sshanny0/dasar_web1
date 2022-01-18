<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtUpah = New System.Windows.Forms.TextBox()
        Me.txtJamKerja = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.cmbGolongan = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Golongan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Upah Per Jam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah Jam Kerja"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Upah"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(161, 36)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(227, 20)
        Me.txtNama.TabIndex = 5
        '
        'txtUpah
        '
        Me.txtUpah.Enabled = False
        Me.txtUpah.Location = New System.Drawing.Point(161, 133)
        Me.txtUpah.Name = "txtUpah"
        Me.txtUpah.Size = New System.Drawing.Size(227, 20)
        Me.txtUpah.TabIndex = 6
        '
        'txtJamKerja
        '
        Me.txtJamKerja.Location = New System.Drawing.Point(161, 195)
        Me.txtJamKerja.Name = "txtJamKerja"
        Me.txtJamKerja.Size = New System.Drawing.Size(227, 20)
        Me.txtJamKerja.TabIndex = 7
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(161, 254)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(227, 20)
        Me.txtTotal.TabIndex = 8
        '
        'cmbGolongan
        '
        Me.cmbGolongan.FormattingEnabled = True
        Me.cmbGolongan.Items.AddRange(New Object() {"Golongan A", "Golongan B", "Golongan C", "Golongan D"})
        Me.cmbGolongan.Location = New System.Drawing.Point(161, 83)
        Me.cmbGolongan.Name = "cmbGolongan"
        Me.cmbGolongan.Size = New System.Drawing.Size(227, 21)
        Me.cmbGolongan.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnKeluar)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(50, 328)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(702, 110)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Navigasi"
        '
        'btnKeluar
        '
        Me.btnKeluar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnKeluar.Location = New System.Drawing.Point(429, 45)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(123, 33)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnSimpan.Location = New System.Drawing.Point(246, 45)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(123, 33)
        Me.btnSimpan.TabIndex = 1
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnTambah.Location = New System.Drawing.Point(60, 45)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(123, 33)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbGolongan)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtJamKerja)
        Me.Controls.Add(Me.txtUpah)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Upah Karyawan"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUpah As TextBox
    Friend WithEvents txtJamKerja As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents cmbGolongan As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnTambah As Button
End Class
