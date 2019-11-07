<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppTile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppTile))
        Me.Det = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Det
        '
        Me.Det.AutoEllipsis = True
        Me.Det.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Det.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Det.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Det.FlatAppearance.BorderSize = 2
        Me.Det.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Det.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Det.ForeColor = System.Drawing.SystemColors.Control
        Me.Det.Image = CType(resources.GetObject("Det.Image"), System.Drawing.Image)
        Me.Det.Location = New System.Drawing.Point(0, 0)
        Me.Det.Name = "Det"
        Me.Det.Size = New System.Drawing.Size(150, 155)
        Me.Det.TabIndex = 0
        Me.Det.Text = "Appname"
        Me.Det.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Det.UseVisualStyleBackColor = False
        '
        'AppTile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Det)
        Me.Name = "AppTile"
        Me.Size = New System.Drawing.Size(150, 155)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Det As Button
End Class
