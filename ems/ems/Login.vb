Imports DBlib.DBSQL

Public Class Login
    Private dbems As New Dbconnection(My.Settings.DbEmsConnectionString)

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        txtUserName.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If dbems.checkLogIn(txtUserName.Text, txtPassword.Text) = True Then
            user = dbems.getSession(dbems.getLogInID(txtUserName.Text, txtPassword.Text))
            Me.Close()
        Else
            MessageBox.Show("Username and/or password not found.")
        End If
    End Sub

End Class