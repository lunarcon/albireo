Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Runtime.InteropServices

Namespace DWIn
    Module DesktopWindowsStuff
        <DllImport("user32.dll")>
        Private Function IsWindowVisible(ByVal hWnd As IntPtr) As Boolean
        End Function
        <DllImport("user32.dll", EntryPoint:="GetWindowText", ExactSpelling:=False, CharSet:=CharSet.Auto, SetLastError:=True)>
        Private Function GetWindowText(ByVal hWnd As IntPtr, ByVal lpWindowText As StringBuilder, ByVal nMaxCount As Integer) As Integer
        End Function
        <DllImport("user32.dll", EntryPoint:="EnumDesktopWindows", ExactSpelling:=False, CharSet:=CharSet.Auto, SetLastError:=True)>
        Private Function EnumDesktopWindows(ByVal hDesktop As IntPtr, ByVal lpEnumCallbackFunction As EnumDelegate, ByVal lParam As IntPtr) As Boolean
        End Function
        Private Delegate Function EnumDelegate(ByVal hWnd As IntPtr, ByVal lParam As Integer) As Boolean
        Private WindowHandles As List(Of IntPtr)
        Private WindowTitles As List(Of String)

        Sub GetDesktopWindowHandlesAndTitles(<Out> ByRef [handles] As List(Of IntPtr), <Out> ByRef titles As List(Of String))
            WindowHandles = New List(Of IntPtr)()
            WindowTitles = New List(Of String)()

            If Not EnumDesktopWindows(IntPtr.Zero, AddressOf FilterCallback, IntPtr.Zero) Then
                [handles] = Nothing
                titles = Nothing
            Else
                [handles] = WindowHandles
                titles = WindowTitles
            End If
        End Sub

        Private Function FilterCallback(ByVal hWnd As IntPtr, ByVal lParam As Integer) As Boolean
            Dim sb_title As StringBuilder = New StringBuilder(1024)
            Dim length As Integer = GetWindowText(hWnd, sb_title, sb_title.Capacity)
            Dim title As String = sb_title.ToString()

            If IsWindowVisible(hWnd) AndAlso String.IsNullOrEmpty(title) = False Then
                WindowHandles.Add(hWnd)
                WindowTitles.Add(title)
            End If

            Return True
        End Function
    End Module
End Namespace
