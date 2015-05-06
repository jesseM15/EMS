Public Class Reports
    Private _employedDates As Collection
    Private _employeeIds As Collection
    Private _workPeriodStart As Date
    Public cboReports As New ComboBox
    Public _ctrls As Collection

    Public Sub New()
        _employedDates = New Collection()
        _employeeIds = New Collection()
        _workPeriodStart = New Date
        _ctrls = New Collection()
    End Sub

    Public Property employedDates() As Collection
        Get
            Return _employedDates
        End Get
        Set(value As Collection)
            _employedDates = value
        End Set
    End Property

    Public Property employeeIds() As Collection
        Get
            Return _employeeIds
        End Get
        Set(value As Collection)
            _employeeIds = value
        End Set
    End Property

    Public Property workPeriodStart() As Date
        Get
            Return _workPeriodStart
        End Get
        Set(value As Date)
            _workPeriodStart = value
        End Set
    End Property

    Public Property ctrls() As Collection
        Get
            Return _ctrls
        End Get
        Set(value As Collection)
            _ctrls = value
        End Set
    End Property

    Public Sub initReportsPanel()
        If employedDates.Count < 1 Then
            _employedDates = time.getEmployedDates(dbems.getFirstWorkDate(), user.hire_date)
            For Each payPeriod In _employedDates
                cboReports.Items.Add("Pay Report: " & payPeriod.date & " - " & payPeriod.addDays(time.workPeriodLength).addMinutes(-1).date)
            Next
            _workPeriodStart = _employedDates.Item(1)
            _employeeIds = dbems.getEmployeeIds(user.id)
        End If

        initReportsPanelFramework()
        refreshLabels()

        Form1.pnlReports.Visible = True
    End Sub

    Private Sub cboReports_SelectedIndexChanged(sender As Object, e As EventArgs)
        workPeriodStart = employedDates.Item(cboReports.SelectedIndex + 1)
        refreshLabels()
    End Sub

    Private Sub refreshLabels()
        Dim totalEarnedHours As Decimal = 0
        Dim totalPayRate As Decimal = 0
        Dim totalWagesPaid As Decimal = 0
        Dim emphours As New PaySlip()
        Dim c As Integer = 1
        Dim i As Integer = 1
        For Each ctrl In _ctrls
            emphours.getHours(_employeeIds(i), _workPeriodStart)
            Select Case c
                Case 1
                    'Employee name
                    ctrl.text = dbems.getUserName(_employeeIds(i))
                Case 2
                    'Earned hours
                    Dim ea As Decimal = emphours.hoursTotal + emphours.hoursOvertime
                    ctrl.text = FormatNumber(CDec(ea), 4)
                    totalEarnedHours += ea
                Case 3
                    'Pay Rate
                    Dim hp As Decimal = emphours.hourlyPay
                    ctrl.text = hp.ToString("C5")
                    totalPayRate += hp
                Case 4
                    'Wages Paid
                    Dim wp As Decimal = ((emphours.hoursTotal * emphours.hourlyPay) + (emphours.hoursOvertime * (emphours.hourlyPay * 1.5)))
                    ctrl.text = wp.ToString("C2")
                    totalWagesPaid += wp
            End Select
            c += 1
            If c > 4 Then
                i += 1
                c = 1
            End If
        Next

        'averages and totals
        Dim avgEarnedHours As Decimal = totalEarnedHours / _employeeIds.Count()
        Dim avgPayRate As Decimal = totalPayRate / _employeeIds.Count()
        Dim avgWagesPaid As Decimal = totalWagesPaid / _employeeIds.Count()

        Form1.pnlReports.Controls.Item(Form1.pnlReports.Controls.Count - 6).Text = FormatNumber(CDec(avgEarnedHours), 4)
        Form1.pnlReports.Controls.Item(Form1.pnlReports.Controls.Count - 5).Text = avgPayRate.ToString("C5")
        Form1.pnlReports.Controls.Item(Form1.pnlReports.Controls.Count - 4).Text = avgWagesPaid.ToString("C2")
        Form1.pnlReports.Controls.Item(Form1.pnlReports.Controls.Count - 2).Text = FormatNumber(CDec(totalEarnedHours), 4)
        Form1.pnlReports.Controls.Item(Form1.pnlReports.Controls.Count - 1).Text = totalWagesPaid.ToString("C2")

    End Sub


    Private Sub initReportsPanelFramework()
        Form1.pnlReports.Controls.Clear()
        Dim lblReports As New Label
        lblReports.Location = New Point(22, 12)
        lblReports.Text = "Reports"
        lblReports.Font = New Font("Microsoft Sans Serif", 14)

        cboReports.Location = New Point(432, 12)
        cboReports.Size = New Size(203, 21)
        cboReports.Name = "cboReports"
        AddHandler cboReports.SelectedIndexChanged, AddressOf cboReports_SelectedIndexChanged

        Dim lblReportsEmployeeField As New Label
        lblReportsEmployeeField.Location = New Point(22, 72)
        lblReportsEmployeeField.Text = "Employee"
        lblReportsEmployeeField.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
        Dim lblReportsEarnedHoursField As New Label
        lblReportsEarnedHoursField.Location = New Point(122, 72)
        lblReportsEarnedHoursField.Text = "Earned Hours"
        lblReportsEarnedHoursField.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
        Dim lblReportsPayRateField As New Label
        lblReportsPayRateField.Location = New Point(222, 72)
        lblReportsPayRateField.Text = "Pay Rate"
        lblReportsPayRateField.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
        Dim lblReportsWagesPaidField As New Label
        lblReportsWagesPaidField.Location = New Point(322, 72)
        lblReportsWagesPaidField.Text = "Wages Paid"
        lblReportsWagesPaidField.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)

        Dim rowY As Integer = 102
        If _ctrls.Count < _employeeIds.Count Then
            _ctrls.Clear()
            For Each id In _employeeIds
                Dim lblEmployee As New Label
                lblEmployee.Location = New Point(22, rowY)
                Dim lblEarnedHours As New Label
                lblEarnedHours.Location = New Point(122, rowY)
                Dim lblPayRate As New Label
                lblPayRate.Location = New Point(222, rowY)
                Dim lblWagesPaid As New Label
                lblWagesPaid.Location = New Point(322, rowY)
                _ctrls.Add(lblEmployee)
                _ctrls.Add(lblEarnedHours)
                _ctrls.Add(lblPayRate)
                _ctrls.Add(lblWagesPaid)
                rowY += 30
            Next
        End If

        rowY = _ctrls(_ctrls.Count).location.y + 60
        Dim lblReportsAverageField As New Label
        lblReportsAverageField.Location = New Point(22, rowY)
        lblReportsAverageField.Text = "Average"
        lblReportsAverageField.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
        Dim lblReportsAverageEarnedHours As New Label
        lblReportsAverageEarnedHours.Location = New Point(122, rowY)
        Dim lblReportsAveragePayRate As New Label
        lblReportsAveragePayRate.Location = New Point(222, rowY)
        Dim lblReportsAverageWagesPaid As New Label
        lblReportsAverageWagesPaid.Location = New Point(322, rowY)
        rowY += 30
        Dim lblReportsTotalField As New Label
        lblReportsTotalField.Location = New Point(22, rowY)
        lblReportsTotalField.Text = "Total"
        lblReportsTotalField.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
        Dim lblReportsTotalEarnedHours As New Label
        lblReportsTotalEarnedHours.Location = New Point(122, rowY)
        Dim lblReportsTotalWagesPaid As New Label
        lblReportsTotalWagesPaid.Location = New Point(322, rowY)

        Form1.pnlReports.Controls.Add(lblReports)
        Form1.pnlReports.Controls.Add(cboReports)
        Form1.pnlReports.Controls.Add(lblReportsEmployeeField)
        Form1.pnlReports.Controls.Add(lblReportsEarnedHoursField)
        Form1.pnlReports.Controls.Add(lblReportsPayRateField)
        Form1.pnlReports.Controls.Add(lblReportsWagesPaidField)

        For Each ctrl In _ctrls
            Form1.pnlReports.Controls.Add(ctrl)
        Next

        Form1.pnlReports.Controls.Add(lblReportsAverageField)
        Form1.pnlReports.Controls.Add(lblReportsAverageEarnedHours)
        Form1.pnlReports.Controls.Add(lblReportsAveragePayRate)
        Form1.pnlReports.Controls.Add(lblReportsAverageWagesPaid)
        Form1.pnlReports.Controls.Add(lblReportsTotalField)
        Form1.pnlReports.Controls.Add(lblReportsTotalEarnedHours)
        Form1.pnlReports.Controls.Add(lblReportsTotalWagesPaid)

    End Sub

End Class
