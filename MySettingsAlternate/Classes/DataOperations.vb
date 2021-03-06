﻿Imports System.Data.SqlClient

Namespace Classes
    Public Class DataOperations
        ''' <summary>
        ''' Must call to get connection string from app.config
        ''' </summary>
        Public Shared Sub GetConnectionString()
            ConnectionString = ApplicationSettings.DatabaseConnectionString()
        End Sub
        ''' <summary>
        ''' Connection string to use for accessing SQL-Server
        ''' </summary>
        ''' <returns></returns>
        Public Shared Property ConnectionString() As String
        ''' <summary>
        ''' Open database specified in configuration file.
        ''' </summary>
        ''' <returns></returns>
        Public Shared Async Function OpenDatabaseConnection() As Task(Of Boolean)
            Try
                Using cn = New SqlConnection() With {.ConnectionString = ConnectionString}
                    Await cn.OpenAsync()
                End Using
            Catch e As Exception
                Exceptions.Write(e)
                Return False
            End Try

            Return True

        End Function
        ''' <summary>
        ''' Get all known categories in the database. if an unhandled exception is raised
        ''' it's written to the error log file in ApplicationEvents module only at runtime.
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function GetCategories() As List(Of Category)
            Dim catList As New List(Of Category)

            Using cn = New SqlConnection() With {.ConnectionString = ConnectionString}
                Dim selectStatement = "SELECT CategoryID, CategoryName, [Description] FROM dbo.Categories WHERE dbo.Categories.CategoryID < 9;"
                Using cmd As New SqlCommand(selectStatement, cn)

                    cn.Open()
                    Dim reader = cmd.ExecuteReader()

                    While reader.Read()
                        catList.Add(New Category() With {.CategoryID = reader.GetInt32(0), .CategoryName = reader.GetString(1)})
                    End While
                End Using
            End Using

            Return catList

        End Function
        ''' <summary>
        ''' Get all products by category
        ''' </summary>
        ''' <param name="categoryIdentifier"></param>
        ''' <returns></returns>
        Public Shared Async Function ProductsByCategoryIdentifier(categoryIdentifier As Integer) As Task(Of DataTable)

            Dim categoryTable As New DataTable

            Try
                Using cn = New SqlConnection() With {.ConnectionString = ConnectionString}
                    Dim selectStatement As String =
                        "SELECT P.ProductID, P.ProductName, P.SupplierID, P.UnitPrice, P.UnitsInStock, S.CompanyName AS SupplierName " &
                        "FROM Products AS P INNER JOIN Suppliers AS S ON P.SupplierID = S.SupplierID " &
                        "WHERE P.CategoryID = @CategoryID ORDER BY P.ProductName;"

                    Using cmd As New SqlCommand(selectStatement, cn)
                        cmd.Parameters.AddWithValue("@CategoryID", categoryIdentifier)
                        Await cn.OpenAsync()

                        categoryTable.Load(cmd.ExecuteReader())
                    End Using
                End Using
            Catch e As Exception
                Exceptions.Write(e)
            End Try

            Return categoryTable

        End Function
    End Class
End Namespace
