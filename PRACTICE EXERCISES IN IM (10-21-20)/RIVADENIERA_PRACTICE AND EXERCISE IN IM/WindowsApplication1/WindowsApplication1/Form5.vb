

Public Class Form5

    Private Sub lst1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst1.SelectedIndexChanged
        Dim i As Byte
        For i = 0 To lst1.Items.Count
            If lst1.SelectedIndex = i Then
                lst2.Items.Add(lst1.SelectedItem)
            End If
        Next
    End Sub
    Private Sub bntClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
For i = 0 To lst2.Items.Count
If lst2.SelectedIndex = i Then
lst2.Items.RemoveAt(i)
End If
Next i
    End Sub

    Private Sub bntClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntClearAll.Click
        lst1.ClearSelected()
        lst2.Items.Clear()
    End Sub
End Class


