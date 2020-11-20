Imports System.IO
Imports System.Threading
Public Class Operations
    Public Delegate Sub OnDelete(status As String)
    ''' <summary>
    ''' Callback for subscribers to see what is being worked on
    ''' </summary>
    Public Shared Event OnDeleteEvent As OnDelete

    Public Delegate Sub OnException(exception As Exception)
    ''' <summary>
    ''' Callback for subscribers to know about a problem
    ''' </summary>
    Public Shared Event OnExceptionEvent As OnException


    Public Delegate Sub OnTraverseFolder(status As String)
    ''' <summary>
    ''' Callback for when a folder is being processed
    ''' </summary>
    Public Shared Event OnTraverseEvent As OnTraverseFolder

    Public Delegate Sub OnTraverseExcludeFolder(sender As String)
    ''' <summary>
    ''' Callback when a folder is being excluded
    ''' </summary>
    Public Shared Event OnTraverseExcludeFolderEvent As OnTraverseExcludeFolder
    ''' <summary>
    ''' For traversing folders, if a cancellation is requested stop processing folders.
    ''' </summary>
    Public Shared Cancelled As Boolean = False

    Public Shared Sub RecursiveDelete(baseDir As DirectoryInfo)

        If Not baseDir.Exists Then
            RaiseEvent OnDeleteEvent("Nothing to process")
            Return
        End If

        RaiseEvent OnDeleteEvent(baseDir.Name)

        For Each dir As DirectoryInfo In baseDir.EnumerateDirectories()
            Try
                RecursiveDelete(dir)
            Catch ex As Exception


                RaiseEvent OnExceptionEvent(ex)
            End Try
        Next

        baseDir.Delete(True)

    End Sub
    ''' <summary>
    ''' Process directory tree
    ''' </summary>
    ''' <param name="baseDir">Full path</param>
    ''' <param name="exclude">string array to filter what folders to exclude</param>
    ''' <param name="ct"></param>
    Public Shared Async Sub RecursiveFolders(baseDir As DirectoryInfo, exclude As String(), ct As CancellationToken)
        If Not baseDir.Exists Then
            RaiseEvent OnTraverseEvent("Nothing to process")
            Return
        End If

        If Not exclude.Any(AddressOf baseDir.FullName.Contains) Then
            RaiseEvent OnTraverseEvent(baseDir.FullName)
        Else
            RaiseEvent OnTraverseExcludeFolderEvent(baseDir.FullName)
        End If

        For Each dir As DirectoryInfo In baseDir.EnumerateDirectories()
            Try

                Dim folder = dir

                If Not Cancelled Then

                    Await Task.Run(Async Function()
                                       Await Task.Delay(10)
                                       RecursiveFolders(folder, exclude, ct)
                                   End Function)
                Else
                    Return
                End If


                If ct.IsCancellationRequested Then
                    ct.ThrowIfCancellationRequested()
                End If

            Catch ex As Exception
                '
                ' Only raise exceptions, not cancellation request
                '
                If TypeOf ex Is OperationCanceledException Then
                    Cancelled = True
                Else
                    RaiseEvent OnExceptionEvent(ex)
                End If

            End Try
        Next
    End Sub

End Class
