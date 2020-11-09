Imports System.Runtime.CompilerServices
Imports EntityFrameworkCoreNorthWind.Models
Imports Microsoft.EntityFrameworkCore

Namespace Extensions

    Public Module QueryExtensions
        <Extension>
        Public Function IncludeContactCountry(query As IQueryable(Of Customers)) As IQueryable(Of Customers)
            Return query.
                Include(Function(customer) customer.Contact).
                Include(Function(customer) customer.ContactTypeNavigation).
                Include(Function(customer) customer.CountryIdentifierNavigation)

        End Function
        <Extension>
        Public Function IncludeContactCountry(query As IQueryable(Of Customers), identifier As Integer) As Task(Of Customers)
            Return query.
                Include(Function(customer) customer.Contact).
                Include(Function(customer) customer.ContactTypeNavigation).
                Include(Function(customer) customer.CountryIdentifierNavigation).
                FirstOrDefaultAsync(Function(customer) customer.CustomerIdentifier = identifier)

        End Function
    End Module
End Namespace