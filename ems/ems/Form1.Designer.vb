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
        Me.grbHome = New System.Windows.Forms.GroupBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.grbHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbHome
        '
        Me.grbHome.Controls.Add(Me.lblName)
        Me.grbHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbHome.Location = New System.Drawing.Point(12, 41)
        Me.grbHome.Name = "grbHome"
        Me.grbHome.Size = New System.Drawing.Size(200, 319)
        Me.grbHome.TabIndex = 0
        Me.grbHome.TabStop = False
        Me.grbHome.Text = "Home"
        Me.grbHome.Visible = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(17, 28)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(66, 24)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 428)
        Me.Controls.Add(Me.grbHome)
        Me.Name = "Form1"
        Me.Text = "Employee Management System"
        Me.grbHome.ResumeLayout(False)
        Me.grbHome.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbHome As System.Windows.Forms.GroupBox
    Friend WithEvents lblName As System.Windows.Forms.Label

End Class
