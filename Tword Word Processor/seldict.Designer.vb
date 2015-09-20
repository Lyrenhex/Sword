<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class seldict
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
        Me.listDicts = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'listDicts
        '
        Me.listDicts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listDicts.FormattingEnabled = True
        Me.listDicts.Items.AddRange(New Object() {"el_GR", "en_AU", "en_CA", "en_GB", "en_US", "en_ZA", "ko_KR", "lt_LT", "sv_SE"})
        Me.listDicts.Location = New System.Drawing.Point(0, 0)
        Me.listDicts.Name = "listDicts"
        Me.listDicts.Size = New System.Drawing.Size(490, 457)
        Me.listDicts.TabIndex = 0
        '
        'seldict
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 457)
        Me.Controls.Add(Me.listDicts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "seldict"
        Me.Text = "Select Dictionary"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listDicts As System.Windows.Forms.ListBox
End Class
