Imports System.Data
Imports System.Data.OleDb
Public Class Form_Login
    Private Myconnection As New CLS.clsDatabaseConneciton
    Private Nama As String
    Private Password As String
    Private NamaLengkap As String
    Private objDataTable As Object

    Private Sub Form_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNama_User.MaxLength = 60
        txtPassword.MaxLength = 10
    End Sub

    Public Sub CekUser()
        '=============================================================
        'Fungsi untuk mengecek nama user apakah ada pada database table record user
        'yang dimana nama username = txtusername.text
        objDataTable.Clear()
        StrSql = ("select * from [tbl_userlogin] where [username] = '" & Trim(txtNama_User.Text) & "'")
        objCommand = New OleDbCommand
        objCommand.Connection = Myconnection.Open
        objCommand.CommandType = CommandType.Text
        objCommand.CommandText = StrSql
        objDataAdapter = New OleDbDataAdapter(objCommand)
        objDataAdapter.Fill(objDataSet, "Mdt_Nama_User")
        objDataTable = objDataSet.Tables("Mdt_Nama_User")
        Myconnection.Close()
        '=============================================================
    End Sub

    Private Function Form_Buku1.Form_Login.Form_Buku1() As Object
        Throw New NotImplementedException()
    End Function

    Private Function Form_Login.objCommand() As OleDbCommand
        Throw New NotImplementedException()
    End Function

    Public Sub CekPassword()

        '=============================================================
        'Fungsi mencari nilai value password & Level
        objCommand = Myconnection.Open.CreateCommand
        objCommand.CommandText = ("select [username],[password],[namalengkap] from [tbl_userlogin] where [username]='" & Trim(txtNama_User.Text) & "'")
        objDataReader = objCommand.ExecuteReader
        objDataReader.Read()
        Nama = objDataReader.Item("username")
        Password = objDataReader.Item("password")
        NamaLengkap = objDataReader.Item("namalengkap")
        Myconnection.Close()
        '=============================================================
    End Sub

    Private Function objDataReader() As OleDbDataReader
        Throw New NotImplementedException()
    End Function

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtNama_User.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Maaf Data Login Belum Lengkap..", "DATA LOGIN",
           MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNama_User.Text = ""
            txtPassword.Text = ""
            txtNama_User.Focus()
        Else
            Call CekUser()
            If objDataTable.Rows.Count <= 0 Then
                MessageBox.Show("Maaf Nama User Tidak Terdaftar..", "ID TIDAK
TERDAFTAR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtNama_User.Text = ""
                txtPassword.Text = ""
                txtNama_User.Focus()
            Else
                Call CekPassword()
                If Password <> Trim(txtPassword.Text) Then
                    MessageBox.Show("Password Salah", "SALAH PASSWORD",
MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtPassword.Text = ""
                    txtPassword.Focus()
                Else
                    MessageBox.Show("SELAMAT DATANG " & UCase(NamaLengkap) & "",
"LOGIN SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MenuUtama.ShowDialog()
                    Me.Close()
                    Me.Hide()
                End If
            End If
        End If
    End Sub
    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        End
    End Sub
End Class
