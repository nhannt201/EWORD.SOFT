Module Modun
    Public Function SplitString(ByVal mainString As String, ByVal BeginString As String, ByVal EndString As String) As String
        Dim i_s As Integer : i_s = InStr(mainString, BeginString)
        Dim i_e As Integer : i_e = InStr(mainString, EndString)
        On Error Resume Next
        If i_s <> -1 And i_e <> -1 Then
            Dim s As String

            s = Mid(mainString, i_s + Len(BeginString), i_e - i_s - Len(BeginString))
            SplitString = s

        Else
            SplitString = ""
        End If
    End Function
    Private ReadOnly VietnameseSigns As String() = New String() {"aAeEoOuUiIdDyY", "áàạảãâấầậẩẫăắằặẳẵ", "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ", "éèẹẻẽêếềệểễ", "ÉÈẸẺẼÊẾỀỆỂỄ", "óòọỏõôốồộổỗơớờợởỡ",
                                                                            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ", "úùụủũưứừựửữ", "ÚÙỤỦŨƯỨỪỰỬỮ", "íìịỉĩ", "ÍÌỊỈĨ", "đ",
                                                                            "Đ", "ýỳỵỷỹ", "ÝỲỴỶỸ"}

    Public Function RemoveSign4VietnameseString(ByVal str As String) As String
        For i As Integer = 1 To VietnameseSigns.Length - 1
            For j As Integer = 0 To VietnameseSigns(i).Length - 1
                str = str.Replace(VietnameseSigns(i)(j), VietnameseSigns(0)(i - 1))
            Next
        Next
        Return str
    End Function

End Module
