<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Start
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
        Me.components = New System.ComponentModel.Container()
        Me.Header = New System.Windows.Forms.Panel()
        Me.UCon = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Sep = New System.Windows.Forms.Panel()
        Me.UserGreet = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AppList = New System.Windows.Forms.FlowLayoutPanel()
        Me.Shad = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Libs = New System.Windows.Forms.FlowLayoutPanel()
        Me.Recents = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl2 = New System.Windows.Forms.LinkLabel()
        Me.lbl1 = New System.Windows.Forms.LinkLabel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.UserTile1 = New Albireo.UserTile()
        Me.SearchBox1 = New Albireo.SearchBox()
        Me.Header.SuspendLayout()
        Me.UCon.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Header.Controls.Add(Me.UCon)
        Me.Header.Controls.Add(Me.Panel3)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1422, 154)
        Me.Header.TabIndex = 0
        '
        'UCon
        '
        Me.UCon.Controls.Add(Me.UserTile1)
        Me.UCon.Controls.Add(Me.Panel2)
        Me.UCon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UCon.Location = New System.Drawing.Point(0, 0)
        Me.UCon.Name = "UCon"
        Me.UCon.Size = New System.Drawing.Size(820, 154)
        Me.UCon.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(27, 154)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.SearchBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(820, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(602, 154)
        Me.Panel3.TabIndex = 1
        '
        'Sep
        '
        Me.Sep.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Sep.Location = New System.Drawing.Point(820, 184)
        Me.Sep.Name = "Sep"
        Me.Sep.Size = New System.Drawing.Size(2, 622)
        Me.Sep.TabIndex = 1
        '
        'UserGreet
        '
        Me.UserGreet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.UserGreet.FlatAppearance.BorderSize = 0
        Me.UserGreet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.UserGreet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.UserGreet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UserGreet.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.UserGreet.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.UserGreet.Location = New System.Drawing.Point(0, 178)
        Me.UserGreet.Margin = New System.Windows.Forms.Padding(4)
        Me.UserGreet.Name = "UserGreet"
        Me.UserGreet.Size = New System.Drawing.Size(187, 67)
        Me.UserGreet.TabIndex = 15
        Me.UserGreet.Text = "My Apps"
        Me.UserGreet.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.Location = New System.Drawing.Point(824, 178)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 67)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Recent Files"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AppList
        '
        Me.AppList.AutoScroll = True
        Me.AppList.Location = New System.Drawing.Point(27, 243)
        Me.AppList.Name = "AppList"
        Me.AppList.Size = New System.Drawing.Size(825, 563)
        Me.AppList.TabIndex = 17
        '
        'Shad
        '
        Me.Shad.Dock = System.Windows.Forms.DockStyle.Top
        Me.Shad.Location = New System.Drawing.Point(0, 154)
        Me.Shad.Margin = New System.Windows.Forms.Padding(4)
        Me.Shad.Name = "Shad"
        Me.Shad.Size = New System.Drawing.Size(1422, 16)
        Me.Shad.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Libs)
        Me.Panel1.Controls.Add(Me.Recents)
        Me.Panel1.Location = New System.Drawing.Point(828, 243)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(582, 563)
        Me.Panel1.TabIndex = 29
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button2.Location = New System.Drawing.Point(1, 327)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 52)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Libraries"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Libs
        '
        Me.Libs.Location = New System.Drawing.Point(28, 386)
        Me.Libs.Name = "Libs"
        Me.Libs.Size = New System.Drawing.Size(553, 158)
        Me.Libs.TabIndex = 19
        '
        'Recents
        '
        Me.Recents.Location = New System.Drawing.Point(28, 45)
        Me.Recents.Name = "Recents"
        Me.Recents.Size = New System.Drawing.Size(551, 260)
        Me.Recents.TabIndex = 0
        '
        'lbl2
        '
        Me.lbl2.ActiveLinkColor = System.Drawing.Color.Gainsboro
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lbl2.LinkColor = System.Drawing.Color.DodgerBlue
        Me.lbl2.Location = New System.Drawing.Point(1260, 203)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(121, 23)
        Me.lbl2.TabIndex = 30
        Me.lbl2.TabStop = True
        Me.lbl2.Text = "Open Timeline"
        Me.lbl2.VisitedLinkColor = System.Drawing.Color.DodgerBlue
        '
        'lbl1
        '
        Me.lbl1.ActiveLinkColor = System.Drawing.Color.Gainsboro
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lbl1.LinkColor = System.Drawing.Color.DodgerBlue
        Me.lbl1.Location = New System.Drawing.Point(713, 203)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(72, 23)
        Me.lbl1.TabIndex = 31
        Me.lbl1.TabStop = True
        Me.lbl1.Text = "All Apps"
        Me.lbl1.VisitedLinkColor = System.Drawing.Color.DodgerBlue
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'Timer3
        '
        Me.Timer3.Interval = 10
        '
        'UserTile1
        '
        Me.UserTile1.AutoSize = True
        Me.UserTile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.UserTile1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserTile1.Location = New System.Drawing.Point(27, 0)
        Me.UserTile1.Name = "UserTile1"
        Me.UserTile1.Size = New System.Drawing.Size(793, 154)
        Me.UserTile1.TabIndex = 1
        '
        'SearchBox1
        '
        Me.SearchBox1.Location = New System.Drawing.Point(36, 51)
        Me.SearchBox1.Name = "SearchBox1"
        Me.SearchBox1.Size = New System.Drawing.Size(525, 52)
        Me.SearchBox1.TabIndex = 0
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1422, 833)
        Me.Controls.Add(Me.Sep)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.Shad)
        Me.Controls.Add(Me.AppList)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UserGreet)
        Me.Controls.Add(Me.Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Start"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start"
        Me.TopMost = True
        Me.Header.ResumeLayout(False)
        Me.UCon.ResumeLayout(False)
        Me.UCon.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Header As Panel
    Friend WithEvents UCon As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Sep As Panel
    Friend WithEvents UserGreet As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents UserTile1 As UserTile
    Friend WithEvents SearchBox1 As SearchBox
    Friend WithEvents AppList As FlowLayoutPanel
    Friend WithEvents Shad As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Libs As FlowLayoutPanel
    Friend WithEvents Recents As FlowLayoutPanel
    Friend WithEvents lbl2 As LinkLabel
    Friend WithEvents lbl1 As LinkLabel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
End Class
