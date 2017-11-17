Public Class Form1

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Convert As Double

        Convert = (CDbl(txtBoxOne.Text) * 1.8) + 32
        lblResult.Text = Convert
    End Sub

    Private Sub lblResult_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub
End Class
