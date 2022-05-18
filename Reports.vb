Public Class Reports
    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GD_BillRecords.CellContentClick

    End Sub

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_BillRecords.TB_Bill_Records' table. You can move, or remove it, as needed.
        Me.TB_Bill_RecordsTableAdapter.Fill(Me.DB_BillRecords.TB_Bill_Records)

    End Sub
End Class