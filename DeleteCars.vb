Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports System.Data.SqlClient



Public Class DeleteCars
    Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS ; Database=CarInformation ; Integrated Security=True")
    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles txtDelete.Click



        Dim deleteQuery As String = " DELETE FROM Cars Where CarId ='" & txtDeleteData.Text & "'"

        ExecuteQuery(deleteQuery)
        MessageBox.Show("Car Deleted")

    End Sub


End Class