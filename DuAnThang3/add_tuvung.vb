
Imports System.IO

Public Class add_tuvung

    Sub add_data()
        edit_tuvung.lst_word.Items.Add(txt_word.Text & ": " & txt_mean.Text)
        fr_ram.txt_ram.Text = Replace(fr_ram.txt_ram.Text, "</data>", Trim("|" & txt_word.Text & "~" & txt_mean.Text & "</data>"))
        Using writer As New StreamWriter(Application.StartupPath & edit_tuvung.lb_dc.Text, False)
            writer.WriteLine(fr_ram.txt_ram.Text)
        End Using
    End Sub
    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Me.Hide()

    End Sub

    Private Sub txt_namefd_TextChanged(sender As Object, e As EventArgs) Handles txt_word.TextChanged

    End Sub

    Private Sub txt_namefd_Click(sender As Object, e As EventArgs) Handles txt_word.Click
        txt_word.Clear()

    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        If txt_word.Text = "(Từ của bạn)" Or txt_mean.Text = "(Nghĩa của từ)" Then
            MsgBox("Bạn chưa nhập dữ liệu!")
        Else
            add_data()
        End If
        Me.Hide()
    End Sub

    Private Sub txt_mean_TextChanged(sender As Object, e As EventArgs) Handles txt_mean.TextChanged

    End Sub

    Private Sub txt_mean_Click(sender As Object, e As EventArgs) Handles txt_mean.Click
        txt_mean.Clear()

    End Sub

    Private Sub add_tuvung_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_mean_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_mean.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz0123456789áàạảãâấầậẩẫăắằặẳẵéèẹẻẽêếềệểễóòọỏõôốồộổỗơớờợởỡúùụủũưứừựửữíìịỉĩđýỳỵỷỹ "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_word_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_word.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz0123456789()- "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub lb1_Click(sender As Object, e As EventArgs) Handles lb1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class