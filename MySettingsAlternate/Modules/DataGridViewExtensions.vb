Namespace Modules
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
        <Runtime.CompilerServices.Extension>
        Public Sub ExpandColumns(sender As DataGridView)
            For Each column As DataGridViewColumn In sender.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
        End Sub
    End Module
End Namespace