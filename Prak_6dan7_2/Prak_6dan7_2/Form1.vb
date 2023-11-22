Public Class Form1

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        If TxtPassword.Text = "" And TxtUserName.Text = "" Then
            MessageBox.Show("User name dan Password harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Question)
            TxtUserName.Focus()
        ElseIf TxtPassword.Text = "" Then
            MessageBox.Show("Password harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Question)
            TxtPassword.Focus()
        ElseIf TxtUserName.Text = "" Then
            MessageBox.Show("User name harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Question)
            TxtUserName.Focus()
        ElseIf TxtUserName.Text = "STIKOM" And TxtPassword.Text = "1234" Then
            MessageBox.Show("Password dan User Name Benar", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Question)

        Else
            MessageBox.Show("Password dan User Name Anda Salah, ulangi lagi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Question)
            TxtUserName.Text = ""
            TxtUserName.Text = ""
            TxtUserName.Focus()
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        End
    End Sub
End Class
