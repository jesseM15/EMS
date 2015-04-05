<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.pnlNavigation = New System.Windows.Forms.Panel()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnViewMessages = New System.Windows.Forms.Button()
        Me.btnRequestVacation = New System.Windows.Forms.Button()
        Me.btnViewPaySlip = New System.Windows.Forms.Button()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.mnuNavigation = New System.Windows.Forms.MenuStrip()
        Me.tmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiLogInOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiClockInOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiEmployee = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiViewPaySlip = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiRequestVacation = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiViewMessages = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiChangePassword = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pnlNavigation.SuspendLayout()
        Me.mnuNavigation.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlNavigation)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPosition)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblName)
        Me.SplitContainer1.Size = New System.Drawing.Size(826, 438)
        Me.SplitContainer1.SplitterDistance = 156
        Me.SplitContainer1.TabIndex = 1
        Me.SplitContainer1.Visible = False
        '
        'pnlNavigation
        '
        Me.pnlNavigation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNavigation.Controls.Add(Me.btnChangePassword)
        Me.pnlNavigation.Controls.Add(Me.btnViewMessages)
        Me.pnlNavigation.Controls.Add(Me.btnRequestVacation)
        Me.pnlNavigation.Controls.Add(Me.btnViewPaySlip)
        Me.pnlNavigation.Location = New System.Drawing.Point(12, 72)
        Me.pnlNavigation.Name = "pnlNavigation"
        Me.pnlNavigation.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlNavigation.Size = New System.Drawing.Size(133, 130)
        Me.pnlNavigation.TabIndex = 2
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Location = New System.Drawing.Point(8, 95)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(113, 23)
        Me.btnChangePassword.TabIndex = 3
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'btnViewMessages
        '
        Me.btnViewMessages.Location = New System.Drawing.Point(8, 66)
        Me.btnViewMessages.Name = "btnViewMessages"
        Me.btnViewMessages.Size = New System.Drawing.Size(113, 23)
        Me.btnViewMessages.TabIndex = 2
        Me.btnViewMessages.Text = "View Messages"
        Me.btnViewMessages.UseVisualStyleBackColor = True
        '
        'btnRequestVacation
        '
        Me.btnRequestVacation.Location = New System.Drawing.Point(8, 37)
        Me.btnRequestVacation.Name = "btnRequestVacation"
        Me.btnRequestVacation.Size = New System.Drawing.Size(113, 23)
        Me.btnRequestVacation.TabIndex = 1
        Me.btnRequestVacation.Text = "Request Vacation"
        Me.btnRequestVacation.UseVisualStyleBackColor = True
        '
        'btnViewPaySlip
        '
        Me.btnViewPaySlip.Location = New System.Drawing.Point(8, 8)
        Me.btnViewPaySlip.Name = "btnViewPaySlip"
        Me.btnViewPaySlip.Size = New System.Drawing.Size(113, 23)
        Me.btnViewPaySlip.TabIndex = 0
        Me.btnViewPaySlip.Text = "View Pay Slip"
        Me.btnViewPaySlip.UseVisualStyleBackColor = True
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(13, 36)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(58, 17)
        Me.lblPosition.TabIndex = 1
        Me.lblPosition.Text = "Position"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(12, 12)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(61, 24)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'mnuNavigation
        '
        Me.mnuNavigation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiFile, Me.tmiEmployee})
        Me.mnuNavigation.Location = New System.Drawing.Point(0, 0)
        Me.mnuNavigation.Name = "mnuNavigation"
        Me.mnuNavigation.Size = New System.Drawing.Size(826, 24)
        Me.mnuNavigation.TabIndex = 2
        Me.mnuNavigation.Text = "MenuStrip1"
        '
        'tmiFile
        '
        Me.tmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiLogInOut, Me.tmiClockInOut, Me.tmiExit})
        Me.tmiFile.Name = "tmiFile"
        Me.tmiFile.Size = New System.Drawing.Size(37, 20)
        Me.tmiFile.Text = "File"
        '
        'tmiLogInOut
        '
        Me.tmiLogInOut.Name = "tmiLogInOut"
        Me.tmiLogInOut.Size = New System.Drawing.Size(152, 22)
        Me.tmiLogInOut.Text = "Log In"
        '
        'tmiClockInOut
        '
        Me.tmiClockInOut.Name = "tmiClockInOut"
        Me.tmiClockInOut.Size = New System.Drawing.Size(152, 22)
        Me.tmiClockInOut.Text = "Clock In"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 440)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(826, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tmiExit
        '
        Me.tmiExit.Name = "tmiExit"
        Me.tmiExit.Size = New System.Drawing.Size(152, 22)
        Me.tmiExit.Text = "Exit"
        '
        'tmiEmployee
        '
        Me.tmiEmployee.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiViewPaySlip, Me.tmiRequestVacation, Me.tmiViewMessages, Me.tmiChangePassword})
        Me.tmiEmployee.Name = "tmiEmployee"
        Me.tmiEmployee.Size = New System.Drawing.Size(71, 20)
        Me.tmiEmployee.Text = "Employee"
        '
        'tmiViewPaySlip
        '
        Me.tmiViewPaySlip.Name = "tmiViewPaySlip"
        Me.tmiViewPaySlip.Size = New System.Drawing.Size(168, 22)
        Me.tmiViewPaySlip.Text = "ViewPaySlip"
        '
        'tmiRequestVacation
        '
        Me.tmiRequestVacation.Name = "tmiRequestVacation"
        Me.tmiRequestVacation.Size = New System.Drawing.Size(168, 22)
        Me.tmiRequestVacation.Text = "Request Vacation"
        '
        'tmiViewMessages
        '
        Me.tmiViewMessages.Name = "tmiViewMessages"
        Me.tmiViewMessages.Size = New System.Drawing.Size(168, 22)
        Me.tmiViewMessages.Text = "View Messages"
        '
        'tmiChangePassword
        '
        Me.tmiChangePassword.Name = "tmiChangePassword"
        Me.tmiChangePassword.Size = New System.Drawing.Size(168, 22)
        Me.tmiChangePassword.Text = "Change Password"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 462)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.mnuNavigation)
        Me.MainMenuStrip = Me.mnuNavigation
        Me.Name = "Form1"
        Me.Text = "Employee Management System"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pnlNavigation.ResumeLayout(False)
        Me.mnuNavigation.ResumeLayout(False)
        Me.mnuNavigation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents mnuNavigation As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents pnlNavigation As System.Windows.Forms.Panel
    Friend WithEvents btnChangePassword As System.Windows.Forms.Button
    Friend WithEvents btnViewMessages As System.Windows.Forms.Button
    Friend WithEvents btnRequestVacation As System.Windows.Forms.Button
    Friend WithEvents btnViewPaySlip As System.Windows.Forms.Button
    Friend WithEvents tmiFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiLogInOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiClockInOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiEmployee As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiViewPaySlip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiRequestVacation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiViewMessages As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiChangePassword As System.Windows.Forms.ToolStripMenuItem

End Class
