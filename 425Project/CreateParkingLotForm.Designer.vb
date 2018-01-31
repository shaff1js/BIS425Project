<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateParkingLotForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ConstantBillingCheckBox = New System.Windows.Forms.CheckBox()
        Me.DisableBillingCheckBox = New System.Windows.Forms.CheckBox()
        Me.ParkingLotNameTextBox = New System.Windows.Forms.TextBox()
        Me.StreetAddressTextBox = New System.Windows.Forms.TextBox()
        Me.ParkingLotIDMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CapacityMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PriceMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox5 = New System.Windows.Forms.MaskedTextBox()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CreateParkingLotToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Parking Lot ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Parking Lot Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Street Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Capacity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Price:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(66, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Begin Billing:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(77, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "End Billing"
        '
        'ConstantBillingCheckBox
        '
        Me.ConstantBillingCheckBox.AutoSize = True
        Me.ConstantBillingCheckBox.Location = New System.Drawing.Point(139, 232)
        Me.ConstantBillingCheckBox.Name = "ConstantBillingCheckBox"
        Me.ConstantBillingCheckBox.Size = New System.Drawing.Size(94, 17)
        Me.ConstantBillingCheckBox.TabIndex = 7
        Me.ConstantBillingCheckBox.Text = "24 Hour Billing"
        Me.ConstantBillingCheckBox.UseVisualStyleBackColor = True
        '
        'DisableBillingCheckBox
        '
        Me.DisableBillingCheckBox.AutoSize = True
        Me.DisableBillingCheckBox.Location = New System.Drawing.Point(139, 255)
        Me.DisableBillingCheckBox.Name = "DisableBillingCheckBox"
        Me.DisableBillingCheckBox.Size = New System.Drawing.Size(91, 17)
        Me.DisableBillingCheckBox.TabIndex = 8
        Me.DisableBillingCheckBox.Text = "Disable Billing"
        Me.DisableBillingCheckBox.UseVisualStyleBackColor = True
        '
        'ParkingLotNameTextBox
        '
        Me.ParkingLotNameTextBox.Location = New System.Drawing.Point(139, 76)
        Me.ParkingLotNameTextBox.MaxLength = 30
        Me.ParkingLotNameTextBox.Name = "ParkingLotNameTextBox"
        Me.ParkingLotNameTextBox.Size = New System.Drawing.Size(266, 20)
        Me.ParkingLotNameTextBox.TabIndex = 9
        '
        'StreetAddressTextBox
        '
        Me.StreetAddressTextBox.Location = New System.Drawing.Point(139, 102)
        Me.StreetAddressTextBox.MaxLength = 30
        Me.StreetAddressTextBox.Name = "StreetAddressTextBox"
        Me.StreetAddressTextBox.Size = New System.Drawing.Size(266, 20)
        Me.StreetAddressTextBox.TabIndex = 10
        '
        'ParkingLotIDMaskedTextBox
        '
        Me.ParkingLotIDMaskedTextBox.Location = New System.Drawing.Point(139, 50)
        Me.ParkingLotIDMaskedTextBox.Name = "ParkingLotIDMaskedTextBox"
        Me.ParkingLotIDMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ParkingLotIDMaskedTextBox.TabIndex = 11
        '
        'CapacityMaskedTextBox
        '
        Me.CapacityMaskedTextBox.Location = New System.Drawing.Point(139, 128)
        Me.CapacityMaskedTextBox.Mask = "000"
        Me.CapacityMaskedTextBox.Name = "CapacityMaskedTextBox"
        Me.CapacityMaskedTextBox.Size = New System.Drawing.Size(26, 20)
        Me.CapacityMaskedTextBox.TabIndex = 12
        Me.CapacityMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'PriceMaskedTextBox
        '
        Me.PriceMaskedTextBox.Location = New System.Drawing.Point(139, 154)
        Me.PriceMaskedTextBox.Mask = "00.00"
        Me.PriceMaskedTextBox.Name = "PriceMaskedTextBox"
        Me.PriceMaskedTextBox.Size = New System.Drawing.Size(36, 20)
        Me.PriceMaskedTextBox.TabIndex = 13
        Me.PriceMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.Location = New System.Drawing.Point(139, 180)
        Me.MaskedTextBox4.Mask = "00:00"
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(36, 20)
        Me.MaskedTextBox4.TabIndex = 14
        Me.CreateParkingLotToolTip.SetToolTip(Me.MaskedTextBox4, "Please use 24 hour format")
        Me.MaskedTextBox4.ValidatingType = GetType(Date)
        '
        'MaskedTextBox5
        '
        Me.MaskedTextBox5.Location = New System.Drawing.Point(139, 206)
        Me.MaskedTextBox5.Mask = "00:00"
        Me.MaskedTextBox5.Name = "MaskedTextBox5"
        Me.MaskedTextBox5.Size = New System.Drawing.Size(36, 20)
        Me.MaskedTextBox5.TabIndex = 14
        Me.CreateParkingLotToolTip.SetToolTip(Me.MaskedTextBox5, "Please use 24 hour format")
        Me.MaskedTextBox5.ValidatingType = GetType(Date)
        '
        'CreateButton
        '
        Me.CreateButton.Location = New System.Drawing.Point(186, 290)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(102, 40)
        Me.CreateButton.TabIndex = 15
        Me.CreateButton.Text = "Create"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(186, 336)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(102, 40)
        Me.ClearButton.TabIndex = 15
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(186, 382)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(102, 40)
        Me.BackButton.TabIndex = 15
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(411, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(171, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(181, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(181, 183)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(181, 209)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "*"
        '
        'CreateParkingLotForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 451)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CreateButton)
        Me.Controls.Add(Me.MaskedTextBox5)
        Me.Controls.Add(Me.MaskedTextBox4)
        Me.Controls.Add(Me.PriceMaskedTextBox)
        Me.Controls.Add(Me.CapacityMaskedTextBox)
        Me.Controls.Add(Me.ParkingLotIDMaskedTextBox)
        Me.Controls.Add(Me.StreetAddressTextBox)
        Me.Controls.Add(Me.ParkingLotNameTextBox)
        Me.Controls.Add(Me.DisableBillingCheckBox)
        Me.Controls.Add(Me.ConstantBillingCheckBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CreateParkingLotForm"
        Me.Text = "Creat Parking Lot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ConstantBillingCheckBox As CheckBox
    Friend WithEvents DisableBillingCheckBox As CheckBox
    Friend WithEvents ParkingLotNameTextBox As TextBox
    Friend WithEvents StreetAddressTextBox As TextBox
    Friend WithEvents ParkingLotIDMaskedTextBox As MaskedTextBox
    Friend WithEvents CapacityMaskedTextBox As MaskedTextBox
    Friend WithEvents PriceMaskedTextBox As MaskedTextBox
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
    Friend WithEvents CreateParkingLotToolTip As ToolTip
    Friend WithEvents MaskedTextBox5 As MaskedTextBox
    Friend WithEvents CreateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
