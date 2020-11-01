Namespace Classes
    Public Class MyApplication
        Public Property MainWindowTitle() As String
        Public Property IncomingFolder() As String
        Public Property ImportMinutesToPause() As Integer
        Public Property TestMode() As Boolean
        Public Property LastRan() As DateTime
        Public Property DatabaseServer() As String
        Public Property Catalog() As String
        Public ReadOnly Property ConnectionString() As String
            Get
                Return $"Data Source= {DatabaseServer};Initial Catalog={Catalog};Integrated Security=True"
            End Get
        End Property
    End Class
End Namespace