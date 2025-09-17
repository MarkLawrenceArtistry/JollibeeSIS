<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngredientAddEdit
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
        Me.txtIngredientName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUnit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numStock = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIngredientName
        '
        Me.txtIngredientName.BorderRadius = 5
        Me.txtIngredientName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIngredientName.DefaultText = ""
        Me.txtIngredientName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtIngredientName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtIngredientName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIngredientName.DisabledState.Parent = Me.txtIngredientName
        Me.txtIngredientName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIngredientName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.txtIngredientName.FocusedState.Parent = Me.txtIngredientName
        Me.txtIngredientName.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngredientName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIngredientName.HoverState.Parent = Me.txtIngredientName
        Me.txtIngredientName.Location = New System.Drawing.Point(32, 87)
        Me.txtIngredientName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIngredientName.Name = "txtIngredientName"
        Me.txtIngredientName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIngredientName.PlaceholderText = "3 ounce lid"
        Me.txtIngredientName.SelectedText = ""
        Me.txtIngredientName.ShadowDecoration.Parent = Me.txtIngredientName
        Me.txtIngredientName.Size = New System.Drawing.Size(439, 44)
        Me.txtIngredientName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingredient Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Stocks"
        '
        'txtUnit
        '
        Me.txtUnit.BorderRadius = 5
        Me.txtUnit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUnit.DefaultText = ""
        Me.txtUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUnit.DisabledState.Parent = Me.txtUnit
        Me.txtUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.txtUnit.FocusedState.Parent = Me.txtUnit
        Me.txtUnit.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUnit.HoverState.Parent = Me.txtUnit
        Me.txtUnit.Location = New System.Drawing.Point(272, 193)
        Me.txtUnit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUnit.PlaceholderText = "Grams, Kilograms..."
        Me.txtUnit.SelectedText = ""
        Me.txtUnit.ShadowDecoration.Parent = Me.txtUnit
        Me.txtUnit.Size = New System.Drawing.Size(199, 44)
        Me.txtUnit.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(269, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Unit"
        '
        'numStock
        '
        Me.numStock.BackColor = System.Drawing.Color.Transparent
        Me.numStock.BorderRadius = 5
        Me.numStock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numStock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.numStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.numStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.numStock.DisabledState.Parent = Me.numStock
        Me.numStock.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.numStock.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.numStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numStock.FocusedState.Parent = Me.numStock
        Me.numStock.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.numStock.Location = New System.Drawing.Point(34, 193)
        Me.numStock.Name = "numStock"
        Me.numStock.ShadowDecoration.Parent = Me.numStock
        Me.numStock.Size = New System.Drawing.Size(199, 44)
        Me.numStock.TabIndex = 8
        Me.numStock.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 5
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(34, 337)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(437, 45)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.BorderRadius = 5
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Location = New System.Drawing.Point(34, 286)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(437, 45)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        '
        'frmIngredientAddEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(505, 427)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.numStock)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIngredientName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmIngredientAddEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingredient Details"
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIngredientName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUnit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents numStock As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
End Class
