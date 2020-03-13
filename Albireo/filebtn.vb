Imports System.IO

Public Class filebtn
    Dim clicc As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.BackColor = Color.FromArgb(200, 200, 200, 210)
        Button1.Text = Path.GetFileNameWithoutExtension(Tag)
        If clicc = False Then
            clicc = True
        Else
            clicc = False
        End If
        If Button1.BackColor = Color.FromArgb(200, 200, 200, 210) And clicc = False Then
            Try
                Process.Start(Tag)
            Catch ex As Exception

            End Try
        End If
    End Sub



    Private Sub Button1_LostFocus(sender As Object, e As EventArgs) Handles Button1.LostFocus
        Button1.BackColor = Color.Transparent
        Try
            Button1.Text = Button1.Text.Substring(1, 20)
        Catch
        End Try
        clicc = False
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave

    End Sub

    Private Sub filebtn_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

End Class
