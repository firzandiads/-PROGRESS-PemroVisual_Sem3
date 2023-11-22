Public Class Form1

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNamaBrg.TextChanged

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Call Bersih()
    End Sub

    Private Sub BtnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHitung.Click
        Call CekDataKosong()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub Bersih()
        TxtKodeBrg.Text = ""
        TxtNamaBrg.Text = ""
        TxtSatuan.Text = ""
        TxtHarga.Text = ""
        TxtHrgSatuan.Text = ""
        TxtTot.Text = ""
        TxtKodeBrg.Focus()
        TxtTot.Enabled = False
    End Sub

    Private Function Hitung()
        Dim Harga, HrgSatuan, Total As Integer
        Harga = TxtHarga.Text
        HrgSatuan = TxtHrgSatuan.Text
        Total = Harga * HrgSatuan
        TxtTot.Text = Total
        Return Total
    End Function

    Sub CekDataKosong()
        If TxtKodeBrg.Text = "" Then
            MessageBox.Show("Kode Barang harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtKodeBrg.Focus()
        ElseIf TxtNamaBrg.Text = "" Then
            MessageBox.Show("Nama Barang harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNamaBrg.Focus()
        ElseIf TxtSatuan.Text = "" Then
            MessageBox.Show("Satua Barang harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtSatuan.Focus()
        ElseIf TxtHarga.Text = "" Then
            MessageBox.Show("Harga Barang harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtHarga.Focus()
        ElseIf TxtHrgSatuan.Text = "" Then
            MessageBox.Show("Harga Satuan Barang harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtHrgSatuan.Focus()
        Else
            Call Hitung()
        End If
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Dim Tutup As String
        Tutup = MessageBox.Show("Yakin tutup form ini ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tutup = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
End Class
