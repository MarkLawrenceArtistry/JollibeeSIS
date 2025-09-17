<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlSidebar = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUsers = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReports = New Guna.UI2.WinForms.Guna2Button()
        Me.btnIngredients = New Guna.UI2.WinForms.Guna2Button()
        Me.btnInventory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPOS = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlContent = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.Controls.Add(Me.Label3)
        Me.pnlSidebar.Controls.Add(Me.Label2)
        Me.pnlSidebar.Controls.Add(Me.Label1)
        Me.pnlSidebar.Controls.Add(Me.Guna2PictureBox1)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnUsers)
        Me.pnlSidebar.Controls.Add(Me.btnReports)
        Me.pnlSidebar.Controls.Add(Me.btnIngredients)
        Me.pnlSidebar.Controls.Add(Me.btnInventory)
        Me.pnlSidebar.Controls.Add(Me.btnPOS)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.FillColor = System.Drawing.Color.White
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.ShadowDecoration.Parent = Me.pnlSidebar
        Me.pnlSidebar.Size = New System.Drawing.Size(213, 804)
        Me.pnlSidebar.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 455)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Management"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Menu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Overview"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(3, 28)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(208, 75)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BorderColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnLogout.BorderRadius = 5
        Me.btnLogout.BorderThickness = 1
        Me.btnLogout.CheckedState.Parent = Me.btnLogout
        Me.btnLogout.CustomImages.Parent = Me.btnLogout
        Me.btnLogout.FillColor = System.Drawing.Color.White
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnLogout.HoverState.Parent = Me.btnLogout
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.Location = New System.Drawing.Point(13, 716)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.ShadowDecoration.Parent = Me.btnLogout
        Me.btnLogout.Size = New System.Drawing.Size(188, 45)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnUsers
        '
        Me.btnUsers.BorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnUsers.BorderRadius = 5
        Me.btnUsers.BorderThickness = 1
        Me.btnUsers.CheckedState.Parent = Me.btnUsers
        Me.btnUsers.CustomImages.Parent = Me.btnUsers
        Me.btnUsers.FillColor = System.Drawing.Color.White
        Me.btnUsers.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnUsers.HoverState.Parent = Me.btnUsers
        Me.btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), System.Drawing.Image)
        Me.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUsers.Location = New System.Drawing.Point(13, 475)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.PressedColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnUsers.ShadowDecoration.Parent = Me.btnUsers
        Me.btnUsers.Size = New System.Drawing.Size(188, 45)
        Me.btnUsers.TabIndex = 1
        Me.btnUsers.Text = "Users"
        Me.btnUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnReports
        '
        Me.btnReports.BorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnReports.BorderRadius = 5
        Me.btnReports.BorderThickness = 1
        Me.btnReports.CheckedState.Parent = Me.btnReports
        Me.btnReports.CustomImages.Parent = Me.btnReports
        Me.btnReports.FillColor = System.Drawing.Color.White
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnReports.HoverState.Parent = Me.btnReports
        Me.btnReports.Image = CType(resources.GetObject("btnReports.Image"), System.Drawing.Image)
        Me.btnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReports.Location = New System.Drawing.Point(13, 206)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.PressedColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnReports.ShadowDecoration.Parent = Me.btnReports
        Me.btnReports.Size = New System.Drawing.Size(188, 45)
        Me.btnReports.TabIndex = 1
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnIngredients
        '
        Me.btnIngredients.BorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnIngredients.BorderRadius = 5
        Me.btnIngredients.BorderThickness = 1
        Me.btnIngredients.CheckedState.Parent = Me.btnIngredients
        Me.btnIngredients.CustomImages.Parent = Me.btnIngredients
        Me.btnIngredients.FillColor = System.Drawing.Color.White
        Me.btnIngredients.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnIngredients.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnIngredients.HoverState.Parent = Me.btnIngredients
        Me.btnIngredients.Image = CType(resources.GetObject("btnIngredients.Image"), System.Drawing.Image)
        Me.btnIngredients.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnIngredients.Location = New System.Drawing.Point(13, 392)
        Me.btnIngredients.Name = "btnIngredients"
        Me.btnIngredients.PressedColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnIngredients.ShadowDecoration.Parent = Me.btnIngredients
        Me.btnIngredients.Size = New System.Drawing.Size(188, 45)
        Me.btnIngredients.TabIndex = 1
        Me.btnIngredients.Text = "Ingredients"
        Me.btnIngredients.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnInventory
        '
        Me.btnInventory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnInventory.BorderRadius = 5
        Me.btnInventory.BorderThickness = 1
        Me.btnInventory.CheckedState.Parent = Me.btnInventory
        Me.btnInventory.CustomImages.Parent = Me.btnInventory
        Me.btnInventory.FillColor = System.Drawing.Color.White
        Me.btnInventory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnInventory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnInventory.HoverState.Parent = Me.btnInventory
        Me.btnInventory.Image = CType(resources.GetObject("btnInventory.Image"), System.Drawing.Image)
        Me.btnInventory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnInventory.Location = New System.Drawing.Point(13, 341)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.PressedColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnInventory.ShadowDecoration.Parent = Me.btnInventory
        Me.btnInventory.Size = New System.Drawing.Size(188, 45)
        Me.btnInventory.TabIndex = 1
        Me.btnInventory.Text = "Products"
        Me.btnInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnPOS
        '
        Me.btnPOS.BorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnPOS.BorderRadius = 5
        Me.btnPOS.BorderThickness = 1
        Me.btnPOS.CheckedState.Parent = Me.btnPOS
        Me.btnPOS.CustomImages.Parent = Me.btnPOS
        Me.btnPOS.FillColor = System.Drawing.Color.White
        Me.btnPOS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPOS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnPOS.HoverState.Parent = Me.btnPOS
        Me.btnPOS.Image = CType(resources.GetObject("btnPOS.Image"), System.Drawing.Image)
        Me.btnPOS.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnPOS.Location = New System.Drawing.Point(13, 290)
        Me.btnPOS.Name = "btnPOS"
        Me.btnPOS.PressedColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnPOS.ShadowDecoration.Parent = Me.btnPOS
        Me.btnPOS.Size = New System.Drawing.Size(188, 45)
        Me.btnPOS.TabIndex = 1
        Me.btnPOS.Text = "POS"
        Me.btnPOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnDashboard
        '
        Me.btnDashboard.BorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnDashboard.BorderRadius = 5
        Me.btnDashboard.BorderThickness = 1
        Me.btnDashboard.CheckedState.Parent = Me.btnDashboard
        Me.btnDashboard.CustomImages.Parent = Me.btnDashboard
        Me.btnDashboard.FillColor = System.Drawing.Color.White
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnDashboard.HoverState.Parent = Me.btnDashboard
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.Location = New System.Drawing.Point(13, 155)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.PressedColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnDashboard.ShadowDecoration.Parent = Me.btnDashboard
        Me.btnDashboard.Size = New System.Drawing.Size(188, 45)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pnlContent
        '
        Me.pnlContent.FillColor = System.Drawing.Color.White
        Me.pnlContent.Location = New System.Drawing.Point(220, 79)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.ShadowDecoration.Parent = Me.pnlContent
        Me.pnlContent.Size = New System.Drawing.Size(1081, 725)
        Me.pnlContent.TabIndex = 1
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.lblWelcome)
        Me.pnlHeader.FillColor = System.Drawing.Color.White
        Me.pnlHeader.Location = New System.Drawing.Point(220, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.ShadowDecoration.Parent = Me.pnlHeader
        Me.pnlHeader.Size = New System.Drawing.Size(1081, 73)
        Me.pnlHeader.TabIndex = 2
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(15, 15)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(393, 38)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome, [User's Full Name]"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1301, 803)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSidebar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlContent As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUsers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReports As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnInventory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPOS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnIngredients As Guna.UI2.WinForms.Guna2Button
End Class
