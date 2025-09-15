<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDashboard
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlCardSales = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTodaysSales = New System.Windows.Forms.Label()
        Me.pnlCardItems = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblItemsSold = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlCardTransactions = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTransactions = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvTopSelling = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.dgvLowStock = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlCardSales.SuspendLayout()
        Me.pnlCardItems.SuspendLayout()
        Me.pnlCardTransactions.SuspendLayout()
        CType(Me.dgvTopSelling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLowStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCardSales
        '
        Me.pnlCardSales.BorderRadius = 15
        Me.pnlCardSales.Controls.Add(Me.Guna2Panel1)
        Me.pnlCardSales.Controls.Add(Me.Label1)
        Me.pnlCardSales.Controls.Add(Me.lblTodaysSales)
        Me.pnlCardSales.FillColor = System.Drawing.Color.White
        Me.pnlCardSales.Location = New System.Drawing.Point(34, 71)
        Me.pnlCardSales.Name = "pnlCardSales"
        Me.pnlCardSales.ShadowDecoration.Parent = Me.pnlCardSales
        Me.pnlCardSales.Size = New System.Drawing.Size(335, 162)
        Me.pnlCardSales.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(26, 28)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(10, 100)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(59, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Today Sales"
        '
        'lblTodaysSales
        '
        Me.lblTodaysSales.AutoSize = True
        Me.lblTodaysSales.BackColor = System.Drawing.Color.Transparent
        Me.lblTodaysSales.Font = New System.Drawing.Font("Segoe UI", 30.8!, System.Drawing.FontStyle.Bold)
        Me.lblTodaysSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblTodaysSales.Location = New System.Drawing.Point(48, 51)
        Me.lblTodaysSales.Name = "lblTodaysSales"
        Me.lblTodaysSales.Size = New System.Drawing.Size(150, 70)
        Me.lblTodaysSales.TabIndex = 0
        Me.lblTodaysSales.Text = "1000"
        '
        'pnlCardItems
        '
        Me.pnlCardItems.BorderRadius = 15
        Me.pnlCardItems.Controls.Add(Me.Guna2Panel2)
        Me.pnlCardItems.Controls.Add(Me.lblItemsSold)
        Me.pnlCardItems.Controls.Add(Me.Label4)
        Me.pnlCardItems.FillColor = System.Drawing.Color.White
        Me.pnlCardItems.Location = New System.Drawing.Point(392, 71)
        Me.pnlCardItems.Name = "pnlCardItems"
        Me.pnlCardItems.ShadowDecoration.Parent = Me.pnlCardItems
        Me.pnlCardItems.Size = New System.Drawing.Size(304, 162)
        Me.pnlCardItems.TabIndex = 1
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderRadius = 5
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(26, 28)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(10, 100)
        Me.Guna2Panel2.TabIndex = 1
        '
        'lblItemsSold
        '
        Me.lblItemsSold.AutoSize = True
        Me.lblItemsSold.BackColor = System.Drawing.Color.Transparent
        Me.lblItemsSold.Font = New System.Drawing.Font("Segoe UI", 30.8!, System.Drawing.FontStyle.Bold)
        Me.lblItemsSold.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblItemsSold.Location = New System.Drawing.Point(48, 51)
        Me.lblItemsSold.Name = "lblItemsSold"
        Me.lblItemsSold.Size = New System.Drawing.Size(150, 70)
        Me.lblItemsSold.TabIndex = 0
        Me.lblItemsSold.Text = "1000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(59, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Items Sold Today"
        '
        'pnlCardTransactions
        '
        Me.pnlCardTransactions.BorderRadius = 15
        Me.pnlCardTransactions.Controls.Add(Me.Guna2Panel3)
        Me.pnlCardTransactions.Controls.Add(Me.lblTransactions)
        Me.pnlCardTransactions.Controls.Add(Me.Label6)
        Me.pnlCardTransactions.FillColor = System.Drawing.Color.White
        Me.pnlCardTransactions.Location = New System.Drawing.Point(722, 71)
        Me.pnlCardTransactions.Name = "pnlCardTransactions"
        Me.pnlCardTransactions.ShadowDecoration.Parent = Me.pnlCardTransactions
        Me.pnlCardTransactions.Size = New System.Drawing.Size(304, 162)
        Me.pnlCardTransactions.TabIndex = 2
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderRadius = 5
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(26, 28)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(10, 100)
        Me.Guna2Panel3.TabIndex = 1
        '
        'lblTransactions
        '
        Me.lblTransactions.AutoSize = True
        Me.lblTransactions.BackColor = System.Drawing.Color.Transparent
        Me.lblTransactions.Font = New System.Drawing.Font("Segoe UI", 30.8!, System.Drawing.FontStyle.Bold)
        Me.lblTransactions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblTransactions.Location = New System.Drawing.Point(48, 51)
        Me.lblTransactions.Name = "lblTransactions"
        Me.lblTransactions.Size = New System.Drawing.Size(150, 70)
        Me.lblTransactions.TabIndex = 0
        Me.lblTransactions.Text = "1000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(59, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Transactions Today"
        '
        'dgvTopSelling
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvTopSelling.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTopSelling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTopSelling.BackgroundColor = System.Drawing.Color.White
        Me.dgvTopSelling.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTopSelling.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvTopSelling.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTopSelling.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTopSelling.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTopSelling.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTopSelling.EnableHeadersVisualStyles = False
        Me.dgvTopSelling.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTopSelling.Location = New System.Drawing.Point(34, 286)
        Me.dgvTopSelling.Name = "dgvTopSelling"
        Me.dgvTopSelling.RowHeadersVisible = False
        Me.dgvTopSelling.RowTemplate.Height = 24
        Me.dgvTopSelling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTopSelling.Size = New System.Drawing.Size(476, 405)
        Me.dgvTopSelling.TabIndex = 3
        Me.dgvTopSelling.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvTopSelling.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTopSelling.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvTopSelling.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvTopSelling.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvTopSelling.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvTopSelling.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvTopSelling.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTopSelling.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTopSelling.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTopSelling.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvTopSelling.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvTopSelling.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvTopSelling.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvTopSelling.ThemeStyle.ReadOnly = False
        Me.dgvTopSelling.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTopSelling.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvTopSelling.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvTopSelling.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvTopSelling.ThemeStyle.RowsStyle.Height = 24
        Me.dgvTopSelling.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTopSelling.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'dgvLowStock
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvLowStock.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvLowStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLowStock.BackgroundColor = System.Drawing.Color.White
        Me.dgvLowStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLowStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvLowStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLowStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvLowStock.ColumnHeadersHeight = 4
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLowStock.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvLowStock.EnableHeadersVisualStyles = False
        Me.dgvLowStock.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLowStock.Location = New System.Drawing.Point(550, 286)
        Me.dgvLowStock.Name = "dgvLowStock"
        Me.dgvLowStock.RowHeadersVisible = False
        Me.dgvLowStock.RowTemplate.Height = 24
        Me.dgvLowStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLowStock.Size = New System.Drawing.Size(476, 405)
        Me.dgvLowStock.TabIndex = 3
        Me.dgvLowStock.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvLowStock.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvLowStock.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvLowStock.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvLowStock.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvLowStock.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvLowStock.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvLowStock.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLowStock.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLowStock.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvLowStock.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvLowStock.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvLowStock.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvLowStock.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvLowStock.ThemeStyle.ReadOnly = False
        Me.dgvLowStock.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvLowStock.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvLowStock.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvLowStock.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvLowStock.ThemeStyle.RowsStyle.Height = 24
        Me.dgvLowStock.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLowStock.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(30, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Top 5 Selling Items (Today)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(546, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Items with Low Stock"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(26, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 47)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Dashboard"
        '
        'ucDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Controls.Add(Me.dgvLowStock)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvTopSelling)
        Me.Controls.Add(Me.pnlCardTransactions)
        Me.Controls.Add(Me.pnlCardItems)
        Me.Controls.Add(Me.pnlCardSales)
        Me.Name = "ucDashboard"
        Me.Size = New System.Drawing.Size(1081, 725)
        Me.pnlCardSales.ResumeLayout(False)
        Me.pnlCardSales.PerformLayout()
        Me.pnlCardItems.ResumeLayout(False)
        Me.pnlCardItems.PerformLayout()
        Me.pnlCardTransactions.ResumeLayout(False)
        Me.pnlCardTransactions.PerformLayout()
        CType(Me.dgvTopSelling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLowStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlCardSales As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTodaysSales As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlCardItems As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblItemsSold As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pnlCardTransactions As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTransactions As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvTopSelling As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents dgvLowStock As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
