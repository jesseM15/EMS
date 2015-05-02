Imports EMSlib.EMS

Public Class ViewEmployees
    Private _employeeID As Integer
    Private _dgvInitialized As Boolean

    Public Sub New()
        _employeeID = 0
        _dgvInitialized = False
    End Sub

    Public Property employeeID As Integer
        Get
            Return _employeeID
        End Get
        Set(value As Integer)
            _employeeID = value
        End Set
    End Property

    Private Sub initDGV()

        Form1.dgvEmployees.Columns(0).Visible = False
        Form1.dgvEmployees.Columns(1).HeaderText = "First Name"
        Form1.dgvEmployees.Columns(2).HeaderText = "Last Name"
        Form1.dgvEmployees.Columns(3).HeaderText = "Position"
        Form1.dgvEmployees.Columns(4).HeaderText = "Pay Rate"
        Form1.dgvEmployees.Columns(5).HeaderText = "Vacation"
        Form1.dgvEmployees.Columns(6).HeaderText = "Personal"

        Dim colDetails As New DataGridViewLinkColumn
        Dim colRemove As New DataGridViewLinkColumn
        colDetails.Name = "Details"
        colDetails.HeaderText = "Details"
        colDetails.Text = "Details"
        colDetails.UseColumnTextForLinkValue = True
        colRemove.Name = "Remove"
        colRemove.HeaderText = "Remove"
        colRemove.Text = "Remove"
        colRemove.UseColumnTextForLinkValue = True

        Form1.dgvEmployees.Columns.Add(colDetails)
        Form1.dgvEmployees.Columns.Add(colRemove)

        For Each col In Form1.dgvEmployees.Columns
            col.width = 77
        Next
        _dgvInitialized = True
    End Sub

    Public Sub initViewEmployeesPanel()
        Form1.dgvEmployees.DataSource = dbems.getEmployees(user.id)
        If _dgvInitialized = False Then
            initDGV()
        End If

        Form1.pnlViewEmployees.Visible = True
    End Sub

    Public Sub initEditEmployeePanel()
        Dim cUser As New User
        If _employeeID = 0 Then
            Form1.lblEditEmployee.Text = "Add Employee"
            Form1.btnEditEmployee.Text = "Add Employee"
        Else
            'existing user
            Form1.lblEditEmployee.Text = "Edit Employee"
            Form1.btnEditEmployee.Text = "Update Employee"
            cUser = dbems.getSession(_employeeID)
        End If
        Form1.txtEditFirstName.Text = cUser.first_name
        Form1.txtEditLastName.Text = cUser.last_name
        Form1.txtEditAddress.Text = cUser.address
        Form1.txtEditCity.Text = cUser.city
        Form1.txtEditState.Text = cUser.state
        Form1.txtEditZip.Text = cUser.zip
        Form1.txtEditUserName.Text = cUser.user_name
        Form1.txtEditPassword.Text = cUser.password

        'populates the combobox
        Form1.cboEditUserType.Items.Clear()
        Form1.cboEditUserType.Items.Add("Employee")
        Form1.cboEditUserType.Items.Add("Manager")
        Form1.cboEditUserType.Items.Add("Administrator")
        'selects the appropriate user type
        For Each userType In Form1.cboEditUserType.Items
            If cUser.user_type = userType Then
                Form1.cboEditUserType.SelectedItem = userType
            End If
        Next

        Form1.datEditHireDate.Text = cUser.hire_date.Date
        Form1.txtEditPosition.Text = cUser.position
        Form1.txtEditPayRate.Text = cUser.current_pay_rate

        Dim managers As Collection = dbems.getManagers()
        'populates the combobox
        Form1.cboEditManager.Items.Clear()
        For Each manager In managers
            If manager.id <> _employeeID Then
                Form1.cboEditManager.Items.Add(manager.first_name & " " & manager.last_name)
            End If
        Next
        'select the currently selected user's manager
        Dim c As Integer = 0
        For Each manager In managers
            If manager.id = dbems.getManagerId(_employeeID) Then
                Form1.cboEditManager.SelectedIndex = c
            End If
            If manager.id <> _employeeID Then
                c += 1
            End If
        Next

        Form1.txtEditVacationTime.Text = cUser.vacation_time
        Form1.txtEditPersonalTime.Text = cUser.personal_time

        Form1.pnlEditEmployee.Visible = True
    End Sub

    Public Function getFormData() As User
        Dim cUser As New User
        If _employeeID > 0 Then
            'existing user
            cUser = dbems.getSession(_employeeID)
        End If
        cUser.first_name = Form1.txtEditFirstName.Text
        cUser.last_name = Form1.txtEditLastName.Text
        cUser.address = Form1.txtEditAddress.Text
        cUser.city = Form1.txtEditCity.Text
        cUser.state = Form1.txtEditState.Text
        cUser.zip = Form1.txtEditZip.Text
        cUser.user_name = Form1.txtEditUserName.Text
        cUser.password = Form1.txtEditPassword.Text
        cUser.user_type = Form1.cboEditUserType.Text
        cUser.hire_date = Form1.datEditHireDate.Text
        cUser.position = Form1.txtEditPosition.Text
        cUser.current_pay_rate = Form1.txtEditPayRate.Text
        'gets the id for the selected manager
        Dim managers As Collection = dbems.getManagers()
        Dim c As Integer = 0
        For Each manager In managers
            If Form1.cboEditManager.SelectedIndex = c Then
                cUser.manager_id = manager.id
            End If
            c += 1
        Next

        cUser.vacation_time = Form1.txtEditVacationTime.Text
        cUser.personal_time = Form1.txtEditPersonalTime.Text
        Return cUser
    End Function

End Class
