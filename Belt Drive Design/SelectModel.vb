Public Class SelectModel
    Private Sub SelectModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Y_MotorDataSet1.SS750' table. You can move, or remove it, as needed.
        Me.SS750TableAdapter.Fill(Me.Y_MotorDataSet1.SS750)


    End Sub
    Public Shaftdia As String
    Public vsd As Double

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Shaftdia = Ymg.CurrentCell.Value.ToString

        Dim sdt As Int32
        Try
            sdt = CInt(Shaftdia)
        Catch ex As Exception
        End Try
        Mainf.Shaftdia = sdt
        Mainf.Label11.Text = Mainf.Shaftdia

        vsd = Ymg.Item(6, Ymg.CurrentCell.RowIndex).Value

        Mainf.Label11.Text = vsd
        Mainf.vsd = vsd
    End Sub
End Class