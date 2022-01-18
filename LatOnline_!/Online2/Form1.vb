Public Class Form1
    Private Sub btNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNew.Click
        Me.inputInap.Clear()
        Me.inputHrgPerhari.Clear()
        Me.inputBiaya.Clear()
        Me.inputJumlah.Clear()
        Me.inputKembali.Clear()
        Me.inputInap.Focus()
    End Sub
    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Close()
    End Sub

    Private Sub cbJenis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbJenis.SelectedIndexChanged
        If Me.cbJenis.Text = "VIP" Then
            Me.inputHrgPerhari.Text = 750000
        ElseIf Me.cbJenis.Text = "Kelas I" Then
            Me.inputHrgPerhari.Text = 500000
        ElseIf Me.cbJenis.Text = "Kelas II" Then
            Me.inputHrgPerhari.Text = 300000
        ElseIf Me.cbJenis.Text = "Kelas III" Then
            Me.inputHrgPerhari.Text = 150000
        End If
    End Sub

    Private Sub txtMenginap_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles inputInap.KeyDown
        inputBiaya.Text = Val(inputHrgPerhari.Text) * Val(inputInap.Text)

        If e.KeyCode = Keys.Enter Then
            Me.inputJumlah.Focus()
        End If
    End Sub

    Private Sub txtJumlah_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles inputJumlah.KeyDown
        inputKembali.Text = Val(inputJumlah.Text) - Val(inputBiaya.Text)
    End Sub
End Class
