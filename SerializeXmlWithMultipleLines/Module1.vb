Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Module Module1

    Sub Main()

        Dim fileName = "person.xml"

        Dim person As New Person() With {
                .FirstName = "Karen",
                .Lastname = "Payne",
                .Comments = "Line 1" & vbLf & "line2" & vbLf & "line3"
                }

        Dim ws As New XmlWriterSettings With {.NewLineHandling = NewLineHandling.Entitize}

        Dim serializer As New XmlSerializer(GetType(Person))
        Using xmlWriter As XmlWriter = XmlWriter.Create(fileName, ws)
            serializer.Serialize(xmlWriter, person)
        End Using

        Dim person1 = DeserializeXmlFileToObject(Of Person)(fileName)

        Console.WriteLine("Comments")
        Console.WriteLine($"[{person1.Comments}]")
        Console.ReadLine()

    End Sub
    Public Function DeserializeXmlFileToObject(Of T)(xmlFilename As String) As T
        Dim returnObject As T = Nothing
        If String.IsNullOrEmpty(xmlFilename) Then
            Return Nothing
        End If

        Try
            Dim xmlStream As New StreamReader(xmlFilename)
            Dim serializer As New XmlSerializer(GetType(T))
            returnObject = DirectCast(serializer.Deserialize(xmlStream), T)
        Catch ex As Exception
            Console.WriteLine()
        End Try
        Return returnObject
    End Function
End Module
Public Class Person
    Public Property FirstName() As String
    Public Property Lastname() As String
    Public Property Comments() As String
End Class

