Imports System.Reflection

Public Class Operations

    Public Shared Sub Work()
        Dim properties = GetType(Person).GetProperties().Where(Function(propertyInfo) propertyInfo.PropertyType IsNot GetType(Integer))
        Console.WriteLine()

    End Sub
End Class
