<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_tuvung
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bt3 = New System.Windows.Forms.Button()
        Me.bt1 = New System.Windows.Forms.Button()
        Me.bt2 = New System.Windows.Forms.Button()
        Me.lst_word = New System.Windows.Forms.ListBox()
        Me.bt_close = New System.Windows.Forms.Button()
        Me.lb_Address = New System.Windows.Forms.Label()
        Me.lb_dc = New System.Windows.Forms.Label()
        Me.rp_edit = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.bt3)
        Me.GroupBox1.Controls.Add(Me.bt1)
        Me.GroupBox1.Controls.Add(Me.bt2)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 61)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quản lí từ vựng"
        '
        'bt3
        '
        Me.bt3.BackColor = System.Drawing.Color.Aquamarine
        Me.bt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt3.Location = New System.Drawing.Point(130, 22)
        Me.bt3.Name = "bt3"
        Me.bt3.Size = New System.Drawing.Size(75, 31)
        Me.bt3.TabIndex = 5
        Me.bt3.Text = "&Sửa"
        Me.bt3.UseVisualStyleBackColor = False
        '
        'bt1
        '
        Me.bt1.BackColor = System.Drawing.Color.Aquamarine
        Me.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt1.Location = New System.Drawing.Point(47, 22)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(77, 31)
        Me.bt1.TabIndex = 3
        Me.bt1.Text = "&Thêm"
        Me.bt1.UseVisualStyleBackColor = False
        '
        'bt2
        '
        Me.bt2.BackColor = System.Drawing.Color.Aquamarine
        Me.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt2.Location = New System.Drawing.Point(211, 22)
        Me.bt2.Name = "bt2"
        Me.bt2.Size = New System.Drawing.Size(75, 31)
        Me.bt2.TabIndex = 4
        Me.bt2.Text = "&Xóa"
        Me.bt2.UseVisualStyleBackColor = False
        '
        'lst_word
        '
        Me.lst_word.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_word.FormattingEnabled = True
        Me.lst_word.ItemHeight = 19
        Me.lst_word.Location = New System.Drawing.Point(12, 92)
        Me.lst_word.Name = "lst_word"
        Me.lst_word.Size = New System.Drawing.Size(333, 289)
        Me.lst_word.TabIndex = 1
        '
        'bt_close
        '
        Me.bt_close.BackColor = System.Drawing.Color.Firebrick
        Me.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_close.Font = New System.Drawing.Font("Tahoma", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_close.ForeColor = System.Drawing.Color.White
        Me.bt_close.Location = New System.Drawing.Point(342, 0)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.Size = New System.Drawing.Size(17, 17)
        Me.bt_close.TabIndex = 4
        Me.bt_close.Text = "X"
        Me.bt_close.UseVisualStyleBackColor = False
        '
        'lb_Address
        '
        Me.lb_Address.AutoSize = True
        Me.lb_Address.Location = New System.Drawing.Point(12, 76)
        Me.lb_Address.Name = "lb_Address"
        Me.lb_Address.Size = New System.Drawing.Size(63, 13)
        Me.lb_Address.TabIndex = 5
        Me.lb_Address.Text = "Đường dẫn:"
        '
        'lb_dc
        '
        Me.lb_dc.AutoSize = True
        Me.lb_dc.Location = New System.Drawing.Point(81, 76)
        Me.lb_dc.Name = "lb_dc"
        Me.lb_dc.Size = New System.Drawing.Size(19, 13)
        Me.lb_dc.TabIndex = 6
        Me.lb_dc.Text = "dc"
        '
        'rp_edit
        '
        Me.rp_edit.Location = New System.Drawing.Point(223, 347)
        Me.rp_edit.Multiline = True
        Me.rp_edit.Name = "rp_edit"
        Me.rp_edit.Size = New System.Drawing.Size(112, 52)
        Me.rp_edit.TabIndex = 7
        Me.rp_edit.Visible = False
        '
        'edit_tuvung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(357, 411)
        Me.Controls.Add(Me.rp_edit)
        Me.Controls.Add(Me.lb_dc)
        Me.Controls.Add(Me.lb_Address)
        Me.Controls.Add(Me.bt_close)
        Me.Controls.Add(Me.lst_word)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "edit_tuvung"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lí từ vựng"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bt3 As Button
    Friend WithEvents bt1 As Button
    Friend WithEvents bt2 As Button
    Friend WithEvents lst_word As ListBox
    Friend WithEvents bt_close As Button
    Friend WithEvents lb_Address As Label
    Friend WithEvents lb_dc As Label
    Friend WithEvents rp_edit As TextBox
End Class
