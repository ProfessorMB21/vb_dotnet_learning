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

        Public Property DateIssue() As Date
            Get
                Return mDateIssue
            End Get
            Set(value As Date)
                mHandler = New VisaHandler()
                If Not mHandler.Handle(value) Then
                    mDateIssue = value
                Else
                    MsgBox("Invalid date.")
                    Exit Property
                End If
            End Set
        End Property

        Public Property DateExpiry() As Date
            Get
                Return mDateExpiry
            End Get
            Set(value As Date)
                mHandler = New VisaHandler()
                If mHandler.Handle(value) Then
                    mDateExpiry = value
                Else
                    MsgBox("Invalid date.")
                    Exit Property
                End If
            End Set
        End Property

        Public Property BankName() As String
            Get
                Return mBankName
            End Get
            Set(value As String)
                mHandler = New PersonHandler()
                If mHandler.Handle(value) Then
                    mBankName = value
                End If
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return DateIssue.ToString() + vbNewLine + DateExpiry.ToString() +
                vbNewLine + BankName
        End Function

    End Class

    Public Class Bank
        Dim mName As String
        Dim mAccount As BankAccount
        Private mHandler As BankHandler

        Public Sub New()

        End Sub

        Public Sub New(account As BankAccount)
            mAccount = account
            mName = mAccount.BankName()
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

        Public Overrides Function ToString() As String
            Return Name + Account.ToString()
        End Function

    End Class
End Module
