Namespace Classes
    ''' <summary>
    ''' Note, property names casing must match the json properties or us
    ''' &lt;JsonProperty("name")gt;
    ''' But we don't care as this class is only used to load some json
    ''' </summary>
    Public Class CountryJson
        Public Property name As String
        Public Property code As String
    End Class
End Namespace