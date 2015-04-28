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

        Form1.pnlRequestVacation.Visible = True
    End Sub

    'gets a collection of the dates requested with weekends trimmed
    Public Function getDatesRequested(ByVal startDate As Date, ByVal endDate As Date) As Collection
        Dim dates As New Collection()
        If startDate = endDate Then
            If time.isWeekDay(startDate) = True Then dates.Add(startDate)
        Else
            Dim currentDate As Date = startDate
            While currentDate <= endDate
                If time.isWeekDay(currentDate) = True Then dates.Add(currentDate)
                currentDate = currentDate.AddDays(1)
            End While
        End If
        Return dates
    End Function

    

End Class
