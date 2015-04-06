Imports DBlib.DBSQL
Imports EMSlib.EMS

Public Class Form1
    Private dbems As New Dbconnection(My.Settings.DbEmsConnectionString)
    Public user As New User
    Public time As New Time

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Show()
        tmiClockInOut.Enabled = False
        tmiEmployee.Enabled = False
        Login.ShowDialog()
        If user.id > 0 Then
            initializeNavigationPanel()
        End If

    End Sub

    Private Sub initializeNavigationPanel()
        tmiClockInOut.Enabled = True
        tmiEmployee.Enabled = True
        tmiLogInOut.Text = "Log Out"
        If dbems.checkClockedIn(user.id) = True Then
            tmiClockInOut.Text = "Clock Out"
        Else
            tmiClockInOut.Text = "Clock In"
        End If
        lblName.Text = user.first_name + " " + user.last_name
        lblPosition.Text = user.position
        SplitContainer1.Visible = True
    End Sub


    Private Sub tmiLogInOut_Click(sender As Object, e As EventArgs) Handles tmiLogInOut.Click
        If user.id > 0 Then
            user = New User
            tmiClockInOut.Enabled = False
            tmiEmployee.Enabled = False
            tmiLogInOut.Text = "Log In"
            SplitContainer1.Visible = False
        Else
            Login.ShowDialog()
            If user.id > 0 Then
                initializeNavigationPanel()
            End If
        End If
    End Sub

    Private Sub tmiClockInOut_Click(sender As Object, e As EventArgs) Handles tmiClockInOut.Click
        If dbems.checkClockedIn(user.id) = True Then
            dbems.clockOut(user.id)
            tmiClockInOut.Text = "Clock In"
        Else
            dbems.clockIn(user.id)
            tmiClockInOut.Text = "Clock Out"
        End If
        
    End Sub

    Private Sub tmiExit_Click(sender As Object, e As EventArgs) Handles tmiExit.Click
        Me.Close()
    End Sub

    Private Sub tmiViewPaySlip_Click(sender As Object, e As EventArgs) Handles tmiViewPaySlip.Click
        '!!!TEMPORARY!!! CHANGE THIS CODE (WRITTEN FOR TESTING)
        Dim arf As New TimeSpan
        arf = dbems.getHoursWorked(user.id)
        MessageBox.Show(arf.Hours & ":" & arf.Minutes & ":" & arf.Seconds)
    End Sub

    Private Sub tmiRequestVacation_Click(sender As Object, e As EventArgs) Handles tmiRequestVacation.Click

    End Sub

    Private Sub tmiViewMessages_Click(sender As Object, e As EventArgs) Handles tmiViewMessages.Click

    End Sub

    Private Sub tmiChangePassword_Click(sender As Object, e As EventArgs) Handles tmiChangePassword.Click

    End Sub




End Class
