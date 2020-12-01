Imports System.IO
Imports System.Threading
Imports RecurseFolders.Extensions

Public Class OtherExamplesForm
    ''' <summary>
    ''' Provides an opportunity to cancel traversal of folders
    ''' </summary>
    Private _cts As New CancellationTokenSource()
    Private _exceptionList As List(Of String)

    ''' <summary>
    ''' Traverse folders searching for any .dll files
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub DeniedAccessCoveredButton_Click(sender As Object, e As EventArgs) Handles DeniedAccessCoveredButton.Click

        If _cts.IsCancellationRequested = True Then
            _cts.Dispose()
            _cts = New CancellationTokenSource()
        End If

        _exceptionList = New List(Of String)
        ExceptionsListBox.DataSource = Nothing

        Dim stack As New Stack(Of String)

        stack.Push(Environment.GetFolderPath(Environment.SpecialFolder.Desktop))

        Try

            Await Task.Run(Async Function()

                               Do While (stack.Count > 0)
                                   Dim directory As String = stack.Pop
                                   Dim lvItem As New ListViewItem(directory)
                                   ListView1.InvokeIfRequired(Sub(lv) lv.Items.Add(lvItem))

                                   Await Task.Delay(1)

                                   If _cts.IsCancellationRequested Then
                                       _cts.Token.ThrowIfCancellationRequested()
                                   End If

                                   Try

                                       Dim files = IO.Directory.GetFiles(directory, "*.*")

                                       If files.Length > 0 Then

                                           For Each file As String In files
                                               Dim item = New ListViewItem(New String() {"", Path.GetFileName(file)})
                                               item.Tag = directory
                                               ListView1.InvokeIfRequired(Sub(lv) lv.Items.Add(item))
                                           Next

                                       End If

                                       Dim strDirectoryName As String
                                       For Each strDirectoryName In IO.Directory.GetDirectories(directory)
                                           stack.Push(strDirectoryName)

                                       Next

                                   Catch ex As UnauthorizedAccessException
                                       _exceptionList.Add(ex.Message)
                                   End Try
                               Loop

                           End Function)

            ExceptionsListBox.DataSource = _exceptionList

            ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            ListView1.FocusedItem = ListView1.Items(0)
            ListView1.Items(0).Selected = True
            ActiveControl = ListView1

        Catch ex As OperationCanceledException
            MessageBox.Show($"Cancelled")
        End Try

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        _cts.Cancel()
    End Sub
    ''' <summary>
    ''' Get current item
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectedButton_Click(sender As Object, e As EventArgs) Handles SelectedButton.Click
        If ListView1.Items.Count = 0 Then
            Exit Sub
        End If

        Dim folder = ListView1.SelectedItems(0).Text
        Dim fileName = ""
        If ListView1.SelectedItems(0).SubItems.Count = 2 Then
            fileName = ListView1.SelectedItems(0).SubItems(1).Text
        Else
            fileName = ""
        End If

        If String.IsNullOrWhiteSpace(folder) Then
            folder = ListView1.SelectedItems(0).Tag.ToString()
        End If

        MessageBox.Show($"{folder}\{fileName}")

    End Sub
End Class