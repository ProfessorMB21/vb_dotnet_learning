Imports vb_learning.Objects
Public Class Form3
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        FormSettings.Show()
    End Sub

    Private Sub btnSaveState_Click(sender As Object, e As EventArgs) Handles btnSaveState.Click

        Dim visa As Visa
        visa = New Visa()

    End Sub
End Class