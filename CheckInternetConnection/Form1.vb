Imports System.Net

''' <summary>
''' One timer, one status strip with a label
''' </summary>
Public Class Form1

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        InternetStatusLabel.Text = "Internet"

        AddHandler Utilities.OnSettingChangedEvent, AddressOf InternetPoll

    End Sub

    Private Sub InternetPoll(status As Boolean)

        InternetStatusLabel.Text = $"Internet is {If(status, "Ready", "Offline")}"

        If status Then
            BackColor = Nothing
            AddressListBox.DataSource = Utilities.AddressList
        Else
            AddressListBox.DataSource = Nothing
            BackColor = Color.Red
            ListBox1.Items.Add(Now.ToShortTimeString())
        End If
    End Sub

    Private Async Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Await Utilities.IsInternetAvailable1()
    End Sub
End Class
''' <summary>
''' Place this in a class file
''' </summary>
Public Class Utilities
    Public Delegate Sub OnCheckStatusDelegate(status As Boolean)
    ''' <summary>
    ''' Callback which can work with results from IsInternetAvailable
    ''' </summary>
    Public Shared Event OnSettingChangedEvent As OnCheckStatusDelegate

    Private Shared _AddressList As List(Of String)
    Public Shared ReadOnly Property AddressList As List(Of String)
        Get
            Return _AddressList
        End Get
    End Property


    ''' <summary>
    ''' Is internet available
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
    Public Shared Async Function IsInternetAvailable1() As Task

        Dim success As Boolean

        _AddressList = New List(Of String)

        Await Task.Run(
            Async Function()

                Await Task.Delay(100)

                Try
                    Dim ips As IPAddress() = Dns.GetHostEntry("microsoft.com").AddressList
                    For Each ip As IPAddress In ips
                        AddressList.Add(ip.ToString())
                    Next
                    success = True
                Catch ex As Exception
                    If ex.Message.Contains("No such host is known") Then
                        success = False
                    Else
                        success = False
                    End If

                End Try

            End Function)

        RaiseEvent OnSettingChangedEvent(success)

    End Function
End Class
