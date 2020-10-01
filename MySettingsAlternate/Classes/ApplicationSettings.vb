Imports System.Configuration
Imports System.IO

Namespace Classes
    Public Class ApplicationSettings
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
                Exceptions.Write(e)
            End Try

            Return value

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

                ' ReSharper disable once AssignNullToNotNullAttribute
                Dim configFile = Path.Combine(applicationDirectoryName, $"{Reflection.Assembly.GetExecutingAssembly().GetName().Name}.exe.config")
                Dim configFileMap = New ExeConfigurationFileMap With {.ExeConfigFilename = configFile}
                Dim config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None)

                config.AppSettings.Settings(key).Value = value
                config.Save()

                ConfigurationManager.RefreshSection("appSettings")

            Catch e As Exception
                Exceptions.Write(e)
                success = False
            End Try

            Return success

        End Function
    End Class
End Namespace