Public Class Form1

    Private Sub MHSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MHSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MHSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Prak_11_AccessDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Prak_11_AccessDataSet.MHS' table. You can move, or remove it, as needed.
        Me.MHSTableAdapter.Fill(Me.Prak_11_AccessDataSet.MHS)

    End Sub
End Class
