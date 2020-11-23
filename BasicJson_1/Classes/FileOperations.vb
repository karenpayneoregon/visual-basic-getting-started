Imports System.IO
Imports Newtonsoft.Json

Namespace Classes
    Public Class FileOperations
        Public Shared FileName As String = "appSetting.json"
        Public Shared Sub Save(storageList As List(Of ApplicationStorage))
            Using streamWriter = File.CreateText(FileName)

                Dim serializer = New JsonSerializer With {.Formatting = Formatting.Indented}
                serializer.Serialize(streamWriter, storageList)

            End Using

        End Sub
        Public Shared Function Load() As List(Of ApplicationStorage)

            Using streamReader = New StreamReader(FileName)
                Dim json = streamReader.ReadToEnd()
                Return JsonConvert.DeserializeObject(Of List(Of ApplicationStorage))(json)
            End Using

        End Function

    End Class
End Namespace