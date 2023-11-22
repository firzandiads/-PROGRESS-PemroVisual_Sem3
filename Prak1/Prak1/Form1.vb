Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RchTeks.TextChanged

    End Sub

    Private Sub BaruToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaruToolStripMenuItem.Click
        RchTeks.Text = ""
    End Sub

    Private Sub BukaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BukaToolStripMenuItem.Click
        Dim kotak_dialog As OpenFileDialog = New OpenFileDialog
        kotak_dialog.Filter = "File Text (*.txt) | *.txt"
        kotak_dialog.ShowDialog()
        Dim fileText As String = My.Computer.FileSystem.ReadAllText(kotak_dialog.FileName)
        RchTeks.Text = fileText
    End Sub

    Private Sub SimpanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanToolStripMenuItem.Click
        Dim kotak_dialog As SaveFileDialog = New SaveFileDialog
        kotak_dialog.Filter = "File Text (*.txt) | *.txt"
        kotak_dialog.ShowDialog()
        My.Computer.FileSystem.WriteAllText("" & kotak_dialog.FileName & "", RchTeks.Text, False)
    End Sub
    

    Private Sub BoldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoldToolStripMenuItem.Click
        RchTeks.SelectionFont = New Font(RchTeks.SelectionFont, FontStyle.Bold)
    End Sub

    Private Sub RegularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReguToolStripMenuItem.Click
        RchTeks.SelectionFont = New Font(RchTeks.SelectionFont, FontStyle.Regular)
    End Sub
End Class
