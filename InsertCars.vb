Imports System.Data.SqlClient


Public Class InsertCars
    Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS ; Database=CarInformation ; Integrated Security=True")
    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCarID.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim insertQuery As String = "INSERT INTO cars (CarId, Name, Brand, Engine, Horsepower, Price) values ('" & txtCarID.Text & "', '" & txtCarModelName.Text & "',
        '" & txtCarBrandName.Text & "', '" & txtCarEngineSize.Text & "', '" & txtCarHorsepower.Text & "','" & txtCarPrice.Text & "' )"

        ExecuteQuery(insertQuery)

        MessageBox.Show("Car Inserted")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class

'carID, carModelName, carBrandName, carAge, carEngineSize, carHorsepower