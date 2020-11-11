Imports System.IO
Imports Newtonsoft.Json

Namespace Classes.Json

    Public Class FileOperations
        Private Property mFileName() As String
        Public Sub New()

        End Sub

        Public Sub New(fileName As String)
            mFileName = fileName
        End Sub
        Public Function LoadApplicationData(fileName As String) As MyApplicationJson

            Using streamReader = New StreamReader(fileName)
                Dim json = streamReader.ReadToEnd()
                Return JsonConvert.DeserializeObject(Of MyApplicationJson)(json)
            End Using

        End Function
        Public Sub SaveApplicationData(searchItems As MyApplicationJson, fileName As String)

            Using streamWriter = File.CreateText(fileName)

                Dim serializer = New JsonSerializer With {.Formatting = Formatting.Indented}
                serializer.Serialize(streamWriter, searchItems)

            End Using

        End Sub

        Public Shared Sub MockUp()
            If Not File.Exists(My.Settings.JsonFileName) Then
                Dim appSetting = New MyApplicationJson With {
                        .MainWindowTitle = "Code sample for reading/setting app.config",
                        .IncomingFolder = "D:\UISides\oed_incoming",
                        .TestMode = False,
                        .ImportMinutesToPause = 2,
                        .LastCategoryIdentifier = 3,
                        .LastRan = #10/31/2020 3:12:50 AM#,
                        .DatabaseServer = ".\SQLEXPRESS", .Catalog = "NorthWind2020"}

                My.Settings.SaveJsonSettings(appSetting)

            End If
        End Sub
    End Class
End Namespace