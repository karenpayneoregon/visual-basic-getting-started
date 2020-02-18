
Imports System
Imports System.ComponentModel
Imports System.Configuration

Namespace Classes
    Public Class AppConfiguration
        Public Shared Function ConfigSetting(Of T)(settingName As String) As T
            Dim value As Object = ConfigurationManager.AppSettings(settingName)
            Return CType(Convert.ChangeType(value, GetType(T)), T)
        End Function

        Public Shared Function ParseGeneric(Of T)(stringValue As String) As T
            Return CType(TypeDescriptor.GetConverter(GetType(T)).ConvertFromString(stringValue), T)
        End Function
        Public Shared Function GetConfigSetting(Of T)(stringValue As String) As T
            Return ParseGeneric(Of T)(ConfigurationManager.AppSettings(stringValue))
        End Function
        Public Shared Function ConvertOrDefault(Of T)(input As String) As T
            Try
                Dim converter = TypeDescriptor.GetConverter(GetType(T))
                Return CType(converter.ConvertFromString(input), T)
            Catch ex As Exception
                Return Nothing
            End Try
        End Function
        Public Shared Function TestMode() As Boolean
            Return ConfigSetting(Of Boolean)("TestMode")
        End Function
        Public Shared Function TestMode1() As Boolean
            Return GetConfigSetting(Of Boolean)("TestMode")
        End Function
        Public Shared Function DatabaseServer() As String
            Return ConfigurationManager.AppSettings("DatabaseServer")
        End Function
    End Class
End Namespace