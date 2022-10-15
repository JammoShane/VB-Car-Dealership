Public Class Car_Database_Menu
    Private Sub Car_Database_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCars_Click(sender As Object, e As EventArgs) Handles btnCars.Click
        DisplayCars.Show()
        Me.Hide()
    End Sub
End Class