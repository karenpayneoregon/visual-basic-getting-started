Namespace LanguageExtensions
    Public Module DataGridViewExtensions
        ''' <summary>
        ''' Assert if current cell is a DataGridViewComboBox via DataGridViewComboBoxEditingControl
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <returns></returns>
        <DebuggerStepThrough()>
        <Runtime.CompilerServices.Extension()>
        Public Function IsComboBoxCell(sender As DataGridViewCell) As Boolean
            Dim result As Boolean = False

            If sender.EditType IsNot Nothing Then
                If sender.EditType Is GetType(DataGridViewComboBoxEditingControl) Then
                    result = True
                End If
            End If

            Return result

        End Function
        ''' <summary>
        ''' Get current customer primary key
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <returns></returns>
        <DebuggerStepThrough()>
        <Runtime.CompilerServices.Extension()>
        Public Function Identifier(sender As BindingSource) As Integer
            Return CType(sender.Current, DataRowView).Row.Field(Of Integer)("CustomerIdentifier")
        End Function
    End Module
End Namespace