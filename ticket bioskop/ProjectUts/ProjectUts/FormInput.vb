Public Class FormInput
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm4 As New FormOutput
        jumlah = 0
        If ComboBox1.SelectedItem = "The Witches" Then
            frm4.TextBox1.Text = ComboBox1.Text
        ElseIf ComboBox1.SelectedItem = "Black Widow" Then
            frm4.TextBox1.Text = ComboBox1.Text
        ElseIf ComboBox1.SelectedItem = "The Croods 2" Then
            frm4.TextBox1.Text = ComboBox1.Text
        ElseIf ComboBox1.SelectedItem = "Death On The Nile" Then
            frm4.TextBox1.Text = ComboBox1.Text
        ElseIf ComboBox1.SelectedItem = "Free Guy" Then
            frm4.TextBox1.Text = ComboBox1.Text
        ElseIf ComboBox1.SelectedItem = "Avengers: Infinity War" Then
            frm4.TextBox1.Text = ComboBox1.Text
        ElseIf ComboBox1.SelectedItem = "Avengers: Endgame" Then
            frm4.TextBox1.Text = ComboBox1.Text
        End If

        frm4.TextBox10.Text = Format(DateTimePicker1.Value, "dddd")
        frm4.TextBox2.Text = Format(DateTimePicker1.Value, "d MMM yyyy")

        If ComboBox4.SelectedItem = "12:15" Then
            frm4.TextBox3.Text = "12:15"
        ElseIf ComboBox4.SelectedItem = "14:30" Then
            frm4.TextBox3.Text = "14:30"
        ElseIf ComboBox4.SelectedItem = "16:45" Then
            frm4.TextBox3.Text = "16:45"
        ElseIf ComboBox4.SelectedItem = "19:00" Then
            frm4.TextBox3.Text = "19:00"
        ElseIf ComboBox4.SelectedItem = "21:15" Then
            frm4.TextBox3.Text = "21:15"
        ElseIf ComboBox4.SelectedItem = "23:30" Then
            frm4.TextBox3.Text = "23:30"
        End If

        If CheckBox8.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox8.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox7.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox7.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox6.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox6.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox5.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox5.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox4.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox4.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox3.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox3.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox2.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox2.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox1.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox1.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox9.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox9.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox10.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox10.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox11.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox11.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox12.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox12.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox13.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox13.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox14.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox14.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox15.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox15.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox16.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox16.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox17.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox17.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox18.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox18.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox19.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox19.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox20.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox20.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox21.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox21.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox22.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox22.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox23.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox23.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox24.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox24.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox25.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox25.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox26.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox26.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox27.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox27.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox28.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox28.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox29.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox29.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox30.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox30.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox31.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox31.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox32.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox32.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox33.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox33.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox34.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox34.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox35.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox35.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox36.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox36.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox37.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox37.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox38.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox38.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox39.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox39.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox40.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox40.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox41.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox41.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox42.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox42.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox43.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox43.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox44.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox44.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox45.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox45.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox46.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox46.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox47.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox47.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox48.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox48.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox49.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox49.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox50.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox50.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox51.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox51.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox52.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox52.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox53.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox53.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox54.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox54.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox55.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox55.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox56.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox56.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox57.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox57.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox58.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox58.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox59.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox59.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox60.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox60.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox61.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox61.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox62.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox62.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox63.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox63.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox64.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox64.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox65.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox65.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox66.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox66.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox67.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox67.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox68.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox68.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox69.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox69.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox70.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox70.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox71.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox71.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox72.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox72.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox73.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox73.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox74.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox74.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox75.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox75.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox76.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox76.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox77.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox77.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox78.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox78.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox79.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox79.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If
        If CheckBox80.Checked Then
            frm4.TextBox4.Text = frm4.TextBox4.Text + CheckBox80.Text + " "
            jumlah += 1
            frm4.TextBox5.Text = jumlah
        Else
            kurang = jumlah - 1
            frm4.TextBox5.Text = jumlah
        End If

        If frm4.TextBox10.Text = "Monday" Then
            total = 30000 * jumlah
            frm4.TextBox7.Text = total
        ElseIf frm4.TextBox10.Text = "Tuesday" Then
            total = 30000 * jumlah
            frm4.TextBox7.Text = total
        ElseIf frm4.TextBox10.Text = "Wednesday" Then
            total = 30000 * jumlah
            frm4.TextBox7.Text = total
        ElseIf frm4.TextBox10.Text = "Thursday" Then
            total = 30000 * jumlah
            frm4.TextBox7.Text = total
        ElseIf frm4.TextBox10.Text = "Friday" Then
            total = 35000 * jumlah
            frm4.TextBox7.Text = total
        ElseIf frm4.TextBox10.Text = "Saturday" Then
            total = 40000 * jumlah
            frm4.TextBox7.Text = total
        ElseIf frm4.TextBox10.Text = "Sunday" Then
            total = 40000 * jumlah
            frm4.TextBox7.Text = total
        End If
        frm4.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm5 As New FormInfo
        frm5.Show()
    End Sub
End Class