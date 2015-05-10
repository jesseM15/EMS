Imports EMSlib.EMS

Public Class ManageVacations
    Private _dgvInitialized As Boolean
    Private _employees As Collection

    Public Sub New()
        _dgvInitialized = False
        _employees = New Collection()
    End Sub

    Public Property employees As Collection
        Get
            Return _employees
        End Get
        Set(value As Collection)
            _employees = value
        End Set
    End Property

    Private Sub initDGV()
        Form1.dgvManageVacations.Columns(0).Visible = False
        Form1.dgvManageVacations.Columns(1).Visible = False
        Form1.dgvManageVacations.Columns(2).HeaderText = "First Name"
        Form1.dgvManageVacations.Columns(3).HeaderText = "Last Name"
        Form1.dgvManageVacations.Columns(4).HeaderText = "Date"

        Dim colApprove As New DataGridViewButtonColumn
        Dim colDeny As New DataGridViewButtonColumn
        colApprove.Name = "Approve"
        colApprove.HeaderText = "Approve"
        colApprove.Text = "Approve"
        colApprove.UseColumnTextForButtonValue = True
        colDeny.Name = "Deny"
        colDeny.HeaderText = "Deny"
        colDeny.Text = "Deny"
        colDeny.UseColumnTextForButtonValue = True

        Form1.dgvManageVacations.Columns.Add(colApprove)
        Form1.dgvManageVacations.Columns.Add(colDeny)

        Form1.dgvManageVacations.Columns(2).Width = 80
        Form1.dgvManageVacations.Columns(3).Width = 80
        Form1.dgvManageVacations.Columns(4).Width = 70
        Form1.dgvManageVacations.Columns(5).Width = 60
        Form1.dgvManageVacations.Columns(6).Width = 58

        _dgvInitialized = True
    End Sub

    Public Sub initManageVacationsPanel()
        Form1.dgvManageVacations.DataSource = dbems.getEmployeeRequests(user.id)
        If _dgvInitialized = False Then
            initDGV()
        End If
        _employees = dbems.getEmployeeIds(user.id)
        For Each employee In _employees
            For Each rDay In dbems.getVacationRequests(employee)
                Form1.calManageVacations.AddBoldedDate(rDay)
            Next
            For Each vDay In dbems.getScheduledVacation(employee)
                Form1.calManageVacations.AddBoldedDate(vDay)
            Next
        Next

        Form1.cboPersonalTimeEmployees.Items.Clear()
        Form1.datPersonalTime.Value = Date.Now.Date
        Form1.numPersonalTime.Value = 8
        For Each employee In employees
            Form1.cboPersonalTimeEmployees.Items.Add(dbems.getUserName(employee))
        Next
        If Form1.cboPersonalTimeEmployees.Items.Count > 0 Then
            Form1.cboPersonalTimeEmployees.SelectedIndex = 0
        End If

        Form1.pnlManageVacations.Visible = True
    End Sub

    Public Sub approveVacation(ByVal user_id As Integer, ByVal time_id As Integer, ByVal employeeMessage As String, ByVal managerMessage As String)
        dbems.subtractVacationTime(user_id)
        dbems.approveVacationRequest(time_id)
        Dim m As New Message
        m.userId = user_id
        m.senderId = user.id
        m.message = employeeMessage
        dbems.sendMessage(m)
        MessageBox.Show(managerMessage)
        mngVac.initManageVacationsPanel()
    End Sub

    Public Sub denyVacation(ByVal user_id As Integer, ByVal time_id As Integer, ByVal employeeMessage As String, ByVal managerMessage As String)
        dbems.denyVacationRequest(time_id)
        Dim m As New Message
        m.userId = user_id
        m.senderId = user.id
        m.message = employeeMessage
        dbems.sendMessage(m)
        MessageBox.Show(managerMessage)
        mngVac.initManageVacationsPanel()
    End Sub

    Public Sub submitPersonalTime()
        If Form1.cboPersonalTimeEmployees.Items.Count < 1 Then Exit Sub
        Dim employeeID As Integer = _employees(Form1.cboPersonalTimeEmployees.SelectedIndex + 1)
        Dim ptDate As Date = Form1.datPersonalTime.Value.Date
        Dim hours As Integer = Form1.numPersonalTime.Value
        If hours <= dbems.getPersonalTime(employeeID) Then
            Dim empUser As User = dbems.getSession(employeeID)
            dbems.submitPersonalTime(employeeID, ptDate, hours, empUser.current_pay_rate)
            dbems.subtractPersonalTime(employeeID, hours)
            MessageBox.Show("Personal time submitted.")
        Else
            MessageBox.Show("Not enough personal time remaining.")
        End If
    End Sub

End Class
