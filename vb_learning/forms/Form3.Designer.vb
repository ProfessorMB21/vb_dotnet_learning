<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        Label2 = New Label()
        Label4 = New Label()
        radioMale = New RadioButton()
        radioFemale = New RadioButton()
        GroupBox1 = New GroupBox()
        groupGeneral = New GroupBox()
        comboOccupation = New ComboBox()
        Label3 = New Label()
        dateDateOfBirth = New DateTimePicker()
        Label8 = New Label()
        btnSubmitForm = New Button()
        btnSaveState = New Button()
        txtCountryCode = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        txtPassportNo = New TextBox()
        Label7 = New Label()
        dateDateOfIssue = New DateTimePicker()
        Label9 = New Label()
        dateDateOfExpiry = New DateTimePicker()
        Label10 = New Label()
        txtAuthority = New TextBox()
        Label11 = New Label()
        groupPassport = New GroupBox()
        comboNationality = New ComboBox()
        MenuStrip1 = New MenuStrip()
        ColonToolStripMenuItem = New ToolStripMenuItem()
        FormsToolStripMenuItem = New ToolStripMenuItem()
        GeneralToolStripMenuItem = New ToolStripMenuItem()
        ClearToolStripMenuItem1 = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        PassportToolStripMenuItem = New ToolStripMenuItem()
        ClearToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem1 = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        OperationToolStripMenuItem = New ToolStripMenuItem()
        SaveAllToolStripMenuItem1 = New ToolStripMenuItem()
        ClearAllMenuItem1 = New ToolStripMenuItem()
        SubmitToolStripMenuItem = New ToolStripMenuItem()
        ToolsToolStripMenuItem = New ToolStripMenuItem()
        SettingsToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1.SuspendLayout()
        groupGeneral.SuspendLayout()
        groupPassport.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(9, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.AllowDrop = True
        txtFirstName.CharacterCasing = CharacterCasing.Upper
        txtFirstName.Cursor = Cursors.IBeam
        txtFirstName.Location = New Point(100, 27)
        txtFirstName.MaxLength = 255
        txtFirstName.Name = "txtFirstName"
        txtFirstName.PlaceholderText = "Bupe"
        txtFirstName.Size = New Size(203, 23)
        txtFirstName.TabIndex = 1
        ' 
        ' txtLastName
        ' 
        txtLastName.AllowDrop = True
        txtLastName.CharacterCasing = CharacterCasing.Upper
        txtLastName.Cursor = Cursors.IBeam
        txtLastName.Location = New Point(100, 61)
        txtLastName.MaxLength = 255
        txtLastName.Name = "txtLastName"
        txtLastName.PlaceholderText = "Mwansa"
        txtLastName.Size = New Size(203, 23)
        txtLastName.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(10, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 2
        Label2.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20F)
        Label4.Location = New Point(276, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(205, 37)
        Label4.TabIndex = 6
        Label4.Text = "Personal Details"
        ' 
        ' radioMale
        ' 
        radioMale.AutoSize = True
        radioMale.Location = New Point(51, 22)
        radioMale.Name = "radioMale"
        radioMale.Size = New Size(51, 19)
        radioMale.TabIndex = 8
        radioMale.TabStop = True
        radioMale.Text = "Male"
        radioMale.UseVisualStyleBackColor = True
        ' 
        ' radioFemale
        ' 
        radioFemale.AutoSize = True
        radioFemale.Location = New Point(175, 22)
        radioFemale.Name = "radioFemale"
        radioFemale.Size = New Size(63, 19)
        radioFemale.TabIndex = 9
        radioFemale.TabStop = True
        radioFemale.Text = "Female"
        radioFemale.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radioFemale)
        GroupBox1.Controls.Add(radioMale)
        GroupBox1.Cursor = Cursors.Hand
        GroupBox1.Location = New Point(9, 137)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(294, 54)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Sex"
        ' 
        ' groupGeneral
        ' 
        groupGeneral.Controls.Add(comboOccupation)
        groupGeneral.Controls.Add(Label3)
        groupGeneral.Controls.Add(dateDateOfBirth)
        groupGeneral.Controls.Add(Label8)
        groupGeneral.Controls.Add(GroupBox1)
        groupGeneral.Controls.Add(txtLastName)
        groupGeneral.Controls.Add(Label2)
        groupGeneral.Controls.Add(txtFirstName)
        groupGeneral.Controls.Add(Label1)
        groupGeneral.Location = New Point(30, 67)
        groupGeneral.Name = "groupGeneral"
        groupGeneral.Size = New Size(322, 260)
        groupGeneral.TabIndex = 11
        groupGeneral.TabStop = False
        groupGeneral.Text = "General"
        ' 
        ' comboOccupation
        ' 
        comboOccupation.DropDownStyle = ComboBoxStyle.DropDownList
        comboOccupation.FormattingEnabled = True
        comboOccupation.Location = New Point(100, 218)
        comboOccupation.Name = "comboOccupation"
        comboOccupation.Size = New Size(203, 23)
        comboOccupation.Sorted = True
        comboOccupation.TabIndex = 33
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 221)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 15)
        Label3.TabIndex = 32
        Label3.Text = "Occupation"
        ' 
        ' dateDateOfBirth
        ' 
        dateDateOfBirth.Location = New Point(100, 99)
        dateDateOfBirth.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        dateDateOfBirth.MinDate = New Date(1901, 1, 1, 0, 0, 0, 0)
        dateDateOfBirth.Name = "dateDateOfBirth"
        dateDateOfBirth.Size = New Size(203, 23)
        dateDateOfBirth.TabIndex = 31
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(10, 105)
        Label8.Name = "Label8"
        Label8.Size = New Size(73, 15)
        Label8.TabIndex = 30
        Label8.Text = "Date of Birth"
        ' 
        ' btnSubmitForm
        ' 
        btnSubmitForm.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnSubmitForm.BackColor = SystemColors.ControlLightLight
        btnSubmitForm.BackgroundImageLayout = ImageLayout.None
        btnSubmitForm.Location = New Point(632, 355)
        btnSubmitForm.Name = "btnSubmitForm"
        btnSubmitForm.Size = New Size(133, 29)
        btnSubmitForm.TabIndex = 12
        btnSubmitForm.Text = "Submit"
        btnSubmitForm.UseVisualStyleBackColor = False
        ' 
        ' btnSaveState
        ' 
        btnSaveState.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnSaveState.BackColor = SystemColors.ControlLightLight
        btnSaveState.BackgroundImageLayout = ImageLayout.None
        btnSaveState.Location = New Point(493, 355)
        btnSaveState.Name = "btnSaveState"
        btnSaveState.Size = New Size(133, 29)
        btnSaveState.TabIndex = 13
        btnSaveState.Text = "Save"
        btnSaveState.UseVisualStyleBackColor = False
        ' 
        ' txtCountryCode
        ' 
        txtCountryCode.AllowDrop = True
        txtCountryCode.CharacterCasing = CharacterCasing.Upper
        txtCountryCode.Cursor = Cursors.IBeam
        txtCountryCode.Location = New Point(115, 63)
        txtCountryCode.MaxLength = 3
        txtCountryCode.Name = "txtCountryCode"
        txtCountryCode.PlaceholderText = "ZMB"
        txtCountryCode.Size = New Size(200, 23)
        txtCountryCode.TabIndex = 16
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 66)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 15)
        Label5.TabIndex = 15
        Label5.Text = "Country code"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(24, 28)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 15)
        Label6.TabIndex = 13
        Label6.Text = "Nationality"
        ' 
        ' txtPassportNo
        ' 
        txtPassportNo.AllowDrop = True
        txtPassportNo.CharacterCasing = CharacterCasing.Upper
        txtPassportNo.Cursor = Cursors.IBeam
        txtPassportNo.Location = New Point(115, 101)
        txtPassportNo.MaxLength = 255
        txtPassportNo.Name = "txtPassportNo"
        txtPassportNo.PlaceholderText = "e.g ZNXXXXXX"
        txtPassportNo.Size = New Size(200, 23)
        txtPassportNo.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(24, 104)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 15)
        Label7.TabIndex = 17
        Label7.Text = "Passport No."
        ' 
        ' dateDateOfIssue
        ' 
        dateDateOfIssue.Location = New Point(115, 139)
        dateDateOfIssue.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        dateDateOfIssue.MinDate = New Date(1901, 1, 1, 0, 0, 0, 0)
        dateDateOfIssue.Name = "dateDateOfIssue"
        dateDateOfIssue.Size = New Size(200, 23)
        dateDateOfIssue.TabIndex = 22
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(24, 142)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 15)
        Label9.TabIndex = 21
        Label9.Text = "Date of Issue"
        ' 
        ' dateDateOfExpiry
        ' 
        dateDateOfExpiry.Location = New Point(115, 177)
        dateDateOfExpiry.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        dateDateOfExpiry.MinDate = New Date(1901, 1, 1, 0, 0, 0, 0)
        dateDateOfExpiry.Name = "dateDateOfExpiry"
        dateDateOfExpiry.Size = New Size(200, 23)
        dateDateOfExpiry.TabIndex = 24
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(24, 180)
        Label10.Name = "Label10"
        Label10.Size = New Size(80, 15)
        Label10.TabIndex = 23
        Label10.Text = "Date of Expiry"
        ' 
        ' txtAuthority
        ' 
        txtAuthority.AllowDrop = True
        txtAuthority.CharacterCasing = CharacterCasing.Upper
        txtAuthority.Cursor = Cursors.IBeam
        txtAuthority.Location = New Point(115, 215)
        txtAuthority.MaxLength = 255
        txtAuthority.Name = "txtAuthority"
        txtAuthority.Size = New Size(200, 23)
        txtAuthority.TabIndex = 26
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(24, 218)
        Label11.Name = "Label11"
        Label11.Size = New Size(57, 15)
        Label11.TabIndex = 25
        Label11.Tag = "Authority which issued your passport"
        Label11.Text = "Authority"
        ' 
        ' groupPassport
        ' 
        groupPassport.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        groupPassport.Controls.Add(comboNationality)
        groupPassport.Controls.Add(txtAuthority)
        groupPassport.Controls.Add(Label11)
        groupPassport.Controls.Add(dateDateOfExpiry)
        groupPassport.Controls.Add(Label10)
        groupPassport.Controls.Add(dateDateOfIssue)
        groupPassport.Controls.Add(Label9)
        groupPassport.Controls.Add(txtPassportNo)
        groupPassport.Controls.Add(Label7)
        groupPassport.Controls.Add(txtCountryCode)
        groupPassport.Controls.Add(Label5)
        groupPassport.Controls.Add(Label6)
        groupPassport.Location = New Point(430, 67)
        groupPassport.Name = "groupPassport"
        groupPassport.Size = New Size(335, 260)
        groupPassport.TabIndex = 27
        groupPassport.TabStop = False
        groupPassport.Text = "Passport"
        ' 
        ' comboNationality
        ' 
        comboNationality.BackColor = SystemColors.ControlLightLight
        comboNationality.DropDownStyle = ComboBoxStyle.DropDownList
        comboNationality.FormattingEnabled = True
        comboNationality.ImeMode = ImeMode.NoControl
        comboNationality.Location = New Point(115, 25)
        comboNationality.Name = "comboNationality"
        comboNationality.Size = New Size(200, 23)
        comboNationality.Sorted = True
        comboNationality.TabIndex = 34
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ColonToolStripMenuItem, OperationToolStripMenuItem, ToolsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 28
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ColonToolStripMenuItem
        ' 
        ColonToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FormsToolStripMenuItem, ExitToolStripMenuItem})
        ColonToolStripMenuItem.Name = "ColonToolStripMenuItem"
        ColonToolStripMenuItem.Size = New Size(51, 20)
        ColonToolStripMenuItem.Text = "Colon"
        ' 
        ' FormsToolStripMenuItem
        ' 
        FormsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GeneralToolStripMenuItem, PassportToolStripMenuItem})
        FormsToolStripMenuItem.Name = "FormsToolStripMenuItem"
        FormsToolStripMenuItem.Size = New Size(107, 22)
        FormsToolStripMenuItem.Text = "Forms"
        ' 
        ' GeneralToolStripMenuItem
        ' 
        GeneralToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClearToolStripMenuItem1, SaveToolStripMenuItem})
        GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem"
        GeneralToolStripMenuItem.Size = New Size(119, 22)
        GeneralToolStripMenuItem.Text = "General"
        ' 
        ' ClearToolStripMenuItem1
        ' 
        ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        ClearToolStripMenuItem1.Size = New Size(101, 22)
        ClearToolStripMenuItem1.Text = "Clear"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(101, 22)
        SaveToolStripMenuItem.Text = "Save"
        ' 
        ' PassportToolStripMenuItem
        ' 
        PassportToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClearToolStripMenuItem, SaveToolStripMenuItem1})
        PassportToolStripMenuItem.Name = "PassportToolStripMenuItem"
        PassportToolStripMenuItem.Size = New Size(119, 22)
        PassportToolStripMenuItem.Text = "Passport"
        ' 
        ' ClearToolStripMenuItem
        ' 
        ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        ClearToolStripMenuItem.Size = New Size(101, 22)
        ClearToolStripMenuItem.Text = "Clear"
        ' 
        ' SaveToolStripMenuItem1
        ' 
        SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        SaveToolStripMenuItem1.Size = New Size(101, 22)
        SaveToolStripMenuItem1.Text = "Save"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(107, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' OperationToolStripMenuItem
        ' 
        OperationToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SaveAllToolStripMenuItem1, ClearAllMenuItem1, SubmitToolStripMenuItem})
        OperationToolStripMenuItem.Name = "OperationToolStripMenuItem"
        OperationToolStripMenuItem.Size = New Size(72, 20)
        OperationToolStripMenuItem.Text = "Operation"
        ' 
        ' SaveAllToolStripMenuItem1
        ' 
        SaveAllToolStripMenuItem1.Name = "SaveAllToolStripMenuItem1"
        SaveAllToolStripMenuItem1.Size = New Size(118, 22)
        SaveAllToolStripMenuItem1.Text = "Save All"
        ' 
        ' ClearAllMenuItem1
        ' 
        ClearAllMenuItem1.Name = "ClearAllMenuItem1"
        ClearAllMenuItem1.Size = New Size(118, 22)
        ClearAllMenuItem1.Text = "Clear All"
        ' 
        ' SubmitToolStripMenuItem
        ' 
        SubmitToolStripMenuItem.Name = "SubmitToolStripMenuItem"
        SubmitToolStripMenuItem.Size = New Size(118, 22)
        SubmitToolStripMenuItem.Text = "Submit"
        ' 
        ' ToolsToolStripMenuItem
        ' 
        ToolsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SettingsToolStripMenuItem})
        ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        ToolsToolStripMenuItem.Size = New Size(46, 20)
        ToolsToolStripMenuItem.Text = "Tools"
        ' 
        ' SettingsToolStripMenuItem
        ' 
        SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        SettingsToolStripMenuItem.Size = New Size(116, 22)
        SettingsToolStripMenuItem.Text = "Settings"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 396)
        Controls.Add(groupPassport)
        Controls.Add(btnSaveState)
        Controls.Add(btnSubmitForm)
        Controls.Add(groupGeneral)
        Controls.Add(Label4)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        MinimumSize = New Size(778, 435)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Colon"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        groupGeneral.ResumeLayout(False)
        groupGeneral.PerformLayout()
        groupPassport.ResumeLayout(False)
        groupPassport.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents radioMale As RadioButton
    Friend WithEvents radioFemale As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents groupGeneral As GroupBox
    Friend WithEvents btnSubmitForm As Button
    Friend WithEvents btnSaveState As Button
    Friend WithEvents txtCountryCode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPassportNo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dateDateOfIssue As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents dateDateOfExpiry As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAuthority As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents groupPassport As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dateDateOfBirth As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents comboOccupation As ComboBox
    Friend WithEvents comboNationality As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ColonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PassportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OperationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAllToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SubmitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAllMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
End Class
