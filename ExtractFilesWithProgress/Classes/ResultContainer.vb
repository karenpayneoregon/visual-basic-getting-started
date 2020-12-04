Namespace Classes
    Public Class ResultContainer
        Public Property FolderName() As String
        Public Property List() As New List(Of FileContainer)
        Public Overrides Function ToString() As String
            Return FolderName
        End Function
    End Class
    Public Class FileContainer
        Public Property Name() As String
        Public Property Size() As Int64
        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class
End Namespace