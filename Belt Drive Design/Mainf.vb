Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.Sql
Imports System.Math


Public Class Mainf
    Public Shaftdia, indexbt As Int32
    Public Belttype As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Private Sub MS_Click(sender As Object, e As EventArgs) Handles MS.Click
        SelectModel.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SelectCondition.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SelectProto.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If textbox8.text = "" Then
        Else
            Dim aa, ldd As Double
            aa = TextBox8.Text
            ldd = 2 * aa + pi / 2 * (dd1 + dd2) + (dd2 - dd1) ^ 2 / (4 * aa)
            Label23.Text = Round(ldd, 3)
            If TextBox9.Text = "" Then
            Else
                ld = TextBox9.Text
                a = aa + (ld - ldd) / 2
                TextBox10.Text = Round(a, 3)
                alf = 180 - (dd2 - dd1) / a * 57.3
                TextBox11.Text = Round(alf, 3)

            End If

        End If

    End Sub
    Public alf, ka, pd, sprpm, tr, er, ld, a, kl, kalf, z, f0, fq, vsd As Double

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        outtb.Text = "Transmitted Power Pd(kW)= " + CStr(pd) + vbCrLf + "Prime Motor & Driven Gear rpm= " + CStr(sprpm) + vbCrLf + "Sliding Ratio= " + CStr(er) + vbCrLf + "External Loads: " + ComboBox1.Text + vbCrLf + "Application Factor= " + CStr(ka) + vbCrLf + "Belt Type= " + Belttype + vbCrLf + "Small Pulley Datum Dia dd1(mm)= " + CStr(dd1) + vbCrLf + "Big Pulley Datum Dia dd2(mm)= " + CStr(dd2) + vbCrLf + "Belt Velocity(m/s)= " + CStr(v) + vbCrLf + "Bend Influence Factor Kb= " + CStr(kb) + vbCrLf + "Datum Lenth Ld(mm)= " + CStr(ld) + vbCrLf + "Centre Distance(mm)= " + CStr(a) + vbCrLf + "Pulley-s Angle of Contact(°)= " + CStr(alf) + vbCrLf + "Rating Power Each Belt P0(kW)= " + CStr(p0) + vbCrLf + "Wheni≠1,ΔP0(kW)= " + CStr(p0p) + vbCrLf + "AOC Adjustment Ratio Kα= " + CStr(kalf) + vbCrLf + "Belt Lenth Adjustment Ratio Kl= " + CStr(kl) + vbCrLf + "Amount of Belt= " + CStr(z) + vbCrLf + "Vbelt Tension(N)= " + CStr(f0) + vbCrLf + "Axial Load Fq(N)= " + CStr(fq) + vbCrLf + sct1 + vbCrLf + sct2
    End Sub
    Public sct1, sct2 As String

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        z = TextBox12.Text
        f0 = 500 * (pd / (v * z)) * ((2.5 - kalf) / kalf) + m * v * v
        fq = 2 * z * f0 * Abs(Sin(alf / 2))
        If dd1 <= vsd Then
            sct1 = "Small Pulley Recommands: Solid"
        ElseIf dd1 <= 300 Then
            sct1 = "Small Pulley Recommands: Thin Web"
        ElseIf dd1 <= 500 Then
            sct1 = "Small Pulley Recommands: Perforated"
        Else
            sct1 = "Small Pulley Recommands: Spokes"
        End If
        If dd2 <= vsd Then
            sct2 = "Big Pulley Recommands: Solid"
        ElseIf dd2 <= 300 Then
            sct2 = "Big Pulley Recommands: Thin Web"
        ElseIf dd1 <= 500 Then
            sct2 = "Big Pulley Recommands: Perforated"
        Else
            sct2 = "Big Pulley Recommands: Spokes"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SelectRP.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Selectld.Show()
    End Sub

    Public v, pi, dd1, dd2, kb, ki, m, p0, p0p As Double
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        pi = 3.14159265358
        dd1 = TextBox6.Text
        dd2 = TextBox7.Text
        Dim vmax As Double
        Dim Message As String = "Belt Overspeed! Please Reselect dd1"
        Dim Caption As String = "Error Detected"
        Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
        v = pi * dd1 * sprpm / 60000
        If Belttype = "Z" Then
            vmax = 25
            kb = 0.0002925
            m = 0.06
        ElseIf Belttype = "A" Then
            vmax = 25
            kb = 0.0007725
            m = 0.105
        ElseIf Belttype = "B" Then
            vmax = 25
            kb = 0.0019875
            m = 0.17
        ElseIf Belttype = "C" Then
            vmax = 25
            kb = 0.005625
            m = 0.3
        ElseIf Belttype = "D" Then
            vmax = 30
            kb = 0.01995
            m = 0.63
        ElseIf Belttype = "E" Then
            vmax = 30
            kb = 0.03735
            m = 0.97
        End If
        If v > vmax Then
            MessageBox.Show(Message, Caption, Buttons)

        Else
            Button6.Enabled = True
            TextBox8.Enabled = True
            Label18.Text = 0.7 * (dd1 + dd2)
            Label19.Text = 2 * (dd1 + dd2)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pd = TextBox2.Text
        sprpm = TextBox3.Text
        tr = TextBox4.Text
        If TextBox5.Text = "(0~0.02)" Then
            er = 0
        Else
            er = TextBox5.Text
        End If


        If tr <= 1.01 Then
            ki = 1
        ElseIf tr <= 1.04 Then
            ki = 1.0136
        ElseIf tr <= 1.08 Then
            ki = 1.0276
        ElseIf tr <= 1.12 Then
            ki = 1.0419
        ElseIf tr <= 1.18 Then
            ki = 1.0567
        ElseIf tr <= 1.24 Then
            ki = 1.0719
        ElseIf tr <= 1.34 Then
            ki = 1.0875
        ElseIf tr <= 1.51 Then
            ki = 1.1036
        ElseIf tr <= 1.99 Then
            ki = 1.1202
        ElseIf tr >= 2.0 Then
            ki = 1.1373
        End If
        'testtb.Text = CStr(ki) + CStr(tr)
        Belt.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim kap, pdp As Double
        If ComboBox1.Text = "Stable" Then
            If ComboBox2.Text = "Prototype I" Then
                If ComboBox3.Text = "<10h" Then
                    kap = 1
                ElseIf ComboBox3.Text = "10~16h" Then
                    kap = 1.1
                ElseIf ComboBox3.Text = ">16h" Then
                    kap = 1.2
                End If
            ElseIf ComboBox2.Text = "Prototype II" Then
                If ComboBox3.Text = "<10h" Then
                    kap = 1.1
                ElseIf ComboBox3.Text = "10~16h" Then
                    kap = 1.2
                ElseIf ComboBox3.Text = ">16h" Then
                    kap = 1.3
                End If
            End If
        ElseIf ComboBox1.Text = "Minor" Then
            If ComboBox2.Text = "Prototype I" Then
                If ComboBox3.Text = "<10h" Then
                    kap = 1.1
                ElseIf ComboBox3.Text = "10~16h" Then
                    kap = 1.2
                ElseIf ComboBox3.Text = ">16h" Then
                    kap = 1.3
                End If
            ElseIf ComboBox2.Text = "Prototype II" Then
                If ComboBox3.Text = "<10h" Then
                    kap = 1.2
                ElseIf ComboBox3.Text = "10~16h" Then
                    kap = 1.3
                ElseIf ComboBox3.Text = ">16h" Then
                    kap = 1.4
                End If
            End If

        ElseIf ComboBox1.Text = "Large" Then
            If ComboBox2.Text = "Prototype I" Then
                If ComboBox3.Text = "<10h" Then
                    kap = 1.2
                ElseIf ComboBox3.Text = "10~16h" Then
                    kap = 1.3
                ElseIf ComboBox3.Text = ">16h" Then
                    kap = 1.4
                End If
            ElseIf ComboBox2.Text = "Prototype II" Then
                If ComboBox3.Text = "<10h" Then
                    kap = 1.4
                ElseIf ComboBox3.Text = "10~16h" Then
                    kap = 1.5
                ElseIf ComboBox3.Text = ">16h" Then
                    kap = 1.6
                End If
            End If

        ElseIf ComboBox1.Text = "Exquisite" Then
            If ComboBox2.Text = "Prototype I" Then
                If ComboBox3.Text = "<10h" Then
                    kap = 1.3
                ElseIf ComboBox3.Text = "10~16h" Then
                    kap = 1.4
                ElseIf ComboBox3.Text = ">16h" Then
                    kap = 1.5
                End If
            ElseIf ComboBox2.Text = "Prototype II" Then
                If ComboBox3.Text = "<10h" Then
                    kap = 1.5
                ElseIf ComboBox3.Text = "10~16h" Then
                    kap = 1.6
                ElseIf ComboBox3.Text = ">16h" Then
                    kap = 1.8
                End If
            End If
        End If

        If CheckBox1.Checked Then
            ka = kap * 1.1
        Else ka = kap
        End If
        pdp = ka * CDbl(TextBox1.Text)
        Label10.Text = CStr(pdp)
        TextBox2.Text = pdp
    End Sub
End Class
