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
    ''' <summary>
    ''' Base template for removing a folder structure. Unlike RecursiveFolders
    ''' which has cancellation and error trapping this procedure does not but with a
    ''' little effort it can.
    ''' </summary>
    ''' <param name="directoryInformation"></param>
    Public Shared Sub RecursiveDelete(directoryInformation As DirectoryInfo)

        If Not directoryInformation.Exists Then
            RaiseEvent OnDeleteEvent("Nothing to process")
            Return
        End If

        RaiseEvent OnDeleteEvent(directoryInformation.Name)

        For Each dir As DirectoryInfo In directoryInformation.EnumerateDirectories()
            Try
                RecursiveDelete(dir)
            Catch ex As Exception
                RaiseEvent OnExceptionEvent(ex)
            End Try
        Next

        directoryInformation.Delete(True)

    End Sub
    ''' <summary>
    ''' Process directory tree
    ''' </summary>
    ''' <param name="directoryInfo">Full path wrapped in a DirectoryInfo variable</param>
    ''' <param name="excludeFileExtensions">string array to filter what folders to exclude</param>
    ''' <param name="ct"></param>
    Public Shared Async Function RecursiveFolders(directoryInfo As DirectoryInfo, excludeFileExtensions As String(), ct As CancellationToken) As Task

        If Not directoryInfo.Exists Then
            RaiseEvent OnTraverseEvent("Nothing to process")
            Return
        End If

        If Not excludeFileExtensions.Any(AddressOf directoryInfo.FullName.Contains) Then
            Await Task.Delay(1)
            RaiseEvent OnTraverseEvent(directoryInfo.FullName)
        Else
            RaiseEvent OnTraverseExcludeFolderEvent(directoryInfo.FullName)
        End If

        Try
            Await Task.Run(Async Function()

                               For Each dir As DirectoryInfo In directoryInfo.EnumerateDirectories()
                                   Dim folder = dir

                                   If Not Cancelled Then

                                       Await Task.Delay(1)
                                       Await RecursiveFolders(folder, excludeFileExtensions, ct)

                                   Else
                                       Return
                                   End If

                                   If ct.IsCancellationRequested Then
                                       ct.ThrowIfCancellationRequested()
                                   End If

                               Next

                           End Function)

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

    End Function

End Class
