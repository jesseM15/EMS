Imports System.Xml
Imports System.IO

Namespace EMS

    Public Class Admin
        Private _workPeriod As Integer
        Private _workStartDate As Date
        Private _allowAutoLogin As Boolean

        Public Sub New()
            'Create the XmlDocument. 
            Dim reader As New XmlTextReader("C:\Users\J\Documents\ems_repository\ems\DBlib\Admin.xml")
            Dim elemName As String = ""
            While reader.Read()
                Select Case reader.NodeType
                    Case XmlNodeType.Element
                        elemName = reader.Name
                        Exit Select
                    Case XmlNodeType.Text
                        Select Case elemName
                            Case "WorkPeriod"
                                _workPeriod = reader.Value
                                Exit Select
                            Case "AllowAutoLogin"
                                _allowAutoLogin = reader.Value
                        End Select
                        Exit Select
                End Select
            End While
        End Sub

        Public Property workPeriod() As Integer
            Get
                Return _workPeriod
            End Get
            Set(value As Integer)
                _workPeriod = value
            End Set
        End Property

        Public Property workStartDate() As Date
            Get
                Return _workStartDate
            End Get
            Set(value As Date)
                _workStartDate = value
            End Set
        End Property

        Public Property allowAutoLogin() As Boolean
            Get
                Return _allowAutoLogin
            End Get
            Set(value As Boolean)
                _allowAutoLogin = value
            End Set
        End Property

    End Class

End Namespace
