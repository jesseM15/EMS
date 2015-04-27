Public Class ViewEmployees



    Public Sub initViewEmployeesPanel()

        'Dim fields() As String = {"first_name", "last_name", "position", "pay_rate"}
        Form1.dgvEmployees.DataSource = dbems.getEmployees(user.id)
        Dim colDetails As New DataGridViewLinkColumn
        Dim colRemove As New DataGridViewLinkColumn
        colDetails.Name = "Details"
        colDetails.HeaderText = "Details"
        colDetails.Text = "Details"
        colDetails.UseColumnTextForLinkValue = True
        colRemove.Name = "Remove"
        colRemove.HeaderText = "Remove"
        colRemove.Text = "Remove"
        colRemove.UseColumnTextForLinkValue = True
        Form1.dgvEmployees.Columns.Add(colDetails)
        Form1.dgvEmployees.Columns.Add(colRemove)

        Form1.pnlViewEmployees.Visible = True
    End Sub

End Class
