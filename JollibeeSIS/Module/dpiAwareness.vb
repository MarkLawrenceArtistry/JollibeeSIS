Imports System.Runtime.InteropServices
Module DpiAwareness
    <DllImport("user32.dll")>
    Private Function SetProcessDPIAware() As Boolean
    End Function

    Public Sub Enable()
        SetProcessDPIAware()
    End Sub
End Module