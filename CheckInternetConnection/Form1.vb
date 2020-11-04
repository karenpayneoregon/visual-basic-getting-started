Imports System.Net

Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        InternetStatusLabel.Text = "Internet"

        AddHandler Utilities.OnSettingChangedEvent, AddressOf InternetPoll
    End Sub

    Private Sub InternetPoll(status As Boolean)
        InternetStatusLabel.Text = $"Internet is {If(status, "Ready", "Offline")}"
    End Sub

    Private Async Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Await Utilities.IsInternetAvailable()
    End Sub
End Class
Public Class Utilities
    Public Delegate Sub OnCheckStatusDelegate(status As Boolean)
    Public Shared Event OnSettingChangedEvent As OnCheckStatusDelegate
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Shared Async Function IsInternetAvailable() As Task

        Dim success As Boolean

        Await Task.Run(
            Async Function()

                Await Task.Delay(100)

                Try
                    Dns.GetHostEntry("www.google.com")

                    success = True
                Catch ex As Exception
                    success = False
                End Try
            End Function)

        RaiseEvent OnSettingChangedEvent(success)



    End Function

End Class
