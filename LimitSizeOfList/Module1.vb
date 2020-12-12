Module Module1

    Sub Main()
        Console.ReadLine()

    End Sub

    Sub Example1()
        Dim originalColor = Console.ForegroundColor

        Dim StackData1 As New FixedSizeStack(5)


        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Adding")
        Console.ForegroundColor = originalColor
        For index As Integer = 0 To 9
            StackData1.Push(index + 1)
        Next index

        Console.WriteLine()


        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Items in StackData")
        Console.ForegroundColor = originalColor

        Dim results = StackData1.OfType(Of Integer)().OrderBy(Function(x) x).ToList()
        For Each result As Integer In results
            Console.WriteLine(result)
        Next

        Dim StackData2 As New FixedSizeStack(3)
        StackData2.Push("A")
        StackData2.Push("B")
        StackData2.Push("C")
        StackData2.Push("D")
        StackData2.Push("E")
        StackData2.Push("F")
        StackData2.Push("G")


        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Items in StackData2")
        Console.ForegroundColor = originalColor

        Dim results1 = StackData2.OfType(Of String).Reverse().ToList()

        For Each result As String In results1
            Console.WriteLine(result)
        Next


    End Sub

End Module