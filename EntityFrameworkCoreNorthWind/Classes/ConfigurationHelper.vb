Imports System.Configuration

Namespace Classes
    ''' <summary>
    ''' Get database server and default catalog from app.config
    ''' </summary>
    Public Class ConfigurationHelper

        Private Shared Function GetAppSetting(config As Configuration, key As String) As String

            Dim element As KeyValueConfigurationElement = config.AppSettings.Settings(key)

            If element IsNot Nothing Then
                Dim value As String = element.Value
                If Not String.IsNullOrWhiteSpace(value) Then
                    Return value
                End If
            End If

            Return ""

        End Function

        Public ReadOnly Property ConnectionString() As String
            Get

                Dim config As Configuration = Nothing
                Dim exeConfigPath As String = Me.GetType().Assembly.Location
                Try
                    config = ConfigurationManager.OpenExeConfiguration(exeConfigPath)
                Catch ex As Exception
                End Try

                If config IsNot Nothing Then
                    Return $"Data Source={GetAppSetting(config, "DatabaseServer")};" &
                           $"Initial Catalog={GetAppSetting(config, "DefaultCatalog")};" &
                           "Integrated Security=True"
                Else
                    Return ""
                End If
            End Get
        End Property
    End Class
End Namespace