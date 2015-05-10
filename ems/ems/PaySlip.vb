Public Class PaySlip
    Private _employedDates As Collection
    Private _workPeriodStart As Date
    Private _workPeriodEnd As Date

    Private _hoursRegular As Decimal
    Private _hoursOvertime As Decimal
    Private _hoursPersonal As Decimal
    Private _hoursVacation As Decimal
    Private _hoursHoliday As Decimal
    Private _hoursTotal As Decimal
    Private _YTDRegular As Decimal
    Private _YTDOvertime As Decimal
    Private _YTDPersonal As Decimal
    Private _YTDVacation As Decimal
    Private _YTDHoliday As Decimal
    Private _YTDTotal As Decimal
    Private _annualPay As Decimal
    Private _hourlyPay As Decimal

    Public Sub New()
        _employedDates = New Collection
        _workPeriodStart = New Date
        _workPeriodEnd = New Date
        _hoursRegular = 0
        _hoursOvertime = 0
        _hoursPersonal = 0
        _hoursVacation = 0
        _hoursHoliday = 0
        _hoursTotal = 0
        _YTDRegular = 0
        _YTDOvertime = 0
        _YTDPersonal = 0
        _YTDVacation = 0
        _YTDHoliday = 0
        _YTDTotal = 0
        _annualPay = 0
        _hourlyPay = 0
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

    Public Property hoursOvertime() As Decimal
        Get
            Return _hoursOvertime
        End Get
        Set(ByVal value As Decimal)
            _hoursOvertime = value
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

    Public Property YTDOvertime() As Decimal
        Get
            Return _YTDOvertime
        End Get
        Set(ByVal value As Decimal)
            _YTDOvertime = value
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

    Public Property annualPay() As Decimal
        Get
            Return _annualPay
        End Get
        Set(ByVal value As Decimal)
            _annualPay = value
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
            Try
                _employedDates = time.getEmployedDates(dbems.getFirstWorkDate(), user.hire_date)
                _workPeriodStart = _employedDates.Item(1)
                _workPeriodEnd = _workPeriodStart.AddDays(time.workPeriodLength).AddMinutes(-1)
                For Each payPeriod In _employedDates
                    Form1.cboWorkPeriod.Items.Add("Pay Period: " & payPeriod.date & " - " & payPeriod.addDays(time.workPeriodLength).addMinutes(-1).date)
                Next
            Catch ex As Exception
                err.errorMessage = "Failed to initialize pay slip."
                err.exceptionMessage = ex.Message
                err.outputMessage()
            End Try
        End If
        If employedDates.Count < 1 Then Exit Sub
        getHours(user.id, _workPeriodStart)
        'employee information
        Form1.lblEmployeeName.Text = user.first_name & " " & user.last_name
        Form1.lblHireDate.Text = user.hire_date
        Form1.lblEmployeeAddress1.Text = user.address
        Form1.lblEmployeeAddress2.Text = user.city & ", " & user.state & " " & user.zip
        'employer information
        Form1.lblEmployerName.Text = busDat.companyName
        Form1.lblEmployerPhone.Text = busDat.companyPhone
        Form1.lblEmployerAddress1.Text = busDat.companyAddress
        Form1.lblEmployerAddress2.Text = busDat.companyCity & ", " & busDat.companyState & " " & busDat.companyZip
        'pay period and salary
        If time.workPeriodLength = 7 Then
            Form1.lblPayPeriod.Text = "Weekly"
        ElseIf time.workPeriodLength = 14 Then
            Form1.lblPayPeriod.Text = "Biweekly"
        End If
        Form1.lblPaymentDate.Text = _workPeriodEnd.AddDays(5).Date
        Form1.lblPayStartDate.Text = _workPeriodStart.Date
        Form1.lblPayEndDate.Text = _workPeriodEnd.Date
        Form1.lblPayRate.Text = hourlyPay.ToString("C5")
        Form1.lblAnnualSalary.Text = annualPay.ToString("C2")
        'summary
        Dim currentGross As String = ((hoursTotal * hourlyPay) + (_hoursOvertime * (_hourlyPay * 1.5))).ToString("C2")
        Dim YTDGross As String = ((YTDTotal * hourlyPay) + (_YTDOvertime * (_hourlyPay * 1.5))).ToString("C2")
        Dim currentTaxes As String = getTaxes(_workPeriodStart).ToString("C2")
        Dim YTDTaxesTotal As Decimal = 0
        For Each d In employedDates
            'gets the pay periods up to the current pay period
            If d <= _workPeriodStart And _workPeriodStart.Year = d.year Then
                YTDTaxesTotal += getTaxes(d)
            End If
        Next
        Dim YTDTaxes As String = YTDTaxesTotal.ToString("C2")
        Form1.lblGrossCurrent.Text = currentGross
        Form1.lblGrossYTD.Text = YTDGross
        Form1.lblTaxesCurrent.Text = currentTaxes
        Form1.lblTaxesYTD.Text = YTDTaxes
        Form1.lblNetPayCurrent.Text = (currentGross - currentTaxes).ToString("C2")
        Form1.lblNetPayYTD.Text = (YTDGross - YTDTaxes).ToString("C2")

        getHours(user.id, _workPeriodStart)
        'current hours
        Form1.lblCurrentHoursRegular.Text = FormatNumber(CDec(hoursRegular), 4)
        Form1.lblCurrentHoursOvertime.Text = FormatNumber(CDec(hoursOvertime), 4)
        Form1.lblCurrentHoursPersonal.Text = FormatNumber(CDec(hoursPersonal), 4)
        Form1.lblCurrentHoursVacation.Text = FormatNumber(CDec(hoursVacation), 4)
        Form1.lblCurrentHoursHoliday.Text = FormatNumber(CDec(hoursHoliday), 4)
        'YTD hours
        Form1.lblYTDHoursRegular.Text = FormatNumber(CDec(YTDRegular), 4)
        Form1.lblYTDHoursOvertime.Text = FormatNumber(CDec(YTDOvertime), 4)
        Form1.lblYTDHoursPersonal.Text = FormatNumber(CDec(YTDPersonal), 4)
        Form1.lblYTDHoursVacation.Text = FormatNumber(CDec(YTDVacation), 4)
        Form1.lblYTDHoursHoliday.Text = FormatNumber(CDec(YTDHoliday), 4)
        'current amount
        Form1.lblCurrentAmountRegular.Text = (hoursRegular * hourlyPay).ToString("C2")
        Form1.lblCurrentAmountOvertime.Text = (hoursOvertime * (hourlyPay * 1.5)).ToString("C2")
        Form1.lblCurrentAmountPersonal.Text = (hoursPersonal * hourlyPay).ToString("C2")
        Form1.lblCurrentAmountVacation.Text = (hoursVacation * hourlyPay).ToString("C2")
        Form1.lblCurrentAmountHoliday.Text = (hoursHoliday * hourlyPay).ToString("C2")
        'YTD amount
        Form1.lblYTDAmountRegular.Text = (YTDRegular * hourlyPay).ToString("C2")
        Form1.lblYTDAmountOvertime.Text = (YTDOvertime * (hourlyPay * 1.5)).ToString("C2")
        Form1.lblYTDAmountPersonal.Text = (YTDPersonal * hourlyPay).ToString("C2")
        Form1.lblYTDAmountVacation.Text = (YTDVacation * hourlyPay).ToString("C2")
        Form1.lblYTDAmountHoliday.Text = (YTDHoliday * hourlyPay).ToString("C2")

        Form1.pnlPaySlip.Visible = True
    End Sub

    Public Sub getHours(ByVal userID As Integer, ByVal workStart As Date)
        _hoursRegular = getRegularHours(userID, workStart)
        _hoursOvertime = getOvertimeHours(userID, workStart)

        _hoursPersonal = dbems.getHoursWorked(userID, "Personal", time.workPeriodStart, time.workPeriodEnd).TotalHours
        _hoursVacation = dbems.getHoursWorked(userID, "Vacation", time.workPeriodStart, time.workPeriodEnd).TotalHours
        _hoursHoliday = dbems.getHoursWorked(userID, "Holiday", time.workPeriodStart, time.workPeriodEnd).TotalHours
        _hoursTotal = _hoursRegular + _hoursPersonal + _hoursVacation + _hoursHoliday
        _YTDRegular = 0
        _YTDOvertime = 0
        For Each d In employedDates
            'gets the pay periods up to the current pay period
            If d <= workStart And workStart.Year = d.year Then
                _YTDRegular += getRegularHours(userID, d)
                _YTDOvertime += getOvertimeHours(userID, d)
            End If
        Next
        _YTDPersonal = dbems.getHoursWorked(userID, "Personal", time.findFirstWorkPeriod(workStart, _employedDates), time.workPeriodEnd).TotalHours
        _YTDVacation = dbems.getHoursWorked(userID, "Vacation", time.findFirstWorkPeriod(workStart, _employedDates), time.workPeriodEnd).TotalHours
        _YTDHoliday = dbems.getHoursWorked(userID, "Holiday", time.findFirstWorkPeriod(workStart, _employedDates), time.workPeriodEnd).TotalHours
        _YTDTotal = _YTDRegular + _YTDPersonal + _YTDVacation + _YTDHoliday

        _annualPay = getAnnualPay(userID, workStart)
        _hourlyPay = _annualPay / 52 / 40
    End Sub

    'gets the regular hours (adjusted for overtime) for the pay period starting on the workStart date
    Private Function getRegularHours(ByVal userID As Integer, ByVal workStart As Date) As Decimal
        Dim regWeek As Decimal = 0
        Dim regPayPeriod As Decimal = 0
        Dim timeLeft As Integer = time.workPeriodLength
        While timeLeft > 0
            regWeek = dbems.getHoursWorked(userID, "Regular", workStart, workStart.AddDays(7).AddMinutes(-1)).TotalHours
            If regWeek > 40 Then
                regWeek = 40
            End If
            regPayPeriod += regWeek
            regWeek = 0
            workStart = workStart.AddDays(7)
            timeLeft -= 7
        End While
        Return regPayPeriod
    End Function

    'gets the overtime hours for the pay period starting on the workStart date
    Private Function getOvertimeHours(ByVal userID As Integer, ByVal workStart As Date) As Decimal
        Dim regWeek As Decimal = 0
        Dim otWeek As Decimal = 0
        Dim otPayPeriod As Decimal = 0
        Dim timeLeft As Integer = time.workPeriodLength
        While timeLeft > 0
            regWeek = dbems.getHoursWorked(userID, "Regular", workStart, workStart.AddDays(7).AddMinutes(-1)).TotalHours
            If regWeek > 40 Then
                otWeek = regWeek - 40
            End If
            otPayPeriod += otWeek
            otWeek = 0
            workStart = workStart.AddDays(7)
            timeLeft -= 7
        End While
        Return otPayPeriod
    End Function

    Private Function getTaxes(ByVal workStart As Date) As Decimal
        getHours(user.id, workStart)
        Dim taxableIncome As Decimal = ((_hoursTotal * _hourlyPay) + (_hoursOvertime * (_hourlyPay * 1.5)))
        Dim taxes As Decimal = 0
        Dim payPeriods As Integer = 0
        Dim annualEstimate As Decimal = 0
        If time.workPeriodLength = 7 Then
            payPeriods = 52
        ElseIf time.workPeriodLength = 14 Then
            payPeriods = 26
        End If
        annualEstimate = taxableIncome * payPeriods
        'for individual taxpayer
        If annualEstimate > 0 And annualEstimate <= 9225 Then
            taxes = (annualEstimate * 0.1) / payPeriods
        ElseIf annualEstimate > 9225 And annualEstimate <= 37450 Then
            taxes = (((annualEstimate - 9225) * 0.15) + 922.5) / payPeriods
        ElseIf annualEstimate > 37450 And annualEstimate <= 90750 Then
            taxes = (((annualEstimate - 37450) * 0.25) + 5156.25) / payPeriods
        ElseIf annualEstimate > 90750 And annualEstimate <= 189300 Then
            taxes = (((annualEstimate - 90750) * 0.28) + 18481.25) / payPeriods
        ElseIf annualEstimate > 189300 And annualEstimate <= 411500 Then
            taxes = (((annualEstimate - 189300) * 0.33) + 46075.25) / payPeriods
        ElseIf annualEstimate > 411500 And annualEstimate <= 413200 Then
            taxes = (((annualEstimate - 411500) * 0.35) + 119401.25) / payPeriods
        ElseIf annualEstimate > 413200 Then
            taxes = (((annualEstimate - 413200) * 0.396) + 119996.25) / payPeriods
        End If
        Return taxes
    End Function

    'returns the pay rate on the specified date. If no pay rate is found
    'the workdays of each week are iterated through until one is found
    Private Function getAnnualPay(ByVal userID As Integer, ByVal workStart As Date) As Decimal
        Dim pay As Decimal = 0
        Dim inputDate As Date = workStart
        While pay = 0
            For i = 0 To 4
                If pay = 0 Then
                    pay = dbems.getPeriodPayRate(userID, inputDate.AddDays(i))
                End If
            Next
            If busDat.workPeriodLength = 14 Then
                For i = 7 To 11
                    If pay = 0 Then
                        pay = dbems.getPeriodPayRate(userID, inputDate.AddDays(i))
                    End If
                Next
            End If
            'if no pay rate is found before the user's hire date is reached then exit the function
            If inputDate < dbems.getHireDate(userID) Then
                Exit While
            End If
            inputDate = inputDate.AddDays(-busDat.workPeriodLength)
        End While
        Return pay
    End Function

End Class
