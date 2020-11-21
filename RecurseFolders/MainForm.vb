Imports System.IO
Imports System.Threading
Imports FileHelpers
Imports RecurseFolders.Extensions

Public Class MainForm
    ''' <summary>
    ''' Provides an opportunity to cancel traversal of folders
    ''' </summary>
    Private _cts As New CancellationTokenSource()

    Private Async Sub TraverseButton_Click(sender As Object, e As EventArgs) Handles TraverseButton.Click

        If String.IsNullOrWhiteSpace(FolderTextBox.Text) Then
            MessageBox.Show("Please select a folder")
            Exit Sub
        End If

        If _cts.IsCancellationRequested = True Then
            _cts.Dispose()
            _cts = New CancellationTokenSource()
        End If

        ExcludeListBox.Items.Clear()
        IncludedListBox.Items.Clear()
        ExceptionsListBox.Items.Clear()

        '
        ' Consider creating a TextBox where the user can place extensions in
        ' semi-colon delimited, pass to RecursiveFolders and if nothing 
        ' for extensions pass an empty string array
        '
        Dim excludedFileExtensions = New String() {"obj", "bin", ".git", ".vs"}

        Operations.Cancelled = False
        Await Operations.RecursiveFolders(New DirectoryInfo(FolderTextBox.Text), excludedFileExtensions, _cts.Token)

    End Sub
    ''' <summary>
    ''' Subscribe to various events for recursive folder search 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Operations.OnTraverseEvent, AddressOf Traversing
        AddHandler Operations.OnTraverseExcludeFolderEvent, AddressOf ExcludeTraverse
        AddHandler Operations.OnExceptionEvent, AddressOf ExceptionHappened
    End Sub
    ''' <summary>
    ''' Report exception to the user interface. Another option
    ''' is not to show the exception until finished processing folders
    ''' which means a tad more logic tied to a List(Of String)
    ''' </summary>
    ''' <param name="sender"></param>
    Private Sub ExceptionHappened(sender As Exception)
        ExceptionsListBox.InvokeIfRequired(
            Sub(listBox)
                listBox.Items.Add(sender.Message)
                listBox.SelectedIndex = listBox.Items.Count - 1
            End Sub)
    End Sub
    ''' <summary>
    ''' Reports skipping a folder as it has been told to be
    ''' ignored
    ''' </summary>
    ''' <param name="sender"></param>
    Private Sub ExcludeTraverse(sender As String)
        ExcludeListBox.InvokeIfRequired(
            Sub(listBox)
                listBox.Items.Add(sender)
                listBox.SelectedIndex = listBox.Items.Count - 1
            End Sub)
    End Sub
    ''' <summary>
    ''' Folders found w/o exception or in the exclude array
    ''' </summary>
    ''' <param name="sender"></param>
    Private Sub Traversing(sender As String)
        IncludedListBox.InvokeIfRequired(
            Sub(listBox)
                listBox.Items.Add(sender)
                listBox.SelectedIndex = listBox.Items.Count - 1
            End Sub)
    End Sub
    ''' <summary>
    ''' Cancel the current task
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        _cts.Cancel()
    End Sub
    ''' <summary>
    ''' Select a folder to traverse
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectFolderButton_Click(sender As Object, e As EventArgs) Handles SelectFolderButton.Click
        If FolderBrowser.ShowDialog(Me) = DialogResult.OK Then
            FolderTextBox.Text = FolderBrowser.SelectedFolder
        End If
    End Sub
End Class