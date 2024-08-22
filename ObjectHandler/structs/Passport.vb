Imports FileIOHandler
Imports FileIOHandler.DataHandler
Public Class Passport
    Dim mDateIssue As Date
    Dim mDateExpiry As Date
    Dim mAuthority As String
    Dim mCountryCode As String
    Dim mNationality As String
    Dim mPassportNumber As String
    Dim mType As Char
    'Dim mMisc As String()
    Dim mHandler As DataHandler.PassportHandler

    Public Sub New()

    End Sub

    Public Sub New(dateIssue As Date, dateExpiry As Date, type As Char, authorizer As String,
            nationality As String, countryCode As String)
        mDateIssue = dateIssue
        mDateExpiry = dateExpiry
        mType = type
        'mMisc = miscInfo
        mAuthority = authorizer
        mNationality = nationality
        mCountryCode = countryCode

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

    Public Property Type() As Char
        Get
            Return mType
        End Get
        Set(value As Char)
            mHandler = New VisaHandler()
            If Not mHandler.Handle(value) Then
                Exit Property
            Else
                mType = value
            End If
        End Set
    End Property

    Public Property Nationality() As String
        Get
            Return mNationality
        End Get
        Set(value As String)
            mHandler = New PassportHandler()
            If Not mHandler.Handle(value) Then
                mNationality = value
            End If
        End Set
    End Property

    Public Property Authorizer() As String
        Get
            Return mAuthority
        End Get
        Set(value As String)
            mHandler = New PassportHandler()
            If Not mHandler.Handle(value) Then
                mAuthority = value
            End If
        End Set
    End Property

    Public Property PassportNumber() As String
        Get
            Return mPassportNumber
        End Get
        Set(value As String)
            mHandler = New PassportHandler()
            If mHandler.HandlePNum(value) Then
                mPassportNumber = value
            Else
                MsgBox("Invalid passport number.")
                Exit Property
            End If
        End Set
    End Property

    Public Property CountryCode As String
        Get
            Return mCountryCode
        End Get
        Set(value As String)
            mHandler = New PassportHandler()

            Dim chars As Char() = {}
            Dim i As Integer

            Do While i < value.Length
                chars.Append(value(i))
            Loop

            If mHandler.Handle(chars) = Nothing Then
                MsgBox("Invalid country code.")
                Exit Property
            End If

            mCountryCode = mHandler.Handle(chars)
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Nationality & vbNewLine & DateIssue.ToString() & vbNewLine & DateExpiry.ToString() &
            vbNewLine & Type & vbNewLine & Authorizer & vbNewLine & PassportNumber
    End Function

End Class
