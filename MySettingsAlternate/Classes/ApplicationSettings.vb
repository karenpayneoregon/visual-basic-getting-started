Imports System.Configuration
Imports System.IO

Namespace Classes
    Public Class ApplicationSettings

        Public Delegate Sub OnErrorSettingDelegate(args As ApplicationSettingError)
        Public Delegate Sub OnErrorGetDelegate(key As String, ex As Exception)
        Public Delegate Sub OnSettingChangedDelegate(key As String, value As String)

        ''' <summary>
        ''' Provides access to when an exception is thrown when a value can not be set
        ''' </summary>
        Public Shared Event OnSettingsErrorEvent As OnErrorSettingDelegate
        ''' <summary>
        ''' provides access when a key in the configuration file is not found in the configuration file
        ''' </summary>
        Public Shared Event OnGetKeyErrorEvent As OnErrorGetDelegate
        ''' <summary>
        ''' Provides access to a setting changed
        ''' </summary>
        Public Shared Event OnSettingChangedEvent As OnSettingChangedDelegate

        ''' <summary>
        ''' Get app setting as string from application file. If configKey is not located an exception is thrown without
        ''' anything to indicate this but will throw a runtime exception from the calling method.
        ''' </summary>
        ''' <param name="configKey">Key in app.config</param>
        ''' <returns>Key value or an empty string</returns>
        Public Shared Function GetSettingAsString(configKey As String) As String

            Dim value As String = Nothing

            Try

                value = ConfigurationManager.AppSettings(configKey)

                If value Is Nothing Then
                    Throw New Exception($"Setting {configKey} not found")
                End If

            Catch e As Exception
                RaiseEvent OnGetKeyErrorEvent(configKey, e)
                Exceptions.Write(e)
            End Try

            Return value

        End Function
        ''' <summary>
        ''' Get a key in the configuration file as a date
        ''' </summary>
        ''' <param name="configKey">Key to read</param>
        ''' <returns></returns>
        Public Shared Function GetSettingAsDateTime(configKey As String) As DateTime

            Dim value As String = Nothing
            Dim result As DateTime

            Try

                value = ConfigurationManager.AppSettings(configKey)

                If value Is Nothing Then
                    Throw New Exception($"Setting {configKey} not found")
                End If


                If Not DateTime.TryParse(value, result) Then
                    Throw New Exception($"Invalid value in app config for {configKey}")
                End If
            Catch e As Exception

                RaiseEvent OnGetKeyErrorEvent(configKey, e)
                Exceptions.Write(e)
            End Try

            Return result

        End Function
        ''' <summary>
        ''' Get a key in the configuration file as a date
        ''' </summary>
        ''' <param name="configKey">Key to read</param>
        ''' <returns></returns>
        Public Shared Function GetSettingAsInteger(configKey As String) As Integer

            Dim value As String = Nothing
            Dim result As Integer

            Try

                value = ConfigurationManager.AppSettings(configKey)

                If value Is Nothing Then
                    Throw New Exception($"Setting {configKey} not found")
                End If


                If Not Integer.TryParse(value, result) Then
                    Throw New Exception($"Invalid value in app config for {configKey}")
                End If
            Catch e As Exception

                RaiseEvent OnGetKeyErrorEvent(configKey, e)
                Exceptions.Write(e)
            End Try

            Return result

        End Function
        ''' <summary>
        ''' Set a app setting key value
        ''' </summary>
        ''' <param name="key">Key in app setting</param>
        ''' <param name="value">Value for key</param>
        Public Shared Function SetValue(key As String, value As String) As Boolean

            Dim success As Boolean = True

            Try
                Dim applicationDirectoryName = Path.GetDirectoryName(Reflection.Assembly.GetExecutingAssembly().Location)
                Dim configFile = Path.Combine(applicationDirectoryName, $"{Reflection.Assembly.GetExecutingAssembly().GetName().Name}.exe.config")
                Dim configFileMap = New ExeConfigurationFileMap With {.ExeConfigFilename = configFile}
                Dim config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None)

                If config.AppSettings.Settings(key) Is Nothing Then
                    Throw New Exception($"Key {key} does not exist")
                End If

                config.AppSettings.Settings(key).Value = value

                config.Save()

                ConfigurationManager.RefreshSection("appSettings")
                RaiseEvent OnSettingChangedEvent(key, value)

            Catch e As Exception
                RaiseEvent OnSettingsErrorEvent(New ApplicationSettingError() With {.Key = key, .Value = value, .Exception = e})
                Exceptions.Write(e)
                success = False
            End Try

            Return success

        End Function
        ''' <summary>
        ''' Set last running of the app
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function SetLastRan() As Boolean
            Return SetValue("LastRan", Now.ToString())
        End Function
        ''' <summary>
        ''' Set Incoming folder
        ''' </summary>
        ''' <param name="value"></param>
        ''' <returns></returns>
        Public Shared Function SetIncomingFolder(value As String) As Boolean
            Return SetValue("IncomingFolder", value)
        End Function
        ''' <summary>
        ''' Get incoming folder
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function GetIncomingFolder() As String
            Return GetSettingAsString("IncomingFolder")
        End Function
        ''' <summary>
        ''' Get main window title
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function MainWindowTitle() As String
            Return GetSettingAsString("MainWindowTitle")
        End Function
        ''' <summary>
        ''' Set main form/window title (Text property)
        ''' </summary>
        ''' <param name="value"></param>
        ''' <returns></returns>
        Public Shared Function SetMainWindowTitle(value As String) As Boolean
            Return SetValue("MainWindowTitle", value)
        End Function
        ''' <summary>
        ''' Minutes to pause for various operations as milliseconds 
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function importMinutesToPause() As Integer
            Return GetSettingAsInteger("importMinutesToPause") * 1000
        End Function
        'LastCategoryIdentifier
        Public Shared Function LastCategoryIdentifier() As Integer
            Return GetSettingAsInteger("LastCategoryIdentifier")
        End Function
        Public Shared Function SetLastCategoryIdentifier(value As Integer) As Integer
            SetValue("LastCategoryIdentifier", value.ToString())
        End Function

        ''' <summary>
        ''' Get last run date as string
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function LastRan() As String
            Return LastRanAsDate().ToString()
        End Function
        Public Shared Function LastRanAsDate() As DateTime
            Return GetSettingAsDateTime("LastRan")
        End Function
        ''' <summary>
        ''' Determine if the application should be in test mode
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function IsTestMode() As Boolean
            Return CBool(GetSettingAsString("TestMode"))
        End Function
        Public Shared Sub SetTestMode(value As Boolean)
            SetValue("TestMode", value.ToString())
        End Sub
        ''' <summary>
        ''' SQL-Server database string
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function DatabaseConnectionString() As String
            Return $"Data Source= {GetSettingAsString("DatabaseServer")};Initial Catalog={GetSettingAsString("Catalog")};Integrated Security=True"
        End Function
        ''' <summary>
        ''' Finish up
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function Application() As MyApplication

            Return New MyApplication() With {
                .IncomingFolder = GetIncomingFolder(),
                .MainWindowTitle = MainWindowTitle(),
                .DatabaseServer = GetSettingAsString("DatabaseServer"),
                .Catalog = GetSettingAsString("Catalog"),
                .LastRan = GetSettingAsDateTime("LastRan")
            }

        End Function
        ''' <summary>
        ''' Determine if a key exists
        ''' </summary>
        Public Shared Sub AllKeys()
            Dim keys = ConfigurationManager.AppSettings.AllKeys.Select(Function(item) New With {.Name = item, .Value = ConfigurationManager.AppSettings(item)})
        End Sub

        ''' <summary>
        ''' Determine if a key exists
        ''' </summary>
        Public Shared Function KeyExists(key As String) As Boolean
            Dim result = ConfigurationManager.AppSettings.AllKeys.FirstOrDefault(Function(keyName) keyName = key)
            Return result IsNot Nothing
        End Function
        ''' <summary>
        ''' Populate <see cref="MyApplication"/> instance dynamically
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function CreateMyApplicationDynamically() As MyApplication

            Dim propertyInfo = GetType(MyApplication).
                    GetProperties().
                    Where(Function(p) p.CanWrite).
                    Select(Function(p) New With {
                              .PropertyName = p.Name,
                              .Value = ConfigurationManager.AppSettings(p.Name)
                              }).
                    ToList()

            Dim myApplication As New MyApplication()

            For Each anonymous In propertyInfo
                Dim propertyValue As Object = anonymous.Value
                myApplication.SetPropertyValue(anonymous.PropertyName, propertyValue)
            Next


            Return myApplication

        End Function

        Public Shared Function MailAddresses() As List(Of MailItem)
            Dim emailList As New List(Of MailItem)
            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            Dim myCollect As ConfigurationSectionGroupCollection = config.SectionGroups

            For Each configurationSectionGroup As ConfigurationSectionGroup In myCollect

                For Each configurationSection As ConfigurationSection In configurationSectionGroup.Sections
                    Dim sectionName As String = configurationSection.SectionInformation.Name.ToString()


                    If sectionName.StartsWith("smtp") Then
                        Dim mc As MailConfiguration = New MailConfiguration($"mailSettings/{sectionName}")
                        Dim mailItem As New MailItem With {
                                .DisplayName = sectionName.Replace("smtp_", ""),
                                .ConfigurationName = sectionName, .MailConfiguration = mc
                                }
                        emailList.Add(mailItem)
                    End If
                Next
            Next

            Return emailList

        End Function
    End Class
End Namespace