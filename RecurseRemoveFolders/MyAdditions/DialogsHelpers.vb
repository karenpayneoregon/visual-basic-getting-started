Namespace My
    <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
    Partial Friend Class _Dialogs
        Public Function Question(Text As String) As Boolean
            Return (MessageBox.Show(Text, My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes)
        End Function
        Public Function Question(Text As String, Title As String) As Boolean
            Return (MessageBox.Show(Text, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes)
        End Function
    End Class
    <HideModuleName()>
    Friend Module WinFormsDialogs
        Private instance As New ThreadSafeObjectProvider(Of _Dialogs)
        ReadOnly Property Dialogs() As _Dialogs
            Get
                Return instance.GetInstance()
            End Get
        End Property
    End Module
End Namespace