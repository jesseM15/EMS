Imports DBlib.DBSQL
Imports EMSlib.EMS

Module globals
    Public admin As Admin
    Public dbems As DbConnection
    Public time As Time
    Public user As User
    Public pay As PaySlip
    Public vacReq As VacationRequest
    Public msgs As Messages

    Public employees As ViewEmployees
    Public mngVac As ManageVacations
    Public report As Reports

    Public Sub initSession()
        admin = New Admin
        dbems = New DbConnection(My.Settings.DbEmsConnectionString)
        time = New Time
        user = New User
        pay = New PaySlip
        vacReq = New VacationRequest
        msgs = New Messages

        employees = New ViewEmployees
        mngVac = New ManageVacations
        report = New Reports
    End Sub

End Module
