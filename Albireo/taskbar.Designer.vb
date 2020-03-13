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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AppsPanel = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ilist
        '
        Me.ilist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ilist.ImageSize = New System.Drawing.Size(32, 32)
        Me.ilist.TransparentColor = System.Drawing.Color.Transparent
        '
        'Timer1
        '
        Me.Timer1.Interval = 30
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 42)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 13.25!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(44, 42)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = ""
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AppsPanel
        '
        Me.AppsPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.AppsPanel.Location = New System.Drawing.Point(220, 0)
        Me.AppsPanel.Name = "AppsPanel"
        Me.AppsPanel.Size = New System.Drawing.Size(672, 42)
        Me.AppsPanel.TabIndex = 1
        '
        'taskbar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1344, 42)
        Me.Controls.Add(Me.AppsPanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "taskbar"
        Me.ShowInTaskbar = False
        Me.Text = "taskbar"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ilist As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents AppsPanel As Panel
End Class
