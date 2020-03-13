<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class explorer_shell
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AppList = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 822)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1495, 40)
        Me.Panel1.TabIndex = 0
        '
        'AppList
        '
        Me.AppList.AutoScroll = True
        Me.AppList.BackColor = System.Drawing.Color.Transparent
        Me.AppList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AppList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.AppList.Location = New System.Drawing.Point(0, 0)
        Me.AppList.Margin = New System.Windows.Forms.Padding(2)
        Me.AppList.Name = "AppList"
        Me.AppList.Size = New System.Drawing.Size(1495, 822)
        Me.AppList.TabIndex = 18
        '
        'explorer_shell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1495, 862)
        Me.ControlBox = False
        Me.Controls.Add(Me.AppList)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "explorer_shell"
        Me.Text = "explorer_shell"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AppList As FlowLayoutPanel
End Class
