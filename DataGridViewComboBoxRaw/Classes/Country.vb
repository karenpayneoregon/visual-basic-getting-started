Namespace Classes
    Public Class Country
        Public Property CountryIdentifier() As Integer
        Public Property CountryName() As String

        Public Overrides Function ToString() As String
            Return CountryName
        End Function
    End Class
End NameSpace