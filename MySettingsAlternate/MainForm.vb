Imports System.IO
Imports System.Text
Imports MySettingsAlternate.Classes

Public Class MainForm
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        IncomingFolderTextBox.Text = ApplicationSettings.GetSettingAsString("IncomingFolder")

        Text = ApplicationSettings.MainWindowTitle()

        ConnectionStringTextBox.Text = ApplicationSettings.DatabaseConnectionString()

        LastRanTextBox.Text = ApplicationSettings.LastRan()

        WindowTitleTextBox.Text = ApplicationSettings.MainWindowTitle()


        IncomingFolderTextBox.Select(0, 0)

        '
        ' Subscribe to events for run time exceptions working with the configuration settings
        '
        AddHandler ApplicationSettings.OnSettingsErrorEvent, AddressOf SettingsException
        AddHandler ApplicationSettings.OnGetKeyErrorEvent, AddressOf GetException

        PopulateApplicationListView()

        If ApplicationSettings.IsTestMode() Then
            BackColor = Color.Cornsilk
            TestBoxCheckBox.Checked = True
        End If

        AddHandler ApplicationSettings.OnSettingChangedEvent, AddressOf GettingChanged
        Console.WriteLine(ApplicationSettings.importMinutesToPause())
    End Sub
    ''' <summary>
    ''' Display settings. If TestMode has changed we need to unsubscribe else will
    ''' end up with a recursive call thus a StackOverflowException exception,
    ''' </summary>
    ''' <param name="key">Key in config file which changed</param>
    ''' <param name="value">New value for key</param>
    Private Sub GettingChanged(key As String, value As String)
        Dim lines = ResultsTextBox.Lines.ToList()
        lines.Add($"Key '{key}' changed to '{value}'")
        ResultsTextBox.Lines = lines.ToArray()
        PopulateApplicationListView()

        If key = "TestMode" Then

            RemoveHandler ApplicationSettings.OnSettingChangedEvent, AddressOf GettingChanged

            If ApplicationSettings.IsTestMode() Then
                BackColor = Color.Cornsilk
            Else
                BackColor = Nothing
            End If

            ApplicationSettings.SetTestMode(TestBoxCheckBox.Checked)
            AddHandler ApplicationSettings.OnSettingChangedEvent, AddressOf GettingChanged

        End If

    End Sub

    ''' <summary>
    ''' Event is raised when a key was not located in the configuration file.
    ''' </summary>
    ''' <param name="key"></param>
    ''' <param name="ex"></param>
    Private Sub GetException(key As String, ex As Exception)
        Dim lines = ResultsTextBox.Lines.ToList()
        lines.Add($"Failed to get '{key}', reason: '{ex.Message}'")
        ResultsTextBox.Lines = lines.ToArray()
    End Sub
    ''' <summary>
    ''' Event is raised when they key does not exists in the configuration file.
    ''' </summary>
    ''' <param name="args"></param>
    Private Sub SettingsException(args As ApplicationSettingError)
        Dim lines = ResultsTextBox.Lines.ToList()
        lines.Add($"Error setting value for {args.Key} - {args.Exception.Message}")
        ResultsTextBox.Lines = lines.ToArray()
    End Sub
    ''' <summary>
    ''' Set the IncomingFolder in application configuration file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub IncomingFolderButton_Click(sender As Object, e As EventArgs) Handles IncomingFolderButton.Click
        If Not String.IsNullOrWhiteSpace(IncomingFolderTextBox.Text) Then
            Dim originalValue = ApplicationSettings.GetSettingAsString("IncomingFolder")

            If ApplicationSettings.SetIncomingFolder(IncomingFolderTextBox.Text) Then
                Dim currentValue = ApplicationSettings.GetSettingAsString("IncomingFolder")
                'MessageBox.Show($"IncomingFolder setting has been updated from {originalValue} to {currentValue}")
            Else
                MessageBox.Show("IncomingFolder failed to update see error log")
            End If
        End If
    End Sub
    Private Sub UpdateWindowTitleButton_Click(sender As Object, e As EventArgs) Handles UpdateWindowTitleButton.Click
        If Not String.IsNullOrWhiteSpace(WindowTitleTextBox.Text) Then
            Dim originalValue = ApplicationSettings.MainWindowTitle()

            If ApplicationSettings.SetMainWindowTitle(WindowTitleTextBox.Text) Then
                Dim currentValue = ApplicationSettings.MainWindowTitle()
                Text = currentValue
            Else
                MessageBox.Show("Window title, failed to update see error log")
            End If
        End If
    End Sub
    ''' <summary>
    ''' Attempt to get a value for a key in the configuration file where in this
    ''' case the key does not exists.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CrashOnGetNonExistingKeyButton_Click(sender As Object, e As EventArgs) Handles CrashOnGetNonExistingKeyButton.Click

        Dim settingValue = ApplicationSettings.GetSettingAsString("NotASetting")

        If settingValue Is Nothing Then
            MessageBox.Show("Failed getting value see error log")
        End If

    End Sub
    Private Sub CrashOnSetNonExistingKeyButton_Click(sender As Object, e As EventArgs) Handles CrashOnSetNonExistingKeyButton.Click
        ApplicationSettings.SetValue("NotASetting", "Apples")
    End Sub

    Private Sub OpenErrorLogButton_Click(sender As Object, e As EventArgs) Handles OpenErrorLogButton.Click
        Dim fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UnhandledException.txt")

        If File.Exists(fileName) Then
            Process.Start(fileName)
        Else
            MessageBox.Show("Log file does not exists!")
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ApplicationSettings.SetLastRan()
    End Sub

    Private Sub MyApplicationPropertiesButton_Click(sender As Object, e As EventArgs) Handles MyApplicationPropertiesButton.Click
        PopulateApplicationListView()
    End Sub
    Private Sub KeyExistsButton_Click(sender As Object, e As EventArgs) Handles KeyExistsButton.Click

        Dim sb As New StringBuilder
        Dim keyList As New List(Of String) From {"DatabaseServer", "Catalog", "BadApple"}

        For Each keyName As String In keyList
            sb.AppendLine($"Key '{keyName}' exists: {ApplicationSettings.KeyExists(keyName)}")
        Next

        MessageBox.Show(sb.ToString())

    End Sub
    Private Sub GetMyApplicationDynamicallyButton_Click(sender As Object, e As EventArgs) Handles GetMyApplicationDynamicallyButton.Click
        Dim sb As New StringBuilder
        Dim myApplication = ApplicationSettings.CreateMyApplicationDynamically()

        sb.AppendLine($"Connection string: [{myApplication.ConnectionString}]")
        sb.AppendLine($"Minutes to pause: [{myApplication.ImportMinutesToPause}]")
        sb.AppendLine($"IncomingFolder: [{myApplication.IncomingFolder}]")
        sb.AppendLine($"Last ran: [{myApplication.LastRan}]")
        sb.AppendLine($"Main Title: [{myApplication.MainWindowTitle}]")
        sb.AppendLine($"Test mode: [{myApplication.TestMode}]")

        MessageBox.Show(sb.ToString())

    End Sub
    Private Sub PopulateApplicationListView()
        Dim properties = ApplicationSettings.Application()
        AppSettingsListView.Items.Clear()

        Dim lastRan As New ListViewItem("Last ran", 0)
        lastRan.SubItems.Add(properties.LastRan.ToString())

        Dim IncomingFolder As New ListViewItem("Incoming Folder", 1)
        IncomingFolder.SubItems.Add(properties.IncomingFolder)

        Dim WindowTitle As New ListViewItem("Window Title", 2)
        WindowTitle.SubItems.Add(properties.MainWindowTitle)

        AppSettingsListView.Items.AddRange(New ListViewItem() {lastRan, IncomingFolder, WindowTitle})

        AppSettingsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

    End Sub

    Private Async Sub OpenDatabaseButton_Click(sender As Object, e As EventArgs) Handles OpenDatabaseButton.Click

        OpenDatabaseButton.Enabled = False

        Try
            If Await DataOperations.OpenDatabaseConnection() Then
                MessageBox.Show("Open successfully")
            Else
                MessageBox.Show("Failed to open")
            End If
        Finally
            OpenDatabaseButton.Enabled = True
        End Try


    End Sub

    Private Sub ChangeConnectionStringButton_Click(sender As Object, e As EventArgs) Handles ChangeConnectionStringButton.Click
        Dim settingForm As New DatabaseSettingsForm
        Try
            settingForm.ShowDialog()
            ConnectionStringTextBox.Text = ApplicationSettings.DatabaseConnectionString()
        Finally
            settingForm.Dispose()
        End Try
    End Sub

    Private Sub TestBoxCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TestBoxCheckBox.CheckedChanged
        ApplicationSettings.SetValue("TestMode", TestBoxCheckBox.Checked.ToString())
    End Sub


End Class
