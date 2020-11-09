Imports EntityFrameworkCoreNorthWind.Contexts
Imports EntityFrameworkCoreNorthWind.Extensions
Imports EntityFrameworkCoreNorthWind.Models
Imports EntityFrameworkCoreNorthWind.Projections
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata
Imports Microsoft.EntityFrameworkCore.Metadata.Internal

Namespace Classes

    Public Class Operations
        ''' <summary>
        ''' Select all customers with contact and country details
        ''' </summary>
        ''' <returns></returns>
        Public Shared Async Function ReadCustomers() As Task(Of List(Of Customers))

            Return Await Task.Run(
                Async Function()
                    Using context As New CustomerContext
                        Return Await context.Customers.IncludeContactCountry.ToListAsync()
                    End Using
                End Function)

        End Function
        ''' <summary>
        ''' Select a customer with contact and country details by customer identifier
        ''' </summary>
        ''' <param name="identifier">customer identifier to find by</param>
        ''' <returns></returns>
        Public Shared Async Function ReadCustomer(identifier As Integer) As Task(Of Customers)

            Return Await Task.Run(
                Async Function()
                    Using context As New CustomerContext
                        Return Await context.Customers.IncludeContactCountry(identifier)
                    End Using
                End Function)

        End Function
        Public Shared Async Function ReadCustomersProjected() As Task(Of List(Of CustomerItem))

            Return Await Task.Run(
                Async Function()
                    Using context As New CustomerContext
                        Return Await context.Customers.IncludeContactCountry.Select(CustomerItem.Projection).ToListAsync()
                    End Using
                End Function)

        End Function

    End Class
End Namespace