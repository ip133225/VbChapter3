Public Class Form1

 

    Private Sub btnChanges_Click(sender As Object, e As EventArgs) Handles btnChanges.Click
        ' Declare variables for the calculations.
        Dim decRoomCharges As Decimal             ' Room charges total
        Dim decAddCharges As Decimal         ' Additional charges
        Dim decSubTotal As Decimal           ' Subtotal
        Dim decTaxCharges As Decimal         ' Tax
        Dim decTotalCharges As Decimal       ' Total of all charges
        Const decTax_Rate As Decimal = 0.08D ' Tax Rate

       
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the room info fields.
        txtNights.Clear()
        txtNightlyCharge.Clear()

        ' Clear the additional charges fields.
        decRoomCharges.Clear()
        txtBoxFour.Clear()
        txtBoxFive.Clear()

        ' Clear the decTotal fields.
        lblRoomCharges.Text = String.Empty
        lblAddCharges.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty

        ' Get today's date from the operating system and display it.
        lblNine.Text = Now.ToString("D")

        ' Get the current time from the operating system and display it.
        lblTen.Text = Now.ToString("T")

        'Reset the focus to the first field.
        txtNights.Focus()
    End Sub

    Private Sub txtBoxThree_TextChanged(sender As Object, e As EventArgs) Handles decRoomCharges.TextChanged
        'lblStatus.Text = String.Empty
        Try
            ' Calculate and display the room charges. 
            decRoomCharges = CDec(txtNights.Text) *
                CDec(txtNightlyCharge.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")

    End Sub

    Private Sub lblSeventeen_Click(sender As Object, e As EventArgs) Handles lblAddCharges.Click
        ' Calculate and display the additional charges.
        decAddCharges = CDec(txtRoomService.Text) +
            CDec(txtTelephone.Text) +
            CDec(txtMisc.Text)
        lblAddCharges.Text = decAddCharges.ToString("c")


    Private Sub lblEighteen_Click(sender As Object, e As EventArgs) Handles lblSubtotal.Click
        ' Calculate and display the subtotal.
        decSubtotal = decRoomCharges + decAddCharges
        lblSubtotal.Text = decSubtotal.ToString("c")


    Private Sub lblNineteen_Click(sender As Object, e As EventArgs) Handles lblTax.Click
        ' Calculate and display the subtotal.
        decTax = decSubtotal * decTAX_RATE
        lblTax.Text = decTax.ToString("c")
    End Sub

    Private Sub lblFouteen_Click(sender As Object, e As EventArgs) Handles decTax.Click

    End Sub

    Private Sub lblTwenty_Click(sender As Object, e As EventArgs) Handles lblTotal.Click
        ' Calculate and display the subtotal.
        decTotal = decSubtotal + decTax
        lblTotal.Text = decTotal.ToString("c")
        Catch
            ' Error message
            MessageBox.Show("All input must be valid numeric values.")
        End Try
    End Sub
End Class
