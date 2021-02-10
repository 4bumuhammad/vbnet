Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Isi Pesan", MsgBoxStyle.Information, "Judul Pesan")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim yesNo As String
        yesNo = MsgBox("Lanjutkan?", MsgBoxStyle.YesNo, "Pesan")
        If yesNo = DialogResult.Yes Then
            MsgBox("Anda menekan tomnol Yes")
        ElseIf yesNo = DialogResult.No Then
            MsgBox("Anda menekan tombol No")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Berikut adalah isi dari pesan warning.",
        "Critical Warning",
        MessageBoxButtons.OKCancel,
        MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.RightAlign,
        True)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result3 As DialogResult =
            MessageBox.Show("Apakah ini aplikasi yang bagus?",
            "The Question",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2)

        ' Test Dialog result
        If result3 = DialogResult.Yes Then MessageBox.Show("Kamu telah menjawab Yes", "Yes")
    End Sub
End Class
