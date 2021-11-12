Imports System.IO

Public Class add_thumuc
    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        Dim check_space As String = Replace(txt_namefd.Text, "  ", "").Replace(" ", "")


        If check_space.Length < 5 Then
            MsgBox("Tên thư mục không thể bỏ trống hoặc nhỏ hơn 5 kí tự!", vbInformation, "Nhắc nhở")
        Else
            Me.Hide()
            Using writer As New StreamWriter(Application.StartupPath & "\Folder_Word\" & txt_namefd.Text.Trim & ".ewd", True)
                writer.WriteLine("<name>" & txt_namefd.Text.Trim & "</name><data></data><thongke><so_dung>0</sodung><so_sai>0</so_sai></thongke>")
            End Using
            Home_WT.lst_fd.Items.Add(txt_namefd.Text.Trim)
            'read file
            ' Dim line As String
            '  Using reader As New StreamReader("file.txt")
            '  line = reader.ReadLine()
            '  End Using
            '  Console.WriteLine(line)
        End If

    End Sub

    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Me.Hide()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_namefd.TextChanged

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles txt_namefd.Click
        txt_namefd.Clear()

    End Sub

    Private Sub txt_namefd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_namefd.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz0123456789_ "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class