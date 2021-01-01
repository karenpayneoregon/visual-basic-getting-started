Imports ResolveLibrary

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim addressDetailList As New List(Of AddressDetail) From {
            New AddressDetail() With {.Host = "www.google.com"},
            New AddressDetail() With {.Host = "https://www.vbforums.com"},
            New AddressDetail() With {.Host = "https://www.BadAddressAttempt.com"},
            New AddressDetail() With {.Host = "stackoverflow.com"}
        }

        Try
            For index As Integer = 0 To addressDetailList.Count - 1

                addressDetailList(index).Address = Helpers.
                    ResolveIPAddressWithTimeout(addressDetailList(index).Host)
            Next

            addressDetailList.ForEach(Sub(item)
                                          If String.IsNullOrWhiteSpace(item.Address) Then
                                              Console.WriteLine($"{item.Host} (error or timeout)")
                                          Else
                                              Console.WriteLine($"{item.Host},[{item.Address}]")
                                          End If

                                      End Sub)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
