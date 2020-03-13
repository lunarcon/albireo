
Imports System.ComponentModel
Imports System.IO

Public Class taskbar

    Private Sub Taskbar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Width = Screen.PrimaryScreen.WorkingArea.Width
        loadprocesses()
        Timer1.Start()
    End Sub

    Private Sub loadprocesses()
        Dim processlist = Process.GetProcesses
        Dim idx As Integer = 0

        For Each c As Control In AppsPanel.Controls
            Dim cont As Boolean = False
            For Each process In processlist
                If Not String.IsNullOrEmpty(process.MainWindowTitle) Then
                    If process.Id = Val(c.Tag) Then
                        cont = True
                    End If
                End If
            Next
            If cont = False Then
                AppsPanel.Controls.Remove(c)
            End If
        Next
        For Each process In processlist
            If Not String.IsNullOrEmpty(process.MainWindowTitle) Then
                Try
                    Dim appicon = GetWindowIcon(process.MainWindowHandle)
                    Dim btx As New taskbarbutton
                    btx.Button1.FlatStyle = FlatStyle.Flat

                    btx.Size = New Size(50, 42)
                    btx.Name = process.ProcessName
                    btx.Tag = process.Id
                    btx.Button1.Tag = process.MainWindowTitle.ToString
                    btx.Dock = DockStyle.Left
                    btx.Button1.Image = appicon
                    btx.Margin = New Padding(10, 0, 0, 0)
                    Dim contains = False
                    For Each c As Control In AppsPanel.Controls
                        If c.Tag = btx.Tag Then
                            contains = True
                        End If
                    Next
                    If contains = False Then
                        AppsPanel.Controls.Add(btx)
                    End If
                    idx += 1
                Catch
                End Try
            End If
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        loadprocesses()
    End Sub

    Public Function GetWindowIcon(ByVal windowHandle As IntPtr) As Image
        Try
            Dim hIcon As IntPtr = Nothing
            hIcon = NativeMethods.SendMessage(windowHandle, NativeMethods.WM_GETICON, NativeMethods.SHGFI_LARGEICON, IntPtr.Zero)
            If hIcon = IntPtr.Zero Then hIcon = GetClassLongPtr(windowHandle, NativeMethods.GCL_HICON)
            If hIcon = IntPtr.Zero Then hIcon = NativeMethods.LoadIcon(IntPtr.Zero, CType(&H7F00, IntPtr))
            If hIcon <> IntPtr.Zero Then
                Return New Bitmap(Icon.FromHandle(hIcon).ToBitmap(), 20, 20)
            Else
                Return Nothing
            End If

        Catch ola_amigo_si_dora As Exception
            Return Nothing
        End Try
    End Function

    Private Function GetClassLongPtr(ByVal windowHandle As IntPtr, ByVal nIndex As Integer) As IntPtr
        If IntPtr.Size = 4 Then
            Return New IntPtr(CLng(NativeMethods.GetClassLongPtr32(windowHandle, nIndex)))
        Else
            Return NativeMethods.GetClassLongPtr64(windowHandle, nIndex)
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Start_Menu.Show()
    End Sub
End Class
