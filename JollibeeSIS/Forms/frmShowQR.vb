Imports ZXing

Public Class frmShowQR
    ' Public properties to receive data from the other form
    Public UserName As String
    Public QRCodeData As String

    Private Sub frmShowQR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserName.Text = "QR Code for: " & UserName

        If String.IsNullOrEmpty(QRCodeData) Then
            MessageBox.Show("This user does not have QR Code data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        ' --- Generate the QR Code ---
        Dim writer As New BarcodeWriter()
        writer.Format = BarcodeFormat.QR_CODE
        writer.Options.Width = 300
        writer.Options.Height = 300
        ' Encode the data and display it in the picture box
        picQRCode.Image = writer.Write(QRCodeData)
    End Sub
End Class