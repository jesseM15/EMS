Namespace EMS

    Public Class Message
        Private _userId As Integer
        Private _senderId As Integer
        Private _message As String
        Private _timeStamp As Date
        Private _deleted As Boolean

        Public Sub New()
            _userId = 0
            _senderId = 0
            _message = ""
            _timeStamp = New Date()
            _deleted = False
        End Sub

        Public Property userId() As Integer
            Get
                Return _userId
            End Get
            Set(value As Integer)
                _userId = value
            End Set
        End Property

        Public Property senderId() As Integer
            Get
                Return _senderId
            End Get
            Set(value As Integer)
                _senderId = value
            End Set
        End Property

        Public Property message() As String
            Get
                Return _message
            End Get
            Set(value As String)
                _message = value
            End Set
        End Property

        Public Property timeStamp() As Date
            Get
                Return _timeStamp
            End Get
            Set(value As Date)
                _timeStamp = value
            End Set
        End Property

        Public Property deleted() As Boolean
            Get
                Return _deleted
            End Get
            Set(value As Boolean)
                _deleted = value
            End Set
        End Property

        

    End Class

End Namespace