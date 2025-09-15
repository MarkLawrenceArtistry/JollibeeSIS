<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.txtCashReceived = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.btnConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.lblTotalDue.Location = New System.Drawing.Point(17, 38)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(0, 46)
        Me.lblTotalDue.TabIndex = 0
        '
        'txtCashReceived
        '
        Me.txtCashReceived.BorderRadius = 5
        Me.txtCashReceived.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCashReceived.DefaultText = ""
        Me.txtCashReceived.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCashReceived.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCashReceived.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCashReceived.DisabledState.Parent = Me.txtCashReceived
        Me.txtCashReceived.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCashReceived.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCashReceived.FocusedState.Parent = Me.txtCashReceived
        Me.txtCashReceived.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCashReceived.HoverState.Parent = Me.txtCashReceived
        Me.txtCashReceived.Location = New System.Drawing.Point(25, 92)
        Me.txtCashReceived.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCashReceived.Name = "txtCashReceived"
        Me.txtCashReceived.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCashReceived.PlaceholderText = "Place Amount..."
        Me.txtCashReceived.SelectedText = ""
        Me.txtCashReceived.ShadowDecoration.Parent = Me.txtCashReceived
        Me.txtCashReceived.Size = New System.Drawing.Size(398, 54)
        Me.txtCashReceived.TabIndex = 1
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.lblChange.Location = New System.Drawing.Point(17, 173)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(0, 46)
        Me.lblChange.TabIndex = 0
        '
        'btnConfirm
        '
        Me.btnConfirm.BorderRadius = 15
        Me.btnConfirm.CheckedState.Parent = Me.btnConfirm
        Me.btnConfirm.CustomImages.Parent = Me.btnConfirm
        Me.btnConfirm.FillColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.HoverState.Parent = Me.btnConfirm
        Me.btnConfirm.Location = New System.Drawing.Point(25, 233)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.ShadowDecoration.Parent = Me.btnConfirm
        Me.btnConfirm.Size = New System.Drawing.Size(398, 125)
        Me.btnConfirm.TabIndex = 2
        Me.btnConfirm.Text = "Confirm"
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 10
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(25, 375)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(398, 45)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Due"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Change"
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(448, 445)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtCashReceived)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotalDue As System.Windows.Forms.Label
    Friend WithEvents txtCashReceived As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
