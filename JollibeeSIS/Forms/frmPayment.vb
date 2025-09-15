' --- Add this import at the top of your file ---
Imports System.Globalization

Public Class frmPayment
    ' Public property to receive the total from the POS screen
    Public TotalAmount As Decimal

    ' --- Define the Philippine culture info once for the whole form ---
    Private ReadOnly PH_CULTURE As New CultureInfo("en-PH")

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' --- FIX: Use the Philippine culture to format the currency ---
        lblTotalDue.Text = TotalAmount.ToString("C", PH_CULTURE)
        lblChange.Text = (0D).ToString("C", PH_CULTURE) ' Display ₱0.00 correctly
        txtCashReceived.Focus()
    End Sub

    Private Sub txtCashReceived_TextChanged(sender As Object, e As EventArgs) Handles txtCashReceived.TextChanged
        Dim cashReceived As Decimal
        If Decimal.TryParse(txtCashReceived.Text, cashReceived) Then
            Dim change As Decimal = cashReceived - TotalAmount
            ' --- FIX: Use the Philippine culture to format the currency ---
            lblChange.Text = change.ToString("C", PH_CULTURE)
        Else
            lblChange.Text = "Invalid Input"
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim cashReceived As Decimal
        If Not Decimal.TryParse(txtCashReceived.Text, cashReceived) Then
            MessageBox.Show("Please enter a valid cash amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cashReceived < TotalAmount Then
            MessageBox.Show("Cash received is less than the total amount due.", "Insufficient Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Payment is valid, set DialogResult to OK and close
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class