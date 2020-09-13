Public Class Operations
    ''' <summary>
    ''' Here is where the person would be added to a database table
    ''' </summary>
    ''' <param name="person"></param>
    Public Sub NewPersonAdded(person As Person)
        Console.WriteLine($"{person} added")
    End Sub
    ''' <summary>
    ''' Here is where the person would be removed from the database
    ''' table using Id property
    ''' </summary>
    ''' <param name="person"></param>
    Public Sub RemovedPersonAdded(person As Person)
        Console.WriteLine($"{person} removed")
    End Sub
    ''' <summary>
    ''' Not dealing with Id property, this would be
    ''' handled when working with a database with the
    ''' table having an auto-incrementing primary key
    ''' </summary>
    ''' <returns></returns>
    Public Function MockedPeople() As List(Of Person)
        Return New List(Of Person) From {
            New Person() With {.FirstName = "Karen", .LastName = "Payne"},
            New Person() With {.FirstName = "Bill", .LastName = "Smith"},
            New Person() With {.FirstName = "Anne", .LastName = "Jones"}}
    End Function
End Class
