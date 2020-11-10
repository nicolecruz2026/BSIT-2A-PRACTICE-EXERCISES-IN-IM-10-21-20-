Public Class Form4

    Private Sub lstTerms_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTerms.SelectedIndexChanged
        Dim Means As String
        Dim i As Byte
        Select lstTerms.SelectedIndex
            Case 0
                Means = " - A small piece of message that is transported over the Internet."

            Case 1
                Means = " - A special-purpose computer that directs packets of data along a network."

            Case 2
                Means = " - A security mechanism that organizations use to protect their intranet from the Internet."

            Case 3
                Means = " - A program that allows you to log into a remote computer."

            Case 4
                Means = " - A set of precisely specified rules for carrying out a procedure."

                rchMeaning.Text = Means
        End Select



        Select Case lstTerms.SelectedIndex
            Case 0
                Means = " - A small piece of message that is transported over the Internet."

            Case 1
                Means = " - A special-purpose computer that directs packets of data along a network."

            Case 2
                Means = " - A security mechanism that organizations use to protect their intranet from the Internet."

            Case 3
                Means = " - A program that allows you to log into a remote computer."

            Case 4
                Means = " - A set of precisely specified rules for carrying out a procedure."
                For i = 0 To 4
                    If lstTerms.SelectedIndex = i Then
                        rchMeaning.Text = lstTerms.Items.Item(i) + Means

                    End If
                Next i
        End Select

    End Sub
End Class