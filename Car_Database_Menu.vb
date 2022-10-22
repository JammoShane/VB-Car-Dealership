Public Class Car_Database_Menu
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Me.Hide()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        DisplayCars.Show()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        InsertCars.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        DeleteCars.Show()
    End Sub
End Class