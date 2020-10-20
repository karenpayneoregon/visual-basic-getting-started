
Namespace Classes
    Public Class MonitorProgressArgs
        Inherits EventArgs

        Public Sub New(fileName As String)
            CurrentFileName = fileName
        End Sub

        Public ReadOnly Property CurrentFileName() As String
    End Class
End Namespace
