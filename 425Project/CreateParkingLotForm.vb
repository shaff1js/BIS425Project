Public Class CreateParkingLotForm
    Dim ParkingLotNameString, StreetAddressString As String
    Dim CapacityInteger, BillingStartTime, BillingEndTime As Integer
    Dim PriceDecimal As Decimal

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        ParkingLotNameString = ParkingLotNameTextBox.Text
        StreetAddressString = StreetAddressTextBox.Text
        CapacityInteger = Integer.Parse(CapacityTextBox.Text)
        PriceDecimal = Decimal.Parse(PriceDollarComboBox.Text & PriceCentComboBox.Text)
        BillingStartTime = Integer.Parse(BeginBillHourComboBox.Text & BeginBillMinuteComboBox.Text)
        BillingEndTime = Integer.Parse(EndBillHourComboBox.Text & EndBillMinuteComboBox.Text)

        Test1Label.Text = BillingStartTime.ToString
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