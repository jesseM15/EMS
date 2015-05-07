Imports System.Xml
Imports System.IO

Public Class BusinessData
    Private _companyName As String
    Private _companyPhone As String
    Private _companyAddress As String
    Private _companyCity As String
    Private _companyState As String
    Private _companyZip As String

    Private _WorkPeriodLength As Integer

    Public Sub New()
        _companyName = ""
        _companyPhone = ""
        _companyAddress = ""
        _companyCity = ""
        _companyState = ""
        _companyZip = ""

        _WorkPeriodLength = 7
    End Sub

    Public Property companyName As String
        Get
            Return _companyName
        End Get
        Set(value As String)
            _companyName = value
        End Set
    End Property

    Public Property companyPhone As String
        Get
            Return _companyPhone
        End Get
        Set(value As String)
            _companyPhone = value
        End Set
    End Property

    Public Property companyAddress As String
        Get
            Return _companyAddress
        End Get
        Set(value As String)
            _companyAddress = value
        End Set
    End Property

    Public Property companyCity As String
        Get
            Return _companyCity
        End Get
        Set(value As String)
            _companyCity = value
        End Set
    End Property

    Public Property companyState As String
        Get
            Return _companyState
        End Get
        Set(value As String)
            _companyState = value
        End Set
    End Property

    Public Property companyZip As String
        Get
            Return _companyZip
        End Get
        Set(value As String)
            _companyZip = value
        End Set
    End Property

    Public Property workPeriodLength As Integer
        Get
            Return _WorkPeriodLength
        End Get
        Set(value As Integer)
            _WorkPeriodLength = value
        End Set
    End Property

    Public Sub initBusinessDataPanel()
        getXMLData()
        Form1.txtCompanyName.Text = _companyName
        Form1.mtxCompanyPhone.Text = _companyPhone
        Form1.txtCompanyAddress.Text = _companyAddress
        Form1.txtCompanyCity.Text = _companyCity
        Form1.txtCompanyState.Text = _companyState
        Form1.txtCompanyZip.Text = _companyZip
        If _WorkPeriodLength = 7 Then
            Form1.radWorkPeriodWeekly.Checked = True
        ElseIf _WorkPeriodLength = 14 Then
            Form1.radWorkPeriodBiweekly.Checked = True
        End If

        Form1.pnlBusinessData.Visible = True
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
                        Case "CompanyName"
                            _companyName = reader.Value
                            Exit Select
                        Case "CompanyPhone"
                            _companyPhone = reader.Value
                            Exit Select
                        Case "CompanyAddress"
                            _companyAddress = reader.Value
                            Exit Select
                        Case "CompanyCity"
                            _companyCity = reader.Value
                            Exit Select
                        Case "CompanyState"
                            _companyState = reader.Value
                            Exit Select
                        Case "CompanyZip"
                            _companyZip = reader.Value
                            Exit Select
                        Case "WorkPeriod"
                            _WorkPeriodLength = reader.Value
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
        doc.SelectSingleNode("Admin/Business/Info/CompanyName").InnerText = Form1.txtCompanyName.Text
        doc.SelectSingleNode("Admin/Business/Info/CompanyPhone").InnerText = Form1.mtxCompanyPhone.Text
        doc.SelectSingleNode("Admin/Business/Info/CompanyAddress").InnerText = Form1.txtCompanyAddress.Text
        doc.SelectSingleNode("Admin/Business/Info/CompanyCity").InnerText = Form1.txtCompanyCity.Text
        doc.SelectSingleNode("Admin/Business/Info/CompanyState").InnerText = Form1.txtCompanyState.Text
        doc.SelectSingleNode("Admin/Business/Info/CompanyZip").InnerText = Form1.txtCompanyZip.Text
        If Form1.radWorkPeriodWeekly.Checked = True Then
            doc.SelectSingleNode("Admin/Business/WorkPeriod").InnerText = 7
        ElseIf Form1.radWorkPeriodBiweekly.Checked = True Then
            doc.SelectSingleNode("Admin/Business/WorkPeriod").InnerText = 14
        End If
        doc.Save("C:\Users\J\Documents\ems_repository\ems\DBlib\Admin.xml")

    End Sub

End Class
