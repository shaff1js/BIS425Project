Public Class EditDisableParkingLotForm
    Dim DB As New DBAccessClass
    Dim ParkingLotNameString, StreetAddressString, BillStartTimeString, BillEndTimeString, CapacityString, PriceString, ConstantParkingString, DisableParkingString, ValidityStartDateString, ValidityEndDateString, YearString, MonthString, DayString, DollarString, CentString, InstanceString, HourString, MinuteString, AMPMString As String

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

    Private Sub ConstantBillingCheckBox_MouseUp(sender As Object, e As MouseEventArgs) Handles ConstantBillingCheckBox.Checked

        'uncheck disable billing.  You can not have both boxes checked at the same time
        DisableBillingCheckBox.Checked = False
        'check constant billing
        ' ConstantBillingCheckBox.Checked = True

    End Sub

    Private Sub DisableBillingCheckBox_MouseUp(sender As Object, e As MouseEventArgs) Handles DisableBillingCheckBox.CheckedChanged

        'uncheck constant billing. You can not have both boxes checked at the same time
        ConstantBillingCheckBox.Checked = False
        'check disable billing
        'DisableBillingCheckBox.Checked = True

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
       
        'convert hour string to integer
        HourString = Microsoft.VisualBasic.Left(BillStartTimeString, 2)
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
            HourString = "0" & HourInteger.ToString
                MinuteString = Microsoft.VisualBasic.Right(BillStartTimeString, 4)
                MinuteString = Microsoft.VisualBasic.Left(MinuteString, 2)
                BeginBillHourComboBox.Text = HourString
                BeginBillMinuteComboBox.Text = MinuteString
                BeginBillAMPMComboBox.Text = "PM"
        ElseIf HourInteger = 0 Then
            HourString = "00"
            MinuteString = Microsoft.VisualBasic.Right(BillStartTimeString, 4)
            MinuteString = Microsoft.VisualBasic.Left(MinuteString, 2)
            BeginBillHourComboBox.Text = HourString
            BeginBillMinuteComboBox.Text = MinuteString
            BeginBillAMPMComboBox.Text = "AM"
        End If

        'populate bill end time
        'convert hour string to integer
        HourString = Microsoft.VisualBasic.Left(BillEndTimeString, 2)
        HourInteger = Integer.Parse(HourString)
        If HourInteger = 12 Then
            HourString = HourInteger.ToString
            MinuteString = Microsoft.VisualBasic.Right(BillEndTimeString, 4)
            MinuteString = Microsoft.VisualBasic.Left(MinuteString, 2)
            EndBillHourComboBox.Text = HourString
            EndBillMinuteComboBox.Text = MinuteString
            EndBillAMPMComboBox.Text = "PM"
        ElseIf HourInteger < 12 Then
            HourString = Microsoft.VisualBasic.Left(BillEndTimeString, 2)
            MinuteString = Microsoft.VisualBasic.Right(BillEndTimeString, 4)
            MinuteString = Microsoft.VisualBasic.Left(MinuteString, 2)
            EndBillHourComboBox.Text = HourString
            EndBillMinuteComboBox.Text = MinuteString
            EndBillAMPMComboBox.Text = "AM"
        ElseIf HourInteger > 12 Then
            HourInteger = HourInteger - 12
            HourString = "0" & HourInteger.ToString
            MinuteString = Microsoft.VisualBasic.Right(BillEndTimeString, 4)
            MinuteString = Microsoft.VisualBasic.Left(MinuteString, 2)
            EndBillHourComboBox.Text = HourString
            EndBillMinuteComboBox.Text = MinuteString
            EndBillAMPMComboBox.Text = "PM"
        ElseIf HourInteger = 0 Then
            HourString = "00"
            MinuteString = Microsoft.VisualBasic.Right(BillEndTimeString, 4)
            MinuteString = Microsoft.VisualBasic.Left(MinuteString, 2)
            EndBillHourComboBox.Text = HourString
            EndBillMinuteComboBox.Text = MinuteString
            EndBillAMPMComboBox.Text = "AM"
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
            'save updated information
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
            ValidityEndDateString = YearString & MonthString & DayString

            'update old parking lot instance with validity end date
            DB.AddParam("@ParkingLotID", ParkingLotIDComboBox.Text)
            DB.ExecuteQuery("SELECT MAX(ParkingLotInstanceID) FROM ParkingLot WHERE ParkingLotID LIKE ?")
            InstanceString = DB.DBDataTable.Rows(0).Item("MAX(ParkingLotInstanceID)")

            DB.AddParam("@ValidityEndDate", ValidityEndDateString)
            DB.AddParam("@ParkingLotInstanceID", InstanceString)
            DB.ExecuteQuery("UPDATE ParkingLot SET ValidityEndDate = ? WHERE ParkingLotInstanceID LIKE ?")

            'set parking lot id string
            ParkingLotIDInteger = Integer.Parse(ParkingLotIDComboBox.Text)
            'set params for insert statement for new parking lot

            DB.AddParam("@ParkingLotID", ParkingLotIDInteger.ToString)
            DB.AddParam("@ParkingLotName", ParkingLotNameString)
            DB.AddParam("@StreetAddress", StreetAddressString)
            DB.AddParam("@Capacity", CapacityString)
            DB.AddParam("@Price", PriceString)
            DB.AddParam("@BillStartTime", BillStartTimeString)
            DB.AddParam("@BillEndTime", BillEndTimeString)
            DB.AddParam("@24HourCharge", ConstantParkingString)
            DB.AddParam("@DisableTIcketing", DisableParkingString)
            DB.AddParam("@ValidityEndDate", ValidityStartDateString)
            DB.AddParam("@Enabled", "1")

            'perform insert
            Try
                DB.ExecuteQuery("INSERT INTO ParkingLot(ParkingLotID, ParkingLotName, StreetAddress, Capacity, Price, BillStartTime, BillEndTime, 24HourCharge, DisableTicketing, ValidityStartDate, Enabled) VALUES(?,?,?,?,?,?,?,?,?,?,?)")
                'messagebox iff successful
                MessageBox.Show("Parking Lot Edited Successfull")
            Catch ex As Exception
                MessageBox.Show("Parking Lot Edit Failed")
                Exit Sub
            End Try

            'disable form after save
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


            EditSaveButton.Text = "Edit"
            DisableEnableButton.Enabled = True
        End If

        '
    End Sub

End Class