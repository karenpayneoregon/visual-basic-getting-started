Namespace Extensions
    Module BindingSourceExtensions
        <Runtime.CompilerServices.Extension()>
        Public Function CurrentRow(sender As BindingSource, Column As String) As String
            Return DirectCast(sender.Current, DataRowView).Row(Column).ToString
        End Function
    End Module
End Namespace