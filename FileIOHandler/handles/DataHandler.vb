﻿Public Module DataHandler
    Public Class VisaHandler
        Dim mArrayLength As Integer

        Public Sub New()

        End Sub

        Public Sub New(length As Integer)
            If Not length <= 0 Then
                mArrayLength = length
            Else
                MsgBox("Invalid array length.")
                Exit Sub
            End If
        End Sub

        Public Property ArrayLength() As Integer
            Get
                Return mArrayLength
            End Get
            Set(value As Integer)
                If Not value <= 0 Then
                    mArrayLength = value
                End If
                Exit Property
            End Set
        End Property

        Public Function Handle(array As Integer(), expectedLength As Integer) As Boolean
            If array.Length = expectedLength Then Return True
            Return False
        End Function

        Public Function Handle(array As Integer()) As Boolean
            If Not array.Length = mArrayLength Then Return False
            Return True
        End Function

        Public Function Handle(value As Date) As Boolean
            Return value > Today()
        End Function

        Public Function Handle(value As Integer) As Boolean
            Return value <= 0
        End Function

        Public Function Handle(value As Char) As Boolean
            Return Char.IsLetter(value) And (value.CompareTo("T") Or value.CompareTo("M"))
        End Function

        Public Function Handle(value As String) As Boolean
            If String.IsNullOrEmpty(value) Or String.IsNullOrWhiteSpace(value) Then Return False
            Return True
        End Function

    End Class

    Public Class PersonHandler
        Dim visaHandler As VisaHandler
        Dim bankHandler As BankHandler

        Public Sub New()

        End Sub

        Public Sub New(handler As VisaHandler)
            visaHandler = handler
        End Sub

        Public Sub New(handler As BankHandler)
            bankHandler = handler
        End Sub

        Public Function CreateHandlerV() As VisaHandler
            Return visaHandler
        End Function

        Public Function CreateHandlerB() As BankHandler
            Return bankHandler
        End Function

        Public Function Handle(value As Date) As Boolean
            Return value > Today()
        End Function

        Public Function StringCheck(value As String) As Boolean
            Return String.IsNullOrEmpty(value) And String.IsNullOrWhiteSpace(value)
        End Function

    End Class

    Public Class BankHandler

        Public Class AccountHandler
            Dim bIsBlocked As Boolean
            Private Shared decMaxAmount As Decimal
            Public Sub New()

            End Sub

            Public Function Handle(amount As Decimal) As Boolean
                Return amount >= 0.0 And amount <= 100000000.0
            End Function

            Public Function StrtoDec(value As String) As Decimal
                Dim decAmount As Decimal

                If value.Length > 0 And IsNumeric(value) Then
                    decAmount = CDec(value)
                    Return decAmount
                End If
                Return decAmount
            End Function

        End Class


    End Class

End Module
