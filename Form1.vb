Public Class Form1
    Dim attempts As Integer = 0
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim username As String = txtUserName.Text
        Dim password As String = txtPassword.Text

        If (username <> "Harish Ramachandra" Or password <> 206007) Then
            MessageBox.Show("Wrong username or password, try again")
            txtPassword.Text = ""
            txtUserName.Text = ""
            txtUserName.Focus()
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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim question As DialogResult
        question = MsgBox("Are you sure you want to exit Log In page ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If question = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUserName.Text = ""
        txtPassword.Text = ""
        txtUserName.Focus()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
