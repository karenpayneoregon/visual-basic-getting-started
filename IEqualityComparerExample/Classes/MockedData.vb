Namespace Classes
    Public Class MockedData
        Public Shared Function CustomerList() As List(Of Customer)

            Return New List(Of Customer)() From {
                New Customer() With {.CompanyName = "Parfropanicator  Corp", .Country = "Namibia"},
                New Customer() With {.CompanyName = "Winsipazz WorldWide", .Country = "Australia"},
                New Customer() With {.CompanyName = "Parfropanicator  Corp", .Country = "Vanuatu"},
                New Customer() With {.CompanyName = "Parfropanicator  Corp", .Country = "Vanuatu"},
                New Customer() With {.CompanyName = "Winsipazz WorldWide", .Country = "Australia"},
                New Customer() With {.CompanyName = "Parpickazz Direct Group", .Country = "USA"}}

        End Function
    End Class
End Namespace