Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        txtUserName.Clear()
        txtPassword.Clear()
        conSet.getXMLData()
        If conSet.allowAutoLogIn = True Then
            chkAutoLogIn.Visible = True
        Else
            chkAutoLogIn.Visible = False
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If dbems.checkLogIn(txtUserName.Text, txtPassword.Text) = True Then
            user = dbems.getSession(dbems.getLogInID(txtUserName.Text, txtPassword.Text))
            If chkAutoLogIn.Checked = True Then
                Try
                    Dim objWriter As New System.IO.StreamWriter(Application.StartupPath & "\autologin.txt", True)
                    objWriter.WriteLine(user.user_name)
                    objWriter.WriteLine(user.password)
                    objWriter.Close()
                Catch ex As Exception
                    err.errorMessage = "Failed to write autologin file."
                    err.exceptionMessage = ex.Message
                    err.outputMessage()
                End Try
            End If
            Me.Close()
        Else
            MessageBox.Show("Username and/or password not found.")
        End If
    End Sub

End Class