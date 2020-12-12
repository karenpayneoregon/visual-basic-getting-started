Public Class FixedSizeStack
    Inherits Stack

    Private MaxNumber As Integer
    Public Sub New(limit As Integer)
        MaxNumber = limit
    End Sub

    Public Overrides Sub Push(sender As Object)
        If Count < MaxNumber Then
            MyBase.Push(sender)
        End If
    End Sub
End Class