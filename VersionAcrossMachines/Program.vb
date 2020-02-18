Imports System

Module Program
    Sub Main(args As String())

        Dim index = GetType(Program).Assembly.Location.LastIndexOf("\", StringComparison.Ordinal)
        Console.WriteLine($"AppDomain.CurrentDomain.BaseDirectory: {AppDomain.CurrentDomain.BaseDirectory}")
        Console.WriteLine($"             AppContext.BaseDirectory: {AppContext.BaseDirectory}")
        Console.WriteLine($"                    Assembly.Location: {GetType(Program).Assembly.Location.Substring(0, index)}")
        Console.ReadLine()
    End Sub
End Module
