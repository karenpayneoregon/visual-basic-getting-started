Imports System.Threading
Imports Classes
Imports Classes.Classes


Partial Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub

    Private _cancellationTokenSource As New CancellationTokenSource()

    Private folderName As String = "C:\Program Files (x86)"
    Private searchFor As String = "THE SOFTWARE IS PROVIDED"

    Private Async Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click

        FolderNameListBox.DataSource = Nothing

        ErrorListBox.Items.Clear()

        If _cancellationTokenSource.IsCancellationRequested Then
            _cancellationTokenSource.Dispose()
            _cancellationTokenSource = New CancellationTokenSource()
        End If

        Dim operations As New Operations()

        AddHandler operations.OnIterate_Conflict, AddressOf IterateFolders

        Try

            Dim foundFiles = Await operations.IterateFolders(folderName, searchFor, _cancellationTokenSource.Token)

            If Not operations.FolderExists Then
                MessageBox.Show($"{folderName}{Environment.NewLine} does not exists")
            ElseIf foundFiles.Count = 0 Then
                MessageBox.Show("No matches")
            End If

            FolderNameListBox.DataSource = foundFiles
            CurrentFileLabel.Text = ""

        Catch oce As OperationCanceledException
            '
            ' Land here from token.ThrowIfCancellationRequested()
            ' thrown in Run method from a cancel request in this
            ' form's Cancel button
            '
            MessageBox.Show("Operation cancelled")
        Catch ex As Exception
            '
            ' Handle any unhandled exceptions
            '
            MessageBox.Show(ex.Message)
        Finally
            '
            ' Success or failure reenable the Run button
            '
            StartButton.Enabled = True

        End Try

    End Sub
    ''' <summary>
    ''' Show current file on each iteration along
    ''' with if there were permission issues reading.
    ''' </summary>
    ''' <param name="args"></param>
    Private Sub IterateFolders(args As MonitorProgressArgs)

        If args.CurrentFileName.Contains("Access denied") Then
            ErrorListBox.Items.Add(args.CurrentFileName)
        Else
            CurrentFileLabel.Text = args.CurrentFileName
        End If

    End Sub
    ''' <summary>
    ''' Cancel operation
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        _cancellationTokenSource.Cancel()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        AddHandler FolderNameListBox.DoubleClick, AddressOf FolderListBoxDoubleClicked
    End Sub

    Private Sub FolderListBoxDoubleClicked(sender As Object, e As EventArgs)
        If FolderNameListBox.Items.Count > 0 Then
            Try
                Process.Start(FolderNameListBox.Text)
            Catch ex As Exception
                MessageBox.Show("Failed to open file")
            End Try
        End If
    End Sub

#Region "Done when converting from C#"

    Private Shared _DefaultInstance As Form1
    Public Shared ReadOnly Property DefaultInstance() As Form1
        Get
            If _DefaultInstance Is Nothing OrElse _DefaultInstance.IsDisposed Then
                _DefaultInstance = New Form1()
            End If

            Return _DefaultInstance
        End Get
    End Property
End Class

#End Region