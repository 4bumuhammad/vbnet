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
End Class
