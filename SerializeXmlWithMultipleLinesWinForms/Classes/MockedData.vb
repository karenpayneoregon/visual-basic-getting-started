Namespace Classes
    Public Class MockedData
        Public Shared Function People() As List(Of Person)
            Dim peopleList As New List(Of Person)

            peopleList.Add(New Person() With {.FirstName = "Joe", .Lastname = "Smith", .Comments = $"Line1{vbLf}Line 2{vbLf}Line3"})
            peopleList.Add(New Person() With {.FirstName = "Mary", .Lastname = "Smith", .Comments = $"Line A{vbLf}Line B{vbLf}Line C"})
            peopleList.Add(New Person() With {.FirstName = "Tom", .Lastname = "Adams", .Comments = $"Line F{vbLf}Line A{vbLf}Line B"})

            Return peopleList

        End Function
    End Class
End Namespace