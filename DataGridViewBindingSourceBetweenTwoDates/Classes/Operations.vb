Public Class Operations
    Private Shared ConnectionString As String =
                       "Data Source=.\SQLEXPRESS;" &
                       "Initial Catalog=NorthWind2020;Integrated Security=True"

    Public Shared Function Read() As DataTable
        Using cn As New SqlClient.SqlConnection With {.ConnectionString = ConnectionString}
            Using cmd As New SqlClient.SqlCommand With {.Connection = cn}
                cmd.CommandText = "SELECT OrderID, CustomerIdentifier, EmployeeID, OrderDate, ShipCountry FROM dbo.Orders"
                Dim orderTable As New DataTable
                cn.Open()
                orderTable.Load(cmd.ExecuteReader())
                Return orderTable
            End Using
        End Using
    End Function
End Class
