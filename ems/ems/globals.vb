Imports DBlib.DBSQL
Imports EMSlib.EMS

Module globals
    Public admin As New Admin
    Public dbems As New DbConnection(My.Settings.DbEmsConnectionString)
    Public time As New Time
    Public user As New User
    Public pay As New PaySlip
    Public vacReq As New VacationRequest
    Public msgs As New Messages

    Public employees As New ViewEmployees

End Module
