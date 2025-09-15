Namespace My
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            ' Call our DPI awareness function before anything else happens.
            DpiAwareness.Enable()
        End Sub
    End Class
End Namespace