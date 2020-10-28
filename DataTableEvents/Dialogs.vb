Namespace My

    <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
    Partial Friend Class _Dialogs
        Public Function Question(message As String) As Boolean
            Return (MessageBox.Show(message, My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes)
        End Function
        ''' <summary>
        ''' Shows text in dialog with information icon
        ''' </summary>
        ''' <param name="message">Message to display</param>
        ''' <remarks></remarks>
        Public Sub InformationDialog(message As String)
            MessageBox.Show(message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
    End Class

    <HideModuleName()>
    Friend Module SpecialFormsDialogs
        Private instance As New ThreadSafeObjectProvider(Of _Dialogs)
        ReadOnly Property Dialogs() As _Dialogs
            Get
                Return instance.GetInstance()
            End Get
        End Property
    End Module
End Namespace