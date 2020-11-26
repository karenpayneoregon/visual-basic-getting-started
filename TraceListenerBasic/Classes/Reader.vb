Imports System.IO
Imports LogLibrary

Public Class Reader
    Public Function GetLines() As List(Of String)
        Try
            Return File.ReadAllLines("FileHere.txt").ToList()
        Catch e As Exception
            ApplicationTraceListener.Instance.Exception(e)
            Return New List(Of String)()
        End Try
    End Function
End Class
