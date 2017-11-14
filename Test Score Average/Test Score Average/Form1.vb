Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        Dim Average As Double

        Average = (CDbl(txtBoxOne.Text) + CDbl(txtBoxTwo.Text) + CDbl(txtBoxThree.Text) + CDbl(txtBoxFour.Text) + CDbl(txtBoxFive.Text)) / 5

        lblResult.Text = Average
    End Sub
End Class
