<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDisableParkingLotForm
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
        Me.BackButton = New System.Windows.Forms.Button()
        Me.DisableEnableButton = New System.Windows.Forms.Button()
        Me.EditSaveButton = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.EndBillAMPMComboBox = New System.Windows.Forms.ComboBox()
        Me.BeginBillAMPMComboBox = New System.Windows.Forms.ComboBox()
        Me.EndBillMinuteComboBox = New System.Windows.Forms.ComboBox()
        Me.EndBillHourComboBox = New System.Windows.Forms.ComboBox()
        Me.BeginBillMinuteComboBox = New System.Windows.Forms.ComboBox()
        Me.PriceCentComboBox = New System.Windows.Forms.ComboBox()
        Me.PriceDollarComboBox = New System.Windows.Forms.ComboBox()
        Me.BeginBillHourComboBox = New System.Windows.Forms.ComboBox()
        Me.CapacityTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StreetAddressTextBox = New System.Windows.Forms.TextBox()
        Me.ParkingLotNameTextBox = New System.Windows.Forms.TextBox()
        Me.DisableBillingCheckBox = New System.Windows.Forms.CheckBox()
        Me.ConstantBillingCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ParkingLotIDComboBox = New System.Windows.Forms.ComboBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(198, 371)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(102, 40)
        Me.BackButton.TabIndex = 35
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'DisableEnableButton
        '
        Me.DisableEnableButton.Location = New System.Drawing.Point(198, 325)
        Me.DisableEnableButton.Name = "DisableEnableButton"
        Me.DisableEnableButton.Size = New System.Drawing.Size(102, 40)
        Me.DisableEnableButton.TabIndex = 34
        Me.DisableEnableButton.Text = "Disable"
        Me.DisableEnableButton.UseVisualStyleBackColor = True
        '
        'EditSaveButton
        '
        Me.EditSaveButton.Location = New System.Drawing.Point(198, 279)
        Me.EditSaveButton.Name = "EditSaveButton"
        Me.EditSaveButton.Size = New System.Drawing.Size(102, 40)
        Me.EditSaveButton.TabIndex = 33
        Me.EditSaveButton.Text = "Edit"
        Me.EditSaveButton.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(197, 200)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 15)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(197, 148)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 15)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(197, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 15)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = ":"
        '
        'EndBillAMPMComboBox
        '
        Me.EndBillAMPMComboBox.Enabled = False
        Me.EndBillAMPMComboBox.FormattingEnabled = True
        Me.EndBillAMPMComboBox.Items.AddRange(New Object() {"AM", "PM"})
        Me.EndBillAMPMComboBox.Location = New System.Drawing.Point(252, 199)
        Me.EndBillAMPMComboBox.Name = "EndBillAMPMComboBox"
        Me.EndBillAMPMComboBox.Size = New System.Drawing.Size(48, 21)
        Me.EndBillAMPMComboBox.TabIndex = 55
        '
        'BeginBillAMPMComboBox
        '
        Me.BeginBillAMPMComboBox.Enabled = False
        Me.BeginBillAMPMComboBox.FormattingEnabled = True
        Me.BeginBillAMPMComboBox.Items.AddRange(New Object() {"AM", "PM"})
        Me.BeginBillAMPMComboBox.Location = New System.Drawing.Point(252, 173)
        Me.BeginBillAMPMComboBox.Name = "BeginBillAMPMComboBox"
        Me.BeginBillAMPMComboBox.Size = New System.Drawing.Size(48, 21)
        Me.BeginBillAMPMComboBox.TabIndex = 52
        '
        'EndBillMinuteComboBox
        '
        Me.EndBillMinuteComboBox.Enabled = False
        Me.EndBillMinuteComboBox.FormattingEnabled = True
        Me.EndBillMinuteComboBox.Items.AddRange(New Object() {"00", "15", "30", "45"})
        Me.EndBillMinuteComboBox.Location = New System.Drawing.Point(210, 199)
        Me.EndBillMinuteComboBox.Name = "EndBillMinuteComboBox"
        Me.EndBillMinuteComboBox.Size = New System.Drawing.Size(36, 21)
        Me.EndBillMinuteComboBox.TabIndex = 54
        '
        'EndBillHourComboBox
        '
        Me.EndBillHourComboBox.Enabled = False
        Me.EndBillHourComboBox.FormattingEnabled = True
        Me.EndBillHourComboBox.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.EndBillHourComboBox.Location = New System.Drawing.Point(155, 199)
        Me.EndBillHourComboBox.Name = "EndBillHourComboBox"
        Me.EndBillHourComboBox.Size = New System.Drawing.Size(36, 21)
        Me.EndBillHourComboBox.TabIndex = 53
        '
        'BeginBillMinuteComboBox
        '
        Me.BeginBillMinuteComboBox.Enabled = False
        Me.BeginBillMinuteComboBox.FormattingEnabled = True
        Me.BeginBillMinuteComboBox.Items.AddRange(New Object() {"00", "15", "30", "45"})
        Me.BeginBillMinuteComboBox.Location = New System.Drawing.Point(210, 173)
        Me.BeginBillMinuteComboBox.Name = "BeginBillMinuteComboBox"
        Me.BeginBillMinuteComboBox.Size = New System.Drawing.Size(36, 21)
        Me.BeginBillMinuteComboBox.TabIndex = 50
        '
        'PriceCentComboBox
        '
        Me.PriceCentComboBox.Enabled = False
        Me.PriceCentComboBox.FormattingEnabled = True
        Me.PriceCentComboBox.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75", "80", "85", "90", "95"})
        Me.PriceCentComboBox.Location = New System.Drawing.Point(210, 146)
        Me.PriceCentComboBox.Name = "PriceCentComboBox"
        Me.PriceCentComboBox.Size = New System.Drawing.Size(36, 21)
        Me.PriceCentComboBox.TabIndex = 46
        '
        'PriceDollarComboBox
        '
        Me.PriceDollarComboBox.Enabled = False
        Me.PriceDollarComboBox.FormattingEnabled = True
        Me.PriceDollarComboBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.PriceDollarComboBox.Location = New System.Drawing.Point(155, 146)
        Me.PriceDollarComboBox.Name = "PriceDollarComboBox"
        Me.PriceDollarComboBox.Size = New System.Drawing.Size(36, 21)
        Me.PriceDollarComboBox.TabIndex = 42
        '
        'BeginBillHourComboBox
        '
        Me.BeginBillHourComboBox.Enabled = False
        Me.BeginBillHourComboBox.FormattingEnabled = True
        Me.BeginBillHourComboBox.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.BeginBillHourComboBox.Location = New System.Drawing.Point(155, 173)
        Me.BeginBillHourComboBox.Name = "BeginBillHourComboBox"
        Me.BeginBillHourComboBox.Size = New System.Drawing.Size(36, 21)
        Me.BeginBillHourComboBox.TabIndex = 48
        '
        'CapacityTextBox
        '
        Me.CapacityTextBox.Location = New System.Drawing.Point(155, 121)
        Me.CapacityTextBox.MaxLength = 3
        Me.CapacityTextBox.Name = "CapacityTextBox"
        Me.CapacityTextBox.ReadOnly = True
        Me.CapacityTextBox.Size = New System.Drawing.Size(36, 20)
        Me.CapacityTextBox.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(306, 207)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(306, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 13)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(252, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 13)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(197, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(427, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "*"
        '
        'StreetAddressTextBox
        '
        Me.StreetAddressTextBox.Location = New System.Drawing.Point(155, 95)
        Me.StreetAddressTextBox.MaxLength = 30
        Me.StreetAddressTextBox.Name = "StreetAddressTextBox"
        Me.StreetAddressTextBox.ReadOnly = True
        Me.StreetAddressTextBox.Size = New System.Drawing.Size(266, 20)
        Me.StreetAddressTextBox.TabIndex = 38
        '
        'ParkingLotNameTextBox
        '
        Me.ParkingLotNameTextBox.Location = New System.Drawing.Point(155, 69)
        Me.ParkingLotNameTextBox.MaxLength = 30
        Me.ParkingLotNameTextBox.Name = "ParkingLotNameTextBox"
        Me.ParkingLotNameTextBox.ReadOnly = True
        Me.ParkingLotNameTextBox.Size = New System.Drawing.Size(266, 20)
        Me.ParkingLotNameTextBox.TabIndex = 36
        '
        'DisableBillingCheckBox
        '
        Me.DisableBillingCheckBox.AutoSize = True
        Me.DisableBillingCheckBox.Enabled = False
        Me.DisableBillingCheckBox.Location = New System.Drawing.Point(155, 248)
        Me.DisableBillingCheckBox.Name = "DisableBillingCheckBox"
        Me.DisableBillingCheckBox.Size = New System.Drawing.Size(91, 17)
        Me.DisableBillingCheckBox.TabIndex = 57
        Me.DisableBillingCheckBox.Text = "Disable Billing"
        Me.DisableBillingCheckBox.UseVisualStyleBackColor = True
        '
        'ConstantBillingCheckBox
        '
        Me.ConstantBillingCheckBox.AutoSize = True
        Me.ConstantBillingCheckBox.Enabled = False
        Me.ConstantBillingCheckBox.Location = New System.Drawing.Point(155, 225)
        Me.ConstantBillingCheckBox.Name = "ConstantBillingCheckBox"
        Me.ConstantBillingCheckBox.Size = New System.Drawing.Size(94, 17)
        Me.ConstantBillingCheckBox.TabIndex = 56
        Me.ConstantBillingCheckBox.Text = "24 Hour Billing"
        Me.ConstantBillingCheckBox.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(93, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "End Billing"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(82, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Begin Billing:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(115, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(98, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Capacity:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Street Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Parking Lot Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Parking Lot ID:"
        '
        'ParkingLotIDComboBox
        '
        Me.ParkingLotIDComboBox.FormattingEnabled = True
        Me.ParkingLotIDComboBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.ParkingLotIDComboBox.Location = New System.Drawing.Point(155, 42)
        Me.ParkingLotIDComboBox.Name = "ParkingLotIDComboBox"
        Me.ParkingLotIDComboBox.Size = New System.Drawing.Size(53, 21)
        Me.ParkingLotIDComboBox.TabIndex = 42
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(214, 41)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 63
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'EditDisableParkingLotForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 451)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.EndBillAMPMComboBox)
        Me.Controls.Add(Me.BeginBillAMPMComboBox)
        Me.Controls.Add(Me.EndBillMinuteComboBox)
        Me.Controls.Add(Me.EndBillHourComboBox)
        Me.Controls.Add(Me.BeginBillMinuteComboBox)
        Me.Controls.Add(Me.PriceCentComboBox)
        Me.Controls.Add(Me.ParkingLotIDComboBox)
        Me.Controls.Add(Me.PriceDollarComboBox)
        Me.Controls.Add(Me.BeginBillHourComboBox)
        Me.Controls.Add(Me.CapacityTextBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.StreetAddressTextBox)
        Me.Controls.Add(Me.ParkingLotNameTextBox)
        Me.Controls.Add(Me.DisableBillingCheckBox)
        Me.Controls.Add(Me.ConstantBillingCheckBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.DisableEnableButton)
        Me.Controls.Add(Me.EditSaveButton)
        Me.Name = "EditDisableParkingLotForm"
        Me.Text = "Edit / Disable Parking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackButton As Button
    Friend WithEvents DisableEnableButton As Button
    Friend WithEvents EditSaveButton As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents EndBillAMPMComboBox As ComboBox
    Friend WithEvents BeginBillAMPMComboBox As ComboBox
    Friend WithEvents EndBillMinuteComboBox As ComboBox
    Friend WithEvents EndBillHourComboBox As ComboBox
    Friend WithEvents BeginBillMinuteComboBox As ComboBox
    Friend WithEvents PriceCentComboBox As ComboBox
    Friend WithEvents PriceDollarComboBox As ComboBox
    Friend WithEvents BeginBillHourComboBox As ComboBox
    Friend WithEvents CapacityTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents StreetAddressTextBox As TextBox
    Friend WithEvents ParkingLotNameTextBox As TextBox
    Friend WithEvents DisableBillingCheckBox As CheckBox
    Friend WithEvents ConstantBillingCheckBox As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ParkingLotIDComboBox As ComboBox
    Friend WithEvents SearchButton As Button
End Class
