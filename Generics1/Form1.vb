Imports System.Configuration
Imports Generics1.Classes

Public Class Form1
    Public Sub New()
        InitializeComponent()

        Console.SetOut(New ControlWriter(TextBox1))

    End Sub

    Private Sub GetStringButton_Click(sender As Object, e As EventArgs) Handles GetStringButton.Click
        Dim testModeConventional = ConfigurationManager.AppSettings("DatabaseServer")
        Console.WriteLine($"Get TestMode conventional: {testModeConventional}")

        Dim databaseServerWrapper = AppConfiguration.DatabaseServer
        Console.WriteLine($"Get Wrapper: {databaseServerWrapper}")

        Dim databaseServerGeneric = AppConfiguration.ConfigSetting(Of String)("DatabaseServer")
        Console.WriteLine($"Get generic: {databaseServerGeneric}")
        Console.WriteLine()
    End Sub

    Private Sub GetBooleanButton_Click(sender As Object, e As EventArgs) Handles GetBooleanButton.Click
        ' conventional access to a setting
        Dim testModeConventional = Convert.ToBoolean(ConfigurationManager.AppSettings("TestMode"))
        Console.WriteLine($"Get TestMode conventional: {testModeConventional}")

        ' generic access to a setting
        Dim testModeGeneric1 = AppConfiguration.ConfigSetting(Of Boolean)("TestMode")
        Console.WriteLine($"Get TestMode generic: {testModeGeneric1}")

        ' generic access to a setting with wrapper
        Dim testModeGeneric2 = AppConfiguration.TestMode
        Console.WriteLine($"Get TestMode generic wrapper: {testModeGeneric2}")

        Dim testModeGeneric3 = AppConfiguration.TestMode1
        Console.WriteLine(testModeGeneric3)

        Console.WriteLine()
    End Sub

    Private Sub GetTimeSpanButton_Click(sender As Object, e As EventArgs) Handles GetTimeSpanButton.Click
        Dim backupTime = TimeSpan.Parse(ConfigurationManager.AppSettings("BackupTime"))
        Console.WriteLine($"TimeSpan.Parse: {backupTime}")

        Dim testModeGeneric1 = AppConfiguration.GetConfigSetting(Of TimeSpan)("BackupTime")
        Console.WriteLine($"GetConfigSetting: {testModeGeneric1}")

        Try
            Dim testModeGeneric2 = AppConfiguration.ConfigSetting(Of TimeSpan)("BackupTime")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Try
            Dim anotherTest = AppConfiguration.ConvertOrDefault(Of TimeSpan)(ConfigurationManager.AppSettings("BackupTime"))
            Console.WriteLine(anotherTest)
        Catch exception As Exception
            Console.WriteLine(exception)
        End Try

        Console.WriteLine()
    End Sub

    Private Sub GetDateButton_Click(sender As Object, e As EventArgs) Handles GetDateButton.Click
        Dim alertDate1 = Convert.ToDateTime(ConfigurationManager.AppSettings("AlertDate"))
        Console.WriteLine($"Convert.ToDateTime: {alertDate1:d}")

        Dim alertDate2 = AppConfiguration.GetConfigSetting(Of Date)("AlertDate")
        Console.WriteLine($"GetConfigSetting: {alertDate2:d}")

        Dim anotherTest = AppConfiguration.ConvertOrDefault(Of TimeSpan)(ConfigurationManager.AppSettings("AlertDate1"))
        Console.WriteLine(anotherTest)

        Console.WriteLine()
    End Sub
End Class
