Namespace Classes
    ''' <summary>
    ''' Provide SMTP configuration read from app.config for
    ''' sending email messages.
    ''' </summary>
    Public Class MailItem
        ''' <summary>
        ''' Display in a control
        ''' </summary>
        ''' <returns></returns>
        Public Property DisplayName() As String
        ''' <summary>
        ''' Name from app.config with smtp_ taken off the name. There
        ''' can be other naming conventions while this one is clear feel
        ''' free to change.
        ''' </summary>
        ''' <returns></returns>
        Public Property ConfigurationName() As String
        ''' <summary>
        ''' Container with all properties used for a mail message
        ''' </summary>
        ''' <returns></returns>
        Public Property MailConfiguration() As MailConfiguration
        ''' <summary>
        ''' From email address
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property From() As String
            Get
                Return MailConfiguration.FromAddress
            End Get
        End Property
        ''' <summary>
        ''' Host to use for sending mail
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Host() As String
            Get
                Return MailConfiguration.Host
            End Get
        End Property
        ''' <summary>
        ''' User name for sending email messages
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property UserName() As String
            Get
                Return MailConfiguration.UserName
            End Get
        End Property
        ''' <summary>
        ''' Password for sending email messages, might be wise
        ''' to encrypt.
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Password() As String
            Get
                Return MailConfiguration.Password
            End Get
        End Property
        ''' <summary>
        ''' Port for sending email
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Port() As Integer
            Get
                Return MailConfiguration.Port
            End Get
        End Property
        ''' <summary>
        ''' Indicates if default credentials should be used
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property DefaultCredentials() As Boolean
            Get
                Return MailConfiguration.DefaultCredentials
            End Get
        End Property
        ''' <summary>
        ''' SSL enabled
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property EnableSsl() As Boolean
            Get
                Return MailConfiguration.EnableSsl
            End Get
        End Property
        ''' <summary>
        ''' For unit testing
        ''' </summary>
        ''' <returns>Name of pickup folder</returns>
        Public ReadOnly Property PickupFolder() As String
            Get
                Return MailConfiguration.PickupFolder
            End Get
        End Property
        ''' <summary>
        ''' Does the Pickup folder exists
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property PickupFolderExists() As Boolean
            Get
                Return MailConfiguration.PickupFolderExists()
            End Get
        End Property
        Public Overrides Function ToString() As String
            Return DisplayName
        End Function
    End Class
End Namespace