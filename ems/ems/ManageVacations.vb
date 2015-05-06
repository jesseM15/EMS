Imports EMSlib.EMS

Public Class ManageVacations
    Private _dgvInitialized As Boolean

    Public Sub New()
        _dgvInitialized = False

    End Sub

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

End Class
