Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnShowGreeting.Click
        Dim strName As String

        strName = txtUserName.Text

        lblGreeting.Text = strName
    End Sub
End Class
