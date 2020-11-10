Public Class Form7

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        picBaby.Visible = True
    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click
        picBaby.Visible = False
    End Sub

    Private Sub btnEnable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnable.Click
        btnShow.Enabled = True
        btnHide.Enabled = True
    End Sub

    Private Sub btnDisable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisable.Click
        btnShow.Enabled = False
        btnHide.Enabled = False
    End Sub
End Class