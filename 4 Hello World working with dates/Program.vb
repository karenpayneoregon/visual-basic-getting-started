''' <summary>
''' Convert string to string date
''' </summary>
Module Program
    Sub Main(args As String())

        '
        ' Mocked up data
        '
        Dim mockedData = New String() {
            "Wednesday,January,1,2020",
            "Thursday,January,2,2020",
            "Friday,January,3,2020",
            "Friday,March,3,2020"}

        For Each item As String In mockedData
            Console.WriteLine($"{item} -> {StringToDate(item).ToShortDateString()}")
        Next

        Console.ReadLine()

    End Sub

    Function StringToDate(sender As String) As Date
        Dim parts = sender.Split(",")
        Return New Date(CInt(parts(3)), Converts.MonthNameToInteger(parts(1)), CInt(parts(2)))
    End Function
End Module
Class DatePart
    Public Property Index() As Integer
    Public Property Name() As String
End Class
Class Converts
    ''' <summary>
    ''' Contains month names and respective index e.g. Sunday is 1
    ''' </summary>
    Private Shared ReadOnly Months As List(Of DatePart) = Globalization.CultureInfo.CurrentCulture.
        DateTimeFormat.MonthNames.
        Where(Function(value) Not String.IsNullOrWhiteSpace(value)).Select(
            Function(item, index)
                Return New DatePart With {.Name = item, .Index = index + 1}
            End Function).ToList()

    Public Shared Function MonthNameToInteger(sender As String) As Integer
        Return Months.FirstOrDefault(Function(item) item.Name = sender).Index
    End Function
End Class
