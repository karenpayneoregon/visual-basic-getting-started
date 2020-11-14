Imports System.IO
Imports ScreenLibrary

Public Class Form1
    ''' <summary>
    ''' Capture the current window to disk
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CaptureThisFormToFileButton_Click(sender As Object, e As EventArgs) Handles CaptureThisFormToFileButton.Click

        Dim fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{Name}.jpg")
        Dim screenOperations As New ScreenCapture
        screenOperations.CaptureWindowToFile(Handle, fileName, Imaging.ImageFormat.Jpeg)
        Process.Start(fileName)

    End Sub
End Class
