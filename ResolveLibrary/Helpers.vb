Imports System.Net

Public Class Helpers

    Private Shared Function ResolveIpAddressAsync(hostName As String) As Task(Of IPAddress)

        Return Task.Run(Async Function()
                            Try
                                Dim entry As IPHostEntry = Await Dns.GetHostEntryAsync(hostName)
                                Return entry.AddressList(0)

                            Catch ex As Exception
                                Return Nothing
                            End Try

                        End Function)
    End Function

    Public Shared Function ResolveIPAddressWithTimeout(
          hostNameOrIpAddress As String,
          Optional timeOutValue As Double = 3.0) As String

        hostNameOrIpAddress = hostNameOrIpAddress.Replace("https://", "")

        Dim timeout = TimeSpan.FromSeconds(timeOutValue)

        Try

            Dim task As Task(Of IPAddress) = ResolveIpAddressAsync(hostNameOrIpAddress)

            If Not task.Wait(timeout) Then
                Throw New TimeoutException()
            End If

            Return task.Result.ToString()

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

End Class
