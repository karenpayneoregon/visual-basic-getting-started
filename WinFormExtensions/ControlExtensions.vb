Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Module ControlExtensions
    <Extension>
    Public Sub InvokeIfRequired(control As Control, action As Action(Of Control))
        If control.InvokeRequired Then
            control.Invoke(New Action(Sub() action(control)))
        Else
            action(control)
        End If
    End Sub
End Module

