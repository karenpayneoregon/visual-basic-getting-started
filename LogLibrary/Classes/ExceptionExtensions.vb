Namespace Classes
    ''' <summary>
    ''' Helper methods for logging exceptions
    ''' </summary>
    Public Module ExceptionExtensions
        ''' <summary>
        ''' Get InnerException if there is one as text.
        ''' </summary>
        ''' <param name="e"></param>
        ''' <param name="result"></param>
        ''' <returns></returns>
        <System.Runtime.CompilerServices.Extension>
        Public Function GetExceptionMessages(e As Exception, Optional ByVal result As String = "") As String
            Try
                If e Is Nothing Then
                    Return String.Empty
                End If

                If String.IsNullOrWhiteSpace(result) Then
                    result = e.Message
                End If

                If e.InnerException IsNot Nothing Then
                    result &= $": InnerException: {e.InnerException.GetExceptionMessages()}"
                End If

                Return result
            Catch ex As Exception
                Return $"Failure in ExceptionExtensions.GetExceptionMessages: [{ex.Message}]"
            End Try
        End Function
    End Module
End Namespace