Public Class Form1

    Private Sub lblDateString_Click(sender As Object, e As EventArgs) Handles lblDateString.Click


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblTwo.Click

    End Sub

    Private Sub lblOne_Click(sender As Object, e As EventArgs) Handles lblOne.Click

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShowDate_Click.Click
        lblDateString.Text = txtWeek.Text & ", " & txtMonth.Text & " " &
            txtDayOfMonth.Text & ", " & txtYear.Text()
    End Sub
End Class
