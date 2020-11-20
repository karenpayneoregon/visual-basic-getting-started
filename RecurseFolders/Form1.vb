Imports System.IO
Imports System.Threading
Imports FileHelpers

Public Class Form1
    Private _cts As New CancellationTokenSource()

    Private Sub TraverseButton_Click(sender As Object, e As EventArgs) Handles TraverseButton.Click

        If _cts.IsCancellationRequested = True Then
            _cts.Dispose()
            _cts = New CancellationTokenSource()
        End If

        ExcludeListBox.Items.Clear()
        IncludedListBox.Items.Clear()
        ExceptionsListBox.Items.Clear()

        Dim exclude = New String() {"obj", "bin", ".git", ".vs"}

        Operations.Cancelled = False

        Operations.RecursiveFolders(New DirectoryInfo("C:\OED\Dotnetland\vbGettingStarted"), exclude, _cts.Token)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Operations.OnTraverseEvent, AddressOf Traversing
        AddHandler Operations.OnTraverseExcludeFolderEvent, AddressOf ExcludeTraverse
        AddHandler Operations.OnExceptionEvent, AddressOf ExceptionHappened
    End Sub

    Private Sub ExceptionHappened(sender As Exception)
        ExceptionsListBox.InvokeIfRequired(
            Sub(listBox)
                listBox.Items.Add(sender)
                listBox.SelectedIndex = listBox.Items.Count - 1
            End Sub)
    End Sub

    Private Sub ExcludeTraverse(sender As String)
        ExcludeListBox.InvokeIfRequired(
            Sub(listBox)
                listBox.Items.Add(sender)
                listBox.SelectedIndex = listBox.Items.Count - 1
            End Sub)
    End Sub

    Private Sub Traversing(sender As String)
        IncludedListBox.InvokeIfRequired(
            Sub(listBox)
                listBox.Items.Add(sender)
                listBox.SelectedIndex = listBox.Items.Count - 1
            End Sub)
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        _cts.Cancel()
    End Sub
End Class