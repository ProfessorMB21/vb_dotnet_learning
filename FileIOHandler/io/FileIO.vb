Imports ObjectHandler
Imports System.IO

Public Module FileIO
    Private fPath As String
    Private pHandler As PersonHandler

    Public Class Stream
        Dim fWriter As StreamWriter
        Dim fReader As StreamReader

        Public Sub New(stream As String, write As Boolean)
            fPath = stream
            If Not write Then
                ReaderInit()
                Exit Sub
            End If

            WriterInit()
        End Sub

        Public Sub New(stream As String, write As Boolean, append As Boolean)
            fPath = stream
            If Not write Then
                ReaderInit()
                Exit Sub
            End If

            If append Then
                WriterInit(append)
            Else
                WriterInit()
            End If
        End Sub

        Public Function GetWriter() As StreamWriter
            Return fWriter
        End Function

        Public Function GetReader() As StreamReader
            Return fReader
        End Function

        Public Property FilePath() As String
            Get
                Return fPath
            End Get
            Set(value As String)
                pHandler = New PersonHandler()
                If Not pHandler.Handle(value) Then
                    fPath = value
                End If
            End Set
        End Property

        Private Sub WriterInit()
            fWriter = New StreamWriter(fPath)
        End Sub

        Private Sub WriterInit(append As Boolean)
            If append Then
                fWriter = New StreamWriter(fPath, append)
            Else
                WriterInit()
            End If
        End Sub

        Public Sub WriterDeInit()
            fWriter.Close()
        End Sub

        Private Sub ReaderInit()
            fReader = New StreamReader(fPath)
        End Sub

        Public Sub ReaderDeInit()
            fReader.Close()
        End Sub

        Public Sub Write(value As String)
            fWriter.WriteLine(value)
        End Sub

        Public Sub Write(person As Person)
            fWriter.Write(person)
        End Sub

        Public Sub Write(visa As Visa)
            fWriter.Write(visa)
        End Sub

        Public Sub Write(bankAcc As BankAccount)
            fWriter.Write(bankAcc)
        End Sub

        Public Function Read() As String
            Dim line As String = fReader.ReadLine()
            Return line
        End Function

        Public Sub Read(person As Person)
            Dim sPersonInfo As String() = {}

            Do While Not fReader.EndOfStream
                sPersonInfo.Append(fReader.ReadLine())
            Loop

            Dim iLen As Integer = sPersonInfo.Length()
            If iLen = 5 Then
                person.FirstName = sPersonInfo(0)
                person.LastName = sPersonInfo(1)
                person.DateOfBirth = sPersonInfo(2)
                person.Occupation = sPersonInfo(3)
                person.Sex = sPersonInfo(4)
            Else
                MsgBox("Unable to read file.", Nothing, "FileIO Unexpected Error")
                Exit Sub
            End If
        End Sub

    End Class

    Public Class Binary
        Dim fStream As FileStream
        Dim fWriter As BinaryWriter
        Dim fReader As BinaryReader

        Public Sub New(stream As String, write As Boolean)
            FilePath = stream
            If Not write Then
                ReaderInit()
                Exit Sub
            End If

            WriterInit()
        End Sub

        Public Function GetWriter() As BinaryWriter
            Return fWriter
        End Function

        Public Function GetReader() As BinaryReader
            Return fReader
        End Function

        Public Property FilePath() As String
            Get
                Return fPath
            End Get
            Set(value As String)
                pHandler = New PersonHandler()
                If Not pHandler.Handle(value) Then
                    fPath = value
                End If
            End Set
        End Property

        Private Sub WriterInit()
            fStream = New FileStream(fPath, FileMode.OpenOrCreate, FileAccess.Write)
            fWriter = New BinaryWriter(fStream)
        End Sub

        Public Sub WriterDeInit()
            fWriter.Close()
            fStream.Close()
        End Sub

        Private Sub ReaderInit()
            fStream = New FileStream(fPath, FileMode.Open, FileAccess.Read)
            fReader = New BinaryReader(fStream)
        End Sub

        Public Sub ReaderDeInit()
            fReader.Close()
        End Sub

        Public Function Read() As String
            Dim line As String = fReader.ReadString
            Return line
        End Function

        Public Function ReadPerson() As Person
            Dim sPersonInfo As String() = {}

            sPersonInfo.Append(fReader.ReadString())
            sPersonInfo.Append(fReader.ReadString())
            sPersonInfo.Append(fReader.ReadString())
            sPersonInfo.Append(fReader.ReadString())
            sPersonInfo.Append(fReader.ReadInt32())

            Dim tPerson As New Person With {
                .FirstName = sPersonInfo(0),
                .LastName = sPersonInfo(1),
                .DateOfBirth = sPersonInfo(2),
                .Occupation = sPersonInfo(3),
                .Sex = sPersonInfo(4)
            }

            Return tPerson
        End Function

    End Class

End Module
