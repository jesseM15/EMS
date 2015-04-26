﻿Imports DBlib.DBSQL
Imports EMSlib.EMS

Public Class Form1

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
        pnlChangePassword.Visible = False
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
        pay.initPaySlipPanel()
        cboWorkPeriod.SelectedIndex = 0
    End Sub

    Private Sub tmiRequestVacation_Click(sender As Object, e As EventArgs) Handles tmiRequestVacation.Click, btnRequestVacation.Click
        hidePanels()
        vacReq.initVacationRequestPanel()
    End Sub

    Private Sub tmiViewMessages_Click(sender As Object, e As EventArgs) Handles tmiViewMessages.Click, btnViewMessages.Click
        hidePanels()
        msgs.initMessagesPanel()
    End Sub

    Private Sub tmiChangePassword_Click(sender As Object, e As EventArgs) Handles tmiChangePassword.Click, btnChangePassword.Click
        hidePanels()
        pnlChangePassword.Visible = True
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
        msgs.view = "Inbox"
        msgs.initMessagesPanel()
    End Sub

    Private Sub btnSent_Click(sender As Object, e As EventArgs) Handles btnSent.Click
        msgs.view = "Sent"
        msgs.initMessagesPanel()
    End Sub

    Private Sub btnChangePasswordOK_Click(sender As Object, e As EventArgs) Handles btnChangePasswordOK.Click
        If dbems.checkLogIn(user.user_name, txtCurrentPassword.Text) = True Then
            If txtNewPassword.Text = txtRetypePassword.Text Then
                dbems.changePassword(user.id, txtNewPassword.Text)
                lblChangePasswordMessage.Text = "Password Successfully Changed."
            Else
                lblChangePasswordMessage.Text = "Error retyping new password."
            End If
        Else
            lblChangePasswordMessage.Text = "Current password incorrect."
        End If
    End Sub

    Private Sub cboWorkPeriod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboWorkPeriod.SelectedIndexChanged
        hidePanels()
        pay.workPeriodStart = pay.employedDates.Item(cboWorkPeriod.SelectedIndex + 1)
        pay.workPeriodEnd = pay.workPeriodStart.AddDays(time.workPeriodLength).AddMinutes(-1)
        pay.initPaySlipPanel()
    End Sub
End Class
