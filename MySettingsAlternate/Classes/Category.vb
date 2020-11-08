Public Class Category
    Public Property CategoryID() As Integer
    Public Property CategoryName() As String
    Public Property Description() As String

    Public Overrides Function ToString() As String
        Return CategoryName
    End Function
End Class
