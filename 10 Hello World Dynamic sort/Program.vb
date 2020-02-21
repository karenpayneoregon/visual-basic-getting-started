Imports System
Imports StandardLibrary1

Module Program
    Sub Main(args As String())
        Dim personList As List(Of Person) = MockedData.PersonList()

        Dim originalForegroundColor = Console.ForegroundColor
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Dynamic sort by property name")
        Console.ForegroundColor = originalForegroundColor

        Console.WriteLine("Sort ASC FirstName")
        Console.WriteLine()

        Dim sort1 = personList.Sort("FirstName", SortDirection.Ascending)

        For Each person As Person In sort1
            Console.WriteLine(person)
        Next

        Console.WriteLine()

        Console.WriteLine("Sort DESC LastName")
        sort1 = personList.Sort("LastName", SortDirection.Descending)

        For Each person As Person In sort1
            Console.WriteLine(person)
        Next


        Console.WriteLine()

        Console.WriteLine("Sort ASC ContactId")
        sort1 = personList.Sort("ContactId", SortDirection.Ascending)

        For Each person As Person In sort1
            Console.WriteLine(person)
        Next

        Console.ReadLine()

    End Sub
End Module
Public Class Person
    Public Property ContactId() As Integer
    Public Property FirstName() As String
    Public Property LastName() As String

    Public Overrides Function ToString() As String
        Return $"{ContactId} | {FirstName} {LastName}"
    End Function
End Class
Public Class MockedData
    Public Shared Function PersonList() As List(Of Person)
        Return New List(Of Person) From {
                New Person() With {.ContactId = 1, .FirstName = "Peter", .LastName = "Tonini"},
                New Person() With {.ContactId = 2, .FirstName = "Adam", .LastName = "Hardy"},
                New Person() With {.ContactId = 3, .FirstName = "Elizabeth", .LastName = "Lebihan"},
                New Person() With {.ContactId = 4, .FirstName = "Martín", .LastName = "Wilson"}
            }
    End Function
End Class
