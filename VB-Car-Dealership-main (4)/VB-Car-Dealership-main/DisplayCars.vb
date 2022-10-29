Public Class DisplayCars
    Private Sub DisplayCars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CarInformationDataSet.Cars' table. You can move, or remove it, as needed.


        Dim unused = Me.CarsTableAdapter.Fill(CarInformationDataSet.Cars)

    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Car_Database_Menu.Show()
        Me.Hide()


    End Sub
End Class