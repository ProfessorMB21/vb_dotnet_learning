Imports System.ComponentModel
Imports System.Numerics
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports FileIOHandler
Imports FileIOHandler.DataHandler
Imports FileIOHandler.FileIO
Imports ObjectHandler
Public Class Form3
    Dim fileReader As FileIO.Stream
    Dim fileWriter As FileIO.Stream
    Dim passportObj As Passport
    Dim personObj As Person

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

    Private Sub btnSaveState_Click(sender As Object, e As EventArgs) Handles btnSaveState.Click
        SaveToolStripMenuItem_Click(sender, e)
        SaveToolStripMenuItem1_Click(sender, e)

    End Sub

    Private Sub ClearAllMenuItem1_Click(sender As Object, e As EventArgs) Handles ClearAllMenuItem1.Click
        ClearToolStripMenuItem1_Click(sender, e)
        ClearToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim personObj As Person
        If Not bwPersonCreator.IsBusy() Then
            bwPersonCreator.RunWorkerAsync(personObj)
            Threading.Thread.Sleep(250)
            Me.Refresh()
        End If

        If Not IsNothing(personObj) Then
            MsgBox("Created object person: " & personObj.ToString())
        End If

    End Sub

    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem1.Click
        Dim passportObj As Passport

        If Not bwPassportCreator.IsBusy() Then
            bwPassportCreator.RunWorkerAsync(passportObj)
            Threading.Thread.Sleep(250)
            Me.Refresh()
        End If

        If Not IsNothing(passportObj) Then
            MsgBox("Created passport object: " & passportObj.ToString())
        End If

    End Sub

    Private Sub bwPersonCreator_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwPersonCreator.DoWork
        Dim sex(1) As Boolean
        Dim cGender As Char
        Dim firstName As String
        Dim lastName As String
        Dim dDob As Date
        Dim occupation As String


        Invoke(radioFemale, Sub()
                                sex(0) = radioFemale.Checked
                            End Sub)
        Invoke(radioMale, Sub()
                              sex(1) = radioMale.Checked
                          End Sub)
        Invoke(txtFirstName, Sub()
                                 firstName = txtFirstName.Text
                             End Sub)
        Invoke(txtLastName, Sub()
                                lastName = txtLastName.Text
                            End Sub)
        Invoke(dateDateOfBirth, Sub()
                                    dDob = dateDateOfBirth.Value
                                End Sub)
        Invoke(comboOccupation, Sub()
                                    occupation = comboOccupation.SelectedItem.ToString()
                                End Sub)

        Dim checkedFlag As Boolean = False
        Dim i As Integer
        Do While i < sex.Length
            If sex(i) = True Then
                Exit Do
            End If
        Loop

        Select Case i
            Case Is = 0
                cGender = "F"
            Case Is = 1
                cGender = "M"
        End Select

        personObj = New Person With {
            .FirstName = firstName,
            .LastName = lastName,
            .DateOfBirth = dDob,
            .Sex = cGender,
            .Occupation = occupation
        }

    End Sub

    Private Sub bwPassportCreator_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwPassportCreator.DoWork
        Dim sNationality As String = ""
        Dim sCode As String = ""
        Dim sPNumber As String = ""
        Dim dIssue As Date
        Dim dExpiry As Date
        Dim sAuthority As String = ""

        Invoke(comboNationality, Sub()
                                     sNationality = comboNationality.SelectedItem.ToString()
                                 End Sub)

        Invoke(txtCountryCode, Sub()
                                   sCode = txtCountryCode.Text
                               End Sub)

        Invoke(txtPassportNo, Sub()
                                  sPNumber = txtPassportNo.Text
                              End Sub)

        Invoke(txtAuthority, Sub()
                                 sAuthority = txtAuthority.Text
                             End Sub)

        Invoke(dateDateOfIssue, Sub()
                                    dIssue = dateDateOfIssue.Value
                                End Sub)

        Invoke(dateDateOfExpiry, Sub()
                                     dExpiry = dateDateOfExpiry.Value
                                 End Sub)

        passportObj = New Passport With {
           .Nationality = sNationality,
           .CountryCode = sCode,
           .PassportNumber = sPNumber,
           .DateIssue = dIssue,
           .DateExpiry = dExpiry,
           .Type = "P",
           .Authorizer = sAuthority
        }

    End Sub

    Public Overloads Sub Invoke(ByVal control As Control, ByVal action As Action)
        If control.InvokeRequired Then
            control.Invoke(New MethodInvoker(Sub() action()), Nothing)
        Else
            action.Invoke()
        End If
    End Sub

End Class