Public Class CreateParkingLotForm
    Dim ParkingLotNameString, StreetAddressString, BillStartTimeString, BillEndTimeString, CapacityString, PriceString As String
    Dim CapacityInteger, BillingStartInteger, BillingEndInteger As Integer
    Dim priceDecimal As Decimal


    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        ParkingLotNameString = ParkingLotNameTextBox.Text
        StreetAddressString = StreetAddressTextBox.Text

        'create capacity string
        Try
            CapacityInteger = Integer.Parse(CapacityTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Capacity must be numeric and a whole number.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        If CapacityInteger < 1 Then
            MessageBox.Show("Capacity must be greater than 1.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            CapacityString = CapacityInteger.ToString
        End If

        'create price variable
        PriceString = (PriceCentComboBox.Text & "." & PriceCentComboBox.Text)

        If priceDecimal = Decimal.Parse(PriceString) <= 0 Then
            MessageBox.Show("You must enter a price for parking", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'format billing start time
        If BeginBillAMPMComboBox.Text = "AM" Then
            BillStartTimeString = (BeginBillHourComboBox.Text & BeginBillMinuteComboBox.Text & "00")
        Else
            BillingStartInteger = Integer.Parse(BeginBillHourComboBox.Text) + 12
            If BillingStartInteger = 24 Then
                BillStartTimeString = ("00" & BeginBillMinuteComboBox.Text & "00")
            Else
                BillStartTimeString = (BillingStartInteger.ToString & BeginBillMinuteComboBox.Text & 0)
            End If
        End If

        'formet bill end time
        If EndBillAMPMComboBox.Text = "AM" Then
            BillEndTimeString = (EndBillHourComboBox.Text & EndBillMinuteComboBox.Text & "00")
        Else
            BillingEndInteger = Integer.Parse(EndBillHourComboBox.Text) + 12
            If BillingEndInteger = 24 Then
                BillEndTimeString = ("00" & EndBillMinuteComboBox.Text & "00")
            Else
                BillEndTimeString = (BillingEndInteger.ToString & EndBillMinuteComboBox.Text & "00")
            End If
        End If

        If BillingStartInteger = (Integer.Parse(BillStartTimeString)) < BillingEndInteger = Integer.Parse(BillEndTimeString) Then
            MessageBox.Show("Billing Start Time must be before Billing End Time", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Test1Label.Text = BillStartTimeString
    End Sub

    Private Sub ConstantBillingCheckBox_MouseUp(sender As Object, e As MouseEventArgs) Handles ConstantBillingCheckBox.MouseUp
        'uncheck disable billing.  You can not have both boxes checked at the same time
        DisableBillingCheckBox.Checked = False
        'check constant billing
        ConstantBillingCheckBox.Checked = True
    End Sub

    Private Sub DisableBillingCheckBox_MouseUp(sender As Object, e As MouseEventArgs) Handles DisableBillingCheckBox.MouseUp
        'uncheck constant billing. You can not have both boxes checked at the same time
        ConstantBillingCheckBox.Checked = False
        'check disable billing
        DisableBillingCheckBox.Checked = True
    End Sub
End Class