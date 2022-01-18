Public Class FormRegistrasi
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm1 As New FormLogin
        username = TextBox3.Text
        password = TextBox4.Text
        frm1.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox4.UseSystemPasswordChar = False
        Else
            CheckBox1.Checked = False
            TextBox4.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub FormRegistrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class