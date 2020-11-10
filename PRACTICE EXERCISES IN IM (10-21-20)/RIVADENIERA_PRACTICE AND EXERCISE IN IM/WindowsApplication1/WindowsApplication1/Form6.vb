Public Class Form6

    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn.Click
        txtIn.Text = Today
    End Sub

    Private Sub btnOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOut.Click
        txtOut.Text = Today
    End Sub

    Private Sub btnCompute1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute1.Click
        lblTotDays.Text = DateDiff("d", txtIn.Text, txtOut.Text)
    End Sub

    Private Sub btnCompute2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute2.Click
        lblTotDays.Text = DateDiff("d", dtpIn.Text, dtpOut.Text)
    End Sub
End Class