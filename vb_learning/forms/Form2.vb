Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim sPassword As String

        sPassword = "password"

        If txtPassword.Text = sPassword Then
            Threading.Thread.Sleep(20)
            Close()
            Form3.Show()
        Else
            MsgBox("Please try again!")
            txtPassword.Clear()
        End If

    End Sub

    Private Sub FormLogin_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtPassword.Focus()
    End Sub

    Private Sub FormLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If
        lbState.Text = "Typing...."
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbState.Text = ""
    End Sub

    Private Sub FormLogin_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp, txtPassword.KeyUp
        lbState.Text = ""
    End Sub
End Class