Public Class Selectld
    Private Sub Selectld_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Vbelt1DataSet1.LDKL' table. You can move, or remove it, as needed.
        Me.LDKLTableAdapter.Fill(Me.Vbelt1DataSet1.LDKL)

    End Sub
    Public indexbt As Int16 = Mainf.indexbt
    Public kl As Double
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Mainf.TextBox9.Text = CDbl(DataGridView1.CurrentCell.Value.ToString)
        If DataGridView1.CurrentCell.RowIndex <> vbNull Then
            Try
                kl = DataGridView1.Item(indexbt, DataGridView1.CurrentCell.RowIndex).Value
            Catch ex As Exception

            End Try

        End If
        Mainf.kl = kl
        'Mainf.testtb.Text = kl

    End Sub
End Class