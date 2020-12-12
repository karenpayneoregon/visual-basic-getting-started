Option Infer On

Imports System
Imports System.ComponentModel
Imports System.Windows.Forms

''' <summary>
''' TextBox which only accepts numeric values along with asserting data copied from the Windows Clipboard
''' </summary>
Public Class NumericTextBox
    Inherits TextBox

    Private WM_KEYDOWN As Integer = &H100
    Private WM_PASTE As Integer = &H302
    ''' <summary>
    ''' Handle key presses for non numeric data
    ''' </summary>
    ''' <param name="msg">Window message</param>
    ''' <returns>bool from base</returns>
    Public Overrides Function PreProcessMessage(ByRef msg As Message) As Boolean
        If msg.Msg = WM_KEYDOWN Then
            Dim keys As Keys = CType(msg.WParam.ToInt32(), Keys)

            Dim numbers As Boolean = ((keys >= Keys.D0 AndAlso keys <= Keys.D9) OrElse
                                      (keys >= Keys.NumPad0 AndAlso keys <= Keys.NumPad9)) AndAlso
                                     ModifierKeys <> Keys.Shift

            Dim ctrl As Boolean = keys = Keys.Control

            Dim ctrlZ As Boolean = keys = Keys.Z AndAlso ModifierKeys = Keys.Control,
                ctrlX As Boolean = keys = Keys.X AndAlso ModifierKeys = Keys.Control, ctrlC As Boolean = keys = Keys.C AndAlso
                    ModifierKeys = Keys.Control, ctrlV As Boolean = keys = Keys.V AndAlso
                    ModifierKeys = Keys.Control, del As Boolean = keys = Keys.Delete,
                bksp As Boolean = keys = Keys.Back, arrows As Boolean = (keys = Keys.Up) Or (keys = Keys.Down) Or
                                                                        (keys = Keys.Left) Or (keys = Keys.Right)

            If numbers Or ctrl Or del Or bksp Or arrows Or ctrlC Or ctrlX Or ctrlZ Then
                Return False

            ElseIf ctrlV Then
                ' handle pasting from clipboard
                Dim clipboardData = Clipboard.GetDataObject()
                Dim input = DirectCast(clipboardData.GetData(GetType(String)), String)
                For Each character In input
                    If Not Char.IsDigit(character) Then
                        Return True
                    End If
                Next character
                Return False
            Else
                Return True
            End If
        Else
            Return MyBase.PreProcessMessage(msg)
        End If
    End Function

    <Browsable(False)>
    Public ReadOnly Property AsInteger() As Integer
        Get
            Dim value As Integer
            If Integer.TryParse(Text, value) Then
                Return value
            Else
                Return 0
            End If
        End Get
    End Property
    ''' <summary>
    ''' Monitor for non-numeric pasted from clipboard
    ''' </summary>
    ''' <param name="m">Windows message <see cref="Message"/></param>
    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_PASTE Then
            Dim clipboardData = Clipboard.GetDataObject()
            Dim input = CStr(clipboardData?.GetData(GetType(String)))
            For Each character In input
                If Not Char.IsDigit(character) Then
                    m.Result = New IntPtr(0)
                    Return
                End If
            Next character
        End If

        MyBase.WndProc(m)

    End Sub
End Class