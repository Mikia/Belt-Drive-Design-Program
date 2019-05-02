Public Class SelectRP
    Private Sub SelectRP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Vbelt1DataSet2.Rating_Power' table. You can move, or remove it, as needed.
        Me.Rating_PowerTableAdapter.Fill(Me.Vbelt1DataSet2.Rating_Power)
        pd = Mainf.pd
        kb = Mainf.kb
        n1 = Mainf.sprpm
        ki = Mainf.ki
        kl = Mainf.kl
        TextBox3.Text = Mainf.alf
    End Sub
    Public p0, kb, ki, p0p, kl, kalf, z, alf, n1, pd As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        p0 = TextBox1.Text

        kalf = TextBox2.Text
        Mainf.kalf = kalf
        p0p = kb * n1 * (1 - (1 / ki))
        z = pd / ((p0 + p0p) * kalf * kl)
        If z < 10 Then
        Else
            Dim message As String = "Please use tight-up Vbelt or reselect the belt type"
            Dim caption As String = "Alert"
            Dim buttons As MessageBoxButtons = MessageBoxButtons.OK
            MessageBox.Show(message, caption, buttons)
        End If
        Mainf.TextBox12.Text = z
        Mainf.p0 = p0
        Mainf.p0p = p0p
        Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TextBox1.Text = "From Chart Below" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
        TextBox1.Text = DataGridView1.CurrentCell.Value.ToString
    End Sub
End Class