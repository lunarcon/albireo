Public Class AppTile
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
    Private Sub AppTile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundthethingy(Me, 15)

    End Sub

    Private Sub AppTile_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        BackColor = Color.FromArgb(255, 30, 30, 30)
    End Sub

    Private Sub AppTile_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        BackColor = Color.Transparent
    End Sub

    Private Sub Det_Click(sender As Object, e As EventArgs) Handles Det.Click
        Try
            Process.Start(Tag)
        Catch ex As Exception
            Shell(Tag)
        End Try
    End Sub

    Private Sub Det_MouseEnter(sender As Object, e As EventArgs) Handles Det.MouseEnter
        Det.FlatAppearance.BorderColor = Color.FromArgb(10, 10, 10)
    End Sub

    Private Sub Det_MouseLeave(sender As Object, e As EventArgs) Handles Det.MouseLeave
        Det.FlatAppearance.BorderColor = Det.BackColor
    End Sub
End Class
