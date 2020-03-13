<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class taskbar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ilist = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ilist
        '
        Me.ilist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ilist.ImageSize = New System.Drawing.Size(32, 32)
        Me.ilist.TransparentColor = System.Drawing.Color.Transparent
        '
        'taskbar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1344, 42)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "taskbar"
        Me.ShowInTaskbar = False
        Me.Text = "taskbar"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ilist As ImageList
    Friend WithEvents Timer1 As Timer
End Class
