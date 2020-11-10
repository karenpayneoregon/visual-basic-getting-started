Namespace My
    <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)>
    Partial Friend Class _Dialogs
        ''' <summary>
        ''' Ask question with NO as the default button
        ''' </summary>
        ''' <param name="Text"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Question(Text As String) As Boolean
            Return (MessageBox.Show(Text, My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes)
        End Function
        Public Function Question(Text As String, Title As String) As Boolean
            Return (MessageBox.Show(Text, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = MsgBoxResult.Yes)
        End Function
        ''' <summary>
        ''' Shows text in dialog with information icon
        ''' </summary>
        ''' <param name="Text">Message to display</param>
        ''' <remarks></remarks>
        Public Sub InformationDialog(Text As String)
            MessageBox.Show(Text, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        ''' <summary>
        ''' Shows text in dialog with information icon
        ''' </summary>
        ''' <param name="Text">Message to display</param>
        ''' <param name="Title"></param>
        ''' <remarks></remarks>
        Public Sub InformationDialog(Text As String, Title As String)
            MessageBox.Show(Text, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        Public Sub WarningDialog(Text As String)
            MessageBox.Show(Text, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Sub
        Public Sub WarningDialog(Text As String, Title As String)
            MessageBox.Show(Text, Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Sub
    End Class
    <HideModuleName()>
    Friend Module KarenPayneDialogs
        Private instance As New ThreadSafeObjectProvider(Of _Dialogs)
        ReadOnly Property Dialogs() As _Dialogs
            Get
                Return instance.GetInstance()
            End Get
        End Property
    End Module
End Namespace
