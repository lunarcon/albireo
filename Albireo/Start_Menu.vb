Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Runtime.InteropServices
Imports IWshRuntimeLibrary
Imports Microsoft.Win32
Imports System.Collections.ObjectModel

Imports System.Text
Imports Microsoft.WindowsAPICodePack.Shell
Imports System.Windows.Media.Imaging

Public Class Start
    Dim pinnedapps As String = CStr("C:\Users\" & GetUserName() & "\AppData\Roaming\Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar\")
    Dim libraries As String = CStr("C:\Users\" & GetUserName() & "\")
    Dim recent As String = CStr("C:\Users\" & GetUserName() & "\AppData\Roaming\Microsoft\Windows\Recent\")
    Dim allapps As String = CStr("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\")
    Dim objShell = CreateObject("Shell.Application")

    Declare Function GetUserName Lib "advapi32.dll" Alias _
       "GetUserNameA" (ByVal lpBuffer As String,
       ByRef nSize As Integer) As Integer
    Public colorSystemAccent As UInteger = GetImmersiveColorFromColorSetEx(GetImmersiveUserColorSetPreference(False, False), GetImmersiveColorTypeFromName(Marshal.StringToHGlobalUni("ImmersiveSystemAccent")), False, 0)
    Public colorAccent As System.Drawing.Color = System.Drawing.Color.FromArgb((&HFF000000 And colorSystemAccent) >> 24, &HFF And colorSystemAccent, (&HFF00 And colorSystemAccent) >> 8, (&HFF0000 And colorSystemAccent) >> 16)

    <DllImport("Uxtheme.dll", SetLastError:=True, CharSet:=CharSet.Auto, EntryPoint:="#95")>
    Public Shared Function GetImmersiveColorFromColorSetEx(ByVal dwImmersiveColorSet As UInteger, ByVal dwImmersiveColorType As UInteger, ByVal bIgnoreHighContrast As Boolean, ByVal dwHighContrastCacheMode As UInteger) As UInteger
    End Function
    <DllImport("Uxtheme.dll", SetLastError:=True, CharSet:=CharSet.Auto, EntryPoint:="#96")>
    Public Shared Function GetImmersiveColorTypeFromName(ByVal pName As IntPtr) As UInteger
    End Function
    <DllImport("Uxtheme.dll", SetLastError:=True, CharSet:=CharSet.Auto, EntryPoint:="#98")>
    Public Shared Function GetImmersiveUserColorSetPreference(ByVal bForceCheckRegistry As Boolean, ByVal bSkipCheckOnFail As Boolean) As UInteger
    End Function
    Public Function GetUserName() As String
        Dim iReturn As Integer
        Dim userName As String
        userName = New String(CChar(" "), 50)
        iReturn = GetUserName(userName, 50)
        GetUserName = userName.Substring(0, userName.IndexOf(Chr(0)))
    End Function
    Private Sub roundthethingy(oj As Object, rad As Integer)
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, rad, rad), 180, 90)
        p.AddLine(rad, 0, oj.Width - rad, 0)
        p.AddArc(New Rectangle(oj.Width - rad, 0, rad, rad), -90, 90)
        p.AddLine(oj.Width, rad, oj.Width, oj.Height - rad)
        p.AddArc(New Rectangle(oj.Width - rad, oj.Height - rad, rad, rad), 0, 90)
        p.AddLine(oj.Width - rad, oj.Height, rad, oj.Height)
        p.AddArc(New Rectangle(0, oj.Height - rad, rad, rad), 90, 90)
        p.CloseFigure()
        oj.Region = New Region(p)
    End Sub
    Private Sub StartMenu_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        If Timer2.Enabled = False And Opacity > 0.88 Then
            Timer3.Enabled = True
            Timer3.Start()
        End If
    End Sub
    Private Sub Content_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Enabled = True
        Backfrm.Show()
        Backfrm.Size = Size
        BringToFront()
        Timer2.Start()
        lbl1.LinkColor = colorAccent
        lbl2.LinkColor = colorAccent
        roundthethingy(Me, 20)
        Populate(pinnedapps, AppList)
        Populate(libraries, Libs)
        Populate(recent, Recents)
        SurroundingSub()
    End Sub

    Private Sub Rescale(scale_factor As Single, bm_source As Bitmap, source As AppTile)

        Dim bm_dest As New Bitmap(
        CInt(bm_source.Width * scale_factor),
        CInt(bm_source.Height * scale_factor))
        Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)

        gr_dest.DrawImage(bm_source, 0, 0,
        bm_dest.Width + 1,
        bm_dest.Height + 1)

        source.Det.Image = bm_dest
    End Sub

    Private Sub Rescale001(scale_factor As Single, bm_source As Bitmap, source As ActivityTile)

        Dim bm_dest As New Bitmap(
        CInt(bm_source.Width * scale_factor),
        CInt(bm_source.Height * scale_factor))
        Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)

        gr_dest.DrawImage(bm_source, 0, 0,
        bm_dest.Width + 1,
        bm_dest.Height + 1)
        source.ActivityIcon.BackgroundImage = bm_dest
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Opacity += 0.08
        Backfrm.Opacity += 0.08
        If Opacity >= 0.9 Then
            Timer2.Stop()
            'Timer3.Enabled = True
            'Timer3.Start()
            Timer2.Enabled = False
            Opacity = 0.93
            Backfrm.Opacity = 1
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer2.Enabled = False
        Timer2.Stop()
        Opacity -= 0.085
        Backfrm.Opacity -= 0.08
        If Opacity <= 0.1 Then
            Timer3.Enabled = False
            Timer3.Stop()
            Close()
            End
        End If
    End Sub
    Private Sub Populate(Fpsth As String, pnl As FlowLayoutPanel)
        If Not Fpsth Is Nothing AndAlso Directory.Exists(Fpsth) Then

            Try
                If pnl.Name = AppList.Name Then
                    If lbl1.Text <> "All Apps" Then
                        For Each file As String In Directory.GetFiles(Fpsth)
                            If Path.GetFileName(file).Contains(".ini") = False Then
                                Dim appx As New AppTile
                                Dim appicon = AddIcon(file, 1)
                                appx.Det.BackColor = pnl.BackColor
                                Dim appname = Path.GetFileNameWithoutExtension(file)
                                appx.Det.Text = appname
                                appx.Det.Image = appicon
                                Rescale(0.7, appx.Det.Image, appx)
                                appx.Tag = file
                                'appx.BackColor = colorAccent
                                pnl.Controls.Add(appx)
                            End If
                        Next
                    Else
                        For Each file As String In Directory.GetFiles(Fpsth)
                            If Path.GetFileName(file).Contains(".ini") = False Then
                                Dim appx As New AppTile
                                Dim appicon = AddIcon(file, 1)
                                appx.Det.BackColor = pnl.BackColor
                                Dim appname = Path.GetFileNameWithoutExtension(file)
                                appx.Det.Text = appname
                                appx.Det.Image = appicon
                                Rescale(0.7, appx.Det.Image, appx)
                                appx.Tag = file
                                'appx.BackColor = colorAccent
                                pnl.Controls.Add(appx)
                            End If
                        Next
                        For Each fldr As String In Directory.GetDirectories(Fpsth)
                            For Each file As String In Directory.GetFiles(fldr)
                                If Path.GetFileName(file).Contains(".lnk") Then
                                    Dim appx As New AppTile
                                    Dim appicon = AddIcon(file, 1)
                                    appx.Det.BackColor = pnl.BackColor
                                    Dim appname = Path.GetFileNameWithoutExtension(file)
                                    appx.Det.Text = appname
                                    appx.Det.Image = appicon
                                    Rescale(0.7, appx.Det.Image, appx)
                                    appx.Tag = file
                                    'appx.BackColor = colorAccent
                                    pnl.Controls.Add(appx)
                                End If
                            Next
                        Next
                    End If
                ElseIf pnl.Name = Libs.Name Then
                    For Each fldr As String In Directory.GetDirectories(Fpsth)
                        If fldr.Contains("OneDrive") Or fldr.Contains("Videos") Or fldr.Contains("Music") Or fldr.Contains("Downloads") Or fldr.Contains("Desktop") Or fldr.Contains("3D Objects") Then
                            Dim appx As New AppTile
                            Dim appicon = AddIcon(fldr, 1)
                            appx.Det.BackColor = pnl.BackColor
                            Dim appname = Path.GetFileNameWithoutExtension(fldr)
                            appx.Det.Text = appname
                            appx.Det.Image = appicon
                            Rescale(0.5, appx.Det.Image, appx)
                            appx.Tag = fldr
                            appx.Width -= 34
                            pnl.Controls.Add(appx)
                        End If
                    Next
                ElseIf pnl.Name = Recents.Name Then
                    Dim n As Integer = 0
                    For Each file As String In Directory.GetFiles(Fpsth)
                        n = pnl.Controls.Count
                        If n < 6 Then
                            If file.Contains(".ini") = False And file.Contains(".sln") = False And file.Contains(".vb") = False And Path.GetFileNameWithoutExtension(file).Contains(".") Then
                                Dim appicon = AddIcon(file, 1)
                                Dim appname = Path.GetFileNameWithoutExtension(file)
                                Dim actx As New ActivityTile
                                actx.Tag = file
                                actx.ActivityIcon.Text = appname
                                actx.ActivityIcon.BackColor = colorAccent
                                actx.BackgroundImageLayout = ImageLayout.Center
                                actx.ActivityIcon.BackgroundImage = appicon
                                If file.Contains(".docx") Or file.Contains(".doc") Then
                                    actx.ActivityIcon.BackColor = Color.FromArgb(255, 10, 66, 165)
                                    actx.ActivityIcon.BackgroundImage = Nothing
                                ElseIf file.Contains(".pptx") Or file.Contains(".ppt") Then
                                    actx.ActivityIcon.BackColor = Color.FromArgb(255, 211, 82, 48)
                                    actx.ActivityIcon.BackgroundImage = Nothing
                                ElseIf file.Contains(".xlsx") Then
                                    actx.ActivityIcon.BackColor = Color.FromArgb(255, 14, 117, 60)
                                    actx.ActivityIcon.BackgroundImage = Nothing
                                End If
                                Try
                                    If file.Contains(".bmp") Or file.Contains(".png") Or file.Contains(".jpg") Then
                                        file = GetTargetPath(file)
                                        actx.ActivityIcon.BackgroundImage = Image.FromFile(file)
                                        actx.ActivityIcon.BackgroundImageLayout = ImageLayout.Center
                                    End If
                                Catch ex As Exception

                                End Try
                                pnl.Controls.Add(actx)
                            End If
                        Else

                        End If
                    Next
                End If

            Catch

            End Try
        End If
    End Sub
    Private Function GetTargetPath(LinkFilename As String) As String
        Dim scpath As String = ""
        If LinkFilename.ToLower.EndsWith(".lnk") Then
            Dim theShell As New WshShell()
            Dim theShortcut As WshShortcut = CType(theShell.CreateShortcut(LinkFilename), WshShortcut)
            scpath = theShortcut.TargetPath
            System.Runtime.InteropServices.Marshal.ReleaseComObject(theShortcut)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(theShell)
        End If
        Return scpath
    End Function

    Private Sub Shad_Paint(sender As Object, e As PaintEventArgs) Handles Shad.Paint
        Dim TheControl As Control = CType(sender, Control)
        Dim oRAngle As Rectangle = New Rectangle(0, 0, TheControl.Width, TheControl.Height)
        Dim oGradientBrush As Brush = New LinearGradientBrush(
                                  oRAngle, Color.FromArgb(200, 0, 0, 0),
                                  Color.Transparent,
                                  Drawing.Drawing2D _
                                  .LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(oGradientBrush, oRAngle)
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

    Private Sub lbl1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl2.LinkClicked
        objShell.WindowSwitcher
        Timer3.Enabled = True
        Timer3.Start()
    End Sub

    Private Sub Start_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub Start_ControlRemoved(sender As Object, e As ControlEventArgs) Handles Me.ControlRemoved

    End Sub

    Private Sub lbl1_Click(sender As Object, e As EventArgs) Handles lbl1.Click
        For Each j In AppList.Controls
            j.Dispose()
        Next
        AppList.Controls.Clear()
        If lbl1.Text = "All Apps" Then
            For i = 1 To Len("0123456789abcdefghijklmnopqrstuvwxyz") - 1
                Dim sep As New separator
                sep.txtme.Text = "0123456789abcdefghijklmnopqrstuvwxyz".Substring(i, 1).ToUpper
                AppList.Controls.Add(sep)
                Dim n As Integer = 0
                For Each k As AppTile In als.Controls
                    If k.Det.Text.ToLower.StartsWith("0123456789abcdefghijklmnopqrstuvwxyz".Substring(i, 1)) Then
                        AppList.Controls.Add(k)
                        n += 1
                    End If
                Next
                If n = 0 Then
                    AppList.Controls.Remove(sep)
                End If
            Next
            lbl1.Text = "Pinned"
        Else
            Populate(pinnedapps, AppList)
            lbl1.Text = "All Apps"
        End If
    End Sub
    Dim als As New FlowLayoutPanel

    Private Sub SurroundingSub()
        Dim FODLERID_AppsFolder = New Guid("{1e87508d-89c2-42f0-8a7e-645a0f50ca58}")
        Dim appsFolder As ShellObject = CType(KnownFolderHelper.FromKnownFolderId(FODLERID_AppsFolder), ShellObject)
        For Each app In CType(appsFolder, IKnownFolder)
            Dim appx As New AppTile
            Dim appicon = app.Thumbnail.SmallBitmapSource
            appx.Det.BackColor = AppList.BackColor
            Dim appname = app.Name
            appx.Det.Text = appname
            appx.Det.Image = BitmapFromSource(appicon)
            Rescale(0.7, appx.Det.Image, appx)
            appx.Tag = app.Properties.System.ParsingPath.Value
            als.Controls.Add(appx)
        Next

    End Sub

    Private Function BitmapFromSource(ByVal bitmapsource As BitmapSource) As System.Drawing.Bitmap
        Dim bitmap As System.Drawing.Bitmap
        Using outStream As MemoryStream = New MemoryStream()
            Dim enc As BitmapEncoder = New BmpBitmapEncoder()
            enc.Frames.Add(BitmapFrame.Create(bitmapsource))
            enc.Save(outStream)
            bitmap = New System.Drawing.Bitmap(outStream)
        End Using
        Return bitmap
    End Function

    Private Sub Lbl1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl1.LinkClicked

    End Sub
End Class
