Imports System.Text.RegularExpressions

Namespace Modules
    ''' <summary>
    '''  Extension methods for Exception class.
    ''' </summary>
    Public Module ExceptionExtensions
        ''' <summary>
        '''  Provides full stack trace for the exception that occurred.
        ''' </summary>
        ''' <param name="exception">Exception object.</param>
        ''' <param name="environmentStackTrace">Environment stack trace, for pulling additional stack frames.</param>
        ''' <returns>Formatted exception with stack trace</returns>
        <System.Runtime.CompilerServices.Extension>
        Public Function ToLogString(exception As Exception, environmentStackTrace As String) As String

            Dim environmentStackTraceLines = GetUserStackTraceLines(environmentStackTrace)
            environmentStackTraceLines.RemoveAt(0)

            Dim stackTraceLines = GetStackTraceLines(exception.StackTrace)
            stackTraceLines.AddRange(environmentStackTraceLines)

            Dim fullStackTrace = String.Join(Environment.NewLine, stackTraceLines)

            Return exception.Message & Environment.NewLine & fullStackTrace

        End Function

        ''' <summary>
        '''  Gets a list of stack frame lines, as strings.
        ''' </summary>
        ''' <param name="stackTrace">Stack trace string.</param>
        ''' <returns>Stack trace lines</returns>
        Private Function GetStackTraceLines(ByVal stackTrace As String) As List(Of String)
            Return stackTrace.Split({Environment.NewLine}, StringSplitOptions.None).ToList()
        End Function
        ''' <summary>
        '''  Gets a list of stack frame lines, as strings, only including those for which line number is known.
        ''' </summary>
        ''' <param name="fullStackTrace">Full stack trace, including external code.</param>
        ''' <returns>Stack trace lines</returns>
        Private Function GetUserStackTraceLines(ByVal fullStackTrace As String) As List(Of String)

            Dim outputList = New List(Of String)()
            Dim regex As New Regex("([^\)]*\)) in (.*):line (\d)*$")

            Dim stackTraceLines As List(Of String) = GetStackTraceLines(fullStackTrace)

            For Each stackTraceLine In stackTraceLines
                If Not regex.IsMatch(stackTraceLine) Then
                    Continue For
                End If

                outputList.Add(stackTraceLine)
            Next stackTraceLine

            Return outputList

        End Function
    End Module
End Namespace
