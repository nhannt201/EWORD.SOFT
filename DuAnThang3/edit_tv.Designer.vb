<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_tv
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
        Me.txt_mean = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_close = New System.Windows.Forms.Button()
        Me.bt1 = New System.Windows.Forms.Button()
        Me.txt_word = New System.Windows.Forms.TextBox()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.rp_text = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_mean
        '
        Me.txt_mean.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mean.Location = New System.Drawing.Point(17, 79)
        Me.txt_mean.Name = "txt_mean"
        Me.txt_mean.Size = New System.Drawing.Size(181, 27)
        Me.txt_mean.TabIndex = 15
        Me.txt_mean.Text = "(Nghĩa của từ)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nghĩa:"
        '
        'bt_close
        '
        Me.bt_close.BackColor = System.Drawing.Color.Firebrick
        Me.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_close.Font = New System.Drawing.Font("Tahoma", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_close.ForeColor = System.Drawing.Color.White
        Me.bt_close.Location = New System.Drawing.Point(285, 0)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.Size = New System.Drawing.Size(17, 17)
        Me.bt_close.TabIndex = 13
        Me.bt_close.Text = "X"
        Me.bt_close.UseVisualStyleBackColor = False
        '
        'bt1
        '
        Me.bt1.BackColor = System.Drawing.Color.Turquoise
        Me.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt1.Location = New System.Drawing.Point(216, 26)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(77, 78)
        Me.bt1.TabIndex = 12
        Me.bt1.Text = "&Sửa"
        Me.bt1.UseVisualStyleBackColor = False
        '
        'txt_word
        '
        Me.txt_word.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_word.Location = New System.Drawing.Point(17, 26)
        Me.txt_word.Name = "txt_word"
        Me.txt_word.Size = New System.Drawing.Size(181, 27)
        Me.txt_word.TabIndex = 11
        Me.txt_word.Text = "(Từ của bạn)"
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1.Location = New System.Drawing.Point(13, 4)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(82, 19)
        Me.lb1.TabIndex = 10
        Me.lb1.Text = "Từ vựng:"
        '
        'rp_text
        '
        Me.rp_text.Location = New System.Drawing.Point(179, 6)
        Me.rp_text.Multiline = True
        Me.rp_text.Name = "rp_text"
        Me.rp_text.Size = New System.Drawing.Size(100, 17)
        Me.rp_text.TabIndex = 16
        '
        'edit_tv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(303, 116)
        Me.Controls.Add(Me.rp_text)
        Me.Controls.Add(Me.txt_mean)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_close)
        Me.Controls.Add(Me.bt1)
        Me.Controls.Add(Me.txt_word)
        Me.Controls.Add(Me.lb1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "edit_tv"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sửa từ tựng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_mean As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_close As Button
    Friend WithEvents bt1 As Button
    Friend WithEvents txt_word As TextBox
    Friend WithEvents lb1 As Label
    Friend WithEvents rp_text As TextBox
End Class
