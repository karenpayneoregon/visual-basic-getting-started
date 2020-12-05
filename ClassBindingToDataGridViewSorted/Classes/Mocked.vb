Public Class Mocked
    Public Shared ReadOnly Property PeopleList() As List(Of Person)
        Get
            Return New List(Of Person) From {
                New Person() With {.Id = 1, .FirstName = "Karen", .LastName = "Payne"},
                New Person() With {.Id = 2, .FirstName = "Bill", .LastName = "Smith"},
                New Person() With {.Id = 3, .FirstName = "Mary", .LastName = "Jones"},
                New Person() With {.Id = 4, .FirstName = "Kim", .LastName = "Adams"}}
        End Get
    End Property
End Class
