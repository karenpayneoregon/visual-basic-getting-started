Namespace Classes
    Public Class Operations
        Private Shared ConnectionString As String =
                           "Data Source=.\SQLEXPRESS;" &
                           "Initial Catalog=NorthWind2020;Integrated Security=True"

        Public Shared Function Read(Optional order As Boolean = False) As DataTable
            Using cn As New SqlClient.SqlConnection With {.ConnectionString = ConnectionString}
                Using cmd As New SqlClient.SqlCommand With {.Connection = cn}


                    If order Then
                        cmd.CommandText = "SELECT OrderID, CustomerIdentifier, EmployeeID, OrderDate, ShipCountry FROM dbo.Orders ORDER BY ShipCountry"
                    Else
                        cmd.CommandText = "SELECT OrderID, CustomerIdentifier, EmployeeID, OrderDate, ShipCountry FROM dbo.Orders"
                    End If

                    Dim orderTable As New DataTable

                    cn.Open()

                    orderTable.Load(cmd.ExecuteReader())

                    Return orderTable

                End Using
            End Using
        End Function
    End Class
End Namespace