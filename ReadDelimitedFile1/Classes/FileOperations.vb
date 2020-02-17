Imports System.IO
Imports System.Text

Namespace Classes
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
        Public Shared Function ConventionalRead(FileName As String) As List(Of Customer)
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
        Public Shared Async Function ReadAllLinesAsync1(FileName As String, Encoding As Encoding) As Task(Of Customer())
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