<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
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
        radioLightMode = New RadioButton()
        radioDarkMode = New RadioButton()
        radioSystemDefault = New RadioButton()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        tabSettingsControl = New TabControl()
        tabAppearance = New TabPage()
        tabAdvanced = New TabPage()
        btnRevert = New Button()
        btnApply = New Button()
        btnCancel = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        tabSettingsControl.SuspendLayout()
        tabAppearance.SuspendLayout()
        SuspendLayout()
        ' 
        ' radioLightMode
        ' 
        radioLightMode.AutoSize = True
        radioLightMode.Location = New Point(15, 31)
        radioLightMode.Name = "radioLightMode"
        radioLightMode.Size = New Size(86, 19)
        radioLightMode.TabIndex = 0
        radioLightMode.TabStop = True
        radioLightMode.Text = "Light mode"
        radioLightMode.UseVisualStyleBackColor = True
        ' 
        ' radioDarkMode
        ' 
        radioDarkMode.AutoSize = True
        radioDarkMode.Location = New Point(114, 31)
        radioDarkMode.Name = "radioDarkMode"
        radioDarkMode.Size = New Size(83, 19)
        radioDarkMode.TabIndex = 1
        radioDarkMode.TabStop = True
        radioDarkMode.Text = "Dark mode"
        radioDarkMode.UseVisualStyleBackColor = True
        ' 
        ' radioSystemDefault
        ' 
        radioSystemDefault.AutoSize = True
        radioSystemDefault.Location = New Point(210, 31)
        radioSystemDefault.Name = "radioSystemDefault"
        radioSystemDefault.Size = New Size(103, 19)
        radioSystemDefault.TabIndex = 3
        radioSystemDefault.TabStop = True
        radioSystemDefault.Text = "System default"
        radioSystemDefault.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radioSystemDefault)
        GroupBox1.Controls.Add(radioDarkMode)
        GroupBox1.Controls.Add(radioLightMode)
        GroupBox1.Location = New Point(17, 23)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(328, 67)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Theme"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(GroupBox3)
        GroupBox2.Controls.Add(GroupBox1)
        GroupBox2.Location = New Point(15, 6)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(372, 267)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Window"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(CheckBox4)
        GroupBox3.Controls.Add(CheckBox3)
        GroupBox3.Controls.Add(CheckBox2)
        GroupBox3.Controls.Add(CheckBox1)
        GroupBox3.Location = New Point(17, 105)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(144, 144)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        GroupBox3.Text = "Font Style"
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(15, 107)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(106, 19)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "Bold and Italics"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(15, 82)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(56, 19)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Italics"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(15, 57)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(50, 19)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Bold"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(15, 32)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(64, 19)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Default"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' tabSettingsControl
        ' 
        tabSettingsControl.Controls.Add(tabAppearance)
        tabSettingsControl.Controls.Add(tabAdvanced)
        tabSettingsControl.Location = New Point(2, 0)
        tabSettingsControl.Name = "tabSettingsControl"
        tabSettingsControl.SelectedIndex = 0
        tabSettingsControl.Size = New Size(436, 401)
        tabSettingsControl.TabIndex = 6
        ' 
        ' tabAppearance
        ' 
        tabAppearance.AutoScroll = True
        tabAppearance.BackColor = Color.White
        tabAppearance.Controls.Add(GroupBox2)
        tabAppearance.Location = New Point(4, 24)
        tabAppearance.Name = "tabAppearance"
        tabAppearance.Padding = New Padding(3)
        tabAppearance.Size = New Size(428, 373)
        tabAppearance.TabIndex = 0
        tabAppearance.Text = "Appearance"
        ' 
        ' tabAdvanced
        ' 
        tabAdvanced.AutoScroll = True
        tabAdvanced.BorderStyle = BorderStyle.Fixed3D
        tabAdvanced.Location = New Point(4, 24)
        tabAdvanced.Name = "tabAdvanced"
        tabAdvanced.Padding = New Padding(3)
        tabAdvanced.Size = New Size(428, 373)
        tabAdvanced.TabIndex = 1
        tabAdvanced.Text = "Advanced"
        tabAdvanced.UseVisualStyleBackColor = True
        ' 
        ' btnRevert
        ' 
        btnRevert.Location = New Point(127, 407)
        btnRevert.Name = "btnRevert"
        btnRevert.Size = New Size(91, 31)
        btnRevert.TabIndex = 7
        btnRevert.Text = "Revert"
        btnRevert.UseVisualStyleBackColor = True
        ' 
        ' btnApply
        ' 
        btnApply.Location = New Point(231, 407)
        btnApply.Name = "btnApply"
        btnApply.Size = New Size(91, 31)
        btnApply.TabIndex = 8
        btnApply.Text = "Apply"
        btnApply.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(335, 407)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(91, 31)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' FormSettings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        CancelButton = btnCancel
        ClientSize = New Size(439, 450)
        Controls.Add(btnCancel)
        Controls.Add(btnApply)
        Controls.Add(btnRevert)
        Controls.Add(tabSettingsControl)
        MaximizeBox = False
        MaximumSize = New Size(456, 490)
        MinimumSize = New Size(454, 488)
        Name = "FormSettings"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Settings"
        TopMost = True
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        tabSettingsControl.ResumeLayout(False)
        tabAppearance.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents radioLightMode As RadioButton
    Friend WithEvents radioDarkMode As RadioButton
    Friend WithEvents radioSystemDefault As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tabSettingsControl As TabControl
    Friend WithEvents tabAppearance As TabPage
    Friend WithEvents tabAdvanced As TabPage
    Friend WithEvents btnRevert As Button
    Friend WithEvents btnApply As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
