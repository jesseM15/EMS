Imports DBlib.DBSQL
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
        pnlNavigationManager.Visible = False
        tmiManage.Visible = False
        If user.user_type = "Manager" Then
            pnlNavigationManager.Visible = True
            tmiManage.Visible = True
        ElseIf user.user_type = "Administrator" Then
            pnlNavigationManager.Visible = True
            tmiManage.Visible = True

        End If
        SplitContainer1.Visible = True
    End Sub

    Private Sub hidePanels()
        pnlPaySlip.Visible = False
        pnlRequestVacation.Visible = False
        pnlMessages.Visible = False
        pnlChangePassword.Visible = False
        pnlViewEmployees.Visible = False
        pnlEditEmployee.Visible = False
        pnlManageVacations.Visible = False
        pnlReports.Visible = False
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

    Private Sub tmiViewEmployees_Click(sender As Object, e As EventArgs) Handles tmiViewEmployees.Click, btnViewEmployees.Click
        hidePanels()
        employees.initViewEmployeesPanel()
    End Sub

    Private Sub tmiManageVacations_Click(sender As Object, e As EventArgs) Handles tmiManageVacations.Click, btnManageVacations.Click

    End Sub

    Private Sub tmiReports_Click(sender As Object, e As EventArgs) Handles tmiReports.Click, btnReports.Click

    End Sub

    Private Sub calVacation_DateSelected(sender As Object, e As DateRangeEventArgs) Handles calVacation.DateSelected
        vacReq.datesRequested = vacReq.getDatesRequested(e.Start, e.End)
        txtDateList.Text = ""
        For Each d In vacReq.datesRequested
            txtDateList.Text += d.date & vbCrLf
        Next
    End Sub

    Private Sub btnSubmitRequest_Click(sender As Object, e As EventArgs) Handles btnSubmitRequest.Click
        For Each d In vacReq.datesRequested
            dbems.submitVacationRequest(user.id, d)
        Next
        Dim m As New Message
        m.userId = user.manager_id
        m.senderId = user.id
        m.message = user.first_name & " " & user.last_name & " has requested the following vacation days: "
        Dim c As Integer = 1
        While c <= vacReq.datesRequested.Count
            m.message += vacReq.datesRequested(c).date
            If c < vacReq.datesRequested.Count Then
                m.message += ", "
            Else
                m.message += "."
            End If
            c += 1
        End While
        dbems.sendVacationRequestMessage(m)
        MessageBox.Show("Vacation request submitted.")
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

    Private Sub dgvEmployees_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployees.CellContentClick
        employees.employeeID = dgvEmployees.Rows(e.RowIndex).Cells.Item(2).Value
        If e.ColumnIndex = 0 Then
            hidePanels()
            employees.initEditEmployeePanel()
            lblEditEmployee.Text = employees.employeeID
        ElseIf e.ColumnIndex = 1 Then
            MessageBox.Show("Remove employee #" & employees.employeeID)
        End If
    End Sub

End Class
