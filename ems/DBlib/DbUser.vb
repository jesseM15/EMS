Imports EMSlib.EMS
Imports System.Data.SqlClient

Namespace DBSQL

    Public Class DbUser
        Inherits DbConnection

        Public Sub New(ByVal con As String)
            MyBase.New(con)

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
                u.pay_rate = reader(11)
                u.position = reader(12)
                u.manager_id = reader(13)
            End While
            reader.Close()
            _cmd.Connection.Close()
            Return u
        End Function

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

    End Class

End Namespace


