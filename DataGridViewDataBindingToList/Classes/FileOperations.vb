﻿Imports System.IO
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
        ''' <see cref="StreamReader"/> and <see cref="FileStream"/>.
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
        ''' <param name="fileName"></param>
        ''' <returns></returns>
        Public Shared Function ReadAllLinesWithFileReadLines(fileName As String, countryList As List(Of Country)) As (List As List(Of Customer), Exception As Exception)

            Dim customers = New List(Of Customer)()

            Try

                Dim lines = File.ReadAllLines(fileName)
                Dim index As Integer = 1

                For Each line As String In lines
                    Console.WriteLine(index)
                    ' split line by comma
                    Dim lineParts = line.Split(","c)

                    ' for this code sample there are numbers in the last element,
                    ' in the wild there should be an assertion if the last element
                    ' is a valid integer.
                    Dim countryId = Convert.ToInt32(lineParts(5))

                    '
                    ' Get country name from country identifier
                    '
                    Dim currentCountryName = countryList.FirstOrDefault(Function(country) country.CountryIdentifier = countryId).Name

                    customers.Add(New Customer() With {
                                     .CustomerIdentifier = Convert.ToInt32(lineParts(0)),
                                     .CompanyName = lineParts(1),
                                     .ContactName = lineParts(2),
                                     .ContactTitle = lineParts(3),
                                     .City = lineParts(4),
                                     .CountryIdentifier = countryId,
                                     .CountryName = currentCountryName
                                 })
                    index += 1
                Next


            Catch ex As Exception
                Return (customers, ex)
            End Try

            Return (customers, Nothing)

        End Function
        ''' <summary>
        ''' Read country id and name into a strong type list of Country
        ''' </summary>
        ''' <param name="fileName"></param>
        ''' <returns></returns>
        Public Shared Function GetCountryList(fileName As String) As List(Of Country)

            Try

                Return File.ReadAllLines(fileName).Select(
                Function(country)
                    Dim linePart() As String

                    linePart = country.Split(","c)

                    Return New Country With {.CountryIdentifier = CInt(linePart(0)), .Name = linePart(1)}

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
        ''' <param name="fileName"></param>
        ''' <returns></returns>
        Public Shared Function ReadAllLinesWithFileStream(fileName As String) As List(Of Customer)
            Dim customers = New List(Of Customer)()

            ' Open the FileStream with the same FileMode, FileAccess
            ' and FileShare as a call to File.OpenText would've done.
            Using stream = New FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read, DefaultBufferSize, DefaultOptions)
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
                                         .CountryIdentifier = Convert.ToInt32(lineParts(5))
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
        ''' <param name="fileName"></param>
        ''' <param name="encoding"></param>
        ''' <returns></returns>
        Public Shared Async Function ReadAllLinesWithFileStreamAsync(fileName As String, encoding As Encoding) As Task(Of Customer())
            Dim customers = New List(Of Customer)()

            Using stream = New FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read, DefaultBufferSize, DefaultOptions)
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
                                         .CountryIdentifier = Convert.ToInt32(lineParts(5))
                                         })

                        line = Await reader.ReadLineAsync()
                    Loop
                End Using
            End Using

            Return customers.ToArray()

        End Function

    End Class
End Namespace