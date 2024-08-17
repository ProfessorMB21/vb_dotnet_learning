Public Class FormSettings
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
        Form3.BringToFront()
    End Sub
End Class