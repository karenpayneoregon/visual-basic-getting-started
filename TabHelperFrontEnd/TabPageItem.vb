Public Class TabPageItem
    Public Property Name() As String
    Public Property Tab() As TabPage

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class
