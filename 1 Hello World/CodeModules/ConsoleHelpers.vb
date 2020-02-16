Namespace CodeModules
    Module ConsoleHelpers
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
    End Module

End Namespace