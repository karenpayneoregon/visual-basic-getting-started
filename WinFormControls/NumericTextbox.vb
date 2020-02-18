Imports System.ComponentModel
Imports System.Windows.Forms

Public Class NumericTextbox
    Inherits TextBox

    Const WM_PASTE As Integer = &H302
    <Browsable(False)>
    Public ReadOnly Property AsDouble As Double
        Get
            If String.IsNullOrWhiteSpace(Text) Then
                Return 0
            Else
                Return CDbl(Text)
            End If
        End Get
    End Property
    Public ReadOnly Property AsDecimal As Decimal
        Get
            If String.IsNullOrWhiteSpace(Text) Then
                Return 0
            Else
                Return CDec(Text)
            End If
        End Get
    End Property
    Public ReadOnly Property AsInteger As Integer
        Get
            If String.IsNullOrWhiteSpace(Text) Then
                Return 0
            Else
                Return CInt(Text)
            End If
        End Get
    End Property
    Public ReadOnly Property IsInteger As Boolean
        Get
            If Integer.TryParse(Text, Nothing) Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property
    Protected Overrides Sub OnKeyPress(ByVal e As KeyPressEventArgs)
        Dim value As String = Text
        value = value.Remove(SelectionStart, SelectionLength)
        value = value.Insert(SelectionStart, e.KeyChar)

        e.Handled = value.LastIndexOf("-", StringComparison.Ordinal) > 0 Or Not (Char.IsControl(e.KeyChar) OrElse
            Char.IsDigit(e.KeyChar) OrElse (e.KeyChar = "."c And Not Text.Contains(".") Or
            e.KeyChar = "."c And MyBase.SelectedText.Contains(".")) OrElse
            (e.KeyChar = "-"c And SelectionStart = 0))

        MyBase.OnKeyPress(e)

    End Sub
    Protected Overrides Sub WndProc(ByRef m As Message)

        If m.Msg = WM_PASTE Then

            Dim value As String = Text

            value = value.Remove(SelectionStart, SelectionLength)
            value = value.Insert(SelectionStart, Clipboard.GetText)

            Dim result As Decimal = 0
            If Not Decimal.TryParse(value, result) Then
                Return
            End If

        End If

        MyBase.WndProc(m)

    End Sub
End Class