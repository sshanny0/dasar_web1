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
        Me.ofdBuka = New System.Windows.Forms.OpenFileDialog()
        Me.PcbGambar = New System.Windows.Forms.PictureBox()
        Me.BtnBuka = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        CType(Me.PcbGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ofdBuka
        '
        Me.ofdBuka.FileName = "OpenFileDialog1"
        '
        'PcbGambar
        '
        Me.PcbGambar.Location = New System.Drawing.Point(32, 29)
        Me.PcbGambar.Name = "PcbGambar"
        Me.PcbGambar.Size = New System.Drawing.Size(504, 350)
        Me.PcbGambar.TabIndex = 0
        Me.PcbGambar.TabStop = False
        '
        'BtnBuka
        '
        Me.BtnBuka.Location = New System.Drawing.Point(300, 401)
        Me.BtnBuka.Name = "BtnBuka"
        Me.BtnBuka.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuka.TabIndex = 1
        Me.BtnBuka.Text = "Buka"
        Me.BtnBuka.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(429, 401)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 2
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 450)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnBuka)
        Me.Controls.Add(Me.PcbGambar)
        Me.Name = "Form1"
        Me.Text = "Aplikasi Buka Gambar"
        CType(Me.PcbGambar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ofdBuka As OpenFileDialog
    Friend WithEvents PcbGambar As PictureBox
    Friend WithEvents BtnBuka As Button
    Friend WithEvents BtnExit As Button
End Class
