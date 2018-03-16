Public Class EditDisableParkingLotForm
    Dim DB As New DBAccessClass
    Dim ParkingLotNameString, StreetAddressString, BillStartTimeString, BillEndTimeString, CapacityString, PriceString, ConstantParkingString, DisableParkingString, ValidityStartDateString, YearString, MonthString, DayString, DollarString, CentString, InstanceString, HourString, MinuteString, AMPMString As String

    Private Sub EditDisableParkingLotForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fill parking lot combobox
        'perform query
        DB.ExecuteQuery("SELECT * FROM ParkingLot")
        'clear out residual items form combobox before load
        ParkingLotIDComboBox.Items.Clear()

        ''load combobox
        For Each ADataRow As DataRow In DB.DBDataTable.Rows
            ParkingLotIDComboBox.Items.Add(ADataRow("ParkingLotID"))
        Next
        If DB.RecordCount > 0 Then
            ParkingLotIDComboBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub ConstantBillingCheckBox_MouseUp(sender As Object, e As MouseEventArgs) Handles ConstantBillingCheckBox.MouseClick
        'uncheck disable billing.  You can not have both boxes checked at the same time
        DisableBillingCheckBox.Checked = False
        'check constant billing
        ConstantBillingCheckBox.Checked = True
    End Sub

    Private Sub DisableBillingCheckBox_MouseUp(sender As Object, e As MouseEventArgs) Handles DisableBillingCheckBox.MouseClick
        'uncheck constant billing. You can not have both boxes checked at the same time
        ConstantBillingCheckBox.Checked = False
        'check disable billing
        DisableBillingCheckBox.Checked = True
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        'select the parking lot that you want to edit. 
        'set params
        DB.AddParam("@ParkingLotID", ParkingLotIDComboBox.Text.ToString)
        'perform query to find current instance
        DB.ExecuteQuery("SELECT MAX(ParkingLotInstanceID) FROM ParkingLot WHERE ParkingLotID LIKE ?")
        InstanceString = DB.DBDataTable.Rows(0).Item("MAX(ParkingLotInstanceID)").ToString
        'load current string
        DB.AddParam("@ParkingLotInstanceID", InstanceString)
        DB.ExecuteQuery("SELECT ParkingLotName, StreetAddress, Capacity, Price, BillStartTime, BillEndTime, 24HourCharge, DisableTicketing FROM ParkingLot WHERE ParkingLotInstanceID LIKE ? ")

        'fill strings to be used 
        ParkingLotNameString = DB.DBDataTable.Rows(0).Item("ParkingLotName").ToString
        StreetAddressString = DB.DBDataTable.Rows(0).Item("StreetAddress").ToString
        CapacityString = DB.DBDataTable.Rows(0).Item("Capacity").ToString
        PriceString = DB.DBDataTable.Rows(0).Item("Price").ToString
        BillStartTimeString = DB.DBDataTable.Rows(0).Item("BillStartTime").ToString
        BillEndTimeString = DB.DBDataTable.Rows(0).Item("BillEndTime").ToString
        ConstantParkingString = DB.DBDataTable.Rows(0).Item("24HourCharge").ToString
        DisableParkingString = DB.DBDataTable.Rows(0).Item("DisableTicketing").ToString
        'fill comboboxes and textboxes
        ParkingLotNameTextBox.Text = ParkingLotNameString
        StreetAddressTextBox.Text = StreetAddressString
        CapacityTextBox.Text = CapacityString
        If ConstantParkingString = "1" Then
            ConstantBillingCheckBox.Checked = True
        ElseIf ConstantParkingString = "0" Then
            ConstantBillingCheckBox.Checked = False
        End If
        If DisableParkingString = "1" Then
            DisableBillingCheckBox.Checked = True
        ElseIf DisableParkingString = "0" Then
            DisableBillingCheckBox.Checked = False
        End If

        'populate price comboboxes
        DollarString = Microsoft.VisualBasic.Left(PriceString, 1)
        CentString = Microsoft.VisualBasic.Right(PriceString, 2)
        PriceDollarComboBox.Text = DollarString
        PriceCentComboBox.Text = CentString

        'populate bill start time combo boxes
        If BillStartTimeString.Length = 5 Then
            HourString = Microsoft.VisualBasic.Left(BillStartTimeString, 1)
            MinuteString = Microsoft.VisualBasic.Right(BillStartTimeString, 4)
            MinuteString = Microsoft.VisualBasic.Left(MinuteString, 2)
            BeginBillHourComboBox.Text = HourString
            BeginBillMinuteComboBox.Text = MinuteString
            BeginBillAMPMComboBox.Text = "AM"

        ElseIf BillStartTimeString.Length = 6 Then
            HourString = Microsoft.VisualBasic.Left(BillStartTimeString, 2)
            'convert hour string to integer
            Dim HourInteger As Integer = Integer.Parse(HourString)
            If HourInteger = 12 Then
                HourString = HourInteger.ToString
                MinuteString = Microsoft.VisualBasic.Right(BillStartTimeString, 4)
                MinuteString = Microsoft.VisualBasic.Left(MinuteString, 2)
                BeginBillHourComboBox.Text = HourString
                BeginBillMinuteComboBox.Text = MinuteString
                BeginBillAMPMComboBox.Text = "PM"
            ElseIf HourInteger < 12 Then
                HourString = Microsoft.VisualBasic.Left(BillStartTimeString, 2)
                MinuteString = Microsoft.VisualBasic.Right(BillStartTimeString, 4)
                MinuteString = Microsoft.VisualBasic.Left(MinuteString, 2)
                BeginBillHourComboBox.Text = HourString
                BeginBillMinuteComboBox.Text = MinuteString
                BeginBillAMPMComboBox.Text = "AM"
            ElseIf HourInteger > 12 Then
                HourInteger = HourInteger - 12
                HourString = HourInteger.ToString
                MinuteString = Microsoft.VisualBasic.Right(BillStartTimeString, 4)
                MinuteString = Microsoft.VisualBasic.Left(MinuteString, 2)
                BeginBillHourComboBox.Text = HourString
                BeginBillMinuteComboBox.Text = MinuteString
                BeginBillAMPMComboBox.Text = "PM"

            End If
        End If

    End Sub

    Dim CapacityInteger, BillingStartInteger, BillingEndInteger, ParkingLotIDInteger, MonthInteger, DayInteger As Integer
    Dim priceDecimal As Decimal
    Private Sub EditSaveButton_Click(sender As Object, e As EventArgs) Handles EditSaveButton.Click
        'toggle between buttons
        If EditSaveButton.Text = "Edit" Then
            EditSaveButton.Text = "Save"
            DisableEnableButton.Enabled = False

            'enable form to be edited
            PriceDollarComboBox.Enabled = True
            PriceCentComboBox.Enabled = True
            BeginBillHourComboBox.Enabled = True
            BeginBillMinuteComboBox.Enabled = True
            BeginBillAMPMComboBox.Enabled = True
            EndBillHourComboBox.Enabled = True
            EndBillMinuteComboBox.Enabled = True
            EndBillAMPMComboBox.Enabled = True
            ConstantBillingCheckBox.Enabled = True
            DisableBillingCheckBox.Enabled = True
            CapacityTextBox.ReadOnly = False
            StreetAddressTextBox.ReadOnly = False
            ParkingLotNameTextBox.ReadOnly = False

        ElseIf EditSaveButton.Text = "Save" Then
            EditSaveButton.Text = "Edit"
            DisableEnableButton.Enabled = True
        End If

        '
    End Sub

End Class