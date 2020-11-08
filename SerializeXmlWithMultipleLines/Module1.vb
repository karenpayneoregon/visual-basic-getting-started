Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Module Module1

    Sub Main()
        SerializeAnimals()
    End Sub
    Public Sub SerializeAnimals()

        Dim animalFarm As New AnimalFarm()

        animalFarm.Animals.Add(New Cat() With {
                                  .Weight = 4000,
                                  .FurLength = 3,
                                  .Comments = "Line 1" & vbLf & "line2" & vbLf & "line3",
                                  .Name = "Kitty"
                                  })

        animalFarm.Animals.Add(New Fish() With {
                                  .Weight = 200,
                                  .ScalesCount = 99,
                                  .Comments = "Line 1" & vbLf & "line2",
                                  .Name = "Guppy"
                                  })

        Dim ws As New XmlWriterSettings With {.NewLineHandling = NewLineHandling.Entitize}
        Dim serializer As New XmlSerializer(GetType(AnimalFarm))

        ' for debugging if you like to see the output
        '    serializer.Serialize(Console.Out, animalFarm)

        Dim fileName = "annimals.xml"
        Using xmlWriter As XmlWriter = XmlWriter.Create(fileName, ws)
            serializer.Serialize(xmlWriter, animalFarm)
        End Using

        Dim animalFarm1 As AnimalFarm = DeserializeXmlFileToObject(Of AnimalFarm)(fileName)
        For Each animal As Animal In animalFarm1.Animals
            Console.WriteLine(animal.Name)
            Console.WriteLine($"{animal.Comments}")
            Console.WriteLine()
        Next

        Console.ReadKey()
    End Sub
    Sub SerializePerson()
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