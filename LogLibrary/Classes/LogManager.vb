Imports System
Imports System.IO
Imports System.Linq

Namespace Classes
    Public Class LogManager
        Implements ILogger

        ''' <summary>
        ''' File name to write information into
        ''' </summary>
        Public Property FileName() As String Implements ILogger.FileName

        Public Sub LogWarning(message As String) Implements ILogger.LogWarning
            Log(LogLevel.Warning, message)
        End Sub

        Public Sub LogError(message As String) Implements ILogger.LogError
            Log(LogLevel.Errors, message)
        End Sub

        Public Sub LogGeneral(message As String) Implements ILogger.LogGeneral
            Log(LogLevel.General, message)
        End Sub

        ''' <summary>
        ''' Create or append level and message along with date-time stamp
        ''' </summary>
        ''' <param name="level">Type</param>
        ''' <param name="message">Text to write</param>
        Public Sub Log(ByVal level As LogLevel, ByVal message As String) Implements ILogger.Log
            If String.IsNullOrWhiteSpace(FileName) Then
                FileName = "ApplicationLog.csv"
            End If

            Try
                If File.Exists(FileName) Then
                    Dim contents = File.ReadAllLines(FileName).ToList()
                    contents.Add($"{DateTime.Now},{level},{message}")
                    File.WriteAllLines(FileName, contents.ToArray())
                Else
                    File.WriteAllText(FileName, $"{DateTime.Now},{level},{message}")
                End If
            Catch e As Exception
                Exceptions.Write(e)
            End Try
        End Sub
    End Class
End Namespace
