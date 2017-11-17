Public Class Form1

    Private Sub lblCelsius_Click(sender As Object, e As EventArgs) Handles lblActualValue.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Convert As Double

        Convert = (CDbl(txtBoxOne.Text) * 0.64) + 100
        lblResult.Text = Convert
    End Sub
End Class
