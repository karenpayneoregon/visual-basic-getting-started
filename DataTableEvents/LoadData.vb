Module LoadData
    Public Function LoadMockedServiceItems() As DataTable
        Dim dtServices = New DataTable("Services")

        '
        ' Define columns
        '
        dtServices.Columns.Add("Identifier", GetType(Integer))
        dtServices.Columns.Add("Service", GetType(String))
        dtServices.Columns.Add("Cost", GetType(Double))

        '
        ' Setup Identifier column as a auto-incrementing column 
        ' similar to a auto-incrementing primary
        ' key in a database table.
        '
        dtServices.Columns("Identifier").AutoIncrement = True
        dtServices.Columns("Identifier").AllowDBNull = False
        dtServices.Columns("Identifier").ReadOnly = True
        dtServices.Columns("Identifier").AutoIncrementSeed = 1


        dtServices.Rows.Add(Nothing, "Shirt", 5.99)
        dtServices.Rows.Add(Nothing, "Skirt", 6.99)
        dtServices.Rows.Add(Nothing, "Sheet", 10.99)
        dtServices.Rows.Add(Nothing, "Coat", 20.99)
        dtServices.Rows.Add(Nothing, "Full length dress", 15.99)
        dtServices.Rows.Add(Nothing, "Trousers", 12.99)
        dtServices.Rows.Add(Nothing, "Tee shirt", 2.99)

        '
        ' Normally this is not needed, only needed for mocked data.
        '
        dtServices.AcceptChanges()

        Return dtServices

    End Function
End Module