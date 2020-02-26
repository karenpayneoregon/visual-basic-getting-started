Imports System.IO
Imports System.Text

Namespace Classes
    ''' <summary>
    ''' Although all methods should have exception handling only one 
    ''' has exception handling as there are more than one way to deal
    ''' with runtime exceptions which may be returning the error and stop
    ''' processing, continue processing and write errors to a list or
    ''' to a log file etc.
    ''' </summary>
    Public Class FileOperations
        ''' <summary>
        ''' This is the same default buffer size as
        ''' <see cref="StreamReader"/> and <see cref="IO.FileStream"/>.
        ''' </summary>
        Private Const DefaultBufferSize As Integer = 4096

        ''' <summary>
        ''' Indicates that
        ''' - The file is to be used for asynchronous reading.
        ''' - The file is to be accessed sequentially from beginning to end.
        ''' </summary>
        Private Const DefaultOptions As FileOptions = FileOptions.Asynchronous Or FileOptions.SequentialScan

        ''' <summary>
        ''' Uses File.ReadAllLines in tangent with a ValueTuple where the return types
        ''' are a List(Of Customer) and Nothing is the read was successful while if there
        ''' was an error the List may be empty or have several customers along with the exception
        ''' object which throw the exception e.g. file missing, incorrect column count, conversion
        ''' issue.
        ''' </summary>
        ''' <param name="FileName"></param>
        ''' <returns></returns>
        Public Shared Function ReadAllLinesWithFileReadLines(FileName As String) As (List As List(Of Customer), Exception As Exception)
            Dim customers = New List(Of Customer)()
            Dim countries = New List(Of String)
            Try
                Dim lines = File.ReadAllLines(FileName)
                For Each line As String In lines
                    Dim lineParts = line.Split(","c)

                    customers.Add(New Customer() With {
                                 .CustomerIdentifier = Convert.ToInt32(lineParts(0)),
                                 .CompanyName = lineParts(1),
                                 .ContactName = lineParts(2),
                                 .ContactTitle = lineParts(3),
                                 .City = lineParts(4),
                                 .Country = lineParts(5)
                                 })

                    countries.Add(lineParts(5))

                Next

                '
                ' This is how country names were created from the customer list above
                '
                'Dim countryData = countries.
                '        Distinct.
                '        Select(Function(country, index) New Country With {
                '                  .Name = country,
                '                  .Id = index}).
                '        OrderBy(Function(x) x.Name).ToList()

                'For Each item In countryData
                '    Console.WriteLine($"{item.Id},{item.Name}")
                'Next

            Catch ex As Exception
                Return (customers, ex)
            End Try

            Return (customers, Nothing)

        End Function
        ''' <summary>
        ''' Read country id and name into a strong type list of Country
        ''' </summary>
        ''' <param name="FileName"></param>
        ''' <returns></returns>
        Public Shared Function GetCountryList(FileName As String) As List(Of Country)

            Try

                Return File.ReadAllLines(FileName).Select(
                Function(country)
                    Dim linePart() As String

                    linePart = country.Split(","c)

                    Return New Country With {.Id = CInt(linePart(0)), .Name = linePart(1)}

                End Function).ToList()

            Catch ex As Exception
                Return New List(Of Country)
            End Try

        End Function
        ''' <summary>
        ''' Read each line, line by line which allows business logic to determine
        ''' if all lines need to be read or not while the above method will read all
        ''' lines in unless using .Skip and/or .Take which can be a performance hit
        ''' on the application.
        ''' </summary>
        ''' <param name="FileName"></param>
        ''' <returns></returns>
        Public Shared Function ReadAllLinesWithFileStream(FileName As String) As List(Of Customer)
            Dim customers = New List(Of Customer)()

            ' Open the FileStream with the same FileMode, FileAccess
            ' and FileShare as a call to File.OpenText would've done.
            Using stream = New FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.Read, DefaultBufferSize, DefaultOptions)
                Using reader = New StreamReader(stream)
                    Dim line As String

                    line = reader.ReadLine()
                    Do While line IsNot Nothing
                        Dim lineParts = line.Split(","c)

                        customers.Add(New Customer() With {
                                         .CustomerIdentifier = Convert.ToInt32(lineParts(0)),
                                         .CompanyName = lineParts(1),
                                         .ContactName = lineParts(2),
                                         .ContactTitle = lineParts(3),
                                         .City = lineParts(4),
                                         .Country = lineParts(5)
                                         })

                        line = reader.ReadLine()
                    Loop
                End Using
            End Using

            Return customers
        End Function
        ''' <summary>
        ''' Mirror of the synchronous method above, here the method is 
        ''' asynchronous which can keep the app responsive yet will slow
        ''' down the entire process.
        ''' </summary>
        ''' <param name="FileName"></param>
        ''' <param name="Encoding"></param>
        ''' <returns></returns>
        Public Shared Async Function ReadAllLinesWithFileStreamAsync(FileName As String, Encoding As Encoding) As Task(Of Customer())
            Dim customers = New List(Of Customer)()

            Using stream = New FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.Read, DefaultBufferSize, DefaultOptions)
                Using reader = New StreamReader(stream)
                    Dim line As String

                    line = Await reader.ReadLineAsync()
                    Do While line IsNot Nothing
                        Dim lineParts = line.Split(","c)

                        customers.Add(New Customer() With {
                                         .CustomerIdentifier = Convert.ToInt32(lineParts(0)),
                                         .CompanyName = lineParts(1),
                                         .ContactName = lineParts(2),
                                         .ContactTitle = lineParts(3),
                                         .City = lineParts(4),
                                         .Country = lineParts(5)
                                         })

                        line = Await reader.ReadLineAsync()
                    Loop
                End Using
            End Using

            Return customers.ToArray()

        End Function

    End Class
End Namespace