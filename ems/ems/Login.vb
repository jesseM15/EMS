Imports DBlib.DBSQL

Public Class Login
    Private dbems As New dbconnection(My.Settings.DbEmsConnectionString)

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        txtUserName.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If dbems.checkLogIn(txtUserName.Text, txtPassword.Text) = True Then
            Form1.loggedin = True
            Me.Close()
        Else
            MessageBox.Show("Username and/or password not found.")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub
End Class