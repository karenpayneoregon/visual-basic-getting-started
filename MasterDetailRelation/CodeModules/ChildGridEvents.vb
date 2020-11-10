Module ChildGridEvents
    ''' <summary>
    ''' Highlights ShippedDate if there is no value assigned to this field.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>color randomly selected</remarks>
    Sub ChildGrid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        If DirectCast(sender, DataGridView).Columns(e.ColumnIndex).Name = "ShippedDate" Then
            If e.Value Is DBNull.Value OrElse e.Value Is Nothing Then
                e.CellStyle.BackColor = Color.DarkSlateGray
            End If
        End If
    End Sub
End Module
