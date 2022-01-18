Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = ""
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Dim a, b, c As Integer


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        a = Val(txtJamKerja.Text)
        b = Val(txtUpah.Text)
        c = Val(txtTotal.Text)
        txtTotal.Text = (a * b) / 3000

    End Sub

    Private Sub cmbGolongan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGolongan.SelectedIndexChanged
        If Me.cmbGolongan.Text = "Golongan A" Then
            Me.txtUpah.Text = 40000
        ElseIf Me.cmbGolongan.Text = "Golongan B" Then
            Me.txtUpah.Text = 50000
        ElseIf Me.cmbGolongan.Text = "Golongan C" Then
            Me.txtUpah.Text = 60000
        ElseIf Me.cmbGolongan.Text = "Golongan D" Then
            Me.txtUpah.Text = 70000
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Me.txtUpah.Text = ""
        Me.txtNama.Text = ""
        Me.txtTotal.Text = ""
        Me.txtJamKerja.Text = ""
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class
