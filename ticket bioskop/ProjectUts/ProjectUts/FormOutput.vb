Public Class FormOutput
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bayar As Integer
        bayar = TextBox6.Text
        total = TextBox7.Text
        If bayar > total Then
            TextBox8.Text = TextBox6.Text - TextBox7.Text
            Label11.Text = ""
        Else
            Label11.Visible = True
            Label11.Text = "Maaf, Saldo Anda Tidak Mencukupi"
            TextBox8.Text = ""
        End If
    End Sub
End Class