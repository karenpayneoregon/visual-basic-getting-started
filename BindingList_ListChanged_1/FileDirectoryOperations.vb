Imports System.IO

Public Class FileDirectoryOperations
    Public Delegate Sub OnErrorDelegate(exception As Exception)
    Public Shared Event OnErrorEvent As OnErrorDelegate
    Public Shared Sub CopyFolder(sourcePath As String, destinationPath As String)

        Dim sourceDirectoryInfo As New DirectoryInfo(sourcePath)

        If (sourceDirectoryInfo.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden OrElse
           (sourceDirectoryInfo.Attributes And FileAttributes.System) = FileAttributes.System OrElse
           (sourceDirectoryInfo.Attributes And FileAttributes.ReparsePoint) = FileAttributes.ReparsePoint Then
            Exit Sub

        Else
            ' If the destination folder don't exist then create it
            If Not Directory.Exists(destinationPath) Then
                Directory.CreateDirectory(destinationPath)
            End If

            Dim fileSystemInfo As FileSystemInfo

            Try
                For Each fileSystemInfo In sourceDirectoryInfo.GetFileSystemInfos

                    If (fileSystemInfo.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden OrElse
                       (fileSystemInfo.Attributes And FileAttributes.System) = FileAttributes.System Then
                        Continue For

                    Else
                        Dim destinationFileName As String = Path.Combine(destinationPath, fileSystemInfo.Name)
                        If TypeOf fileSystemInfo Is FileInfo Then
                            File.Copy(fileSystemInfo.FullName, destinationFileName, True)
                        Else
                            CopyFolder(fileSystemInfo.FullName, destinationFileName)
                        End If

                    End If
                Next

            Catch ex As Exception
                RaiseEvent OnErrorEvent(ex)
            End Try

        End If

    End Sub

End Class
