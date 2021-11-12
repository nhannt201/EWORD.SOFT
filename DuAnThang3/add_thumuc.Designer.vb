<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_thumuc
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
        Me.lb1 = New System.Windows.Forms.Label()
        Me.txt_namefd = New System.Windows.Forms.TextBox()
        Me.bt1 = New System.Windows.Forms.Button()
        Me.bt_close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1.Location = New System.Drawing.Point(12, 9)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(117, 19)
        Me.lb1.TabIndex = 0
        Me.lb1.Text = "Tên thư mục:"
        '
        'txt_namefd
        '
        Me.txt_namefd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namefd.Location = New System.Drawing.Point(16, 31)
        Me.txt_namefd.Multiline = True
        Me.txt_namefd.Name = "txt_namefd"
        Me.txt_namefd.Size = New System.Drawing.Size(181, 31)
        Me.txt_namefd.TabIndex = 1
        Me.txt_namefd.Text = "(Thư mục)"
        '
        'bt1
        '
        Me.bt1.BackColor = System.Drawing.Color.Turquoise
        Me.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt1.Location = New System.Drawing.Point(203, 32)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(88, 30)
        Me.bt1.TabIndex = 2
        Me.bt1.Text = "&Tạo"
        Me.bt1.UseVisualStyleBackColor = False
        '
        'bt_close
        '
        Me.bt_close.BackColor = System.Drawing.Color.Firebrick
        Me.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_close.Font = New System.Drawing.Font("Tahoma", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_close.ForeColor = System.Drawing.Color.White
        Me.bt_close.Location = New System.Drawing.Point(288, 0)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.Size = New System.Drawing.Size(17, 17)
        Me.bt_close.TabIndex = 3
        Me.bt_close.Text = "X"
        Me.bt_close.UseVisualStyleBackColor = False
        '
        'add_thumuc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(305, 74)
        Me.Controls.Add(Me.bt_close)
        Me.Controls.Add(Me.bt1)
        Me.Controls.Add(Me.txt_namefd)
        Me.Controls.Add(Me.lb1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "add_thumuc"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm từ vựng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb1 As Label
    Friend WithEvents txt_namefd As TextBox
    Friend WithEvents bt1 As Button
    Friend WithEvents bt_close As Button
End Class
