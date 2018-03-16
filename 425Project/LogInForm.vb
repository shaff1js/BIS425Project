Public Class LogInForm
    Dim DB As New DBAccessClass
    Friend UserIDStringFriend As String
    Private Sub RegisterLabel_Click(sender As Object, e As EventArgs) Handles RegisterLabel.Click
        AddUserForm.ShowDialog()
    End Sub

    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click
        'log into the system and filter to the user or admin portals
        'declare variables
        Dim UserNameString, PasswordString, RoleString As String
        Dim RecordCount As Integer
        'fill variables from textboxes
        UserNameString = UserNameTextBox.Text
        PasswordString = PasswordMaskedTextBox.Text
        'declare parameters
        DB.AddParam("@Password", PasswordString)
        DB.AddParam("@UserName", UserNameString)
        DB.AddParam("@UserName", UserNameString)

        'check username and password against database
        DB.ExecuteQuery("SELECT COUNT(*) FROM User WHERE Password LIKE ? AND UserID LIKE ? OR GlobalID LIKE ?")
        RecordCount = Integer.Parse(DB.DBDataTable.Rows(0).Item("COUNT(*)").ToString)
        If RecordCount <> 1 Then
            'if they do not match
            MessageBox.Show("User Name or Password is Incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With UserNameTextBox
                .Clear()
                .Focus()
            End With
            PasswordMaskedTextBox.Clear()
            Exit Sub
            'if they do match
        Else
            'filter to portal
            DB.AddParam("@Password", PasswordString)
            DB.AddParam("@UserName", UserNameString)
            DB.AddParam("@UserName", UserNameString)
            DB.ExecuteQuery("SELECT Role FROM User WHERE Password LIKE ? AND UserID LIKE ? OR GlobalID LIKE ?")
            RoleString = DB.DBDataTable.Rows(0).Item("Role").ToString
        End If
        If RoleString = "1" Then
            StudentPortalForm.ShowDialog()
        Else
            AdminPortalForm.ShowDialog()
        End If
        'set useridfriendstring value
        DB.AddParam("@Password", PasswordString)
        DB.AddParam("@UserName", UserNameString)
        DB.AddParam("@UserName", UserNameString)
        DB.ExecuteQuery("SELECT UserID FROM User WHERE Password LIKE ? AND UserID LIKE ? OR GlobalID LIKE ?")
        UserIDStringFriend = DB.DBDataTable.Rows(0).Item("UserID").ToString
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        CheckInForm.Show()
    End Sub
End Class
