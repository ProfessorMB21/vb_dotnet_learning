Imports ObjectHandler
Imports System.IO

Public Module FileIO

    Public Class Stream
        Dim fWriter As StreamWriter
        Dim fReader As StreamReader
        Dim fPath As String
        Dim pHandler As PersonHandler

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

        Public Sub WriterInit()
            fWriter = New StreamWriter(fPath)
        End Sub

        Public Sub WriterInit(append As Boolean)
            If append Then
                fWriter = New StreamWriter(fPath, append)
            Else
                WriterInit()
            End If
        End Sub

        Public Sub WriterDeInit()
            fWriter.Close()
        End Sub

        Public Sub ReaderInit()
            fReader = New StreamReader(fPath)
        End Sub

        Public Sub ReaderDeInit()
            fReader.Close()
        End Sub

        Public Sub Write(value As String)
            fWriter.WriteLine(value)
        End Sub

        Public Sub Write(person As Person)

        End Sub

        Public Sub Write(visa As Visa)

        End Sub

    End Class

    Public Class Binary
        Dim fStream As FileStream
        Dim fWriter As BinaryWriter
        Dim fReader As BinaryReader
        Dim fPath As String
        Dim pHandler As PersonHandler

        Public Sub New(path As String)
            pHandler = New PersonHandler()
            If Not pHandler.Handle(path) Then
                fPath = path
            End If
        End Sub

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

        Public Sub WriterInit()
            fStream = New FileStream(fPath, FileMode.OpenOrCreate, FileAccess.Write)
            fWriter = New BinaryWriter(fStream)
        End Sub

        Public Sub WriterDeInit()
            fWriter.Close()
            fStream.Close()
        End Sub

        Public Sub ReaderInit()
            fStream = New FileStream(fPath, FileMode.Open, FileAccess.Read)
            fReader = New BinaryReader(fStream)
        End Sub

        Public Sub ReaderDeInit()
            fReader.Close()
        End Sub

    End Class

End Module
