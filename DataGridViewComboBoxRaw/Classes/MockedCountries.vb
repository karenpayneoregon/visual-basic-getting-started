Imports System.IO
Imports Newtonsoft.Json

Namespace Classes
    Public Class MockedCountries
        Public Shared Function Load() As List(Of Country)
            Dim list As New List(Of Country)

            Dim json = File.ReadAllText("countries.json")
            Dim data = JsonConvert.DeserializeObject(Of List(Of CountryJson))(json)

            For index As Integer = 0 To data.Count - 1
                list.Add(New Country() With {.CountryIdentifier = index + 1, .CountryName = data.Item(index).name})
            Next

            Return list

        End Function
    End Class
End NameSpace