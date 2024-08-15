Public Class Form1
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        MsgBox("Hello world")
        MsgBox("how are you")
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        MessageBox.Show("another way of showing a message box")
    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click
        Dim iNumber As Integer
        Dim firstName As String

        iNumber = 107
        firstName = "Bupe"

        MsgBox("hello " & firstName & " nice to meet you " & iNumber)

        iNumber = 5792
        firstName = "clara"

        MessageBox.Show("hello " & firstName & " nice to meet you " & iNumber)

    End Sub

    Private Sub btnCars_Click(sender As Object, e As EventArgs) Handles btnCars.Click
        Dim stModel As String
        Dim stMake As String
        Dim iDoors As Integer
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateREgistered As Date


        stModel = "Escort"
        stMake = "Ford"
        iDoors = 5
        iEngineSize = 42
        decPrice = 435463.54
        dtDateREgistered = #10/5/2024#

        MsgBox("car details " & stMake & vbNewLine & stModel & vbNewLine &
               iDoors & vbNewLine & iEngineSize & vbNewLine &
               decPrice & vbNewLine & dtDateREgistered)
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim sName As String

        sName = InputBox("Enter your name")

        MsgBox("hello, " & sName & ", pleasure to meet you!")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim stFirstName As String
        Dim stLastName As String
        Dim stFavFruit As String

        stFirstName = txtFirstName.Text
        stLastName = txtLastName.Text
        stFavFruit = lstBxFruits.SelectedItem

        MsgBox("Hello " & stLastName & " " & stFirstName & Environment.NewLine & "You love " & stFavFruit & "s")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstBxFruits.Items.Add("Coconut")
        lstBxFruits.Items.Add("Egg")
    End Sub

    Private Sub btnCitySubmit_Click(sender As Object, e As EventArgs) Handles btnCitySubmit.Click
        Dim sCity As String

        ' data verification
        If IsNumeric(txtCity.Text) Then
            MsgBox("numerics in string")
            Exit Sub
        Else
            sCity = txtCity.Text
        End If


        If sCity.ToLower = "Lusaka".ToLower Then
            MsgBox("laka chikala!")
        ElseIf sCity = "Moscow".ToLower Then
            MsgBox("приветка милашка")
        Else
            MsgBox("fuck you, and your fucking city " & sCity.ToUpper)
        End If
    End Sub

    Private Sub btnSubmitTemp_Click(sender As Object, e As EventArgs) Handles btnSubmitTemp.Click
        Dim iTemp As Integer

        If Not IsNumeric(txtTemperature.Text) Then
            MsgBox("Temperature needs to be an integer")
        Else
            iTemp = CInt(txtTemperature.Text)
            MsgBox("fking cunt")
        End If

        Select Case iTemp
            Case Is = 0
                MsgBox("some warm clothes will do")
            Case Is < 0
                MsgBox("you shall die")
            Case 1 To 15
                MsgBox("go fuck 'em bitches")
            Case 16 To 30
                MsgBox("it's fucking hot mate")
            Case Else
                MsgBox("how tf are you alive")
        End Select


    End Sub

    Private Sub btnCounter_Click(sender As Object, e As EventArgs) Handles btnCounter.Click
        Dim iCount As Integer
        Dim sNumber As String

        For iCount = 1 To 100
            sNumber = "Hell yeah " & iCount
            MsgBox(sNumber)
            If iCount Mod 3 And iCount Mod 5 Then
                sNumber = sNumber & " fizzbuzz"
                MsgBox(sNumber)
            ElseIf iCount Mod 3 Then
                sNumber = sNumber & " fizz"
                MsgBox(sNumber)
            ElseIf iCount Mod 5 Then
                sNumber = sNumber & " buzz"
                MsgBox(sNumber)
            Else
                MsgBox(sNumber)
            End If
            '"Threading.Thread.Sleep(3)
        Next
    End Sub

    Private Sub btnDoWhile_Click(sender As Object, e As EventArgs) Handles btnDoWhile.Click
        Dim iCount As Integer

        Do While iCount < 100
            If iCount = 10 Then
                MsgBox("reached 10")
            End If
            If iCount = 20 Then
                MsgBox("done for today")
                Exit Sub
            End If

            MsgBox("iCount = " & iCount)
            iCount = iCount + 1
        Loop
    End Sub

    Private Sub btnDoUntil_Click(sender As Object, e As EventArgs) Handles btnDoUntil.Click
        Dim iCount As Integer

        Do
            iCount += 1
            MsgBox("iCount = " & iCount)
        Loop Until iCount = 20
    End Sub

    Private Sub btnCondLoop_Click(sender As Object, e As EventArgs) Handles btnCondLoop.Click
        Dim sName As String
        Dim iAge As Integer

        Do While Not IsNumeric(sName)
            sName = InputBox("please enter your age")
        Loop

        iAge = CInt(sName)
        MsgBox("Your age is " & iAge)

    End Sub

    Private Sub btnArrays_Click(sender As Object, e As EventArgs) Handles btnArrays.Click
        Dim sLen As String
        Dim iMaxElements As Integer
        Dim iCount As Integer


        Do Until IsNumeric(sLen)
            sLen = InputBox("enter the length of your array")
        Loop

        iMaxElements = CInt(sLen)
        Dim asNames(iMaxElements) As String

        Do
            asNames(iCount) = InputBox("please enter user name")
            iCount += 1
        Loop While iCount <= iMaxElements

        iCount = 0
        Do Until iCount = iMaxElements
            MsgBox("User " & iCount & vbTab & asNames(iCount))
            If iCount = iMaxElements Then MsgBox("we've reached the end of the array")

            iCount += 1
        Loop

    End Sub
End Class
