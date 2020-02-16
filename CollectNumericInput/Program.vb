Imports System
Imports ConsoleHelperLibrary
Module Program
    Sub Main(args As String())

        Dim decimalValue As Decimal
        Dim stringValue As String
        Dim originalForegroundColor = Console.ForegroundColor

        Do While True

            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Yellow

            WriteText("Press ENTER without a value to exit", 0, 0, False)

            Console.ForegroundColor = originalForegroundColor

            WriteText("Enter a decimal value ", 0, 1, False)

            stringValue = Console.ReadLine()

            If Not String.IsNullOrWhiteSpace(stringValue) Then

                If Decimal.TryParse(stringValue, decimalValue) Then
                    Console.WriteLine($"You entered {decimalValue:N2}, press ENTER to try again")
                Else
                    Console.WriteLine($"The value {stringValue} can not be converted to a Decimal, press ENTER to try again.")
                End If

            Else
                Exit Do
            End If

            Console.ReadLine()

        Loop

    End Sub
End Module
