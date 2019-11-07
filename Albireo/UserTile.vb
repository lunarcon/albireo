Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Text


Public Class UserTile
    Dim bmp As Bitmap
    Dim userFullName As String = DirectoryServices.AccountManagement.UserPrincipal.Current.DisplayName
    Dim userEmail As String = DirectoryServices.AccountManagement.UserPrincipal.Current.EmailAddress
    Dim greet As String = "Hi"
    Private Sub RoundPic(pic As Control)
        Dim originalImage = pic.BackgroundImage
        pic.BackgroundImageLayout = ImageLayout.Zoom
        Dim croppedImage As New Bitmap(originalImage.Width, originalImage.Height)
        'Prepare to draw on the new image.
        Using g = Graphics.FromImage(croppedImage)
            Dim path As New GraphicsPath
            path.AddEllipse(0, 0, croppedImage.Width, croppedImage.Height)
            Dim reg As New Region(path)
            'Draw only within the specified ellipse.
            g.Clip = reg
            g.DrawImage(originalImage, Point.Empty)
        End Using
        'Display the new image.
        pic.BackgroundImage = croppedImage
    End Sub
    <DllImport("shell32", EntryPoint:="#261", CharSet:=CharSet.Unicode, PreserveSig:=False)>
    Public Shared Sub GetUserTilePath(username As String, whatever As UInt32, picpath As StringBuilder, maxLength As Integer)
    End Sub
    Declare Function GetUserName Lib "advapi32.dll" Alias _
       "GetUserNameA" (ByVal lpBuffer As String,
       ByRef nSize As Integer) As Integer
    Public Function GetUserName() As String
        Dim iReturn As Integer
        Dim userName As String
        userName = New String(CChar(" "), 50)
        iReturn = GetUserName(userName, 50)
        GetUserName = userName.Substring(0, userName.IndexOf(Chr(0)))
    End Function
    Public Function GetUserTilePath(username As String) As String
        Dim sb As StringBuilder
        sb = New StringBuilder(1000)
        GetUserTilePath(username, 2147483648, sb, sb.Capacity)
        Return sb.ToString()
    End Function

    Public Function GetUserTile(username As String) As Image
        Return Image.FromFile(GetUserTilePath(username))
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
    Private Sub UserGreet_Click(sender As Object, e As EventArgs) Handles UserGreet.Click

    End Sub

    Private Sub UserTile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Now.Hour < 12 And Now.Hour > 4 Then
            greet = "morning"
        ElseIf Now.Hour >= 12 And Now.Hour < 16 Then
            greet = "afternoon"
        ElseIf Now.Hour >= 16 And Now.Hour <= 20 Then
            greet = "evening"
        Else
            greet = "night"
        End If
        UserGreet.Text = "Good " & greet & ", " & userFullName
        ProfilePic.BackgroundImage = GetUserTile(GetUserName)
        RoundPic(ProfilePic)
        roundthethingy(ProfilePic, 80)
        bmp = ProfilePic.BackgroundImage

    End Sub
    Private Sub ProfilePic_MouseEnter(sender As Object, e As EventArgs) Handles ProfilePic.MouseEnter
        ProfilePic.Text = ""
        sender.BackgroundImage = Nothing
    End Sub

    Private Sub ProfilePic_MouseLeave(sender As Object, e As EventArgs) Handles ProfilePic.MouseLeave
        ProfilePic.Text = ""
        ProfilePic.BackgroundImage = bmp
    End Sub

    Private Sub ProfilePic_Click(sender As Object, e As EventArgs) Handles ProfilePic.Click
        Process.Start("ms-settings:yourinfo")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("ms-settings:")
    End Sub
End Class
