Imports System.Numerics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports FileIOHandler.DataHandler
Imports FileIOHandler.FileIO
Imports ObjectHandler
Public Class Form3
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        FormSettings.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim sNations(11) As String

        comboOccupation.Items.Add("Doctor")
        comboOccupation.Items.Add("High school student")
        comboOccupation.Items.Add("Mathematician")
        comboOccupation.Items.Add("Professor")
        comboOccupation.Items.Add("Programmer")
        comboOccupation.Items.Add("Retiree")
        comboOccupation.Items.Add("Soldier")
        comboOccupation.Items.Add("Student")
        comboOccupation.Items.Add("Teacher")

        comboNationality.Items.Add("Australia")
        comboNationality.Items.Add("Brazil")
        comboNationality.Items.Add("China")
        comboNationality.Items.Add("Colombia")
        comboNationality.Items.Add("England")
        comboNationality.Items.Add("Indonesia")
        comboNationality.Items.Add("Japan")
        comboNationality.Items.Add("Russia")
        comboNationality.Items.Add("South Africa")
        comboNationality.Items.Add("South Korea")
        comboNationality.Items.Add("United States of America")
        comboNationality.Items.Add("France")
        comboNationality.Items.Add("Zambia")

    End Sub
End Class