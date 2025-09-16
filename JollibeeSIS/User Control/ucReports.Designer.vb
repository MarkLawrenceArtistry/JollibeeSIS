<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucReports
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnToday = New Guna.UI2.WinForms.Guna2Button()
        Me.btnThisWeek = New Guna.UI2.WinForms.Guna2Button()
        Me.btnThisMonth = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGenerate = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.dtpStartDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnThisYear = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLowStockReport = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnToday
        '
        Me.btnToday.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnToday.BorderThickness = 1
        Me.btnToday.CheckedState.Parent = Me.btnToday
        Me.btnToday.CustomImages.Parent = Me.btnToday
        Me.btnToday.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnToday.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnToday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnToday.HoverState.Parent = Me.btnToday
        Me.btnToday.Location = New System.Drawing.Point(34, 98)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.ShadowDecoration.Parent = Me.btnToday
        Me.btnToday.Size = New System.Drawing.Size(215, 45)
        Me.btnToday.TabIndex = 2
        Me.btnToday.Text = "Today"
        '
        'btnThisWeek
        '
        Me.btnThisWeek.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnThisWeek.BorderThickness = 1
        Me.btnThisWeek.CheckedState.Parent = Me.btnThisWeek
        Me.btnThisWeek.CustomImages.Parent = Me.btnThisWeek
        Me.btnThisWeek.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnThisWeek.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnThisWeek.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnThisWeek.HoverState.Parent = Me.btnThisWeek
        Me.btnThisWeek.Location = New System.Drawing.Point(286, 98)
        Me.btnThisWeek.Name = "btnThisWeek"
        Me.btnThisWeek.ShadowDecoration.Parent = Me.btnThisWeek
        Me.btnThisWeek.Size = New System.Drawing.Size(215, 45)
        Me.btnThisWeek.TabIndex = 2
        Me.btnThisWeek.Text = "This Week"
        '
        'btnThisMonth
        '
        Me.btnThisMonth.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnThisMonth.BorderThickness = 1
        Me.btnThisMonth.CheckedState.Parent = Me.btnThisMonth
        Me.btnThisMonth.CustomImages.Parent = Me.btnThisMonth
        Me.btnThisMonth.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnThisMonth.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnThisMonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnThisMonth.HoverState.Parent = Me.btnThisMonth
        Me.btnThisMonth.Location = New System.Drawing.Point(539, 98)
        Me.btnThisMonth.Name = "btnThisMonth"
        Me.btnThisMonth.ShadowDecoration.Parent = Me.btnThisMonth
        Me.btnThisMonth.Size = New System.Drawing.Size(231, 45)
        Me.btnThisMonth.TabIndex = 2
        Me.btnThisMonth.Text = "This Month"
        '
        'btnGenerate
        '
        Me.btnGenerate.BorderRadius = 30
        Me.btnGenerate.CheckedState.Parent = Me.btnGenerate
        Me.btnGenerate.CustomImages.Parent = Me.btnGenerate
        Me.btnGenerate.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnGenerate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.HoverState.Parent = Me.btnGenerate
        Me.btnGenerate.Location = New System.Drawing.Point(34, 325)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.ShadowDecoration.Parent = Me.btnGenerate
        Me.btnGenerate.Size = New System.Drawing.Size(1006, 56)
        Me.btnGenerate.TabIndex = 3
        Me.btnGenerate.Text = "Generate Sales Report"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(26, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 47)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Reports"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.BorderRadius = 5
        Me.dtpEndDate.CheckedState.Parent = Me.dtpEndDate
        Me.dtpEndDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.dtpEndDate.ForeColor = System.Drawing.Color.White
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpEndDate.HoverState.Parent = Me.dtpEndDate
        Me.dtpEndDate.Location = New System.Drawing.Point(539, 49)
        Me.dtpEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.ShadowDecoration.Parent = Me.dtpEndDate
        Me.dtpEndDate.Size = New System.Drawing.Size(438, 45)
        Me.dtpEndDate.TabIndex = 8
        Me.dtpEndDate.Value = New Date(2025, 9, 11, 23, 28, 18, 880)
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.BackColor = System.Drawing.Color.Transparent
        Me.lblEnd.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblEnd.Location = New System.Drawing.Point(535, 16)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(80, 23)
        Me.lblEnd.TabIndex = 7
        Me.lblEnd.Text = "End Date"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.BorderRadius = 5
        Me.dtpStartDate.CheckedState.Parent = Me.dtpStartDate
        Me.dtpStartDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.dtpStartDate.ForeColor = System.Drawing.Color.White
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpStartDate.HoverState.Parent = Me.dtpStartDate
        Me.dtpStartDate.Location = New System.Drawing.Point(30, 49)
        Me.dtpStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.ShadowDecoration.Parent = Me.dtpStartDate
        Me.dtpStartDate.Size = New System.Drawing.Size(437, 45)
        Me.dtpStartDate.TabIndex = 6
        Me.dtpStartDate.Value = New Date(2025, 9, 11, 23, 28, 18, 880)
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.BackColor = System.Drawing.Color.Transparent
        Me.lblStart.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblStart.Location = New System.Drawing.Point(26, 16)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(86, 23)
        Me.lblStart.TabIndex = 5
        Me.lblStart.Text = "Start Date"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderRadius = 10
        Me.Guna2Panel1.Controls.Add(Me.dtpEndDate)
        Me.Guna2Panel1.Controls.Add(Me.lblStart)
        Me.Guna2Panel1.Controls.Add(Me.lblEnd)
        Me.Guna2Panel1.Controls.Add(Me.dtpStartDate)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(34, 181)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1006, 119)
        Me.Guna2Panel1.TabIndex = 9
        '
        'btnThisYear
        '
        Me.btnThisYear.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnThisYear.BorderThickness = 1
        Me.btnThisYear.CheckedState.Parent = Me.btnThisYear
        Me.btnThisYear.CustomImages.Parent = Me.btnThisYear
        Me.btnThisYear.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnThisYear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnThisYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnThisYear.HoverState.Parent = Me.btnThisYear
        Me.btnThisYear.Location = New System.Drawing.Point(809, 98)
        Me.btnThisYear.Name = "btnThisYear"
        Me.btnThisYear.ShadowDecoration.Parent = Me.btnThisYear
        Me.btnThisYear.Size = New System.Drawing.Size(231, 45)
        Me.btnThisYear.TabIndex = 2
        Me.btnThisYear.Text = "This Year"
        '
        'btnLowStockReport
        '
        Me.btnLowStockReport.BorderRadius = 30
        Me.btnLowStockReport.CheckedState.Parent = Me.btnLowStockReport
        Me.btnLowStockReport.CustomImages.Parent = Me.btnLowStockReport
        Me.btnLowStockReport.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnLowStockReport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLowStockReport.ForeColor = System.Drawing.Color.White
        Me.btnLowStockReport.HoverState.Parent = Me.btnLowStockReport
        Me.btnLowStockReport.Location = New System.Drawing.Point(34, 387)
        Me.btnLowStockReport.Name = "btnLowStockReport"
        Me.btnLowStockReport.ShadowDecoration.Parent = Me.btnLowStockReport
        Me.btnLowStockReport.Size = New System.Drawing.Size(1006, 56)
        Me.btnLowStockReport.TabIndex = 3
        Me.btnLowStockReport.Text = "Generate Low Stock Report"
        '
        'ucReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnLowStockReport)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnThisYear)
        Me.Controls.Add(Me.btnThisMonth)
        Me.Controls.Add(Me.btnThisWeek)
        Me.Controls.Add(Me.btnToday)
        Me.Name = "ucReports"
        Me.Size = New System.Drawing.Size(1081, 725)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnToday As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnThisWeek As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnThisMonth As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGenerate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnThisYear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLowStockReport As Guna.UI2.WinForms.Guna2Button

End Class
