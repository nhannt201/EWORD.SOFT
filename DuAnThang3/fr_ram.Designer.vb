<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_ram
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
        Me.txt_ram = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_ram
        '
        Me.txt_ram.Location = New System.Drawing.Point(0, 0)
        Me.txt_ram.Multiline = True
        Me.txt_ram.Name = "txt_ram"
        Me.txt_ram.Size = New System.Drawing.Size(100, 20)
        Me.txt_ram.TabIndex = 0
        '
        'fr_ram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(120, 35)
        Me.Controls.Add(Me.txt_ram)
        Me.Name = "fr_ram"
        Me.Text = "fr_ram"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_ram As TextBox
End Class
