Imports Classes

Public Interface ILogger
    Property FileName() As String
    Sub LogWarning(message As String)
    Sub LogError(message As String)
    Sub LogGeneral(message As String)
    Sub Log(ByVal level As LogLevel, ByVal message As String)
End Interface