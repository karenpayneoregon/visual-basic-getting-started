Imports System.Runtime.InteropServices
Imports System.Windows.Forms


Public Module CueBannerTextCode
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> lParam As String) As Int32
    End Function
    Private Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (hWnd1 As IntPtr, hWnd2 As IntPtr, lpsz1 As String, lpsz2 As String) As IntPtr
    Private Const EM_SETCUEBANNER As Integer = &H1501

    Public Sub SetCueText(control As Control, text As String)

        If TypeOf control Is ComboBox Then
            Dim editHWnd As IntPtr = FindWindowEx(control.Handle, IntPtr.Zero, "Edit", Nothing)
            If Not editHWnd = IntPtr.Zero Then
                SendMessage(editHWnd, EM_SETCUEBANNER, 0, text)
            End If
        ElseIf TypeOf control Is TextBox Then
            SendMessage(control.Handle, EM_SETCUEBANNER, 0, text)
        End If
    End Sub

End Module