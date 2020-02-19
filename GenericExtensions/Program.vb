Imports System
Imports System.Runtime.InteropServices
Imports System.Text
Imports StandardLibrary1

''' <summary>
''' TODO separate out examples and document code and extensions.
''' </summary>
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

        Console.WriteLine()
        Dim sb As New StringBuilder
        Dim random As New Random
        Dim randomNumberList = Enumerable.Range(1, 40).OrderBy(Function(n) random.Next(0, 100)).ToList()
        Dim results = randomNumberList.ChunkBy(7)


        Dim result1 = randomNumberList.Where(Function(item) item >= 1 AndAlso item <= 10).ToArray()
        Dim result2 = randomNumberList.Where(Function(item) item >= 10 AndAlso item <= 19).ToArray()
        Dim result3 = randomNumberList.Where(Function(item) item >= 20 AndAlso item <= 29).ToArray()

        sb.AppendLine(String.Join(" ", result1))
        sb.AppendLine(String.Join(" ", result2))
        sb.AppendLine(String.Join(" ", result3))

        Console.WriteLine(sb.ToString())

        Console.ReadLine()

    End Sub
End Module
Public Class Person
    Public Property FirstName() As String
    Public Property LastName() As String
End Class

