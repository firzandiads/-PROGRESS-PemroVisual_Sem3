Public Class Form1

    Private Sub Proses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Proses.Click
        For Each ctrl In Controls
            ctrl.Text = "Tombol"
        Next
    End Sub
End Class
