<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserTile
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.UserGreet = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ProfilePic = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserGreet
        '
        Me.UserGreet.AutoSize = True
        Me.UserGreet.Dock = System.Windows.Forms.DockStyle.Left
        Me.UserGreet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.UserGreet.FlatAppearance.BorderSize = 0
        Me.UserGreet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.UserGreet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.UserGreet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UserGreet.Font = New System.Drawing.Font("Segoe UI", 16.25!, System.Drawing.FontStyle.Bold)
        Me.UserGreet.ForeColor = System.Drawing.SystemColors.Control
        Me.UserGreet.Location = New System.Drawing.Point(125, 0)
        Me.UserGreet.Margin = New System.Windows.Forms.Padding(4)
        Me.UserGreet.Name = "UserGreet"
        Me.UserGreet.Size = New System.Drawing.Size(400, 135)
        Me.UserGreet.TabIndex = 16
        Me.UserGreet.Text = "Good greeting, username"
        Me.UserGreet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UserGreet.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe MDL2 Assets", 16.8!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(7, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(58, 58)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = ""
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(525, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(204, 135)
        Me.Panel1.TabIndex = 18
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe MDL2 Assets", 16.8!)
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(135, 48)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(58, 58)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = ""
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe MDL2 Assets", 16.8!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(71, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(58, 58)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = ""
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ProfilePic)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(125, 135)
        Me.Panel2.TabIndex = 19
        '
        'ProfilePic
        '
        Me.ProfilePic.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ProfilePic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ProfilePic.FlatAppearance.BorderSize = 0
        Me.ProfilePic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ProfilePic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ProfilePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProfilePic.Font = New System.Drawing.Font("Segoe MDL2 Assets", 20.25!)
        Me.ProfilePic.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ProfilePic.Location = New System.Drawing.Point(11, 24)
        Me.ProfilePic.Margin = New System.Windows.Forms.Padding(0)
        Me.ProfilePic.Name = "ProfilePic"
        Me.ProfilePic.Padding = New System.Windows.Forms.Padding(9, 3, 0, 0)
        Me.ProfilePic.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProfilePic.Size = New System.Drawing.Size(110, 100)
        Me.ProfilePic.TabIndex = 16
        Me.ProfilePic.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ProfilePic.UseVisualStyleBackColor = False
        '
        'UserTile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UserGreet)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "UserTile"
        Me.Size = New System.Drawing.Size(782, 135)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserGreet As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ProfilePic As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
