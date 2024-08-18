Imports FileIOHandler.DataHandler

Public Class Person
    Dim mFirstName As String
    Dim mLastName As String
    'Dim mAge As Integer
    Dim mDob As Date
    Dim mSex As Char
    Dim mOccupation As String
    Private mHandler As PersonHandler
    Dim mVisa As Visa
    Dim mBankCard As BankAccount

    Public Sub New()

    End Sub

    Public Sub New(firstName As String, lastName As String, dob As Date, sex As Char,
                    occupation As String)

    End Sub

    Public Sub New(firstName As String, lastName As String, dob As Date, sex As Char,
                    occupation As String, visa As Visa, bankCard As BankAccount)

    End Sub

End Class
