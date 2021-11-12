Imports System.IO

Public Class Home_WT
    Dim max_wt = 0
    Dim max_hg = 0
    Dim max_hg_mb3 = 0
    Dim max_wt_mb3 = 0
    Dim lst_ram As New TextBox
    Dim lst_rram As String
    Private rancon As New Random
    Dim lst_ao As New ListBox
    Dim drag As Boolean

    Dim mousex As Integer

    Dim mousey As Integer
    Private Sub MN_1_Paint(sender As Object, e As PaintEventArgs) Handles MN_1.Paint

    End Sub

    Private Sub MN_1_MouseMove(sender As Object, e As MouseEventArgs) Handles MN_1.MouseMove
        move_right()
    End Sub
    Sub move_right()
        If max_wt >= 150 Then
            ' Me.Location = New Point(Me.Location.X, Me.Location.Y - 150)
            '     Me.Width = Me.Width - 150
        Else
            MN_1.Width += 4
            max_wt += 4
            MN_3.Left += 4

        End If
    End Sub
    Dim regDate As Date = Date.Today()
    ''  Dim loc1 As New Point
    'Dim loc2 As New Point
    ' Dim loc3 As New Point
    'Dim loc4 As New Point
    ' Dim loc5 As New Point
    ' Dim loc6 As New Point
    Private Sub Home_WT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MN_1.Top = 0
        MN_3.Top = 0
        MN_3.Left = 50
        Me.Width = 638
        ' Dim files() As String = IO.Directory.GetFiles(Application.StartupPath & "\Folder_Word\")

        Dim di As DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(Application.StartupPath & "\Folder_Word\")
        For Each fi As FileInfo In di.GetFiles("*.ewd")
            lst_fd.Items.Add(fi.Name.Replace(".ewd", ""))
        Next fi
        '  MN_2.Visible = False
        lst_ram.Multiline = True
        'Home Panel
        '    txt_tv.Left = (pan_bk.Parent.Width \ 2) - (txt_tv.Width \ 2) * 2.5

        Dim folderFiles() As String = Directory.GetFiles(Application.StartupPath & "\Folder_Word\", "*.*")   'folderFiles should to be defined as a array
        If folderFiles.Length = 0 Then
            txt_tv.Text = "Hello: Xin chào"

        Else
            Dim fl_rtam As String
            Dim rc As Integer = lst_fd.Items.Count
            fl_rtam = lst_fd.Items(rancon.Next(rc)).ToString()
            int_lst_home(fl_rtam)

        End If

        If My.Settings.dd_r = regDate.ToString("MM\/dd\/yyyy") Then
            bt_dn.Enabled = False
        Else
            bt_dn.Enabled = True
        End If
        '  pn_game.Location = New Point(10, 31)
        lb_dn.Text = "Đã điểm danh " & My.Settings.dd.ToString & " ngày"
        If My.Settings.log = "yes" Then
            ck_st1.Checked = True
        Else
            ck_st1.Checked = False
        End If
        Label5.Visible = False
        lb_solan.Text = My.Settings.tudahoc
        lb_tile.Text = My.Settings.landung & "/" & My.Settings.lansai
        If My.Settings.lang_dict = "en" Then
            ckg1.Checked = True
        ElseIf My.Settings.lang_dict = "vi" Then
            ckg2.Checked = True
        End If
    End Sub
    Sub RandomColor_Game()
        Dim rand As New Random
        lb_w1.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
        lb_w2.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
        lb_w3.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
        lb_w4.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
        lb_w5.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
        lb_w6.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
    End Sub
    Sub int_lst_home(file_name As String)
        lst_ao.Items.Clear()
        Dim linek As String
        Using reader As New StreamReader(Application.StartupPath & "\Folder_Word\" & file_name & ".ewd")
            linek = reader.ReadLine()
        End Using
        lst_ram.Text = (linek)
        fr_ram.txt_ram.Text = linek
        lst_rram = SplitString(lst_ram.Text, "<data>", "</data>")
        Dim strarr() As String
        strarr = lst_rram.Split("|")
        For Each s As String In strarr
            s = StrConv(s.Replace("~", ": "), 3)
            If (s.Length < 1) Then
                txt_tv.Text = "Hello: Xin chào"
            Else
                lst_ao.Items.Add(s)
            End If
        Next
        Dim rcc As Integer = lst_ao.Items.Count
        lb_ts.Text = lst_ao.Items.Count
        txt_tv.Text = lst_ao.Items(rancon.Next(rcc)).ToString()

    End Sub
    Sub int_lst_game(file_name As String)
        lst_ao.Items.Clear()
        Dim linek As String
        Using reader As New StreamReader(Application.StartupPath & "\Folder_Word\" & file_name & ".ewd")
            linek = reader.ReadLine()
        End Using
        lst_ram.Text = (linek)
        fr_ram.txt_ram.Text = linek
        lst_rram = SplitString(lst_ram.Text, "<data>", "</data>")
        Dim strarr() As String
        strarr = lst_rram.Split("|")
        For Each s As String In strarr
            s = StrConv(s.Replace("~", ": "), 3)
            If (s.Length < 1) Then
                lb_tv_game.Text = "Hello"
            Else
                lst_ao.Items.Add(s)
            End If
        Next
        Dim rcc As Integer = lst_ao.Items.Count
        Dim tamm As String = lst_ao.Items(rancon.Next(rcc)).ToString()
        Dim txtts() As String
        txtts = tamm.Split(": ")
        If My.Settings.lang_dict = "en" Then
            lb_game_vn.Text = txtts(1)
            lb_tv_game.Text = txtts(0)
        ElseIf My.Settings.lang_dict = "vi" Then
            lb_game_vn.Text = txtts(0)
            lb_tv_game.Text = txtts(1)
        End If

    End Sub
    Private Sub Home_WT_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'If drag is set to true then move the form accordingly.

        If drag Then

            Me.Top = Windows.Forms.Cursor.Position.Y - mousey

            Me.Left = Windows.Forms.Cursor.Position.X - mousex

        End If

    End Sub


    Private Sub MN_3_Paint(sender As Object, e As PaintEventArgs) Handles MN_3.Paint

    End Sub

    Private Sub MN_3_MouseMove(sender As Object, e As MouseEventArgs) Handles MN_3.MouseMove
        move_homne()
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Sub move_homne()
        If max_wt = 0 Then

        Else
            MN_1.Width -= 4
            max_wt -= 4
            MN_3.Left -= 4
            ' Me.Width -= 4
        End If
        If max_hg = 0 Then

        Else

            max_hg -= 10
            ' MN_1.Top -= 10
            MN_3.Top -= 10
            'Me.Width -= 10
        End If

    End Sub

    Private Sub tuvung_Click(sender As Object, e As EventArgs) Handles tuvung.Click
        pn_tuvung.Visible = True
        pn_home.Visible = False
        pn_game2.Visible = False
        pn_st.Visible = False
        pn_ab.Visible = False
        reset_game()
    End Sub

    Private Sub home_Click(sender As Object, e As EventArgs) Handles home.Click
        pn_tuvung.Visible = False
        pn_game2.Visible = False
        pn_home.Visible = True
        pn_st.Visible = False
        pn_ab.Visible = False
        reset_game()
    End Sub

    Private Sub pn_tuvung_Paint(sender As Object, e As PaintEventArgs) Handles pn_tuvung.Paint

    End Sub

    Private Sub pn_tuvung_MouseMove(sender As Object, e As MouseEventArgs) Handles pn_tuvung.MouseMove
        move_homne()
    End Sub



    Private Sub lst_tuvung_MouseMove(sender As Object, e As MouseEventArgs) Handles lst_fd.MouseMove
        move_homne()

    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        add_thumuc.Show()
        add_thumuc.txt_namefd.Clear()
        add_thumuc.TopMost = True

    End Sub

    Private Sub lst_fd_DoubleClick(sender As Object, e As EventArgs) Handles lst_fd.DoubleClick
        edit_tuvung.lst_word.Items.Clear()
        edit_tuvung.Close()
        Dim line As String
        If lst_fd.Text = "" Then

        Else
            Using reader As New StreamReader(Application.StartupPath & "\Folder_Word\" & lst_fd.Text & ".ewd")
                line = reader.ReadLine()
            End Using
            lst_ram.Text = (line)
            fr_ram.txt_ram.Text = line
            lst_rram = SplitString(lst_ram.Text, "<data>", "</data>")
            Dim strarr() As String
            strarr = lst_rram.Split("|")
            For Each s As String In strarr
                s = StrConv(s.Replace("~", ": "), 3)
                If (s.Length < 1) Then

                Else
                    edit_tuvung.lst_word.Items.Add(s)
                End If
            Next
            edit_tuvung.lb_dc.Text = "\Folder_Word\" & lst_fd.Text & ".ewd"
            edit_tuvung.Show()
        End If


    End Sub

    Private Sub bt2_Click(sender As Object, e As EventArgs) Handles bt2.Click
        Dim path_del As String = Application.StartupPath & "\Folder_Word\" & lst_fd.Text & ".ewd"
        If File.Exists(path_del) = True Then
            If lst_fd.SelectedIndex >= 0 Then
                My.Computer.FileSystem.DeleteFile(path_del)
                lst_fd.Items.Remove(lst_fd.SelectedItem)
                MsgBox("Đã xóa thư mục!")
            Else
                MsgBox("Bạn chưa chọn thư mục xóa!", vbInformation, "Thông báo")
            End If
        Else
            'Tuc la ko con gi de xoa
        End If
    End Sub

    Private Sub lst_fd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_fd.SelectedIndexChanged

    End Sub

    Private Sub pn_home_Paint(sender As Object, e As PaintEventArgs) Handles pn_home.Paint

    End Sub

    Private Sub pn_home_MouseMove(sender As Object, e As MouseEventArgs) Handles pn_home.MouseMove
        move_homne()
    End Sub


    Private Sub pan_bk_MouseMove(sender As Object, e As MouseEventArgs) Handles pan_bk.MouseMove
        move_homne()
    End Sub

    Private Sub bt2_MouseMove(sender As Object, e As MouseEventArgs) Handles bt2.MouseMove
        move_homne()
    End Sub

    Private Sub bt1_MouseMove(sender As Object, e As MouseEventArgs) Handles bt1.MouseMove
        move_homne()
    End Sub

    Private Sub gr_tv_MouseMove(sender As Object, e As MouseEventArgs) Handles gr_tv.MouseMove
        move_homne()
    End Sub

    Private Sub trochoi_Click(sender As Object, e As EventArgs) Handles trochoi.Click
        pn_home.Visible = False
        pn_game2.Visible = True
        pn_tuvung.Visible = False
        pn_st.Visible = False
        pn_ab.Visible = False
        RandomColor_Game()
        If rancon.Next(0, 2).ToString() = 1 Then
            wmp.URL = Application.StartupPath & "\Sound_type\nen2.mp3"
        Else
            wmp.URL = Application.StartupPath & "\Sound_type\nen3.mp3"
        End If
        wmp.settings.volume = 55
        '  wmp.settings.setMode("Loop", True)

    End Sub

    Private Sub gr_dn_MouseMove(sender As Object, e As MouseEventArgs) Handles gr_dn.MouseMove
        move_homne()
    End Sub

    Private Sub p_1_MouseMove(sender As Object, e As MouseEventArgs)
        move_homne()
    End Sub

    Private Sub bt_dn_Click(sender As Object, e As EventArgs) Handles bt_dn.Click
        bt_dn.Enabled = False
        My.Settings.dd = My.Settings.dd + 1
        My.Settings.dd_r = regDate.ToString("MM\/dd\/yyyy")
        lb_dn.Text = "Đã điểm danh " & My.Settings.dd.ToString & " ngày"
        My.Settings.Save()
    End Sub

    Private Sub gb1_Enter(sender As Object, e As EventArgs) Handles gb1.Enter

    End Sub

    Private Sub gb1_MouseMove(sender As Object, e As MouseEventArgs) Handles gb1.MouseMove
        move_homne()
    End Sub

    Private Sub bt_dn_MouseMove(sender As Object, e As MouseEventArgs) Handles bt_dn.MouseMove
        move_homne()
    End Sub

    Private Sub lb_dn_Click(sender As Object, e As EventArgs) Handles lb_dn.Click

    End Sub

    Private Sub lb_dn_MouseMove(sender As Object, e As MouseEventArgs) Handles lb_dn.MouseMove
        move_homne()
    End Sub

    Private Sub BT_1_Click(sender As Object, e As EventArgs) Handles BT_1.Click
        End
    End Sub


    Private Sub pn_gm2_MouseMove(sender As Object, e As MouseEventArgs) Handles pn_gm2.MouseMove
        move_homne()
    End Sub


    '  Dim num As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Timer1.Interval = rancon.Next(1, 20).ToString()
        '  num = num + 20
        ' If num >= 1000 Then
        '  lb_w1.Location = loc1
        '    lb_w2.Location = loc2
        '    lb_w3.Location = loc3
        '    lb_w4.Location = loc4
        '   lb_w5.Location = loc5
        '   lb_w6.Location = loc6
        'num = 0
        ' End If
        If lb_w1.Right < 0 Then
            lb_w1.Left = pn_game2.ClientSize.Width
        Else
            lb_w1.Left -= rancon.Next(20).ToString()
            '   lb_w1.Top -= rancon.Next(-5, 5).ToString()
        End If
        If lb_w2.Right < 0 Then
            lb_w2.Left = pn_game2.ClientSize.Width
        Else
            lb_w2.Left -= rancon.Next(20).ToString()
            '   lb_w2.Top -= rancon.Next(-5, 5).ToString()
        End If
        If lb_w3.Right < 0 Then
            lb_w3.Left = pn_game2.ClientSize.Width
        Else
            lb_w3.Left -= rancon.Next(20).ToString()
            '   lb_w3.Top -= rancon.Next(-5, 5).ToString()
        End If
        If lb_w4.Right < 0 Then
            lb_w4.Left = pn_game2.ClientSize.Width
        Else
            lb_w4.Left -= rancon.Next(20).ToString()
            '   lb_w4.Top -= rancon.Next(-5, 5).ToString()
        End If
        If lb_w5.Right < 0 Then
            lb_w5.Left = pn_game2.ClientSize.Width
        Else
            lb_w5.Left -= rancon.Next(20).ToString()
            '   lb_w5.Top -= rancon.Next(-5, 5).ToString()
        End If
        If lb_w6.Right < 0 Then
            lb_w6.Left = pn_game2.ClientSize.Width
        Else
            lb_w6.Left -= rancon.Next(20).ToString()
            '  lb_w6.Top -= rancon.Next(-5, 5).ToString()
        End If
    End Sub

    Private Sub bt_game_st_Click(sender As Object, e As EventArgs) Handles bt_game_st.Click
        next_game()
        My.Settings.tudahoc += 1
        My.Settings.Save()
    End Sub
    Sub next_game()
        Dim folderFiles() As String = Directory.GetFiles(Application.StartupPath & "\Folder_Word\", "*.*")   'folderFiles should to be defined as a array
        If folderFiles.Length = 0 Then
            MsgBox("Không đủ từ vựng để chơi trò này!")
        Else
            bt_game_st.Visible = False
            '   pn_game.Enabled = True
            '   Timer1.Start()
            '  loc1 = (lb_w1.Location)
            '  loc2 = (lb_w2.Location)
            '  loc3 = (lb_w3.Location)
            '  loc4 = (lb_w4.Location)
            '  loc5 = (lb_w5.Location)
            '  loc6 = (lb_w6.Location)
            Dim fl_rtam As String
            Dim rc As Integer = lst_fd.Items.Count
            fl_rtam = lst_fd.Items(rancon.Next(rc)).ToString()
            int_lst_game(fl_rtam)
            int_w_game()
            RandomColor_Game()
        End If

    End Sub
    Sub int_w_game()
        Dim numint As String = rancon.Next(5).ToString()
        If numint = 0 Then
            lang_fl_st(lb_w1)
            int_word(lb_w2)
            int_word(lb_w3)
            int_word(lb_w4)
            int_word(lb_w5)
            int_word(lb_w6)
        ElseIf numint = 1 Then
            lang_fl_st(lb_w2)
            int_word(lb_w1)
            int_word(lb_w3)
            int_word(lb_w4)
            int_word(lb_w5)
            int_word(lb_w6)
        ElseIf numint = 2 Then
            lang_fl_st(lb_w3)
            int_word(lb_w2)
            int_word(lb_w1)
            int_word(lb_w4)
            int_word(lb_w5)
            int_word(lb_w6)
        ElseIf numint = 3 Then
            lang_fl_st(lb_w4)
            int_word(lb_w2)
            int_word(lb_w3)
            int_word(lb_w1)
            int_word(lb_w5)
            int_word(lb_w6)
        ElseIf numint = 4 Then
            lang_fl_st(lb_w5)
            int_word(lb_w2)
            int_word(lb_w3)
            int_word(lb_w4)
            int_word(lb_w1)
            int_word(lb_w6)
        ElseIf numint = 5 Then
            lang_fl_st(lb_w6)
            int_word(lb_w2)
            int_word(lb_w3)
            int_word(lb_w4)
            int_word(lb_w5)
            int_word(lb_w1)
        End If

    End Sub
    Sub lang_fl_st(anaa As Label)
        If My.Settings.lang_dict = "en" Then
            anaa.Text = lb_tv_game.Text
        ElseIf My.Settings.lang_dict = "vi" Then
            anaa.Text = lb_game_vn.Text
        End If
    End Sub
    Private Sub int_word(wordd As Label)
        Dim strarr() As String
        strarr = lst_rram.Split("|")
        For Each s As String In strarr
            s = StrConv(s.Replace("~", ": "), 3)
            If (s.Length < 1) Then
                '         lb_tv_game.Text = "Hello"
            Else
                lst_ao.Items.Add(s)
            End If
        Next
        Dim rcc As Integer = lst_ao.Items.Count
        Dim tamm As String = lst_ao.Items(rancon.Next(rcc)).ToString()
        Dim txtts() As String
        txtts = tamm.Split(": ")
        '   lb_tv_game.Text = txtts(0)
        If My.Settings.lang_dict = "en" Then
            wordd.Text = txtts(1)
        ElseIf My.Settings.lang_dict = "vi" Then
            wordd.Text = txtts(0)
        End If
        '   Dim newTop As Integer = rancon.Next(pn_game2.Height - wordd.Height)
        '    Dim newLeft As Integer = rancon.Next(pn_game2.Width - wordd.Width)
        '      wordd.Top = newTop
        '  wordd.Left = newLeft
        Dim x As Integer = rancon.Next(Me.ClientRectangle.Height - wordd.Width)
        '   Dim y As Integer = rancon.Next(Me.ClientRectangle.Height - wordd.Height)
        Dim p As New Point(x, wordd.Location.Y)
        wordd.Location = p
    End Sub

    Private Sub lb_w1_Click(sender As Object, e As EventArgs) Handles lb_w1.Click
        diemgame(lb_w1)
    End Sub
    Sub diemgame(gamelb As Label)
        If bt_game_st.Visible = True Then

        Else
            If My.Settings.lang_dict = "en" Then
                If gamelb.Text = lb_tv_game.Text Then
                    correct_game()
                Else
                    wrong_game()
                End If
            ElseIf My.Settings.lang_dict = "vi" Then
                If gamelb.Text = lb_game_vn.Text Then
                    correct_game()
                Else
                    wrong_game()
                End If
            End If


        End If
    End Sub
    Sub wrong_game()
        baohieu.Image = My.Resources.wrong_icon_70
        lb_right.Text -= 1
        My.Settings.lansai += 1
        My.Settings.Save()
        ' baohieu.BackColor = Color.Red
        My.Computer.Audio.Play(Application.StartupPath & "\Sound_type\false.wav", AudioPlayMode.WaitToComplete)
        If lb_right.Text <= 0 Then
            'lb_right.Text = 0
            lb_right.Text = 0

            If bt_game_st.Visible = True Then

            Else
                MsgBox("Game Over!", vbInformation, "eWORD")
                bt_game_st.Visible = True

            End If
        Else
            next_game()
        End If
    End Sub
    Sub correct_game()
        lb_right.Text += 1
        My.Settings.landung += 1
        My.Settings.Save()
        '  Timer1.Interval = rancon.Next(10, 50).ToString()
        '  My.Computer.Audio.Play(Application.StartupPath & "\Sound_type\true.wav",
        '     AudioPlayMode.WaitToComplete)
        If lb_right.Text >= 100 Then
            My.Computer.Audio.Play(Application.StartupPath & "\Sound_type\win.wav", AudioPlayMode.WaitToComplete)
            MsgBox("You Win!", vbInformation, "eWORD")
            reset_game()
        Else
            Dim SAPI
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.Speak(lb_tv_game.Text)
            next_game()
            baohieu.Image = My.Resources.check_40319_960_720
        End If


    End Sub
    Sub reset_game()
        lb_right.Text = 0
        baohieu.Image = Nothing
        bt_game_st.Visible = True
        lb_tv_game.Text = "Vocabulary Game"
        '   My.Computer.Audio.Stop()
        wmp.URL = ""
    End Sub
    Private Sub lb_w2_Click(sender As Object, e As EventArgs) Handles lb_w2.Click
        diemgame(lb_w2)
    End Sub

    Private Sub lb_w3_Click(sender As Object, e As EventArgs) Handles lb_w3.Click
        diemgame(lb_w3)
    End Sub

    Private Sub lb_w4_Click(sender As Object, e As EventArgs) Handles lb_w4.Click
        diemgame(lb_w4)
    End Sub

    Private Sub lb_w5_Click(sender As Object, e As EventArgs) Handles lb_w5.Click
        diemgame(lb_w5)
    End Sub

    Private Sub lb_w6_Click(sender As Object, e As EventArgs) Handles lb_w6.Click
        diemgame(lb_w6)
    End Sub

    Private Sub lb_win_Click(sender As Object, e As EventArgs) Handles lb_win.Click

    End Sub

    Private Sub lb_game_vn_Click(sender As Object, e As EventArgs) Handles lb_game_vn.Click

    End Sub

    Private Sub pn_game_Paint(sender As Object, e As PaintEventArgs) Handles pn_game.Paint

    End Sub

    Private Sub pn_game_MouseMove(sender As Object, e As MouseEventArgs) Handles pn_game.MouseMove
        '  Timer1.Start()
        move_homne()
    End Sub

    Private Sub lb_w1_MouseMove(sender As Object, e As MouseEventArgs) Handles lb_w1.MouseMove
        Timer1.Stop()
    End Sub
    Private Sub lb_w2_MouseMove(sender As Object, e As MouseEventArgs) Handles lb_w2.MouseMove
        Timer1.Stop()
    End Sub
    Private Sub lb_w3_MouseMove(sender As Object, e As MouseEventArgs) Handles lb_w3.MouseMove
        Timer1.Stop()
    End Sub
    Private Sub lb_w4_MouseMove(sender As Object, e As MouseEventArgs) Handles lb_w4.MouseMove
        Timer1.Stop()
    End Sub
    Private Sub lb_w5_MouseMove(sender As Object, e As MouseEventArgs) Handles lb_w5.MouseMove
        Timer1.Stop()
    End Sub
    Private Sub lb_w6_MouseMove(sender As Object, e As MouseEventArgs) Handles lb_w6.MouseMove
        Timer1.Stop()
    End Sub

    Private Sub bt_game_st_MouseMove(sender As Object, e As MouseEventArgs) Handles bt_game_st.MouseMove
        move_homne()
    End Sub


    Private Sub pn_game2_MouseMove(sender As Object, e As MouseEventArgs) Handles pn_game2.MouseMove
        move_homne()
    End Sub

    Private Sub home_MouseMove(sender As Object, e As MouseEventArgs) Handles home.MouseMove
        move_right()
    End Sub

    Private Sub IM_1_Click(sender As Object, e As EventArgs) Handles IM_1.Click

    End Sub

    Private Sub IM_1_MouseMove(sender As Object, e As MouseEventArgs) Handles IM_1.MouseMove
        move_right()
    End Sub

    Private Sub tuvung_MouseMove(sender As Object, e As MouseEventArgs) Handles tuvung.MouseMove
        move_right()
    End Sub

    Private Sub IM_2_Click(sender As Object, e As EventArgs) Handles IM_2.Click

    End Sub

    Private Sub IM_2_MouseMove(sender As Object, e As MouseEventArgs) Handles IM_2.MouseMove
        move_right()
    End Sub

    Private Sub trochoi_MouseMove(sender As Object, e As MouseEventArgs) Handles trochoi.MouseMove
        move_right()
    End Sub

    Private Sub IM_3_Click(sender As Object, e As EventArgs) Handles IM_3.Click

    End Sub

    Private Sub IM_3_MouseMove(sender As Object, e As MouseEventArgs) Handles IM_3.MouseMove
        move_right()
    End Sub

    Private Sub setting_Click(sender As Object, e As EventArgs) Handles setting.Click
        pn_home.Visible = False
        pn_game2.Visible = False
        pn_tuvung.Visible = False
        pn_st.Visible = True
        pn_ab.Visible = False
        reset_game()
    End Sub

    Private Sub setting_MouseMove(sender As Object, e As MouseEventArgs) Handles setting.MouseMove
        move_right()
    End Sub

    Private Sub IM_4_Click(sender As Object, e As EventArgs) Handles IM_4.Click

    End Sub

    Private Sub IM_4_MouseMove(sender As Object, e As MouseEventArgs) Handles IM_4.MouseMove
        move_right()
    End Sub

    Private Sub about_Click(sender As Object, e As EventArgs) Handles about.Click
        pn_home.Visible = False
        pn_game2.Visible = False
        pn_tuvung.Visible = False
        pn_st.Visible = False
        pn_ab.Visible = True
    End Sub

    Private Sub about_MouseMove(sender As Object, e As MouseEventArgs) Handles about.MouseMove
        move_right()
    End Sub

    Private Sub IM_5_Click(sender As Object, e As EventArgs) Handles IM_5.Click

    End Sub

    Private Sub IM_5_MouseMove(sender As Object, e As MouseEventArgs) Handles IM_5.MouseMove
        move_right()
    End Sub



    Private Sub lb_name_MouseMove(sender As Object, e As MouseEventArgs) Handles lb_name.MouseMove
        move_homne()
    End Sub

    Private Sub pn_st_Paint(sender As Object, e As PaintEventArgs) Handles pn_st.Paint

    End Sub

    Private Sub pn_st_MouseMove(sender As Object, e As MouseEventArgs) Handles pn_st.MouseMove
        move_homne()
    End Sub

    Private Sub gb_st_Enter(sender As Object, e As EventArgs) Handles gb_st.Enter

    End Sub

    Private Sub gb_st_MouseMove(sender As Object, e As MouseEventArgs) Handles gb_st.MouseMove
        move_homne()
    End Sub

    Private Sub pn_ab_Paint(sender As Object, e As PaintEventArgs) Handles pn_ab.Paint

    End Sub

    Private Sub pn_ab_MouseMove(sender As Object, e As MouseEventArgs) Handles pn_ab.MouseMove
        move_homne()
    End Sub

    Private Sub Home_WT_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        drag = True 'Sets the variable drag to true.

        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex

        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey

    End Sub

    Private Sub Home_WT_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove

    End Sub

    Private Sub MN_3_MouseDown(sender As Object, e As MouseEventArgs) Handles MN_3.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub MN_3_MouseUp(sender As Object, e As MouseEventArgs) Handles MN_3.MouseUp
        drag = False

    End Sub

    Private Sub ck_st1_CheckedChanged(sender As Object, e As EventArgs) Handles ck_st1.CheckedChanged
        Try
            Dim applicationName As String = Application.ProductName
            Dim applicationPath As String = Application.ExecutablePath
            If ck_st1.Checked = True Then
                My.Settings.log = "yes"
                My.Settings.Save()
                Dim regKey As Microsoft.Win32.RegistryKey
                regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
                regKey.SetValue(applicationName, """" & applicationPath & """")
                regKey.Close()
            ElseIf ck_st1.Checked = False Then
                My.Settings.log = "no"
                My.Settings.Save()
                Dim regKey As Microsoft.Win32.RegistryKey
                regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
                regKey.DeleteValue(applicationName, False)
                regKey.Close()
            End If


        Catch
            MsgBox("Có lỗi xảy ra không thể thêm khởi động cùng Windows!")
        End Try
    End Sub

    Private Sub pb_lg_Click(sender As Object, e As EventArgs) Handles pb_lg.Click

    End Sub

    Private Sub pb_lg_MouseMove(sender As Object, e As MouseEventArgs) Handles pb_lg.MouseMove
        move_homne()
    End Sub

    Private Sub lbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl.LinkClicked
        Dim webAddress As String = "http://trungnhan.name.vn/"
        Process.Start(webAddress)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles GroupBox1.MouseMove
        move_homne()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label6_MouseMove(sender As Object, e As MouseEventArgs) Handles Label6.MouseMove
        move_homne()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label7_MouseMove(sender As Object, e As MouseEventArgs) Handles Label7.MouseMove
        move_homne()
    End Sub

    Private Sub lbl_MouseMove(sender As Object, e As MouseEventArgs) Handles lbl.MouseMove
        move_homne()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs)
        move_homne()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Tính năng đang phát triển", vbInformation, "eWORD")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim webAddress As String = "https://www.facebook.com/groups/4it.community/"
        Process.Start(webAddress)
    End Sub

    Private Sub lg1_Click(sender As Object, e As EventArgs) Handles lg1.Click

    End Sub

    Private Sub lg1_MouseMove(sender As Object, e As MouseEventArgs) Handles lg1.MouseMove
        move_homne()
    End Sub

    Private Sub lg2_Click(sender As Object, e As EventArgs) Handles lg2.Click

    End Sub

    Private Sub lg2_MouseMove(sender As Object, e As MouseEventArgs) Handles lg2.MouseMove
        move_homne()
    End Sub

    Private Sub ckg1_CheckedChanged(sender As Object, e As EventArgs) Handles ckg1.CheckedChanged
        If ckg1.Checked = True Then
            ckg1.Checked = True
            ckg2.Checked = False
            My.Settings.lang_dict = "en"
            My.Settings.Save()
        End If
    End Sub

    Private Sub ckg2_CheckedChanged(sender As Object, e As EventArgs) Handles ckg2.CheckedChanged
        If ckg2.Checked = True Then
            ckg1.Checked = False
            ckg2.Checked = True
            My.Settings.lang_dict = "vi"
            My.Settings.Save()
        End If
    End Sub

    Private Sub GroupBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles GroupBox2.MouseMove
        move_homne()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim webAddress As String = "https://apps.4it.top/"
        Process.Start(webAddress)
    End Sub
End Class
