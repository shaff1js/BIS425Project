<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPortalForm
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
        Me.StudentButton = New System.Windows.Forms.Button()
        Me.UsageButton = New System.Windows.Forms.Button()
        Me.CapacityButton = New System.Windows.Forms.Button()
        Me.DateRevButton = New System.Windows.Forms.Button()
        Me.TotalRevButton = New System.Windows.Forms.Button()
        Me.DisableLotButton = New System.Windows.Forms.Button()
        Me.EditLotButton = New System.Windows.Forms.Button()
        Me.CreateLotButton = New System.Windows.Forms.Button()
        Me.DisableAccountButton = New System.Windows.Forms.Button()
        Me.EditAccountButton = New System.Windows.Forms.Button()
        Me.CreateAccountButton = New System.Windows.Forms.Button()
        Me.ReportLabel = New System.Windows.Forms.Label()
        Me.CMULabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'StudentButton
        '
        Me.StudentButton.Location = New System.Drawing.Point(297, 317)
        Me.StudentButton.Name = "StudentButton"
        Me.StudentButton.Size = New System.Drawing.Size(111, 23)
        Me.StudentButton.TabIndex = 25
        Me.StudentButton.Text = "&Student Monthly Bill"
        Me.StudentButton.UseVisualStyleBackColor = True
        '
        'UsageButton
        '
        Me.UsageButton.Location = New System.Drawing.Point(297, 274)
        Me.UsageButton.Name = "UsageButton"
        Me.UsageButton.Size = New System.Drawing.Size(111, 23)
        Me.UsageButton.TabIndex = 24
        Me.UsageButton.Text = "&Usage by Lot"
        Me.UsageButton.UseVisualStyleBackColor = True
        '
        'CapacityButton
        '
        Me.CapacityButton.Location = New System.Drawing.Point(297, 229)
        Me.CapacityButton.Name = "CapacityButton"
        Me.CapacityButton.Size = New System.Drawing.Size(111, 23)
        Me.CapacityButton.TabIndex = 23
        Me.CapacityButton.Text = "Lot Ca&pacity"
        Me.CapacityButton.UseVisualStyleBackColor = True
        '
        'DateRevButton
        '
        Me.DateRevButton.Location = New System.Drawing.Point(297, 188)
        Me.DateRevButton.Name = "DateRevButton"
        Me.DateRevButton.Size = New System.Drawing.Size(111, 23)
        Me.DateRevButton.TabIndex = 22
        Me.DateRevButton.Text = "&Revenue by Date"
        Me.DateRevButton.UseVisualStyleBackColor = True
        '
        'TotalRevButton
        '
        Me.TotalRevButton.Location = New System.Drawing.Point(297, 140)
        Me.TotalRevButton.Name = "TotalRevButton"
        Me.TotalRevButton.Size = New System.Drawing.Size(111, 23)
        Me.TotalRevButton.TabIndex = 21
        Me.TotalRevButton.Text = "&Total Revenue"
        Me.TotalRevButton.UseVisualStyleBackColor = True
        '
        'DisableLotButton
        '
        Me.DisableLotButton.Location = New System.Drawing.Point(18, 317)
        Me.DisableLotButton.Name = "DisableLotButton"
        Me.DisableLotButton.Size = New System.Drawing.Size(111, 23)
        Me.DisableLotButton.TabIndex = 20
        Me.DisableLotButton.Text = "Dia&ble Lot"
        Me.DisableLotButton.UseVisualStyleBackColor = True
        '
        'EditLotButton
        '
        Me.EditLotButton.Location = New System.Drawing.Point(18, 274)
        Me.EditLotButton.Name = "EditLotButton"
        Me.EditLotButton.Size = New System.Drawing.Size(111, 23)
        Me.EditLotButton.TabIndex = 19
        Me.EditLotButton.Text = "Edit &Lot"
        Me.EditLotButton.UseVisualStyleBackColor = True
        '
        'CreateLotButton
        '
        Me.CreateLotButton.Location = New System.Drawing.Point(18, 229)
        Me.CreateLotButton.Name = "CreateLotButton"
        Me.CreateLotButton.Size = New System.Drawing.Size(111, 23)
        Me.CreateLotButton.TabIndex = 18
        Me.CreateLotButton.Text = "&Create Lot"
        Me.CreateLotButton.UseVisualStyleBackColor = True
        '
        'DisableAccountButton
        '
        Me.DisableAccountButton.Location = New System.Drawing.Point(18, 188)
        Me.DisableAccountButton.Name = "DisableAccountButton"
        Me.DisableAccountButton.Size = New System.Drawing.Size(111, 23)
        Me.DisableAccountButton.TabIndex = 17
        Me.DisableAccountButton.Text = "&Disable Account"
        Me.DisableAccountButton.UseVisualStyleBackColor = True
        '
        'EditAccountButton
        '
        Me.EditAccountButton.Location = New System.Drawing.Point(18, 140)
        Me.EditAccountButton.Name = "EditAccountButton"
        Me.EditAccountButton.Size = New System.Drawing.Size(111, 23)
        Me.EditAccountButton.TabIndex = 16
        Me.EditAccountButton.Text = "&Edit Account"
        Me.EditAccountButton.UseVisualStyleBackColor = True
        '
        'CreateAccountButton
        '
        Me.CreateAccountButton.Location = New System.Drawing.Point(18, 102)
        Me.CreateAccountButton.Name = "CreateAccountButton"
        Me.CreateAccountButton.Size = New System.Drawing.Size(111, 23)
        Me.CreateAccountButton.TabIndex = 15
        Me.CreateAccountButton.Text = "Create &Account"
        Me.CreateAccountButton.UseVisualStyleBackColor = True
        '
        'ReportLabel
        '
        Me.ReportLabel.AutoSize = True
        Me.ReportLabel.Location = New System.Drawing.Point(328, 112)
        Me.ReportLabel.Name = "ReportLabel"
        Me.ReportLabel.Size = New System.Drawing.Size(44, 13)
        Me.ReportLabel.TabIndex = 14
        Me.ReportLabel.Text = "Reports"
        '
        'CMULabel
        '
        Me.CMULabel.AutoSize = True
        Me.CMULabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMULabel.Location = New System.Drawing.Point(131, 55)
        Me.CMULabel.Name = "CMULabel"
        Me.CMULabel.Size = New System.Drawing.Size(177, 20)
        Me.CMULabel.TabIndex = 13
        Me.CMULabel.Text = "CMU Parking System"
        '
        'AdminPortalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 429)
        Me.Controls.Add(Me.StudentButton)
        Me.Controls.Add(Me.UsageButton)
        Me.Controls.Add(Me.CapacityButton)
        Me.Controls.Add(Me.DateRevButton)
        Me.Controls.Add(Me.TotalRevButton)
        Me.Controls.Add(Me.DisableLotButton)
        Me.Controls.Add(Me.EditLotButton)
        Me.Controls.Add(Me.CreateLotButton)
        Me.Controls.Add(Me.DisableAccountButton)
        Me.Controls.Add(Me.EditAccountButton)
        Me.Controls.Add(Me.CreateAccountButton)
        Me.Controls.Add(Me.ReportLabel)
        Me.Controls.Add(Me.CMULabel)
        Me.Name = "AdminPortalForm"
        Me.Text = "AdminPortalForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentButton As Button
    Friend WithEvents UsageButton As Button
    Friend WithEvents CapacityButton As Button
    Friend WithEvents DateRevButton As Button
    Friend WithEvents TotalRevButton As Button
    Friend WithEvents DisableLotButton As Button
    Friend WithEvents EditLotButton As Button
    Friend WithEvents CreateLotButton As Button
    Friend WithEvents DisableAccountButton As Button
    Friend WithEvents EditAccountButton As Button
    Friend WithEvents CreateAccountButton As Button
    Friend WithEvents ReportLabel As Label
    Friend WithEvents CMULabel As Label
End Class
