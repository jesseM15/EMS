Imports EMSlib.EMS
Imports System.Data.SqlClient
Imports System.Xml

Namespace DBSQL

    Public Class DbConnection
        Private _con As String
        Private _cmd As SqlCommand

        '===Initialization======================================================================

        'Constructor for a new dbconnection instance
        Public Sub New(ByVal con As String)
            _con = con
            _cmd = New SqlCommand
        End Sub

        'sets the connection string for the database
        Public Sub setConnectionString(ByVal con As String)
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

        '===User=================================================================================

        'gets the user data by id and returns a User object with the user's data
        Public Function getSession(ByVal id As Integer) As User
            initCommand()
            _cmd.CommandText = "SELECT * FROM Users WHERE id=@id"
            _cmd.Parameters.AddWithValue("@id", id)
            _cmd.Connection.Open()
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
                u.current_pay_rate = reader(11)
                u.position = reader(12)
                u.manager_id = reader(13)
                u.vacation_time = reader(14)
                u.personal_time = reader(15)
            End While
            reader.Close()
            _cmd.Connection.Close()
            Return u
        End Function

        'checks that a user name is available
        Public Function isAvailableUserName(ByVal user_name As String) As Boolean
            initCommand()
            _cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE user_name=@uName"
            _cmd.Parameters.AddWithValue("@uName", user_name)
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
            Dim matchName As Integer = CInt(_cmd.ExecuteScalar)
            _cmd.Connection.Close()
            If matchName > 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        'adds a user
        Public Sub addUser(ByVal user As User)
            initCommand()
            _cmd.CommandText = "INSERT INTO Users VALUES (@user_name, @password, @user_type, @first_name, @last_name, @address, @city, @state, @zip, @hire_date, @current_pay_rate, @position, @manager_id, @vacation_time, @personal_time)"
            _cmd.Parameters.AddWithValue("@id", user.id)
            _cmd.Parameters.AddWithValue("@user_name", user.user_name)
            _cmd.Parameters.AddWithValue("@password", user.password)
            _cmd.Parameters.AddWithValue("@user_type", user.user_type)
            _cmd.Parameters.AddWithValue("@first_name", user.first_name)
            _cmd.Parameters.AddWithValue("@last_name", user.last_name)
            _cmd.Parameters.AddWithValue("@address", user.address)
            _cmd.Parameters.AddWithValue("@city", user.city)
            _cmd.Parameters.AddWithValue("@state", user.state)
            _cmd.Parameters.AddWithValue("@zip", user.zip)
            _cmd.Parameters.AddWithValue("@hire_date", user.hire_date)
            _cmd.Parameters.AddWithValue("@current_pay_rate", user.current_pay_rate)
            _cmd.Parameters.AddWithValue("@position", user.position)
            _cmd.Parameters.AddWithValue("@manager_id", user.manager_id)
            _cmd.Parameters.AddWithValue("@vacation_time", user.vacation_time)
            _cmd.Parameters.AddWithValue("@personal_time", user.personal_time)
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
            _cmd.Connection.Close()
        End Sub

        'updates a user
        Public Sub updateUser(ByVal user As User)
            initCommand()
            _cmd.CommandText = "UPDATE Users SET user_name=@user_name, password=@password, user_type=@user_type, first_name=@first_name, last_name=@last_name, address=@address, city=@city, state=@state, zip=@zip, hire_date=@hire_date, current_pay_rate=@current_pay_rate, position=@position, manager_id=@manager_id, vacation_time=@vacation_time, personal_time=@personal_time WHERE id=@id"
            'Dim uName As String = Mid(user.last_name, 1, 16)
            'uName += Mid(user.first_name, 1, 1)
            'If isAvailableUserName(uName) = False Then
            '    Dim c As Integer = 1
            '    While isAvailableUserName(uName & c.ToString()) = False
            '        c += 1
            '    End While
            '    uName = uName & c.ToString()
            'End If

            _cmd.Parameters.AddWithValue("@id", user.id)
            _cmd.Parameters.AddWithValue("@user_name", user.user_name)
            _cmd.Parameters.AddWithValue("@password", user.password)
            _cmd.Parameters.AddWithValue("@user_type", user.user_type)
            _cmd.Parameters.AddWithValue("@first_name", user.first_name)
            _cmd.Parameters.AddWithValue("@last_name", user.last_name)
            _cmd.Parameters.AddWithValue("@address", user.address)
            _cmd.Parameters.AddWithValue("@city", user.city)
            _cmd.Parameters.AddWithValue("@state", user.state)
            _cmd.Parameters.AddWithValue("@zip", user.zip)
            _cmd.Parameters.AddWithValue("@hire_date", user.hire_date)
            _cmd.Parameters.AddWithValue("@current_pay_rate", user.current_pay_rate)
            _cmd.Parameters.AddWithValue("@position", user.position)
            _cmd.Parameters.AddWithValue("@manager_id", user.manager_id)
            _cmd.Parameters.AddWithValue("@vacation_time", user.vacation_time)
            _cmd.Parameters.AddWithValue("@personal_time", user.personal_time)
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
            _cmd.Connection.Close()
        End Sub

        'removes a user
        Public Sub removeUser(ByVal id As Integer)
            initCommand()
            _cmd.CommandText = "DELETE FROM Users WHERE id=@id"
            _cmd.Parameters.AddWithValue("@id", id)
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
            _cmd.Connection.Close()
        End Sub


        '===LogIn/Out==============================================================================

        'checks to see if login credentials exist in the database
        Public Function checkLogIn(user_name As String, password As String) As Boolean
            initCommand()
            _cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE user_name=@user_name AND password=@password"
            _cmd.Parameters.AddWithValue("@user_name", user_name)
            _cmd.Parameters.AddWithValue("@password", password)
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
        Public Function getLogInID(user_name As String, password As String) As Integer
            initCommand()
            _cmd.CommandText = "SELECT id FROM Users WHERE user_name=@user_name AND password=@password"
            _cmd.Parameters.AddWithValue("@user_name", user_name)
            _cmd.Parameters.AddWithValue("@password", password)
            _cmd.Connection.Open()
            Dim id As Integer = CInt(_cmd.ExecuteScalar())
            _cmd.Connection.Close()
            Return id
        End Function

        'changes the user's password
        Public Sub changePassword(id As Integer, newPassword As String)
            initCommand()
            _cmd.CommandText = "UPDATE Users SET password=@newPassword WHERE id=@id"
            _cmd.Parameters.AddWithValue("@id", id)
            _cmd.Parameters.AddWithValue("@newPassword", newPassword)
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
            _cmd.Connection.Close()
        End Sub

        '===ClockIn/Out==============================================================================

        'returns true if current user has Times data that does not have a time_end value
        Public Function isClockedIn(ByVal user_id As Integer) As Boolean
            initCommand()
            _cmd.CommandText = "SELECT COUNT(*) FROM Times WHERE user_id=@user_id AND time_end IS NULL"
            _cmd.Parameters.AddWithValue("@user_id", user_id)
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
            Dim numClockIn As Integer = CInt(_cmd.ExecuteScalar)
            _cmd.Connection.Close()
            If numClockIn > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Sub clockIn(ByVal user_id As Integer, Optional ByVal hours_type As String = "Regular")
            initCommand()
            _cmd.CommandText = "INSERT INTO Times (user_id,time_start,hours_type) VALUES (@user_id, @time_start, @hours_type)"
            _cmd.Parameters.AddWithValue("@user_id", user_id)
            _cmd.Parameters.AddWithValue("@time_start", DateAndTime.Now)
            _cmd.Parameters.AddWithValue("@hours_type", hours_type)
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
            _cmd.Connection.Close()
        End Sub

        Public Sub clockOut(ByVal user_id As Integer)
            initCommand()
            _cmd.CommandText = "UPDATE Times SET time_end=@time_end WHERE user_id=@user_id AND time_end IS NULL"
            _cmd.Parameters.AddWithValue("@user_id", user_id)
            _cmd.Parameters.AddWithValue("@time_end", DateAndTime.Now)
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
            _cmd.Connection.Close()
        End Sub

        Public Function getHoursWorked(ByVal user_id As Integer, ByVal hours_type As String, ByVal HoursStart As Date, ByVal HoursEnd As Date) As TimeSpan
            initCommand()
            _cmd.CommandText = "SELECT * FROM Times WHERE user_id=@user_id AND hours_type=@hours_type AND time_end IS NOT NULL AND time_start BETWEEN @HoursStart AND @HoursEnd"
            _cmd.Parameters.AddWithValue("@user_id", user_id)
            _cmd.Parameters.AddWithValue("@hours_type", hours_type)
            _cmd.Parameters.AddWithValue("@HoursStart", HoursStart)
            _cmd.Parameters.AddWithValue("@HoursEnd", HoursEnd)
            _cmd.Connection.Open()
            Dim r As IAsyncResult = _cmd.BeginExecuteReader
            Dim reader As SqlDataReader = _cmd.EndExecuteReader(r)
            Dim ts As New TimeSpan
            While reader.Read
                ts += reader(3) - reader(2)
            End While
            reader.Close()
            _cmd.Connection.Close()
            Return ts
        End Function

        '===Vacation Requests====================================================================

        'gets a collection of the user's times with an hours_type of Requested
        Public Function getVacationRequests(ByVal user_id As Integer) As Collection
            initCommand()
            _cmd.CommandText = "SELECT * FROM Times WHERE user_id=@user_id AND hours_type='Requested'"
            _cmd.Parameters.AddWithValue("@user_id", user_id)
            _cmd.Connection.Open()
            Dim r As IAsyncResult = _cmd.BeginExecuteReader
            Dim reader As SqlDataReader = _cmd.EndExecuteReader(r)
            Dim req As New Collection
            While reader.Read
                req.Add(reader(2))
            End While
            reader.Close()
            _cmd.Connection.Close()
            Return req
        End Function

        'gets a collection of the user's times with an hours_type of Vacation
        Public Function getScheduledVacation(ByVal user_id As Integer) As Collection
            initCommand()
            _cmd.CommandText = "SELECT * FROM Times WHERE user_id=@user_id AND hours_type='Vacation'"
            _cmd.Parameters.AddWithValue("@user_id", user_id)
            _cmd.Connection.Open()
            Dim r As IAsyncResult = _cmd.BeginExecuteReader
            Dim reader As SqlDataReader = _cmd.EndExecuteReader(r)
            Dim req As New Collection
            While reader.Read
                req.Add(reader(2))
            End While
            reader.Close()
            _cmd.Connection.Close()
            Return req
        End Function

        'submits a vacation request
        Public Sub submitVacationRequest(ByVal user_id As Integer, ByVal dateRequested As Date)
            initCommand()
            _cmd.CommandText = "INSERT INTO Times (user_id,time_start,time_end,hours_type) VALUES (@user_id,@time_start,@time_end,'Requested')"
            _cmd.Parameters.AddWithValue("@user_id", user_id)
            _cmd.Parameters.AddWithValue("@time_start", dateRequested)
            _cmd.Parameters.AddWithValue("@time_end", dateRequested.AddHours(8))
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
            _cmd.Connection.Close()
        End Sub

        'schedules a requested vacation day
        Public Sub approveVacationRequest(ByVal id As Integer)
            initCommand()
            _cmd.CommandText = "UPDATE Times SET hours_type='Vacation' WHERE id=@id"
            _cmd.Parameters.AddWithValue("@id", id)
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
            _cmd.Connection.Close()
        End Sub

        'removes a requested vacation day
        Public Sub denyVacationRequest(ByVal id As Integer)
            initCommand()
            _cmd.CommandText = "DELETE FROM Times WHERE id=@id"
            _cmd.Parameters.AddWithValue("@id", id)
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
            _cmd.Connection.Close()
        End Sub

        '===Messages=============================================================================

        'sends vacation request message
        Public Sub sendMessage(ByVal msg As Message)
            initCommand()
            _cmd.CommandText = "INSERT INTO Messages (user_id,sender_id,message,time_stamp,viewed) VALUES (@user_id,@sender_id,@message,@time_stamp,0)"
            _cmd.Parameters.AddWithValue("@user_id", msg.userId)
            _cmd.Parameters.AddWithValue("@sender_id", msg.senderId)
            _cmd.Parameters.AddWithValue("@message", msg.message)
            _cmd.Parameters.AddWithValue("@time_stamp", DateAndTime.Now)
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
            _cmd.Connection.Close()
        End Sub

        'gets all the messages in the inbox
        Public Function getInboxMessages(ByVal user_id As Integer) As Collection
            initCommand()
            _cmd.CommandText = "SELECT * FROM Messages WHERE user_id=@user_id AND viewed=0 ORDER BY time_stamp DESC"
            _cmd.Parameters.AddWithValue("@user_id", user_id)
            _cmd.Connection.Open()
            Dim messages As New Collection
            Dim r As IAsyncResult = _cmd.BeginExecuteReader
            Dim reader As SqlDataReader = _cmd.EndExecuteReader(r)
            While reader.Read
                Dim m As New Message
                m.id = reader("id")
                m.senderId = reader("sender_id")
                m.message = reader("message")
                m.timeStamp = reader("time_stamp")
                'm.viewed = reader("viewed")
                m.viewed = True
                messages.Add(m)
            End While
            reader.Close()
            _cmd.Connection.Close()
            For Each m In messages
                setMessageViewed(m.id)
            Next
            Return messages
        End Function

        Private Sub setMessageViewed(ByVal id As Integer)
            initCommand()
            _cmd.CommandText = "UPDATE Messages SET viewed='True' WHERE id=@id"
            _cmd.Parameters.AddWithValue("@id", id)
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
            _cmd.Connection.Close()
        End Sub

        'gets all the messages sent by the user
        Public Function getSentMessages(ByVal user_id As Integer) As Collection
            initCommand()
            _cmd.CommandText = "SELECT * FROM Messages WHERE sender_id=@user_id ORDER BY time_stamp DESC"
            _cmd.Parameters.AddWithValue("@user_id", user_id)
            _cmd.Connection.Open()
            Dim messages As New Collection
            Dim r As IAsyncResult = _cmd.BeginExecuteReader
            Dim reader As SqlDataReader = _cmd.EndExecuteReader(r)
            While reader.Read
                Dim m As New Message
                m.userId = reader("user_id")
                m.message = reader("message")
                m.timeStamp = reader("time_stamp")
                messages.Add(m)
            End While
            reader.Close()
            _cmd.Connection.Close()
            Return messages
        End Function

        'gets all the viewed messages
        Public Function getViewedMessages(ByVal user_id As Integer) As Collection
            initCommand()
            _cmd.CommandText = "SELECT * FROM Messages WHERE user_id=@user_id AND viewed=1 ORDER BY time_stamp DESC"
            _cmd.Parameters.AddWithValue("@user_id", user_id)
            _cmd.Connection.Open()
            Dim messages As New Collection
            Dim r As IAsyncResult = _cmd.BeginExecuteReader
            Dim reader As SqlDataReader = _cmd.EndExecuteReader(r)
            While reader.Read
                Dim m As New Message
                m.senderId = reader("sender_id")
                m.message = reader("message")
                m.timeStamp = reader("time_stamp")
                m.viewed = reader("viewed")
                messages.Add(m)
            End While
            reader.Close()
            _cmd.Connection.Close()
            Return messages
        End Function

        'gets the full name of user by id
        Public Function getUserName(ByVal id As Integer) As String
            initCommand()
            _cmd.CommandText = "SELECT * FROM Users WHERE id=@id"
            _cmd.Parameters.AddWithValue("@id", id)
            _cmd.Connection.Open()
            Dim name As String = ""
            Dim r As IAsyncResult = _cmd.BeginExecuteReader
            Dim reader As SqlDataReader = _cmd.EndExecuteReader(r)
            While reader.Read
                name += reader("first_name")
                name += " "
                name += reader("last_name")
            End While
            reader.Close()
            _cmd.Connection.Close()
            Return name
        End Function

        '===Manager==============================================================================

        'returns a datatable from Users by manager id
        Public Function getEmployees(ByVal id As Integer) As DataTable
            initCommand()
            _cmd.CommandText = "SELECT id, first_name, last_name, position, current_pay_rate, vacation_time, personal_time FROM Users WHERE manager_id=@id"
            _cmd.Parameters.AddWithValue("@id", id)
            Dim da As SqlDataAdapter
            Dim dt As New DataTable()
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
            da = New SqlDataAdapter(_cmd)
            da.Fill(dt)
            _cmd.Connection.Close()
            Return dt
        End Function

        'returns a collection of ids of users with manager-level or greater permission
        Public Function getManagers() As Collection
            initCommand()
            _cmd.CommandText = "SELECT * FROM Users WHERE user_type='Manager' OR user_type='Administrator'"
            _cmd.Connection.Open()
            Dim managers As New Collection
            Dim r As IAsyncResult = _cmd.BeginExecuteReader
            Dim reader As SqlDataReader = _cmd.EndExecuteReader(r)
            While reader.Read
                Dim u As New User
                u.id = reader("id")
                u.first_name = reader("first_name")
                u.last_name = reader("last_name")
                managers.Add(u)
            End While
            reader.Close()
            _cmd.Connection.Close()
            Return managers
        End Function

        'gets the id of the manager for a specified user id
        Public Function getManagerId(ByVal id As Integer) As Integer
            initCommand()
            _cmd.CommandText = "SELECT manager_id FROM Users WHERE id=@id"
            _cmd.Parameters.AddWithValue("@id", id)
            _cmd.Connection.Open()
            Dim manager_id As Integer = 0
            Dim r As IAsyncResult = _cmd.BeginExecuteReader
            Dim reader As SqlDataReader = _cmd.EndExecuteReader(r)
            While reader.Read
                manager_id = reader("manager_id")
            End While
            reader.Close()
            _cmd.Connection.Close()
            Return manager_id
        End Function

        'returns a datatable from Times of requested hours_type by manager id
        Public Function getEmployeeRequests(ByVal manager_id As Integer) As DataTable
            initCommand()
            _cmd.CommandText = "SELECT Users.id, Times.id, Users.first_name, Users.last_name, Times.time_start FROM Times INNER JOIN Users ON Times.user_id=Users.id WHERE Times.hours_type='Requested' AND manager_id=@manager_id"
            _cmd.Parameters.AddWithValue("@manager_id", manager_id)
            Dim da As SqlDataAdapter
            Dim dt As New DataTable()
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
            da = New SqlDataAdapter(_cmd)
            da.Fill(dt)
            _cmd.Connection.Close()
            Return dt
        End Function

        '===General==============================================================================

        'returns a datatable from a table using all columns
        Public Function getDataTable(ByVal table As String) As DataTable
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
        Public Function getDataTable(ByVal table As String, ByVal columns As String()) As DataTable
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
        Public Function getTableCount(ByVal table As String) As Integer
            initCommand()
            _cmd.CommandText = "SELECT COUNT(*) FROM " + table
            _cmd.Connection.Open()
            _cmd.ExecuteNonQuery()
            Dim numEmployees As Integer = CInt(_cmd.ExecuteScalar)
            _cmd.Connection.Close()
            Return numEmployees
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


