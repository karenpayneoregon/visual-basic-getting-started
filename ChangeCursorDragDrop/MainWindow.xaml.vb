
Class MainWindow
    Private Sub Label_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs)

        Dim data As New DataObject(DataFormats.Text, CType(e.Source, Label).Content)

        DragDrop.DoDragDrop(CType(e.Source, DependencyObject), data, DragDropEffects.Copy)

    End Sub

    Private Sub Label_Drop(sender As Object, e As DragEventArgs)

        CType(e.Source, Label).Content = CStr(e.Data.GetData(DataFormats.Text))
        MessageBox.Show("Dropped")

    End Sub

    Private _customCursor As Cursor = Nothing

    Private Sub Label_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs)

        If e.Effects = DragDropEffects.Copy Then
            If _customCursor Is Nothing Then
                _customCursor = CursorHelper.CreateCursorFromImage("Dynamic.bmp")
            End If

            If _customCursor IsNot Nothing Then
                e.UseDefaultCursors = False
                Mouse.SetCursor(_customCursor)
            End If
        Else
            e.UseDefaultCursors = True
        End If

        e.Handled = True

    End Sub

End Class
