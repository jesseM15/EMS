

Namespace EMS

    Public Class Time
        Private _time_start As Date
        Private _time_end As Date
        Private _hours_type As String
        Private _workWeekStart As Date
        Private _WorkWeekEnd As Date
        Private _workYearStart As Date

        Public Sub New()
            _time_start = New Date
            _time_end = New Date
            _hours_type = "Regular"
            _workWeekStart = findMondayDate()
            _WorkWeekEnd = findSundayDate()
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

        Public ReadOnly Property workWeekStart() As Date
            Get
                Return _workWeekStart
            End Get
        End Property

        Public ReadOnly Property workWeekEnd() As Date
            Get
                Return _WorkWeekEnd
            End Get
        End Property

        Public ReadOnly Property workYearStart() As Date
            Get
                Return _workYearStart
            End Get
        End Property

        'finds the date for monday of the current week
        Public Function findMondayDate() As Date
            Dim today As Date = Date.Today
            Dim dayDiff As Integer = today.DayOfWeek - DayOfWeek.Monday
            Dim monday As Date = today.AddDays(-dayDiff)
            Return monday
        End Function

        Public Function findSundayDate() As Date
            Return _workWeekStart.AddDays(7).AddMinutes(-1)
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

    End Class

End Namespace