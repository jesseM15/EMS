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
        initSession()
        user = dbems.getSession(5)
        time.workPeriodLength = admin.workPeriod
        initNavigationPanel()
    End Sub

    Private Sub initNavigationPanel()
        tmiClockInOut.Enabled = True
        tmiEmployee.Enabled = True
        tmiLogInOut.Text = "Log Out"
        If dbems.isClockedIn(user.id) = True Then
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

    Public Sub hidePanels()
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
                hidePanels()
                initNavigationPanel()
            End If
        End If
    End Sub

    Private Sub tmiClockInOut_Click(sender As Object, e As EventArgs) Handles tmiClockInOut.Click
        If dbems.isClockedIn(user.id) = True Then
            dbems.clockOut(user.id)
            tmiClockInOut.Text = "Clock In"
        Else
            dbems.clockIn(user.id, user.current_pay_rate)
            tmiClockInOut.Text = "Clock Out"
        End If

    End Sub

    Private Sub tmiExit_Click(sender As Object, e As EventArgs) Handles tmiExit.Click
        MessageBox.Show(time.findMondayDate(dbems.getFirstWorkDate()))
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
        hidePanels()
        mngVac.initManageVacationsPanel()
    End Sub

    Private Sub tmiReports_Click(sender As Object, e As EventArgs) Handles tmiReports.Click, btnReports.Click
        hidePanels()
        report.initReportsPanel()
        report.cboReports.SelectedIndex = 0
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
        dbems.sendMessage(m)
        MessageBox.Show("Vacation request submitted.")
        vacReq.initVacationRequestPanel()
    End Sub

    Private Sub btnInbox_Click(sender As Object, e As EventArgs) Handles btnInbox.Click
        If msgs.view = "Inbox" Then Exit Sub
        msgs.view = "Inbox"
        msgs.initMessagesPanel()
    End Sub

    Private Sub btnSent_Click(sender As Object, e As EventArgs) Handles btnSent.Click
        If msgs.view = "Sent" Then Exit Sub
        msgs.view = "Sent"
        msgs.initMessagesPanel()
    End Sub

    Private Sub btnViewed_Click(sender As Object, e As EventArgs) Handles btnViewed.Click
        If msgs.view = "Viewed" Then Exit Sub
        msgs.view = "Viewed"
        msgs.initMessagesPanel()
    End Sub

    Private Sub btnChangePasswordOK_Click(sender As Object, e As EventArgs) Handles btnChangePasswordOK.Click
        If dbems.checkLogIn(user.user_name, txtCurrentPassword.Text) = True Then
            If txtNewPassword.Text = txtRetypePassword.Text Then
                dbems.changePassword(user.id, txtNewPassword.Text)
                lblChangePasswordMessage.ForeColor = Color.Green
                lblChangePasswordMessage.Text = "Password Successfully Changed."
            Else
                lblChangePasswordMessage.ForeColor = Color.Red
                lblChangePasswordMessage.Text = "Error retyping new password."
            End If
        Else
            lblChangePasswordMessage.ForeColor = Color.Red
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
        If e.RowIndex = -1 Then Exit Sub
        employees.employeeID = dgvEmployees.Rows(e.RowIndex).Cells.Item(2).Value
        If e.ColumnIndex = 0 Then
            hidePanels()
            employees.initEditEmployeePanel()
        ElseIf e.ColumnIndex = 1 Then
            Dim msg As String = "Are you sure you want to remove employee " & dbems.getUserName(employees.employeeID) & "?"
            Dim deleteEmployee As MsgBoxResult = MsgBox(msg, MsgBoxStyle.YesNo, "Terminate Employee?")
            If deleteEmployee = MsgBoxResult.Yes Then
                dbems.removeUser(employees.employeeID)
                hidePanels()
                employees.initViewEmployeesPanel()
            End If
        End If
    End Sub

    Private Sub dgvManageVacations_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvManageVacations.CellContentClick
        If e.RowIndex = -1 Then Exit Sub
        Dim uid As Integer = dgvManageVacations.Rows(e.RowIndex).Cells.Item(2).Value
        Dim tid As Integer = dgvManageVacations.Rows(e.RowIndex).Cells.Item(3).Value
        Dim name As String = dgvManageVacations.Rows(e.RowIndex).Cells.Item(4).Value & " " & dgvManageVacations.Rows(e.RowIndex).Cells.Item(5).Value
        Dim rDate As Date = dgvManageVacations.Rows(e.RowIndex).Cells.Item(6).Value
        If e.ColumnIndex = 0 Then
            If dbems.getVacationTime(uid) >= 8 Then
                mngVac.approveVacation(uid, tid, _
                    "Your vacation request for " & rDate & " has been approved.", _
                    "Vacation request for " & name & " on " & rDate & " has been approved.")
            Else
                mngVac.denyVacation(uid, tid, _
                    "Your vacation request for " & rDate & " has been denied.", _
                    "Not enough vacation time remaining.")
            End If
        ElseIf e.ColumnIndex = 1 Then
            mngVac.denyVacation(uid, tid, _
                "Your vacation request for " & rDate & " has been denied.", _
                "Vacation request for " & name & " on " & rDate & " has been denied.")
        End If
    End Sub

    Private Sub btnEditEmployee_Click(sender As Object, e As EventArgs) Handles btnEditEmployee.Click
        If employees.employeeID = 0 Then
            dbems.addUser(employees.getFormData())
        Else
            dbems.updateUser(employees.getFormData())
        End If
        hidePanels()
        employees.initViewEmployeesPanel()
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        hidePanels()
        employees.employeeID = 0
        employees.initEditEmployeePanel()
    End Sub

    Private Sub lsvMessages_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lsvMessages.ItemSelectionChanged
        If e.IsSelected Then
            Dim caption As String = msgs.view & " Message"
            Dim msg As String = lsvMessages.Columns(0).Text & ": " & e.Item.SubItems(0).Text & " on "
            msg += e.Item.SubItems(1).Text & vbCrLf & vbCrLf
            msg += e.Item.SubItems(2).Text
            MessageBox.Show(msg, caption)
        End If
    End Sub

End Class
