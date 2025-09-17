<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecipeManagement
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvRecipe = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cmbIngredients = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numQuantityUsed = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.lblNumStock = New System.Windows.Forms.Label()
        Me.btnRemoveIngredient = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddIngredient = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSaveRecipe = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvRecipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQuantityUsed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRecipe
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvRecipe.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRecipe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecipe.BackgroundColor = System.Drawing.Color.White
        Me.dgvRecipe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRecipe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecipe.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRecipe.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvRecipe.EnableHeadersVisualStyles = False
        Me.dgvRecipe.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRecipe.Location = New System.Drawing.Point(12, 12)
        Me.dgvRecipe.Name = "dgvRecipe"
        Me.dgvRecipe.RowHeadersVisible = False
        Me.dgvRecipe.RowTemplate.Height = 24
        Me.dgvRecipe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecipe.Size = New System.Drawing.Size(360, 567)
        Me.dgvRecipe.TabIndex = 0
        Me.dgvRecipe.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvRecipe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRecipe.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvRecipe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvRecipe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvRecipe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvRecipe.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvRecipe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRecipe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRecipe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvRecipe.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvRecipe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRecipe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecipe.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvRecipe.ThemeStyle.ReadOnly = False
        Me.dgvRecipe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRecipe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRecipe.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvRecipe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvRecipe.ThemeStyle.RowsStyle.Height = 24
        Me.dgvRecipe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRecipe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'cmbIngredients
        '
        Me.cmbIngredients.BackColor = System.Drawing.Color.Transparent
        Me.cmbIngredients.BorderRadius = 5
        Me.cmbIngredients.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbIngredients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIngredients.FocusedColor = System.Drawing.Color.Empty
        Me.cmbIngredients.FocusedState.Parent = Me.cmbIngredients
        Me.cmbIngredients.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbIngredients.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbIngredients.FormattingEnabled = True
        Me.cmbIngredients.HoverState.Parent = Me.cmbIngredients
        Me.cmbIngredients.ItemHeight = 30
        Me.cmbIngredients.ItemsAppearance.Parent = Me.cmbIngredients
        Me.cmbIngredients.Location = New System.Drawing.Point(389, 144)
        Me.cmbIngredients.Name = "cmbIngredients"
        Me.cmbIngredients.ShadowDecoration.Parent = Me.cmbIngredients
        Me.cmbIngredients.Size = New System.Drawing.Size(259, 36)
        Me.cmbIngredients.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(385, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Select Ingredients"
        '
        'numQuantityUsed
        '
        Me.numQuantityUsed.BackColor = System.Drawing.Color.Transparent
        Me.numQuantityUsed.BorderRadius = 5
        Me.numQuantityUsed.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numQuantityUsed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.numQuantityUsed.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.numQuantityUsed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.numQuantityUsed.DisabledState.Parent = Me.numQuantityUsed
        Me.numQuantityUsed.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.numQuantityUsed.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.numQuantityUsed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numQuantityUsed.FocusedState.Parent = Me.numQuantityUsed
        Me.numQuantityUsed.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numQuantityUsed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.numQuantityUsed.Location = New System.Drawing.Point(389, 242)
        Me.numQuantityUsed.Name = "numQuantityUsed"
        Me.numQuantityUsed.ShadowDecoration.Parent = Me.numQuantityUsed
        Me.numQuantityUsed.Size = New System.Drawing.Size(259, 44)
        Me.numQuantityUsed.TabIndex = 19
        Me.numQuantityUsed.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        '
        'lblNumStock
        '
        Me.lblNumStock.AutoSize = True
        Me.lblNumStock.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumStock.Location = New System.Drawing.Point(385, 203)
        Me.lblNumStock.Name = "lblNumStock"
        Me.lblNumStock.Size = New System.Drawing.Size(98, 19)
        Me.lblNumStock.TabIndex = 18
        Me.lblNumStock.Text = "Quantity Used"
        '
        'btnRemoveIngredient
        '
        Me.btnRemoveIngredient.BorderRadius = 5
        Me.btnRemoveIngredient.CheckedState.Parent = Me.btnRemoveIngredient
        Me.btnRemoveIngredient.CustomImages.Parent = Me.btnRemoveIngredient
        Me.btnRemoveIngredient.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnRemoveIngredient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRemoveIngredient.ForeColor = System.Drawing.Color.White
        Me.btnRemoveIngredient.HoverState.Parent = Me.btnRemoveIngredient
        Me.btnRemoveIngredient.Location = New System.Drawing.Point(388, 373)
        Me.btnRemoveIngredient.Name = "btnRemoveIngredient"
        Me.btnRemoveIngredient.ShadowDecoration.Parent = Me.btnRemoveIngredient
        Me.btnRemoveIngredient.Size = New System.Drawing.Size(260, 45)
        Me.btnRemoveIngredient.TabIndex = 22
        Me.btnRemoveIngredient.Text = "Remove Selected"
        '
        'btnAddIngredient
        '
        Me.btnAddIngredient.BorderRadius = 5
        Me.btnAddIngredient.CheckedState.Parent = Me.btnAddIngredient
        Me.btnAddIngredient.CustomImages.Parent = Me.btnAddIngredient
        Me.btnAddIngredient.FillColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnAddIngredient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAddIngredient.ForeColor = System.Drawing.Color.White
        Me.btnAddIngredient.HoverState.Parent = Me.btnAddIngredient
        Me.btnAddIngredient.Location = New System.Drawing.Point(388, 322)
        Me.btnAddIngredient.Name = "btnAddIngredient"
        Me.btnAddIngredient.ShadowDecoration.Parent = Me.btnAddIngredient
        Me.btnAddIngredient.Size = New System.Drawing.Size(260, 45)
        Me.btnAddIngredient.TabIndex = 21
        Me.btnAddIngredient.Text = "Add To Recipe"
        '
        'btnSaveRecipe
        '
        Me.btnSaveRecipe.BorderRadius = 5
        Me.btnSaveRecipe.CheckedState.Parent = Me.btnSaveRecipe
        Me.btnSaveRecipe.CustomImages.Parent = Me.btnSaveRecipe
        Me.btnSaveRecipe.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnSaveRecipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSaveRecipe.ForeColor = System.Drawing.Color.White
        Me.btnSaveRecipe.HoverState.Parent = Me.btnSaveRecipe
        Me.btnSaveRecipe.Location = New System.Drawing.Point(388, 424)
        Me.btnSaveRecipe.Name = "btnSaveRecipe"
        Me.btnSaveRecipe.ShadowDecoration.Parent = Me.btnSaveRecipe
        Me.btnSaveRecipe.Size = New System.Drawing.Size(259, 45)
        Me.btnSaveRecipe.TabIndex = 20
        Me.btnSaveRecipe.Text = "Save Recipe"
        '
        'btnClose
        '
        Me.btnClose.BorderRadius = 5
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(389, 534)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(259, 45)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "Close"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(385, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Product Name"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(384, 44)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(0, 28)
        Me.lblProductName.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(384, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 28)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Product Name"
        '
        'frmRecipeManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(672, 608)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRemoveIngredient)
        Me.Controls.Add(Me.btnAddIngredient)
        Me.Controls.Add(Me.btnSaveRecipe)
        Me.Controls.Add(Me.numQuantityUsed)
        Me.Controls.Add(Me.lblNumStock)
        Me.Controls.Add(Me.cmbIngredients)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvRecipe)
        Me.Name = "frmRecipeManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRecipeManagement"
        CType(Me.dgvRecipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQuantityUsed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvRecipe As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cmbIngredients As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents numQuantityUsed As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents lblNumStock As System.Windows.Forms.Label
    Friend WithEvents btnRemoveIngredient As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddIngredient As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSaveRecipe As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
