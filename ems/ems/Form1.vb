Imports DBlib.DBSQL
Imports EMSlib.EMS

Public Class Form1
    Private dbems As New Dbconnection(My.Settings.DbEmsConnectionString)
    Public session As New User

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Show()
        Login.ShowDialog()
        lblName.Text = session.first_name + " " + session.last_name
        grbHome.Visible = True

    End Sub
End Class
