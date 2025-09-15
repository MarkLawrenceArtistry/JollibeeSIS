<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucUsers
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAddUser = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdateUser = New Guna.UI2.WinForms.Guna2Button()
        Me.btnShowQR = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSearchUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgvUsers = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddUser
        '
        Me.btnAddUser.BorderRadius = 5
        Me.btnAddUser.CheckedState.Parent = Me.btnAddUser
        Me.btnAddUser.CustomImages.Parent = Me.btnAddUser
        Me.btnAddUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnAddUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAddUser.ForeColor = System.Drawing.Color.White
        Me.btnAddUser.HoverState.Parent = Me.btnAddUser
        Me.btnAddUser.Location = New System.Drawing.Point(855, 98)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.ShadowDecoration.Parent = Me.btnAddUser
        Me.btnAddUser.Size = New System.Drawing.Size(187, 45)
        Me.btnAddUser.TabIndex = 1
        Me.btnAddUser.Text = "Add New User"
        '
        'btnUpdateUser
        '
        Me.btnUpdateUser.BorderRadius = 5
        Me.btnUpdateUser.CheckedState.Parent = Me.btnUpdateUser
        Me.btnUpdateUser.CustomImages.Parent = Me.btnUpdateUser
        Me.btnUpdateUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnUpdateUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUpdateUser.ForeColor = System.Drawing.Color.White
        Me.btnUpdateUser.HoverState.Parent = Me.btnUpdateUser
        Me.btnUpdateUser.Location = New System.Drawing.Point(669, 98)
        Me.btnUpdateUser.Name = "btnUpdateUser"
        Me.btnUpdateUser.ShadowDecoration.Parent = Me.btnUpdateUser
        Me.btnUpdateUser.Size = New System.Drawing.Size(180, 45)
        Me.btnUpdateUser.TabIndex = 1
        Me.btnUpdateUser.Text = "Update Selected"
        '
        'btnShowQR
        '
        Me.btnShowQR.BorderRadius = 5
        Me.btnShowQR.CheckedState.Parent = Me.btnShowQR
        Me.btnShowQR.CustomImages.Parent = Me.btnShowQR
        Me.btnShowQR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnShowQR.ForeColor = System.Drawing.Color.White
        Me.btnShowQR.HoverState.Parent = Me.btnShowQR
        Me.btnShowQR.Location = New System.Drawing.Point(483, 98)
        Me.btnShowQR.Name = "btnShowQR"
        Me.btnShowQR.ShadowDecoration.Parent = Me.btnShowQR
        Me.btnShowQR.Size = New System.Drawing.Size(180, 45)
        Me.btnShowQR.TabIndex = 1
        Me.btnShowQR.Text = "Show QR Selected"
        '
        'txtSearchUser
        '
        Me.txtSearchUser.BorderRadius = 5
        Me.txtSearchUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchUser.DefaultText = ""
        Me.txtSearchUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchUser.DisabledState.Parent = Me.txtSearchUser
        Me.txtSearchUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchUser.FocusedState.Parent = Me.txtSearchUser
        Me.txtSearchUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchUser.HoverState.Parent = Me.txtSearchUser
        Me.txtSearchUser.Location = New System.Drawing.Point(34, 98)
        Me.txtSearchUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearchUser.Name = "txtSearchUser"
        Me.txtSearchUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchUser.PlaceholderText = "Search.."
        Me.txtSearchUser.SelectedText = ""
        Me.txtSearchUser.ShadowDecoration.Parent = Me.txtSearchUser
        Me.txtSearchUser.Size = New System.Drawing.Size(327, 44)
        Me.txtSearchUser.TabIndex = 2
        '
        'dgvUsers
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.dgvUsers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsers.BackgroundColor = System.Drawing.Color.White
        Me.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvUsers.ColumnHeadersHeight = 4
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUsers.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvUsers.EnableHeadersVisualStyles = False
        Me.dgvUsers.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUsers.Location = New System.Drawing.Point(34, 157)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.RowHeadersVisible = False
        Me.dgvUsers.RowTemplate.Height = 24
        Me.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsers.Size = New System.Drawing.Size(1004, 528)
        Me.dgvUsers.TabIndex = 3
        Me.dgvUsers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvUsers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvUsers.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvUsers.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvUsers.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvUsers.ThemeStyle.ReadOnly = False
        Me.dgvUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvUsers.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvUsers.ThemeStyle.RowsStyle.Height = 24
        Me.dgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2DataGridView1
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.Guna2DataGridView1.ColumnHeadersHeight = 4
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle12
        Me.Guna2DataGridView1.EnableHeadersVisualStyles = False
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(40, 183)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowTemplate.Height = 24
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(985, 414)
        Me.Guna2DataGridView1.TabIndex = 3
        Me.Guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(26, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(323, 47)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "User Management"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.BackColor = System.Drawing.Color.Transparent
        Me.lblStart.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.lblStart.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblStart.Location = New System.Drawing.Point(31, 79)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(87, 15)
        Me.lblStart.TabIndex = 7
        Me.lblStart.Text = "Search Product"
        '
        'ucUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvUsers)
        Me.Controls.Add(Me.txtSearchUser)
        Me.Controls.Add(Me.btnShowQR)
        Me.Controls.Add(Me.btnUpdateUser)
        Me.Controls.Add(Me.btnAddUser)
        Me.Name = "ucUsers"
        Me.Size = New System.Drawing.Size(1081, 725)
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdateUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnShowQR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearchUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvUsers As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label

End Class
