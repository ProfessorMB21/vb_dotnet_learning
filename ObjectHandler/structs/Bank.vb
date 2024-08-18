Imports FileIOHandler.DataHandler

Public Module BankObject
    Public Class BankAccount
        Shared mDateIssue As Date
        Dim mDateExpiry As Date
        Dim mBankName As String
        Dim mPinCode As Integer
        Dim mSecurityCode As Integer
        Dim mCardNumber As Integer
        Private mHandler As BankHandler.AccountHandler

        Public Sub New()

        End Sub

    End Class

    Public Class Bank
        Dim mName As String
        Dim mAccount As BankAccount
        Private mHandler As BankHandler

        Public Sub New()

        End Sub

        Public Sub New(accout As BankAccount)

        End Sub

    End Class
End Module
