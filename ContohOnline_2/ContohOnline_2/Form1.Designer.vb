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
        Me.TxtNIM = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.CmbKelamin = New System.Windows.Forms.ComboBox()
        Me.CmbProdi = New System.Windows.Forms.ComboBox()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "KELAMIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PRODI"
        '
        'TxtNIM
        '
        Me.TxtNIM.Location = New System.Drawing.Point(165, 46)
        Me.TxtNIM.Name = "TxtNIM"
        Me.TxtNIM.Size = New System.Drawing.Size(206, 20)
        Me.TxtNIM.TabIndex = 4
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(165, 105)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(206, 20)
        Me.TxtNama.TabIndex = 5
        '
        'CmbKelamin
        '
        Me.CmbKelamin.FormattingEnabled = True
        Me.CmbKelamin.Location = New System.Drawing.Point(166, 162)
        Me.CmbKelamin.Name = "CmbKelamin"
        Me.CmbKelamin.Size = New System.Drawing.Size(205, 21)
        Me.CmbKelamin.TabIndex = 6
        '
        'CmbProdi
        '
        Me.CmbProdi.FormattingEnabled = True
        Me.CmbProdi.Location = New System.Drawing.Point(166, 240)
        Me.CmbProdi.Name = "CmbProdi"
        Me.CmbProdi.Size = New System.Drawing.Size(205, 21)
        Me.CmbProdi.TabIndex = 7
        '
        'BtnProses
        '
        Me.BtnProses.Location = New System.Drawing.Point(343, 292)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(89, 26)
        Me.BtnProses.TabIndex = 8
        Me.BtnProses.Text = "Proses"
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(46, 359)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(656, 157)
        Me.ListView1.TabIndex = 9
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 538)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.BtnProses)
        Me.Controls.Add(Me.CmbProdi)
        Me.Controls.Add(Me.CmbKelamin)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtNIM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Array Multi Dimensi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNIM As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents CmbKelamin As ComboBox
    Friend WithEvents CmbProdi As ComboBox
    Friend WithEvents BtnProses As Button
    Friend WithEvents ListView1 As ListView

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Arr(3, 1) As String
        Arr(0, 0) = "NIM"
        Arr(0, 1) = "NAMA"
        Arr(1, 0) = "JENIS KELAMIN"
        Arr(1, 1) = "PRODI"
        Arr(2, 0) = "Laki-laki"
        Arr(2, 1) = "Perempuan"
        Arr(3, 0) = "Sistem Informasi"
        Arr(3, 1) = "Teknik Informatika"
        ListView1.GridLines = True
        ListView1.View = View.Details
        For Baris = 0 To 1
            For Kolom = 0 To 1
                ListView1.Columns.Add(Arr(Baris, Kolom), 100)
            Next Kolom
        Next Baris
        For Baris = 2 To 2
            For Kolom = 0 To 1
                CmbKelamin.Items.Add(Arr(Baris, Kolom))
            Next Kolom
        Next Baris
        For Baris = 3 To 3
            For Kolom = 0 To 1
                CmbProdi.Items.Add(Arr(Baris, Kolom))
            Next Kolom
        Next Baris
    End Sub

    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        Dim Arr(3) As String
        Arr(0) = TxtNIM.Text
        Arr(1) = TxtNama.Text
        Arr(2) = CmbKelamin.Text
        Arr(3) = CmbProdi.Text
        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(Arr(0))
        listitem.SubItems.Add(Arr(1))
        listitem.SubItems.Add(Arr(2))
        listitem.SubItems.Add(Arr(3))
        TxtNIM.Text = TxtNIM.Text + 1
        TxtNama.Text = ""
        CmbKelamin.Text = ""
        CmbProdi.Text = ""
        TxtNama.Focus()
    End Sub
End Class
