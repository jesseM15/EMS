Imports System.Xml
Imports System.IO

Public Class ConfigureSettings
    Private _allowAutoLogIn As Boolean

    Public Sub New()
        _allowAutoLogIn = False
    End Sub

    Public Property allowAutoLogIn As Boolean
        Get
            Return _allowAutoLogIn
        End Get
        Set(value As Boolean)
            _allowAutoLogIn = value
        End Set
    End Property

    Public Sub initConfigureSettingsPanel()
        getXMLData()
        If _allowAutoLogIn = True Then
            Form1.radAutoLogInAllow.Checked = True
        Else
            Form1.radAutoLogInDeny.Checked = True
        End If

        Form1.pnlConfigureSettings.Visible = True
    End Sub

    Public Sub getXMLData()
        Try
            'Create the XmlDocument. 
            If System.IO.File.Exists(Application.StartupPath & "\Admin.xml") Then
                Dim reader As New XmlTextReader(Application.StartupPath & "\Admin.xml")
                Dim elemName As String = ""
                While reader.Read()
                    Select Case reader.NodeType
                        Case XmlNodeType.Element
                            elemName = reader.Name
                            Exit Select
                        Case XmlNodeType.Text
                            Select Case elemName
                                Case "AllowAutoLogIn"
                                    _allowAutoLogIn = reader.Value
                                    Exit Select
                            End Select
                            Exit Select
                    End Select
                End While
                reader.Close()
                reader.Dispose()
            End If
        Catch ex As Exception
            err.errorMessage = "Failed to read XML file."
            err.exceptionMessage = ex.Message
            err.outputMessage()
        End Try
    End Sub

    Public Sub setXMLData()
        Try
            Dim doc As New XmlDocument()
            If System.IO.File.Exists(Application.StartupPath & "\Admin.xml") Then
                doc.Load(Application.StartupPath & "\Admin.xml")
                If Form1.radAutoLogInAllow.Checked = True Then
                    doc.SelectSingleNode("Admin/Settings/User/AllowAutoLogIn").InnerText = True
                ElseIf Form1.radAutoLogInDeny.Checked = True Then
                    doc.SelectSingleNode("Admin/Settings/User/AllowAutoLogIn").InnerText = False
                End If
                doc.Save(Application.StartupPath & "\Admin.xml")
            End If
        Catch ex As Exception
            err.errorMessage = "Failed to write to XML file."
            err.exceptionMessage = ex.Message
            err.outputMessage()
        End Try
    End Sub

End Class
