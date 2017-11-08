Public Class txtOne

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        Dim dblAnswer As Date
        Dim strResult As String

        dblAnswer = CDate(txtUserEntry.Text)

        strResult = dblAnswer.ToString("d")
        lblThree.Text = strResult
    End Sub

    Private Sub lblTwo_Click(sender As Object, e As EventArgs) Handles lblTwo.Click

    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
      Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("n")
        lblThree.Text = strResult
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("f")
        lblThree.Text = strResult
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("e")
        lblThree.Text = strResult
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("c")
        lblThree.Text = strResult
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("p")
        lblThree.Text = strResult
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtUserEntry.Text)

        strResult = Answer.ToString("D")
        lblThree.Text = strResult
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtUserEntry.Text)

        strResult = Answer.ToString("t")
        lblThree.Text = strResult
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtUserEntry.Text)

        strResult = Answer.ToString("T")
        lblThree.Text = strResult
    End Sub

    Private Sub btnTen_Click(sender As Object, e As EventArgs) Handles btnTen.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtUserEntry.Text)

        strResult = Answer.ToString("F")
        lblThree.Text = strResult
    End Sub

    Private Sub txtUserEntry_TextChanged(sender As Object, e As EventArgs) Handles txtUserEntry.TextChanged

    End Sub
End Class
