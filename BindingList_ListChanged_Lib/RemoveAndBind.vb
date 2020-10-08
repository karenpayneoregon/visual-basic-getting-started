Imports System.ComponentModel

Public Class RemoveAndBind(Of T)
    Inherits BindingList(Of T)

    Protected Overrides Sub RemoveItem(ByVal index As Integer)
        RaiseEvent FireBeforeRemove(Me,
            New ListChangedEventArgs(ListChangedType.ItemDeleted, index))
        MyBase.RemoveItem(index)
    End Sub

    Public Event FireBeforeRemove As EventHandler(Of ListChangedEventArgs)
End Class
