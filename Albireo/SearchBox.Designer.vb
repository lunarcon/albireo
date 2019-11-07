<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchBox
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
        Me.SearchBoxPadding = New System.Windows.Forms.Panel()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.SearchText = New System.Windows.Forms.TextBox()
        Me.SearchBoxPadding.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchBoxPadding
        '
        Me.SearchBoxPadding.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.SearchBoxPadding.Controls.Add(Me.SearchBtn)
        Me.SearchBoxPadding.Controls.Add(Me.SearchText)
        Me.SearchBoxPadding.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchBoxPadding.Location = New System.Drawing.Point(0, 0)
        Me.SearchBoxPadding.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchBoxPadding.Name = "SearchBoxPadding"
        Me.SearchBoxPadding.Padding = New System.Windows.Forms.Padding(20, 9, 13, 9)
        Me.SearchBoxPadding.Size = New System.Drawing.Size(525, 52)
        Me.SearchBoxPadding.TabIndex = 17
        '
        'SearchBtn
        '
        Me.SearchBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.SearchBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.SearchBtn.FlatAppearance.BorderSize = 0
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.Font = New System.Drawing.Font("Segoe MDL2 Assets", 11.05!)
        Me.SearchBtn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.SearchBtn.Location = New System.Drawing.Point(475, 9)
        Me.SearchBtn.Margin = New System.Windows.Forms.Padding(0, 0, 13, 0)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(37, 34)
        Me.SearchBtn.TabIndex = 23
        Me.SearchBtn.Text = ""
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'SearchText
        '
        Me.SearchText.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.SearchText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SearchText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchText.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.SearchText.ForeColor = System.Drawing.SystemColors.Menu
        Me.SearchText.Location = New System.Drawing.Point(20, 9)
        Me.SearchText.Margin = New System.Windows.Forms.Padding(7, 4, 4, 4)
        Me.SearchText.Name = "SearchText"
        Me.SearchText.Size = New System.Drawing.Size(492, 30)
        Me.SearchText.TabIndex = 15
        Me.SearchText.Text = "Search"
        '
        'SearchBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SearchBoxPadding)
        Me.Name = "SearchBox"
        Me.Size = New System.Drawing.Size(525, 52)
        Me.SearchBoxPadding.ResumeLayout(False)
        Me.SearchBoxPadding.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SearchBoxPadding As Panel
    Friend WithEvents SearchBtn As Button
    Friend WithEvents SearchText As TextBox
End Class
