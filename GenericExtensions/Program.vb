Imports System
Imports System.Runtime.InteropServices
Imports StandardLibrary1


Module Program
    Sub Main(args As String())
        Dim stringArrayMixedTypesIntegers() As String = {"2", "4B", Nothing, "6", "8A", "", "1.3", "Mike", "-1"}
        Dim expectedIntegerValues() As Integer? = {2, 6, -1}

        Dim nullableIntegerResults =
                (
                    From item In stringArrayMixedTypesIntegers
                    Select value = item.ToNullable(Of Integer)
                    Where value.HasValue
                ).ToList()

        Console.WriteLine("String array to ToNullable Integer")
        Console.WriteLine(nullableIntegerResults.SequenceEqual(expectedIntegerValues))

        Dim stringArrayMixedTypesDouble() As String = {"2.4", "4.8'", Nothing, "6.9", "[8.5]", "", "1.3", "Karen", "1"}
        Dim expectedDoubleValues() As Double? = {2.4, 6.9, 1.3, 1}
        Dim nullableDoubleResults =
                (
                    From item In stringArrayMixedTypesDouble
                    Select value = item.ToNullable(Of Double)
                    Where value.HasValue
                ).ToList()

        Console.WriteLine()
        Console.WriteLine("String array to ToNullable Double")
        Console.WriteLine(nullableDoubleResults.SequenceEqual(expectedDoubleValues))

        Console.ReadLine()

    End Sub
End Module
Public Class Person
    Public Property FirstName() As String
    Public Property LastName() As String
End Class

