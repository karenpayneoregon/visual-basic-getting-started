Imports System.IO
Imports System.IO.Compression

Namespace Classes

    Public Class ZipHelpers
        Public Shared Function GetFiles(zippedFile() As Byte) As Dictionary(Of String, Byte())
            Using ms As New MemoryStream(zippedFile)
                Using archive As New ZipArchive(ms, ZipArchiveMode.Read)
                    Return archive.Entries.ToDictionary(Function(x) x.FullName, Function(x) ReadStream(x.Open()))
                End Using
            End Using
        End Function

        Private Shared Function ReadStream(stream As Stream) As Byte()
            Using ms = New MemoryStream()
                stream.CopyTo(ms)
                Return ms.ToArray()
            End Using
        End Function

        Private Shared ReadOnly SizeSuffixes() As String = {"bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB"}

        Public Shared Function SizeSuffix(value As Int64, Optional decimalPlaces As Integer = 1) As String

            If value < 0 Then
                Return "-" & SizeSuffix(-value)
            End If

            Dim i As Integer = 0
            Dim dValue As Decimal = CDec(value)
            Do While Math.Round(dValue, decimalPlaces) >= 1000
                dValue /= 1024
                i += 1
            Loop

            Return String.Format("{0:n" & decimalPlaces & "} {1}", dValue, SizeSuffixes(i))
        End Function
    End Class
End Namespace