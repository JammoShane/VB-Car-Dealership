Imports System.IO
Imports System.Drawing.Imaging
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AddCarImage

    Dim connection As New SqlConnection("Server=localhost\SQLEXPRESS ; Database=CarInformation ; Integrated Security=True")

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim openfiledialog1 As New OpenFileDialog


        openfiledialog1.Filter = "images|*.jpg;*.png;*.gif;*.bmp"


        If openfiledialog1.ShowDialog = Windows.Forms.DialogResult.OK Then



            PictureBox2.Image = Image.FromFile(openfiledialog1.FileName)


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        Dim update1 As String = "Update cars set pictures=@img where carid=" & TextBox2.Text


        Dim command1 As New SqlCommand(update1, connection)

        'command1.Parameters.Add("@id", SqlDbType.VarChar).Value = TextBox2.Text

        Dim memstr As New MemoryStream


        PictureBox2.Image.Save(memstr, PictureBox2.Image.RawFormat)

        command1.Parameters.Add("@img", SqlDbType.Image).Value = memstr.ToArray


        If connection.State = ConnectionState.Closed Then

            connection.Open()


        End If

        command1.ExecuteNonQuery()

        MessageBox.Show("Image Inserted Successfully")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class