Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim angka As Integer
        ListBox1.Items.Clear()
        angka = 1
        While angka <= Val(TxtBatas.Text)
            ListBox1.Items.Add(angka)
            angka = angka + 1
        End While
    End Sub
End Class
