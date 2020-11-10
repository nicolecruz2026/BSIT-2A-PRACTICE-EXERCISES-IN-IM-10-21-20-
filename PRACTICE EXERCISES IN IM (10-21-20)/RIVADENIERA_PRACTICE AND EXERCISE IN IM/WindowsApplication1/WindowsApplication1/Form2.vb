Public Class Form2

    Private Sub btnSpin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpin.Click
        Dim RndGen As New Random
        Dim N1, N2, N3 As Integer
        N1 = RndGen.Next(1, 10)
        N2 = RndGen.Next(1, 10)
        N3 = RndGen.Next(1, 10)
        lblNum1.Text = N1
        lblNum2.Text = N2
        lblNum3.Text = N3
        If N1 = 7 Or N2 = 7 OrElse N3 = 7 Then
            MessageBox.Show("Congrats! You win...", "Lucky Seven")
        Else : MessageBox.Show("Sorry!")
        End If


    End Sub
End Class