<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPOS
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
        Me.txtBarcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.flpProducts = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlCart = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnPay = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.dgvCart = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlCart.SuspendLayout()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBarcode
        '
        Me.txtBarcode.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.txtBarcode.BorderRadius = 5
        Me.txtBarcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBarcode.DefaultText = ""
        Me.txtBarcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBarcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBarcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBarcode.DisabledState.Parent = Me.txtBarcode
        Me.txtBarcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBarcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.txtBarcode.FocusedState.Parent = Me.txtBarcode
        Me.txtBarcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBarcode.HoverState.Parent = Me.txtBarcode
        Me.txtBarcode.Location = New System.Drawing.Point(28, 30)
        Me.txtBarcode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBarcode.PlaceholderText = "Barcode"
        Me.txtBarcode.SelectedText = ""
        Me.txtBarcode.ShadowDecoration.Parent = Me.txtBarcode
        Me.txtBarcode.Size = New System.Drawing.Size(286, 48)
        Me.txtBarcode.TabIndex = 0
        '
        'flpProducts
        '
        Me.flpProducts.AutoScroll = True
        Me.flpProducts.BackColor = System.Drawing.Color.White
        Me.flpProducts.Location = New System.Drawing.Point(28, 99)
        Me.flpProducts.Name = "flpProducts"
        Me.flpProducts.Size = New System.Drawing.Size(286, 590)
        Me.flpProducts.TabIndex = 1
        '
        'pnlCart
        '
        Me.pnlCart.Controls.Add(Me.btnPay)
        Me.pnlCart.Controls.Add(Me.btnClear)
        Me.pnlCart.Controls.Add(Me.lblTotal)
        Me.pnlCart.Controls.Add(Me.lblTax)
        Me.pnlCart.Controls.Add(Me.Label3)
        Me.pnlCart.Controls.Add(Me.Label2)
        Me.pnlCart.Controls.Add(Me.Label1)
        Me.pnlCart.Controls.Add(Me.lblSubtotal)
        Me.pnlCart.Controls.Add(Me.dgvCart)
        Me.pnlCart.FillColor = System.Drawing.Color.White
        Me.pnlCart.Location = New System.Drawing.Point(332, 30)
        Me.pnlCart.Name = "pnlCart"
        Me.pnlCart.ShadowDecoration.Parent = Me.pnlCart
        Me.pnlCart.Size = New System.Drawing.Size(712, 659)
        Me.pnlCart.TabIndex = 2
        '
        'btnPay
        '
        Me.btnPay.BorderRadius = 15
        Me.btnPay.CheckedState.Parent = Me.btnPay
        Me.btnPay.CustomImages.Parent = Me.btnPay
        Me.btnPay.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnPay.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.Color.White
        Me.btnPay.HoverState.Parent = Me.btnPay
        Me.btnPay.Location = New System.Drawing.Point(384, 415)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.ShadowDecoration.Parent = Me.btnPay
        Me.btnPay.Size = New System.Drawing.Size(296, 135)
        Me.btnPay.TabIndex = 2
        Me.btnPay.Text = "Pay"
        '
        'btnClear
        '
        Me.btnClear.BorderRadius = 10
        Me.btnClear.CheckedState.Parent = Me.btnClear
        Me.btnClear.CustomImages.Parent = Me.btnClear
        Me.btnClear.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnClear.HoverState.Parent = Me.btnClear
        Me.btnClear.Location = New System.Drawing.Point(384, 560)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.ShadowDecoration.Parent = Me.btnClear
        Me.btnClear.Size = New System.Drawing.Size(296, 64)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.lblTotal.Location = New System.Drawing.Point(28, 578)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 46)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.BackColor = System.Drawing.Color.Transparent
        Me.lblTax.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.lblTax.Location = New System.Drawing.Point(28, 504)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(0, 46)
        Me.lblTax.TabIndex = 1
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 560)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 485)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tax"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 415)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SubTotal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtotal.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.lblSubtotal.Location = New System.Drawing.Point(28, 434)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(0, 46)
        Me.lblSubtotal.TabIndex = 1
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvCart
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.dgvCart.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCart.BackgroundColor = System.Drawing.Color.White
        Me.dgvCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvCart.ColumnHeadersHeight = 4
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCart.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCart.EnableHeadersVisualStyles = False
        Me.dgvCart.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCart.Location = New System.Drawing.Point(31, 26)
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.RowHeadersVisible = False
        Me.dgvCart.RowTemplate.Height = 24
        Me.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCart.Size = New System.Drawing.Size(649, 354)
        Me.dgvCart.TabIndex = 0
        Me.dgvCart.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvCart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCart.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvCart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvCart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvCart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvCart.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvCart.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCart.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvCart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvCart.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvCart.ThemeStyle.ReadOnly = False
        Me.dgvCart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvCart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCart.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvCart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvCart.ThemeStyle.RowsStyle.Height = 24
        Me.dgvCart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvCart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ucPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Controls.Add(Me.pnlCart)
        Me.Controls.Add(Me.flpProducts)
        Me.Controls.Add(Me.txtBarcode)
        Me.Name = "ucPOS"
        Me.Size = New System.Drawing.Size(1081, 725)
        Me.pnlCart.ResumeLayout(False)
        Me.pnlCart.PerformLayout()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtBarcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents flpProducts As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlCart As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvCart As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
