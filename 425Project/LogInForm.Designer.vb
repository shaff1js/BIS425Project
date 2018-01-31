<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInForm
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
        Me.Title1Label = New System.Windows.Forms.Label()
        Me.Title2Label = New System.Windows.Forms.Label()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.RegisterLabel = New System.Windows.Forms.Label()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PasswordMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Title1Label
        '
        Me.Title1Label.AutoSize = True
        Me.Title1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title1Label.Location = New System.Drawing.Point(92, 24)
        Me.Title1Label.Name = "Title1Label"
        Me.Title1Label.Size = New System.Drawing.Size(275, 25)
        Me.Title1Label.TabIndex = 0
        Me.Title1Label.Text = "Central Michigan University"
        '
        'Title2Label
        '
        Me.Title2Label.AutoSize = True
        Me.Title2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title2Label.Location = New System.Drawing.Point(107, 49)
        Me.Title2Label.Name = "Title2Label"
        Me.Title2Label.Size = New System.Drawing.Size(243, 25)
        Me.Title2Label.TabIndex = 1
        Me.Title2Label.Text = "Commuter Parking Pass"
        '
        'UserNameLabel
        '
        Me.UserNameLabel.AutoSize = True
        Me.UserNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameLabel.Location = New System.Drawing.Point(100, 120)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(73, 15)
        Me.UserNameLabel.TabIndex = 2
        Me.UserNameLabel.Text = "User Name:"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(109, 148)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(64, 15)
        Me.PasswordLabel.TabIndex = 3
        Me.PasswordLabel.Text = "Password:"
        '
        'RegisterLabel
        '
        Me.RegisterLabel.AutoSize = True
        Me.RegisterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterLabel.Location = New System.Drawing.Point(207, 216)
        Me.RegisterLabel.Name = "RegisterLabel"
        Me.RegisterLabel.Size = New System.Drawing.Size(46, 13)
        Me.RegisterLabel.TabIndex = 7
        Me.RegisterLabel.Text = "Register"
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Location = New System.Drawing.Point(179, 119)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(172, 20)
        Me.UserNameTextBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(185, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 40)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Log In"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PasswordMaskedTextBox
        '
        Me.PasswordMaskedTextBox.Location = New System.Drawing.Point(179, 147)
        Me.PasswordMaskedTextBox.Name = "PasswordMaskedTextBox"
        Me.PasswordMaskedTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordMaskedTextBox.Size = New System.Drawing.Size(172, 20)
        Me.PasswordMaskedTextBox.TabIndex = 6
        '
        'LogInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 291)
        Me.Controls.Add(Me.PasswordMaskedTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(Me.RegisterLabel)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UserNameLabel)
        Me.Controls.Add(Me.Title2Label)
        Me.Controls.Add(Me.Title1Label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "LogInForm"
        Me.Text = "Log in"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title1Label As Label
    Friend WithEvents Title2Label As Label
    Friend WithEvents UserNameLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents RegisterLabel As Label
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PasswordMaskedTextBox As MaskedTextBox
End Class
