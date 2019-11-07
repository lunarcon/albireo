Public Class ActivityTile
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
    Private Sub ActivityIcon_Click(sender As Object, e As EventArgs) Handles ActivityIcon.Click
        Try
            Process.Start(Tag)
        Catch ex As Exception
            Shell(Tag)
        End Try
    End Sub

    Private Sub ActivityTile_Load(sender As Object, e As EventArgs) Handles Me.Load
        roundthethingy(Me, 15)
    End Sub

    Private Sub ActivityIcon_MouseEnter(sender As Object, e As EventArgs) Handles ActivityIcon.MouseEnter
        ActivityIcon.FlatAppearance.BorderSize = 2
        ActivityIcon.FlatAppearance.BorderColor = Color.FromArgb(255, 60, 60, 60)
    End Sub

    Private Sub ActivityIcon_MouseLeave(sender As Object, e As EventArgs) Handles ActivityIcon.MouseLeave
        ActivityIcon.FlatAppearance.BorderColor = Color.FromArgb(255, 20, 20, 20)
    End Sub
End Class
