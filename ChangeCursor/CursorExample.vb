Imports System.Threading

Public Class CursorExample
    Public Shared Sub Change()

        Task.Factory.StartNew(
            Sub()
                Windows.Application.Current.Dispatcher.Invoke(Sub() Mouse.OverrideCursor = Cursors.Wait)
                Try
                    Thread.Sleep(5000)
                Finally
                    Windows.Application.Current.Dispatcher.Invoke(Sub() Mouse.OverrideCursor = Nothing)
                End Try
            End Sub)

    End Sub
End Class