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
        Me.pnlNavigationManager = New System.Windows.Forms.Panel()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnManageVacations = New System.Windows.Forms.Button()
        Me.btnViewEmployees = New System.Windows.Forms.Button()
        Me.pnlNavigationEmployee = New System.Windows.Forms.Panel()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnViewMessages = New System.Windows.Forms.Button()
        Me.btnRequestVacation = New System.Windows.Forms.Button()
        Me.btnViewPaySlip = New System.Windows.Forms.Button()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.pnlEditEmployee = New System.Windows.Forms.Panel()
        Me.lblEditEmployee = New System.Windows.Forms.Label()
        Me.pnlViewEmployees = New System.Windows.Forms.Panel()
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        Me.lblViewEmployees = New System.Windows.Forms.Label()
        Me.pnlMessages = New System.Windows.Forms.Panel()
        Me.pnlMessageNavigation = New System.Windows.Forms.Panel()
        Me.btnViewed = New System.Windows.Forms.Button()
        Me.btnSent = New System.Windows.Forms.Button()
        Me.btnInbox = New System.Windows.Forms.Button()
        Me.lsvMessages = New System.Windows.Forms.ListView()
        Me.lblMessages = New System.Windows.Forms.Label()
        Me.pnlRequestVacation = New System.Windows.Forms.Panel()
        Me.txtRequestList = New System.Windows.Forms.TextBox()
        Me.lblSubmittedRequests = New System.Windows.Forms.Label()
        Me.txtDateList = New System.Windows.Forms.TextBox()
        Me.btnSubmitRequest = New System.Windows.Forms.Button()
        Me.lblDatesRequested = New System.Windows.Forms.Label()
        Me.calVacation = New System.Windows.Forms.MonthCalendar()
        Me.lblVacationRequest = New System.Windows.Forms.Label()
        Me.pnlChangePassword = New System.Windows.Forms.Panel()
        Me.lblChangePasswordMessage = New System.Windows.Forms.Label()
        Me.btnChangePasswordOK = New System.Windows.Forms.Button()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.lblRetypePassword = New System.Windows.Forms.Label()
        Me.txtRetypePassword = New System.Windows.Forms.TextBox()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.lblCurrentPassword = New System.Windows.Forms.Label()
        Me.lblChangePassword = New System.Windows.Forms.Label()
        Me.pnlPaySlip = New System.Windows.Forms.Panel()
        Me.cboWorkPeriod = New System.Windows.Forms.ComboBox()
        Me.lblYTDAmountHoliday = New System.Windows.Forms.Label()
        Me.lblYTDAmountVacation = New System.Windows.Forms.Label()
        Me.lblYTDAmountPersonal = New System.Windows.Forms.Label()
        Me.lblYTDAmountRegular = New System.Windows.Forms.Label()
        Me.lblYTDAmountField = New System.Windows.Forms.Label()
        Me.lblYTDHoursHoliday = New System.Windows.Forms.Label()
        Me.lblYTDHoursVacation = New System.Windows.Forms.Label()
        Me.lblYTDHoursPersonal = New System.Windows.Forms.Label()
        Me.lblYTDHoursRegular = New System.Windows.Forms.Label()
        Me.lblYTDHoursField = New System.Windows.Forms.Label()
        Me.lblCurrentAmountHoliday = New System.Windows.Forms.Label()
        Me.lblCurrentAmountVacation = New System.Windows.Forms.Label()
        Me.lblCurrentAmountPersonal = New System.Windows.Forms.Label()
        Me.lblCurrentAmountRegular = New System.Windows.Forms.Label()
        Me.lblCurrentAmountField = New System.Windows.Forms.Label()
        Me.lblCurrentHoursHoliday = New System.Windows.Forms.Label()
        Me.lblCurrentHoursVacation = New System.Windows.Forms.Label()
        Me.lblCurrentHoursPersonal = New System.Windows.Forms.Label()
        Me.lblCurrentHoursRegular = New System.Windows.Forms.Label()
        Me.lblCurrentHoursField = New System.Windows.Forms.Label()
        Me.lblHolidayPayField = New System.Windows.Forms.Label()
        Me.lblVacationPayField = New System.Windows.Forms.Label()
        Me.lblPersonalPayField = New System.Windows.Forms.Label()
        Me.lblRegularPayField = New System.Windows.Forms.Label()
        Me.lblDescriptionField = New System.Windows.Forms.Label()
        Me.lblHoursAndEarnings = New System.Windows.Forms.Label()
        Me.lblNetPayYTD = New System.Windows.Forms.Label()
        Me.lblNetPayCurrent = New System.Windows.Forms.Label()
        Me.lblNetPayField = New System.Windows.Forms.Label()
        Me.lblTaxesYTD = New System.Windows.Forms.Label()
        Me.lblTaxesCurrent = New System.Windows.Forms.Label()
        Me.lblTaxesField = New System.Windows.Forms.Label()
        Me.lblPreTaxYTD = New System.Windows.Forms.Label()
        Me.lblPreTaxCurrent = New System.Windows.Forms.Label()
        Me.lblPreTaxField = New System.Windows.Forms.Label()
        Me.lblGrossYTD = New System.Windows.Forms.Label()
        Me.lblGrossCurrent = New System.Windows.Forms.Label()
        Me.lblGrossField = New System.Windows.Forms.Label()
        Me.lblYTDField = New System.Windows.Forms.Label()
        Me.lblCurrentField = New System.Windows.Forms.Label()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.lblAnnualSalary = New System.Windows.Forms.Label()
        Me.lblAnnualSalaryField = New System.Windows.Forms.Label()
        Me.lblPayRate = New System.Windows.Forms.Label()
        Me.lblPayRateField = New System.Windows.Forms.Label()
        Me.lblPayEndDate = New System.Windows.Forms.Label()
        Me.lblPayEndDateField = New System.Windows.Forms.Label()
        Me.lblPayStartDate = New System.Windows.Forms.Label()
        Me.lblPayStartDateField = New System.Windows.Forms.Label()
        Me.lblPaymentDate = New System.Windows.Forms.Label()
        Me.lblPaymentDateField = New System.Windows.Forms.Label()
        Me.lblPayPeriod = New System.Windows.Forms.Label()
        Me.lblPayPeriodField = New System.Windows.Forms.Label()
        Me.lblPayPeriodAndSalary = New System.Windows.Forms.Label()
        Me.lblEmployeeAddress2 = New System.Windows.Forms.Label()
        Me.lblEmployeeAddress1 = New System.Windows.Forms.Label()
        Me.lblEmployeeAddressField = New System.Windows.Forms.Label()
        Me.lblHireDate = New System.Windows.Forms.Label()
        Me.lblHireDateField = New System.Windows.Forms.Label()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.lblEmployeeNameField = New System.Windows.Forms.Label()
        Me.lblPaySlip = New System.Windows.Forms.Label()
        Me.pnlReports = New System.Windows.Forms.Panel()
        Me.pnlManageVacations = New System.Windows.Forms.Panel()
        Me.mnuNavigation = New System.Windows.Forms.MenuStrip()
        Me.tmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiLogInOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiClockInOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiEmployee = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiViewPaySlip = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiRequestVacation = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiViewMessages = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiChangePassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiManage = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiViewEmployees = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiManageVacations = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pnlNavigationManager.SuspendLayout()
        Me.pnlNavigationEmployee.SuspendLayout()
        Me.pnlEditEmployee.SuspendLayout()
        Me.pnlViewEmployees.SuspendLayout()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMessages.SuspendLayout()
        Me.pnlMessageNavigation.SuspendLayout()
        Me.pnlRequestVacation.SuspendLayout()
        Me.pnlChangePassword.SuspendLayout()
        Me.pnlPaySlip.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlNavigationManager)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlNavigationEmployee)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPosition)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblName)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlMessages)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlRequestVacation)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlChangePassword)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlPaySlip)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlReports)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlManageVacations)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlEditEmployee)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlViewEmployees)
        Me.SplitContainer1.Size = New System.Drawing.Size(826, 483)
        Me.SplitContainer1.SplitterDistance = 156
        Me.SplitContainer1.TabIndex = 1
        Me.SplitContainer1.Visible = False
        '
        'pnlNavigationManager
        '
        Me.pnlNavigationManager.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNavigationManager.Controls.Add(Me.btnReports)
        Me.pnlNavigationManager.Controls.Add(Me.btnManageVacations)
        Me.pnlNavigationManager.Controls.Add(Me.btnViewEmployees)
        Me.pnlNavigationManager.Location = New System.Drawing.Point(12, 208)
        Me.pnlNavigationManager.Name = "pnlNavigationManager"
        Me.pnlNavigationManager.Size = New System.Drawing.Size(133, 101)
        Me.pnlNavigationManager.TabIndex = 3
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(8, 65)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(113, 23)
        Me.btnReports.TabIndex = 2
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnManageVacations
        '
        Me.btnManageVacations.Location = New System.Drawing.Point(8, 36)
        Me.btnManageVacations.Name = "btnManageVacations"
        Me.btnManageVacations.Size = New System.Drawing.Size(113, 23)
        Me.btnManageVacations.TabIndex = 1
        Me.btnManageVacations.Text = "Manage Vacations"
        Me.btnManageVacations.UseVisualStyleBackColor = True
        '
        'btnViewEmployees
        '
        Me.btnViewEmployees.Location = New System.Drawing.Point(8, 7)
        Me.btnViewEmployees.Name = "btnViewEmployees"
        Me.btnViewEmployees.Size = New System.Drawing.Size(113, 23)
        Me.btnViewEmployees.TabIndex = 0
        Me.btnViewEmployees.Text = "View Employees"
        Me.btnViewEmployees.UseVisualStyleBackColor = True
        '
        'pnlNavigationEmployee
        '
        Me.pnlNavigationEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlNavigationEmployee.Controls.Add(Me.btnChangePassword)
        Me.pnlNavigationEmployee.Controls.Add(Me.btnViewMessages)
        Me.pnlNavigationEmployee.Controls.Add(Me.btnRequestVacation)
        Me.pnlNavigationEmployee.Controls.Add(Me.btnViewPaySlip)
        Me.pnlNavigationEmployee.Location = New System.Drawing.Point(12, 72)
        Me.pnlNavigationEmployee.Name = "pnlNavigationEmployee"
        Me.pnlNavigationEmployee.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlNavigationEmployee.Size = New System.Drawing.Size(133, 130)
        Me.pnlNavigationEmployee.TabIndex = 2
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
        'pnlEditEmployee
        '
        Me.pnlEditEmployee.Controls.Add(Me.lblEditEmployee)
        Me.pnlEditEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEditEmployee.Location = New System.Drawing.Point(0, 0)
        Me.pnlEditEmployee.Name = "pnlEditEmployee"
        Me.pnlEditEmployee.Size = New System.Drawing.Size(664, 481)
        Me.pnlEditEmployee.TabIndex = 66
        '
        'lblEditEmployee
        '
        Me.lblEditEmployee.AutoSize = True
        Me.lblEditEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditEmployee.Location = New System.Drawing.Point(21, 12)
        Me.lblEditEmployee.Name = "lblEditEmployee"
        Me.lblEditEmployee.Size = New System.Drawing.Size(133, 24)
        Me.lblEditEmployee.TabIndex = 0
        Me.lblEditEmployee.Text = "Edit Employee"
        '
        'pnlViewEmployees
        '
        Me.pnlViewEmployees.Controls.Add(Me.dgvEmployees)
        Me.pnlViewEmployees.Controls.Add(Me.lblViewEmployees)
        Me.pnlViewEmployees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlViewEmployees.Location = New System.Drawing.Point(0, 0)
        Me.pnlViewEmployees.Name = "pnlViewEmployees"
        Me.pnlViewEmployees.Size = New System.Drawing.Size(664, 481)
        Me.pnlViewEmployees.TabIndex = 63
        '
        'dgvEmployees
        '
        Me.dgvEmployees.AllowUserToAddRows = False
        Me.dgvEmployees.AllowUserToDeleteRows = False
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Location = New System.Drawing.Point(25, 54)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.ReadOnly = True
        Me.dgvEmployees.RowHeadersVisible = False
        Me.dgvEmployees.Size = New System.Drawing.Size(619, 370)
        Me.dgvEmployees.TabIndex = 1
        '
        'lblViewEmployees
        '
        Me.lblViewEmployees.AutoSize = True
        Me.lblViewEmployees.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewEmployees.Location = New System.Drawing.Point(21, 12)
        Me.lblViewEmployees.Name = "lblViewEmployees"
        Me.lblViewEmployees.Size = New System.Drawing.Size(152, 24)
        Me.lblViewEmployees.TabIndex = 0
        Me.lblViewEmployees.Text = "View Employees"
        '
        'pnlMessages
        '
        Me.pnlMessages.Controls.Add(Me.pnlMessageNavigation)
        Me.pnlMessages.Controls.Add(Me.lsvMessages)
        Me.pnlMessages.Controls.Add(Me.lblMessages)
        Me.pnlMessages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMessages.Location = New System.Drawing.Point(0, 0)
        Me.pnlMessages.Name = "pnlMessages"
        Me.pnlMessages.Size = New System.Drawing.Size(664, 481)
        Me.pnlMessages.TabIndex = 3
        '
        'pnlMessageNavigation
        '
        Me.pnlMessageNavigation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlMessageNavigation.Controls.Add(Me.btnViewed)
        Me.pnlMessageNavigation.Controls.Add(Me.btnSent)
        Me.pnlMessageNavigation.Controls.Add(Me.btnInbox)
        Me.pnlMessageNavigation.Location = New System.Drawing.Point(25, 70)
        Me.pnlMessageNavigation.Name = "pnlMessageNavigation"
        Me.pnlMessageNavigation.Size = New System.Drawing.Size(97, 100)
        Me.pnlMessageNavigation.TabIndex = 2
        '
        'btnViewed
        '
        Me.btnViewed.Location = New System.Drawing.Point(9, 66)
        Me.btnViewed.Name = "btnViewed"
        Me.btnViewed.Size = New System.Drawing.Size(74, 23)
        Me.btnViewed.TabIndex = 2
        Me.btnViewed.Text = "Viewed"
        Me.btnViewed.UseVisualStyleBackColor = True
        '
        'btnSent
        '
        Me.btnSent.Location = New System.Drawing.Point(9, 37)
        Me.btnSent.Name = "btnSent"
        Me.btnSent.Size = New System.Drawing.Size(74, 23)
        Me.btnSent.TabIndex = 1
        Me.btnSent.Text = "Sent"
        Me.btnSent.UseVisualStyleBackColor = True
        '
        'btnInbox
        '
        Me.btnInbox.Location = New System.Drawing.Point(9, 8)
        Me.btnInbox.Name = "btnInbox"
        Me.btnInbox.Size = New System.Drawing.Size(74, 23)
        Me.btnInbox.TabIndex = 0
        Me.btnInbox.Text = "Inbox"
        Me.btnInbox.UseVisualStyleBackColor = True
        '
        'lsvMessages
        '
        Me.lsvMessages.Location = New System.Drawing.Point(128, 70)
        Me.lsvMessages.Name = "lsvMessages"
        Me.lsvMessages.Size = New System.Drawing.Size(522, 378)
        Me.lsvMessages.TabIndex = 1
        Me.lsvMessages.UseCompatibleStateImageBehavior = False
        Me.lsvMessages.View = System.Windows.Forms.View.Details
        '
        'lblMessages
        '
        Me.lblMessages.AutoSize = True
        Me.lblMessages.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessages.Location = New System.Drawing.Point(21, 12)
        Me.lblMessages.Name = "lblMessages"
        Me.lblMessages.Size = New System.Drawing.Size(96, 24)
        Me.lblMessages.TabIndex = 0
        Me.lblMessages.Text = "Messages"
        '
        'pnlRequestVacation
        '
        Me.pnlRequestVacation.Controls.Add(Me.txtRequestList)
        Me.pnlRequestVacation.Controls.Add(Me.lblSubmittedRequests)
        Me.pnlRequestVacation.Controls.Add(Me.txtDateList)
        Me.pnlRequestVacation.Controls.Add(Me.btnSubmitRequest)
        Me.pnlRequestVacation.Controls.Add(Me.lblDatesRequested)
        Me.pnlRequestVacation.Controls.Add(Me.calVacation)
        Me.pnlRequestVacation.Controls.Add(Me.lblVacationRequest)
        Me.pnlRequestVacation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRequestVacation.Location = New System.Drawing.Point(0, 0)
        Me.pnlRequestVacation.Name = "pnlRequestVacation"
        Me.pnlRequestVacation.Size = New System.Drawing.Size(664, 481)
        Me.pnlRequestVacation.TabIndex = 62
        '
        'txtRequestList
        '
        Me.txtRequestList.Location = New System.Drawing.Point(423, 67)
        Me.txtRequestList.Multiline = True
        Me.txtRequestList.Name = "txtRequestList"
        Me.txtRequestList.ReadOnly = True
        Me.txtRequestList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRequestList.Size = New System.Drawing.Size(82, 86)
        Me.txtRequestList.TabIndex = 7
        '
        'lblSubmittedRequests
        '
        Me.lblSubmittedRequests.AutoSize = True
        Me.lblSubmittedRequests.Location = New System.Drawing.Point(281, 70)
        Me.lblSubmittedRequests.Name = "lblSubmittedRequests"
        Me.lblSubmittedRequests.Size = New System.Drawing.Size(105, 13)
        Me.lblSubmittedRequests.TabIndex = 6
        Me.lblSubmittedRequests.Text = "Submitted Requests:"
        '
        'txtDateList
        '
        Me.txtDateList.Location = New System.Drawing.Point(170, 237)
        Me.txtDateList.Multiline = True
        Me.txtDateList.Name = "txtDateList"
        Me.txtDateList.ReadOnly = True
        Me.txtDateList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDateList.Size = New System.Drawing.Size(82, 86)
        Me.txtDateList.TabIndex = 5
        '
        'btnSubmitRequest
        '
        Me.btnSubmitRequest.Location = New System.Drawing.Point(94, 347)
        Me.btnSubmitRequest.Name = "btnSubmitRequest"
        Me.btnSubmitRequest.Size = New System.Drawing.Size(91, 23)
        Me.btnSubmitRequest.TabIndex = 4
        Me.btnSubmitRequest.Text = "Submit Request"
        Me.btnSubmitRequest.UseVisualStyleBackColor = True
        '
        'lblDatesRequested
        '
        Me.lblDatesRequested.AutoSize = True
        Me.lblDatesRequested.Location = New System.Drawing.Point(25, 240)
        Me.lblDatesRequested.Name = "lblDatesRequested"
        Me.lblDatesRequested.Size = New System.Drawing.Size(99, 13)
        Me.lblDatesRequested.TabIndex = 2
        Me.lblDatesRequested.Text = "Date(s) Requested:"
        '
        'calVacation
        '
        Me.calVacation.Location = New System.Drawing.Point(25, 54)
        Me.calVacation.MaxSelectionCount = 14
        Me.calVacation.Name = "calVacation"
        Me.calVacation.TabIndex = 1
        '
        'lblVacationRequest
        '
        Me.lblVacationRequest.AutoSize = True
        Me.lblVacationRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVacationRequest.Location = New System.Drawing.Point(21, 12)
        Me.lblVacationRequest.Name = "lblVacationRequest"
        Me.lblVacationRequest.Size = New System.Drawing.Size(158, 24)
        Me.lblVacationRequest.TabIndex = 0
        Me.lblVacationRequest.Text = "Vacation Request"
        '
        'pnlChangePassword
        '
        Me.pnlChangePassword.Controls.Add(Me.lblChangePasswordMessage)
        Me.pnlChangePassword.Controls.Add(Me.btnChangePasswordOK)
        Me.pnlChangePassword.Controls.Add(Me.txtNewPassword)
        Me.pnlChangePassword.Controls.Add(Me.lblRetypePassword)
        Me.pnlChangePassword.Controls.Add(Me.txtRetypePassword)
        Me.pnlChangePassword.Controls.Add(Me.lblNewPassword)
        Me.pnlChangePassword.Controls.Add(Me.txtCurrentPassword)
        Me.pnlChangePassword.Controls.Add(Me.lblCurrentPassword)
        Me.pnlChangePassword.Controls.Add(Me.lblChangePassword)
        Me.pnlChangePassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlChangePassword.Location = New System.Drawing.Point(0, 0)
        Me.pnlChangePassword.Name = "pnlChangePassword"
        Me.pnlChangePassword.Size = New System.Drawing.Size(664, 481)
        Me.pnlChangePassword.TabIndex = 62
        '
        'lblChangePasswordMessage
        '
        Me.lblChangePasswordMessage.AutoSize = True
        Me.lblChangePasswordMessage.Location = New System.Drawing.Point(25, 185)
        Me.lblChangePasswordMessage.Name = "lblChangePasswordMessage"
        Me.lblChangePasswordMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblChangePasswordMessage.TabIndex = 8
        '
        'btnChangePasswordOK
        '
        Me.btnChangePasswordOK.Location = New System.Drawing.Point(143, 147)
        Me.btnChangePasswordOK.Name = "btnChangePasswordOK"
        Me.btnChangePasswordOK.Size = New System.Drawing.Size(75, 23)
        Me.btnChangePasswordOK.TabIndex = 7
        Me.btnChangePasswordOK.Text = "OK"
        Me.btnChangePasswordOK.UseVisualStyleBackColor = True
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(115, 111)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(103, 20)
        Me.txtNewPassword.TabIndex = 6
        '
        'lblRetypePassword
        '
        Me.lblRetypePassword.AutoSize = True
        Me.lblRetypePassword.Location = New System.Drawing.Point(22, 114)
        Me.lblRetypePassword.Name = "lblRetypePassword"
        Me.lblRetypePassword.Size = New System.Drawing.Size(93, 13)
        Me.lblRetypePassword.TabIndex = 5
        Me.lblRetypePassword.Text = "Retype Password:"
        '
        'txtRetypePassword
        '
        Me.txtRetypePassword.Location = New System.Drawing.Point(115, 81)
        Me.txtRetypePassword.Name = "txtRetypePassword"
        Me.txtRetypePassword.Size = New System.Drawing.Size(103, 20)
        Me.txtRetypePassword.TabIndex = 4
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Location = New System.Drawing.Point(22, 84)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(81, 13)
        Me.lblNewPassword.TabIndex = 3
        Me.lblNewPassword.Text = "New Password:"
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.Location = New System.Drawing.Point(115, 50)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.Size = New System.Drawing.Size(103, 20)
        Me.txtCurrentPassword.TabIndex = 2
        '
        'lblCurrentPassword
        '
        Me.lblCurrentPassword.AutoSize = True
        Me.lblCurrentPassword.Location = New System.Drawing.Point(22, 53)
        Me.lblCurrentPassword.Name = "lblCurrentPassword"
        Me.lblCurrentPassword.Size = New System.Drawing.Size(93, 13)
        Me.lblCurrentPassword.TabIndex = 1
        Me.lblCurrentPassword.Text = "Current Password:"
        '
        'lblChangePassword
        '
        Me.lblChangePassword.AutoSize = True
        Me.lblChangePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangePassword.Location = New System.Drawing.Point(21, 12)
        Me.lblChangePassword.Name = "lblChangePassword"
        Me.lblChangePassword.Size = New System.Drawing.Size(164, 24)
        Me.lblChangePassword.TabIndex = 0
        Me.lblChangePassword.Text = "Change Password"
        '
        'pnlPaySlip
        '
        Me.pnlPaySlip.AutoScroll = True
        Me.pnlPaySlip.Controls.Add(Me.cboWorkPeriod)
        Me.pnlPaySlip.Controls.Add(Me.lblYTDAmountHoliday)
        Me.pnlPaySlip.Controls.Add(Me.lblYTDAmountVacation)
        Me.pnlPaySlip.Controls.Add(Me.lblYTDAmountPersonal)
        Me.pnlPaySlip.Controls.Add(Me.lblYTDAmountRegular)
        Me.pnlPaySlip.Controls.Add(Me.lblYTDAmountField)
        Me.pnlPaySlip.Controls.Add(Me.lblYTDHoursHoliday)
        Me.pnlPaySlip.Controls.Add(Me.lblYTDHoursVacation)
        Me.pnlPaySlip.Controls.Add(Me.lblYTDHoursPersonal)
        Me.pnlPaySlip.Controls.Add(Me.lblYTDHoursRegular)
        Me.pnlPaySlip.Controls.Add(Me.lblYTDHoursField)
        Me.pnlPaySlip.Controls.Add(Me.lblCurrentAmountHoliday)
        Me.pnlPaySlip.Controls.Add(Me.lblCurrentAmountVacation)
        Me.pnlPaySlip.Controls.Add(Me.lblCurrentAmountPersonal)
        Me.pnlPaySlip.Controls.Add(Me.lblCurrentAmountRegular)
        Me.pnlPaySlip.Controls.Add(Me.lblCurrentAmountField)
        Me.pnlPaySlip.Controls.Add(Me.lblCurrentHoursHoliday)
        Me.pnlPaySlip.Controls.Add(Me.lblCurrentHoursVacation)
        Me.pnlPaySlip.Controls.Add(Me.lblCurrentHoursPersonal)
        Me.pnlPaySlip.Controls.Add(Me.lblCurrentHoursRegular)
        Me.pnlPaySlip.Controls.Add(Me.lblCurrentHoursField)
        Me.pnlPaySlip.Controls.Add(Me.lblHolidayPayField)
        Me.pnlPaySlip.Controls.Add(Me.lblVacationPayField)
        Me.pnlPaySlip.Controls.Add(Me.lblPersonalPayField)
        Me.pnlPaySlip.Controls.Add(Me.lblRegularPayField)
        Me.pnlPaySlip.Controls.Add(Me.lblDescriptionField)
        Me.pnlPaySlip.Controls.Add(Me.lblHoursAndEarnings)
        Me.pnlPaySlip.Controls.Add(Me.lblNetPayYTD)
        Me.pnlPaySlip.Controls.Add(Me.lblNetPayCurrent)
        Me.pnlPaySlip.Controls.Add(Me.lblNetPayField)
        Me.pnlPaySlip.Controls.Add(Me.lblTaxesYTD)
        Me.pnlPaySlip.Controls.Add(Me.lblTaxesCurrent)
        Me.pnlPaySlip.Controls.Add(Me.lblTaxesField)
        Me.pnlPaySlip.Controls.Add(Me.lblPreTaxYTD)
        Me.pnlPaySlip.Controls.Add(Me.lblPreTaxCurrent)
        Me.pnlPaySlip.Controls.Add(Me.lblPreTaxField)
        Me.pnlPaySlip.Controls.Add(Me.lblGrossYTD)
        Me.pnlPaySlip.Controls.Add(Me.lblGrossCurrent)
        Me.pnlPaySlip.Controls.Add(Me.lblGrossField)
        Me.pnlPaySlip.Controls.Add(Me.lblYTDField)
        Me.pnlPaySlip.Controls.Add(Me.lblCurrentField)
        Me.pnlPaySlip.Controls.Add(Me.lblSummary)
        Me.pnlPaySlip.Controls.Add(Me.lblAnnualSalary)
        Me.pnlPaySlip.Controls.Add(Me.lblAnnualSalaryField)
        Me.pnlPaySlip.Controls.Add(Me.lblPayRate)
        Me.pnlPaySlip.Controls.Add(Me.lblPayRateField)
        Me.pnlPaySlip.Controls.Add(Me.lblPayEndDate)
        Me.pnlPaySlip.Controls.Add(Me.lblPayEndDateField)
        Me.pnlPaySlip.Controls.Add(Me.lblPayStartDate)
        Me.pnlPaySlip.Controls.Add(Me.lblPayStartDateField)
        Me.pnlPaySlip.Controls.Add(Me.lblPaymentDate)
        Me.pnlPaySlip.Controls.Add(Me.lblPaymentDateField)
        Me.pnlPaySlip.Controls.Add(Me.lblPayPeriod)
        Me.pnlPaySlip.Controls.Add(Me.lblPayPeriodField)
        Me.pnlPaySlip.Controls.Add(Me.lblPayPeriodAndSalary)
        Me.pnlPaySlip.Controls.Add(Me.lblEmployeeAddress2)
        Me.pnlPaySlip.Controls.Add(Me.lblEmployeeAddress1)
        Me.pnlPaySlip.Controls.Add(Me.lblEmployeeAddressField)
        Me.pnlPaySlip.Controls.Add(Me.lblHireDate)
        Me.pnlPaySlip.Controls.Add(Me.lblHireDateField)
        Me.pnlPaySlip.Controls.Add(Me.lblEmployeeName)
        Me.pnlPaySlip.Controls.Add(Me.lblEmployeeNameField)
        Me.pnlPaySlip.Controls.Add(Me.lblPaySlip)
        Me.pnlPaySlip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPaySlip.Location = New System.Drawing.Point(0, 0)
        Me.pnlPaySlip.Name = "pnlPaySlip"
        Me.pnlPaySlip.Size = New System.Drawing.Size(664, 481)
        Me.pnlPaySlip.TabIndex = 0
        '
        'cboWorkPeriod
        '
        Me.cboWorkPeriod.FormattingEnabled = True
        Me.cboWorkPeriod.Location = New System.Drawing.Point(423, 17)
        Me.cboWorkPeriod.Name = "cboWorkPeriod"
        Me.cboWorkPeriod.Size = New System.Drawing.Size(203, 21)
        Me.cboWorkPeriod.TabIndex = 1
        '
        'lblYTDAmountHoliday
        '
        Me.lblYTDAmountHoliday.AutoSize = True
        Me.lblYTDAmountHoliday.Location = New System.Drawing.Point(420, 623)
        Me.lblYTDAmountHoliday.Name = "lblYTDAmountHoliday"
        Me.lblYTDAmountHoliday.Size = New System.Drawing.Size(68, 13)
        Me.lblYTDAmountHoliday.TabIndex = 61
        Me.lblYTDAmountHoliday.Text = "YTD Amount"
        '
        'lblYTDAmountVacation
        '
        Me.lblYTDAmountVacation.AutoSize = True
        Me.lblYTDAmountVacation.Location = New System.Drawing.Point(420, 588)
        Me.lblYTDAmountVacation.Name = "lblYTDAmountVacation"
        Me.lblYTDAmountVacation.Size = New System.Drawing.Size(68, 13)
        Me.lblYTDAmountVacation.TabIndex = 60
        Me.lblYTDAmountVacation.Text = "YTD Amount"
        '
        'lblYTDAmountPersonal
        '
        Me.lblYTDAmountPersonal.AutoSize = True
        Me.lblYTDAmountPersonal.Location = New System.Drawing.Point(420, 554)
        Me.lblYTDAmountPersonal.Name = "lblYTDAmountPersonal"
        Me.lblYTDAmountPersonal.Size = New System.Drawing.Size(68, 13)
        Me.lblYTDAmountPersonal.TabIndex = 59
        Me.lblYTDAmountPersonal.Text = "YTD Amount"
        '
        'lblYTDAmountRegular
        '
        Me.lblYTDAmountRegular.AutoSize = True
        Me.lblYTDAmountRegular.Location = New System.Drawing.Point(420, 520)
        Me.lblYTDAmountRegular.Name = "lblYTDAmountRegular"
        Me.lblYTDAmountRegular.Size = New System.Drawing.Size(68, 13)
        Me.lblYTDAmountRegular.TabIndex = 58
        Me.lblYTDAmountRegular.Text = "YTD Amount"
        '
        'lblYTDAmountField
        '
        Me.lblYTDAmountField.AutoSize = True
        Me.lblYTDAmountField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYTDAmountField.Location = New System.Drawing.Point(420, 486)
        Me.lblYTDAmountField.Name = "lblYTDAmountField"
        Me.lblYTDAmountField.Size = New System.Drawing.Size(78, 13)
        Me.lblYTDAmountField.TabIndex = 57
        Me.lblYTDAmountField.Text = "YTD Amount"
        '
        'lblYTDHoursHoliday
        '
        Me.lblYTDHoursHoliday.AutoSize = True
        Me.lblYTDHoursHoliday.Location = New System.Drawing.Point(317, 623)
        Me.lblYTDHoursHoliday.Name = "lblYTDHoursHoliday"
        Me.lblYTDHoursHoliday.Size = New System.Drawing.Size(60, 13)
        Me.lblYTDHoursHoliday.TabIndex = 56
        Me.lblYTDHoursHoliday.Text = "YTD Hours"
        '
        'lblYTDHoursVacation
        '
        Me.lblYTDHoursVacation.AutoSize = True
        Me.lblYTDHoursVacation.Location = New System.Drawing.Point(317, 588)
        Me.lblYTDHoursVacation.Name = "lblYTDHoursVacation"
        Me.lblYTDHoursVacation.Size = New System.Drawing.Size(60, 13)
        Me.lblYTDHoursVacation.TabIndex = 55
        Me.lblYTDHoursVacation.Text = "YTD Hours"
        '
        'lblYTDHoursPersonal
        '
        Me.lblYTDHoursPersonal.AutoSize = True
        Me.lblYTDHoursPersonal.Location = New System.Drawing.Point(317, 554)
        Me.lblYTDHoursPersonal.Name = "lblYTDHoursPersonal"
        Me.lblYTDHoursPersonal.Size = New System.Drawing.Size(60, 13)
        Me.lblYTDHoursPersonal.TabIndex = 54
        Me.lblYTDHoursPersonal.Text = "YTD Hours"
        '
        'lblYTDHoursRegular
        '
        Me.lblYTDHoursRegular.AutoSize = True
        Me.lblYTDHoursRegular.Location = New System.Drawing.Point(317, 520)
        Me.lblYTDHoursRegular.Name = "lblYTDHoursRegular"
        Me.lblYTDHoursRegular.Size = New System.Drawing.Size(60, 13)
        Me.lblYTDHoursRegular.TabIndex = 53
        Me.lblYTDHoursRegular.Text = "YTD Hours"
        '
        'lblYTDHoursField
        '
        Me.lblYTDHoursField.AutoSize = True
        Me.lblYTDHoursField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYTDHoursField.Location = New System.Drawing.Point(317, 486)
        Me.lblYTDHoursField.Name = "lblYTDHoursField"
        Me.lblYTDHoursField.Size = New System.Drawing.Size(69, 13)
        Me.lblYTDHoursField.TabIndex = 52
        Me.lblYTDHoursField.Text = "YTD Hours"
        '
        'lblCurrentAmountHoliday
        '
        Me.lblCurrentAmountHoliday.AutoSize = True
        Me.lblCurrentAmountHoliday.Location = New System.Drawing.Point(216, 623)
        Me.lblCurrentAmountHoliday.Name = "lblCurrentAmountHoliday"
        Me.lblCurrentAmountHoliday.Size = New System.Drawing.Size(80, 13)
        Me.lblCurrentAmountHoliday.TabIndex = 51
        Me.lblCurrentAmountHoliday.Text = "Current Amount"
        '
        'lblCurrentAmountVacation
        '
        Me.lblCurrentAmountVacation.AutoSize = True
        Me.lblCurrentAmountVacation.Location = New System.Drawing.Point(216, 588)
        Me.lblCurrentAmountVacation.Name = "lblCurrentAmountVacation"
        Me.lblCurrentAmountVacation.Size = New System.Drawing.Size(80, 13)
        Me.lblCurrentAmountVacation.TabIndex = 50
        Me.lblCurrentAmountVacation.Text = "Current Amount"
        '
        'lblCurrentAmountPersonal
        '
        Me.lblCurrentAmountPersonal.AutoSize = True
        Me.lblCurrentAmountPersonal.Location = New System.Drawing.Point(216, 554)
        Me.lblCurrentAmountPersonal.Name = "lblCurrentAmountPersonal"
        Me.lblCurrentAmountPersonal.Size = New System.Drawing.Size(80, 13)
        Me.lblCurrentAmountPersonal.TabIndex = 49
        Me.lblCurrentAmountPersonal.Text = "Current Amount"
        '
        'lblCurrentAmountRegular
        '
        Me.lblCurrentAmountRegular.AutoSize = True
        Me.lblCurrentAmountRegular.Location = New System.Drawing.Point(216, 520)
        Me.lblCurrentAmountRegular.Name = "lblCurrentAmountRegular"
        Me.lblCurrentAmountRegular.Size = New System.Drawing.Size(80, 13)
        Me.lblCurrentAmountRegular.TabIndex = 48
        Me.lblCurrentAmountRegular.Text = "Current Amount"
        '
        'lblCurrentAmountField
        '
        Me.lblCurrentAmountField.AutoSize = True
        Me.lblCurrentAmountField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentAmountField.Location = New System.Drawing.Point(216, 486)
        Me.lblCurrentAmountField.Name = "lblCurrentAmountField"
        Me.lblCurrentAmountField.Size = New System.Drawing.Size(94, 13)
        Me.lblCurrentAmountField.TabIndex = 47
        Me.lblCurrentAmountField.Text = "Current Amount"
        '
        'lblCurrentHoursHoliday
        '
        Me.lblCurrentHoursHoliday.AutoSize = True
        Me.lblCurrentHoursHoliday.Location = New System.Drawing.Point(115, 623)
        Me.lblCurrentHoursHoliday.Name = "lblCurrentHoursHoliday"
        Me.lblCurrentHoursHoliday.Size = New System.Drawing.Size(72, 13)
        Me.lblCurrentHoursHoliday.TabIndex = 46
        Me.lblCurrentHoursHoliday.Text = "Current Hours"
        '
        'lblCurrentHoursVacation
        '
        Me.lblCurrentHoursVacation.AutoSize = True
        Me.lblCurrentHoursVacation.Location = New System.Drawing.Point(115, 588)
        Me.lblCurrentHoursVacation.Name = "lblCurrentHoursVacation"
        Me.lblCurrentHoursVacation.Size = New System.Drawing.Size(72, 13)
        Me.lblCurrentHoursVacation.TabIndex = 45
        Me.lblCurrentHoursVacation.Text = "Current Hours"
        '
        'lblCurrentHoursPersonal
        '
        Me.lblCurrentHoursPersonal.AutoSize = True
        Me.lblCurrentHoursPersonal.Location = New System.Drawing.Point(115, 554)
        Me.lblCurrentHoursPersonal.Name = "lblCurrentHoursPersonal"
        Me.lblCurrentHoursPersonal.Size = New System.Drawing.Size(72, 13)
        Me.lblCurrentHoursPersonal.TabIndex = 44
        Me.lblCurrentHoursPersonal.Text = "Current Hours"
        '
        'lblCurrentHoursRegular
        '
        Me.lblCurrentHoursRegular.AutoSize = True
        Me.lblCurrentHoursRegular.Location = New System.Drawing.Point(115, 520)
        Me.lblCurrentHoursRegular.Name = "lblCurrentHoursRegular"
        Me.lblCurrentHoursRegular.Size = New System.Drawing.Size(72, 13)
        Me.lblCurrentHoursRegular.TabIndex = 43
        Me.lblCurrentHoursRegular.Text = "Current Hours"
        '
        'lblCurrentHoursField
        '
        Me.lblCurrentHoursField.AutoSize = True
        Me.lblCurrentHoursField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentHoursField.Location = New System.Drawing.Point(115, 486)
        Me.lblCurrentHoursField.Name = "lblCurrentHoursField"
        Me.lblCurrentHoursField.Size = New System.Drawing.Size(85, 13)
        Me.lblCurrentHoursField.TabIndex = 42
        Me.lblCurrentHoursField.Text = "Current Hours"
        '
        'lblHolidayPayField
        '
        Me.lblHolidayPayField.AutoSize = True
        Me.lblHolidayPayField.Location = New System.Drawing.Point(22, 623)
        Me.lblHolidayPayField.Name = "lblHolidayPayField"
        Me.lblHolidayPayField.Size = New System.Drawing.Size(63, 13)
        Me.lblHolidayPayField.TabIndex = 41
        Me.lblHolidayPayField.Text = "Holiday Pay"
        '
        'lblVacationPayField
        '
        Me.lblVacationPayField.AutoSize = True
        Me.lblVacationPayField.Location = New System.Drawing.Point(22, 588)
        Me.lblVacationPayField.Name = "lblVacationPayField"
        Me.lblVacationPayField.Size = New System.Drawing.Size(70, 13)
        Me.lblVacationPayField.TabIndex = 40
        Me.lblVacationPayField.Text = "Vacation Pay"
        '
        'lblPersonalPayField
        '
        Me.lblPersonalPayField.AutoSize = True
        Me.lblPersonalPayField.Location = New System.Drawing.Point(22, 554)
        Me.lblPersonalPayField.Name = "lblPersonalPayField"
        Me.lblPersonalPayField.Size = New System.Drawing.Size(69, 13)
        Me.lblPersonalPayField.TabIndex = 39
        Me.lblPersonalPayField.Text = "Personal Pay"
        '
        'lblRegularPayField
        '
        Me.lblRegularPayField.AutoSize = True
        Me.lblRegularPayField.Location = New System.Drawing.Point(22, 520)
        Me.lblRegularPayField.Name = "lblRegularPayField"
        Me.lblRegularPayField.Size = New System.Drawing.Size(65, 13)
        Me.lblRegularPayField.TabIndex = 38
        Me.lblRegularPayField.Text = "Regular Pay"
        '
        'lblDescriptionField
        '
        Me.lblDescriptionField.AutoSize = True
        Me.lblDescriptionField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptionField.Location = New System.Drawing.Point(22, 486)
        Me.lblDescriptionField.Name = "lblDescriptionField"
        Me.lblDescriptionField.Size = New System.Drawing.Size(71, 13)
        Me.lblDescriptionField.TabIndex = 37
        Me.lblDescriptionField.Text = "Description"
        '
        'lblHoursAndEarnings
        '
        Me.lblHoursAndEarnings.AutoSize = True
        Me.lblHoursAndEarnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursAndEarnings.Location = New System.Drawing.Point(22, 450)
        Me.lblHoursAndEarnings.Name = "lblHoursAndEarnings"
        Me.lblHoursAndEarnings.Size = New System.Drawing.Size(118, 13)
        Me.lblHoursAndEarnings.TabIndex = 36
        Me.lblHoursAndEarnings.Text = "Hours and Earnings"
        '
        'lblNetPayYTD
        '
        Me.lblNetPayYTD.AutoSize = True
        Me.lblNetPayYTD.Location = New System.Drawing.Point(420, 394)
        Me.lblNetPayYTD.Name = "lblNetPayYTD"
        Me.lblNetPayYTD.Size = New System.Drawing.Size(45, 13)
        Me.lblNetPayYTD.TabIndex = 35
        Me.lblNetPayYTD.Text = "Net Pay"
        '
        'lblNetPayCurrent
        '
        Me.lblNetPayCurrent.AutoSize = True
        Me.lblNetPayCurrent.Location = New System.Drawing.Point(420, 362)
        Me.lblNetPayCurrent.Name = "lblNetPayCurrent"
        Me.lblNetPayCurrent.Size = New System.Drawing.Size(45, 13)
        Me.lblNetPayCurrent.TabIndex = 34
        Me.lblNetPayCurrent.Text = "Net Pay"
        '
        'lblNetPayField
        '
        Me.lblNetPayField.AutoSize = True
        Me.lblNetPayField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPayField.Location = New System.Drawing.Point(420, 331)
        Me.lblNetPayField.Name = "lblNetPayField"
        Me.lblNetPayField.Size = New System.Drawing.Size(52, 13)
        Me.lblNetPayField.TabIndex = 33
        Me.lblNetPayField.Text = "Net Pay"
        '
        'lblTaxesYTD
        '
        Me.lblTaxesYTD.AutoSize = True
        Me.lblTaxesYTD.Location = New System.Drawing.Point(317, 394)
        Me.lblTaxesYTD.Name = "lblTaxesYTD"
        Me.lblTaxesYTD.Size = New System.Drawing.Size(36, 13)
        Me.lblTaxesYTD.TabIndex = 32
        Me.lblTaxesYTD.Text = "Taxes"
        '
        'lblTaxesCurrent
        '
        Me.lblTaxesCurrent.AutoSize = True
        Me.lblTaxesCurrent.Location = New System.Drawing.Point(317, 362)
        Me.lblTaxesCurrent.Name = "lblTaxesCurrent"
        Me.lblTaxesCurrent.Size = New System.Drawing.Size(36, 13)
        Me.lblTaxesCurrent.TabIndex = 31
        Me.lblTaxesCurrent.Text = "Taxes"
        '
        'lblTaxesField
        '
        Me.lblTaxesField.AutoSize = True
        Me.lblTaxesField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxesField.Location = New System.Drawing.Point(317, 331)
        Me.lblTaxesField.Name = "lblTaxesField"
        Me.lblTaxesField.Size = New System.Drawing.Size(41, 13)
        Me.lblTaxesField.TabIndex = 30
        Me.lblTaxesField.Text = "Taxes"
        '
        'lblPreTaxYTD
        '
        Me.lblPreTaxYTD.AutoSize = True
        Me.lblPreTaxYTD.Location = New System.Drawing.Point(216, 394)
        Me.lblPreTaxYTD.Name = "lblPreTaxYTD"
        Me.lblPreTaxYTD.Size = New System.Drawing.Size(44, 13)
        Me.lblPreTaxYTD.TabIndex = 29
        Me.lblPreTaxYTD.Text = "Pre-Tax"
        '
        'lblPreTaxCurrent
        '
        Me.lblPreTaxCurrent.AutoSize = True
        Me.lblPreTaxCurrent.Location = New System.Drawing.Point(216, 362)
        Me.lblPreTaxCurrent.Name = "lblPreTaxCurrent"
        Me.lblPreTaxCurrent.Size = New System.Drawing.Size(44, 13)
        Me.lblPreTaxCurrent.TabIndex = 28
        Me.lblPreTaxCurrent.Text = "Pre-Tax"
        '
        'lblPreTaxField
        '
        Me.lblPreTaxField.AutoSize = True
        Me.lblPreTaxField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreTaxField.Location = New System.Drawing.Point(216, 331)
        Me.lblPreTaxField.Name = "lblPreTaxField"
        Me.lblPreTaxField.Size = New System.Drawing.Size(51, 13)
        Me.lblPreTaxField.TabIndex = 27
        Me.lblPreTaxField.Text = "Pre-Tax"
        '
        'lblGrossYTD
        '
        Me.lblGrossYTD.AutoSize = True
        Me.lblGrossYTD.Location = New System.Drawing.Point(115, 394)
        Me.lblGrossYTD.Name = "lblGrossYTD"
        Me.lblGrossYTD.Size = New System.Drawing.Size(34, 13)
        Me.lblGrossYTD.TabIndex = 26
        Me.lblGrossYTD.Text = "Gross"
        '
        'lblGrossCurrent
        '
        Me.lblGrossCurrent.AutoSize = True
        Me.lblGrossCurrent.Location = New System.Drawing.Point(115, 362)
        Me.lblGrossCurrent.Name = "lblGrossCurrent"
        Me.lblGrossCurrent.Size = New System.Drawing.Size(34, 13)
        Me.lblGrossCurrent.TabIndex = 25
        Me.lblGrossCurrent.Text = "Gross"
        '
        'lblGrossField
        '
        Me.lblGrossField.AutoSize = True
        Me.lblGrossField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossField.Location = New System.Drawing.Point(115, 331)
        Me.lblGrossField.Name = "lblGrossField"
        Me.lblGrossField.Size = New System.Drawing.Size(39, 13)
        Me.lblGrossField.TabIndex = 24
        Me.lblGrossField.Text = "Gross"
        '
        'lblYTDField
        '
        Me.lblYTDField.AutoSize = True
        Me.lblYTDField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYTDField.Location = New System.Drawing.Point(22, 394)
        Me.lblYTDField.Name = "lblYTDField"
        Me.lblYTDField.Size = New System.Drawing.Size(32, 13)
        Me.lblYTDField.TabIndex = 23
        Me.lblYTDField.Text = "YTD"
        '
        'lblCurrentField
        '
        Me.lblCurrentField.AutoSize = True
        Me.lblCurrentField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentField.Location = New System.Drawing.Point(22, 362)
        Me.lblCurrentField.Name = "lblCurrentField"
        Me.lblCurrentField.Size = New System.Drawing.Size(48, 13)
        Me.lblCurrentField.TabIndex = 22
        Me.lblCurrentField.Text = "Current"
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummary.Location = New System.Drawing.Point(22, 301)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(57, 13)
        Me.lblSummary.TabIndex = 21
        Me.lblSummary.Text = "Summary"
        '
        'lblAnnualSalary
        '
        Me.lblAnnualSalary.AutoSize = True
        Me.lblAnnualSalary.Location = New System.Drawing.Point(497, 249)
        Me.lblAnnualSalary.Name = "lblAnnualSalary"
        Me.lblAnnualSalary.Size = New System.Drawing.Size(72, 13)
        Me.lblAnnualSalary.TabIndex = 20
        Me.lblAnnualSalary.Text = "Annual Salary"
        '
        'lblAnnualSalaryField
        '
        Me.lblAnnualSalaryField.AutoSize = True
        Me.lblAnnualSalaryField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnualSalaryField.Location = New System.Drawing.Point(497, 222)
        Me.lblAnnualSalaryField.Name = "lblAnnualSalaryField"
        Me.lblAnnualSalaryField.Size = New System.Drawing.Size(85, 13)
        Me.lblAnnualSalaryField.TabIndex = 19
        Me.lblAnnualSalaryField.Text = "Annual Salary"
        '
        'lblPayRate
        '
        Me.lblPayRate.AutoSize = True
        Me.lblPayRate.Location = New System.Drawing.Point(420, 249)
        Me.lblPayRate.Name = "lblPayRate"
        Me.lblPayRate.Size = New System.Drawing.Size(51, 13)
        Me.lblPayRate.TabIndex = 18
        Me.lblPayRate.Text = "Pay Rate"
        '
        'lblPayRateField
        '
        Me.lblPayRateField.AutoSize = True
        Me.lblPayRateField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayRateField.Location = New System.Drawing.Point(420, 222)
        Me.lblPayRateField.Name = "lblPayRateField"
        Me.lblPayRateField.Size = New System.Drawing.Size(59, 13)
        Me.lblPayRateField.TabIndex = 17
        Me.lblPayRateField.Text = "Pay Rate"
        '
        'lblPayEndDate
        '
        Me.lblPayEndDate.AutoSize = True
        Me.lblPayEndDate.Location = New System.Drawing.Point(317, 249)
        Me.lblPayEndDate.Name = "lblPayEndDate"
        Me.lblPayEndDate.Size = New System.Drawing.Size(73, 13)
        Me.lblPayEndDate.TabIndex = 16
        Me.lblPayEndDate.Text = "Pay End Date"
        '
        'lblPayEndDateField
        '
        Me.lblPayEndDateField.AutoSize = True
        Me.lblPayEndDateField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayEndDateField.Location = New System.Drawing.Point(317, 222)
        Me.lblPayEndDateField.Name = "lblPayEndDateField"
        Me.lblPayEndDateField.Size = New System.Drawing.Size(85, 13)
        Me.lblPayEndDateField.TabIndex = 15
        Me.lblPayEndDateField.Text = "Pay End Date"
        '
        'lblPayStartDate
        '
        Me.lblPayStartDate.AutoSize = True
        Me.lblPayStartDate.Location = New System.Drawing.Point(216, 249)
        Me.lblPayStartDate.Name = "lblPayStartDate"
        Me.lblPayStartDate.Size = New System.Drawing.Size(76, 13)
        Me.lblPayStartDate.TabIndex = 14
        Me.lblPayStartDate.Text = "Pay Start Date"
        '
        'lblPayStartDateField
        '
        Me.lblPayStartDateField.AutoSize = True
        Me.lblPayStartDateField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayStartDateField.Location = New System.Drawing.Point(216, 222)
        Me.lblPayStartDateField.Name = "lblPayStartDateField"
        Me.lblPayStartDateField.Size = New System.Drawing.Size(90, 13)
        Me.lblPayStartDateField.TabIndex = 13
        Me.lblPayStartDateField.Text = "Pay Start Date"
        '
        'lblPaymentDate
        '
        Me.lblPaymentDate.AutoSize = True
        Me.lblPaymentDate.Location = New System.Drawing.Point(115, 249)
        Me.lblPaymentDate.Name = "lblPaymentDate"
        Me.lblPaymentDate.Size = New System.Drawing.Size(74, 13)
        Me.lblPaymentDate.TabIndex = 12
        Me.lblPaymentDate.Text = "Payment Date"
        '
        'lblPaymentDateField
        '
        Me.lblPaymentDateField.AutoSize = True
        Me.lblPaymentDateField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentDateField.Location = New System.Drawing.Point(115, 222)
        Me.lblPaymentDateField.Name = "lblPaymentDateField"
        Me.lblPaymentDateField.Size = New System.Drawing.Size(86, 13)
        Me.lblPaymentDateField.TabIndex = 11
        Me.lblPaymentDateField.Text = "Payment Date"
        '
        'lblPayPeriod
        '
        Me.lblPayPeriod.AutoSize = True
        Me.lblPayPeriod.Location = New System.Drawing.Point(22, 249)
        Me.lblPayPeriod.Name = "lblPayPeriod"
        Me.lblPayPeriod.Size = New System.Drawing.Size(58, 13)
        Me.lblPayPeriod.TabIndex = 10
        Me.lblPayPeriod.Text = "Pay Period"
        '
        'lblPayPeriodField
        '
        Me.lblPayPeriodField.AutoSize = True
        Me.lblPayPeriodField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayPeriodField.Location = New System.Drawing.Point(22, 222)
        Me.lblPayPeriodField.Name = "lblPayPeriodField"
        Me.lblPayPeriodField.Size = New System.Drawing.Size(68, 13)
        Me.lblPayPeriodField.TabIndex = 9
        Me.lblPayPeriodField.Text = "Pay Period"
        '
        'lblPayPeriodAndSalary
        '
        Me.lblPayPeriodAndSalary.AutoSize = True
        Me.lblPayPeriodAndSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayPeriodAndSalary.Location = New System.Drawing.Point(22, 191)
        Me.lblPayPeriodAndSalary.Name = "lblPayPeriodAndSalary"
        Me.lblPayPeriodAndSalary.Size = New System.Drawing.Size(132, 13)
        Me.lblPayPeriodAndSalary.TabIndex = 8
        Me.lblPayPeriodAndSalary.Text = "Pay Period and Salary"
        '
        'lblEmployeeAddress2
        '
        Me.lblEmployeeAddress2.AutoSize = True
        Me.lblEmployeeAddress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeAddress2.Location = New System.Drawing.Point(128, 140)
        Me.lblEmployeeAddress2.Name = "lblEmployeeAddress2"
        Me.lblEmployeeAddress2.Size = New System.Drawing.Size(88, 13)
        Me.lblEmployeeAddress2.TabIndex = 7
        Me.lblEmployeeAddress2.Text = "City, State Zip"
        '
        'lblEmployeeAddress1
        '
        Me.lblEmployeeAddress1.AutoSize = True
        Me.lblEmployeeAddress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeAddress1.Location = New System.Drawing.Point(128, 111)
        Me.lblEmployeeAddress1.Name = "lblEmployeeAddress1"
        Me.lblEmployeeAddress1.Size = New System.Drawing.Size(90, 13)
        Me.lblEmployeeAddress1.TabIndex = 6
        Me.lblEmployeeAddress1.Text = "Street Address"
        '
        'lblEmployeeAddressField
        '
        Me.lblEmployeeAddressField.AutoSize = True
        Me.lblEmployeeAddressField.Location = New System.Drawing.Point(22, 111)
        Me.lblEmployeeAddressField.Name = "lblEmployeeAddressField"
        Me.lblEmployeeAddressField.Size = New System.Drawing.Size(97, 13)
        Me.lblEmployeeAddressField.TabIndex = 5
        Me.lblEmployeeAddressField.Text = "Employee Address:"
        '
        'lblHireDate
        '
        Me.lblHireDate.AutoSize = True
        Me.lblHireDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHireDate.Location = New System.Drawing.Point(128, 82)
        Me.lblHireDate.Name = "lblHireDate"
        Me.lblHireDate.Size = New System.Drawing.Size(61, 13)
        Me.lblHireDate.TabIndex = 4
        Me.lblHireDate.Text = "Hire Date"
        '
        'lblHireDateField
        '
        Me.lblHireDateField.AutoSize = True
        Me.lblHireDateField.Location = New System.Drawing.Point(22, 82)
        Me.lblHireDateField.Name = "lblHireDateField"
        Me.lblHireDateField.Size = New System.Drawing.Size(55, 13)
        Me.lblHireDateField.TabIndex = 3
        Me.lblHireDateField.Text = "Hire Date:"
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.Location = New System.Drawing.Point(128, 53)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(97, 13)
        Me.lblEmployeeName.TabIndex = 2
        Me.lblEmployeeName.Text = "Employee Name"
        '
        'lblEmployeeNameField
        '
        Me.lblEmployeeNameField.AutoSize = True
        Me.lblEmployeeNameField.Location = New System.Drawing.Point(22, 53)
        Me.lblEmployeeNameField.Name = "lblEmployeeNameField"
        Me.lblEmployeeNameField.Size = New System.Drawing.Size(87, 13)
        Me.lblEmployeeNameField.TabIndex = 1
        Me.lblEmployeeNameField.Text = "Employee Name:"
        '
        'lblPaySlip
        '
        Me.lblPaySlip.AutoSize = True
        Me.lblPaySlip.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaySlip.Location = New System.Drawing.Point(21, 12)
        Me.lblPaySlip.Name = "lblPaySlip"
        Me.lblPaySlip.Size = New System.Drawing.Size(77, 24)
        Me.lblPaySlip.TabIndex = 0
        Me.lblPaySlip.Text = "Pay Slip"
        '
        'pnlReports
        '
        Me.pnlReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlReports.Location = New System.Drawing.Point(0, 0)
        Me.pnlReports.Name = "pnlReports"
        Me.pnlReports.Size = New System.Drawing.Size(664, 481)
        Me.pnlReports.TabIndex = 65
        '
        'pnlManageVacations
        '
        Me.pnlManageVacations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlManageVacations.Location = New System.Drawing.Point(0, 0)
        Me.pnlManageVacations.Name = "pnlManageVacations"
        Me.pnlManageVacations.Size = New System.Drawing.Size(664, 481)
        Me.pnlManageVacations.TabIndex = 64
        '
        'mnuNavigation
        '
        Me.mnuNavigation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiFile, Me.tmiEmployee, Me.tmiManage})
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
        Me.tmiLogInOut.Size = New System.Drawing.Size(117, 22)
        Me.tmiLogInOut.Text = "Log In"
        '
        'tmiClockInOut
        '
        Me.tmiClockInOut.Name = "tmiClockInOut"
        Me.tmiClockInOut.Size = New System.Drawing.Size(117, 22)
        Me.tmiClockInOut.Text = "Clock In"
        '
        'tmiExit
        '
        Me.tmiExit.Name = "tmiExit"
        Me.tmiExit.Size = New System.Drawing.Size(117, 22)
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
        'tmiManage
        '
        Me.tmiManage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiViewEmployees, Me.tmiManageVacations, Me.tmiReports})
        Me.tmiManage.Name = "tmiManage"
        Me.tmiManage.Size = New System.Drawing.Size(62, 20)
        Me.tmiManage.Text = "Manage"
        '
        'tmiViewEmployees
        '
        Me.tmiViewEmployees.Name = "tmiViewEmployees"
        Me.tmiViewEmployees.Size = New System.Drawing.Size(171, 22)
        Me.tmiViewEmployees.Text = "View Employees"
        '
        'tmiManageVacations
        '
        Me.tmiManageVacations.Name = "tmiManageVacations"
        Me.tmiManageVacations.Size = New System.Drawing.Size(171, 22)
        Me.tmiManageVacations.Text = "Manage Vacations"
        '
        'tmiReports
        '
        Me.tmiReports.Name = "tmiReports"
        Me.tmiReports.Size = New System.Drawing.Size(171, 22)
        Me.tmiReports.Text = "Reports"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 485)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(826, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 507)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.mnuNavigation)
        Me.MainMenuStrip = Me.mnuNavigation
        Me.Name = "Form1"
        Me.Text = "Employee Management System"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pnlNavigationManager.ResumeLayout(False)
        Me.pnlNavigationEmployee.ResumeLayout(False)
        Me.pnlEditEmployee.ResumeLayout(False)
        Me.pnlEditEmployee.PerformLayout()
        Me.pnlViewEmployees.ResumeLayout(False)
        Me.pnlViewEmployees.PerformLayout()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMessages.ResumeLayout(False)
        Me.pnlMessages.PerformLayout()
        Me.pnlMessageNavigation.ResumeLayout(False)
        Me.pnlRequestVacation.ResumeLayout(False)
        Me.pnlRequestVacation.PerformLayout()
        Me.pnlChangePassword.ResumeLayout(False)
        Me.pnlChangePassword.PerformLayout()
        Me.pnlPaySlip.ResumeLayout(False)
        Me.pnlPaySlip.PerformLayout()
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
    Friend WithEvents pnlNavigationEmployee As System.Windows.Forms.Panel
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
    Friend WithEvents pnlPaySlip As System.Windows.Forms.Panel
    Friend WithEvents lblEmployeeAddress1 As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeAddressField As System.Windows.Forms.Label
    Friend WithEvents lblHireDate As System.Windows.Forms.Label
    Friend WithEvents lblHireDateField As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeName As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeNameField As System.Windows.Forms.Label
    Friend WithEvents lblPaySlip As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeAddress2 As System.Windows.Forms.Label
    Friend WithEvents lblAnnualSalary As System.Windows.Forms.Label
    Friend WithEvents lblAnnualSalaryField As System.Windows.Forms.Label
    Friend WithEvents lblPayRate As System.Windows.Forms.Label
    Friend WithEvents lblPayRateField As System.Windows.Forms.Label
    Friend WithEvents lblPayEndDate As System.Windows.Forms.Label
    Friend WithEvents lblPayEndDateField As System.Windows.Forms.Label
    Friend WithEvents lblPayStartDate As System.Windows.Forms.Label
    Friend WithEvents lblPayStartDateField As System.Windows.Forms.Label
    Friend WithEvents lblPaymentDate As System.Windows.Forms.Label
    Friend WithEvents lblPaymentDateField As System.Windows.Forms.Label
    Friend WithEvents lblPayPeriod As System.Windows.Forms.Label
    Friend WithEvents lblPayPeriodField As System.Windows.Forms.Label
    Friend WithEvents lblPayPeriodAndSalary As System.Windows.Forms.Label
    Friend WithEvents lblNetPayYTD As System.Windows.Forms.Label
    Friend WithEvents lblNetPayCurrent As System.Windows.Forms.Label
    Friend WithEvents lblNetPayField As System.Windows.Forms.Label
    Friend WithEvents lblTaxesYTD As System.Windows.Forms.Label
    Friend WithEvents lblTaxesCurrent As System.Windows.Forms.Label
    Friend WithEvents lblTaxesField As System.Windows.Forms.Label
    Friend WithEvents lblPreTaxYTD As System.Windows.Forms.Label
    Friend WithEvents lblPreTaxCurrent As System.Windows.Forms.Label
    Friend WithEvents lblPreTaxField As System.Windows.Forms.Label
    Friend WithEvents lblGrossYTD As System.Windows.Forms.Label
    Friend WithEvents lblGrossCurrent As System.Windows.Forms.Label
    Friend WithEvents lblGrossField As System.Windows.Forms.Label
    Friend WithEvents lblYTDField As System.Windows.Forms.Label
    Friend WithEvents lblCurrentField As System.Windows.Forms.Label
    Friend WithEvents lblSummary As System.Windows.Forms.Label
    Friend WithEvents lblYTDAmountHoliday As System.Windows.Forms.Label
    Friend WithEvents lblYTDAmountVacation As System.Windows.Forms.Label
    Friend WithEvents lblYTDAmountPersonal As System.Windows.Forms.Label
    Friend WithEvents lblYTDAmountRegular As System.Windows.Forms.Label
    Friend WithEvents lblYTDAmountField As System.Windows.Forms.Label
    Friend WithEvents lblYTDHoursHoliday As System.Windows.Forms.Label
    Friend WithEvents lblYTDHoursVacation As System.Windows.Forms.Label
    Friend WithEvents lblYTDHoursPersonal As System.Windows.Forms.Label
    Friend WithEvents lblYTDHoursRegular As System.Windows.Forms.Label
    Friend WithEvents lblYTDHoursField As System.Windows.Forms.Label
    Friend WithEvents lblCurrentAmountHoliday As System.Windows.Forms.Label
    Friend WithEvents lblCurrentAmountVacation As System.Windows.Forms.Label
    Friend WithEvents lblCurrentAmountPersonal As System.Windows.Forms.Label
    Friend WithEvents lblCurrentAmountRegular As System.Windows.Forms.Label
    Friend WithEvents lblCurrentAmountField As System.Windows.Forms.Label
    Friend WithEvents lblCurrentHoursHoliday As System.Windows.Forms.Label
    Friend WithEvents lblCurrentHoursVacation As System.Windows.Forms.Label
    Friend WithEvents lblCurrentHoursPersonal As System.Windows.Forms.Label
    Friend WithEvents lblCurrentHoursRegular As System.Windows.Forms.Label
    Friend WithEvents lblCurrentHoursField As System.Windows.Forms.Label
    Friend WithEvents lblHolidayPayField As System.Windows.Forms.Label
    Friend WithEvents lblVacationPayField As System.Windows.Forms.Label
    Friend WithEvents lblPersonalPayField As System.Windows.Forms.Label
    Friend WithEvents lblRegularPayField As System.Windows.Forms.Label
    Friend WithEvents lblDescriptionField As System.Windows.Forms.Label
    Friend WithEvents lblHoursAndEarnings As System.Windows.Forms.Label
    Friend WithEvents cboWorkPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents pnlRequestVacation As System.Windows.Forms.Panel
    Friend WithEvents calVacation As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblVacationRequest As System.Windows.Forms.Label
    Friend WithEvents lblDatesRequested As System.Windows.Forms.Label
    Friend WithEvents pnlMessages As System.Windows.Forms.Panel
    Friend WithEvents pnlMessageNavigation As System.Windows.Forms.Panel
    Friend WithEvents btnViewed As System.Windows.Forms.Button
    Friend WithEvents btnSent As System.Windows.Forms.Button
    Friend WithEvents btnInbox As System.Windows.Forms.Button
    Friend WithEvents lsvMessages As System.Windows.Forms.ListView
    Friend WithEvents lblMessages As System.Windows.Forms.Label
    Friend WithEvents pnlChangePassword As System.Windows.Forms.Panel
    Friend WithEvents btnChangePasswordOK As System.Windows.Forms.Button
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblRetypePassword As System.Windows.Forms.Label
    Friend WithEvents txtRetypePassword As System.Windows.Forms.TextBox
    Friend WithEvents lblNewPassword As System.Windows.Forms.Label
    Friend WithEvents txtCurrentPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblCurrentPassword As System.Windows.Forms.Label
    Friend WithEvents lblChangePassword As System.Windows.Forms.Label
    Friend WithEvents lblChangePasswordMessage As System.Windows.Forms.Label
    Friend WithEvents pnlNavigationManager As System.Windows.Forms.Panel
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnManageVacations As System.Windows.Forms.Button
    Friend WithEvents btnViewEmployees As System.Windows.Forms.Button
    Friend WithEvents pnlViewEmployees As System.Windows.Forms.Panel
    Friend WithEvents lblViewEmployees As System.Windows.Forms.Label
    Friend WithEvents pnlReports As System.Windows.Forms.Panel
    Friend WithEvents pnlManageVacations As System.Windows.Forms.Panel
    Friend WithEvents tmiManage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiViewEmployees As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiManageVacations As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmiReports As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvEmployees As System.Windows.Forms.DataGridView
    Friend WithEvents btnSubmitRequest As System.Windows.Forms.Button
    Friend WithEvents txtDateList As System.Windows.Forms.TextBox
    Friend WithEvents txtRequestList As System.Windows.Forms.TextBox
    Friend WithEvents lblSubmittedRequests As System.Windows.Forms.Label
    Friend WithEvents pnlEditEmployee As System.Windows.Forms.Panel
    Friend WithEvents lblEditEmployee As System.Windows.Forms.Label

End Class
