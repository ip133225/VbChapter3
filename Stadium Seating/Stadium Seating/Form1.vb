Public Class Form1

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblC.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        Dim total As Double

        lblA.Text = CDbl(txtBoxA.Text) * 15

        lblB.Text = CDbl(txtBoxB.Text) * 12

        lblC.Text = CDbl(txtBoxC.Text) * 9

        total = CDbl(txtBoxA.Text) * 15 +
            CDbl(txtBoxB.Text) * 12 + CDbl(txtBoxC.Text) * 9

        lblTotal.Text = total.ToString("c")

    End Sub
End Class
