Imports System.Data.OleDb
Imports System.Data

Module mdlDeclarasi
    Public objCommand As OleDbCommand
    Public objDataAdapter As OleDbDataAdapter
    Public objDataReader As OleDbDataReader
    Public StrSql As String
    Public objDataSet As New DataSet
    Public objDataTable As New DataTable
End Module

Namespace CLS
    Public Class clsDatabaseConneciton
        Private Connect As New _
 OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Persist " & "Security Info=False;Data Source=dbPerpustakaan.accdb")
        Public Function Open() As OleDbConnection
            Connect.Open()
            Return Connect
        End Function
        Public Function Close() As OleDbConnection
            Connect.Close()
            Return Connect
        End Function
    End Class
End Namespace