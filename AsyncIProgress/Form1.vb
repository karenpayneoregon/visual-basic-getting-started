Imports System.Threading

Public Class Form1
    Private _cts As New CancellationTokenSource()
    Public Sub New()
        InitializeComponent()

        StatusLabel.Text = ""

    End Sub
    Private Async Function AsyncMethod(progress As IProgress(Of Integer), ct As CancellationToken) As Task

        For index As Integer = 100 To 120
            'Simulate an async call that takes some time to complete
            Await Task.Delay(500)

            If ct.IsCancellationRequested Then
                ct.ThrowIfCancellationRequested()
            End If

            'Report progress
            If progress IsNot Nothing Then
                progress.Report(index)
            End If

        Next

    End Function

    Private Async Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click

        Dim cancelled = False
        '
        ' Reset if needed, if was ran and cancelled before
        '
        If _cts.IsCancellationRequested = True Then
            _cts.Dispose()
            _cts = New CancellationTokenSource()
        End If

        'Instantiate progress indicator.
        'In this example this reports an Integer as progress, but
        'we could actually report a complex object providing more
        'information such as current operation
        Dim progressIndicator = New Progress(Of Integer)(AddressOf ReportProgress)
        Try
            'Call async method, pass progress indicator and cancellation token as parameters
            Await AsyncMethod(progressIndicator, _cts.Token)
        Catch ex As OperationCanceledException
            StatusLabel.Text = "Cancelled"
            cancelled = True
        End Try

        If cancelled Then
            Await Task.Delay(1000)
            StatusLabel.Text = "Go again!"
        End If

    End Sub
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancellButton.Click
        _cts.Cancel()
    End Sub
    Private Sub ReportProgress(value As Integer)
        StatusLabel.Text = value.ToString()
    End Sub

End Class
