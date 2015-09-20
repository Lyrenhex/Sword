<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class replace
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
        Me.txtRep1 = New System.Windows.Forms.TextBox()
        Me.btnRep = New System.Windows.Forms.Button()
        Me.txtRep2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtRep1
        '
        Me.txtRep1.Location = New System.Drawing.Point(13, 13)
        Me.txtRep1.Name = "txtRep1"
        Me.txtRep1.Size = New System.Drawing.Size(259, 20)
        Me.txtRep1.TabIndex = 0
        '
        'btnRep
        '
        Me.btnRep.Location = New System.Drawing.Point(13, 70)
        Me.btnRep.Name = "btnRep"
        Me.btnRep.Size = New System.Drawing.Size(111, 23)
        Me.btnRep.TabIndex = 1
        Me.btnRep.Text = "Replace #1 with #2"
        Me.btnRep.UseVisualStyleBackColor = True
        '
        'txtRep2
        '
        Me.txtRep2.Location = New System.Drawing.Point(13, 40)
        Me.txtRep2.Name = "txtRep2"
        Me.txtRep2.Size = New System.Drawing.Size(259, 20)
        Me.txtRep2.TabIndex = 2
        '
        'replace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 105)
        Me.Controls.Add(Me.txtRep2)
        Me.Controls.Add(Me.btnRep)
        Me.Controls.Add(Me.txtRep1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "replace"
        Me.Text = "Find Text"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRep1 As System.Windows.Forms.TextBox
    Friend WithEvents btnRep As System.Windows.Forms.Button
    Friend WithEvents txtRep2 As System.Windows.Forms.TextBox
End Class
