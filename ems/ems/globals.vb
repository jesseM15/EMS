Imports DBlib.DBSQL
Imports EMSlib.EMS

Module globals
    Public dbems As DbConnection
    Public time As Time
    Public user As User
    Public pay As PaySlip
    Public vacReq As VacationRequest
    Public msgs As Messages

    Public employees As ViewEmployees
    Public mngVac As ManageVacations
    Public report As Reports
    Public busDat As BusinessData
    Public conSet As ConfigureSettings

    Public err As ErrorHandler

    Public Sub initSession()
        dbems = New DbConnection(My.Settings.EMSDBConnectionString)
        time = New Time
        user = New User
        pay = New PaySlip
        vacReq = New VacationRequest
        msgs = New Messages

        employees = New ViewEmployees
        mngVac = New ManageVacations
        report = New Reports
        busDat = New BusinessData
        busDat.getXMLData()
        conSet = New ConfigureSettings

        err = New ErrorHandler

        firstTimeProgramInitialization()
    End Sub

    Private Sub firstTimeProgramInitialization()
        'if no users exist in the database
        If dbems.getTableCount("Users") < 1 Then
            Dim u As New User
            u.user_name = "Admin"
            u.password = "password"
            u.user_type = "Administrator"
            u.hire_date = Date.Now
            dbems.addUser(u)
        End If
    End Sub

End Module
