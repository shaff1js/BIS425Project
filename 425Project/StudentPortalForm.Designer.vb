<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentPortalForm
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
        Me.CapacityButton = New System.Windows.Forms.Button()
        Me.SemesterButton = New System.Windows.Forms.Button()
        Me.MonthlyButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DisableButton = New System.Windows.Forms.Button()
        Me.AddVehicleButton = New System.Windows.Forms.Button()
        Me.CMULabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CapacityButton
        '
        Me.CapacityButton.Location = New System.Drawing.Point(180, 332)
        Me.CapacityButton.Name = "CapacityButton"
        Me.CapacityButton.Size = New System.Drawing.Size(94, 23)
        Me.CapacityButton.TabIndex = 13
        Me.CapacityButton.Text = "&Lot Capacity"
        Me.CapacityButton.UseVisualStyleBackColor = True
        '
        'SemesterButton
        '
        Me.SemesterButton.Location = New System.Drawing.Point(180, 290)
        Me.SemesterButton.Name = "SemesterButton"
        Me.SemesterButton.Size = New System.Drawing.Size(94, 23)
        Me.SemesterButton.TabIndex = 12
        Me.SemesterButton.Text = "&Semester Bill"
        Me.SemesterButton.UseVisualStyleBackColor = True
        '
        'MonthlyButton
        '
        Me.MonthlyButton.Location = New System.Drawing.Point(180, 246)
        Me.MonthlyButton.Name = "MonthlyButton"
        Me.MonthlyButton.Size = New System.Drawing.Size(94, 23)
        Me.MonthlyButton.TabIndex = 11
        Me.MonthlyButton.Text = "&Monthly Bill"
        Me.MonthlyButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(180, 206)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(94, 23)
        Me.EditButton.TabIndex = 10
        Me.EditButton.Text = "&Edit Account"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'DisableButton
        '
        Me.DisableButton.Location = New System.Drawing.Point(180, 164)
        Me.DisableButton.Name = "DisableButton"
        Me.DisableButton.Size = New System.Drawing.Size(94, 23)
        Me.DisableButton.TabIndex = 9
        Me.DisableButton.Text = "&Disable Vehicle"
        Me.DisableButton.UseVisualStyleBackColor = True
        '
        'AddVehicleButton
        '
        Me.AddVehicleButton.Location = New System.Drawing.Point(180, 119)
        Me.AddVehicleButton.Name = "AddVehicleButton"
        Me.AddVehicleButton.Size = New System.Drawing.Size(94, 23)
        Me.AddVehicleButton.TabIndex = 8
        Me.AddVehicleButton.Text = "&Add Vehicle"
        Me.AddVehicleButton.UseVisualStyleBackColor = True
        '
        'CMULabel
        '
        Me.CMULabel.AutoSize = True
        Me.CMULabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMULabel.Location = New System.Drawing.Point(141, 77)
        Me.CMULabel.Name = "CMULabel"
        Me.CMULabel.Size = New System.Drawing.Size(177, 20)
        Me.CMULabel.TabIndex = 7
        Me.CMULabel.Text = "CMU Parking System"
        '
        'StudentPortalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 451)
        Me.Controls.Add(Me.CapacityButton)
        Me.Controls.Add(Me.SemesterButton)
        Me.Controls.Add(Me.MonthlyButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.DisableButton)
        Me.Controls.Add(Me.AddVehicleButton)
        Me.Controls.Add(Me.CMULabel)
        Me.Name = "StudentPortalForm"
        Me.Text = "StudentPortalForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CapacityButton As Button
    Friend WithEvents SemesterButton As Button
    Friend WithEvents MonthlyButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DisableButton As Button
    Friend WithEvents AddVehicleButton As Button
    Friend WithEvents CMULabel As Label
End Class
