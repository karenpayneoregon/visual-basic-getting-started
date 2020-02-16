''' <summary>
''' Provides reusable code for one or more projects
''' </summary>
''' <remarks>
''' By default when creating a new code module their modifier is
''' private which means they are only visible in the current project
''' so to allow code to be exposed to projects which reference this
''' project the modifier must be Public.
''' </remarks>
Public Module ConsoleHelpers
    ''' <summary>
    ''' Provides an enhanced Console.ReadLine with a time out.
    ''' </summary>
    ''' <param name="timeout">Timeout</param>
    ''' <returns>Input from a Task or if no input an empty string</returns>
    ''' <remarks>
    ''' Example, wait for two seconds
    ''' ConsoleReadLineWithTimeout(TimeSpan.FromSeconds(2.5))
    ''' 
    ''' Example, use default, wait for one second
    ''' ConsoleReadLineWithTimeout(TimeSpan.FromSeconds())
    ''' 
    ''' For more on working with TimeSpan
    ''' https://docs.microsoft.com/en-us/dotnet/api/system.timespan?view=netframework-4.8
    ''' 
    ''' </remarks>
    Public Function ConsoleReadLineWithTimeout(Optional timeout? As TimeSpan = Nothing) As String

        Dim timeSpan As TimeSpan = If(timeout, TimeSpan.FromSeconds(1))
        Dim task As Task(Of String) = Threading.Tasks.Task.Factory.StartNew(AddressOf Console.ReadLine)
        Dim result As String = If(Threading.Tasks.Task.WaitAny(New Task() {task}, timeSpan) = 0, task.Result, String.Empty)

        Return result

    End Function
    ''' <summary>
    ''' Write a string to a specific location on the screen
    ''' </summary>
    ''' <param name="value">String to print usually "*" or "@"</param>
    ''' <param name="positionLeft">The x position,  This is modulo divided by the window.width, which allows large numbers, ie feel free to call with large loop counters</param>
    ''' <param name="positionTop"></param>
    ''' <param name="restorePosition">Move to original position prior to calling this procedure</param>
    Sub WriteText(value As String, positionLeft As Integer, Optional ByVal positionTop As Integer = 1, Optional ByVal restorePosition As Boolean = True)

        Dim originalRow As Integer = Console.CursorTop
        Dim originalCol As Integer = Console.CursorLeft

        Dim width As Integer = Console.WindowWidth


        Try

            positionLeft = positionLeft Mod width

            Console.SetCursorPosition(positionLeft, positionTop)
            Console.Write(value)

            If restorePosition Then
                Console.SetCursorPosition(originalRow, originalCol)
            End If

        Catch e1 As Exception
            Console.Write(value)
        End Try
    End Sub

End Module
