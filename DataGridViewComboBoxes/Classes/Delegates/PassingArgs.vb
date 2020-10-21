
Namespace Classes.Delegates
    Public Class PassingArgs
        Inherits EventArgs

        Public Sub New(columnName As String, value As String)
            Me.ColumnName = columnName
            Me.Value = value
        End Sub
        ''' <summary>
        ''' Current DataGridView column for the current cell
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property ColumnName() As String
        ''' <summary>
        ''' String value for the current cell
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Value() As String
    End Class
End Namespace
