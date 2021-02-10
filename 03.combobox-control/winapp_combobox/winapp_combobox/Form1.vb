
'Referensi belajar 
'https://www.tutorialspoint.com/vb.net/vb.net_combobox.htm
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ComboBox1.Items.Clear()
        Me.ComboBox1.Items.Add("Safety")
        Me.ComboBox1.Items.Add("Security")
        Me.ComboBox1.Items.Add("Governance")
        Me.ComboBox1.Items.Add("Good Music")
        Me.ComboBox1.Items.Add("Good Movies")
        Me.ComboBox1.Items.Add("Good Books")
        Me.ComboBox1.Items.Add("Education")
        Me.ComboBox1.Items.Add("Roads")
        Me.ComboBox1.Items.Add("Health")
        Me.ComboBox1.Items.Add("Food for all")
        Me.ComboBox1.Items.Add("Shelter for all")
        Me.ComboBox1.Items.Add("Industrialisation")
        Me.ComboBox1.Items.Add("Peace")
        Me.ComboBox1.Items.Add("Liberty")
        Me.ComboBox1.Items.Add("Freedom of Speech")
        Me.ComboBox1.Text = "Select from ..."
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ComboBox1.Sorted = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.Label1.Text = Me.ComboBox1.SelectedItem.ToString()
    End Sub
End Class
