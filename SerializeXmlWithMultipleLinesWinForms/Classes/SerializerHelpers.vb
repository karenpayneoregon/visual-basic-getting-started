Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Namespace Classes
    Public Module SerializerHelpers
        Private _fileName As String = "person.xml"
        Sub SerializePerson(person As Person)

            Dim ws As New XmlWriterSettings With {.NewLineHandling = NewLineHandling.Entitize}
            Dim serializer As New XmlSerializer(GetType(Person))

            Using xmlWriter As XmlWriter = XmlWriter.Create(_fileName, ws)
                serializer.Serialize(xmlWriter, person)
            End Using

        End Sub
        Public Sub SerializeList(person As List(Of Person))

            Dim ws As New XmlWriterSettings With {.NewLineHandling = NewLineHandling.Entitize}
            Dim serializer As New XmlSerializer(GetType(List(Of Person)))

            Using xmlWriter As XmlWriter = XmlWriter.Create(_fileName, ws)
                serializer.Serialize(xmlWriter, person)
            End Using

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
End Namespace