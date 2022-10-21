Public Class Car_Database_Menu
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Me.Hide()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        DisplayCars.Show()
    End Sub
End Class