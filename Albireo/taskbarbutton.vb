Public Class taskbarbutton
    Declare Function SetForegroundWindow Lib "user32.dll" (ByVal hwnd As Integer) As Integer
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function ShowWindow(ByVal hWnd As IntPtr, ByVal flags As ShowWindowEnum) As Boolean
    End Function
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function SetForegroundWindow(ByVal hwnd As IntPtr) As Integer
    End Function
    Private Enum ShowWindowEnum
        Hide = 0
        ShowNormal = 1
        ShowMinimized = 2
        ShowMaximized = 3
        Maximize = 3
        ShowNormalNoActivate = 4
        Show = 5
        Minimize = 6
        ShowMinNoActivate = 7
        ShowNoActivate = 8
        Restore = 9
        ShowDefault = 10
        ForceMinimized = 11
    End Enum

    Public Sub BringMainWindowToFront(ByVal processName As Integer)
        Dim bProcess As Process = Process.GetProcessById(processName)

        If bProcess IsNot Nothing Then

            If bProcess.MainWindowHandle = IntPtr.Zero Then
                ShowWindow(bProcess.Handle, ShowWindowEnum.ShowMaximized)
            End If

            SetForegroundWindow(bProcess.MainWindowHandle)
        Else
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        BringMainWindowToFront(Val(Tag))
    End Sub
End Class
