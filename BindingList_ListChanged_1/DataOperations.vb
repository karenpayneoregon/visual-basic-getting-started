Public Class DataOperations

    Public Shared Function LoadPeople() As List(Of Person)
        Return New List(Of Person) From {
            New Person() With {.PersonId = 1, .FirstName = "Karen", .LastName = "Payne"},
            New Person() With {.PersonId = 2, .FirstName = "Bill", .LastName = "Miller"},
            New Person() With {.PersonId = 3, .FirstName = "Anne", .LastName = "Adams"}}
    End Function
End Class
