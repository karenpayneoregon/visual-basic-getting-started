Imports System
Imports GroupByVehicle.Classes

Module Program
    Sub Main(args As String())
        Dim originalForegroundColor = Console.ForegroundColor
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("LINQ GroupBy Manufacturer ThenBy Year")
        Console.ForegroundColor = originalForegroundColor

        VehicleExamples.GroupByManufacturerThenByYear()
        Console.ForegroundColor = ConsoleColor.White

        Console.WriteLine("Lambda GroupBy Manufacturer OrderBy-Manufacturer")
        Console.ForegroundColor = originalForegroundColor
        VehicleExamples.GroupByManufacturerOrderByManufacturer()

        Console.ForegroundColor = originalForegroundColor
        Console.WriteLine("Press a key to quit")
        Console.ReadLine()
    End Sub
End Module
