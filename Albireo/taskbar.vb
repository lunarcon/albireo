
Imports System.ComponentModel

Public Class taskbar
    Dim olst
    Private Sub Taskbar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadprocesses()
        Timer1.Start()
    End Sub

    Private Sub loadprocesses()
        For Each x As Control In Controls
            Controls.Remove(x)
            x.Dispose()
        Next
        Dim processlist = Process.GetProcesses
        Dim idx As Integer = 0
        For Each process In processlist
            If Not String.IsNullOrEmpty(process.MainWindowTitle) Then
                Dim file As String
                Try
                    file = process.Modules(0).FileName
                    Dim appicon = AddIcon(file, 2)
                    Dim btx As New taskbarbutton
                    btx.Button1.FlatStyle = FlatStyle.Flat
                    btx.Size = New Size(50, 42)
                    btx.Name = process.ProcessName
                    btx.Tag = process.Id
                    btx.Dock = DockStyle.Left
                    btx.Button1.Image = appicon
                    btx.Button1.Tag = file
                    btx.Margin = New Padding(10, 0, 0, 0)
                    Controls.Add(btx)
                    idx += 1
                Catch ex As Win32Exception
                    file = ""
                End Try
            End If
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim lst = Process.GetProcesses
        If Not lst.Contains(olst) Then
            loadprocesses()
        End If
    End Sub

    Private Function AddIcon(fname As String, mode As Integer)
        Dim size
        If mode = 1 Then
            size = CType(ExtractLargeIconFromFile.ShellEx.IconSizeEnum.LargeIcon48, ExtractLargeIconFromFile.ShellEx.IconSizeEnum)
        ElseIf mode = 2 Then
            size = CType(ExtractLargeIconFromFile.ShellEx.IconSizeEnum.MediumIcon32, ExtractLargeIconFromFile.ShellEx.IconSizeEnum)
        End If
#Disable Warning BC42104
        Return ExtractLargeIconFromFile.ShellEx.GetBitmapFromFilePath(fname, size)
#Enable Warning BC42104
    End Function
End Class
