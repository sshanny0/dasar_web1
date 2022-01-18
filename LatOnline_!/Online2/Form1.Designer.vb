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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.inputKembali = New System.Windows.Forms.TextBox()
        Me.inputJumlah = New System.Windows.Forms.TextBox()
        Me.inputBiaya = New System.Windows.Forms.TextBox()
        Me.inputHrgPerhari = New System.Windows.Forms.TextBox()
        Me.inputInap = New System.Windows.Forms.TextBox()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btNew = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.inputKembali)
        Me.GroupBox1.Controls.Add(Me.inputJumlah)
        Me.GroupBox1.Controls.Add(Me.inputBiaya)
        Me.GroupBox1.Controls.Add(Me.inputHrgPerhari)
        Me.GroupBox1.Controls.Add(Me.inputInap)
        Me.GroupBox1.Controls.Add(Me.cbJenis)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(31, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(734, 322)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "| Data Hotel |"
        '
        'inputKembali
        '
        Me.inputKembali.Location = New System.Drawing.Point(218, 285)
        Me.inputKembali.Name = "inputKembali"
        Me.inputKembali.Size = New System.Drawing.Size(273, 20)
        Me.inputKembali.TabIndex = 11
        '
        'inputJumlah
        '
        Me.inputJumlah.Location = New System.Drawing.Point(218, 238)
        Me.inputJumlah.Name = "inputJumlah"
        Me.inputJumlah.Size = New System.Drawing.Size(273, 20)
        Me.inputJumlah.TabIndex = 10
        '
        'inputBiaya
        '
        Me.inputBiaya.Location = New System.Drawing.Point(218, 190)
        Me.inputBiaya.Name = "inputBiaya"
        Me.inputBiaya.Size = New System.Drawing.Size(273, 20)
        Me.inputBiaya.TabIndex = 9
        '
        'inputHrgPerhari
        '
        Me.inputHrgPerhari.Location = New System.Drawing.Point(218, 139)
        Me.inputHrgPerhari.Name = "inputHrgPerhari"
        Me.inputHrgPerhari.Size = New System.Drawing.Size(273, 20)
        Me.inputHrgPerhari.TabIndex = 8
        '
        'inputInap
        '
        Me.inputInap.Location = New System.Drawing.Point(218, 85)
        Me.inputInap.Name = "inputInap"
        Me.inputInap.Size = New System.Drawing.Size(273, 20)
        Me.inputInap.TabIndex = 7
        '
        'cbJenis
        '
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Items.AddRange(New Object() {"VIP", "Kelas I", "Kelas II", "Kelas III"})
        Me.cbJenis.Location = New System.Drawing.Point(218, 33)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(273, 21)
        Me.cbJenis.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Location = New System.Drawing.Point(39, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Kembali"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label5.Location = New System.Drawing.Point(39, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah Bayar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(39, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Biaya Sewa Kamar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(39, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga Sewa Perhari"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(39, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lama Menginap"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(39, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jenis Kamar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btClose)
        Me.GroupBox2.Controls.Add(Me.btNew)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox2.Location = New System.Drawing.Point(31, 352)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(734, 86)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "| Navigasi |"
        '
        'btClose
        '
        Me.btClose.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btClose.Location = New System.Drawing.Point(247, 19)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(98, 57)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "Close"
        Me.btClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btNew
        '
        Me.btNew.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btNew.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btNew.Location = New System.Drawing.Point(114, 19)
        Me.btNew.Name = "btNew"
        Me.btNew.Size = New System.Drawing.Size(98, 57)
        Me.btNew.TabIndex = 0
        Me.btNew.Text = "New"
        Me.btNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btNew.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Data Penginapan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents inputKembali As TextBox
    Friend WithEvents inputJumlah As TextBox
    Friend WithEvents inputBiaya As TextBox
    Friend WithEvents inputHrgPerhari As TextBox
    Friend WithEvents inputInap As TextBox
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents btClose As Button
    Friend WithEvents btNew As Button
End Class
