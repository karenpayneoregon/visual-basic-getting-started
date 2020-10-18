Imports System.Text
Imports DataGridViewComboBoxes.Classes

Namespace LanguageExtensions

    Public Module TableChangesExtensions
        <Runtime.CompilerServices.Extension>
        Public Function AllChanges(sender As DataTable, primaryKeyIndex As Integer) As TableChanges
            Dim results = New TableChanges With {.Deleted = sender.GetChanges(DataRowState.Deleted)}

            results.HasDeleted = results.Deleted IsNot Nothing

            For index = 0 To sender.Rows.Count - 1
                If sender.Rows(index).RowState = DataRowState.Deleted Then
                    results.DeletedPrimaryKeys.Add(Convert.ToInt32(sender.Rows(index)(primaryKeyIndex, DataRowVersion.Original)))
                End If
            Next index

            results.Modified = sender.GetChanges(DataRowState.Modified)
            results.HasModified = results.Modified IsNot Nothing

            results.Added = sender.GetChanges(DataRowState.Added)
            results.HasNew = results.Added IsNot Nothing

            results.UnChanged = sender.GetChanges(DataRowState.Unchanged)
            results.HasUnchanged = results.UnChanged IsNot Nothing

            results.Any = results.HasDeleted OrElse results.HasModified OrElse results.HasNew

            Return results

        End Function
        ''' <summary> 
        ''' Get changes by primary name 
        ''' </summary> 
        ''' <param name="sender"></param> 
        ''' <param name="primaryKeyColumnName"></param> 
        ''' <returns></returns> 
        <Runtime.CompilerServices.Extension>
        Public Function AllChanges(sender As DataTable, Optional ByVal primaryKeyColumnName As String = "id") As TableChanges

            Dim primaryKeyIndex As Integer = sender.Columns(primaryKeyColumnName).Ordinal
            Dim results = sender.AllChanges(primaryKeyIndex)

            Return results

        End Function
        ''' <summary> 
        ''' Returns a comma delimited string representing all  
        ''' data rows in the table. 
        ''' </summary> 
        ''' <param name="sender"></param> 
        ''' <returns></returns> 
        <Runtime.CompilerServices.Extension>
        Public Function Flatten(sender As DataTable) As String

            Dim sb = New StringBuilder()

            For Each row As DataRow In sender.Rows
                sb.AppendLine(String.Join(",", row.ItemArray))
            Next row

            Return sb.ToString()

        End Function

    End Module
End Namespace