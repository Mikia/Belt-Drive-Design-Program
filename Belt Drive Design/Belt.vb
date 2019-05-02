Imports System.Math
Public Class Belt
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ComboBox1.Text = "Z" Then
            Label4.Text = "50"
            Mainf.indexbt = 3
            Button1.Enabled = True
        ElseIf ComboBox1.Text = "A" Then
            Label4.Text = "75"
            Mainf.indexbt = 4
            Button1.Enabled = True
        ElseIf ComboBox1.Text = "B" Then
            Label4.Text = "125"
            Mainf.indexbt = 5
            Button1.Enabled = True
        ElseIf ComboBox1.Text = "C" Then
            Mainf.indexbt = 6
            Label4.Text = "200"
            Button1.Enabled = True
        ElseIf ComboBox1.Text = "D" Then
            Mainf.indexbt = 7
            Label4.Text = "355"
            Button1.Enabled = True
        ElseIf ComboBox1.Text = "E" Then
            Mainf.indexbt = 8
            Label4.Text = "500"
            Button1.Enabled = True
        End If

    End Sub
    Public dd1, dd2 As Double


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dd2t As Double
        dd2t = TextBox2.Text
        If dd2t - dd2 < 0.05 Then
            Mainf.TextBox6.Text = dd1
            Mainf.TextBox7.Text = TextBox2.Text
            Mainf.Belttype = ComboBox1.Text
            Close()
        Else
            Dim Message As String = "Unacceptable Deviation Detected! Please Reselect dd2."
            Dim Caption As String = "Error Detected"
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            MessageBox.Show(Message, Caption, Buttons)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "≥ddmin" Then
            dd1 = CDbl(Label4.Text)
        Else
            dd1 = TextBox1.Text
        End If
        Dim Message As String = "You did not enter a number larger than ddmin based on the Guide Form."
        Dim Caption As String = "Error Detected in Input"
        Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK

        If ComboBox1.Text = "Z" And dd1 < 50 Then
            MessageBox.Show(Message, Caption, Buttons)
        ElseIf ComboBox1.Text = "A" And dd1 < 75 Then
            MessageBox.Show(Message, Caption, Buttons)
        ElseIf ComboBox1.Text = "B" And dd1 < 125 Then
            MessageBox.Show(Message, Caption, Buttons)
        ElseIf ComboBox1.Text = "C" And dd1 < 200 Then
            MessageBox.Show(Message, Caption, Buttons)
        ElseIf ComboBox1.Text = "D" And dd1 < 355 Then
            MessageBox.Show(Message, Caption, Buttons)
        ElseIf ComboBox1.Text = "E" And dd1 < 500 Then
            MessageBox.Show(Message, Caption, Buttons)
        Else
            If Mainf.CheckBox2.Checked Then
                dd2 = Mainf.tr * dd1 * (1 - Mainf.er)
                TextBox2.Text = dd2
            Else
                dd2 = Mainf.tr * dd1
            TextBox2.Text = dd2
        End If
        End If



    End Sub
End Class