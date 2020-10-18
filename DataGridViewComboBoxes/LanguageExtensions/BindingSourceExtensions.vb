Namespace LanguageExtensions
    Public Module BindingSourceExtensions
        ''' <summary>
        ''' Get underlying DataTable for a BindingSource with a
        ''' DataTable as the DataSource.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <returns></returns>
        <Runtime.CompilerServices.Extension>
        Public Function DataTable(sender As BindingSource) As DataTable
            Return CType(sender.DataSource, DataTable)
        End Function
        ''' <summary>
        ''' Get current as a DataRow
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <returns></returns>
        <Runtime.CompilerServices.Extension>
        Public Function DataRow(sender As BindingSource) As DataRow
            Return CType(sender.Current, DataRowView).Row
        End Function
    End Module
End Namespace