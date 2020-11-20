Imports System.Runtime.CompilerServices

Public Module ControlExtensions
    <Extension>
    Public Function InvokeIfRequired(Of T As Control)(control As T, action As Action(Of T)) As IAsyncResult

        If control.InvokeRequired Then
            Try

                Return control.BeginInvoke(New Action(Of T, Action(Of T))(AddressOf InvokeIfRequired), New Object() {control, action})

            Catch ex As Exception

                Return Nothing

            End Try
        Else

            action(control)
            Return Nothing

        End If

    End Function
End Module