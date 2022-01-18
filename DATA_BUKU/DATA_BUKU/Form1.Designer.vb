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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtTahun = New System.Windows.Forms.TextBox()
        Me.txtPengarang = New System.Windows.Forms.TextBox()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.txtKodeBuku2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodeBuku = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.DbBukuDataSet = New DATA_BUKU.dbBukuDataSet()
        Me.TblbukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_bukuTableAdapter = New DATA_BUKU.dbBukuDataSetTableAdapters.tbl_bukuTableAdapter()
        Me.KodeBukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JudulBukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PengarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TahunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DbBukuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblbukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBukuDataGridViewTextBoxColumn, Me.JudulBukuDataGridViewTextBoxColumn, Me.PengarangDataGridViewTextBoxColumn, Me.TahunDataGridViewTextBoxColumn, Me.JumlahDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblbukuBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(54, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(702, 128)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnKeluar)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.txtJumlah)
        Me.GroupBox1.Controls.Add(Me.txtTahun)
        Me.GroupBox1.Controls.Add(Me.txtPengarang)
        Me.GroupBox1.Controls.Add(Me.txtJudul)
        Me.GroupBox1.Controls.Add(Me.txtKodeBuku2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 222)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(647, 181)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 13
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(546, 181)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(442, 181)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 11
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(339, 181)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 5
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'txtJumlah
        '
        Me.txtJumlah.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblbukuBindingSource, "Jumlah", True))
        Me.txtJumlah.Location = New System.Drawing.Point(110, 161)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(174, 20)
        Me.txtJumlah.TabIndex = 10
        '
        'txtTahun
        '
        Me.txtTahun.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblbukuBindingSource, "Tahun", True))
        Me.txtTahun.Location = New System.Drawing.Point(110, 128)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Size = New System.Drawing.Size(174, 20)
        Me.txtTahun.TabIndex = 9
        '
        'txtPengarang
        '
        Me.txtPengarang.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblbukuBindingSource, "Pengarang", True))
        Me.txtPengarang.Location = New System.Drawing.Point(110, 93)
        Me.txtPengarang.Name = "txtPengarang"
        Me.txtPengarang.Size = New System.Drawing.Size(634, 20)
        Me.txtPengarang.TabIndex = 8
        '
        'txtJudul
        '
        Me.txtJudul.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblbukuBindingSource, "Judul Buku", True))
        Me.txtJudul.Location = New System.Drawing.Point(111, 62)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(633, 20)
        Me.txtJudul.TabIndex = 4
        '
        'txtKodeBuku2
        '
        Me.txtKodeBuku2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblbukuBindingSource, "Kode Buku", True))
        Me.txtKodeBuku2.Location = New System.Drawing.Point(111, 31)
        Me.txtKodeBuku2.Name = "txtKodeBuku2"
        Me.txtKodeBuku2.Size = New System.Drawing.Size(633, 20)
        Me.txtKodeBuku2.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Jumlah :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tahun :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Pengarang :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Judul Buku :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kode Buku :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kode Buku :"
        '
        'txtKodeBuku
        '
        Me.txtKodeBuku.Location = New System.Drawing.Point(123, 29)
        Me.txtKodeBuku.Name = "txtKodeBuku"
        Me.txtKodeBuku.Size = New System.Drawing.Size(173, 20)
        Me.txtKodeBuku.TabIndex = 3
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(408, 27)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'DbBukuDataSet
        '
        Me.DbBukuDataSet.DataSetName = "dbBukuDataSet"
        Me.DbBukuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblbukuBindingSource
        '
        Me.TblbukuBindingSource.DataMember = "tbl_buku"
        Me.TblbukuBindingSource.DataSource = Me.DbBukuDataSet
        '
        'Tbl_bukuTableAdapter
        '
        Me.Tbl_bukuTableAdapter.ClearBeforeFill = True
        '
        'KodeBukuDataGridViewTextBoxColumn
        '
        Me.KodeBukuDataGridViewTextBoxColumn.DataPropertyName = "Kode Buku"
        Me.KodeBukuDataGridViewTextBoxColumn.HeaderText = "Kode Buku"
        Me.KodeBukuDataGridViewTextBoxColumn.Name = "KodeBukuDataGridViewTextBoxColumn"
        '
        'JudulBukuDataGridViewTextBoxColumn
        '
        Me.JudulBukuDataGridViewTextBoxColumn.DataPropertyName = "Judul Buku"
        Me.JudulBukuDataGridViewTextBoxColumn.HeaderText = "Judul Buku"
        Me.JudulBukuDataGridViewTextBoxColumn.Name = "JudulBukuDataGridViewTextBoxColumn"
        '
        'PengarangDataGridViewTextBoxColumn
        '
        Me.PengarangDataGridViewTextBoxColumn.DataPropertyName = "Pengarang"
        Me.PengarangDataGridViewTextBoxColumn.HeaderText = "Pengarang"
        Me.PengarangDataGridViewTextBoxColumn.Name = "PengarangDataGridViewTextBoxColumn"
        '
        'TahunDataGridViewTextBoxColumn
        '
        Me.TahunDataGridViewTextBoxColumn.DataPropertyName = "Tahun"
        Me.TahunDataGridViewTextBoxColumn.HeaderText = "Tahun"
        Me.TahunDataGridViewTextBoxColumn.Name = "TahunDataGridViewTextBoxColumn"
        '
        'JumlahDataGridViewTextBoxColumn
        '
        Me.JumlahDataGridViewTextBoxColumn.DataPropertyName = "Jumlah"
        Me.JumlahDataGridViewTextBoxColumn.HeaderText = "Jumlah"
        Me.JumlahDataGridViewTextBoxColumn.Name = "JumlahDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtKodeBuku)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DbBukuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblbukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents txtPengarang As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtKodeBuku2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents DbBukuDataSet As dbBukuDataSet
    Friend WithEvents TblbukuBindingSource As BindingSource
    Friend WithEvents Tbl_bukuTableAdapter As dbBukuDataSetTableAdapters.tbl_bukuTableAdapter
    Friend WithEvents KodeBukuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JudulBukuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PengarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TahunDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JumlahDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
