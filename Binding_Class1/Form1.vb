Imports System.ComponentModel

Public Class Form1
    Private _itemBindingList As New BindingList(Of Item)
    Private ReadOnly _itemBindingSource As New BindingSource
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim items = New List(Of Item) From {
                New Item() With {.Value1 = 100000000D, .Value2 = 100400000D},
                New Item() With {.Value1 = 200000000D, .Value2 = 200500000D},
                New Item() With {.Value1 = 300000000D, .Value2 = 300500000D}}

        _itemBindingList = New BindingList(Of Item)(items)
        _itemBindingSource.DataSource = _itemBindingList

        BindingNavigator1.BindingSource = _itemBindingSource

        Dim b As Binding = New Binding("Text", _itemBindingSource, "Value1")
        AddHandler b.Format, AddressOf FormatDouble
        Value1TextBox.DataBindings.Add(b)

        b = New Binding("Text", _itemBindingSource, "Value2")
        AddHandler b.Format, AddressOf FormatDouble
        Value2TextBox.DataBindings.Add(b)

    End Sub

    Private Sub FormatDouble(sender As Object, e As ConvertEventArgs)

        If e.DesiredType IsNot GetType(String) Then
            Exit Sub
        End If

        e.Value = CType(e.Value, Double).ToString("N1")

    End Sub
End Class