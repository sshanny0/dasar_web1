Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Entri Data Obat"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.btSimpan.Enabled = False
    End Sub
    Private Sub btTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTambah.Click
        Me.txtKode_Obat.Clear()
        Me.txtNama_Obat.Clear()
        Me.txtBanyak.Clear()
        Me.txtHarga.Clear()
        Me.txtKode_Obat.Focus()
    End Sub
    Private Sub btExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExit.Click
        Me.Close()
    End Sub
    Private Sub cbSatuan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSatuan.SelectedIndexChanged
        If Me.cbSatuan.Text = "Buah" Then
            Me.txtHarga.Text = 50000
        ElseIf Me.cbSatuan.Text = "Box" Then
            Me.txtHarga.Text = 60000
        ElseIf Me.cbSatuan.Text = "Botol" Then
            Me.txtHarga.Text = 70000
        ElseIf Me.cbSatuan.Text = "Dus" Then
            Me.txtHarga.Text = 80000
        ElseIf Me.cbSatuan.Text = "Tablet" Then
            Me.txtHarga.Text = 5000
        End If
    End Sub
End Class