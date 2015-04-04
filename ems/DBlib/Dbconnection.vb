Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Imports EMSlib.EMS

Namespace DBSQL

    Public Class Dbconnection
        Private _con As String
        Private _cmd As SqlCommand

        'Constructor for a new dbconnection instance
        Public Sub New(con As String)
            _con = con
        End Sub

        'sets the connection string for the database
        Public Sub setConnectionString(con As String)
            _con = con
        End Sub

        'gets the database connection string
        Public Function getConnectionString() As String
            Return _con
        End Function

        'initialize an sql command
        Private Sub initCommand()
            _cmd = New SqlCommand
            _cmd.Connection = New SqlConnection(_con)
            _cmd.CommandType = CommandType.Text
        End Sub

        'returns a datatable from a table using all columns
        Public Function getDataTable(table As String) As DataTable
            initCommand()
            _cmd.CommandText += "SELECT * FROM " + table
            Dim da As SqlDataAdapter
            Dim dt As New DataTable()
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
            da = New SqlDataAdapter(_cmd)
            da.Fill(dt)
            _cmd.Connection.Close()
            Return dt
        End Function

        'returns a datatable from a table using a string array as column names
        Public Function getDataTable(table As String, columns As String()) As DataTable
            initCommand()
            _cmd.CommandText = "SELECT "
            Dim c As Integer = 1
            For Each column In columns
                _cmd.CommandText += column
                If columns.Count > c Then
                    _cmd.CommandText += ", "
                Else
                    _cmd.CommandText += " "
                End If
                c += 1
            Next
            _cmd.CommandText += "FROM " + table
            Dim da As SqlDataAdapter
            Dim dt As New DataTable()
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
            da = New SqlDataAdapter(_cmd)
            da.Fill(dt)
            _cmd.Connection.Close()
            Return dt
        End Function

        'returns the number of rows in a table
        Public Function getTableCount(table As String) As Integer
            initCommand()
            _cmd.CommandText = "SELECT COUNT(*) FROM " + table
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
            Dim numEmployees As Integer = CInt(_cmd.ExecuteScalar)
            _cmd.Connection.Close()
            Return numEmployees
        End Function

        'checks to see if login credentials exist in the database
        Public Function checkLogIn(username As String, password As String) As Boolean
            initCommand()
            _cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE user_name='" & username & "' AND password='" & password & "'"
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
            Dim matchCredentials As Integer = CInt(_cmd.ExecuteScalar)
            _cmd.Connection.Close()
            If matchCredentials = 1 Then
                Return True
            Else
                Return False
            End If
        End Function

        'returns the id of the user logging in
        Public Function getLogInID(username As String, password As String) As Integer
            initCommand()
            _cmd.CommandText = "SELECT id FROM Users WHERE user_name='" & username & "' AND password='" & password & "'"
            _cmd.Connection.Open()
            Dim id As Integer = CInt(_cmd.ExecuteScalar())
            _cmd.Connection.Close()
            Return id
        End Function

        'gets the user data by id and returns a User object with the user's data
        Public Function getSession(ByVal id As Integer) As User
            initCommand()
            _cmd.CommandText = "SELECT * FROM Users WHERE id=" & id
            _cmd.Connection.Open()
            'Dim results As New System.Text.StringBuilder
            Dim r As IAsyncResult = _cmd.BeginExecuteReader
            Dim reader As SqlDataReader = _cmd.EndExecuteReader(r)
            Dim u As New User()
            While reader.Read
                u.id = reader(0)
                u.user_name = reader(1)
                u.password = reader(2)
                u.user_type = reader(3)
                u.first_name = reader(4)
                u.last_name = reader(5)
                u.address = reader(6)
                u.city = reader(7)
                u.state = reader(8)
                u.zip = reader(9)
                u.hire_date = reader(10)
                u.pay_rate = reader(11)
                u.position = reader(12)
                u.manager_id = reader(13)
            End While
            reader.Close()
            _cmd.Connection.Close()
            Return u
        End Function

        'returns the user_type from the user id
        Public Function getUserType(id As Integer) As String
            initCommand()
            _cmd.CommandText = "SELECT user_type FROM Users WHERE id=" & id
            _cmd.Connection.Open()
            Dim userType As String = CStr(_cmd.ExecuteScalar())
            _cmd.Connection.Close()
            Return userType
        End Function

        'returns a list of employee names in xml format
        Public Function getXML() As String
            initCommand()
            _cmd.CommandText = "Select firstname,lastname from employees for XML Auto"
            _cmd.Connection.Open()
            Dim reader As XmlReader = _cmd.ExecuteXmlReader()
            Dim myXML As String = ""
            reader.Read()
            Do While reader.ReadState <> ReadState.EndOfFile
                myXML += reader.ReadOuterXml().ToString() & vbCrLf
            Loop
            reader.Close()
            _cmd.Connection.Close()
            Return myXML
        End Function
    End Class

End Namespace


