

Namespace EMS

    Public Class Time
        Private _time_start As Date
        Private _time_end As Date
        Private _hours_type As String
        Private _workPeriodLength As Integer
        Private _workPeriodStart As Date
        Private _workPeriodEnd As Date
        Private _workYearStart As Date

        Private _companyPayPeriods As Collection

        Public Sub New()
            _time_start = New Date
            _time_end = New Date
            _hours_type = "Regular"
            _workPeriodLength = 14
            _workPeriodStart = findMondayDate(Date.Today)
            _workPeriodEnd = findSundayDate()
            _workYearStart = findFirstMonday()

        End Sub

        Public Property time_start() As Date
            Get
                Return _time_start
            End Get
            Set(ByVal value As Date)
                _time_start = value
            End Set
        End Property

        Public Property time_end() As Date
            Get
                Return _time_end
            End Get
            Set(ByVal value As Date)
                _time_end = value
            End Set
        End Property

        Public Property hours_type() As String
            Get
                Return _hours_type
            End Get
            Set(ByVal value As String)
                _hours_type = value
            End Set
        End Property

        Public Property workPeriodLength() As Integer
            Get
                Return _workPeriodLength
            End Get
            Set(ByVal value As Integer)
                _workPeriodLength = value
            End Set
        End Property

        Public ReadOnly Property workPeriodStart() As Date
            Get
                Return _workPeriodStart
            End Get
        End Property

        Public ReadOnly Property workPeriodEnd() As Date
            Get
                Return _workPeriodEnd
            End Get
        End Property

        Public ReadOnly Property workYearStart() As Date
            Get
                Return _workYearStart
            End Get
        End Property

        'finds the date for monday of the current week
        Public Function findMondayDate(ByVal inputDate As Date) As Date
            Dim dayDiff As Integer = inputDate.DayOfWeek - DayOfWeek.Monday
            Dim monday As Date = inputDate.AddDays(-dayDiff)
            Return monday
        End Function

        Public Function findSundayDate() As Date
            Return _workPeriodStart.AddDays(_workPeriodLength).AddMinutes(-1)
        End Function

        'finds the date for monday of the current year
        Public Function findFirstMonday() As Date
            Dim currentYear As Integer = Date.Today.Year
            Dim firstDay As New Date(currentYear, 1, 1)

            If firstDay.DayOfWeek = DayOfWeek.Monday Then
                Return firstDay
            Else
                While firstDay.DayOfWeek <> DayOfWeek.Monday
                    firstDay = firstDay.AddDays(1)
                End While
                Return firstDay
            End If
        End Function

        'returns a collection of the start dates for each work period in company history
        Public Function getCompanyPayPeriods(ByVal workStartDate As Date) As Collection
            Dim dates As New Collection
            Dim startDate As Date = findMondayDate(workStartDate)
            Dim today As Date = Date.Now
            Do While (startDate.AddDays(_workPeriodLength) < today)
                dates.Add(startDate)
                startDate = startDate.AddDays(_workPeriodLength)
            Loop
            Dim reorder As New Collection
            Dim count As Integer = dates.Count
            Do While count > 0
                reorder.Add(dates(count))
                count -= 1
            Loop
            Return reorder
        End Function

    End Class

End Namespace