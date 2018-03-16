Public Class CheckInForm
    Dim DB As New DBAccessClass
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'close the window
        Me.Close()
    End Sub

    Private Sub SwipeButton_Click(sender As Object, e As EventArgs) Handles SwipeButton.Click
        'declase variables for use
        Dim UserIDString, ParkingLotInstanceString, YearString, MonthString, DayString, HourString, MinuteString, SecondString, SwipeString, MaxParkingString As String
        Dim MonthInteger, DayInteger, HourInteger, MinuteInteger, SecondInteger As Integer
        Dim CheckOutInteger As Int64

        'fill userIdstring and ParkingLotString
        UserIDString = UserIDTextBox.Text
        'get most recent parking lot instance id
        DB.AddParam("@parkinglotid", ParkingLotTextBox.Text.ToString)
        DB.ExecuteQuery("SELECT MAX(ParkingLotInstanceID) FROM ParkingLot WHERE ParkingLotID = ?")
        ParkingLotInstanceString = DB.DBDataTable.Rows(0).Item("MAX(ParkingLotInstanceID)").ToString

        'concat swipe string, while testing to make sure that the string remains a constant length
        'initial fill
        YearString = Today.Year
        MonthString = Today.Month
        DayString = Today.Day
        HourString = TimeOfDay.Hour
        MinuteString = TimeOfDay.Minute
        SecondString = TimeOfDay.Second
        'fix single digit month, day, hour, minute and second strings
        MonthInteger = Integer.Parse(MonthString)
        DayInteger = Integer.Parse(DayString)
        HourInteger = Integer.Parse(HourString)
        MinuteInteger = Integer.Parse(MinuteString)
        SecondInteger = Integer.Parse(SecondString)

        If MonthInteger < 10 Then
            MonthString = 0 & MonthString
        End If
        If DayInteger < 10 Then
            DayString = 0 & DayString
        End If
        If HourInteger < 10 Then
            HourString = 0 & HourString
        End If
        If MinuteInteger < 10 Then
            MinuteString = 0 & MinuteString
        End If
        If SecondInteger < 10 Then
            SecondString = 0 & SecondString
        End If
        'concat into swipe string
        SwipeString = YearString & MonthString & DayString & HourString & MinuteString & SecondString

        'begin sql statements

        'declare params
        DB.AddParam("@user_id", UserIDString)
        DB.AddParam("@ParkingLotID", ParkingLotInstanceString)
        DB.AddParam("@Swipe", SwipeString)
        DB.ExecuteQuery("SELECT MAX(ParkingID) FROM Parking WHERE UserID LIKE ? AND ParkingLotInstanceID LIKE ?")
        MaxParkingString = DB.DBDataTable.Rows(0).Item("MAX(ParkingID)").ToString
        'check to see if they have a record associated with the parkinglot and userid
        If String.IsNullOrEmpty(MaxParkingString) Then

            'if they have not insert their record
            DB.AddParam("@ParkingLotID", ParkingLotInstanceString)
            DB.AddParam("@user_id", UserIDString)
            DB.AddParam("@Swipe", SwipeString)
            DB.ExecuteQuery("INSERT INTO Parking (ParkingLotInstanceID, UserID, CheckInTime, CheckOutTime) VALUES(?,?,?,0)")
            MessageBox.Show("Check In Complete ")
        Else
            'if they have check the check out column to see if it is 0
            DB.AddParam("ParkingID", MaxParkingString)
            DB.ExecuteQuery("SELECT CheckOutTime FROM Parking WHERE ParkingID LIKE ?")
            CheckOutInteger = Int64.Parse(DB.DBDataTable.Rows(0).Item("CheckOutTime"))
            If CheckOutInteger = 0 Then
                'if it is then update to fill column
                DB.AddParam("@ParkingLotID", ParkingLotInstanceString)
                DB.AddParam("@user_id", UserIDString)
                DB.AddParam("@Swipe", SwipeString)
                DB.AddParam("ParkingID", MaxParkingString)
                DB.ExecuteQuery("UPDATE PARKING SET ParkingLotInstanceID = ?, UserID = ?, CheckOutTime = ? WHERE ParkingID LIKE ?")
                MessageBox.Show("Check Out Complete")
            Else
                'if it is not then insert new row
                DB.AddParam("@ParkingLotID", ParkingLotInstanceString)
                DB.AddParam("@user_id", UserIDString)
                DB.AddParam("@Swipe", SwipeString)
                DB.AddParam("ParkingID", MaxParkingString)
                DB.ExecuteQuery("INSERT INTO Parking (ParkingLotInstanceID, UserID, CheckInTime, CheckOutTime) VALUES(?,?,?,0)")
                MessageBox.Show("Check In Complete")
            End If
        End If
    End Sub
End Class