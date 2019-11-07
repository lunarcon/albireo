<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivityTile
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActivityTile))
        Me.ActivityIcon = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ActivityIcon
        '
        Me.ActivityIcon.BackColor = System.Drawing.Color.White
        Me.ActivityIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ActivityIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActivityIcon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ActivityIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActivityIcon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ActivityIcon.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ActivityIcon.Image = CType(resources.GetObject("ActivityIcon.Image"), System.Drawing.Image)
        Me.ActivityIcon.Location = New System.Drawing.Point(0, 0)
        Me.ActivityIcon.Margin = New System.Windows.Forms.Padding(10)
        Me.ActivityIcon.Name = "ActivityIcon"
        Me.ActivityIcon.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.ActivityIcon.Size = New System.Drawing.Size(170, 121)
        Me.ActivityIcon.TabIndex = 1
        Me.ActivityIcon.Text = "ActivityName"
        Me.ActivityIcon.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ActivityIcon.UseVisualStyleBackColor = False
        '
        'ActivityTile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ActivityIcon)
        Me.Name = "ActivityTile"
        Me.Size = New System.Drawing.Size(170, 121)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ActivityIcon As Button
End Class
