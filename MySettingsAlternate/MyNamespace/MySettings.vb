Imports System.IO
Imports MySettingsAlternate.Classes
Imports MySettingsAlternate.Classes.Json

Namespace My
    ''' <summary>
    ''' There are two different configurations here, one for app.config and
    ''' one for json.
    ''' </summary>
    Partial Class MySettings
        ''' <summary>
        ''' Last time application ran as date for app.config
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property LastRanAsDate() As DateTime
            Get
                Return ApplicationSettings.LastRanAsDate()
            End Get
        End Property
        ''' <summary>
        ''' Set last ran date for json
        ''' </summary>
        Public Sub SetLastRunDate()
            Dim myApp = ReadJsonSetting
            myApp.LastRan = Now
            SaveJsonSettings(myApp)
        End Sub
        ''' <summary>
        ''' Last time application ran as string for app.config
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property LastRan() As String
            Get
                Return ApplicationSettings.LastRan()
            End Get
        End Property
        ''' <summary>
        ''' Get main window title for app.config  for app.config
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property MainWindowTitle() As String
            Get
                Return ApplicationSettings.MainWindowTitle()
            End Get
        End Property
        ''' <summary>
        ''' Get main window title from json file
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property MainWindowTitleJson() As String
            Get
                Return ReadJsonSetting.MainWindowTitle
            End Get
        End Property
        ''' <summary>
        ''' Set main window tile to json file
        ''' </summary>
        ''' <param name="title"></param>
        Public Sub SetMainWindowTitleJson(title As String)
            Dim myApp = ReadJsonSetting
            myApp.MainWindowTitle = title
            SaveJsonSettings(myApp)
        End Sub
        ''' <summary>
        ''' Get mail addresses for app.config
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property MailAddresses() As List(Of MailItem)
            Get
                Return ApplicationSettings.MailAddresses()
            End Get
        End Property
        ''' <summary>
        ''' Get database connection string  for app.config
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property ConnectionString() As String
            Get
                Return ApplicationSettings.DatabaseConnectionString()
            End Get
        End Property
        ''' <summary>
        ''' Set last ran date for app.config
        ''' </summary>
        Public Sub SetLastRan()
            ApplicationSettings.SetLastRan()
        End Sub
        '
        ' The following is for json setting example
        '
        Private _fileName As String
        Private ReadOnly _fileOperations As New JsonFileOperations
        ''' <summary>
        ''' Read json configuration file settings
        ''' </summary>
        ''' <returns><see cref="MyApplicationJson"/></returns>
        Public ReadOnly Property ReadJsonSetting() As MyApplicationJson
            Get
                Return _fileOperations.LoadApplicationData(_fileName)
            End Get
        End Property
        ''' <summary>
        ''' Save json setting
        ''' </summary>
        ''' <param name="settings"><see cref="MyApplicationJson"/></param>
        Public Sub SaveJsonSettings(settings As MyApplicationJson)
            _fileOperations.SaveApplicationData(settings, _fileName)
        End Sub
        Public Sub New()
            _fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Settings.json")
        End Sub
        ''' <summary>
        ''' File name for json settings
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property JsonFileName() As String
            Get
                Return _fileName
            End Get
        End Property
    End Class

End Namespace
