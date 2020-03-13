Imports System.IO
Imports Microsoft.Win32

Public Class explorer_shell
    Dim dpath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\"
    Private Sub Explorer_shell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        taskbar.Show()
        taskbar.Location = New Point(0, Screen.PrimaryScreen.WorkingArea.Height)
        SendToBack()

        taskbar.BringToFront()
        Populate(dpath, AppList)
        BackgroundImage = Image.FromFile(GetCurrentWallpaper())
        Dim taskkill As New ProcessStartInfo
        taskkill.FileName = "cmd.exe"
        taskkill.Arguments = "/c taskkill /F /IM explorer.exe"
        taskkill.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(taskkill)
        AppList.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height)
    End Sub
    Public Function GetCurrentWallpaper() As String
        Dim rkWallPaper As RegistryKey = Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", False)
        Dim WallpaperPath As String = rkWallPaper.GetValue("WallPaper").ToString()
        rkWallPaper.Close()
        Return WallpaperPath
    End Function

    Private Sub Exitsh()
        Dim explorer As String = String.Format("{0}\{1}", Environment.GetEnvironmentVariable("WINDIR"), "explorer.exe")
        Dim process As Process = New Process()
        process.StartInfo.FileName = explorer
        process.StartInfo.UseShellExecute = True
        process.Start()
        Close()
        End
    End Sub

    Private Sub explorer_shell_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        SendToBack()
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

    Private Sub Populate(Fpsth As String, pnl As FlowLayoutPanel)
        For Each file As String In Directory.GetDirectories(Fpsth)
            Dim appx As New filebtn
            Dim appicon = AddIcon(file, 1)
            Dim appname = Path.GetFileNameWithoutExtension(file)
            appx.Text = appname
            Try
                appx.Button1.Text = appname.Substring(1, 20)
            Catch
                appx.Button1.Text = appname
            End Try
            appx.Button1.Image = appicon
            Rescale(0.7, appx.Button1.Image, appx)
            appx.Tag = file
            appx.Button1.FlatStyle = FlatStyle.Flat
            appx.Button1.FlatAppearance.BorderSize = 0
            appx.Button1.FlatAppearance.BorderColor = Color.Gray
            appx.Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 100, 100, 100)
            appx.Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200, 210)
            appx.Button1.TextAlign = ContentAlignment.BottomCenter
            appx.Button1.ForeColor = Color.White
            appx.Size = New Size(85, 95)
            pnl.Controls.Add(appx)
        Next
        For Each file As String In Directory.GetFiles(Fpsth)
            Dim appx As New filebtn
            Dim appicon = AddIcon(file, 1)
            Dim appname = Path.GetFileNameWithoutExtension(file)
            appx.Text = appname
            Try
                appx.Button1.Text = appname.Substring(1, 20)
            Catch
                appx.Button1.Text = appname
            End Try
            appx.Button1.Image = appicon
            Rescale(0.7, appx.Button1.Image, appx)
            appx.Tag = file
            appx.Button1.FlatStyle = FlatStyle.Flat
            appx.Button1.FlatAppearance.BorderSize = 0
            appx.Button1.FlatAppearance.BorderColor = Color.Gray
            appx.Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 100, 100, 100)
            appx.Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200, 210)
            appx.Button1.TextAlign = ContentAlignment.BottomCenter
            appx.Button1.ForeColor = Color.White
            appx.Size = New Size(85, 95)
            pnl.Controls.Add(appx)
        Next
    End Sub

    Private Sub Rescale(scale_factor As Single, bm_source As Bitmap, source As filebtn)
        Dim bm_dest As New Bitmap(
        CInt(bm_source.Width * scale_factor),
        CInt(bm_source.Height * scale_factor))
        Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)
        gr_dest.DrawImage(bm_source, 0, 0,
        bm_dest.Width + 1,
        bm_dest.Height + 1)
        source.Button1.Image = bm_dest
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Exitsh()
    End Sub

    Private Sub AppList_Paint(sender As Object, e As PaintEventArgs) Handles AppList.Paint

    End Sub

    Private Sub AppList_Click(sender As Object, e As EventArgs) Handles AppList.Click
        sender.focus
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class