Public Class PaySlip
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
        _workPeriodStart = Form1.time.findMondayDate()
        Dim length As Integer = Form1.time.workPeriodLength
        _workPeriodEnd = _workPeriodStart.Date.AddDays(length).AddMinutes(-1)

        Dim latestWorkPeriodStart As New Date
        Dim latestWorkPeriodEnd As New Date
        If _workPeriodEnd.AddDays(5).Date < DateAndTime.Now.Date Then
            'if 5 days has passed since the _workPeriodEnd date
            latestWorkPeriodStart = _workPeriodStart
            latestWorkPeriodEnd = _workPeriodEnd
        Else
            latestWorkPeriodStart = _workPeriodStart.AddDays(-Form1.time.workPeriodLength)
            latestWorkPeriodEnd = _workPeriodEnd.AddDays(-Form1.time.workPeriodLength)
        End If
        _workPeriodStart = latestWorkPeriodStart
        _workPeriodEnd = latestWorkPeriodEnd
        Form1.cboWorkPeriod.Items.Add("Pay Period: " & latestWorkPeriodStart.Date & " - " & latestWorkPeriodEnd.Date)
        Form1.cboWorkPeriod.SelectedIndex = 0

        _hoursRegular = Form1.dbems.getHoursWorked(Form1.user.id, "Regular", _workPeriodStart, _workPeriodEnd).TotalHours
        _hoursPersonal = Form1.dbems.getHoursWorked(Form1.user.id, "Personal", _workPeriodStart, _workPeriodEnd).TotalHours
        _hoursVacation = Form1.dbems.getHoursWorked(Form1.user.id, "Vacation", _workPeriodStart, _workPeriodEnd).TotalHours
        _hoursHoliday = Form1.dbems.getHoursWorked(Form1.user.id, "Holiday", _workPeriodStart, _workPeriodEnd).TotalHours
        _hoursTotal = _hoursRegular + _hoursPersonal + _hoursVacation + _hoursHoliday
        _YTDRegular = Form1.dbems.getHoursWorked(Form1.user.id, "Regular", Form1.time.workYearStart, _workPeriodEnd).TotalHours
        _YTDPersonal = Form1.dbems.getHoursWorked(Form1.user.id, "Personal", Form1.time.workYearStart, _workPeriodEnd).TotalHours
        _YTDVacation = Form1.dbems.getHoursWorked(Form1.user.id, "Vacation", Form1.time.workYearStart, _workPeriodEnd).TotalHours
        _YTDHoliday = Form1.dbems.getHoursWorked(Form1.user.id, "Holiday", Form1.time.workYearStart, _workPeriodEnd).TotalHours
        _YTDTotal = _YTDRegular + _YTDPersonal + _YTDVacation + _YTDHoliday
        _hourlyPay = Form1.user.pay_rate / 52 / 40
    End Sub

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

        Form1.lblEmployeeName.Text = Form1.user.first_name & " " & Form1.user.last_name
        Form1.lblHireDate.Text = Form1.user.hire_date
        Form1.lblEmployeeAddress1.Text = Form1.user.address
        Form1.lblEmployeeAddress2.Text = Form1.user.city & ", " & Form1.user.state & " " & Form1.user.zip
        Form1.lblPayPeriod.Text = "Weekly"

        'Form1.lblPaymentDate.Text = Form1.time.workPeriodEnd.AddDays(5).Date
        'Form1.lblPayStartDate.Text = Form1.time.workPeriodStart.Date
        'Form1.lblPayEndDate.Text = Form1.time.workPeriodEnd.Date
        Form1.lblPaymentDate.Text = _workPeriodEnd.AddDays(5).Date
        Form1.lblPayStartDate.Text = _workPeriodStart.Date
        Form1.lblPayEndDate.Text = _workPeriodEnd.Date

        Form1.lblPayRate.Text = hourlyPay.ToString("C2") & "/hr"
        Form1.lblAnnualSalary.Text = Form1.user.pay_rate.ToString("C2")
        Form1.lblGrossCurrent.Text = (hoursTotal * hourlyPay).ToString("C2")
        Form1.lblPreTaxCurrent.Text = 0
        Form1.lblPreTaxYTD.Text = 0
        Form1.lblGrossYTD.Text = (YTDTotal * hourlyPay).ToString("C2")

        Form1.lblCurrentHoursRegular.Text = hoursRegular
        Form1.lblCurrentHoursPersonal.Text = hoursPersonal
        Form1.lblCurrentHoursVacation.Text = hoursVacation
        Form1.lblCurrentHoursHoliday.Text = hoursHoliday
        Form1.lblYTDHoursRegular.Text = YTDRegular
        Form1.lblYTDHoursPersonal.Text = YTDPersonal
        Form1.lblYTDHoursVacation.Text = YTDVacation
        Form1.lblYTDHoursHoliday.Text = YTDHoliday
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

    

End Class
