Imports System.IO

Public Class edit_tuvung
    Dim top_list As String
    Dim click_list As String
    Dim total_list As String

    Dim rp_delete As String
    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Me.Hide()
    End Sub

    Private Sub edit_tuvung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rp_edit.Text = fr_ram.txt_ram.Text
    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        add_tuvung.Close()
        add_tuvung.Show()
    End Sub

    Private Sub bt2_Click(sender As Object, e As EventArgs) Handles bt2.Click
        total_list = lst_word.Items.Count
        click_list = (lst_word.SelectedIndex)
        If total_list <= 1 Then
            MsgBox("Bạn không thể để rỗng dữ thư mục này!")
        Else
            rp_delete = StrConv(lst_word.Text.Replace(": ", "~"), 2)
            rp_edit.Text = rp_edit.Text.Replace(rp_delete, "").Replace("||", "|").Replace("<data>|", "<data>").Replace("|</data>", "</data>")
            rp_edit.Text = StrConv(rp_edit.Text, 2)
            lst_word.Items.Remove(lst_word.SelectedItem)
            save_word()
        End If

        '  MsgBox(rp_edit.Text)

    End Sub
    Sub save_word()
        Using writer As New StreamWriter(Application.StartupPath & lb_dc.Text, False)
            writer.WriteLine(rp_edit.Text)
        End Using
    End Sub

    Private Sub bt3_Click(sender As Object, e As EventArgs) Handles bt3.Click
        edit_lst()
    End Sub
    Sub edit_lst()
        If lst_word.SelectedIndex >= 0 Then
            Dim strarr() As String
            strarr = lst_word.Text.Split(": ")
            edit_tv.txt_word.Text = (strarr(0))
            edit_tv.txt_mean.Text = Trim(strarr(1))
            edit_tv.Show()
        Else

        End If


    End Sub

    Private Sub lst_word_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_word.SelectedIndexChanged

    End Sub

    Private Sub lst_word_DoubleClick(sender As Object, e As EventArgs) Handles lst_word.DoubleClick
        edit_lst()
    End Sub
End Class