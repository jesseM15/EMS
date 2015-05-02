

Namespace EMS

    Public Class User
        Private _id As Integer
        Private _user_name As String
        Private _password As String
        Private _user_type As String
        Private _first_name As String
        Private _last_name As String
        Private _address As String
        Private _city As String
        Private _state As String
        Private _zip As String
        Private _hire_date As Date
        Private _current_pay_rate As Decimal
        Private _position As String
        Private _manager_id As Integer
        Private _vacation_time As Integer
        Private _personal_time As Integer

        Public Sub New()
            _id = 0
            _user_name = ""
            _password = ""
            _user_type = ""
            _first_name = ""
            _last_name = ""
            _address = ""
            _city = ""
            _state = ""
            _zip = ""
            _hire_date = New Date
            _current_pay_rate = 0
            _position = ""
            _manager_id = 0
            _vacation_time = 0
            _personal_time = 0
        End Sub

        Public Property id() As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property

        Public Property user_name() As String
            Get
                Return _user_name
            End Get
            Set(ByVal value As String)
                _user_name = value
            End Set
        End Property

        Public Property password() As String
            Get
                Return _password
            End Get
            Set(ByVal value As String)
                _password = value
            End Set
        End Property
        
        Public Property user_type() As String
            Get
                Return _user_type
            End Get
            Set(ByVal value As String)
                _user_type = value
            End Set
        End Property

        Public Property first_name() As String
            Get
                Return _first_name
            End Get
            Set(ByVal value As String)
                _first_name = value
            End Set
        End Property

        Public Property last_name() As String
            Get
                Return _last_name
            End Get
            Set(ByVal value As String)
                _last_name = value
            End Set
        End Property

        Public Property address() As String
            Get
                Return _address
            End Get
            Set(ByVal value As String)
                _address = value
            End Set
        End Property

        Public Property city() As String
            Get
                Return _city
            End Get
            Set(ByVal value As String)
                _city = value
            End Set
        End Property

        Public Property state() As String
            Get
                Return _state
            End Get
            Set(ByVal value As String)
                _state = value
            End Set
        End Property

        Public Property zip() As String
            Get
                Return _zip
            End Get
            Set(ByVal value As String)
                _zip = value
            End Set
        End Property

        Public Property hire_date() As Date
            Get
                Return _hire_date
            End Get
            Set(ByVal value As Date)
                _hire_date = value
            End Set
        End Property

        Public Property current_pay_rate() As Decimal
            Get
                Return _current_pay_rate
            End Get
            Set(ByVal value As Decimal)
                _current_pay_rate = value
            End Set
        End Property

        Public Property position() As String
            Get
                Return _position
            End Get
            Set(ByVal value As String)
                _position = value
            End Set
        End Property

        Public Property manager_id() As Integer
            Get
                Return _manager_id
            End Get
            Set(ByVal value As Integer)
                _manager_id = value
            End Set
        End Property

        Public Property vacation_time() As Integer
            Get
                Return _vacation_time
            End Get
            Set(ByVal value As Integer)
                _vacation_time = value
            End Set
        End Property

        Public Property personal_time() As Integer
            Get
                Return _personal_time
            End Get
            Set(ByVal value As Integer)
                _personal_time = value
            End Set
        End Property

    End Class

End Namespace