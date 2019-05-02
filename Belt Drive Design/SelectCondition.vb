Public Class SelectCondition
    Private Sub SelectCondition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Vbelt1DataSet.Driven_Machine_Loading_Condition' table. You can move, or remove it, as needed.
        Me.Driven_Machine_Loading_ConditionTableAdapter.Fill(Me.Vbelt1DataSet.Driven_Machine_Loading_Condition)

    End Sub
End Class