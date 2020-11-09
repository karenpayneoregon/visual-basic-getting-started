Imports System.Linq.Expressions
Imports EntityFrameworkCoreNorthWind.Models

Namespace Projections
    Public Class CustomerItem
        Public Property CustomerIdentifier() As Integer
        Public Property CompanyName() As String
        Public Property ContactName() As String
        Public Property ContactId() As Integer?
        Public Property CountryIdentifier() As Integer?
        Public Property CountryName() As String
        Public Property ContactTypeIdentifier() As Integer?

        Public Overrides Function ToString() As String
            Return $"{CompanyName} - {ContactName}"
        End Function

        Public Shared ReadOnly Property Projection() As Expression(Of Func(Of Customers, CustomerItem))
            Get
                Return Function(customers) New CustomerItem() With {
                        .CustomerIdentifier = customers.CustomerIdentifier,
                        .CompanyName = customers.CompanyName,
                        .ContactId = customers.ContactId,
                        .ContactName = $"{customers.Contact.FirstName} {customers.Contact.LastName}",
                        .CountryIdentifier = customers.CountryIdentifier,
                        .CountryName = customers.CountryIdentifierNavigation.Name,
                        .ContactTypeIdentifier = customers.CountryIdentifier
                    }
            End Get
        End Property
    End Class
End Namespace