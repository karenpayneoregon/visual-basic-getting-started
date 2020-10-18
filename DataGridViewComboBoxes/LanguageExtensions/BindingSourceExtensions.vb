Namespace LanguageExtensions
    Public Module BindingSourceExtensions
        <Runtime.CompilerServices.Extension>
        Public Function DataTable(sender As BindingSource) As DataTable
            Return CType(sender.DataSource, DataTable)
        End Function

        <Runtime.CompilerServices.Extension>
        Public Function DataRow(sender As BindingSource) As DataRow
            Return CType(sender.Current, DataRowView).Row
        End Function
    End Module
End Namespace