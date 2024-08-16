Imports Microsoft.VisualBasic.Devices

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
            txtPassword.Focus()
        End If

    End Sub
End Class