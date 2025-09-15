<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowQR
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
        Me.picQRCode = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picQRCode
        '
        Me.picQRCode.BorderRadius = 5
        Me.picQRCode.Location = New System.Drawing.Point(13, 25)
        Me.picQRCode.Name = "picQRCode"
        Me.picQRCode.ShadowDecoration.Parent = Me.picQRCode
        Me.picQRCode.Size = New System.Drawing.Size(300, 300)
        Me.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQRCode.TabIndex = 0
        Me.picQRCode.TabStop = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblUserName.Location = New System.Drawing.Point(12, 340)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(0, 28)
        Me.lblUserName.TabIndex = 1
        '
        'frmShowQR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 423)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.picQRCode)
        Me.Name = "frmShowQR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "QR Code"
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picQRCode As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
End Class
