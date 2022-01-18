Public Class FormLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm3 As New FormInput
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            MsgBox("Login berhasil", vbInformation, "SUKSES")
            frm3.Show()
            Me.Hide()
        ElseIf TextBox1.Text = username And TextBox2.Text = password Then
            MsgBox("Login berhasil", vbInformation, "SUKSES")
            frm3.Show()
            Me.Hide()
        Else
            TextBox1.Text = ""
            TextBox2.Text = ""
            MsgBox("Error, login gagal", vbCritical, "GAGAL")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm2 As New FormRegistrasi
        frm2.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            CheckBox1.Checked = False
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class