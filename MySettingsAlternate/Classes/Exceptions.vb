Option Infer On

Imports System
Imports System.IO
Imports MySettingsAlternate.Modules

Namespace Classes
    ''' <summary>
    ''' Provides writing run time exceptions to a text file
    ''' </summary>
    Public Module Exceptions
        ''' <summary>
        ''' Write Exception information to UnhandledException.txt in the executable folder.
        ''' </summary>
        ''' <param name="exception">Strong typed <seealso cref="Exception"/></param>
        Public Sub Write(exception As Exception)
            Dim fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UnhandledException.txt")
            If File.Exists(fileName) Then
                Dim contents = File.ReadAllText(fileName)
                Dim current = exception.ToLogString(Environment.StackTrace)
                Dim data = $"{contents}{Environment.NewLine}{current}{Environment.NewLine}"
                File.WriteAllText(fileName, data)
            Else
                File.WriteAllText(fileName, exception.ToLogString(Environment.StackTrace) & Environment.NewLine)
            End If
        End Sub
    End Module
End Namespace
