Public Class Form1
    Dim attempts As Integer = 0
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If (username <> "Harish Ramachandra" Or password <> 206007) Then
            MessageBox.Show("Wrong username or password, try again")
            txtPassword.Text = ""
            txtUsername.Text = ""
            txtUsername.Focus()
            attempts += 1

            If (attempts > 3) Then
                MessageBox.Show("Attempt Failure")
                Me.Close()
            End If



        Else
            Me.Hide()
            Car_Database_Menu.Show()


        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtUsername.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim question As DialogResult
        question = MsgBox("Are you sure you want to exit Log In page ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If question = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        AddCarImage.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        DisplayCar.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) 
        InsertCars.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) 
        DisplayCar.Show()
    End Sub
End Class
