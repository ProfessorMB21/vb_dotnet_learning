Imports Microsoft.VisualBasic.Devices

Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim sPassword As String

        sPassword = "password"

        If txtPassword.Text = sPassword Then
            MsgBox("You're in!")
            Threading.Thread.Sleep(20)
            Close()
            Form1.Focus()
        Else
            MsgBox("Please try again!")
            txtPassword.Focus()
        End If

    End Sub
End Class