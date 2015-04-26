Public Class PaySlip
    Private _employedDates As Collection
    Private _workPeriodStart As Date
    Private _workPeriodEnd As Date

    Private _hoursRegular As Decimal
    Private _hoursPersonal As Decimal
    Private _hoursVacation As Decimal
    Private _hoursHoliday As Decimal
    Private _hoursTotal As Decimal
    Private _YTDRegular As Decimal
    Private _YTDPersonal As Decimal
    Private _YTDVacation As Decimal
    Private _YTDHoliday As Decimal
    Private _YTDTotal As Decimal
    Private _hourlyPay As Decimal

    Public Sub New()
        'Dim length As Integer = time.workPeriodLength
        'Dim dates As New Collection
        ''_employedDates = New Collection
        'dates = time.getCompanyPayPeriods(admin.workStartDate)
        'For Each payPeriod In dates
        '    If payPeriod.AddDays(length).AddMinutes(-1) > user.hire_date Then
        '        _employedDates.Add(payPeriod)
        '    End If
        'Next
        'For Each payPeriod In _employedDates
        '    Form1.cboWorkPeriod.Items.Add("Pay Period: " & payPeriod.date & " - " & payPeriod.addDays(length).addMinutes(-1).date)
        'Next

        '_workPeriodStart = _employedDates.Item(1)
        '_workPeriodEnd = workPeriodStart.AddDays(length).AddMinutes(-1)

        _employedDates = New Collection
        _workPeriodStart = New Date
        _workPeriodEnd = New Date

        _hoursRegular = 0
        _hoursPersonal = 0
        _hoursVacation = 0
        _hoursHoliday = 0
        _hoursTotal = 0
        _YTDRegular = 0
        _YTDPersonal = 0
        _YTDVacation = 0
        _YTDHoliday = 0
        _YTDTotal = 0
        _hourlyPay = 0

        '_hoursRegular = dbems.getHoursWorked(user.id, "Regular", _workPeriodStart, _workPeriodEnd).TotalHours
        '_hoursPersonal = dbems.getHoursWorked(user.id, "Personal", _workPeriodStart, _workPeriodEnd).TotalHours
        '_hoursVacation = dbems.getHoursWorked(user.id, "Vacation", _workPeriodStart, _workPeriodEnd).TotalHours
        '_hoursHoliday = dbems.getHoursWorked(user.id, "Holiday", _workPeriodStart, _workPeriodEnd).TotalHours
        '_hoursTotal = _hoursRegular + _hoursPersonal + _hoursVacation + _hoursHoliday
        '_YTDRegular = dbems.getHoursWorked(user.id, "Regular", time.workYearStart, _workPeriodEnd).TotalHours
        '_YTDPersonal = dbems.getHoursWorked(user.id, "Personal", time.workYearStart, _workPeriodEnd).TotalHours
        '_YTDVacation = dbems.getHoursWorked(user.id, "Vacation", time.workYearStart, _workPeriodEnd).TotalHours
        '_YTDHoliday = dbems.getHoursWorked(user.id, "Holiday", time.workYearStart, _workPeriodEnd).TotalHours
        '_YTDTotal = _YTDRegular + _YTDPersonal + _YTDVacation + _YTDHoliday
        '_hourlyPay = user.pay_rate / 52 / 40
    End Sub

    Public Property employedDates() As Collection
        Get
            Return _employedDates
        End Get
        Set(value As Collection)
            _employedDates = value
        End Set
    End Property

    Public Property workPeriodStart() As Date
        Get
            Return _workPeriodStart
        End Get
        Set(ByVal value As Date)
            _workPeriodStart = value
        End Set
    End Property

    Public Property workPeriodEnd() As Date
        Get
            Return _workPeriodEnd
        End Get
        Set(ByVal value As Date)
            _workPeriodEnd = value
        End Set
    End Property

    Public Property hoursRegular() As Decimal
        Get
            Return _hoursRegular
        End Get
        Set(ByVal value As Decimal)
            _hoursRegular = value
        End Set
    End Property

    Public Property hoursPersonal() As Decimal
        Get
            Return _hoursPersonal
        End Get
        Set(ByVal value As Decimal)
            _hoursPersonal = value
        End Set
    End Property

    Public Property hoursVacation() As Decimal
        Get
            Return _hoursVacation
        End Get
        Set(ByVal value As Decimal)
            _hoursVacation = value
        End Set
    End Property

    Public Property hoursHoliday() As Decimal
        Get
            Return _hoursHoliday
        End Get
        Set(ByVal value As Decimal)
            _hoursHoliday = value
        End Set
    End Property

    Public Property hoursTotal() As Decimal
        Get
            Return _hoursTotal
        End Get
        Set(ByVal value As Decimal)
            _hoursTotal = value
        End Set
    End Property

    Public Property YTDRegular() As Decimal
        Get
            Return _YTDRegular
        End Get
        Set(ByVal value As Decimal)
            _YTDRegular = value
        End Set
    End Property

    Public Property YTDPersonal() As Decimal
        Get
            Return _YTDPersonal
        End Get
        Set(ByVal value As Decimal)
            _YTDPersonal = value
        End Set
    End Property

    Public Property YTDVacation() As Decimal
        Get
            Return _YTDVacation
        End Get
        Set(ByVal value As Decimal)
            _YTDVacation = value
        End Set
    End Property

    Public Property YTDHoliday() As Decimal
        Get
            Return _YTDHoliday
        End Get
        Set(ByVal value As Decimal)
            _YTDHoliday = value
        End Set
    End Property

    Public Property YTDTotal() As Decimal
        Get
            Return _YTDTotal
        End Get
        Set(ByVal value As Decimal)
            _YTDTotal = value
        End Set
    End Property

    Public Property hourlyPay() As Decimal
        Get
            Return _hourlyPay
        End Get
        Set(ByVal value As Decimal)
            _hourlyPay = value
        End Set
    End Property

    Public Sub initPaySlipPanel()
        If employedDates.Count < 1 Then
            getEmployedDates()
        End If
        getHours()
        Form1.lblEmployeeName.Text = user.first_name & " " & user.last_name
        Form1.lblHireDate.Text = user.hire_date
        Form1.lblEmployeeAddress1.Text = user.address
        Form1.lblEmployeeAddress2.Text = user.city & ", " & user.state & " " & user.zip
        Form1.lblPayPeriod.Text = "Weekly"

        'Form1.lblPaymentDate.Text = Form1.time.workPeriodEnd.AddDays(5).Date
        'Form1.lblPayStartDate.Text = Form1.time.workPeriodStart.Date
        'Form1.lblPayEndDate.Text = Form1.time.workPeriodEnd.Date
        Form1.lblPaymentDate.Text = _workPeriodEnd.AddDays(5).Date
        Form1.lblPayStartDate.Text = _workPeriodStart.Date
        Form1.lblPayEndDate.Text = _workPeriodEnd.Date

        Form1.lblPayRate.Text = hourlyPay.ToString("C2") & "/hr"
        Form1.lblAnnualSalary.Text = user.pay_rate.ToString("C2")
        Form1.lblGrossCurrent.Text = (hoursTotal * hourlyPay).ToString("C2")
        Form1.lblPreTaxCurrent.Text = 0
        Form1.lblPreTaxYTD.Text = 0
        Form1.lblGrossYTD.Text = (YTDTotal * hourlyPay).ToString("C2")

        Form1.lblCurrentHoursRegular.Text = FormatNumber(CDec(hoursRegular), 4)
        Form1.lblCurrentHoursPersonal.Text = FormatNumber(CDec(hoursPersonal), 4)
        Form1.lblCurrentHoursVacation.Text = FormatNumber(CDec(hoursVacation), 4)
        Form1.lblCurrentHoursHoliday.Text = FormatNumber(CDec(hoursHoliday), 4)
        Form1.lblYTDHoursRegular.Text = FormatNumber(CDec(YTDRegular), 4)
        Form1.lblYTDHoursPersonal.Text = FormatNumber(CDec(YTDPersonal), 4)
        Form1.lblYTDHoursVacation.Text = FormatNumber(CDec(YTDVacation), 4)
        Form1.lblYTDHoursHoliday.Text = FormatNumber(CDec(YTDHoliday), 4)
        Form1.lblCurrentAmountRegular.Text = (hoursRegular * hourlyPay).ToString("C2")
        Form1.lblCurrentAmountPersonal.Text = (hoursPersonal * hourlyPay).ToString("C2")
        Form1.lblCurrentAmountVacation.Text = (hoursVacation * hourlyPay).ToString("C2")
        Form1.lblCurrentAmountHoliday.Text = (hoursHoliday * hourlyPay).ToString("C2")
        Form1.lblYTDAmountRegular.Text = (YTDRegular * hourlyPay).ToString("C2")
        Form1.lblYTDAmountPersonal.Text = (YTDPersonal * hourlyPay).ToString("C2")
        Form1.lblYTDAmountVacation.Text = (YTDVacation * hourlyPay).ToString("C2")
        Form1.lblYTDAmountHoliday.Text = (YTDHoliday * hourlyPay).ToString("C2")

        Form1.pnlPaySlip.Visible = True
    End Sub

    Private Sub getEmployedDates()
        Dim length As Integer = time.workPeriodLength
        Dim dates As New Collection
        _employedDates = New Collection
        dates = time.getCompanyPayPeriods(admin.workStartDate)
        For Each payPeriod In dates
            If payPeriod.AddDays(length).AddMinutes(-1) > user.hire_date Then
                _employedDates.Add(payPeriod)
            End If
        Next
        For Each payPeriod In _employedDates
            Form1.cboWorkPeriod.Items.Add("Pay Period: " & payPeriod.date & " - " & payPeriod.addDays(length).addMinutes(-1).date)
        Next

        _workPeriodStart = _employedDates.Item(1)
        _workPeriodEnd = workPeriodStart.AddDays(length).AddMinutes(-1)
    End Sub

    Private Sub getHours()
        _hoursRegular = dbems.getHoursWorked(user.id, "Regular", _workPeriodStart, _workPeriodEnd).TotalHours
        _hoursPersonal = dbems.getHoursWorked(user.id, "Personal", _workPeriodStart, _workPeriodEnd).TotalHours
        _hoursVacation = dbems.getHoursWorked(user.id, "Vacation", _workPeriodStart, _workPeriodEnd).TotalHours
        _hoursHoliday = dbems.getHoursWorked(user.id, "Holiday", _workPeriodStart, _workPeriodEnd).TotalHours
        _hoursTotal = _hoursRegular + _hoursPersonal + _hoursVacation + _hoursHoliday
        _YTDRegular = dbems.getHoursWorked(user.id, "Regular", time.workYearStart, _workPeriodEnd).TotalHours
        _YTDPersonal = dbems.getHoursWorked(user.id, "Personal", time.workYearStart, _workPeriodEnd).TotalHours
        _YTDVacation = dbems.getHoursWorked(user.id, "Vacation", time.workYearStart, _workPeriodEnd).TotalHours
        _YTDHoliday = dbems.getHoursWorked(user.id, "Holiday", time.workYearStart, _workPeriodEnd).TotalHours
        _YTDTotal = _YTDRegular + _YTDPersonal + _YTDVacation + _YTDHoliday
        _hourlyPay = user.pay_rate / 52 / 40
    End Sub

End Class
