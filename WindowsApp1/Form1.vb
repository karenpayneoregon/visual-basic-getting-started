Imports System.IO
Imports WinFormExtensions

Public Class Form1
    ''' <summary>
    ''' Expect to find a missing sequence in folder names
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FindMissingButton_Click(sender As Object, e As EventArgs) Handles FindMissingButton.Click
        '
        ' Create a range of letters which over 26 become double letters
        '
        Dim rangeData = Enumerable.Range(1, 100).Select(Function(value) value.ExcelColumnNameFromNumber()).ToArray()
        '
        ' Get folders, in this case there are the following
        '
        ' Folder A, Folder B, Folder C, Folder E, Folder F
        '
        Dim folders = Directory.GetDirectories(Path.Combine(AppDomain.CurrentDomain.BaseDirectory))
        Dim currentData = New List(Of String)

        For Each folder As String In folders
            currentData.Add(New DirectoryInfo(folder).Name.Last())
        Next

        '
        ' Get first missing item in sequence.
        '
        Dim result = rangeData.Except(currentData).ToList().FirstOrDefault

        If Not String.IsNullOrWhiteSpace(result) Then
            MessageBox.Show(result)
        End If

    End Sub
End Class