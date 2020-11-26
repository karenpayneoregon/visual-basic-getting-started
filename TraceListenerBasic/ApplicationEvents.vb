Imports LogLibrary
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Configuration.ConfigurationManager

Namespace My
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            ApplicationTraceListener.Instance.CreateLog(AppSettings("SidesListenerLogName"), AppSettings("SidesListenerName"))
            ApplicationTraceListener.Instance.WriteToTraceFile = True
        End Sub

        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
            ApplicationTraceListener.Instance.Close()
        End Sub
    End Class
End Namespace
