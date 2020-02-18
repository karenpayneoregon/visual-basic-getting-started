Public Module ExceptionExtensions
    ''' <summary>
    ''' Get InnerException if there is one as text.
    ''' </summary>
    ''' <param name="exception"></param>
    ''' <param name="result"></param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension>
    Public Function GetExceptionMessages(exception As Exception, Optional ByVal result As String = "") As String

        If exception Is Nothing Then
            Return String.Empty
        End If

        If String.IsNullOrWhiteSpace(result) Then
            result = exception.Message
        End If

        If exception.InnerException IsNot Nothing Then
            result &= $": InnerException: {GetExceptionMessages(exception.InnerException)}"
        End If

        Return result
    End Function
End Module