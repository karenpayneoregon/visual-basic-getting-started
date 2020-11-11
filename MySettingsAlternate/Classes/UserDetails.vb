Namespace Classes
    Public Class UserDetails
        Public Property FirstName() As String
        Public Property LastName() As String
        Public Property EmailAddress() As String
    End Class

    Public Class Mocking
        Public Shared Function CreateUser() As UserDetails
            Return New UserDetails() With {.FirstName = "", .LastName = "", .EmailAddress = ""}
        End Function
    End Class
End Namespace