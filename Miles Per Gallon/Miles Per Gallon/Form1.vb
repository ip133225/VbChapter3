Public Class Form1

    Private Sub lblResult_Click(sender As Object, e As EventArgs) Handles lblResult.Click
        Dim dblMPG As Double

        dblMPG = CDbl(txtMiles.Text) / CDbl(txtGallons.Text)
        lblResult.Text = dblMPG
    End Sub

    Private Sub txtBoxTwo_TextChanged(sender As Object, e As EventArgs) Handles txtMiles.TextChanged

    End Sub
End Class
