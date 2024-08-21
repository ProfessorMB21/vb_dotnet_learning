Imports FileIOHandler.DataHandler

Public Class Visa
    Dim mDateIssue As Date
    Dim mDateEntry As Date
    Dim mDateExpiry As Date
    Dim mDurationDays As Integer
    Dim mType As Char
    Dim mInvitationNumber As String
    Dim mVisaId As String
    Dim mInvitingOrg As String
    Dim mEntryPurpose As String
    Dim mMisc(1) As Integer 'Red colored numbers on visa
    Private mHandler As VisaHandler

    Public Sub New()

    End Sub

    Public Sub New(dateIssue As Date, dateEntry As Date, dateExpiry As Date, durationDays As Integer, invitationNum As String,
                   Type As Char, id As String, inviteBy As String, entryPurpose As String, miscInfo As Integer())

        mHandler = New VisaHandler()
        If Not mHandler.Handle(miscInfo, mMisc.Length) Then
            MsgBox("Invalid misc. data.")
            Exit Sub
        Else
            mMisc = miscInfo
        End If

        mDateIssue = dateIssue
        mDateEntry = dateEntry
        mDateExpiry = dateExpiry
        mDurationDays = durationDays
        mType = Type
        mInvitationNumber = invitationNum
        mVisaId = id
        mInvitingOrg = inviteBy
        mEntryPurpose = entryPurpose

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

    Public Property DateEntry() As Date
        Get
            Return mDateEntry
        End Get
        Set(value As Date)
            mHandler = New VisaHandler()
            If Not mHandler.Handle(value) Then
                mDateEntry = value
            Else
                MsgBox("Invalid date.")
                Exit Property
            End If
        End Set
    End Property

    Public Property TotalDurationDays() As Integer
        Get
            Return mDurationDays
        End Get
        Set(value As Integer)
            mHandler = New VisaHandler()
            If Not mHandler.Handle(value) Then
                mDurationDays = value
            Else
                MsgBox("Invalid duration days.")
                Exit Property
            End If
            Exit Property
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

    Public Property InvitationNumber() As String
        Get
            Return mInvitationNumber
        End Get
        Set(value As String)
            mHandler = New VisaHandler()
            If mHandler.Handle(value) Then
                mInvitationNumber = value
            Else
                Exit Property
            End If
        End Set
    End Property

    Public Property VisaId() As String
        Get
            Return mVisaId
        End Get
        Set(value As String)
            mHandler = New VisaHandler()
            If mHandler.Handle(value) Then
                mVisaId = value
            Else
                Exit Property
            End If
        End Set
    End Property

    Public Property InviteOrg() As String
        Get
            Return mInvitingOrg
        End Get
        Set(value As String)
            mHandler = New VisaHandler()
            If Not mHandler.Handle(value) Then
                Exit Property
            Else
                mInvitingOrg = value
            End If
        End Set
    End Property

    Public Property EntryPurpose() As String
        Get
            Return mEntryPurpose
        End Get
        Set(value As String)
            mHandler = New VisaHandler()
            If Not mHandler.Handle(value) Then
                Exit Property
            Else
                mEntryPurpose = value
            End If
        End Set
    End Property

    Public Property Misc() As Integer()
        Get
            Return mMisc
        End Get
        Set(value As Integer())
            mHandler = New VisaHandler()
            If Not mHandler.Handle(value, mMisc.Length) Then
                Exit Property
            Else
                mMisc = value
            End If
        End Set
    End Property

    Public Function DaysLeft() As Integer
        Dim tSpan As TimeSpan
        tSpan = mDateExpiry - Today()
        If tSpan.TotalDays < 0 Then Return 0
        Return tSpan.TotalDays()
    End Function

    Public Overrides Function ToString() As String
        Return DateIssue.ToString() + vbNewLine + DateEntry.ToString() + vbNewLine + DateExpiry.ToString() +
            vbNewLine + TotalDurationDays + vbNewLine + Type.ToString() + InvitationNumber + vbNewLine + VisaId +
            vbNewLine + InviteOrg + vbNewLine + EntryPurpose + vbNewLine + Misc(0).ToString() + vbNewLine +
            Misc(0).ToString() + vbNewLine + DaysLeft()
    End Function

End Class

