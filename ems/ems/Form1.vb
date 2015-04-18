Imports DBlib.DBSQL
Imports EMSlib.EMS

Public Class Form1
    Public dbems As New DbConnection(My.Settings.DbEmsConnectionString)
    Public user As New User
    Public time As New Time
    Public vacReq As New VacationRequest
    Public messages As New Messages

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Show()
        tmiClockInOut.Enabled = False
        tmiEmployee.Enabled = False
        hidePanels()
        '**Disabled for development**
        'Login.ShowDialog()
        'If user.id > 0 Then
        'initializeNavigationPanel()
        'End If
        '**Uncomment and remove following lines during testing**
        user = dbems.getSession(1)
        initNavigationPanel()

    End Sub

    Private Sub initNavigationPanel()
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

    Private Sub hidePanels()
        pnlPaySlip.Visible = False
        pnlRequestVacation.Visible = False
        pnlMessages.Visible = False
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
                initNavigationPanel()
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

    Private Sub tmiViewPaySlip_Click(sender As Object, e As EventArgs) Handles tmiViewPaySlip.Click, btnViewPaySlip.Click
        hidePanels()
        Dim payslip As New PaySlip()
        payslip.initPaySlipPanel()
    End Sub

    Private Sub tmiRequestVacation_Click(sender As Object, e As EventArgs) Handles tmiRequestVacation.Click, btnRequestVacation.Click
        hidePanels()
        vacReq.initVacationRequestPanel()
    End Sub

    Private Sub tmiViewMessages_Click(sender As Object, e As EventArgs) Handles tmiViewMessages.Click, btnViewMessages.Click
        hidePanels()
        messages.initMessagesPanel()
    End Sub

    Private Sub tmiChangePassword_Click(sender As Object, e As EventArgs) Handles tmiChangePassword.Click, btnChangePassword.Click
        '!!!TEMPORARY!!! CHANGE THIS CODE (WRITTEN FOR TESTING)
        Dim arf As New TimeSpan
        arf = dbems.getHoursWorked(user.id, "Regular", time.workWeekStart, time.workWeekEnd)
        MessageBox.Show("Weekly Hours: " & arf.Hours + (arf.Days * 24) & ":" & arf.Minutes & ":" & arf.Seconds)

        '!!!TEMPORARY!!! CHANGE THIS CODE (WRITTEN FOR TESTING)
        Dim h As Decimal = dbems.getHoursWorked(user.id, "Regular", time.workWeekStart, time.workWeekEnd).TotalHours
        Dim hourlyPay As Decimal = user.pay_rate / 52 / 40
        Dim pay As Decimal = hourlyPay * h
        MessageBox.Show("Weekly Pay: " & pay.ToString("C2"))
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        vacReq.dateRequested = e.Start
        Dim dateEnd As Date = e.End
        If vacReq.dateRequested.Date = dateEnd.Date Then
            lblDateRequested.Text = "Vacation Date: " & vacReq.dateRequested.Date
        Else
            lblDateRequested.Text = "Vacation Date: " & vacReq.dateRequested.Date & " - " & dateEnd.Date
        End If
    End Sub

    Private Sub btnInbox_Click(sender As Object, e As EventArgs) Handles btnInbox.Click
        messages.view = "Inbox"
        messages.initMessagesPanel()
    End Sub

    Private Sub btnSent_Click(sender As Object, e As EventArgs) Handles btnSent.Click
        messages.view = "Sent"
        messages.initMessagesPanel()
    End Sub
End Class
