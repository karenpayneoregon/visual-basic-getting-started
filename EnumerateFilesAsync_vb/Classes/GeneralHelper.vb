Option Infer On
Imports System.IO
Imports Microsoft.Win32

Namespace ChunkIncomingTextFile.Classes
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
    End Class
End Namespace
