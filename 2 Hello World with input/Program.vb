Imports System
Imports ConsoleHelperLibrary
Module Program
    Sub Main(args As String())

        Console.Write("Enter your first name: ")
        Console.SetCursorPosition(12, 0)
        Dim firstName = Console.ReadLine()

        If Not String.IsNullOrWhiteSpace(firstName) Then
            Console.WriteLine($"Hello {firstName}")
            Console.ReadLine()
        Else
            Console.WriteLine("Hello John Doe")
            ConsoleReadLineWithTimeout(TimeSpan.FromSeconds(2.5))
        End If

    End Sub


End Module
