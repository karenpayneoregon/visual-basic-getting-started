Imports MyApplicationNamespace.Singletons

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        ''' <summary>
        ''' Property to get command arguments minus argument 0 which is the
        ''' path and executable name
        ''' </summary>
        ''' <returns>Command arguments if present</returns>
        ''' <remarks>
        ''' C# version
        ''' https://github.com/karenpayneoregon/code-samples-csharp/blob/master/CommandLineArguments/ApplicationHelper.cs
        ''' </remarks>
        Public ReadOnly Property CommandLineArguments As String()
            Get
                Dim arguments = Environment.GetCommandLineArgs.ToList().Select(Function(arg) arg.ToUpper()).ToList()
                arguments.RemoveAt(0)
                Return arguments.ToArray()
            End Get
        End Property
        ''' <summary>
        ''' Determine if admin mode was requested
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property AdminMode() As Boolean
            Get
                If HasCommandLineArguments Then
                    Return CommandLineArguments.Contains("-ADMIN")
                Else
                    Return False
                End If
            End Get
        End Property
        ''' <summary>
        ''' Used to get command argument count
        ''' </summary>
        ''' <returns>Count of command arguments sent on startup of application</returns>
        Public ReadOnly Property HasCommandLineArguments As Boolean
            Get
                Return CommandLineArguments.Length > 0
            End Get
        End Property
        ''' <summary>
        ''' Access Singleton but not used as we simple have to type more, go figure that
        ''' some may want this.
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Reference() As ReferenceIncrementer
    End Class
End Namespace