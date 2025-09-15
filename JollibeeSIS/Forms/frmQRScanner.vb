Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing

Public Class frmQRScanner

    ' This public property will hold the result to send back to the login form
    Public ScannedData As String = ""

    ' AForge.NET variables to manage the webcam feed
    Private videoDevices As FilterInfoCollection
    Private videoSource As VideoCaptureDevice

    Private Sub frmQRScanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If videoDevices.Count = 0 Then
            MessageBox.Show("No webcam found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Cancel ' Set result to cancel
            Me.Close() ' Close the form if no camera
            Return
        End If

        ' Start the camera feed automatically when the form loads
        videoSource = New VideoCaptureDevice(videoDevices(0).MonikerString)
        AddHandler videoSource.NewFrame, AddressOf videoSource_NewFrame
        videoSource.Start()
        scanTimer.Start()
    End Sub

    Private Sub videoSource_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        ' Use Invoke to safely update the UI from the camera's thread
        If Me.IsDisposed OrElse Not Me.IsHandleCreated Then Return
        Try
            Me.Invoke(New MethodInvoker(Sub()
                                            If picCamera IsNot Nothing Then
                                                picCamera.Image = CType(eventArgs.Frame.Clone(), Bitmap)
                                            End If
                                        End Sub))
        Catch ex As Exception
            ' Ignore exceptions that can occur during form closing
        End Try
    End Sub

    Private Sub scanTimer_Tick(sender As Object, e As EventArgs) Handles scanTimer.Tick
        If picCamera.Image Is Nothing Then Return

        Try
            Dim reader As New BarcodeReader()
            Dim result As Result = reader.Decode(CType(picCamera.Image, Bitmap))

            If result IsNot Nothing Then
                ' --- QR CODE FOUND! ---
                scanTimer.Stop()

                ' Set the public property with the result
                Me.ScannedData = result.Text

                ' Set the DialogResult to OK to signal success
                Me.DialogResult = DialogResult.OK

                ' The form will now close automatically because its DialogResult is set
            End If
        Catch ex As Exception
            ' Ignore decode errors
        End Try
    End Sub

    ' --- Resource Cleanup ---
    Private Sub StopCamera()
        scanTimer.Stop()
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
            RemoveHandler videoSource.NewFrame, AddressOf videoSource_NewFrame
            videoSource = Nothing
        End If
        If picCamera.Image IsNot Nothing Then
            picCamera.Image.Dispose()
            picCamera.Image = Nothing
        End If
    End Sub

    Private Sub frmQRScanner_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        StopCamera()
    End Sub

    Private Sub btnCancelScan_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelScan.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class