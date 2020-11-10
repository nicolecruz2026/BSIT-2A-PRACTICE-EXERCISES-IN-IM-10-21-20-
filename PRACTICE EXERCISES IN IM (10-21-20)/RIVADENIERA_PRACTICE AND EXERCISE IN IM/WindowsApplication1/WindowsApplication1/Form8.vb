Public Class Form8

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        Dim Names() As String = {"Richard", "Noli", "Lester", "Val"}
        Dim Scores() As Single = {100, 80, 70, 95}
        Dim i As Integer
        Dim Total As Single = 0
        For i = 0 To Names.Length - 1 'or => For i = 0 to 3
            lstNames.Items.Add(Names(i))
            lstScores.Items.Add(Scores(i))
            Total += (Scores(i))


        Next
        lblAve.Text = Total / Scores.Length
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstNames.Items.Clear()
        lstScores.Items.Clear()
        lblAve.Text = ""
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class