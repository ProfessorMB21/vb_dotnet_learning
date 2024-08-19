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

        Public Sub New(dateIssue As Date, dateExpiry As Date, bankName As String,
                       pinCode As Integer, cardNumber As Integer, secureCode As Integer)

            mDateIssue = dateIssue
            mDateExpiry = dateExpiry
            mBankName = bankName
            mPinCode = pinCode
            mSecurityCode = secureCode
            mCardNumber = cardNumber
        End Sub

    End Class

    Public Class Bank
        Dim mName As String
        Dim mAccount As BankAccount
        Private mHandler As BankHandler

        Public Sub New()

        End Sub

        Public Sub New(account As BankAccount)
            mAccount = account
        End Sub

        Public Property Name() As String
            Get
                Return mName
            End Get
            Set(value As String)
                mHandler = New BankHandler()
                If mHandler.Handle(value) Then
                    mName = value
                End If
            End Set
        End Property

        Public Property Account() As BankAccount
            Get
                Return mAccount
            End Get
            Set(value As BankAccount)
                mAccount = value
            End Set
        End Property

    End Class
End Module
