Imports System.Windows.Forms
Imports System.IO

Namespace EMS

    Public Class ErrorHandler
        Private _errorMessage As String
        Private _exceptionMessage As String

        Public Sub New()
            _errorMessage = ""
            _exceptionMessage = ""
        End Sub

        Public Property errorMessage() As String
            Get
                Return _errorMessage
            End Get
            Set(value As String)
                _errorMessage = value
            End Set
        End Property

        Public Property exceptionMessage() As String
            Get
                Return _exceptionMessage
            End Get
            Set(value As String)
                _exceptionMessage = value
            End Set
        End Property

        Public Sub outputMessage()
            MessageBox.Show(_exceptionMessage, "Error: " & _errorMessage)
            Try
                Dim objWriter As New System.IO.StreamWriter(Application.StartupPath & "\errorlog.txt", True)
                objWriter.WriteLine("Error: " & DateAndTime.Now)
                objWriter.WriteLine(_errorMessage)
                objWriter.WriteLine(_exceptionMessage)
                objWriter.WriteLine(vbCrLf)
                objWriter.Close()
            Catch ex As Exception
                MessageBox.Show("Error logging failed.")
            End Try
        End Sub

    End Class

End Namespace