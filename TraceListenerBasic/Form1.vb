Imports LogLibrary

Public Class Form1
    Private Sub FileDoesNotExistsButton_Click(sender As Object, e As EventArgs) _
        Handles FileDoesNotExistsButton.Click

        Dim fileOperations = New Reader()
        fileOperations.GetLines()

    End Sub

    Private Sub WriteSomeTextAsInformationButton_Click(sender As Object, e As EventArgs) _
        Handles WriteSomeTextAsInformationButton.Click

        ApplicationTraceListener.Instance.Info("hello from a button click")

    End Sub

    Private Sub WriteSomeTextAsWarningButton_Click(sender As Object, e As EventArgs) _
        Handles WriteSomeTextAsWarningButton.Click

        ApplicationTraceListener.Instance.Warning("A simple warning")

    End Sub
End Class
