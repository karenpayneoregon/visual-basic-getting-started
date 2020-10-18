Imports ExtractFilesWithProgress.Classes

Namespace Delegates
    ''' <summary>
    ''' Delegate used for passing timely data from extraction
    ''' of files from a compressed file.
    ''' </summary>
    Public Module DelegatesModule
        Public Delegate Sub ZipEventHandler(sender As Object, e As ZipArgs)
        Public Delegate Sub ZipExceptions(sender As String)
    End Module
End Namespace