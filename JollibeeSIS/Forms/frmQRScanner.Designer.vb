<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQRScanner
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
        Me.components = New System.ComponentModel.Container()
        Me.picCamera = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnCancelScan = New Guna.UI2.WinForms.Guna2Button()
        Me.scanTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picCamera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCamera
        '
        Me.picCamera.BorderRadius = 15
        Me.picCamera.Location = New System.Drawing.Point(29, 33)
        Me.picCamera.Name = "picCamera"
        Me.picCamera.ShadowDecoration.Parent = Me.picCamera
        Me.picCamera.Size = New System.Drawing.Size(399, 373)
        Me.picCamera.TabIndex = 8
        Me.picCamera.TabStop = False
        '
        'btnCancelScan
        '
        Me.btnCancelScan.BorderRadius = 5
        Me.btnCancelScan.CheckedState.Parent = Me.btnCancelScan
        Me.btnCancelScan.CustomImages.Parent = Me.btnCancelScan
        Me.btnCancelScan.FillColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnCancelScan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancelScan.ForeColor = System.Drawing.Color.White
        Me.btnCancelScan.HoverState.Parent = Me.btnCancelScan
        Me.btnCancelScan.Location = New System.Drawing.Point(29, 430)
        Me.btnCancelScan.Name = "btnCancelScan"
        Me.btnCancelScan.ShadowDecoration.Parent = Me.btnCancelScan
        Me.btnCancelScan.Size = New System.Drawing.Size(399, 45)
        Me.btnCancelScan.TabIndex = 9
        Me.btnCancelScan.Text = "Cancel Scan"
        '
        'scanTimer
        '
        Me.scanTimer.Interval = 500
        '
        'frmQRScanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 514)
        Me.Controls.Add(Me.btnCancelScan)
        Me.Controls.Add(Me.picCamera)
        Me.Name = "frmQRScanner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scan QR Code"
        CType(Me.picCamera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picCamera As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnCancelScan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents scanTimer As System.Windows.Forms.Timer
End Class
