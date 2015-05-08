Imports EMSlib.EMS

Public Class VacationRequest
    Private _datesRequested As Collection

    Public Sub New()
        _datesRequested = New Collection()
    End Sub

    Public Property datesRequested As Collection
        Get
            Return _datesRequested
        End Get
        Set(value As Collection)
            _datesRequested = value
        End Set
    End Property

    Public Sub initVacationRequestPanel()
        Form1.lblVacationHoursRemaining.Text = "Vacation hours remaining: " & user.vacation_time
        Dim req As Collection = dbems.getVacationRequests(user.id)
        Form1.txtRequestList.Text = ""
        For Each d In req
            If DateAndTime.Now <= d Then
                Form1.calVacation.AddBoldedDate(d)
                Form1.txtRequestList.Text += d.date & vbCrLf
            End If
        Next
        Dim vac As Collection = dbems.getScheduledVacation(user.id)
        Form1.txtScheduledList.Text = ""
        For Each d In vac
            If DateAndTime.Now <= d Then
                Form1.calVacation.AddBoldedDate(d)
                Form1.txtScheduledList.Text += d.date & vbCrLf
            End If
        Next
        Form1.pnlRequestVacation.Visible = True
    End Sub

    'gets a collection of the dates requested
    Public Function getDatesRequested(ByVal startDate As Date, ByVal endDate As Date) As Collection
        Dim dates As New Collection()
        If startDate = endDate Then
            If isAvailable(startDate) = True Then dates.Add(startDate)
        Else
            Dim currentDate As Date = startDate
            While currentDate <= endDate
                If isAvailable(currentDate) = True Then dates.Add(currentDate)
                currentDate = currentDate.AddDays(1)
            End While
        End If
        Return dates
    End Function

    'checks to see if date is not a weekend, request, or vacation and 
    'that the date is after today and not more than a year in the future
    Private Function isAvailable(ByVal dateToCheck As Date) As Boolean
        Dim available As Boolean = True
        Dim req As Collection = dbems.getVacationRequests(user.id)
        Dim vac As Collection = dbems.getScheduledVacation(user.id)
        For Each r In req
            If r = dateToCheck Then available = False
        Next
        For Each v In vac
            If v = dateToCheck Then available = False
        Next
        If time.isWeekDay(dateToCheck) = False Then available = False
        If DateAndTime.Now.AddDays(1) > dateToCheck Then available = False
        If DateAndTime.Now.AddYears(1) < dateToCheck Then available = False
        Return available
    End Function

    'submits a vacation request
    Public Sub submitRequest()
        If user.manager_id = 0 Then
            If datesRequested.Count * 8 > user.vacation_time Then
                MessageBox.Show("Not enough vacation time remaining.")
                Exit Sub
            End If
            For Each d In datesRequested
                dbems.submitVacationRequest(user.id, d, user.current_pay_rate)
                dbems.approveVacationRequest(user.id, d)
                dbems.subtractVacationTime(user.id)
                user.vacation_time -= 8
            Next
            MessageBox.Show("Vacation days approved.")
            Exit Sub
        End If
        For Each d In datesRequested
            dbems.submitVacationRequest(user.id, d, user.current_pay_rate)
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
        initVacationRequestPanel()
    End Sub

End Class
