Namespace LanguageExtensions
    Module LanguageExtensions
        <DebuggerStepThrough()>
        <Runtime.CompilerServices.Extension()>
        Public Function DataTable(sender As BindingSource) As DataTable
            Return DirectCast(sender.DataSource, DataTable)
        End Function
        <DebuggerStepThrough()>
        <Runtime.CompilerServices.Extension()>
        Public Function CurrentRow(sender As BindingSource) As DataRow
            Return (CType(sender.Current, DataRowView)).Row
        End Function
    End Module
End Namespace