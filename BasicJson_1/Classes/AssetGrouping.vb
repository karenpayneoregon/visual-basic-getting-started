Imports BasicJson_1.Classes

''' <summary>
''' Used to group assets from json by category
''' </summary>
Public Class AssetGrouping
    Public Property Category() As String
    Public Property AssetList() As List(Of Asset)
    Public Sub New()
        AssetList = New List(Of Asset)
    End Sub
End Class
