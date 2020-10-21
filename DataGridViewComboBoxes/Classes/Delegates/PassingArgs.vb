
Namespace Classes.Delegates
    Public Class PassingArgs
        Inherits EventArgs

        Public Sub New(columnName As String, value As String)
            Me.ColumnName = columnName
            Me.Value = value
        End Sub

        Public ReadOnly Property ColumnName() As String
        Public ReadOnly Property Value() As String
    End Class
End Namespace
