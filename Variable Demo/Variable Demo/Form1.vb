Public Class lblFullName

    Private Sub lblFullName_Click(sender As Object, e As EventArgs) Handles strFullName.Click
        Me.Close()
    End Sub

    Private Sub btnShowName_Click(sender As Object, e As EventArgs) Handles btnShowName.Click
        Dim strFullName As String

        strFullName = txtFirstName.Text & " " & txtLastName.Text

        lblFullName.Text = strFullName
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        strFullName.Text = String.Empty
    End Sub
End Class
