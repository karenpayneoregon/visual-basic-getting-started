Imports System.Data.SqlClient

Namespace Classes
    Public Class DataOperations
        ''' <summary>
        ''' Open database specified in configuration file.
        ''' </summary>
        ''' <returns></returns>
        Public Shared Async Function OpenDatabaseConnection() As Task(Of Boolean)
            Try
                Using cn = New SqlConnection() With {.ConnectionString = ApplicationSettings.DatabaseConnectionString()}
                    Await cn.OpenAsync()
                End Using
            Catch ex As Exception
                Return False
            End Try

            Return True

        End Function
    End Class
End Namespace