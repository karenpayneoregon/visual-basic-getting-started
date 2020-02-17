Namespace Classes

    Public Class CustomerNameCountryComparer
        Implements IEqualityComparer(Of Customer)

        Public Overloads Function Equals(
            customer1 As Customer,
            customer2 As Customer) As Boolean _
            Implements IEqualityComparer(Of Customer).Equals

            Return customer1.CompanyName = customer2.CompanyName AndAlso customer1.Country = customer2.Country

        End Function

        Public Overloads Function GetHashCode(customer As Customer) As Integer _
            Implements IEqualityComparer(Of Customer).GetHashCode

            Return New With {
                Key customer.CompanyName,
                Key customer.Country
                }.GetHashCode()

        End Function

    End Class
End Namespace