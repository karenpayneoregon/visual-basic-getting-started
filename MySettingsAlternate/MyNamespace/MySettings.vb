Imports MySettingsAlternate.Classes

Namespace My
    Partial Class MySettings
        ''' <summary>
        ''' Last time application ran as date
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property LastRanAsDate() As DateTime
            Get
                Return ApplicationSettings.LastRanAsDate()
            End Get
        End Property
        ''' <summary>
        ''' Last time application ran as string
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property LastRan() As String
            Get
                Return ApplicationSettings.LastRan()
            End Get
        End Property
        ''' <summary>
        ''' Get main window title
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property MainWindowTitle() As String
            Get
                Return ApplicationSettings.MainWindowTitle()
            End Get
        End Property
        ''' <summary>
        ''' Get mail addresses
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property MailAddresses() As List(Of MailItem)
            Get
                Return ApplicationSettings.MailAddresses()
            End Get
        End Property
        ''' <summary>
        ''' Get work mail address
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property WorkMailAddress() As MailItem
            Get
                Return MailAddresses.FirstOrDefault(Function(mailItem) mailItem.ConfigurationName = "smtp_Work")
            End Get
        End Property
        ''' <summary>
        ''' Get home mail address
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property HomeMailAddress() As MailItem
            Get
                Return MailAddresses.FirstOrDefault(Function(mailItem) mailItem.ConfigurationName = "smtp_Home")
            End Get
        End Property
        ''' <summary>
        ''' Get database connection string
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property ConnectionString() As String
            Get
                Return ApplicationSettings.DatabaseConnectionString()
            End Get
        End Property
        Public Sub SetLastRan()
            ApplicationSettings.SetLastRan()
        End Sub
    End Class

End Namespace
