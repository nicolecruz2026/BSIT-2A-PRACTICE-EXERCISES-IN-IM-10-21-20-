Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        Dim GenRnd As New Random
        txtNumber.Text = GenRnd.Next(1, 10)
        Dim GuessNum, GenRndNum As Integer
        Try
            GuessNum = CInt(txtNumber.Text)
            GenRndNum = GenRnd.Next(1, 10)
            If GuessNum = GenRndNum Then
                MessageBox.Show("That's correct!", "Guessing Game", _
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("That's Wrong" + vbNewLine + _
                "The correct Answer is: " + CStr(GenRndNum), _
                "Guessing Game", MessageBoxButtons.OK, _
                MessageBoxIcon.Information)
            End If
        Catch MyError As InvalidCastException
            MessageBox.Show("Pls. enter a number...", "Guessing Game")
        End Try
        txtNumber.Text = ""
        txtNumber.Focus()
    End Sub
End Class
