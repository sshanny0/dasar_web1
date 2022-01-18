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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKode_Obat = New System.Windows.Forms.TextBox()
        Me.txtNama_Obat = New System.Windows.Forms.TextBox()
        Me.txtBanyak = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.cbSatuan = New System.Windows.Forms.ComboBox()
        Me.btTambah = New System.Windows.Forms.Button()
        Me.btSimpan = New System.Windows.Forms.Button()
        Me.btExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(49, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "| Data Obat |"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(122, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Obat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(122, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Obat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(122, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Satuan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(122, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah Obat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(122, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Harga Satuan"
        '
        'txtKode_Obat
        '
        Me.txtKode_Obat.Location = New System.Drawing.Point(288, 71)
        Me.txtKode_Obat.Name = "txtKode_Obat"
        Me.txtKode_Obat.Size = New System.Drawing.Size(177, 20)
        Me.txtKode_Obat.TabIndex = 6
        '
        'txtNama_Obat
        '
        Me.txtNama_Obat.Location = New System.Drawing.Point(288, 122)
        Me.txtNama_Obat.Name = "txtNama_Obat"
        Me.txtNama_Obat.Size = New System.Drawing.Size(332, 20)
        Me.txtNama_Obat.TabIndex = 7
        '
        'txtBanyak
        '
        Me.txtBanyak.Location = New System.Drawing.Point(288, 265)
        Me.txtBanyak.Name = "txtBanyak"
        Me.txtBanyak.Size = New System.Drawing.Size(177, 20)
        Me.txtBanyak.TabIndex = 8
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(288, 327)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(177, 20)
        Me.txtHarga.TabIndex = 9
        '
        'cbSatuan
        '
        Me.cbSatuan.FormattingEnabled = True
        Me.cbSatuan.Items.AddRange(New Object() {"Buah", "Box", "Botol", "Dus", "Tablet"})
        Me.cbSatuan.Location = New System.Drawing.Point(288, 173)
        Me.cbSatuan.Name = "cbSatuan"
        Me.cbSatuan.Size = New System.Drawing.Size(177, 21)
        Me.cbSatuan.TabIndex = 10
        '
        'btTambah
        '
        Me.btTambah.Location = New System.Drawing.Point(648, 71)
        Me.btTambah.Name = "btTambah"
        Me.btTambah.Size = New System.Drawing.Size(104, 45)
        Me.btTambah.TabIndex = 11
        Me.btTambah.Text = "Tambah"
        Me.btTambah.UseVisualStyleBackColor = True
        '
        'btSimpan
        '
        Me.btSimpan.Location = New System.Drawing.Point(648, 199)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(104, 45)
        Me.btSimpan.TabIndex = 12
        Me.btSimpan.Text = "Simpan"
        Me.btSimpan.UseVisualStyleBackColor = True
        '
        'btExit
        '
        Me.btExit.Location = New System.Drawing.Point(648, 302)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(104, 45)
        Me.btExit.TabIndex = 13
        Me.btExit.Text = "Keluar"
        Me.btExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.btSimpan)
        Me.Controls.Add(Me.btTambah)
        Me.Controls.Add(Me.cbSatuan)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtBanyak)
        Me.Controls.Add(Me.txtNama_Obat)
        Me.Controls.Add(Me.txtKode_Obat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Entri Data Obat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtKode_Obat As TextBox
    Friend WithEvents txtNama_Obat As TextBox
    Friend WithEvents txtBanyak As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents cbSatuan As ComboBox
    Friend WithEvents btTambah As Button
    Friend WithEvents btSimpan As Button
    Friend WithEvents btExit As Button
End Class
