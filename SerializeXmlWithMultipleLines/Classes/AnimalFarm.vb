Imports System.Xml.Serialization

Public Class AnimalFarm
    <XmlElement(GetType(Cat))>
    <XmlElement(GetType(Fish))>
    Public Property Animals() As List(Of Animal)

    Public Sub New()
        Animals = New List(Of Animal)()
    End Sub
End Class