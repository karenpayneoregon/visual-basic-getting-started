Imports IEqualityComparerExample.Classes

Module Program
    Sub Main(args As String())
        Console.WriteLine("IEqualityComparer Example")
        Console.WriteLine()

        Dim customers = MockedData.CustomerList().
                Distinct(New CustomerNameCountryComparer).
                OrderBy(Function(customer) customer.CompanyName)

        For Each customer As Customer In customers
            Console.WriteLine($"  {customer.CompanyName,-25}|{customer.Country}")
        Next

        Console.WriteLine()
        Console.WriteLine("Press a key to quit")
        Console.ReadLine()
    End Sub
End Module
