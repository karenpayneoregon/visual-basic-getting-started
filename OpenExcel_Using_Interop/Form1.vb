Imports System.IO

Public Class Form1
    Private Sub OpenButton_Click(sender As Object, e As EventArgs) Handles OpenButton.Click

        Dim fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Excel1.xlsx")

        If File.Exists(fileName) Then
            Dim ops = New ExcelOperations
            Dim sheets = ops.GetSheets(fileName)
            ListBox1.DataSource = Nothing
            ListBox1.DataSource = sheets
        Else
            MessageBox.Show($"{fileName} not found")
        End If

    End Sub
End Class
