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

        Form1.pnlEditEmployee.Visible = True
    End Sub

End Class
