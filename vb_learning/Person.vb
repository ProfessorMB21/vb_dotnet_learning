Public Module Objects
    Public Class DataHandler
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
        Private handler As DataHandler

        Public Sub New()

        End Sub

        Public Sub New(dateIssue As Date, dateEntry As Date, dateExpiry As Date, durationDays As Integer, invitationNum As String,
                       Type As Char, id As String, inviteBy As String, entryPurpose As String, miscInfo As Integer())

            If Not handler.Handle(miscInfo, mMisc.Length) Then
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

                If handler.Handle(value) Then
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
                If handler.Handle(value) Then
                    mDateEntry = value
                Else
                    MsgBox("Invalid date.")
                    Exit Property
                End If
            End Set
        End Property

        Public Property DurationDays() As Integer
            Get
                Return mDurationDays
            End Get
            Set(value As Integer)
                If Not handler.Handle(value) Then
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
                If Not handler.Handle(value) Then
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
                If Not handler.Handle(value) Then
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
                If handler.Handle(value) Then
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
                If handler.Handle(value) Then
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
                If Not handler.Handle(value) Then
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
                If Not handler.Handle(value) Then
                    Exit Property
                Else
                    mEntryPurpose = value
                End If
            End Set
        End Property

    End Class

    Public Class Person
        Dim mFirstName As String
        Dim mLastName As String
        'Dim mAge As Integer
        Dim mDob As Date
        Dim mSex As String
        Dim mOccupation As String
        Private handler As DataHandler


    End Class


End Module
