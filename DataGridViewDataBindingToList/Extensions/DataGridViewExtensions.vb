Imports System.Runtime.CompilerServices

Namespace Extensions
    Module Extensions
        <Extension()>
        Public Function IsComboBoxCell(ByVal sender As DataGridViewCell) As Boolean
            Dim result As Boolean = False
            If sender.EditType IsNot Nothing Then
                If sender.EditType Is GetType(DataGridViewComboBoxEditingControl) Then
                    result = True
                End If
            End If
            Return result
        End Function
        <Extension()>
        Public Function Identifier(ByVal sender As BindingSource) As Integer
            Return CType(sender.Current, DataRowView).Row.Field(Of Integer)("Id")
        End Function
    End Module
End Namespace