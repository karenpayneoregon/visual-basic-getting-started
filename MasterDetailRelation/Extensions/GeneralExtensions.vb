Namespace Extensions
    Public Module GeneralExtensions
        <Runtime.CompilerServices.Extension()>
        <DebuggerStepThrough()>
        Function IsCalendarCell(sender As DataGridView, e As DataGridViewCellEventArgs) As Boolean
            Return TypeOf sender.Columns(e.ColumnIndex) Is CalendarColumn AndAlso Not e.RowIndex = -1
        End Function
    End Module
End Namespace