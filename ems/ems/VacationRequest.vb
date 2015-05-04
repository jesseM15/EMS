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

End Class
