<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUserForm
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
        Me.AUBackButton = New System.Windows.Forms.Button()
        Me.AUAddUserButton = New System.Windows.Forms.Button()
        Me.AUClearButton = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.AUPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.AUEmailTextBox = New System.Windows.Forms.TextBox()
        Me.AUPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.AUGlobalIDTextBox = New System.Windows.Forms.TextBox()
        Me.AURoleComboBox = New System.Windows.Forms.ComboBox()
        Me.AULastNameTextBox = New System.Windows.Forms.TextBox()
        Me.AUFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.AUUserIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AUBackButton
        '
        Me.AUBackButton.Location = New System.Drawing.Point(69, 325)
        Me.AUBackButton.Name = "AUBackButton"
        Me.AUBackButton.Size = New System.Drawing.Size(75, 23)
        Me.AUBackButton.TabIndex = 42
        Me.AUBackButton.Text = "Back"
        Me.AUBackButton.UseVisualStyleBackColor = True
        '
        'AUAddUserButton
        '
        Me.AUAddUserButton.Location = New System.Drawing.Point(262, 325)
        Me.AUAddUserButton.Name = "AUAddUserButton"
        Me.AUAddUserButton.Size = New System.Drawing.Size(75, 23)
        Me.AUAddUserButton.TabIndex = 41
        Me.AUAddUserButton.Text = "Add"
        Me.AUAddUserButton.UseVisualStyleBackColor = True
        '
        'AUClearButton
        '
        Me.AUClearButton.Location = New System.Drawing.Point(162, 325)
        Me.AUClearButton.Name = "AUClearButton"
        Me.AUClearButton.Size = New System.Drawing.Size(75, 23)
        Me.AUClearButton.TabIndex = 40
        Me.AUClearButton.Text = "Clear"
        Me.AUClearButton.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(212, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "S - Student   F - Faculty"
        '
        'AUPhoneTextBox
        '
        Me.AUPhoneTextBox.Location = New System.Drawing.Point(159, 271)
        Me.AUPhoneTextBox.MaxLength = 12
        Me.AUPhoneTextBox.Name = "AUPhoneTextBox"
        Me.AUPhoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AUPhoneTextBox.TabIndex = 38
        '
        'AUEmailTextBox
        '
        Me.AUEmailTextBox.Location = New System.Drawing.Point(159, 241)
        Me.AUEmailTextBox.MaxLength = 60
        Me.AUEmailTextBox.Name = "AUEmailTextBox"
        Me.AUEmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AUEmailTextBox.TabIndex = 37
        '
        'AUPasswordTextBox
        '
        Me.AUPasswordTextBox.Location = New System.Drawing.Point(159, 212)
        Me.AUPasswordTextBox.MaxLength = 30
        Me.AUPasswordTextBox.Name = "AUPasswordTextBox"
        Me.AUPasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AUPasswordTextBox.TabIndex = 36
        '
        'AUGlobalIDTextBox
        '
        Me.AUGlobalIDTextBox.Location = New System.Drawing.Point(159, 180)
        Me.AUGlobalIDTextBox.MaxLength = 8
        Me.AUGlobalIDTextBox.Name = "AUGlobalIDTextBox"
        Me.AUGlobalIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AUGlobalIDTextBox.TabIndex = 35
        '
        'AURoleComboBox
        '
        Me.AURoleComboBox.FormattingEnabled = True
        Me.AURoleComboBox.Items.AddRange(New Object() {"S", "F"})
        Me.AURoleComboBox.Location = New System.Drawing.Point(159, 149)
        Me.AURoleComboBox.Name = "AURoleComboBox"
        Me.AURoleComboBox.Size = New System.Drawing.Size(47, 21)
        Me.AURoleComboBox.TabIndex = 34
        '
        'AULastNameTextBox
        '
        Me.AULastNameTextBox.Location = New System.Drawing.Point(159, 118)
        Me.AULastNameTextBox.MaxLength = 30
        Me.AULastNameTextBox.Name = "AULastNameTextBox"
        Me.AULastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AULastNameTextBox.TabIndex = 33
        '
        'AUFirstNameTextBox
        '
        Me.AUFirstNameTextBox.Location = New System.Drawing.Point(159, 88)
        Me.AUFirstNameTextBox.MaxLength = 30
        Me.AUFirstNameTextBox.Name = "AUFirstNameTextBox"
        Me.AUFirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AUFirstNameTextBox.TabIndex = 32
        '
        'AUUserIDTextBox
        '
        Me.AUUserIDTextBox.Location = New System.Drawing.Point(159, 57)
        Me.AUUserIDTextBox.Name = "AUUserIDTextBox"
        Me.AUUserIDTextBox.ReadOnly = True
        Me.AUUserIDTextBox.Size = New System.Drawing.Size(47, 20)
        Me.AUUserIDTextBox.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(100, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Password:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(100, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(75, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Phone Number:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(121, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(102, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Global ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(124, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Role:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "First Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "User ID:"
        '
        'AddUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 408)
        Me.Controls.Add(Me.AUBackButton)
        Me.Controls.Add(Me.AUAddUserButton)
        Me.Controls.Add(Me.AUClearButton)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.AUPhoneTextBox)
        Me.Controls.Add(Me.AUEmailTextBox)
        Me.Controls.Add(Me.AUPasswordTextBox)
        Me.Controls.Add(Me.AUGlobalIDTextBox)
        Me.Controls.Add(Me.AURoleComboBox)
        Me.Controls.Add(Me.AULastNameTextBox)
        Me.Controls.Add(Me.AUFirstNameTextBox)
        Me.Controls.Add(Me.AUUserIDTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddUserForm"
        Me.Text = "AddUserForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AUBackButton As Button
    Friend WithEvents AUAddUserButton As Button
    Friend WithEvents AUClearButton As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents AUPhoneTextBox As TextBox
    Friend WithEvents AUEmailTextBox As TextBox
    Friend WithEvents AUPasswordTextBox As TextBox
    Friend WithEvents AUGlobalIDTextBox As TextBox
    Friend WithEvents AURoleComboBox As ComboBox
    Friend WithEvents AULastNameTextBox As TextBox
    Friend WithEvents AUFirstNameTextBox As TextBox
    Friend WithEvents AUUserIDTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
