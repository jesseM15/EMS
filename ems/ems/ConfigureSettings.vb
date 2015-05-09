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
                        Case "AllowAutoLogIn"
                            _allowAutoLogIn = reader.Value
                            Exit Select
                    End Select
                    Exit Select
            End Select
        End While
        reader.Close()
        reader.Dispose()
    End Sub

    Public Sub setXMLData()
        Dim doc As New XmlDocument()
        doc.Load("C:\Users\J\Documents\ems_repository\ems\DBlib\Admin.xml")
        If Form1.radAutoLogInAllow.Checked = True Then
            doc.SelectSingleNode("Admin/Settings/User/AllowAutoLogIn").InnerText = True
        ElseIf Form1.radAutoLogInDeny.Checked = True Then
            doc.SelectSingleNode("Admin/Settings/User/AllowAutoLogIn").InnerText = False
        End If
        doc.Save("C:\Users\J\Documents\ems_repository\ems\DBlib\Admin.xml")

    End Sub

End Class
