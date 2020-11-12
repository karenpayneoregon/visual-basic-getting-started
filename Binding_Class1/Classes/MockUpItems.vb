Namespace Classes

    Public Class MockUpItems
        Public Shared Function ItemsList() As List(Of Item)
            Return New List(Of Item) From {
                New Item() With {.Value1 = 100000000D, .Value2 = 100400000D},
                New Item() With {.Value1 = 200000000D, .Value2 = 200500000D},
                New Item() With {.Value1 = 300000000.9D, .Value2 = 300500000D}}
        End Function
    End Class
End Namespace