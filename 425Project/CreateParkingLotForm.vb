Public Class CreateParkingLotForm
    Dim DB As New DBAccessClass
    Dim ParkingLotNameString, StreetAddressString, BillStartTimeString, BillEndTimeString, CapacityString, PriceString, ConstantParkingString, DisableParkingString, ValidityStartDateString, YearString, MonthString, DayString, DollarString, CentString As String
    Dim CapacityInteger, BillingStartInteger, BillingEndInteger, ParkingLotIDInteger, MonthInteger, DayInteger As Integer
    Dim priceDecimal As Decimal

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'clear form and reset focus to parking lot name
        PriceDollarComboBox.SelectedIndex = 0
        PriceCentComboBox.SelectedIndex = 0
        BeginBillHourComboBox.SelectedIndex = 0
        BeginBillMinuteComboBox.SelectedIndex = 0
        BeginBillAMPMComboBox.SelectedIndex = 0
        EndBillHourComboBox.SelectedIndex = 0
        EndBillMinuteComboBox.SelectedIndex = 0
        EndBillAMPMComboBox.SelectedIndex = 0
        ConstantBillingCheckBox.Checked = False
        DisableBillingCheckBox.Checked = False
        CapacityTextBox.Clear()
        StreetAddressTextBox.Clear()
        With ParkingLotNameTextBox
            .Clear()
            .Focus()
        End With

        ParkingLotNameString = ""
        StreetAddressString = ""
        priceDecimal = 0
        PriceString = ""
        BillingStartInteger = 0
        BillStartTimeString = ""
        BillingEndInteger = 0
        BillEndTimeString = ""
        ConstantParkingString = ""
        DisableParkingString = ""
        CapacityInteger = 0
        CapacityString = ""
        ValidityStartDateString = ""


    End Sub

    Private Sub CreateParkingLotForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set all combo boxes to 0 as default
        PriceDollarComboBox.SelectedIndex = 0
        PriceCentComboBox.SelectedIndex = 0
        BeginBillHourComboBox.SelectedIndex = 0
        BeginBillMinuteComboBox.SelectedIndex = 0
        BeginBillAMPMComboBox.SelectedIndex = 0
        EndBillHourComboBox.SelectedIndex = 0
        EndBillMinuteComboBox.SelectedIndex = 0
        EndBillAMPMComboBox.SelectedIndex = 0
        ConstantBillingCheckBox.Checked = False
        DisableBillingCheckBox.Checked = False
    End Sub




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
        DollarString = PriceDollarComboBox.Text
        CentString = PriceCentComboBox.Text
        PriceString = DollarString & "." & CentString
        priceDecimal = Decimal.Parse(PriceString)

        If priceDecimal <= 0 Then
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
            Exit Sub
        End If

        'check to make sure that there is an address
        If String.IsNullOrWhiteSpace(StreetAddressString) Then
            MessageBox.Show("Please enter an address.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With StreetAddressTextBox
                .Clear()
                .Focus()
                Exit Sub
            End With
        End If

        'determine parkinglotid
        'find current highest lot id
        DB.ExecuteQuery("SELECT MAX(ParkingLotID) FROM ParkingLot")
        ParkingLotIDInteger = DB.DBDataTable.Rows(0).Item("MAX(ParkingLotID)")
        'iterate up one
        ParkingLotIDInteger = ParkingLotIDInteger + 1

        If DisableBillingCheckBox.Checked = True Then
            DisableParkingString = 1
        Else
            DisableParkingString = 0
        End If

        If ConstantBillingCheckBox.Checked = True Then
            ConstantParkingString = 1
        Else
            ConstantParkingString = 0
        End If

        'set validity start date
        'concat swipe string, while testing to make sure that the string remains a constant length
        'initial fill
        YearString = Today.Year
        MonthString = Today.Month
        DayString = Today.Day
        'fix single digit month, day, hour, minute and second strings
        MonthInteger = Integer.Parse(MonthString)
        DayInteger = Integer.Parse(DayString)
        If MonthInteger < 10 Then
            MonthString = 0 & MonthString
        End If
        If DayInteger < 10 Then
            DayString = 0 & DayString
        End If

        ValidityStartDateString = YearString & MonthString & DayString

        'set params for insert statement
        DB.AddParam("@ParkingLotID", ParkingLotIDInteger.ToString)
        DB.AddParam("@PParkingLotName", ParkingLotNameString)
        DB.AddParam("@StreetAddress", StreetAddressString)
        DB.AddParam("@Capacity", CapacityString)
        DB.AddParam("@Price", PriceString)
        DB.AddParam("@BillStartTime", BillStartTimeString)
        DB.AddParam("@BillEndTime", BillEndTimeString)
        DB.AddParam("@24HourCharge", ConstantParkingString)
        DB.AddParam("@DisableTIcketing", DisableParkingString)
        DB.AddParam("@ValidityStartDate", ValidityStartDateString)
        DB.AddParam("@Enabled", "1")
        'perform insert
        Try
            DB.ExecuteQuery("INSERT INTO ParkingLot(ParkingLotID, ParkingLotName, StreetAddress, Capacity, Price, BillStartTime, BillEndTime, 24HourCharge, DisableTicketing, ValidityStartDate) VALUES(?,?,?,?,?,?,?,?,?,?)")
            'messagebox iff successful
            MessageBox.Show("Parking Lot Creation Successfull")
        Catch ex As Exception
            MessageBox.Show("Parking Lot Creation Failed")
            Exit Sub
        End Try

        'reset form for new entry
        PriceDollarComboBox.SelectedIndex = 0
        PriceCentComboBox.SelectedIndex = 0
        BeginBillHourComboBox.SelectedIndex = 0
        BeginBillMinuteComboBox.SelectedIndex = 0
        BeginBillAMPMComboBox.SelectedIndex = 0
        EndBillHourComboBox.SelectedIndex = 0
        EndBillMinuteComboBox.SelectedIndex = 0
        EndBillAMPMComboBox.SelectedIndex = 0
        ConstantBillingCheckBox.Checked = False
        DisableBillingCheckBox.Checked = False
        StreetAddressTextBox.Clear()
        With ParkingLotNameTextBox
            .Clear()
            .Focus()
        End With

        ParkingLotNameString = ""
        StreetAddressString = ""
        priceDecimal = 0
        PriceString = ""
        BillingStartInteger = 0
        BillStartTimeString = ""
        BillingEndInteger = 0
        BillEndTimeString = ""
        ConstantParkingString = ""
        DisableParkingString = ""
        CapacityInteger = 0
        CapacityString = ""
        ValidityStartDateString = ""

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
End Class