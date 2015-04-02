'Imports DBlib.DBSQL

Public Class Form1
    'Private dbems As New dbconnection(My.Settings.DbEmsConnectionString)
    Public loggedin As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Show()
        Login.ShowDialog()
        If loggedin = True Then
            Label1.Text = "Logged in successfully!"
            'LogInOutToolStripMenuItem.Text = "Log Out"
        End If
    End Sub
End Class
