Imports ExceptionLibrary

Module Program
    Sub Main(args As String())

        Dim originalForegroundColor = Console.ForegroundColor

        Dim inputValue = "Hello"


        Console.ForegroundColor = ConsoleColor.White

        Dim numberResult1 = Demo.Example1(inputValue)
        Console.WriteLine("Example1")
        Console.ForegroundColor = originalForegroundColor

        If numberResult1.HasValue Then
            Console.WriteLine($"{vbTab}{inputValue} was returned as {numberResult1}")
        Else
            Console.WriteLine($"{vbTab}{inputValue} is not a valid integer")
        End If

        Console.WriteLine()

        Dim numberResult2 = Demo.Example2(inputValue)
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Example2")
        Console.ForegroundColor = originalForegroundColor

        If Demo.IsSuccessFul Then
            Console.WriteLine($"{vbTab}{inputValue} was returned as {numberResult2}")
        Else
            Console.WriteLine($"{vbTab}{inputValue} error: {Demo.LastExceptionMessage}")
        End If

        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Example3")
        Console.ForegroundColor = originalForegroundColor

        Dim numberResult3 As (Result As Integer, Message As String) = Demo.Example3(inputValue)
        If String.IsNullOrWhiteSpace(numberResult3.Message) Then
            Console.WriteLine($"{vbTab}{numberResult3.Result} is valid Integer")
        Else
            Console.WriteLine($"{vbTab}{inputValue} failed with {numberResult3.Message}")
        End If

        Console.ReadLine()

    End Sub
End Module
Public Class Demo
    Inherits BaseExceptionsHandler

    Public Shared Function Example1(sender As Object) As Integer?

        Dim result As Integer = Nothing

        Try
            Return CInt(sender)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Shared Function Example2(sender As Object) As Integer

        ThisHasException = False

        Try
            Return CInt(sender)
        Catch ex As Exception
            ThisHasException = True
            TheLastException = ex
            Return Nothing
        End Try

    End Function
    Public Shared Function Example3(sender As String) As (Result As Integer, Message As String)

        Dim result As Integer = Nothing

        If Integer.TryParse(sender, result) Then
            Return (result, "")
        Else
            Return (result, $"Failed to convert {sender} to Integer")
        End If

    End Function
End Class
