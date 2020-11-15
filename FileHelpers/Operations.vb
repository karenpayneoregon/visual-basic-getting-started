Imports System.IO

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


End Class
