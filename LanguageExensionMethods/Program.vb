Imports System
Imports System.Globalization
''' <summary>
''' TODO This needs to be refactored so code is clear which it's not now.
''' </summary>
Module Program
    Sub Main(args As String())
        Dim originalForegroundColor = Console.ForegroundColor

        '
        ' Create a string array of month names using .IsNullOrWhiteSpace() extension method
        '
        Dim monthNames = (
                From monthName In CultureInfo.CurrentCulture.DateTimeFormat.MonthNames
                Where Not monthName.IsNullOrWhiteSpace()).ToArray

        Console.ForegroundColor = ConsoleColor.Yellow
        '
        ' Join by comma, last separator "and" via 
        ' .JoinWithLastSeparator() extension method
        '
        Console.WriteLine("Month names joined by comma and last separator 'and'")
        Console.ForegroundColor = originalForegroundColor
        Console.WriteLine(monthNames.JoinWithLastSeparator())
        Console.WriteLine()

        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("SplitCamelCase extension example")
        Console.ForegroundColor = originalForegroundColor
        Dim combinedMonthNames = String.Join("", monthNames)
        Console.WriteLine(combinedMonthNames)
        Console.WriteLine(combinedMonthNames.SplitCamelCase)

        Console.WriteLine()

        Dim dates = Enumerable.Range(1, 10).Select(Function(index) DateTime.Now.AddDays(index)).ToList()

        Dim lowDate = Date.Now.AddDays(1)
        Dim middleDate = Date.Now.AddDays(3)
        Dim highDate = Date.Now.AddDays(5)

        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Date between")
        Console.ForegroundColor = originalForegroundColor
        If middleDate.Between(lowDate, highDate) Then
            Console.WriteLine($"{middleDate.ToShortDateString()} is between {lowDate.ToShortDateString()} and {highDate.ToShortDateString()}")
        Else
            Console.WriteLine($"{middleDate.ToShortDateString()} is not between {lowDate.ToShortDateString()} and {highDate.ToShortDateString()}")
        End If

        middleDate = middleDate.AddDays(20)
        If middleDate.Between(lowDate, highDate) Then
            Console.WriteLine($"{middleDate.ToShortDateString()} is between {lowDate.ToShortDateString()} and {highDate.ToShortDateString()}")
        Else
            Console.WriteLine($"{middleDate.ToShortDateString()} is not between {lowDate.ToShortDateString()} and {highDate.ToShortDateString()}")
        End If

        Console.WriteLine()

        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Integer between")
        Console.ForegroundColor = originalForegroundColor

        Dim lowNumber = 10
        Dim middleNumber = 11
        Dim highNumber = 12


        If middleNumber.Between(lowNumber, highNumber) Then
            Console.WriteLine($"{middleNumber} is between {lowNumber} and {highNumber}")
        Else
            Console.WriteLine($"{middleNumber} is not between {lowNumber} and {highNumber}")
        End If

        middleNumber = 20
        If middleNumber.Between(lowNumber, highNumber) Then
            Console.WriteLine($"{middleNumber} is between {lowNumber} and {highNumber}")
        Else
            Console.WriteLine($"{middleNumber} is not between {lowNumber} and {highNumber}")
        End If

        Console.ReadLine()
    End Sub
End Module
