Imports System.IO
Imports FileHelpers

Public Class Form1
    Private Sub RemoveFoldersButton_Click(sender As Object, e As EventArgs) Handles RemoveFoldersButton.Click
        Operations.RecursiveDelete(New DirectoryInfo("C:\OED\Dotnetland\vbGettingStarted"))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Operations.OnExceptionEvent, AddressOf ExceptionEvent
        AddHandler Operations.OnDeleteEvent, AddressOf DeletingEvent
    End Sub

    Private Sub DeletingEvent(item As String)
        Console.WriteLine(item)
    End Sub

    Private Sub ExceptionEvent(exception As Exception)
        Console.WriteLine(exception.Message)
    End Sub
End Class
