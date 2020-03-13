Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System
Imports System.Text

Public Class user32
    Public Delegate Function EnumDelegate(ByVal hWnd As IntPtr, ByVal lParam As Integer) As Boolean
    <DllImport("user32.dll")>
    Public Shared Function IsWindowVisible(ByVal hWnd As IntPtr) As Boolean
    End Function
    <DllImport("user32.dll", EntryPoint:="GetWindowText", ExactSpelling:=False, CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function GetWindowText(ByVal hWnd As IntPtr, ByVal lpWindowText As StringBuilder, ByVal nMaxCount As Integer) As Integer
    End Function
    <DllImport("user32.dll", EntryPoint:="EnumDesktopWindows", ExactSpelling:=False, CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function EnumDesktopWindows(ByVal hDesktop As IntPtr, ByVal lpEnumCallbackFunction As EnumDelegate, ByVal lParam As IntPtr) As Boolean
    End Function

    Private Shared Sub Main()
        Dim collection = New List(Of String)()
        Dim filter As user32.EnumDelegate = Function(ByVal hWnd As IntPtr, ByVal lParam As Integer)
                                                Dim strbTitle As StringBuilder = New StringBuilder(255)
                                                Dim nLength As Integer = user32.GetWindowText(hWnd, strbTitle, strbTitle.Capacity + 1)
                                                Dim strTitle As String = strbTitle.ToString()

                                                If user32.IsWindowVisible(hWnd) AndAlso String.IsNullOrEmpty(strTitle) = False Then
                                                    collection.Add(strTitle)
                                                End If

                                                Return True
                                            End Function

        If user32.EnumDesktopWindows(IntPtr.Zero, filter, IntPtr.Zero) Then

            For Each item In collection
                Console.WriteLine(item)
            Next
        End If

    End Sub
End Class
