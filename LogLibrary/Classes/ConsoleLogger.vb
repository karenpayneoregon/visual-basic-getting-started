Namespace Classes

    Public Class ConsoleLogger
        Implements ILogger
        Public Property FileName As String Implements ILogger.FileName

        Public Sub LogWarning(message As String) Implements ILogger.LogWarning
            Log(LogLevel.Warning, message)
        End Sub

        Public Sub LogError(message As String) Implements ILogger.LogError
            Log(LogLevel.Errors, message)
        End Sub

        Public Sub LogGeneral(message As String) Implements ILogger.LogGeneral
            Log(LogLevel.General, message)
        End Sub

        Public Sub Log(level As LogLevel, message As String) Implements ILogger.Log
            Console.WriteLine($"{level}, {message}")
        End Sub
    End Class
End Namespace