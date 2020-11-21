Imports System.IO
Imports System.Threading

Public Class OtherExamplesForm
    ''' <summary>
    ''' Provides an opportunity to cancel traversal of folders
    ''' </summary>
    Private _cts As New CancellationTokenSource()

    Private _resultList As List(Of String)
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

        _resultList = New List(Of String)
        ResultsListBox.DataSource = Nothing

        _exceptionList = New List(Of String)
        ExceptionsListBox.DataSource = Nothing

        'Dim errorList As New List(Of String)
        Dim stack As New Stack(Of String)

        stack.Push("C:\Users")

        Try

            Await Task.Run(Async Function()
                               Do While (stack.Count > 0)

                                   Dim strDirectory As String = stack.Pop
                                   Await Task.Delay(1)

                                   If _cts.IsCancellationRequested Then
                                       _cts.Token.ThrowIfCancellationRequested()
                                   End If

                                   Try

                                       _resultList.AddRange(Directory.GetFiles(strDirectory, "*.dll"))

                                       Dim strDirectoryName As String
                                       For Each strDirectoryName In Directory.GetDirectories(strDirectory)
                                           stack.Push(strDirectoryName)
                                       Next

                                   Catch ex As UnauthorizedAccessException
                                       _exceptionList.Add(ex.Message)
                                   End Try
                               Loop
                           End Function)

        Catch ex As OperationCanceledException
            MessageBox.Show($"Cancelled")
        End Try

        ResultsListBox.DataSource = _resultList
        ExceptionsListBox.DataSource = _exceptionList

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        _cts.Cancel()
    End Sub
End Class