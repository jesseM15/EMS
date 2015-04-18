Namespace EMS

    Public Class VacationRequest
        Private _dateRequested As Date

        Public Sub New()
            _dateRequested = New Date()
        End Sub

        Public Property dateRequested As Date
            Get
                Return _dateRequested
            End Get
            Set(value As Date)
                _dateRequested = value
            End Set
        End Property

        Public Sub initVacationRequestPanel()
            Form1.lblDateRequested.Text = "Vacation Date: "
            Form1.pnlRequestVacation.Visible = True
        End Sub

    End Class

End Namespace
