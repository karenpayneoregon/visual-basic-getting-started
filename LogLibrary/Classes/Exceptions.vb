Option Infer On

Imports System.IO
Imports System.Text.RegularExpressions

Namespace Classes
    ''' <summary>
    ''' Provides writing run time exceptions to a text file
    ''' </summary>
    ''' <remarks>
    ''' What's here works while there will be many modifications later on.
    ''' </remarks>
    Public Module Exceptions
        ''' <summary>
        ''' Write Exception information to UnhandledException.txt in the executable folder.
        ''' </summary>
        ''' <param name="exception">Strong typed <seealso cref="Exception"/></param>
        ''' <param name="exceptionLogType">Type of exception which determines which file to log to. Not passing this parameter will default to the general log file</param>
        Public Sub Write(exception As Exception, Optional ByVal exceptionLogType As ExceptionLogType = ExceptionLogType.General)

            Dim fileName = ""


            Select Case exceptionLogType
                Case ExceptionLogType.General
                    fileName = "GeneralUnhandledException.txt"
                Case ExceptionLogType.Data
                    fileName = "DataUnhandledException.txt"
                Case ExceptionLogType.Unknown
                    fileName = "UnknownUnhandledException.txt"
                Case ExceptionLogType.Post
                    fileName = "PostUnhandledException.txt"
                Case Else
                    Throw New NotImplementedException()
            End Select

            Try
                If File.Exists(fileName) Then
                    Dim contents = File.ReadAllText(fileName)
                    Dim current = ToLogString(exception, Environment.StackTrace)
                    Dim data = $"{contents}{Environment.NewLine}{current}{Environment.NewLine}"

                    File.WriteAllText(fileName, data)

                Else
                    File.WriteAllText(fileName, ToLogString(exception, Environment.StackTrace) & Environment.NewLine)
                End If
            Catch
                ' ignored - we are in no position to handle this other than protect the app from crashing.
            End Try
        End Sub


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
        Private Function GetStackTraceLines(stackTrace As String) As List(Of String)
            Return stackTrace.Split({Environment.NewLine}, StringSplitOptions.None).ToList()
        End Function

        ''' <summary>
        '''  Gets a list of stack frame lines, as strings, only including those for which line number is known.
        ''' </summary>
        ''' <param name="fullStackTrace">Full stack trace, including external code.</param>
        ''' <returns>Stack trace lines</returns>
        Private Function GetUserStackTraceLines(fullStackTrace As String) As List(Of String)

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
