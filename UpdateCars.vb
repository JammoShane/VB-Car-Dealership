Imports System.Data.SqlClient

Public Class UpdateCars
    Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS ; Database=CarInformation ; Integrated Security=True")
    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim updateQuery As String =
            " UPDATE Cars 
              SET Name = '" & txtCarModelName.Text & "', 
              Brand = '" & txtCarBrandName.Text & "', 
              Engine = '" & txtCarEngineSize.Text & "', 
              Horsepower = '" & txtCarHorsepower.Text & "',
              Price = '" & txtCarPrice.Text & "'
              WHERE CarId = '" & txtCarID.Text & "'
            "

        ExecuteQuery(updateQuery)

        MessageBox.Show("Car Updated")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class

