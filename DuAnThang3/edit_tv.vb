Imports System.IO

Public Class edit_tv
    Dim rp_txt As String
    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Me.Hide()
    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        Dim txt_rp As String = StrConv(txt_word.Text & "~" & txt_mean.Text, 2)
        rp_text.Text = rp_text.Text.Replace(rp_txt, txt_rp).Replace("<data>|", "<data>").Replace("|</data>", "</data>")
        edit_tuvung.lst_word.Items(edit_tuvung.lst_word.SelectedIndex) = txt_word.Text & ": " & txt_mean.Text
        save_word()
        Me.Hide()
    End Sub
    Sub save_word()
        Using writer As New StreamWriter(Application.StartupPath & edit_tuvung.lb_dc.Text, False)
            writer.WriteLine(rp_text.Text)
        End Using
    End Sub
    Private Sub edit_tv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rp_txt = StrConv(edit_tuvung.lst_word.Text.Replace(": ", "~"), 2)
        rp_text.Text = fr_ram.txt_ram.Text
        rp_text.Visible = False

    End Sub
End Class