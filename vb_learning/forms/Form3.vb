Imports System.Numerics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports FileIOHandler
Imports FileIOHandler.DataHandler
Imports FileIOHandler.FileIO
Imports ObjectHandler
Public Class Form3
    Dim fileReader As FileIO.Stream
    Dim fileWriter As FileIO.Stream

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        FormSettings.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePathCountries As String = "D:\Datafiles\config\countries.txt"
        Dim filePathProfessions As String = "D:\Datafiles\config\professions.txt"
        fileReader = New FileIO.Stream(filePathCountries, False)

        Do While Not fileReader.GetReader().EndOfStream
            Dim sItem = fileReader.Read()
            comboNationality.Items.Add(sItem)
        Loop
        fileReader.ReaderDeInit()
        fileReader = New FileIO.Stream(filePathProfessions, False)

        Do While Not fileReader.GetReader().EndOfStream
            Dim sItem = fileReader.Read()
            comboOccupation.Items.Add(sItem)
        Loop
        fileReader.ReaderDeInit()

    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub ClearToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem1.Click

        For Each item In groupGeneral.Controls()
            If Not item.GetType() = GetType(Label) Then
                comboOccupation.SelectedItem = Nothing
                txtFirstName.ResetText()
                txtLastName.ResetText()
                dateDateOfBirth.ResetText()
                radioFemale.Checked = False
                radioMale.Checked = False
            End If
        Next

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click

        For Each item In groupGeneral.Controls()
            If Not item.GetType() = GetType(Label) Then
                comboNationality.SelectedItem = Nothing
                txtCountryCode.ResetText()
                txtPassportNo.ResetText()
                dateDateOfIssue.ResetText()
                dateDateOfExpiry.ResetText()
                txtAuthority.ResetText()
            End If
        Next

    End Sub
End Class