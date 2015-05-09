Imports EMSlib.EMS
Imports System.Data.SqlClient
Imports System.Xml

Namespace DBSQL

    Public Class DbConnection
        Private _con As String
        Private _cmd As SqlCommand
        Private _err As ErrorHandler

        '===Initialization======================================================================

        'Constructor for a new dbconnection instance
        Public Sub New(ByVal con As String)
            _con = con
            _cmd = New SqlCommand
            _err = New ErrorHandler
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
            Try
                _cmd = New SqlCommand
                _cmd.Connection = New SqlConnection(_con)
                _cmd.CommandType = CommandType.Text
            Catch ex As Exception
                _err.errorMessage = "Failed to initialize database connection."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
        End Sub

        '===User=================================================================================

        'gets the user data by id and returns a User object with the user's data
        Public Function getSession(ByVal id As Integer) As User
            initCommand()
            Dim u As New User()
            Try
                _cmd.CommandText = "SELECT * FROM Users WHERE id=@id"
                _cmd.Parameters.AddWithValue("@id", id)
                _cmd.Connection.Open()
                Dim r As IAsyncResult = _cmd.BeginExecuteReader
                Dim reader As SqlDataReader = _cmd.EndExecuteReader(r)
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
            Catch ex As Exception
                _err.errorMessage = "Failed to get session information."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            Return u
        End Function

        'checks that a user name is available
        Public Function isAvailableUserName(ByVal user_name As String) As Boolean
            initCommand()
            Dim matchName As Integer = 0
            Try
                _cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE user_name=@uName"
                _cmd.Parameters.AddWithValue("@uName", user_name)
                _cmd.Connection.Open()
                _cmd.ExecuteNonQuery()
                matchName = CInt(_cmd.ExecuteScalar)
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to determine if user name is available."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            If matchName > 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        'adds a user
        Public Sub addUser(ByVal user As User)
            initCommand()
            Try
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
            Catch ex As Exception
                _err.errorMessage = "Failed to add user."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
        End Sub

        'updates a user
        Public Sub updateUser(ByVal user As User)
            initCommand()
            Try
                _cmd.CommandText = "UPDATE Users SET user_name=@user_name, password=@password, user_type=@user_type, first_name=@first_name, last_name=@last_name, address=@address, city=@city, state=@state, zip=@zip, hire_date=@hire_date, current_pay_rate=@current_pay_rate, position=@position, manager_id=@manager_id, vacation_time=@vacation_time, personal_time=@personal_time WHERE id=@id"
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
            Catch ex As Exception
                _err.errorMessage = "Failed to update user."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
        End Sub

        'removes a user
        Public Sub removeUser(ByVal id As Integer)
            initCommand()
            Try
                _cmd.CommandText = "DELETE FROM Users WHERE id=@id"
                _cmd.Parameters.AddWithValue("@id", id)
                _cmd.Connection.Open()
                _cmd.ExecuteNonQuery()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to remove user."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
        End Sub

        'gets the vacation time remaining for the user
        Public Function getVacationTime(ByVal id As Integer)
            initCommand()
            Dim vHours As Integer = 0
            Try
                _cmd.CommandText = "SELECT vacation_time FROM Users WHERE id=@id"
                _cmd.Parameters.AddWithValue("@id", id)
                _cmd.Connection.Open()
                _cmd.ExecuteNonQuery()
                vHours = CInt(_cmd.ExecuteScalar)
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to get vacation time."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            Return vHours
        End Function

        'gets the personal time remaining for the user
        Public Function getPersonalTime(ByVal id As Integer)
            initCommand()
            Dim pHours As Integer = 0
            Try
                _cmd.CommandText = "SELECT personal_time FROM Users WHERE id=@id"
                _cmd.Parameters.AddWithValue("@id", id)
                _cmd.Connection.Open()
                _cmd.ExecuteNonQuery()
                pHours = CInt(_cmd.ExecuteScalar)
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to get personal time."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            Return pHours
        End Function

        'subtracts 8 hours from the users vacation time
        Public Sub subtractVacationTime(ByVal id As Integer)
            initCommand()
            Try
                _cmd.CommandText = "UPDATE Users SET vacation_time=vacation_time-8 WHERE id=@id"
                _cmd.Parameters.AddWithValue("@id", id)
                _cmd.Connection.Open()
                _cmd.ExecuteNonQuery()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to subtract vacation time."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
        End Sub

        'subtracts 8 hours from the users persoanl time
        Public Sub subtractPersonalTime(ByVal id As Integer, ByVal hours As Integer)
            initCommand()
            Try
                _cmd.CommandText = "UPDATE Users SET personal_time=personal_time-@hours WHERE id=@id"
                _cmd.Parameters.AddWithValue("@id", id)
                _cmd.Parameters.AddWithValue("@hours", hours)
                _cmd.Connection.Open()
                _cmd.ExecuteNonQuery()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to subtract personal time."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
        End Sub

        'gets the hire date for a user
        Public Function getHireDate(ByVal id As Integer)
            initCommand()
            Dim hireDate As New Date
            Try
                _cmd.CommandText = "SELECT hire_date FROM Users WHERE id=@id"
                _cmd.Parameters.AddWithValue("@id", id)
                _cmd.Connection.Open()
                Dim r As IAsyncResult = _cmd.BeginExecuteReader
                Dim reader As SqlDataReader = _cmd.EndExecuteReader(r)

                While reader.Read
                    hireDate = reader("hire_date")
                End While
                reader.Close()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to get hire date."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            Return hireDate
        End Function

        '===LogIn/Out==============================================================================

        'checks to see if login credentials exist in the database
        Public Function checkLogIn(user_name As String, password As String) As Boolean
            initCommand()
            Dim matchCredentials As Integer = 0
            Try
                _cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE user_name=@user_name AND password=@password"
                _cmd.Parameters.AddWithValue("@user_name", user_name)
                _cmd.Parameters.AddWithValue("@password", password)
                _cmd.Connection.Open()
                _cmd.ExecuteNonQuery()
                matchCredentials = CInt(_cmd.ExecuteScalar)
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to determine if user is logged in."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            If matchCredentials = 1 Then
                Return True
            Else
                Return False
            End If
        End Function

        'returns the id of the user logging in
        Public Function getLogInID(user_name As String, password As String) As Integer
            initCommand()
            Dim id As Integer
            Try
                _cmd.CommandText = "SELECT id FROM Users WHERE user_name=@user_name AND password=@password"
                _cmd.Parameters.AddWithValue("@user_name", user_name)
                _cmd.Parameters.AddWithValue("@password", password)
                _cmd.Connection.Open()
                id = CInt(_cmd.ExecuteScalar())
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to get log in ID."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            Return id
        End Function

        'changes the user's password
        Public Sub changePassword(id As Integer, newPassword As String)
            initCommand()
            Try
                _cmd.CommandText = "UPDATE Users SET password=@newPassword WHERE id=@id"
                _cmd.Parameters.AddWithValue("@id", id)
                _cmd.Parameters.AddWithValue("@newPassword", newPassword)
                _cmd.Connection.Open()
                _cmd.ExecuteNonQuery()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to change password."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
        End Sub

        '===ClockIn/Out==============================================================================

        'returns true if current user has Times data that does not have a time_end value
        Public Function isClockedIn(ByVal user_id As Integer) As Boolean
            initCommand()
            Dim numClockIn As Integer = 0
            Try
                _cmd.CommandText = "SELECT COUNT(*) FROM Times WHERE user_id=@user_id AND time_end IS NULL"
                _cmd.Parameters.AddWithValue("@user_id", user_id)
                _cmd.Connection.Open()
                _cmd.ExecuteNonQuery()
                numClockIn = CInt(_cmd.ExecuteScalar)
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to determine if user is clocked in."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            If numClockIn > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Sub clockIn(ByVal user_id As Integer, ByVal pay_rate As Decimal, Optional ByVal hours_type As String = "Regular")
            initCommand()
            Try
                _cmd.CommandText = "INSERT INTO Times (user_id,time_start,pay_rate,hours_type) VALUES (@user_id, @time_start,@pay_rate, @hours_type)"
                _cmd.Parameters.AddWithValue("@user_id", user_id)
                _cmd.Parameters.AddWithValue("@time_start", DateAndTime.Now)
                _cmd.Parameters.AddWithValue("@pay_rate", pay_rate)
                _cmd.Parameters.AddWithValue("@hours_type", hours_type)
                _cmd.Connection.Open()
                _cmd.ExecuteNonQuery()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to clock in."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
        End Sub

        Public Sub clockOut(ByVal user_id As Integer)
            initCommand()
            Try
                _cmd.CommandText = "UPDATE Times SET time_end=@time_end WHERE user_id=@user_id AND time_end IS NULL"
                _cmd.Parameters.AddWithValue("@user_id", user_id)
                _cmd.Parameters.AddWithValue("@time_end", DateAndTime.Now)
                _cmd.Connection.Open()
                _cmd.ExecuteNonQuery()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to clock out."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
        End Sub

        'gets the hours worked for a user during a specified span of time
        Public Function getHoursWorked(ByVal user_id As Integer, ByVal hours_type As String, ByVal HoursStart As Date, ByVal HoursEnd As Date) As TimeSpan
            initCommand()
            Dim ts As New TimeSpan
            Try
                _cmd.CommandText = "SELECT * FROM Times WHERE user_id=@user_id AND hours_type=@hours_type AND time_end IS NOT NULL AND time_start BETWEEN @HoursStart AND @HoursEnd"
                _cmd.Parameters.AddWithValue("@user_id", user_id)
                _cmd.Parameters.AddWithValue("@hours_type", hours_type)
                _cmd.Parameters.AddWithValue("@HoursStart", HoursStart)
                _cmd.Parameters.AddWithValue("@HoursEnd", HoursEnd)
                _cmd.Connection.Open()
                Dim r As IAsyncResult = _cmd.BeginExecuteReader
                Dim reader As SqlDataReader = _cmd.EndExecuteReader(r)
                While reader.Read
                    ts += reader(3) - reader(2)
                End While
                reader.Close()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to get hours worked."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            Return ts
        End Function

        'gets the pay rate on the specified day of the work period
        Public Function getPeriodPayRate(ByVal user_id As Integer, ByVal workStart As Date) As Decimal
            initCommand()
            Dim payRate As Decimal = 0
            Try
                _cmd.CommandText = "SELECT * FROM Times WHERE user_id=@user_id AND time_start BETWEEN @workDayStart AND @workDayEnd"
                _cmd.Parameters.AddWithValue("@user_id", user_id)
                _cmd.Parameters.AddWithValue("@workDayStart", workStart)
                _cmd.Parameters.AddWithValue("@workDayEnd", workStart.AddHours(24).AddMinutes(-1))
                _cmd.Connection.Open()
                Dim r As IAsyncResult = _cmd.BeginExecuteReader
                Dim reader As SqlDataReader = _cmd.EndExecuteReader(r)

                While reader.Read
                    If IsDBNull(reader(5)) = False Then
                        payRate = reader(5)
                    End If
                End While
                reader.Close()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to get pay rate."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            Return payRate
        End Function

        'gets the first recorded work date
        Public Function getFirstWorkDate() As Date
            initCommand()
            Dim firstDate As New Date
            Try
                _cmd.CommandText = "SELECT MIN(time_start) FROM Times"
                _cmd.Connection.Open()
                firstDate = _cmd.ExecuteScalar()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to get first work date."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            Return firstDate.Date
        End Function

        '===Vacation Requests====================================================================

        'gets a collection of the user's times with an hours_type of Requested
        Public Function getVacationRequests(ByVal user_id As Integer) As Collection
            initCommand()
            Dim req As New Collection
            Try
                _cmd.CommandText = "SELECT * FROM Times WHERE user_id=@user_id AND hours_type='Requested'"
                _cmd.Parameters.AddWithValue("@user_id", user_id)
                _cmd.Connection.Open()
                Dim r As IAsyncResult = _cmd.BeginExecuteReader
                Dim reader As SqlDataReader = _cmd.EndExecuteReader(r)

                While reader.Read
                    req.Add(reader(2))
                End While
                reader.Close()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to get vacation requests."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            Return req
        End Function

        'gets a collection of the user's times with an hours_type of Vacation
        Public Function getScheduledVacation(ByVal user_id As Integer) As Collection
            initCommand()
            Dim req As New Collection
            Try
                _cmd.CommandText = "SELECT * FROM Times WHERE user_id=@user_id AND hours_type='Vacation'"
                _cmd.Parameters.AddWithValue("@user_id", user_id)
                _cmd.Connection.Open()
                Dim r As IAsyncResult = _cmd.BeginExecuteReader
                Dim reader As SqlDataReader = _cmd.EndExecuteReader(r)

                While reader.Read
                    req.Add(reader(2))
                End While
                reader.Close()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to get scheduled vacation."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            Return req
        End Function

        'submits a vacation request
        Public Sub submitVacationRequest(ByVal user_id As Integer, ByVal dateRequested As Date, ByVal pay_rate As Decimal)
            initCommand()
            Try
                _cmd.CommandText = "INSERT INTO Times (user_id,time_start,time_end,hours_type,pay_rate) VALUES (@user_id,@time_start,@time_end,'Requested',@pay_rate)"
                _cmd.Parameters.AddWithValue("@user_id", user_id)
                _cmd.Parameters.AddWithValue("@time_start", dateRequested)
                _cmd.Parameters.AddWithValue("@time_end", dateRequested.AddHours(8))
                _cmd.Parameters.AddWithValue("@pay_rate", pay_rate)
                _cmd.Connection.Open()
                _cmd.ExecuteNonQuery()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to submit vacation request."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
        End Sub

        'submits personal time
        Public Sub submitPersonalTime(ByVal user_id As Integer, ByVal dateRequested As Date, ByVal hours As Integer, ByVal pay_rate As Decimal)
            initCommand()
            Try
                _cmd.CommandText = "INSERT INTO Times (user_id,time_start,time_end,hours_type,pay_rate) VALUES (@user_id,@time_start,@time_end,'Personal',@pay_rate)"
                _cmd.Parameters.AddWithValue("@user_id", user_id)
                _cmd.Parameters.AddWithValue("@time_start", dateRequested)
                _cmd.Parameters.AddWithValue("@time_end", dateRequested.AddHours(hours))
                _cmd.Parameters.AddWithValue("@pay_rate", pay_rate)
                _cmd.Connection.Open()
                _cmd.ExecuteNonQuery()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to submit personal time."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
        End Sub

        'schedules a requested vacation day
        Public Sub approveVacationRequest(ByVal id As Integer)
            initCommand()
            Try
                _cmd.CommandText = "UPDATE Times SET hours_type='Vacation' WHERE id=@id"
                _cmd.Parameters.AddWithValue("@id", id)
                _cmd.Connection.Open()
                _cmd.ExecuteNonQuery()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to approve vacation request."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
        End Sub

        'schedules a requested vacation day
        Public Sub approveVacationRequest(ByVal user_id As Integer, ByVal time_start As Date)
            initCommand()
            Try
                _cmd.CommandText = "UPDATE Times SET hours_type='Vacation' WHERE user_id=@user_id AND hours_type='Requested' AND time_start=@time_start"
                _cmd.Parameters.AddWithValue("@user_id", user_id)
                _cmd.Parameters.AddWithValue("@time_start", time_start)
                _cmd.Connection.Open()
                _cmd.ExecuteNonQuery()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to approve vacation request."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
        End Sub

        'removes a requested vacation day
        Public Sub denyVacationRequest(ByVal id As Integer)
            initCommand()
            Try
                _cmd.CommandText = "DELETE FROM Times WHERE id=@id"
                _cmd.Parameters.AddWithValue("@id", id)
                _cmd.Connection.Open()
                _cmd.ExecuteNonQuery()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to deny vacation request."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
        End Sub

        '===Messages=============================================================================

        'sends vacation request message
        Public Sub sendMessage(ByVal msg As Message)
            initCommand()
            Try
                _cmd.CommandText = "INSERT INTO Messages (user_id,sender_id,message,time_stamp,viewed) VALUES (@user_id,@sender_id,@message,@time_stamp,0)"
                _cmd.Parameters.AddWithValue("@user_id", msg.userId)
                _cmd.Parameters.AddWithValue("@sender_id", msg.senderId)
                _cmd.Parameters.AddWithValue("@message", msg.message)
                _cmd.Parameters.AddWithValue("@time_stamp", DateAndTime.Now)
                _cmd.Connection.Open()
                _cmd.ExecuteNonQuery()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to send message."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
        End Sub

        'gets all the messages in the inbox
        Public Function getInboxMessages(ByVal user_id As Integer) As Collection
            initCommand()
            Dim messages As New Collection
            Try
                _cmd.CommandText = "SELECT * FROM Messages WHERE user_id=@user_id AND viewed=0 ORDER BY time_stamp DESC"
                _cmd.Parameters.AddWithValue("@user_id", user_id)
                _cmd.Connection.Open()
                Dim r As IAsyncResult = _cmd.BeginExecuteReader
                Dim reader As SqlDataReader = _cmd.EndExecuteReader(r)
                While reader.Read
                    Dim m As New Message
                    m.id = reader("id")
                    m.senderId = reader("sender_id")
                    m.message = reader("message")
                    m.timeStamp = reader("time_stamp")
                    m.viewed = True
                    messages.Add(m)
                End While
                reader.Close()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to get inbox messages."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            Return messages
        End Function

        Public Sub setMessageViewed(ByVal id As Integer)
            initCommand()
            Try
                _cmd.CommandText = "UPDATE Messages SET viewed='True' WHERE id=@id"
                _cmd.Parameters.AddWithValue("@id", id)
                _cmd.Connection.Open()
                _cmd.ExecuteNonQuery()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to send message to viewed."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
        End Sub

        'gets all the messages sent by the user
        Public Function getSentMessages(ByVal user_id As Integer) As Collection
            initCommand()
            Dim messages As New Collection
            Try
                _cmd.CommandText = "SELECT * FROM Messages WHERE sender_id=@user_id ORDER BY time_stamp DESC"
                _cmd.Parameters.AddWithValue("@user_id", user_id)
                _cmd.Connection.Open()
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
            Catch ex As Exception
                _err.errorMessage = "Failed to get sent messages."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            Return messages
        End Function

        'gets all the viewed messages
        Public Function getViewedMessages(ByVal user_id As Integer) As Collection
            initCommand()
            Dim messages As New Collection
            Try
                _cmd.CommandText = "SELECT * FROM Messages WHERE user_id=@user_id AND viewed=1 ORDER BY time_stamp DESC"
                _cmd.Parameters.AddWithValue("@user_id", user_id)
                _cmd.Connection.Open()

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
            Catch ex As Exception
                _err.errorMessage = "Failed to get viewed messages."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            Return messages
        End Function

        'gets the full name of user by id
        Public Function getUserName(ByVal id As Integer) As String
            initCommand()
            Dim name As String = ""
            Try
                _cmd.CommandText = "SELECT * FROM Users WHERE id=@id"
                _cmd.Parameters.AddWithValue("@id", id)
                _cmd.Connection.Open()

                Dim r As IAsyncResult = _cmd.BeginExecuteReader
                Dim reader As SqlDataReader = _cmd.EndExecuteReader(r)
                While reader.Read
                    name += reader("first_name")
                    name += " "
                    name += reader("last_name")
                End While
                reader.Close()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to get user's name."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            Return name
        End Function

        '===Manager==============================================================================

        'returns a datatable from Users by manager id
        Public Function getEmployees(ByVal id As Integer) As DataTable
            initCommand()
            Dim dt As New DataTable()
            Try
                _cmd.CommandText = "SELECT id, first_name, last_name, position, current_pay_rate, vacation_time, personal_time FROM Users WHERE manager_id=@id"
                _cmd.Parameters.AddWithValue("@id", id)
                Dim da As SqlDataAdapter
                _cmd.Connection.Open()
                _cmd.ExecuteNonQuery()
                da = New SqlDataAdapter(_cmd)
                da.Fill(dt)
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to get employees."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            Return dt
        End Function

        'returns a collection of ids for users by manager id
        Public Function getEmployeeIds(ByVal manager_id As Integer) As Collection
            initCommand()
            Dim employees As New Collection()
            Try
                _cmd.CommandText = "SELECT id FROM Users WHERE manager_id=@manager_id"
                _cmd.Parameters.AddWithValue("@manager_id", manager_id)
                _cmd.Connection.Open()
                Dim r As IAsyncResult = _cmd.BeginExecuteReader
                Dim reader As SqlDataReader = _cmd.EndExecuteReader(r)
                While reader.Read
                    employees.Add(reader("id"))
                End While
                reader.Close()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to get employee IDs."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            Return employees
        End Function

        'returns a collection of ids of users with manager-level or greater permission
        Public Function getManagers() As Collection
            initCommand()
            Dim managers As New Collection()
            Try
                _cmd.CommandText = "SELECT * FROM Users WHERE user_type='Manager' OR user_type='Administrator'"
                _cmd.Connection.Open()
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
            Catch ex As Exception
                _err.errorMessage = "Failed to get managers."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            Return managers
        End Function

        'gets the id of the manager for a specified user id
        Public Function getManagerId(ByVal id As Integer) As Integer
            initCommand()
            Dim manager_id As Integer = 0
            Try
                _cmd.CommandText = "SELECT manager_id FROM Users WHERE id=@id"
                _cmd.Parameters.AddWithValue("@id", id)
                _cmd.Connection.Open()
                Dim r As IAsyncResult = _cmd.BeginExecuteReader
                Dim reader As SqlDataReader = _cmd.EndExecuteReader(r)
                While reader.Read
                    manager_id = reader("manager_id")
                End While
                reader.Close()
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to get manager ID."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            Return manager_id
        End Function

        'returns a datatable from Times of requested hours_type by manager id
        Public Function getEmployeeRequests(ByVal manager_id As Integer) As DataTable
            initCommand()
            Dim dt As New DataTable()
            Try
                _cmd.CommandText = "SELECT Users.id, Times.id, Users.first_name, Users.last_name, Times.time_start FROM Times INNER JOIN Users ON Times.user_id=Users.id WHERE Times.hours_type='Requested' AND manager_id=@manager_id"
                _cmd.Parameters.AddWithValue("@manager_id", manager_id)
                Dim da As SqlDataAdapter
                _cmd.Connection.Open()
                _cmd.ExecuteNonQuery()
                da = New SqlDataAdapter(_cmd)
                da.Fill(dt)
                _cmd.Connection.Close()
            Catch ex As Exception
                _err.errorMessage = "Failed to get employee requests."
                _err.exceptionMessage = ex.Message
                _err.outputMessage()
            End Try
            Return dt
        End Function

    End Class

End Namespace


