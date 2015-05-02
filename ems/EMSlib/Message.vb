Namespace EMS

    Public Class Message
        Private _id As Integer
        Private _userId As Integer
        Private _senderId As Integer
        Private _message As String
        Private _timeStamp As Date
        Private _viewed As Boolean

        Public Sub New()
            _id = 0
            _userId = 0
            _senderId = 0
            _message = ""
            _timeStamp = New Date()
            _viewed = False
        End Sub

        Public Property id() As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

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

        Public Property viewed() As Boolean
            Get
                Return _viewed
            End Get
            Set(value As Boolean)
                _viewed = value
            End Set
        End Property



    End Class

End Namespace