Imports System.IO
Imports System.Drawing.Imaging
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class DisplayCar

    Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS ; Database=CarInformation ; Integrated Security=True")

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim command As New SqlCommand("select name, brand, engine, horsepower, pictures from cars where carid = @id", connection)
        command.Parameters.Add("@id", SqlDbType.VarChar).Value = TextBox2.Text

        Dim table As New DataTable()

        Dim adapter As New SqlDataAdapter(command)

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then

            MessageBox.Show("Car ID does not exist in database. Please enter a valid car ID")
        Else

            Dim img() As Byte

            Label3.Text = "Brand"
            Label4.Text = "Engine"
            Label5.Text = "Horsepower"

            Label1.Text = table.Rows(0)(0).ToString()
            lblBrand.Text = table.Rows(0)(1).ToString()
            lblEngine.Text = table.Rows(0)(2).ToString()
            lblHp.Text = table.Rows(0)(3).ToString()
            img = table.Rows(0)(4)

            Dim ms As New MemoryStream(img)

            PictureBox2.Image = Image.FromStream(ms)

        End If
        connection.Close()
    End Sub

    Private Sub lblEngine_Click(sender As Object, e As EventArgs) Handles lblEngine.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        TextBox2.Text = ""
        Label1.Text = ""
        lblBrand.Text = ""
        lblEngine.Text = ""
        lblHp.Text = ""
        PictureBox2.Image = Nothing
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""

    End Sub
End Class