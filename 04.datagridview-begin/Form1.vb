'Referensi belajar http://vb.net-informations.com/datagridview/vb.net_datagridview_add.htm

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.ColumnCount = 3
        DataGridView1.Columns(0).Name = "Product ID"
        DataGridView1.Columns(1).Name = "Product Name"
        DataGridView1.Columns(2).Name = "Product_Price"

        Dim row As String() = New String() {"1", "Product 1", "1000"}
        DataGridView1.Rows.Add(row)
        row = New String() {"2", "Product 2", "2000"}
        DataGridView1.Rows.Add(row)
        row = New String() {"3", "Product 3", "3000"}
        DataGridView1.Rows.Add(row)
        row = New String() {"4", "Product 4", "4000"}
        DataGridView1.Rows.Add(row)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
