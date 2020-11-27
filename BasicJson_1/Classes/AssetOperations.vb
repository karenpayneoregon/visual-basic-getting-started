Imports System.IO
Imports BasicJson_1.Classes
Imports Newtonsoft.Json

Public Class AssetOperations
    ''' <summary>
    ''' File name to read/write json
    ''' </summary>
    Public Shared FileName As String = "assets.json"
    ''' <summary>
    ''' Used to provide a json file with assets
    ''' </summary>
    Public Shared Sub MockAssets()

        Dim assetList As New List(Of Asset) From {
                New Asset() With {.Category = "cat1", .Installed = True, .Name = "Bob"},
                New Asset() With {.Category = "cat1", .Installed = False, .Name = "Jack"},
                New Asset() With {.Category = "cat2", .Installed = True, .Name = "Julie"},
                New Asset() With {.Category = "cat3", .Installed = True, .Name = "Linda"}
                }

        Using streamWriter = File.CreateText(FileName)

            Dim serializer = New JsonSerializer With {.Formatting = Formatting.Indented}
            serializer.Serialize(streamWriter, assetList)

        End Using

    End Sub
    ''' <summary>
    ''' Read assets from json file, if it does not exists
    ''' an empty list is returned.
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function ReadAssets() As List(Of Asset)

        If File.Exists(FileName) Then
            Using streamReader = New StreamReader(FileName)
                Dim json = streamReader.ReadToEnd()
                Return JsonConvert.DeserializeObject(Of List(Of Asset))(json)
            End Using
        Else
            Return New List(Of Asset)
        End If

    End Function
    ''' <summary>
    ''' Update list of assets. Since you can't simply update one
    ''' asset you need to modify one or more from the method above ReadAssets
    ''' change stuff then save the entire list back to disk as json
    ''' </summary>
    ''' <param name="assets"></param>
    Public Shared Sub UpdateAsset(assets As List(Of Asset))

        Using streamWriter = File.CreateText(FileName)

            Dim serializer = New JsonSerializer With {.Formatting = Formatting.Indented}
            serializer.Serialize(streamWriter, assets)

        End Using


    End Sub
End Class