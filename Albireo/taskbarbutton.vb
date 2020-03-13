Imports System.Runtime.InteropServices

Public Class taskbarbutton
    'Declare Auto Function FindWindow Lib "User32.dll" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr

    'Declare Auto Function ForeGroundWindow Lib "User32.dll" (ByVal Hwnd As IntPtr) As Long

    Public hwnd As Integer = Tag
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hwnd = Tag
        AppActivate(sender.tag)
        minWindow()
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover

    End Sub
    <DllImport("user32.dll")>
    Private Shared Function GetWindowPlacement(ByVal hWnd As IntPtr, ByRef lpwndpl As WINDOWPLACEMENT) As Boolean

    End Function
    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr

    End Function
    <DllImport("user32.dll")>
    Private Shared Function SetWindowPlacement(ByVal hWnd As IntPtr, ByRef lpwndpl As WINDOWPLACEMENT) As Boolean

    End Function

    Private Structure POINTAPI
        Public x As Integer
        Public y As Integer
    End Structure

    Private Structure RECT
        Public left As Integer
        Public top As Integer
        Public right As Integer
        Public bottom As Integer
    End Structure

    Private Structure WINDOWPLACEMENT
        Public length As Integer
        Public flags As Integer
        Public showCmd As Integer
        Public ptMinPosition As POINTAPI
        Public ptMaxPosition As POINTAPI
        Public rcNormalPosition As RECT
    End Structure

    Private Sub WindowAction(ByVal className As String)
        Dim app_hwnd As System.IntPtr
        Dim wp As WINDOWPLACEMENT = New WINDOWPLACEMENT()
        app_hwnd = FindWindow(className, Nothing)
        GetWindowPlacement(app_hwnd, wp)
        wp.showCmd = 1
        SetWindowPlacement(app_hwnd, wp)
    End Sub
    Private Sub minWindow()
        Dim processes As Process() = Process.GetProcessesByName(Name)
        For Each p As Process In processes
            Dim app_hwnd As System.IntPtr
            Dim wp As WINDOWPLACEMENT = New WINDOWPLACEMENT()
            app_hwnd = p.MainWindowHandle
            GetWindowPlacement(app_hwnd, wp)
            wp.showCmd = 1
            SetWindowPlacement(app_hwnd, wp)
        Next
    End Sub
End Class
