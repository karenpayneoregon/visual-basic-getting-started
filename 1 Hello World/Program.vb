Imports System
Imports _1_Hello_World.CodeModules
Module Program
    Sub Main(args As String())
        '
        ' Display the text Hello World! to the console window
        '
        Console.WriteLine("Hello World!")
        '
        ' Wait two seconds before clearing the console window
        '
        ConsoleReadLineWithTimeout(TimeSpan.FromSeconds(2))
        Console.Clear()
        '
        ' Wait one second before displaying Goodbye!!! to the console window
        '
        ConsoleReadLineWithTimeout()
        Console.WriteLine("Goodbye!!!")
        '
        ' Wait two seconds, then terminate the console application
        '
        ConsoleReadLineWithTimeout(TimeSpan.FromSeconds(2))

    End Sub
End Module
