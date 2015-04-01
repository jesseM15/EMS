Imports DBlib.DBSQL

Public Class Form1
    Private dbems As New dbconnection(My.Settings.DbEmsConnectionString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvUsers.DataSource = dbems.getDataTable("Users")
    End Sub
End Class
