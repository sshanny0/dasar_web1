Public Class Form1
    Private Sub MHSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MHSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MHSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbMhsDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbMhsDataSet.MHS' table. You can move, or remove it, as needed.
        Me.MHSTableAdapter.Fill(Me.DbMhsDataSet.MHS)

    End Sub
End Class
