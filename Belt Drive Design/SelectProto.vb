Public Class SelectProto
    Private Sub SelectProto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Vbelt1DataSet.Prototype_Selection' table. You can move, or remove it, as needed.
        Me.Prototype_SelectionTableAdapter.Fill(Me.Vbelt1DataSet.Prototype_Selection)

    End Sub
End Class