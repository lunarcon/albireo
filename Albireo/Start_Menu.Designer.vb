<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Start_Menu
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
        Me.UserTile1 = New Albireo.UserTile()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SearchBox1 = New Albireo.SearchBox()
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
        Me.Header.Margin = New System.Windows.Forms.Padding(2)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1066, 125)
        Me.Header.TabIndex = 0
        '
        'UCon
        '
        Me.UCon.Controls.Add(Me.UserTile1)
        Me.UCon.Controls.Add(Me.Panel2)
        Me.UCon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UCon.Location = New System.Drawing.Point(0, 0)
        Me.UCon.Margin = New System.Windows.Forms.Padding(2)
        Me.UCon.Name = "UCon"
        Me.UCon.Size = New System.Drawing.Size(614, 125)
        Me.UCon.TabIndex = 0
        '
        'UserTile1
        '
        Me.UserTile1.AutoSize = True
        Me.UserTile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.UserTile1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserTile1.Location = New System.Drawing.Point(20, 0)
        Me.UserTile1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UserTile1.Name = "UserTile1"
        Me.UserTile1.Size = New System.Drawing.Size(594, 125)
        Me.UserTile1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(20, 125)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.SearchBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(614, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(452, 125)
        Me.Panel3.TabIndex = 1
        '
        'SearchBox1
        '
        Me.SearchBox1.Location = New System.Drawing.Point(27, 41)
        Me.SearchBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SearchBox1.Name = "SearchBox1"
        Me.SearchBox1.Size = New System.Drawing.Size(394, 42)
        Me.SearchBox1.TabIndex = 0
        '
        'Sep
        '
        Me.Sep.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Sep.Location = New System.Drawing.Point(615, 150)
        Me.Sep.Margin = New System.Windows.Forms.Padding(2)
        Me.Sep.Name = "Sep"
        Me.Sep.Size = New System.Drawing.Size(2, 505)
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
        Me.UserGreet.Location = New System.Drawing.Point(0, 145)
        Me.UserGreet.Name = "UserGreet"
        Me.UserGreet.Size = New System.Drawing.Size(140, 54)
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
        Me.Button1.Location = New System.Drawing.Point(618, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 54)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Recent Files"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AppList
        '
        Me.AppList.AutoScroll = True
        Me.AppList.Location = New System.Drawing.Point(20, 197)
        Me.AppList.Margin = New System.Windows.Forms.Padding(2)
        Me.AppList.Name = "AppList"
        Me.AppList.Size = New System.Drawing.Size(619, 457)
        Me.AppList.TabIndex = 17
        '
        'Shad
        '
        Me.Shad.Dock = System.Windows.Forms.DockStyle.Top
        Me.Shad.Location = New System.Drawing.Point(0, 125)
        Me.Shad.Name = "Shad"
        Me.Shad.Size = New System.Drawing.Size(1066, 13)
        Me.Shad.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Libs)
        Me.Panel1.Controls.Add(Me.Recents)
        Me.Panel1.Location = New System.Drawing.Point(621, 197)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(436, 457)
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
        Me.Button2.Location = New System.Drawing.Point(1, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 42)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Libraries"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Libs
        '
        Me.Libs.Location = New System.Drawing.Point(21, 314)
        Me.Libs.Margin = New System.Windows.Forms.Padding(2)
        Me.Libs.Name = "Libs"
        Me.Libs.Size = New System.Drawing.Size(415, 128)
        Me.Libs.TabIndex = 19
        '
        'Recents
        '
        Me.Recents.Location = New System.Drawing.Point(21, 37)
        Me.Recents.Margin = New System.Windows.Forms.Padding(2)
        Me.Recents.Name = "Recents"
        Me.Recents.Size = New System.Drawing.Size(413, 211)
        Me.Recents.TabIndex = 0
        '
        'lbl2
        '
        Me.lbl2.ActiveLinkColor = System.Drawing.Color.Gainsboro
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lbl2.LinkColor = System.Drawing.Color.DodgerBlue
        Me.lbl2.Location = New System.Drawing.Point(945, 165)
        Me.lbl2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(97, 19)
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
        Me.lbl1.Location = New System.Drawing.Point(535, 165)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(59, 19)
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
        'Start_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1066, 677)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Start_Menu"
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
