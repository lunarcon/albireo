<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class separator
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
        Me.txtme = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtme
        '
        Me.txtme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtme.FlatAppearance.BorderSize = 0
        Me.txtme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.txtme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.txtme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtme.Font = New System.Drawing.Font("Segoe UI", 13.25!, System.Drawing.FontStyle.Bold)
        Me.txtme.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.txtme.Location = New System.Drawing.Point(0, 19)
        Me.txtme.Name = "txtme"
        Me.txtme.Size = New System.Drawing.Size(81, 30)
        Me.txtme.TabIndex = 16
        Me.txtme.Text = "#"
        Me.txtme.UseVisualStyleBackColor = True
        '
        'separator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Controls.Add(Me.txtme)
        Me.Name = "separator"
        Me.Size = New System.Drawing.Size(589, 49)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtme As Button
End Class
