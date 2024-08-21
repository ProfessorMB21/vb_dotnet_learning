Imports FileIOHandler.DataHandler

Public Class Person
    Dim mFirstName As String
    Dim mLastName As String
    Dim mDob As Date
    Dim mSex As Char
    Dim mOccupation As String
    Dim mVisa As Visa
    Dim mBankCard As BankAccount
    Private mHandler As PersonHandler

    Public Sub New()

    End Sub

    Public Sub New(firstName As String, lastName As String, dob As Date, sex As Char,
                    occupation As String)

        mFirstName = firstName
        mLastName = lastName
        mSex = sex
        mOccupation = occupation
        mDob = dob
    End Sub

    Public Sub New(firstName As String, lastName As String, dob As Date, sex As Char,
                    occupation As String, visa As Visa, bankCard As BankAccount)
        mFirstName = firstName
        mLastName = lastName
        mSex = sex
        mOccupation = occupation
        mDob = dob
        mVisa = visa
        mBankCard = bankCard
    End Sub

    Public Property FirstName() As String
        Get
            Return mFirstName
        End Get
        Set(value As String)
            mHandler = New PersonHandler()
            If mHandler.Handle(value) Then
                mFirstName = value
            End If
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return mLastName
        End Get
        Set(value As String)
            mHandler = New PersonHandler()
            If mHandler.Handle(value) Then
                mLastName = value
            End If
        End Set
    End Property

    Public Property DateOfBirth() As Date
        Get
            Return mDob
        End Get
        Set(value As Date)
            mHandler = New PersonHandler()
            If Not mHandler.Handle(value) Then
                mDob = value
            End If
        End Set
    End Property

    Public Property Occupation() As String
        Get
            Return mOccupation
        End Get
        Set(value As String)
            mHandler = New PersonHandler()
            If mHandler.Handle(value) Then
                mOccupation = value
            End If
        End Set
    End Property

    Public Property Sex() As Char
        Get
            Return mSex
        End Get
        Set(value As Char)
            mHandler = New PersonHandler()
            If mHandler.Handle(value) Then
                mSex = value
            End If
        End Set
    End Property

    Public Property VisaInfo() As Visa
        Get
            Return mVisa
        End Get
        Set(value As Visa)
            mVisa = value
        End Set
    End Property

    Public Property BankAccountInfo() As BankAccount
        Get
            Return mBankCard
        End Get
        Set(value As BankAccount)
            mBankCard = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return FirstName + vbNewLine + LastName + vbNewLine + DateOfBirth.ToString() + vbNewLine +
            Occupation + vbNewLine + Sex
    End Function

End Class
