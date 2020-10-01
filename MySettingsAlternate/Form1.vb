Imports System.IO
Imports MySettingsAlternate.Classes

Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        IncomingFolderTextBox.Text = ApplicationSettings.GetSettingAsString("IncomingFolder")
    End Sub

    Private Sub IncomingFolderButton_Click(sender As Object, e As EventArgs) Handles IncomingFolderButton.Click
        If Not String.IsNullOrWhiteSpace(IncomingFolderTextBox.Text) Then
            Dim originalValue = ApplicationSettings.GetSettingAsString("IncomingFolder")

            If ApplicationSettings.SetValue("IncomingFolder", IncomingFolderTextBox.Text) Then
                Dim currentValue = ApplicationSettings.GetSettingAsString("IncomingFolder")
                MessageBox.Show($"IncomingFolder setting has been updated from {originalValue} to {currentValue}")
            Else
                MessageBox.Show("IncomingFolder failed to update see error log")
            End If
        End If
    End Sub

    Private Sub CrashButton_Click(sender As Object, e As EventArgs) Handles CrashButton.Click

        Dim settingValue = ApplicationSettings.GetSettingAsString("NotASetting")

        If settingValue Is Nothing Then
            MessageBox.Show("Failed getting value see error log")
        End If
    End Sub

    Private Sub OpenErrorLogButton_Click(sender As Object, e As EventArgs) Handles OpenErrorLogButton.Click
        Dim fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UnhandledException.txt")

        If File.Exists(fileName) Then
            Process.Start(fileName)
        Else
            MessageBox.Show("Log file does not exists!")
        End If
    End Sub
End Class
