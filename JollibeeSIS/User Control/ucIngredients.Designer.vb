<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucIngredients
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgvIngredients = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgvIngredients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(26, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 47)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Ingredients"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.BackColor = System.Drawing.Color.Transparent
        Me.lblStart.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.lblStart.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblStart.Location = New System.Drawing.Point(31, 79)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(104, 15)
        Me.lblStart.TabIndex = 8
        Me.lblStart.Text = "Search Ingredients"
        '
        'txtSearch
        '
        Me.txtSearch.BorderRadius = 5
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.Location = New System.Drawing.Point(34, 98)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search.."
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(342, 44)
        Me.txtSearch.TabIndex = 7
        '
        'dgvIngredients
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvIngredients.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvIngredients.BackgroundColor = System.Drawing.Color.White
        Me.dgvIngredients.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvIngredients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvIngredients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIngredients.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvIngredients.ColumnHeadersHeight = 4
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvIngredients.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvIngredients.EnableHeadersVisualStyles = False
        Me.dgvIngredients.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvIngredients.Location = New System.Drawing.Point(34, 157)
        Me.dgvIngredients.Name = "dgvIngredients"
        Me.dgvIngredients.RowHeadersVisible = False
        Me.dgvIngredients.RowTemplate.Height = 24
        Me.dgvIngredients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvIngredients.Size = New System.Drawing.Size(1004, 528)
        Me.dgvIngredients.TabIndex = 11
        Me.dgvIngredients.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvIngredients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvIngredients.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvIngredients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvIngredients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvIngredients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvIngredients.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvIngredients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvIngredients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvIngredients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvIngredients.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvIngredients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvIngredients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvIngredients.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvIngredients.ThemeStyle.ReadOnly = False
        Me.dgvIngredients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvIngredients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvIngredients.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvIngredients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvIngredients.ThemeStyle.RowsStyle.Height = 24
        Me.dgvIngredients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvIngredients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnUpdate
        '
        Me.btnUpdate.BorderRadius = 5
        Me.btnUpdate.CheckedState.Parent = Me.btnUpdate
        Me.btnUpdate.CustomImages.Parent = Me.btnUpdate
        Me.btnUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.HoverState.Parent = Me.btnUpdate
        Me.btnUpdate.Location = New System.Drawing.Point(669, 97)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ShadowDecoration.Parent = Me.btnUpdate
        Me.btnUpdate.Size = New System.Drawing.Size(180, 45)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update Selected"
        '
        'btnAdd
        '
        Me.btnAdd.BorderRadius = 5
        Me.btnAdd.CheckedState.Parent = Me.btnAdd
        Me.btnAdd.CustomImages.Parent = Me.btnAdd
        Me.btnAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.HoverState.Parent = Me.btnAdd
        Me.btnAdd.Location = New System.Drawing.Point(855, 97)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.Size = New System.Drawing.Size(183, 45)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add New Ingredient"
        '
        'ucIngredients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Controls.Add(Me.dgvIngredients)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label5)
        Me.Name = "ucIngredients"
        Me.Size = New System.Drawing.Size(1081, 725)
        CType(Me.dgvIngredients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvIngredients As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button

End Class
