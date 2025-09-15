<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductAddEdit
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProductName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNumStock = New System.Windows.Forms.Label()
        Me.numStock = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.picProductImage = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBrowse = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtBarcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picBarcode = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProductImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Name"
        '
        'txtProductName
        '
        Me.txtProductName.BorderRadius = 5
        Me.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductName.DefaultText = ""
        Me.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductName.DisabledState.Parent = Me.txtProductName
        Me.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.txtProductName.FocusedState.Parent = Me.txtProductName
        Me.txtProductName.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductName.HoverState.Parent = Me.txtProductName
        Me.txtProductName.Location = New System.Drawing.Point(32, 90)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProductName.PlaceholderText = "Chickenjoy Solo.."
        Me.txtProductName.SelectedText = ""
        Me.txtProductName.ShadowDecoration.Parent = Me.txtProductName
        Me.txtProductName.Size = New System.Drawing.Size(231, 44)
        Me.txtProductName.TabIndex = 1
        '
        'txtDescription
        '
        Me.txtDescription.BorderRadius = 5
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescription.DefaultText = ""
        Me.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.DisabledState.Parent = Me.txtDescription
        Me.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.txtDescription.FocusedState.Parent = Me.txtDescription
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.HoverState.Parent = Me.txtDescription
        Me.txtDescription.Location = New System.Drawing.Point(32, 301)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.PlaceholderText = "Add description..."
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.ShadowDecoration.Parent = Me.txtDescription
        Me.txtDescription.Size = New System.Drawing.Size(500, 187)
        Me.txtDescription.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product Description"
        '
        'txtPrice
        '
        Me.txtPrice.BorderRadius = 5
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.DefaultText = ""
        Me.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.DisabledState.Parent = Me.txtPrice
        Me.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.txtPrice.FocusedState.Parent = Me.txtPrice
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.HoverState.Parent = Me.txtPrice
        Me.txtPrice.Location = New System.Drawing.Point(32, 195)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.PlaceholderText = "300.00"
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.ShadowDecoration.Parent = Me.txtPrice
        Me.txtPrice.Size = New System.Drawing.Size(231, 44)
        Me.txtPrice.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Product Price"
        '
        'lblNumStock
        '
        Me.lblNumStock.AutoSize = True
        Me.lblNumStock.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumStock.Location = New System.Drawing.Point(296, 156)
        Me.lblNumStock.Name = "lblNumStock"
        Me.lblNumStock.Size = New System.Drawing.Size(100, 19)
        Me.lblNumStock.TabIndex = 2
        Me.lblNumStock.Text = "Stock Quantity"
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
        Me.numStock.Location = New System.Drawing.Point(299, 195)
        Me.numStock.Name = "numStock"
        Me.numStock.ShadowDecoration.Parent = Me.numStock
        Me.numStock.Size = New System.Drawing.Size(233, 44)
        Me.numStock.TabIndex = 6
        Me.numStock.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        '
        'picProductImage
        '
        Me.picProductImage.BorderRadius = 5
        Me.picProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProductImage.Location = New System.Drawing.Point(562, 160)
        Me.picProductImage.Name = "picProductImage"
        Me.picProductImage.ShadowDecoration.Parent = Me.picProductImage
        Me.picProductImage.Size = New System.Drawing.Size(337, 328)
        Me.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProductImage.TabIndex = 7
        Me.picProductImage.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(559, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Product Image"
        '
        'btnBrowse
        '
        Me.btnBrowse.BorderRadius = 5
        Me.btnBrowse.CheckedState.Parent = Me.btnBrowse
        Me.btnBrowse.CustomImages.Parent = Me.btnBrowse
        Me.btnBrowse.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.HoverState.Parent = Me.btnBrowse
        Me.btnBrowse.Location = New System.Drawing.Point(562, 90)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.ShadowDecoration.Parent = Me.btnBrowse
        Me.btnBrowse.Size = New System.Drawing.Size(337, 45)
        Me.btnBrowse.TabIndex = 8
        Me.btnBrowse.Text = "Browse..."
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
        Me.btnSave.Location = New System.Drawing.Point(933, 392)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(298, 45)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
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
        Me.btnCancel.Location = New System.Drawing.Point(933, 443)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(298, 45)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductID.Location = New System.Drawing.Point(29, 553)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(0, 19)
        Me.lblProductID.TabIndex = 11
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtBarcode
        '
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
        Me.txtBarcode.Location = New System.Drawing.Point(932, 90)
        Me.txtBarcode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBarcode.PlaceholderText = ""
        Me.txtBarcode.ReadOnly = True
        Me.txtBarcode.SelectedText = ""
        Me.txtBarcode.ShadowDecoration.Parent = Me.txtBarcode
        Me.txtBarcode.Size = New System.Drawing.Size(299, 44)
        Me.txtBarcode.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(929, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Product Barcode"
        '
        'picBarcode
        '
        Me.picBarcode.BorderRadius = 5
        Me.picBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBarcode.Location = New System.Drawing.Point(931, 160)
        Me.picBarcode.Name = "picBarcode"
        Me.picBarcode.ShadowDecoration.Parent = Me.picBarcode
        Me.picBarcode.Size = New System.Drawing.Size(300, 108)
        Me.picBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBarcode.TabIndex = 13
        Me.picBarcode.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(296, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Product Category"
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbCategory.BorderRadius = 5
        Me.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FocusedColor = System.Drawing.Color.Empty
        Me.cmbCategory.FocusedState.Parent = Me.cmbCategory
        Me.cmbCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.HoverState.Parent = Me.cmbCategory
        Me.cmbCategory.ItemHeight = 30
        Me.cmbCategory.ItemsAppearance.Parent = Me.cmbCategory
        Me.cmbCategory.Location = New System.Drawing.Point(300, 90)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.ShadowDecoration.Parent = Me.cmbCategory
        Me.cmbCategory.Size = New System.Drawing.Size(232, 36)
        Me.cmbCategory.TabIndex = 15
        '
        'frmProductAddEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1259, 529)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.picBarcode)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.lblProductID)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.picProductImage)
        Me.Controls.Add(Me.numStock)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblNumStock)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmProductAddEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Details"
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProductImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNumStock As System.Windows.Forms.Label
    Friend WithEvents numStock As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents picProductImage As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblProductID As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtBarcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents picBarcode As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbCategory As Guna.UI2.WinForms.Guna2ComboBox
End Class
