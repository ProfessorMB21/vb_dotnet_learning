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
End Class