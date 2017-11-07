Public Class Form1

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtNumber2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        'This event handler performs addition
        'Declare a variable to hold the result
        Dim dblResult As Double

        lblOperation.Text = " + "

        dblResult = CDbl(txtNumber2.Text) + CDbl(txtNumber1.Text)

        lblResult.Text = CStr(dblResult)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub
End Class
