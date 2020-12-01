Imports System.ComponentModel
Imports System.Globalization

Namespace Controls
    ''' <summary>
    ''' * Suppress beep on ENTER key pressed
    ''' * Provides ability to title case text
    ''' </summary>
    Public Class NoBeepTitleCaseTextBox
        Inherits TextBox

        Public Delegate Sub TriggerDelegate()
        ''' <summary>
        ''' Subscribe to be notified when ENTER was pressed.
        ''' </summary>
        Public Event TriggerEvent As TriggerDelegate
        Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
            If e.KeyCode = Keys.Enter Then

                e.Handled = True
                e.SuppressKeyPress = True

                If ToTitleCase Then
                    HandleCasing()
                End If


                TriggerEventEvent?.Invoke()

                Return

            End If

            MyBase.OnKeyDown(e)
        End Sub
        ''' <summary>
        ''' Use to transform .Text to title case.
        ''' </summary>
        Private Sub HandleCasing()

            If useTitleCase Then
                Dim textInfo As TextInfo = (New CultureInfo("en-US", False)).TextInfo

                If uppercaseOption Then
                    Text = Text.ToLower()
                End If

                Text = textInfo.ToTitleCase(Text)
                SelectionStart = Text.Length
                SelectionLength = 0
            End If

        End Sub

        Private useTitleCase As Boolean
        Private uppercaseOption As Boolean
        <Browsable(True)>
        <Category("Extended Properties")>
        <Description("Set text to title case")>
        <DisplayName("ToTitleCase")>
        Public Property ToTitleCase() As Boolean
            Get
                Return useTitleCase
            End Get
            Set
                useTitleCase = Value
            End Set
        End Property
        <Browsable(True)>
        <Category("Extended Properties")>
        <Description("Override casing when all text may be uppercased")>
        <DisplayName("OverrideUpperCased")>
        Public Property OverrideUpperCased() As Boolean
            Get
                Return uppercaseOption
            End Get
            Set
                uppercaseOption = Value
            End Set
        End Property
        ''' <summary>
        ''' We can not trap TAB in OnKeyDown so handle it here
        ''' then permit default via MyBase.ProcessCmdKey
        ''' </summary>
        ''' <param name="msg"></param>
        ''' <param name="keyData"></param>
        ''' <returns></returns>
        Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
            If keyData = Keys.Tab Then
                If ToTitleCase Then
                    HandleCasing()
                End If
            End If

            Return MyBase.ProcessCmdKey(msg, keyData)

        End Function
    End Class
End Namespace