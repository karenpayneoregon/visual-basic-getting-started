Option Infer On

Imports System.IO
Imports Microsoft.Win32

Namespace Classes
    ''' <summary>
    ''' NotePad++
    ''' </summary>
    Public Enum NotePadPlusStatus
        ''' <summary>
        ''' Installed
        ''' </summary>
        Installed
        ''' <summary>
        ''' Not installed
        ''' </summary>
        NotInstalled
        ''' <summary>
        ''' Can not detect if installed
        ''' </summary>
        ErrorReadingRegistry
    End Enum
    ''' <summary>
    ''' NotePad++ helpers
    ''' </summary>
    Public Class GeneralHelper
        ''' <summary>
        ''' Determine if NotePad++ is installed. If registry can not
        ''' be read false is returned.
        ''' </summary>
        ''' <returns>installed, not installed or error reading system registry</returns>
        Public Shared Function IsNotePadPlus() As NotePadPlusStatus
            Try
                Dim nppDir = DirectCast(Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Notepad++", Nothing, Nothing), String)
                Dim nppExePath = Path.Combine(nppDir, "Notepad++.exe")
                Return If(File.Exists(nppExePath), NotePadPlusStatus.Installed, NotePadPlusStatus.NotInstalled)
            Catch e As Exception
                Return NotePadPlusStatus.ErrorReadingRegistry
            End Try
        End Function
        ''' <summary>
        ''' Provides a way to iterate folders with multiple extensions e.g. .doc|.docx
        ''' </summary>
        ''' <param name="path"></param>
        ''' <param name="patterns"></param>
        ''' <returns></returns>
        Public Shared Iterator Function MultiEnumerateFiles(path As String, patterns As String) As IEnumerable(Of String)

            For Each pattern In patterns.Split("|"c)
                For Each file In Directory.EnumerateFiles(path, pattern, SearchOption.AllDirectories)
                    Yield file
                Next
            Next
        End Function

    End Class

End Namespace
