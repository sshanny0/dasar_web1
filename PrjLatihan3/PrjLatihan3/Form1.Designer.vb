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
        Me.TxtAngka = New System.Windows.Forms.TextBox()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtAngka
        '
        Me.TxtAngka.Location = New System.Drawing.Point(189, 68)
        Me.TxtAngka.Name = "TxtAngka"
        Me.TxtAngka.Size = New System.Drawing.Size(419, 20)
        Me.TxtAngka.TabIndex = 0
        '
        'BtnProses
        '
        Me.BtnProses.Location = New System.Drawing.Point(493, 188)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(115, 21)
        Me.BtnProses.TabIndex = 1
        Me.BtnProses.Text = "Proses"
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnProses)
        Me.Controls.Add(Me.TxtAngka)
        Me.Name = "Form1"
        Me.Text = "Penanganan Kesalahan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtAngka As TextBox
    Friend WithEvents BtnProses As Button
End Class
