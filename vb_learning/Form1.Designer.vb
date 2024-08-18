<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        btn_start = New Button()
        btnGo = New Button()
        btnVariables = New Button()
        btnCars = New Button()
        btnInput = New Button()
        txtFirstName = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtLastName = New TextBox()
        btnSubmit = New Button()
        lstBxFruits = New ListBox()
        Label3 = New Label()
        txtCity = New TextBox()
        Label4 = New Label()
        btnCitySubmit = New Button()
        txtTemperature = New TextBox()
        Label5 = New Label()
        btnSubmitTemp = New Button()
        btnCounter = New Button()
        btnDoWhile = New Button()
        btnDoUntil = New Button()
        btnCondLoop = New Button()
        btnArrays = New Button()
        btnLinSearch = New Button()
        Label6 = New Label()
        txtSearch = New TextBox()
        btnMoreArrays = New Button()
        ProgressBar1 = New ProgressBar()
        btnStart = New Button()
        btnClear = New Button()
        btnStop = New Button()
        txtTimerIncrement = New TextBox()
        txtTimerInterval = New TextBox()
        Timer1 = New Timer(components)
        btnToLoginForm = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        SuspendLayout()
        ' 
        ' btn_start
        ' 
        btn_start.Location = New Point(174, 101)
        btn_start.Name = "btn_start"
        btn_start.Size = New Size(133, 61)
        btn_start.TabIndex = 0
        btn_start.Text = "Hello"
        btn_start.UseVisualStyleBackColor = True
        ' 
        ' btnGo
        ' 
        btnGo.Location = New Point(480, 101)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(147, 61)
        btnGo.TabIndex = 1
        btnGo.Text = "Message box"
        btnGo.UseVisualStyleBackColor = True
        ' 
        ' btnVariables
        ' 
        btnVariables.Location = New Point(174, 208)
        btnVariables.Name = "btnVariables"
        btnVariables.Size = New Size(134, 64)
        btnVariables.TabIndex = 2
        btnVariables.Text = "Vars"
        btnVariables.UseVisualStyleBackColor = True
        ' 
        ' btnCars
        ' 
        btnCars.Location = New Point(480, 211)
        btnCars.Name = "btnCars"
        btnCars.Size = New Size(143, 58)
        btnCars.TabIndex = 3
        btnCars.Text = "Cars"
        btnCars.UseVisualStyleBackColor = True
        ' 
        ' btnInput
        ' 
        btnInput.Location = New Point(174, 302)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(128, 60)
        btnInput.TabIndex = 4
        btnInput.Text = "User Input"
        btnInput.UseVisualStyleBackColor = True
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(489, 295)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(140, 23)
        txtFirstName.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(407, 298)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 15)
        Label1.TabIndex = 6
        Label1.Text = "First name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(407, 342)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 15)
        Label2.TabIndex = 8
        Label2.Text = "Last name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(489, 339)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(140, 23)
        txtLastName.TabIndex = 7
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(489, 382)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(143, 41)
        btnSubmit.TabIndex = 9
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' lstBxFruits
        ' 
        lstBxFruits.FormattingEnabled = True
        lstBxFruits.ItemHeight = 15
        lstBxFruits.Items.AddRange(New Object() {"Apple", "Guava", "Mango", "Lemon", "Peach", "Pomegranate", "Grape"})
        lstBxFruits.Location = New Point(676, 101)
        lstBxFruits.Name = "lstBxFruits"
        lstBxFruits.Size = New Size(108, 79)
        lstBxFruits.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(676, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 15)
        Label3.TabIndex = 11
        Label3.Text = "Favourite Fruit"
        ' 
        ' txtCity
        ' 
        txtCity.Location = New Point(861, 302)
        txtCity.Name = "txtCity"
        txtCity.Size = New Size(160, 23)
        txtCity.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(726, 310)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 15)
        Label4.TabIndex = 13
        Label4.Text = "What city are you fom?"
        ' 
        ' btnCitySubmit
        ' 
        btnCitySubmit.Location = New Point(861, 351)
        btnCitySubmit.Name = "btnCitySubmit"
        btnCitySubmit.Size = New Size(154, 40)
        btnCitySubmit.TabIndex = 14
        btnCitySubmit.Text = "Answer"
        btnCitySubmit.UseVisualStyleBackColor = True
        ' 
        ' txtTemperature
        ' 
        txtTemperature.Location = New Point(172, 485)
        txtTemperature.Name = "txtTemperature"
        txtTemperature.Size = New Size(140, 23)
        txtTemperature.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(74, 491)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 15)
        Label5.TabIndex = 16
        Label5.Text = "Temperature"
        ' 
        ' btnSubmitTemp
        ' 
        btnSubmitTemp.Location = New Point(170, 534)
        btnSubmitTemp.Name = "btnSubmitTemp"
        btnSubmitTemp.Size = New Size(143, 46)
        btnSubmitTemp.TabIndex = 17
        btnSubmitTemp.Text = "Submit"
        btnSubmitTemp.UseVisualStyleBackColor = True
        ' 
        ' btnCounter
        ' 
        btnCounter.Location = New Point(509, 474)
        btnCounter.Name = "btnCounter"
        btnCounter.Size = New Size(132, 60)
        btnCounter.TabIndex = 18
        btnCounter.Text = "Looping"
        btnCounter.UseVisualStyleBackColor = True
        ' 
        ' btnDoWhile
        ' 
        btnDoWhile.Location = New Point(509, 550)
        btnDoWhile.Name = "btnDoWhile"
        btnDoWhile.Size = New Size(132, 58)
        btnDoWhile.TabIndex = 19
        btnDoWhile.Text = "LoopingDoWhile"
        btnDoWhile.UseVisualStyleBackColor = True
        ' 
        ' btnDoUntil
        ' 
        btnDoUntil.Location = New Point(664, 474)
        btnDoUntil.Name = "btnDoUntil"
        btnDoUntil.Size = New Size(132, 60)
        btnDoUntil.TabIndex = 20
        btnDoUntil.Text = "LoopingDoUntil"
        btnDoUntil.UseVisualStyleBackColor = True
        ' 
        ' btnCondLoop
        ' 
        btnCondLoop.Location = New Point(664, 550)
        btnCondLoop.Name = "btnCondLoop"
        btnCondLoop.Size = New Size(132, 58)
        btnCondLoop.TabIndex = 21
        btnCondLoop.Text = "Conditioned Loop"
        btnCondLoop.UseVisualStyleBackColor = True
        ' 
        ' btnArrays
        ' 
        btnArrays.Location = New Point(880, 485)
        btnArrays.Name = "btnArrays"
        btnArrays.Size = New Size(135, 60)
        btnArrays.TabIndex = 22
        btnArrays.Text = "Array Variables"
        btnArrays.UseVisualStyleBackColor = True
        ' 
        ' btnLinSearch
        ' 
        btnLinSearch.Location = New Point(912, 162)
        btnLinSearch.Name = "btnLinSearch"
        btnLinSearch.Size = New Size(140, 50)
        btnLinSearch.TabIndex = 23
        btnLinSearch.Text = "Linear Search"
        btnLinSearch.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(813, 124)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 15)
        Label6.TabIndex = 25
        Label6.Text = "Search for name"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(912, 121)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(140, 23)
        txtSearch.TabIndex = 24
        ' 
        ' btnMoreArrays
        ' 
        btnMoreArrays.Location = New Point(1122, 162)
        btnMoreArrays.Name = "btnMoreArrays"
        btnMoreArrays.Size = New Size(133, 50)
        btnMoreArrays.TabIndex = 26
        btnMoreArrays.Text = "2D Arrays"
        btnMoreArrays.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(1119, 306)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(203, 30)
        ProgressBar1.TabIndex = 27
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(1119, 356)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(79, 35)
        btnStart.TabIndex = 28
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(1119, 438)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(79, 35)
        btnClear.TabIndex = 29
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnStop
        ' 
        btnStop.Location = New Point(1119, 397)
        btnStop.Name = "btnStop"
        btnStop.Size = New Size(79, 35)
        btnStop.TabIndex = 30
        btnStop.Text = "Stop"
        btnStop.UseVisualStyleBackColor = True
        ' 
        ' txtTimerIncrement
        ' 
        txtTimerIncrement.Location = New Point(1222, 368)
        txtTimerIncrement.Name = "txtTimerIncrement"
        txtTimerIncrement.Size = New Size(85, 23)
        txtTimerIncrement.TabIndex = 31
        ' 
        ' txtTimerInterval
        ' 
        txtTimerInterval.Location = New Point(1222, 409)
        txtTimerInterval.Name = "txtTimerInterval"
        txtTimerInterval.Size = New Size(85, 23)
        txtTimerInterval.TabIndex = 32
        ' 
        ' Timer1
        ' 
        ' 
        ' btnToLoginForm
        ' 
        btnToLoginForm.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnToLoginForm.BackgroundImageLayout = ImageLayout.None
        btnToLoginForm.Image = My.Resources.Resources.photo_2024_02_06_19_17_29
        btnToLoginForm.ImageAlign = ContentAlignment.BottomCenter
        btnToLoginForm.Location = New Point(1096, 499)
        btnToLoginForm.Name = "btnToLoginForm"
        btnToLoginForm.Size = New Size(129, 46)
        btnToLoginForm.TabIndex = 33
        btnToLoginForm.Text = "Login Form"
        btnToLoginForm.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1334, 668)
        Controls.Add(btnToLoginForm)
        Controls.Add(txtTimerInterval)
        Controls.Add(txtTimerIncrement)
        Controls.Add(btnStop)
        Controls.Add(btnClear)
        Controls.Add(btnStart)
        Controls.Add(ProgressBar1)
        Controls.Add(btnMoreArrays)
        Controls.Add(Label6)
        Controls.Add(txtSearch)
        Controls.Add(btnLinSearch)
        Controls.Add(btnArrays)
        Controls.Add(btnCondLoop)
        Controls.Add(btnDoUntil)
        Controls.Add(btnDoWhile)
        Controls.Add(btnCounter)
        Controls.Add(btnSubmitTemp)
        Controls.Add(Label5)
        Controls.Add(txtTemperature)
        Controls.Add(btnCitySubmit)
        Controls.Add(Label4)
        Controls.Add(txtCity)
        Controls.Add(Label3)
        Controls.Add(lstBxFruits)
        Controls.Add(btnSubmit)
        Controls.Add(Label2)
        Controls.Add(txtLastName)
        Controls.Add(Label1)
        Controls.Add(txtFirstName)
        Controls.Add(btnInput)
        Controls.Add(btnCars)
        Controls.Add(btnVariables)
        Controls.Add(btnGo)
        Controls.Add(btn_start)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Visual Basic Learning"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_start As Button
    Friend WithEvents btnGo As Button
    Friend WithEvents btnVariables As Button
    Friend WithEvents btnCars As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lstBxFruits As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCitySubmit As Button
    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSubmitTemp As Button
    Friend WithEvents btnCounter As Button
    Friend WithEvents btnDoWhile As Button
    Friend WithEvents btnDoUntil As Button
    Friend WithEvents btnCondLoop As Button
    Friend WithEvents btnArrays As Button
    Friend WithEvents btnLinSearch As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnMoreArrays As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnStart As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents txtTimerIncrement As TextBox
    Friend WithEvents txtTimerInterval As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnToLoginForm As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
