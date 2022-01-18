
Imports System.Data
    Imports System.Data.OleDb
    Public Class Form1
        Dim Myconnection As New CLS.clsDatabaseConneciton
        Dim dtData As New Data.DataTable

        Sub FormatGrid()
            DataGridView1.Columns(0).Width = 130
            DataGridView1.Columns(1).Width = 150
            DataGridView1.Columns(2).Width = 300
            DataGridView1.Columns(3).Width = 100
            DataGridView1.Columns(4).Width = 100
            DataGridView1.Columns(0).HeaderText = "Kode Buku"
            DataGridView1.Columns(1).HeaderText = "Judul Buku"
            DataGridView1.Columns(2).HeaderText = "Pengarang"
            DataGridView1.Columns(3).HeaderText = "Tahun"
            DataGridView1.Columns(4).HeaderText = "Jumlah"
            DataGridView1.ReadOnly = True
        End Sub
        Sub browse()
            objDataTable.Clear()
            StrSql = ("select kodebuku, judulbuku, pengarang,tahun,jumlah from [tbl_buku] where lcase(kodebuku) like '%" & Trim(txtKodeBuku2.Text) & "%' order by judulbuku;")
            objCommand = New OleDbCommand
            objCommand.Connection = Myconnection.Open
            objCommand.CommandType = CommandType.Text
            objCommand.CommandText = StrSql
            objDataAdapter = New OleDbDataAdapter(objCommand)
            objDataAdapter.Fill(objDataSet, "Mdt_tblbuku")
            objDataTable = objDataSet.Tables("Mdt_tblbuku")
            Me.DataGridView1.DataSource = objDataTable
            FormatGrid()
            Myconnection.Close()
        End Sub
        Private Sub hapus()
            StrSql = ("delete from [tbl_buku] where kodebuku='" &
    DataGridView1.CurrentRow.Cells(0).Value & "'")
            objCommand = New OleDbCommand
            objCommand.Connection = Myconnection.Open
            objCommand.CommandType = CommandType.Text
            objCommand.CommandText = StrSql
            objDataAdapter = New OleDbDataAdapter(objCommand)
            objDataAdapter.Fill(objDataSet, "Mdt_tblbuku")
            objCommand.ExecuteNonQuery()
            Myconnection.Close()
            browse()
        End Sub
        Private Sub setClear()
            txtKodeBuku.Text = ""
            txtJudul.Text = ""
            txtPengarang.Text = ""
            txtTahun.Text = ""
            txtJumlah.Text = ""
        End Sub

        Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
            hapus()
        End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbBukuDataSet.tbl_buku' table. You can move, or remove it, as needed.
        Me.Tbl_bukuTableAdapter.Fill(Me.DbBukuDataSet.tbl_buku)

    End Sub
End Class