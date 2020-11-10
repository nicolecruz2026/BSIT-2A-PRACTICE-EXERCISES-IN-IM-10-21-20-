


Public Class Form3

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim Price, SubTot, TotAmt, Disc, Quan As Single

        If lstParts.SelectedIndex = 0 Then
            Price = 2000
        ElseIf lstParts.SelectedIndex = 1 Then
            Price = 250
        ElseIf lstParts.SelectedIndex = 2 Then
            Price = 100
        ElseIf lstParts.SelectedIndex = 3 Then
            Price = 1000
        ElseIf lstParts.SelectedIndex = 4 Then
            Price = 200
        Else
            MessageBox.Show("No selected item...", "Computer Store")
            Exit Sub
        End If
        Quan = nudQuan.Text
        If Quan = 0 Then
            MessageBox.Show("Pls. enter quantity", "Computer Store")
            Exit Sub
        End If
        lblUPrice.Text = FormatNumber(Price, 2)
        SubTot = Price * Quan
        lblSubTot.Text = FormatNumber(SubTot, 2)
        If cboDisc.SelectedIndex = 1 Then
            Disc = SubTot * 0.05
        ElseIf cboDisc.SelectedIndex = 2 Then
            Disc = SubTot * 0.1
        ElseIf cboDisc.SelectedIndex = 3 Then
            Disc = SubTot * 0.15
        Else
            Disc = 0
        End If
        lblDisc.Text = FormatNumber(Disc, 2)
        TotAmt = SubTot - Disc
        lblTotAmt.Text = FormatNumber(TotAmt, 2)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Ans As Integer
        Ans = MessageBox.Show("Do want to close the program", "Close",
    MessageBoxButtons.OKCancel, MessageBoxIcon.Question)


        If Ans = DialogResult.OK Then
            Close()
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstParts.ClearSelected()
        cboDisc.Text = ""
        lblUPrice.Text = ""
        nudQuan.Text = 0
        lblDisc.Text = ""
        lblSubTot.Text = ""
        lblTotAmt.Text = ""
    End Sub
End Class
