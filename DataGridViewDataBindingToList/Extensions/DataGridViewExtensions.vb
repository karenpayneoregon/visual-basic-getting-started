Imports System.IO
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
        <Extension>
        Public Sub ExportRows(sender As DataGridView, pFileName As String, Optional defaultNullValue As String = "(empty)")
            File.WriteAllLines(pFileName, (sender.Rows.Cast(Of DataGridViewRow)().
                                  Where(Function(row) Not row.IsNewRow).Select(Function(row) New With {
                                                                                  Key row,
                                                                                  Key .rowItem = String.Join(",", Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell)().ToArray(),
                                                                                                                                   Function(c) (If(c.Value Is Nothing, defaultNullValue, c.Value.ToString()))))
                                                                                  }).Select(Function(row) row.rowItem)))
        End Sub

    End Module
End Namespace